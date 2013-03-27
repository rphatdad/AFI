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
using AFIObjects;

namespace AFIPO
{
    public partial class POSelForm : Form
    {
        private int CustID;
        private string PartNum;
        public PO rcvPO;
        private POList pList;
        private CustomerList cList;

        public POSelForm(string partno, int custid,string cname)
        {
            cList = new CustomerList();
            CustID =custid;
            PartNum = partno;
            InitializeComponent();
            pList = new POList("OPEN");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow item = dataGridView1.SelectedRows[0];
            String PONum = item.Cells[0].Value.ToString();
            DateTime rcv = DateTime.Parse(item.Cells[2].Value.ToString());
            rcvPO = pList.FindPO(CustID, PartNum, rcv, PONum);
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
      
                foreach (PO po in pList.GetMatchingPOs(CustID,PartNum))
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dataGridView1);
                    item.Cells[0].Value = po.PoNumber;
                    item.Cells[1].Value = po.PartNumber;
                    item.Cells[2].Value = po.ReceiveDate;
                    dataGridView1.Rows.Add(item);
                    count++;
                }
                return count;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ex " + ex.Message);
                return count; }
        }

        private void Form6_Load(object sender, EventArgs e)
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