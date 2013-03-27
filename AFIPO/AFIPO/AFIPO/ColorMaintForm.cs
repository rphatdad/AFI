using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AFIObjects;

namespace AFIPO
{
    public partial class ColorMaintForm : Form
    {
        private ColorsList ColorList;

        public ColorMaintForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorList = new ColorsList();
            comboBox1.DataSource = ColorList.ListColors();
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
           
            try
            {
                // If it is there then have it fill in fields
                if (ColorList.ColorExist(comboBox1.Text))
                {
                    Colors s1 = ColorList.SearchColor(comboBox1.Text);
                    comboBox1.DataSource = ColorList.ListColors();
                    Object2Form(s1);
                }
                // If not have it add item and then fill field from it;
                else
                {
                    Colors s2 = ColorList.SearchColor(comboBox1.Text);
                    ColorList.AddItem(comboBox1.Text);
                    comboBox1.DataSource = ColorList.ListColors();
                    Object2Form(s2);
                }
                textBox1.Focus();  
     
            }
            catch (Exception ex)
            {
                MessageBox.Show("AlreadyHere "+ ex.Message);
            }
        }
        private Colors Form2Object()
        {
            Colors tship = new Colors(0, comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            return tship;
        }
        private void Object2Form(Colors s)
        {
            int Index = comboBox1.FindString(s.Abrev);
            comboBox1.SelectedIndex = Index;
            textBox1.Text = s.ColorName;
            textBox2.Text = s.ColorNumber;
            textBox3.Text = s.ColorManufacturer;
            textBox4.Text = s.PoundsInStock;
            textBox5.Text = s.DesiredPounds;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Save for Color
                if (comboBox1.Text != "")
                {
                    if (ColorList.ColorInDB(comboBox1.Text))
                    {
                        ColorList.UpdateColors(Form2Object());
                    }
                    else
                    {
                        ColorList.AddColors(Form2Object());
                    }
                    comboBox1.DataSource = ColorList.ListColors();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Delete Color
            if (comboBox1.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the current Color? " +
                    "Doing so will also perminately delete the Color from the database.",
                    "Delete Color?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ColorList.DeleteColor(comboBox1.Text);
                        comboBox1.DataSource = ColorList.ListColors();
                        if (comboBox1.Items.Count == 0)
                        {
                            textBox1.Text = "";
                            textBox2.Text ="";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            comboBox1.Text = "";
                        }
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
           ColorReportForm f13 = new ColorReportForm();
           f13.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Colors s2 = ColorList.SearchColor(comboBox1.Text);
            Object2Form(s2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
        }
        
    }
}