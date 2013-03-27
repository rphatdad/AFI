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
    public partial class DotCapPlugForm : Form
    {
        private PartMaskLinkList pmList;
        private MaskTypeList mList = new MaskTypeList();
        private int partID;
        private string partNum;

        public DotCapPlugForm()
        {
            InitializeComponent();
        }
        public DotCapPlugForm(string PartNum, int PartID)
        {
            InitializeComponent();
            label5.Text = PartNum;
            partNum = PartNum;
            partID = PartID;
            pmList = new PartMaskLinkList(PartID);
            
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            UpdateDataGrid();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = mList.GetMaskbyType("Dot");
            comboBox2.DataSource = mList.GetMaskbyType("Cap");
            comboBox3.DataSource = mList.GetMaskbyType("Plug");
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


        private void LoadDataGrid()
        {
            foreach (PartMaskLink p in pmList.GetPartMaskLink())
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dataGridView1);
                item.Cells[0].Value = p.MaskDescription;
                item.Cells[1].Value = p.MaskQty;
                item.Cells[2].Value = p.MaskType;
                dataGridView1.Rows.Add(item);
            }
        }


        private void UpdateDataGrid()
        {
            clearlist();
            LoadDataGrid();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Add Dot
            if (validateString(textBox1.Text))
            {
                PartMaskLink p;
                // Is it an existing link?
                if (pmList.PartMaskLinkExist(comboBox1.Text, "Dot"))
                {
                    p = pmList.SearchPartMaskLink(comboBox1.Text, "Dot");
                    p.MaskQty += int.Parse(textBox1.Text);
                    pmList.UpdatePartMaskLink(p);
                }
                // New Link
                else
                {
                    p = new PartMaskLink(0, partNum, partID, comboBox1.Text, "Dot", int.Parse(textBox1.Text));
                    pmList.AddPartMaskLink(p);
                }
                pmList.reload();
                UpdateDataGrid();
                // Adds Dot To List.
                // Auto Updates 
                textBox1.Text = "0";
            }
            else
            {
                MessageBox.Show("Value Must Be numeric and Exceed 0");
                textBox1.Text = "0";
            }
            // Adds Dot To List.
            // Auto Updates 
        }

        private bool validateString(string p)
        {
            bool Result; 
            int num;
            Result = int.TryParse(p, out num);
            if (Result)
            {
                if (num > 0)
                {
                    return true;
                }
            }
            return false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Add Cap
            if (validateString(textBox2.Text))
            {
                PartMaskLink p;
                // Is it an existing link?
                if (pmList.PartMaskLinkExist(comboBox2.Text, "Cap"))
                {
                    p = pmList.SearchPartMaskLink(comboBox2.Text, "Cap");
                    p.MaskQty += int.Parse(textBox2.Text);
                    pmList.UpdatePartMaskLink(p);
                }
                // New Link
                else
                {
                    p = new PartMaskLink(0, partNum, partID, comboBox2.Text, "Cap", int.Parse(textBox2.Text));
                    pmList.AddPartMaskLink(p);
                }
                pmList.reload();
                UpdateDataGrid();
                // Adds Dot To List.
                // Auto Updates 
                textBox2.Text = "0";
            }
            else
            {
                MessageBox.Show("Value Must Be numeric and Exceed 0");
                textBox2.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (validateString(textBox3.Text))
            {
                PartMaskLink p;
                // Is it an existing link?
                if (pmList.PartMaskLinkExist(comboBox3.Text, "Plug"))
                {
                    p = pmList.SearchPartMaskLink(comboBox3.Text, "Plug");
                    p.MaskQty += int.Parse(textBox3.Text);
                    pmList.UpdatePartMaskLink(p);
                }
                // New Link
                else
                {
                    p = new PartMaskLink(0, partNum, partID, comboBox3.Text, "Plug", int.Parse(textBox3.Text));
                    pmList.AddPartMaskLink(p);
                }
                pmList.reload();
                UpdateDataGrid();
                // Adds Dot To List.
                // Auto Updates 
                textBox3.Text = "0";
            }
            else
            {
                MessageBox.Show("Value Must Be numeric and Exceed 0");
                textBox3.Text = "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Edit Dot Cap or Plug
            if (dataGridView1.SelectedCells.Count > 0)
            {
                try
                    {
                        string Desc;
                        int Qty;
                        string Type;

                        Desc = dataGridView1.SelectedCells[0].Value.ToString();
                        Qty = int.Parse(dataGridView1.SelectedCells[1].Value.ToString());
                        Type = dataGridView1.SelectedCells[2].Value.ToString();
                        PartMaskLink p1 = new PartMaskLink();
                        
                        p1 = pmList.SearchPartMaskLink(Desc, Type);
                        DotCapPlugQty f1 = new DotCapPlugQty(p1.MaskQty);
                        f1.ShowDialog();
                        p1.MaskQty = f1.newqty;
                        pmList.UpdatePartMaskLink(p1);
                        pmList.reload();
                        UpdateDataGrid();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Delete Dot Cap or Plug
            if (dataGridView1.SelectedCells.Count > 0)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete the current Dot, Cap, or Plug? " +
                    "Doing so will remove the Dot, Cap, or Plug from this Part.",
                    "Delete Dot, Cap, or Plug ?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string Desc;
                        int Qty;
                        string Type;

                        Desc = dataGridView1.SelectedCells[0].Value.ToString();
                        Qty = int.Parse(dataGridView1.SelectedCells[1].Value.ToString());
                        Type = dataGridView1.SelectedCells[2].Value.ToString();
                        PartMaskLink p1 = new PartMaskLink();

                        p1 = pmList.SearchPartMaskLink(Desc, Type);
                        pmList.DeletePartMaskLink(p1);
                        pmList.reload();
                        UpdateDataGrid();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Loop Thru Data Grid and Save all the Dot Cap Plugs
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Add Tape
            if (validateString(textBox5.Text))
            {
                PartMaskLink p;
                // Is it an existing link?
                if (pmList.PartMaskLinkExist(comboBox5.Text, "Tape"))
                {
                    p = pmList.SearchPartMaskLink(comboBox5.Text, "Tape");
                    p.MaskQty += int.Parse(textBox5.Text);
                    pmList.UpdatePartMaskLink(p);
                }
                // New Link
                else
                {
                    p = new PartMaskLink(0, partNum, partID, comboBox5.Text, "Tape", int.Parse(textBox5.Text));
                    pmList.AddPartMaskLink(p);
                }
                pmList.reload();
                UpdateDataGrid();
                // Adds Dot To List.
                // Auto Updates 
                textBox5.Text = "0";
            }
            else
            {
                MessageBox.Show("Value Must Be numeric and Exceed 0");
                textBox5.Text = "0";
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //Bag
            //Add Bag
            if (validateString(textBox4.Text))
            {
                PartMaskLink p;
                // Is it an existing link?
                if (pmList.PartMaskLinkExist(comboBox4.Text, "Bag"))
                {
                    p = pmList.SearchPartMaskLink(comboBox4.Text, "Bag");
                    p.MaskQty += int.Parse(textBox5.Text);
                    pmList.UpdatePartMaskLink(p);
                }
                // New Link
                else
                {
                    p = new PartMaskLink(0, partNum, partID, comboBox4.Text, "Bag", int.Parse(textBox4.Text));
                    pmList.AddPartMaskLink(p);
                }
                pmList.reload();
                UpdateDataGrid();
                // Adds Dot To List.
                // Auto Updates 
                textBox4.Text = "0";
            }
            else
            {
                MessageBox.Show("Value Must Be numeric and Exceed 0");
                textBox4.Text = "0";
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = "0";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = "0";
        }
        

    }
}