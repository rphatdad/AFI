using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AFIPO
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AFIDBDataSet.Color' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'AFIDBDataSet.Color' table. You can move, or remove it, as needed.
            this.LowColorTableAdapter.Fill(this.AFIDBDataSet.LowColor);
            // TODO: This line of code loads data into the 'AFIDBDataSet.LowColor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'AFIDBDataSet.Color' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}