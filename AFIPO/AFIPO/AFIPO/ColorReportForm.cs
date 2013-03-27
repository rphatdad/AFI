using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AFIPO
{
    public partial class ColorReportForm : Form
    {
        public ColorReportForm()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AFIDBDataSet.LowColor' table. You can move, or remove it, as needed.
            this.LowColorTableAdapter.Fill(this.AFIDBDataSet.LowColor);
            // TODO: This line of code loads data into the 'AFIDBDataSet.Color' table. You can move, or remove it, as needed.
            this.ColorTableAdapter.Fill(this.AFIDBDataSet.Color);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}