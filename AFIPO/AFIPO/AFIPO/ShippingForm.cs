using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AFIObjects;

namespace AFIPO
{
    public partial class ShippingForm : Form
    {
        private CustomerList CustList;
        private PartsList PartList;
        private POList shipList;
        private POList openInv;
        private ShippersList Shippers;
        private string shipComment;

        public ShippingForm()
        {
            Shippers = new ShippersList();
            shipComment = "";
            shipList = new POList("INV");
            openInv = new POList("OPEN_INV");
            InitializeComponent();
            ShipViaCombo.DataSource = Shippers.ListShippers();
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Packing List Comment

            if (InvPOGrid.RowCount > 0)
            {
                InventoryCommentForm f5 = new InventoryCommentForm(shipComment,"Shipping Comment");
                f5.ShowDialog();
                shipComment = f5.Comment;
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillShipList BSList;
            Customer TCust = CustList.SearchCustomer(CustCombo.Text);
            BSList = new BillShipList(TCust.ID);
            BillToCombo.DataSource = BSList.ListBilling();
            
            AddrCombo.DataSource = BSList.ListShipping();
            
            custNamelbl.Text = TCust.CustName;
            PartList = new PartsList();

            PartCombo.DataSource = PartList.GetCustParts(TCust.ID);
            if (PartCombo.Items.Count == 0)
            {
                PartCombo.Text = "";
                ClearCount(sender, e);
                clearINVPOlist();
            }
           //Get ShipVia Box
        }

        private void ClearCount(object sender, EventArgs e)
        {
            //Put in logic to clear all totals
            ShippedQtyLbl.Text = "0";
            ShipOnHandQtyLbl.Text = "0";
            ShipInitRcvQty.Text = "0";
            BackOrderlbl.Text = "0";
            LastShipLbl.Text = "";
            ToShipTB.Text = "";
            TrackingTB.Text = "";
            BoxesTB.Text = "";
            CompanyNamelbl.Text = "";
            Addrlbl.Text = "";
            
        }

        private void comboBox4_Validated(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CustList = new CustomerList();
            CustCombo.DataSource = CustList.ListCustomers();
        }

        private void Int_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //Validate
            int QTS = 0;
            int ONH = 0;
            
            //Ship Button 
            string message = "";
            ONH = int.Parse(ShipOnHandQtyLbl.Text);
            QTS = int.Parse(ToShipTB.Text);

            if (QTS > ONH)
            {
                message = "Error: Total Entered Quantity exceeds total Quantity\n";
                MessageBox.Show(message, "Quantity Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdatePOShip(QTS,ONH);
                ClearCount(sender, e);
                clearINVPOlist();
                popinvlist();
                // If a PO is to be closed it will prompt the user 
                // that PO will be closed
            }
            
        }

        private void UpdatePOShip(int QTS,int ONH)
        {
            string DataGrid_PO = "";
            string DataGrid_POStat;
            int DataGrid_Inv = 0;
            int DataGrid_OnHand = 0;
            int DataGrid_ShipQuan = 0;
            int totalavqty = 0;
            int POID = 0;
            Shippers shipr = new Shippers();
            CustBillShip bill = new CustBillShip();
            CustBillShip ship = new CustBillShip();


            /* item.Cells[0].Value = po.PoNumber;
            item.Cells[1].Value = po.ReceiveDate;
            item.Cells[2].Value = po.InitialQty;
            item.Cells[3].Value = po.FabRejectQty;
            item.Cells[4].Value = po.PaintRejectQty;
            item.Cells[5].Value = po.InventoryQty;
            item.Cells[6].Value = po.ShippedQty;
            item.Cells[7].Value = po.Status;
            item.Cells[8].Value = po.Id;
            */

            int j = 0;
            while (j < InvPOGrid.RowCount)
            {
                if (QTS  != 0)
                {
                    POID = int.Parse(InvPOGrid.Rows[j].Cells[8].Value.ToString());
                    DataGrid_POStat = InvPOGrid.Rows[j].Cells[7].Value.ToString();
                    DataGrid_PO = InvPOGrid.Rows[j].Cells[0].Value.ToString();
                    DataGrid_Inv = int.Parse(InvPOGrid.Rows[j].Cells[5].Value.ToString());
                    DataGrid_OnHand = int.Parse(InvPOGrid.Rows[j].Cells[9].Value.ToString());
                    DataGrid_ShipQuan = int.Parse(InvPOGrid.Rows[j].Cells[6].Value.ToString());
                    if (DataGrid_Inv <= QTS)
                    {
                        DataGrid_ShipQuan = DataGrid_ShipQuan + DataGrid_Inv;
                        QTS = QTS - DataGrid_Inv;
                        DataGrid_Inv = 0;
                        DataGrid_OnHand = DataGrid_OnHand - DataGrid_ShipQuan;
                        if (DataGrid_POStat != "OPEN_INV")
                        {
                            DataGrid_POStat = "SHIPPED";
                        }
                    }
                    else
                    {
                        DataGrid_ShipQuan = DataGrid_ShipQuan + QTS;
                        DataGrid_Inv = DataGrid_Inv - QTS;
                        DataGrid_OnHand = DataGrid_OnHand - QTS;
                        QTS = 0;
                    }

                    int CustID;
                    Customer TCust = CustList.SearchCustomer(CustCombo.Text);
                    CustID = TCust.ID;
                    BillShipList BSList;
                    BSList = new BillShipList(TCust.ID);

                    InvPOGrid.Rows[j].Cells[6].Value = DataGrid_ShipQuan.ToString();
                    InvPOGrid.Rows[j].Cells[5].Value = DataGrid_Inv.ToString();
                    string RcvDate = InvPOGrid.Rows[j].Cells[1].Value.ToString();
                    shipr = Shippers.SearchShipper(ShipViaCombo.Text);
                    bill = BSList.SearchBillShip(BillToCombo.Text, "Billing");
                    ship = BSList.SearchBillShip(BillToCombo.Text, "Shipping");
                    if (bill.AddressName == "")
                    {
                        bill.ID = 0;
                    }
                    if (ship.AddressName == "")
                    {
                        ship.ID = 0;
                    }
                    if (bill.ID == 0)
                    {
                        bill.ID = ship.ID;
                    }
                    if (ship.ID == 0)
                    {
                        ship.ID = bill.ID;
                    }
                        
                    shipList.ShipPO(DataGrid_PO, CustID, PartCombo.Text, RcvDate, TrackingTB.Text, shipComment, DataGrid_ShipQuan,
                                    ship.ID, DataGrid_Inv, DataGrid_OnHand, DataGrid_POStat,bill.ID);
                    shipList.CreateShipmentRecord(CustID, PartCombo.Text, DataGrid_ShipQuan, POID, TrackingTB.Text,
                                                  ship.ID, bill.ID, shipr.ID);
                    //Update Database
                }
                j++;

                totalavqty = totalavqty + DataGrid_Inv;
            }
        }




        private void ToShipTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCount(sender, e);
            clearINVPOlist();
            popinvlist();
            Part TPart;
            TPart = PartList.SearchPart(PartCombo.Text.ToString());
            ShipColorLbl.Text = TPart.ColorName;
           
            
        }

