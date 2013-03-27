using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AFIPO
{
    public partial class DotCapPlugQty : Form
    {
        public int newqty;
        private int origqty;
        public DotCapPlugQty()
        {
            InitializeComponent();
        }
        public DotCapPlugQty(int qty)
        {
            InitializeComponent();
            origqty = qty;
            newqty = qty;
            textBox1.Text = qty.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (validateString(textBox1.Text))
            {
                newqty = int.Parse(textBox1.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Value Must Be numeric and Exceed 0");
                textBox1.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newqty = origqty;
            this.Close();
        }
    }
}