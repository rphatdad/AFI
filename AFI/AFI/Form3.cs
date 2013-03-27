using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace AFI
{
    public partial class Form3 : Form
    {
        private int CustID;
        private string PartNum;
        public OpenPO rcvPO;

        public Form3(string partno, int custid)
        {
            CustID =custid;
            PartNum = partno;
            InitializeComponent();
            //clearlist();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow item = dataGridView1.SelectedRows[0];
            String PONum = item.Cells[0].Value.ToString();
            DateTime rcv = DateTime.Parse(item.Cells[2].Value.ToString());
            rcvPO = new OpenPO(CustID, PartNum, rcv, PONum);
            this.Hide();
        }

        private void clearlist()
        {
            int i;
            i = dataGridView1.RowCount - 1;
            while (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows.RemoveAt(i);
                i--;
            }
        }

        private int poplist()
        {
            int count = 0;
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["AFI.Properties.Settings.Database1ConnectionString"].ConnectionString;
            
                SqlConnection sqlConnection1 = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("SPGetOpenPOS", sqlConnection1);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@CUSTOMERID", SqlDbType.Int).Value = CustID;
                command.Parameters.Add("@PARTNUMBER", SqlDbType.VarChar).Value = PartNum;

                sqlConnection1.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dataGridView1);
                    item.Cells[0].Value = reader["PONUMBER"];
                    item.Cells[1].Value = reader["PARTNUMBER"];
                    item.Cells[2].Value = reader["RECEIVEDATE"];
                    dataGridView1.Rows.Add(item);
                    count++;
                }
                reader.Close();

                // Data is accessible through the DataReader object here.

                sqlConnection1.Close();
                return count;
            }
            catch (Exception ex)
            { return count; }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (poplist() == 0)
            {
                MessageBox.Show("No PO found matching search Criteria!");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}