        private void popinvlist()
        {
            
            int CustID;
            string PartNum;
            ShipTotals st = new ShipTotals();
            shipList = new POList("INV");
            openInv = new POList("OPEN_INV");
            Customer TCust = CustList.SearchCustomer(CustCombo.Text);
            CustID = TCust.ID;
            PartNum = PartCombo.Text;
            foreach (PO po in shipList.GetMatchingPOs(CustID, PartNum))
            {
                st.AddPO(po);
                PopGrid(po);
            }
            foreach (PO po in openInv.GetMatchingPOs(CustID, PartNum))
            {
                st.AddPO(po);
                PopGrid(po);
            }
            ShippedQtyLbl.Text = st.ShippedQty.ToString();
            ShipOnHandQtyLbl.Text = st.OnHandQty.ToString();
            ShipInitRcvQty.Text = st.InitRcvQty.ToString();
            BackOrderlbl.Text = st.BackOrderQty.ToString();
            LastShipLbl.Text = "";
            
        }

        private void PopGrid(PO po)
        {
            DataGridViewRow item = new DataGridViewRow();

            item.CreateCells(InvPOGrid);
            item.Cells[0].Value = po.PoNumber;
            item.Cells[1].Value = po.ReceiveDate;
            item.Cells[2].Value = po.InitialQty;
            item.Cells[3].Value = po.FabRejectQty;
            item.Cells[4].Value = po.PaintRejectQty;
            item.Cells[5].Value = po.InventoryQty;
            item.Cells[6].Value = po.ShippedQty;
            item.Cells[7].Value = po.POStatus;
            item.Cells[8].Value = po.Id;
            item.Cells[9].Value = po.OnHandQty;
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
            if (item.Cells[6].Value.ToString() == "")
            {
                item.Cells[6].Value = "0";
            }
            
            InvPOGrid.Rows.Add(item);
       
        }

        private void clearINVPOlist()
        {
            int i;
            try
            {
                i = InvPOGrid.RowCount - 1;
                while (InvPOGrid.RowCount > 0)
                {
                    InvPOGrid.Rows.RemoveAt(i);
                    i--;
                }
            }
            catch (Exception ex)
            { }
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ship_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}