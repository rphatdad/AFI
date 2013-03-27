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
    public partial class ReceivingForm : Form
    {
        private CustomerList CustList;
        private PartsList PartList;
        private POList POL;
        private int cid;

        public ReceivingForm()
        {
            InitializeComponent();
        }

        private PO Form2Object()
        {
            Customer TCust = CustList.SearchCustomer(CustCombo.Text);
            string hotpart ="N";
            if(HotPartCB.Checked)
            {
                hotpart ="Y";
            }
            PO po = new PO(PoNum.Text,TCust.ID,PartCombo.Text,Tracking.Text,RcvDate.Value,hotpart,Colorlbl.Text,int.Parse(InitQty.Text),RcvComments.Text);
            po.OnHandQty = po.InitialQty;
            return po;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Save
            if ((PoNum.Text != "") && (InitQty.Text != ""))
            {
                PO tPO = Form2Object();
                if (cid == 0)
                {
                    POL.AddPO(tPO);
                    PO tPO2 = new PO();
                    tPO2 = POL.FindPO(tPO.CustomerID, tPO.PartNumber, tPO.ReceiveDate, tPO.PoNumber);
                    cid = tPO.Id;
                }
                else
                {

                    tPO.Id = cid;
                    POL.UpdatePO(tPO);
                }
                MessageBox.Show("PO has Been Saved");
                ClearRcv(sender, e);
            }
            else
            {
                MessageBox.Show("Must have PO Number and Inital Quantity");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Call New Part
            PartsForm f = new PartsForm();
            f.ShowDialog();
            ClearRcv(sender, e);
            Form3_Load(sender, e);

        }

        private void CustCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer TCust = CustList.SearchCustomer(CustCombo.Text);
            custNameLbl.Text = TCust.CustName;
            PartList = new PartsList();

            PartCombo.DataSource = PartList.GetCustParts(TCust.ID);
            if (PartCombo.Items.Count == 0)
            {
                ClearRcv(sender, e);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            CustList = new CustomerList();
            CustCombo.DataSource = CustList.ListCustomers();
            Customer TCust = CustList.SearchCustomer(CustCombo.Text);
            custNameLbl.Text = TCust.CustName;
            PartList = new PartsList();
            PartCombo.DataSource = PartList.GetCustParts(TCust.ID);
            POL = new POList();
            cid = 0;
    
        }
        private void ClearRcv(object sender, EventArgs e)
        {
            PoNum.Text = "";
            InitQty.Text = "";
            Tracking.Text = "";
            RcvComments.Text = "";
            Colorlbl.Text = "";
            HotPartCB.Checked = false;
            RcvDate.Value = System.DateTime.Now;
            //Form3_Load(sender, e);
        }

        private void PartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearRcv(sender,e);
            Part TPart;
            TPart = PartList.SearchPart(PartCombo.Text.ToString());
            Colorlbl.Text = TPart.ColorName; 
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            Customer TCust = CustList.SearchCustomer(CustCombo.Text);
            if (PartCombo.Items.Count > 0)
            {
                POSelForm SelectionDlg = new POSelForm(PartCombo.SelectedItem.ToString(), TCust.ID, CustCombo.Text);
                SelectionDlg.ShowDialog();
                if (SelectionDlg.rcvPO == null)
                {
                    SelectionDlg.Close();
                    SelectionDlg.Dispose();
                    cid = 0;
                }
                else
                {
                    cid = SelectionDlg.rcvPO.Id;
                    Colorlbl.Text = SelectionDlg.rcvPO.Color;
                    RcvComments.Text = SelectionDlg.rcvPO.RcvComment;
                    PoNum.Text = SelectionDlg.rcvPO.PoNumber;
                    InitQty.Text = SelectionDlg.rcvPO.InitialQty.ToString();
                    RcvDate.Value = SelectionDlg.rcvPO.ReceiveDate;
                    Tracking.Text = SelectionDlg.rcvPO.TrackingNumber;
                    if (SelectionDlg.rcvPO.HotPart == "Y")
                    {
                        HotPartCB.Checked = true;
                    }
                    else
                    {
                        HotPartCB.Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Customer Must have at least one part assigned, Use Add Part Button!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearRcv(sender,e);
            Form3_Load(sender, e);
            cid = 0;
        }

        private void RcvComments_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete
            //Find PO if null message box if not delete it
            DialogResult result = MessageBox.Show("Are you sure you want to delete the current PO? " +
                    "Doing so will also perminately delete the PO from the database.",
                    "PO Delete?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

            if (result == DialogResult.Yes)
            {
               
                if (cid == 0)
                {
                    MessageBox.Show("Can not delete Item it was never saved");
                }
                else
                {
                    POL.DeletePO(cid);
                    ClearRcv(sender,e);
                }
            }

        }

        private void Int_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Router
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitQty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}