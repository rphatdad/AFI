using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AFI
{
    
    public partial class Form2 : Form
    {
        private int CustID;
        private int ShipID;
        private String FormMode;
        private String EditState;
        public Form2(int custID,String Mode)
        {
            string[] AddrType ={ "Shipping", "Billing" };
            InitializeComponent();
            CustID = custID;
            FormMode = Mode.ToUpper();
            if (FormMode == "NEW")
            {
                AddrType[0] ="Shipping";
                AddrType[1] ="Billing";
                button27.Text = "Save";
                
                comboBox1.DataSource = AddrType;

            }
            else
            {
                    /*0 ID 
                      1 Name 
                      2 Type 
                      3 Address1 
                      4 Address2 
                      5 City 
                      6 State 
                      7 ZIP*/
                String[] Dataxfer;
                Dataxfer = Mode.Split('~');
                ShipID = int.Parse(Dataxfer[0]);
                if (Dataxfer[2].ToUpper() == "SHIPPING")
                {
                    AddrType[0] ="Shipping";
                    AddrType[1] ="Billing";
                }
                else
                {
                    AddrType[0] = "Billing";
                    AddrType[1] = "Shipping";
                }
                comboBox1.DataSource = AddrType;
                textBox26.Text = Dataxfer[3];
                textBox1.Text = Dataxfer[4];
                textBox25.Text = Dataxfer[1];
                textBox27.Text = Dataxfer[5];
                EditState = Dataxfer[6]; 
                //comboBox19.SelectedValue = Dataxfer[6]; 
          
                textBox28.Text = Dataxfer[7];
                FormMode = "EDIT";
                button27.Text = "Modify";
            }
        }
      
        private void button29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.statesTableAdapter1.Fill(afiPartsDataSet1.STATES);
            if (FormMode == "EDIT")
            {
                button28.Show();
                comboBox19.SelectedIndex = comboBox19.FindStringExact(EditState);
            }
            else
            {
                button28.Hide();
            }

        }
        
        private void SaveAction()
        {
            //afiPartsDataSet1.CustBillShipAddr.AddCustBillShipAddrRow(99, textBox25.Text, comboBox1.SelectedText, textBox26.Text, textBox1.Text, textBox27.Text, comboBox19.SelectedText, textBox28.Text);
            BillShipBindingSource.EndEdit();
            int result;
            result = custBillShipAddrTableAdapter1.Insert(textBox25.Text, comboBox1.Text, textBox26.Text, textBox1.Text, textBox27.Text, comboBox19.Text, textBox28.Text,CustID);
            this.Hide(); 
  
        }
        private void UpdateAction()
        {
            try
            {
                int result;

                SqlConnection sqlConnection1 = new SqlConnection(custBillShipAddrTableAdapter1.Connection.ConnectionString);
                SqlCommand cmd = new SqlCommand();
                
                cmd.CommandText = "UPDATE CustBillShipAddr Set ADDRESSNAME ='" +textBox25.Text  +"',ADDRESSTYPE = '"+ comboBox1.Text +"',ADDRESS1= '"+ textBox26.Text +"',ADDRESS2= '"+textBox1.Text +"',CITY= '"+ textBox27.Text +"',STATE ='"+ comboBox19.Text+ "',ZIP ='"+ textBox28.Text+ "' WHERE ID ='" + ShipID+ "'"; 
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();

                result = cmd.ExecuteNonQuery();
               

                // Data is accessible through the DataReader object here.

                sqlConnection1.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("in UpdateAction " + ex.Message);
            }
        }

        private void DeleteAction()
        {
            try
            {
                int result;

                SqlConnection sqlConnection1 = new SqlConnection(custBillShipAddrTableAdapter1.Connection.ConnectionString);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Delete from CustBillShipAddr WHERE ID ='" + ShipID + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();

                result = cmd.ExecuteNonQuery();

                // Data is accessible through the DataReader object here.

                sqlConnection1.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("in DeleteAction " + ex.Message);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {

                if (FormMode == "NEW")
                {
                    SaveAction();
                }
                else if (FormMode == "EDIT")
                {
                    UpdateAction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("in button27 " + ex.Message);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            DeleteAction();
        }

    }
}