using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AFIObjects;

namespace AFIPO
{
    public partial class CustomerMaintForm : Form
    {
        private CustomerList CustList;
        public CustomerMaintForm()
        {
            InitializeComponent();
        }
        //ADD NEW Shipping Address
        private void button68_Click(object sender, EventArgs e)
        {
            //Add A New Shipping or Billing Address 
            //Saves Current Customer
            button27_Click(sender, e);
            //Creates a new BillShip calls the form2 to edit further
            Customer c1 = CustList.SearchCustomer(CustIDcombo.Text);
            CustBillShip cBS = new CustBillShip(c1.ID);
            //Add Address form
            BillShipAddrForm f = new BillShipAddrForm(ref cBS, "NEW");
            f.ShowDialog();
            LoadBillShip(c1.ID);
            //poplist();
        }
        //Delete A Shipping Address
        private void button70_Click(object sender, EventArgs e)
        {
            // Delete Address
            if (dataGridView5.SelectedCells.Count > 0)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete the current Address? " +
                    "Doing so will also delete the  selected BillTo or ShipTo Address.",
                    "Delete Address?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string strAddrName;
                        string strAddrType;
                        
                        strAddrName = dataGridView5.SelectedCells[0].Value.ToString();
                        strAddrType = dataGridView5.SelectedCells[1].Value.ToString();
                        Customer c1 = new Customer();
                        c1 = CustList.SearchCustomer(CustIDcombo.Text);
                        BillShipList cBSList = new BillShipList(c1.ID);
                        cBSList.DeleteCustBillShip(cBSList.SearchBillShip(strAddrName, strAddrType).ID);
                        LoadBillShip(c1.ID);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                }
            }
        }
    
            
        

        private void button26_Click(object sender, EventArgs e)
        {
            EditAddress();
        }
        private void EditAddress()
        {
            try
            {
                DataGridViewRow item = dataGridView5.SelectedRows[0];
                String strAddrName = item.Cells[0].Value.ToString(); ;
                String strAddrType = item.Cells[1].Value.ToString();
                
                Customer c1 = CustList.SearchCustomer(CustIDcombo.Text);
                BillShipList cBSList = new BillShipList(c1.ID);
                if (cBSList.BillShipExists(strAddrName, strAddrType))
                {
                    CustBillShip c2 = cBSList.SearchBillShip(strAddrName, strAddrType);
                    BillShipAddrForm f2 = new BillShipAddrForm(ref c2, "EDIT");
                    f2.ShowDialog();
                    LoadBillShip(c1.ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Edit Address " + ex.Message);
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            //Save Customer
            try
            {
                //Save for Customer
                if (CustIDcombo.Text != "")
                {
                    if (CustList.CustInDB(CustIDcombo.Text))
                    {
                        CustList.UpdateCustomer(Form2Object());
                    }
                    else
                    {
                        CustList.AddCustomer(Form2Object());
                    }
                    //CustIDcombo.DataSource = CustList.ListCustomers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //Delete Customer
            if (CustIDcombo.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the current Customer? " +
                    "Doing so will also perminately delete the Customer from the database.",
                    "Delete Customer?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Customer c1 = new Customer();
                        c1 = CustList.SearchCustomer(CustIDcombo.Text);
                        DeleteAllBillShip(c1.ID);
                        CustList.DeleteCust(CustIDcombo.Text);
                        CustIDcombo.DataSource = CustList.ListCustomers();

                        if (CustIDcombo.Items.Count == 0)
                        {
                            textBox24.Text = "";
                            textBox5.Text = "";
                            textBox19.Text = "";
                            textBox100.Text = "";
                            textBox101.Text = "";
                            textBox103.Text = "";
                            CustIDcombo.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //Cancel
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustList = new CustomerList();
            CustIDcombo.DataSource = CustList.ListCustomers();
        }

        private void CustIDcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c1 = CustList.SearchCustomer(CustIDcombo.Text);
            Object2Form(c1);
        }

        private void CustIDcombo_Validated(object sender, EventArgs e)
        {
            try
            {
                // If it is there then have it fill in fields
                if (CustList.CustExists(CustIDcombo.Text))
                {
                    Customer c1 = CustList.SearchCustomer(CustIDcombo.Text);
                    CustIDcombo.DataSource = CustList.ListCustomers();
                    Object2Form(c1);
                    
                }
                // If not have it add item and then fill field from it;
                else
                {
                    Customer c2 = CustList.SearchCustomer(CustIDcombo.Text);
                    CustList.AddItem(CustIDcombo.Text);
                    CustIDcombo.DataSource = CustList.ListCustomers();
                    Object2Form(c2);
                }
                textBox24.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AlreadyHere " + ex.Message);
            }
        }

        private Customer Form2Object()
        {
            Customer tCust = new Customer(0, CustIDcombo.Text, textBox24.Text, textBox5.Text, textBox19.Text, textBox100.Text, textBox101.Text, textBox103.Text);
            return tCust;
        }

        private void Object2Form(Customer c)
        {
            int Index = CustIDcombo.FindString(c.CustShortName);
            CustIDcombo.SelectedIndex = Index;
            textBox24.Text = c.CustName;
            textBox5.Text = c.Phone1;
            textBox19.Text =c.Phone2;
            textBox100.Text = c.Fax;
            textBox101.Text = c.Email;
            textBox103.Text = c.ContactName;
            LoadBillShip(c.ID);
        }

        private void LoadBillShip(int cID)
        {
            BillShipList cBSList = new BillShipList(cID);
            clearlist();
            if (cID != 0)
            {
                cBSList = new BillShipList(cID);
                foreach(CustBillShip c in cBSList.GetCustBillShip())
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dataGridView5);
                    item.Cells[0].Value = c.AddressName;
                    item.Cells[1].Value = c.AddressType;
                    dataGridView5.Rows.Add(item);
                }
            }
           
        }

        private void clearlist()
        {
            int i;
            i = dataGridView5.RowCount - 1;
            while (dataGridView5.RowCount > 0)
            {
                dataGridView5.Rows.RemoveAt(i);
                i--;
            }
        }


        private void DeleteAllBillShip(int cID)
        {
            try
            {
                BillShipList cBSList = new BillShipList(cID);
                ArrayList delList = new ArrayList();
                foreach (CustBillShip c in cBSList.GetCustBillShip())
                {
                    delList.Add(c.ID);
                }
                foreach (int i in delList)
                {
                    cBSList.DeleteCustBillShip(i);
                }
                clearlist();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView5_DoubleClick(object sender, EventArgs e)
        {
            EditAddress();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}