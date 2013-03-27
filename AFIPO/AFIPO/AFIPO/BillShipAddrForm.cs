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
    public partial class BillShipAddrForm : Form
    {
        
        private String FormMode;
        private int cID;
        private int ShipID;
        private string[] cStates =   {  "AK","AL","AR","AZ","CA",  // 1 
                                        "CO","CT","DC","DE","FL",  // 2 
                                        "GA","HI","IA","ID","IL",  // 3 
                                        "IN","KS","KY","LA","MA",  // 4 
                                        "ME","MD","MI","MN","MO",  // 5 
                                        "MS","MT","NC","ND","NE",  // 6 
                                        "NH","NJ","NM","NV","NY",  // 7 
                                        "OH","OK","OR","PA","RI",  // 8 
                                        "SC","SD","TN","TX","UT",  // 9 
                                        "VA","VT","WA","WI","WV",  //10 
                                        "WY"};               //11 

        public BillShipAddrForm(ref CustBillShip CustBS, String Mode)
        {
            string[] AddrType ={ "Shipping", "Billing" };

            InitializeComponent();
            FormMode = Mode.ToUpper();
            cID = CustBS.CustomerID;
            if (FormMode == "NEW")
            {
                AddrType[0] = "Shipping";
                AddrType[1] = "Billing";
                button27.Text = "Save";
                comboBox1.DataSource = AddrType;
                comboBox19.DataSource = cStates;
            }
            else
            {
                ShipID = CustBS.ID;
                comboBox19.DataSource = cStates;
                Object2Form(CustBS);
                FormMode = "EDIT";
                button27.Text = "Modify";
            }
        }

        private void Object2Form(CustBillShip c)
        {
            string[] AddrType ={ "Shipping", "Billing" };
            if (c.AddressType.ToUpper() == "SHIPPING")
            {
                AddrType[0] = "Shipping";
                AddrType[1] = "Billing";
            }
            else
            {
                AddrType[0] = "Billing";
                AddrType[1] = "Shipping";
            }
            comboBox1.DataSource = AddrType;

            /*0 ID 
              1 Name 
              2 Type 
              3 Address1 
              4 Address2 
              5 City 
              6 State 
              7 ZIP*/
            textBox26.Text = c.Address1;
            textBox1.Text = c.Address2;
            textBox25.Text = c.AddressName;
            textBox27.Text = c.City;
            int Index = comboBox19.FindString(c.State);
            comboBox19.SelectedIndex = Index;
            textBox28.Text = c.Zip;
        }
        private CustBillShip Form2Object()
        {
            CustBillShip c = new CustBillShip(0,textBox25.Text,comboBox1.Text,textBox26.Text,textBox1.Text,textBox27.Text,comboBox19.Text,textBox28.Text,cID);
            return c;
        }
        private void button27_Click(object sender, EventArgs e)
        {
            //Save or Update
            BillShipList cBSList = new BillShipList(cID);
            if (FormMode == "NEW")
            {
                cBSList.AddCustBillShip(Form2Object());
            }
            else if (FormMode == "EDIT")
            {
                CustBillShip c = new CustBillShip();
                c = Form2Object();
                c.ID = ShipID;
                cBSList.UpdateCustBillShip(c);
            }
            this.Hide();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            BillShipList cBSList = new BillShipList(cID);
            if (FormMode == "EDIT")
            {
                cBSList.DeleteCustBillShip(ShipID);
            }
            //Delete
            this.Hide();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //Cancel
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}