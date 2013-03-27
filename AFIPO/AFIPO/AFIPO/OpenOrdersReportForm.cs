using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AFIPO
{
    public partial class OpenOrdersReportForm : Form
    {
        public OpenOrdersReportForm()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aFIDBDataSet.Open_Orders' table. You can move, or remove it, as needed.
            this.open_OrdersTableAdapter.Fill(this.aFIDBDataSet.Open_Orders);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}