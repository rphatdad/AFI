using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AFIPO
{
    public partial class TestMenu : Form
    {
        public TestMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DotCapPlugEntryForm f1 = new DotCapPlugEntryForm();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DotCapPlugForm f2 = new DotCapPlugForm("1234",12);
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DotCapPlugEditForm f3 = new DotCapPlugEditForm();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PartsForm f1 = new PartsForm();
            f1.ShowDialog();
        }
    }
}