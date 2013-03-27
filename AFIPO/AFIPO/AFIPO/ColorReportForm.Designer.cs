namespace AFIPO
{
    partial class ColorReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AFIDBDataSet = new AFIPO.AFIDBDataSet();
            this.ColorTableAdapter = new AFIPO.AFIDBDataSetTableAdapters.ColorTableAdapter();
            this.LowColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LowColorTableAdapter = new AFIPO.AFIDBDataSetTableAdapters.LowColorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AFIDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowColorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AFIDBDataSet_Color";
            reportDataSource1.Value = this.ColorBindingSource;
            reportDataSource2.Name = "AFIDBDataSet_LowColor";
            reportDataSource2.Value = this.LowColorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AFIPO.ColorStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(927, 574);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ColorBindingSource
            // 
            this.ColorBindingSource.DataMember = "Color";
            this.ColorBindingSource.DataSource = this.AFIDBDataSet;
            // 
            // AFIDBDataSet
            // 
            this.AFIDBDataSet.DataSetName = "AFIDBDataSet";
            this.AFIDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ColorTableAdapter
            // 
            this.ColorTableAdapter.ClearBeforeFill = true;
            // 
            // LowColorBindingSource
            // 
            this.LowColorBindingSource.DataMember = "LowColor";
            this.LowColorBindingSource.DataSource = this.AFIDBDataSet;
            // 
            // LowColorTableAdapter
            // 
            this.LowColorTableAdapter.ClearBeforeFill = true;
            // 
            // ColorReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 574);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form13";
            this.Text = "Color Report";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AFIDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowColorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ColorBindingSource;
        private AFIDBDataSet AFIDBDataSet;
        private AFIPO.AFIDBDataSetTableAdapters.ColorTableAdapter ColorTableAdapter;
        private System.Windows.Forms.BindingSource LowColorBindingSource;
        private AFIPO.AFIDBDataSetTableAdapters.LowColorTableAdapter LowColorTableAdapter;
    }
}