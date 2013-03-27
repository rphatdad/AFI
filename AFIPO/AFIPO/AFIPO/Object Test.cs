using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AFIObjects;
using Microsoft.Reporting.WinForms;


namespace AFIPO
{
    public partial class Object_Test : Form
    {
        private RouterRptObj rr;
        public Object_Test()
        {
            InitializeComponent();
        }
        public Object_Test(Part p, PartMaskLinkList pl, String Cust )

        {
            InitializeComponent();
            rr = new RouterRptObj(p, pl.GetPartMaskLink(), Cust);

        }
        private void Object_Test_Load(object sender, EventArgs e)
        {
            this.PartBindingSource.DataSource = rr.GetParts();
            this.PartMaskLinkBindingSource.DataSource = rr.GetMasks();
            List<ReportParameter> parameters = new List<ReportParameter>();

            parameters.Add(new ReportParameter("customer",rr.Customer));
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}