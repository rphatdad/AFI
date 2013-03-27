namespace AFIShippers
{
    partial class Form12
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
            this.AFIDBDataSet = new AFIShippers.AFIDBDataSet();
            this.ShippersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShippersTableAdapter = new AFIShippers.AFIDBDataSetTableAdapters.ShippersTableAdapter();
            this.shippersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AFIDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "AFIDBDataSet_Shippers";
            reportDataSource1.Value = this.ShippersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AFIShippers.Shippers.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(860, 753);
            this.reportViewer1.TabIndex = 0;
            // 
            // AFIDBDataSet
            // 
            this.AFIDBDataSet.DataSetName = "AFIDBDataSet";
            this.AFIDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ShippersBindingSource
            // 
            this.ShippersBindingSource.DataMember = "Shippers";
            this.ShippersBindingSource.DataSource = this.AFIDBDataSet;
            // 
            // ShippersTableAdapter
            // 
            this.ShippersTableAdapter.ClearBeforeFill = true;
            // 
            // shippersListBindingSource
            // 
            this.shippersListBindingSource.DataSource = typeof(AFIShippers.ShippersList);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 748);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Shippers Report";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AFIDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource shippersListBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ShippersBindingSource;
        private AFIDBDataSet AFIDBDataSet;
        private AFIShippers.AFIDBDataSetTableAdapters.ShippersTableAdapter ShippersTableAdapter;

    }
}