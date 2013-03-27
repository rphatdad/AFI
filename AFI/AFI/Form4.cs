using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AFI
{
    public partial class Form4 : Form
    {
        public string Comment;
        public Form4(string cmt)
        {
            InitializeComponent();
            Comment = cmt;
            textBox1.Text = cmt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comment = textBox1.Text.ToString();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}