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
    public partial class DotCapPlugEditForm : Form
    {
        private MaskTypeList mlist;

        public DotCapPlugEditForm()
        {
            InitializeComponent();
            mlist = new MaskTypeList();

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

                foreach (MaskType mt in mlist.GetAllMask())
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dataGridView1);
                    item.Cells[0].Value = mt.Type;
                    item.Cells[1].Value = mt.Description;
                    item.Cells[2].Value = mt.ID.ToString();
                    dataGridView1.Rows.Add(item);
                    count++;
                }
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex " + ex.Message);
                return count;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Add
            DotCapPlugEntryForm f1 = new DotCapPlugEntryForm();
            f1.ShowDialog();
            clearlist();
            poplist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Modify

            string strType;
            int ID;
            string strDescription;
            DotCapPlugEntryForm f1;

            strType = dataGridView1.SelectedCells[0].Value.ToString();
            strDescription = dataGridView1.SelectedCells[1].Value.ToString();
            ID = int.Parse(dataGridView1.SelectedCells[2].Value.ToString());
            f1 = new DotCapPlugEntryForm(ID, strDescription, strType);
            f1.ShowDialog();
            clearlist();
            poplist();   
        }

        private void DotCapPlugEditForm_Load(object sender, EventArgs e)
        {
            if (poplist() == 0)
            {
                MessageBox.Show("No Masks found Please Select Add!");
       
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete
            if (dataGridView1.SelectedCells.Count > 0)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete the current Mask? " 
                    ,"Delete Mask?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string strType;
                        int ID;
                        string strDescription;


                        strType = dataGridView1.SelectedCells[0].Value.ToString();
                        strDescription = dataGridView1.SelectedCells[1].Value.ToString();
                        ID = int.Parse(dataGridView1.SelectedCells[2].Value.ToString());
                        mlist.DeleteMaskType(ID);
                        clearlist();
                        poplist();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Cancel Button
            this.Close();
        }
    }
}