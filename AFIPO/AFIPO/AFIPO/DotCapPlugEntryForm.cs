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
    
    public partial class DotCapPlugEntryForm : Form
    {
        private string[] dotType ={ "Dot", "Cap", "Plug","Bag","Tape" };
        private MaskTypeList ml = new MaskTypeList();
        private bool edit;
        private int MaskID;
        public DotCapPlugEntryForm()
        {
            InitializeComponent();
            edit = false;
            comboBox1.DataSource = dotType;
        }
        public DotCapPlugEntryForm(int ID, string Description, string MaskT)
        {
            InitializeComponent();
            MaskID = ID;
            edit = true;
            comboBox1.DataSource = dotType;
            textBox1.Text = Description;
            comboBox1.SelectedIndex = comboBox1.FindString(MaskT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Edit Existing
            DotCapPlugEditForm f1 = new DotCapPlugEditForm();
            this.Hide();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Save
            MaskType mt = new MaskType();
            if (edit == false)
            {
                mt.Type = comboBox1.SelectedItem.ToString();
                mt.Description = textBox1.Text.ToString();
                ml.AddMaskType(mt);
                comboBox1.DataSource = dotType;
                textBox1.Text = "";
            }
            else
            {
                mt.ID = MaskID;
                mt.Type = comboBox1.SelectedItem.ToString();
                mt.Description = textBox1.Text.ToString();
                ml.UpdateMaskType(mt);
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Cancel
            this.Close();
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}