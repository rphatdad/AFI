namespace AFIPO
{
    partial class ReceivingForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.Colorlbl = new System.Windows.Forms.Label();
            this.RcvDate = new System.Windows.Forms.DateTimePicker();
            this.RcvComments = new System.Windows.Forms.TextBox();
            this.custNameLbl = new System.Windows.Forms.Label();
            this.CustCombo = new System.Windows.Forms.ComboBox();
            this.HotPartCB = new System.Windows.Forms.CheckBox();
            this.Tracking = new System.Windows.Forms.TextBox();
            this.InitQty = new System.Windows.Forms.TextBox();
            this.PoNum = new System.Windows.Forms.TextBox();
            this.PartCombo = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 19);
            this.button1.TabIndex = 78;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Colorlbl
            // 
            this.Colorlbl.AutoSize = true;
            this.Colorlbl.ForeColor = System.Drawing.Color.Blue;
            this.Colorlbl.Location = new System.Drawing.Point(312, 162);
            this.Colorlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Colorlbl.Name = "Colorlbl";
            this.Colorlbl.Size = new System.Drawing.Size(0, 13);
            this.Colorlbl.TabIndex = 77;
            // 
            // RcvDate
            // 
            this.RcvDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RcvDate.Location = new System.Drawing.Point(116, 135);
            this.RcvDate.Margin = new System.Windows.Forms.Padding(2);
            this.RcvDate.Name = "RcvDate";
            this.RcvDate.Size = new System.Drawing.Size(83, 20);
            this.RcvDate.TabIndex = 76;
            // 
            // RcvComments
            // 
            this.RcvComments.Location = new System.Drawing.Point(116, 188);
            this.RcvComments.Margin = new System.Windows.Forms.Padding(2);
            this.RcvComments.Multiline = true;
            this.RcvComments.Name = "RcvComments";
            this.RcvComments.Size = new System.Drawing.Size(361, 163);
            this.RcvComments.TabIndex = 69;
            this.RcvComments.TextChanged += new System.EventHandler(this.RcvComments_TextChanged);
            // 
            // custNameLbl
            // 
            this.custNameLbl.AutoSize = true;
            this.custNameLbl.ForeColor = System.Drawing.Color.Blue;
            this.custNameLbl.Location = new System.Drawing.Point(116, 31);
            this.custNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.custNameLbl.Name = "custNameLbl";
            this.custNameLbl.Size = new System.Drawing.Size(111, 13);
            this.custNameLbl.TabIndex = 75;
            this.custNameLbl.Text = "Customer Name Label";
            // 
            // CustCombo
            // 
            this.CustCombo.DisplayMember = "CUSTSHORTNAME";
            this.CustCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustCombo.FormattingEnabled = true;
            this.CustCombo.Location = new System.Drawing.Point(116, 7);
            this.CustCombo.Margin = new System.Windows.Forms.Padding(2);
            this.CustCombo.Name = "CustCombo";
            this.CustCombo.Size = new System.Drawing.Size(112, 21);
            this.CustCombo.TabIndex = 53;
            this.CustCombo.ValueMember = "ID";
            this.CustCombo.SelectedIndexChanged += new System.EventHandler(this.CustCombo_SelectedIndexChanged);
            // 
            // HotPartCB
            // 
            this.HotPartCB.AutoSize = true;
            this.HotPartCB.Location = new System.Drawing.Point(26, 158);
            this.HotPartCB.Margin = new System.Windows.Forms.Padding(2);
            this.HotPartCB.Name = "HotPartCB";
            this.HotPartCB.Size = new System.Drawing.Size(65, 17);
            this.HotPartCB.TabIndex = 68;
            this.HotPartCB.Text = "Hot Part";
            this.HotPartCB.UseVisualStyleBackColor = true;
            // 
            // Tracking
            // 
            this.Tracking.Location = new System.Drawing.Point(116, 108);
            this.Tracking.Margin = new System.Windows.Forms.Padding(2);
            this.Tracking.Name = "Tracking";
            this.Tracking.Size = new System.Drawing.Size(122, 20);
            this.Tracking.TabIndex = 66;
            // 
            // InitQty
            // 
            this.InitQty.Location = new System.Drawing.Point(351, 80);
            this.InitQty.Margin = new System.Windows.Forms.Padding(2);
            this.InitQty.Name = "InitQty";
            this.InitQty.Size = new System.Drawing.Size(47, 20);
            this.InitQty.TabIndex = 64;
            this.InitQty.TextChanged += new System.EventHandler(this.InitQty_TextChanged);
            this.InitQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_KeyPress);
            // 
            // PoNum
            // 
            this.PoNum.Location = new System.Drawing.Point(116, 80);
            this.PoNum.Margin = new System.Windows.Forms.Padding(2);
            this.PoNum.Name = "PoNum";
            this.PoNum.Size = new System.Drawing.Size(122, 20);
            this.PoNum.TabIndex = 59;
            // 
            // PartCombo
            // 
            this.PartCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartCombo.FormattingEnabled = true;
            this.PartCombo.Location = new System.Drawing.Point(116, 51);
            this.PartCombo.Margin = new System.Windows.Forms.Padding(2);
            this.PartCombo.Name = "PartCombo";
            this.PartCombo.Size = new System.Drawing.Size(166, 21);
            this.PartCombo.TabIndex = 55;
            this.PartCombo.SelectedIndexChanged += new System.EventHandler(this.PartCombo_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(335, 50);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 20);
            this.button7.TabIndex = 57;
            this.button7.Text = "Add New Part";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(334, 384);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 19);
            this.button6.TabIndex = 74;
            this.button6.Text = "Router";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(392, 384);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 19);
            this.button5.TabIndex = 73;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(241, 384);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 19);
            this.button4.TabIndex = 72;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 384);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 19);
            this.button3.TabIndex = 71;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 384);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 19);
            this.button2.TabIndex = 70;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Comments:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Color:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Receive Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Hot Part:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Tracking Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "P.O.  Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Part Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Customer ID:";
            // 
            // ReceivingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(594, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Colorlbl);
            this.Controls.Add(this.RcvDate);
            this.Controls.Add(this.RcvComments);
            this.Controls.Add(this.custNameLbl);
            this.Controls.Add(this.CustCombo);
            this.Controls.Add(this.HotPartCB);
            this.Controls.Add(this.Tracking);
            this.Controls.Add(this.InitQty);
            this.Controls.Add(this.PoNum);
            this.Controls.Add(this.PartCombo);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReceivingForm";
            this.Text = "Receiving";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Colorlbl;
        private System.Windows.Forms.DateTimePicker RcvDate;
        private System.Windows.Forms.TextBox RcvComments;
        private System.Windows.Forms.Label custNameLbl;
        private System.Windows.Forms.ComboBox CustCombo;
        private System.Windows.Forms.CheckBox HotPartCB;
        private System.Windows.Forms.TextBox Tracking;
        private System.Windows.Forms.TextBox InitQty;
        private System.Windows.Forms.TextBox PoNum;
        private System.Windows.Forms.ComboBox PartCombo;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}