namespace AFIPO
{
    partial class OpenOrdersReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.aFIDBDataSet = new AFIPO.AFIDBDataSet();
            this.openOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.open_OrdersTableAdapter = new AFIPO.AFIDBDataSetTableAdapters.Open_OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aFIDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AFIDBDataSet_Open_Orders";
            reportDataSource1.Value = this.openOrdersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AFIPO.Open.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(925, 494);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // aFIDBDataSet
            // 
            this.aFIDBDataSet.DataSetName = "AFIDBDataSet";
            this.aFIDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openOrdersBindingSource
            // 
            this.openOrdersBindingSource.DataMember = "Open Orders";
            this.openOrdersBindingSource.DataSource = this.aFIDBDataSet;
            // 
            // open_OrdersTableAdapter
            // 
            this.open_OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // OpenOrdersReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 494);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form16";
            this.Text = "Open Orders Report";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aFIDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AFIDBDataSet aFIDBDataSet;
        private System.Windows.Forms.BindingSource openOrdersBindingSource;
        private AFIPO.AFIDBDataSetTableAdapters.Open_OrdersTableAdapter open_OrdersTableAdapter;
    }
}