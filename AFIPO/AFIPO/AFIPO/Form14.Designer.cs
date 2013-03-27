namespace AFIPO
{
    partial class Form14
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
            this.AFIDBDataSet = new AFIPO.AFIDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LowColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LowColorTableAdapter = new AFIPO.AFIDBDataSetTableAdapters.LowColorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AFIDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowColorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AFIDBDataSet
            // 
            this.AFIDBDataSet.DataSetName = "AFIDBDataSet";
            this.AFIDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AFIDBDataSet_Color";
            reportDataSource2.Name = "AFIDBDataSet_LowColor";
            reportDataSource2.Value = this.LowColorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AFIPO.LowColorStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(929, 266);
            this.reportViewer1.TabIndex = 0;
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
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 266);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AFIDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowColorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AFIDBDataSet AFIDBDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LowColorBindingSource;
        private AFIPO.AFIDBDataSetTableAdapters.LowColorTableAdapter LowColorTableAdapter;

    }
}