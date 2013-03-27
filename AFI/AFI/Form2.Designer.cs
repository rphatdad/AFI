namespace AFI
{
    partial class Form2
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
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.BillShipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afiPartsDataSet1 = new AFI.AFIPartsDataSet();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.custBillShipAddrTableAdapter1 = new AFI.AFIPartsDataSetTableAdapters.CustBillShipAddrTableAdapter();
            this.statesTableAdapter1 = new AFI.AFIPartsDataSetTableAdapters.STATESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BillShipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiPartsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(144, 196);
            this.textBox28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(80, 22);
            this.textBox28.TabIndex = 19;
            // 
            // bindingSource1
            // 
            this.BillShipBindingSource.DataMember = "CustBillShipAddr";
            this.BillShipBindingSource.DataSource = this.afiPartsDataSet1;
            // 
            // afiPartsDataSet1
            // 
            this.afiPartsDataSet1.DataSetName = "AFIPartsDataSet";
            this.afiPartsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox19
            // 
            this.comboBox19.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox19.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox19.DataSource = this.afiPartsDataSet1;
            this.comboBox19.DisplayMember = "STATES.STATE";
            this.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(144, 161);
            this.comboBox19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(57, 24);
            this.comboBox19.TabIndex = 18;
            this.comboBox19.ValueMember = "STATES.ID";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(144, 135);
            this.textBox27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(369, 22);
            this.textBox27.TabIndex = 17;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(144, 75);
            this.textBox26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(569, 22);
            this.textBox26.TabIndex = 13;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(228, 48);
            this.textBox25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(485, 22);
            this.textBox25.TabIndex = 12;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(-77, 185);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(40, 17);
            this.label82.TabIndex = 21;
            this.label82.Text = "Zip1:";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(-77, 155);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(53, 17);
            this.label81.TabIndex = 20;
            this.label81.Text = "State1:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(-77, 124);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(43, 17);
            this.label80.TabIndex = 17;
            this.label80.Text = "City1:";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(-77, 97);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(72, 17);
            this.label79.TabIndex = 15;
            this.label79.Text = "Address1:";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(37, 197);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(32, 17);
            this.label83.TabIndex = 26;
            this.label83.Text = "Zip:";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(37, 167);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(45, 17);
            this.label84.TabIndex = 25;
            this.label84.Text = "State:";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(37, 135);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(35, 17);
            this.label85.TabIndex = 24;
            this.label85.Text = "City:";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(37, 79);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(72, 17);
            this.label86.TabIndex = 23;
            this.label86.Text = "Address1:";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(37, 50);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(169, 17);
            this.label87.TabIndex = 22;
            this.label87.Text = "Customer Address Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Address Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 7);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 27;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(463, 236);
            this.button29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(75, 23);
            this.button29.TabIndex = 32;
            this.button29.Text = "Cancel";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(325, 236);
            this.button28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(75, 23);
            this.button28.TabIndex = 31;
            this.button28.Text = "Delete";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(187, 236);
            this.button27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 23);
            this.button27.TabIndex = 30;
            this.button27.Text = "XXXX";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Address2:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 101);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 22);
            this.textBox1.TabIndex = 14;
            // 
            // custBillShipAddrTableAdapter1
            // 
            this.custBillShipAddrTableAdapter1.ClearBeforeFill = true;
            // 
            // statesTableAdapter1
            // 
            this.statesTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label83);
            this.Controls.Add(this.label84);
            this.Controls.Add(this.label85);
            this.Controls.Add(this.label86);
            this.Controls.Add(this.label87);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.comboBox19);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.label80);
            this.Controls.Add(this.label79);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Billing / Shipping Address";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillShipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiPartsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private AFIPartsDataSet afiPartsDataSet1;
        private AFI.AFIPartsDataSetTableAdapters.CustBillShipAddrTableAdapter custBillShipAddrTableAdapter1;
        private AFI.AFIPartsDataSetTableAdapters.STATESTableAdapter statesTableAdapter1;
        private System.Windows.Forms.BindingSource BillShipBindingSource;
    }
}