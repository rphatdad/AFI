namespace AFIPO
{
    partial class CustomerMaintForm
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
            this.button70 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.ADDRESSNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESSTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusLabel = new System.Windows.Forms.Label();
            this.button68 = new System.Windows.Forms.Button();
            this.textBox103 = new System.Windows.Forms.TextBox();
            this.label219 = new System.Windows.Forms.Label();
            this.textBox101 = new System.Windows.Forms.TextBox();
            this.label212 = new System.Windows.Forms.Label();
            this.textBox100 = new System.Windows.Forms.TextBox();
            this.label211 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label210 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label209 = new System.Windows.Forms.Label();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.CustIDcombo = new System.Windows.Forms.ComboBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.customerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button70
            // 
            this.button70.Location = new System.Drawing.Point(228, 280);
            this.button70.Margin = new System.Windows.Forms.Padding(2);
            this.button70.Name = "button70";
            this.button70.Size = new System.Drawing.Size(95, 19);
            this.button70.TabIndex = 56;
            this.button70.Text = "Delete Address";
            this.button70.UseVisualStyleBackColor = true;
            this.button70.Click += new System.EventHandler(this.button70_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(356, 280);
            this.button26.Margin = new System.Windows.Forms.Padding(2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(95, 19);
            this.button26.TabIndex = 55;
            this.button26.Text = "Edit Address";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToResizeColumns = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ADDRESSNAME,
            this.ADDRESSTYPE});
            this.dataGridView5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView5.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView5.Location = new System.Drawing.Point(100, 155);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(399, 105);
            this.dataGridView5.TabIndex = 54;
            this.dataGridView5.DoubleClick += new System.EventHandler(this.dataGridView5_DoubleClick);
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // ADDRESSNAME
            // 
            this.ADDRESSNAME.DataPropertyName = "ADDRESSNAME";
            this.ADDRESSNAME.HeaderText = "Address Name";
            this.ADDRESSNAME.MinimumWidth = 250;
            this.ADDRESSNAME.Name = "ADDRESSNAME";
            this.ADDRESSNAME.ReadOnly = true;
            this.ADDRESSNAME.Width = 250;
            // 
            // ADDRESSTYPE
            // 
            this.ADDRESSTYPE.DataPropertyName = "ADDRESSTYPE";
            this.ADDRESSTYPE.HeaderText = "Address Type";
            this.ADDRESSTYPE.MinimumWidth = 100;
            this.ADDRESSTYPE.Name = "ADDRESSTYPE";
            this.ADDRESSTYPE.ReadOnly = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(101, 299);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 53;
            // 
            // button68
            // 
            this.button68.Location = new System.Drawing.Point(100, 280);
            this.button68.Margin = new System.Windows.Forms.Padding(2);
            this.button68.Name = "button68";
            this.button68.Size = new System.Drawing.Size(95, 19);
            this.button68.TabIndex = 44;
            this.button68.Text = "Add Address";
            this.button68.UseVisualStyleBackColor = true;
            this.button68.Click += new System.EventHandler(this.button68_Click);
            // 
            // textBox103
            // 
            this.textBox103.Location = new System.Drawing.Point(359, 35);
            this.textBox103.Margin = new System.Windows.Forms.Padding(2);
            this.textBox103.MaxLength = 50;
            this.textBox103.Name = "textBox103";
            this.textBox103.Size = new System.Drawing.Size(210, 20);
            this.textBox103.TabIndex = 38;
            // 
            // label219
            // 
            this.label219.AutoSize = true;
            this.label219.Location = new System.Drawing.Point(279, 35);
            this.label219.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label219.Name = "label219";
            this.label219.Size = new System.Drawing.Size(78, 13);
            this.label219.TabIndex = 52;
            this.label219.Text = "Contact Name:";
            // 
            // textBox101
            // 
            this.textBox101.Location = new System.Drawing.Point(100, 96);
            this.textBox101.Margin = new System.Windows.Forms.Padding(2);
            this.textBox101.MaxLength = 256;
            this.textBox101.Name = "textBox101";
            this.textBox101.Size = new System.Drawing.Size(216, 20);
            this.textBox101.TabIndex = 43;
            // 
            // label212
            // 
            this.label212.AutoSize = true;
            this.label212.Location = new System.Drawing.Point(53, 97);
            this.label212.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label212.Name = "label212";
            this.label212.Size = new System.Drawing.Size(35, 13);
            this.label212.TabIndex = 51;
            this.label212.Text = "Email:";
            // 
            // textBox100
            // 
            this.textBox100.Location = new System.Drawing.Point(361, 72);
            this.textBox100.Margin = new System.Windows.Forms.Padding(2);
            this.textBox100.MaxLength = 16;
            this.textBox100.Name = "textBox100";
            this.textBox100.Size = new System.Drawing.Size(80, 20);
            this.textBox100.TabIndex = 42;
            // 
            // label211
            // 
            this.label211.AutoSize = true;
            this.label211.Location = new System.Drawing.Point(331, 74);
            this.label211.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(27, 13);
            this.label211.TabIndex = 50;
            this.label211.Text = "Fax:";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(235, 72);
            this.textBox19.Margin = new System.Windows.Forms.Padding(2);
            this.textBox19.MaxLength = 16;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(80, 20);
            this.textBox19.TabIndex = 41;
            // 
            // label210
            // 
            this.label210.AutoSize = true;
            this.label210.Location = new System.Drawing.Point(191, 74);
            this.label210.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label210.Name = "label210";
            this.label210.Size = new System.Drawing.Size(47, 13);
            this.label210.TabIndex = 49;
            this.label210.Text = "Phone2:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(100, 72);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.MaxLength = 16;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 20);
            this.textBox5.TabIndex = 40;
            // 
            // label209
            // 
            this.label209.AutoSize = true;
            this.label209.Location = new System.Drawing.Point(53, 74);
            this.label209.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(47, 13);
            this.label209.TabIndex = 48;
            this.label209.Text = "Phone1:";
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(309, 341);
            this.button29.Margin = new System.Windows.Forms.Padding(2);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(56, 19);
            this.button29.TabIndex = 47;
            this.button29.Text = "Cancel";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(206, 341);
            this.button28.Margin = new System.Windows.Forms.Padding(2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(56, 19);
            this.button28.TabIndex = 46;
            this.button28.Text = "Delete";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(101, 341);
            this.button27.Margin = new System.Windows.Forms.Padding(2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(56, 19);
            this.button27.TabIndex = 45;
            this.button27.Text = "Save";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // CustIDcombo
            // 
            this.CustIDcombo.AllowDrop = true;
            this.CustIDcombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CustIDcombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustIDcombo.FormattingEnabled = true;
            this.CustIDcombo.Location = new System.Drawing.Point(100, 11);
            this.CustIDcombo.Margin = new System.Windows.Forms.Padding(2);
            this.CustIDcombo.MaxLength = 50;
            this.CustIDcombo.Name = "CustIDcombo";
            this.CustIDcombo.Size = new System.Drawing.Size(112, 21);
            this.CustIDcombo.TabIndex = 35;
            this.CustIDcombo.SelectedIndexChanged += new System.EventHandler(this.CustIDcombo_SelectedIndexChanged);
            this.CustIDcombo.Validated += new System.EventHandler(this.CustIDcombo_Validated);
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(100, 35);
            this.textBox24.Margin = new System.Windows.Forms.Padding(2);
            this.textBox24.MaxLength = 100;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(177, 20);
            this.textBox24.TabIndex = 37;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(7, 35);
            this.label76.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(85, 13);
            this.label76.TabIndex = 39;
            this.label76.Text = "Customer Name:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(7, 14);
            this.label77.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(68, 13);
            this.label77.TabIndex = 36;
            this.label77.Text = "Customer ID:";
            // 
            // customerListBindingSource
            // 
            //this.customerListBindingSource.DataSource = typeof(AFIObjects.CustomerList);
            // 
            // PartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 390);
            this.Controls.Add(this.button70);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button68);
            this.Controls.Add(this.textBox103);
            this.Controls.Add(this.label219);
            this.Controls.Add(this.textBox101);
            this.Controls.Add(this.label212);
            this.Controls.Add(this.textBox100);
            this.Controls.Add(this.label211);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.label210);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label209);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.CustIDcombo);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.label77);
            this.Name = "Form1";
            this.Text = "Customer Maintence";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button70;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESSNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESSTYPE;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button button68;
        private System.Windows.Forms.TextBox textBox103;
        private System.Windows.Forms.Label label219;
        private System.Windows.Forms.TextBox textBox101;
        private System.Windows.Forms.Label label212;
        private System.Windows.Forms.TextBox textBox100;
        private System.Windows.Forms.Label label211;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label210;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label209;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.ComboBox CustIDcombo;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.BindingSource customerListBindingSource;
    }
}