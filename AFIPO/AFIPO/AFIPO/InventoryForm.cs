using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AFIObjects;

namespace AFIPO
{
    public partial class InventoryForm : Form
    {
        private CustomerList CustList;
        private PartsList PartList;
        private POList POL;
        private string invComment;
        private POList openList;
        private POList openInv;
        
            
        public InventoryForm()
        {
            invComment = "";
            openList = new POList("OPEN");
            openInv = new POList("OPEN_INV");
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (OpenPOGrid.RowCount > 0)
            {
                InventoryCommentForm f5 = new InventoryCommentForm(invComment,"Inventory Comment");
                f5.ShowDialog();
                invComment = f5.Comment;
               // EditInvComment();
                //button10_Click(sender, e);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CustList = new CustomerList();
            CustCombo.DataSource = CustList.ListCustomers();
            Customer TCust = CustList.SearchCustomer(CustCombo.Text);
            custNameLbl.Text = TCust.CustName;
            PartList = new PartsList();
            PartCombo.DataSource = PartList.GetCustParts(TCust.ID);
            POL = new POList();
           
        }

        private void Int_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CustCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer TCust = CustList.SearchCustomer(CustCombo.Text);
            custNameLbl.Text = TCust.CustName;
            PartList = new PartsList();

            PartCombo.DataSource = PartList.GetCustParts(TCust.ID);
            if (PartCombo.Items.Count == 0)
            {
                ClearCount(sender, e);
            }
        }


        private void ClearCount(object sender, EventArgs e)
        {
            invTB.Text = "";
            fabRejTB.Text = "";
            paintRjTB.Text = "";
            TquanAvail.Text = "0";
            //ClearOpenPO's
            clearOpenPOlist();
            //Form3_Load(sender, e);
        }

        private void PartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCount(sender, e);
            clearOpenPOlist();
            popinvlist();
        }


        private void clearOpenPOlist()
        {
            int i;
            try
            {
                i = OpenPOGrid.RowCount - 1;
                while (OpenPOGrid.RowCount > 0)
                {
                    OpenPOGrid.Rows.RemoveAt(i);
                    i--;
                }
            }
            catch (Exception ex)
            { }
        }

        private void popinvlist()
        {
            int totalavqty = 0;
            int CustID;
            string PartNum;
            openList = new POList("OPEN");
            openInv = new POList("OPEN_INV");
            Customer TCust = CustList.SearchCustomer(CustCombo.Text);
            CustID = TCust.ID;
            PartNum = PartCombo.Text;
            foreach (PO po in openList.GetMatchingPOs(CustID, PartNum))
            {
                totalavqty += PopGrid(po);
            }
            foreach (PO po in openInv.GetMatchingPOs(CustID, PartNum))
            {
                totalavqty += PopGrid(po);
            }
            TquanAvail.Text = totalavqty.ToString();
        }


        private int PopGrid(PO po)
        {
            int totalavqty = 0;

            DataGridViewRow item = new DataGridViewRow();

            item.CreateCells(OpenPOGrid);
           
            item.Cells[0].Value = po.PoNumber;
            item.Cells[1].Value = po.ReceiveDate;
            item.Cells[2].Value = po.InventoryQty;
            item.Cells[3].Value = po.PaintRejectQty;
            item.Cells[4].Value = po.FabRejectQty;
            item.Cells[5].Value = po.OnHandQty;
            item.Cells[6].Value = po.InvComment;
            if (item.Cells[2].Value.ToString() == "")
            {
                item.Cells[2].Value = "0";
            }
            if (item.Cells[3].Value.ToString() == "")
            {
                item.Cells[3].Value = "0";
            }
            if (item.Cells[4].Value.ToString() == "")
            {
                item.Cells[4].Value = "0";
            }
            if (item.Cells[5].Value.ToString() == "")
            {
                item.Cells[5].Value = "0";
            }
            if (item.Cells[6].Value.ToString() != "")
            {
                item.Cells[7].Value = "*";
            }
            else
            {
                item.Cells[7].Value = "";
            }
            totalavqty = totalavqty + int.Parse(item.Cells[5].Value.ToString());
            OpenPOGrid.Rows.Add(item);

            return totalavqty;
        }

        private void OpenPOGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //To Inv Button
            int totalqty = 0;
            int qtytoinv = 0;
            int fabreject = 0;
            int paintreject = 0;

