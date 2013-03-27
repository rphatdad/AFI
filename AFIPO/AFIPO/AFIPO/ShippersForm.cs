using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AFIObjects;

namespace AFIPO
{
    public partial class ShippersForm : Form
    {
        private ShippersList ShipList;

        public ShippersForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShipList = new ShippersList();
            comboBox1.DataSource = ShipList.ListShippers();
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
           
            try
            {
                // If it is there then have it fill in fields
                if (ShipList.ShipperExist(comboBox1.Text))
                {
                    Shippers s1 = ShipList.SearchShipper(comboBox1.Text);
                    comboBox1.DataSource = ShipList.ListShippers();
                    Object2Form(s1);
                }
                // If not have it add item and then fill field from it;
                else
                {
                    Shippers s2 = ShipList.SearchShipper(comboBox1.Text);
                    ShipList.AddItem(comboBox1.Text);
                    comboBox1.DataSource = ShipList.ListShippers();
                    Object2Form(s2);
                }
                textBox1.Focus();  
     
            }
            catch (Exception ex)
            {
                MessageBox.Show("AlreadyHere "+ ex.Message);
            }
        }
        private Shippers Form2Object()
        {
            Shippers tship = new Shippers(0, comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            return tship;
        }
        private void Object2Form(Shippers s)
        {
            int Index = comboBox1.FindString(s.Shipper);
            comboBox1.SelectedIndex = Index;
            textBox1.Text = s.Comments;
            textBox2.Text = s.Phone;
            textBox3.Text = s.Fax;
            textBox4.Text = s.Cell;
            textBox5.Text = s.Other;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Save for Shipper
                if (comboBox1.Text != "")
                {
                    if (ShipList.ShipperInDB(comboBox1.Text))
                    {
                        ShipList.UpdateShippers(Form2Object());
                    }
                    else
                    {
                        ShipList.AddShippers(Form2Object());
                    }
                    comboBox1.DataSource = ShipList.ListShippers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Delete Shipper
            if (comboBox1.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the current Shipper? " +
                    "Doing so will also perminately delete the Shipper from the database.",
                    "Delete Shipper?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ShipList.DeleteShipper(comboBox1.Text);
                        comboBox1.DataSource = ShipList.ListShippers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Cancel
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShippersReportForm f12 = new ShippersReportForm();
            f12.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shippers s2 = ShipList.SearchShipper(comboBox1.Text);
            Object2Form(s2);
        }
        
    }
}