            totalqty = int.Parse(TquanAvail.Text);
            if (invTB.Text != "")
            {
                qtytoinv = int.Parse(invTB.Text);
            }
            if (fabRejTB.Text != "")
            {
                fabreject = int.Parse(fabRejTB.Text);
            }
            if (paintRjTB.Text != "")
            {
                paintreject = int.Parse(paintRjTB.Text);
            }
             if (VerifyInv(totalqty,qtytoinv,fabreject,paintreject))
            {
                int TotalInvUsed = qtytoinv + fabreject;
                UpdatePOInv(totalqty, qtytoinv, fabreject, paintreject);
                MessageBox.Show("Inventory has been updated!");
                ClearCount(sender, e);
                clearOpenPOlist();
                popinvlist();
            }
        }


        private bool VerifyInv(int TQ, int QI, int FR, int PR)
        {
            bool failure = true;
            string message="";
            if ((QI + FR + PR) > TQ )
            { 
                message = "Error: Total Entered Quantity exceeds total Quantity\n";
                failure = false;
            }
            if(QI > TQ )
            {
                message = message + "       Quantity To Inventory exceeds total Quantity\n";
                failure = false;
            }
            if (FR > TQ)
            {
                message = message + "       Fab Reject Quantity exceeds total Quantity\n";
                failure = false;
            }
            if (PR > TQ)
            {
                message = message + "       Paint Reject Quantity exceeds total Quantity\n";
                failure = false;
            }
            if (!failure)
            {
                MessageBox.Show(message, "Quantity Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return failure;

        }


        private void UpdatePOInv(int TQ, int IQ, int FR, int PR)
        {
            string DataGrid_PO = "";
          
            int DataGrid_OnHand = 0;
            int DataGrid_FabR = 0;
            int DataGrid_PaintR = 0;
            int DataGrid_InvQuan = 0;
            int totalavqty = 0;
            String DataGrid_POStat;

            /* item.Cells[0].Value = reader["PONUMBER"];
             item.Cells[1].Value = reader["RECEIVEDATE"];
             item.Cells[2].Value = reader["INVENTORYQTY"];
             item.Cells[3].Value = reader["FABREJECTQTY"];
             item.Cells[4].Value = reader["PAINTREJECTQTY"];
             item.Cells[5].Value = reader["ONHANDQTY"];
             */

            int j = 0;
            while (j < OpenPOGrid.RowCount)
            {
                if (!((IQ == 0) && (FR == 0) && (PR == 0)))
                {
                    DataGrid_POStat = "OPEN";
                    DataGrid_PO = OpenPOGrid.Rows[j].Cells[0].Value.ToString();
                    DataGrid_InvQuan = int.Parse(OpenPOGrid.Rows[j].Cells[2].Value.ToString());
                    DataGrid_FabR = int.Parse(OpenPOGrid.Rows[j].Cells[4].Value.ToString());
                    DataGrid_PaintR = int.Parse(OpenPOGrid.Rows[j].Cells[3].Value.ToString());
                    DataGrid_OnHand = int.Parse(OpenPOGrid.Rows[j].Cells[5].Value.ToString());
                    if (DataGrid_OnHand <= IQ)
                    {
                        DataGrid_InvQuan = DataGrid_InvQuan + DataGrid_OnHand;
                        IQ = IQ - DataGrid_OnHand;
                        DataGrid_OnHand = 0;
                        DataGrid_POStat = "INV";
                    }
                    else
                    {
                        DataGrid_InvQuan = DataGrid_InvQuan + IQ;
                        DataGrid_OnHand = DataGrid_OnHand - IQ;
                        IQ = 0;
                        DataGrid_POStat = "OPEN_INV";
                    }

                    if (DataGrid_OnHand <= FR)
                    {
                        DataGrid_FabR = DataGrid_FabR + DataGrid_OnHand;
                        FR = FR - DataGrid_OnHand;
                        DataGrid_OnHand = 0;
                        DataGrid_POStat = "INV";
                    }
                    else
                    {
                        DataGrid_FabR = DataGrid_FabR + FR;
                        DataGrid_OnHand = DataGrid_OnHand - FR;
                        FR = 0;
                        DataGrid_POStat = "OPEN_INV";
                    }
                    // Paint Rejects not taken from onhand since need fixed
                    if (DataGrid_OnHand <= PR)
                    {
                        DataGrid_PaintR = DataGrid_PaintR + DataGrid_OnHand;
                        PR = PR - DataGrid_OnHand;

                    }
                    else
                    {
                        DataGrid_PaintR = DataGrid_PaintR + PR;
                        PR = 0;
                    }
                    int CustID;
                    Customer TCust = CustList.SearchCustomer(CustCombo.Text);
                    CustID = TCust.ID;
                    OpenPOGrid.Rows[j].Cells[2].Value = DataGrid_InvQuan.ToString();
                    OpenPOGrid.Rows[j].Cells[4].Value = DataGrid_FabR.ToString();
                    OpenPOGrid.Rows[j].Cells[3].Value = DataGrid_PaintR.ToString();
                    OpenPOGrid.Rows[j].Cells[5].Value = DataGrid_OnHand.ToString();
                    string RcvDate = OpenPOGrid.Rows[j].Cells[1].Value.ToString();

                    openList.UpdatePOInv(DataGrid_PO, CustID, PartCombo.Text, RcvDate, invComment,
                            int.Parse(DataGrid_InvQuan.ToString()), int.Parse(DataGrid_FabR.ToString()),
                            int.Parse(DataGrid_PaintR.ToString()), int.Parse(DataGrid_OnHand.ToString()),
                            DataGrid_POStat);

                    //Update Database
                }
                j++;

                totalavqty = totalavqty + DataGrid_OnHand;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}