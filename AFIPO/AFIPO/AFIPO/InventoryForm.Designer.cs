namespace AFIPO
{
    partial class InventoryForm
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
            this.button9 = new System.Windows.Forms.Button();
            this.TquanAvail = new System.Windows.Forms.Label();
            this.label214 = new System.Windows.Forms.Label();
            this.CustCombo = new System.Windows.Forms.ComboBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.paintRjTB = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.fabRejTB = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.invTB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.OpenPOGrid = new System.Windows.Forms.DataGridView();
            this.POnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RCVdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaintReject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FabReject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvCmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.PartCombo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.custNameLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OpenPOGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(277, 277);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 67;
            this.button9.Text = "Ship";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // TquanAvail
            // 
            this.TquanAvail.AutoSize = true;
            this.TquanAvail.ForeColor = System.Drawing.Color.Blue;
            this.TquanAvail.Location = new System.Drawing.Point(484, 251);
            this.TquanAvail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TquanAvail.Name = "TquanAvail";
            this.TquanAvail.Size = new System.Drawing.Size(13, 13);
            this.TquanAvail.TabIndex = 66;
            this.TquanAvail.Text = "0";
            // 
            // label214
            // 
            this.label214.AutoSize = true;
            this.label214.Location = new System.Drawing.Point(393, 251);
            this.label214.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(79, 13);
            this.label214.TabIndex = 65;
            this.label214.Text = "Total Qty Avail:";
            // 
            // CustCombo
            // 
            this.CustCombo.DisplayMember = "CUSTSHORTNAME";
            this.CustCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustCombo.FormattingEnabled = true;
            this.CustCombo.Location = new System.Drawing.Point(115, 8);
            this.CustCombo.Margin = new System.Windows.Forms.Padding(2);
            this.CustCombo.Name = "CustCombo";
            this.CustCombo.Size = new System.Drawing.Size(112, 21);
            this.CustCombo.TabIndex = 48;
            this.CustCombo.ValueMember = "ID";
            this.CustCombo.SelectedIndexChanged += new System.EventHandler(this.CustCombo_SelectedIndexChanged);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(28, 381);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(168, 19);
            this.button12.TabIndex = 54;
            this.button12.Text = "Add Inventory Comment";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(437, 381);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 19);
            this.button11.TabIndex = 56;
            this.button11.Text = "Cancel";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(356, 381);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 19);
            this.button10.TabIndex = 55;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // paintRjTB
            // 
            this.paintRjTB.Location = new System.Drawing.Point(149, 323);
            this.paintRjTB.Margin = new System.Windows.Forms.Padding(2);
            this.paintRjTB.Name = "paintRjTB";
            this.paintRjTB.Size = new System.Drawing.Size(47, 20);
            this.paintRjTB.TabIndex = 53;
            this.paintRjTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 323);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 64;
            this.label20.Text = "Paint Reject";
            // 
            // fabRejTB
            // 
            this.fabRejTB.Location = new System.Drawing.Point(149, 300);
            this.fabRejTB.Margin = new System.Windows.Forms.Padding(2);
            this.fabRejTB.Name = "fabRejTB";
            this.fabRejTB.Size = new System.Drawing.Size(47, 20);
            this.fabRejTB.TabIndex = 52;
            this.fabRejTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 300);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 13);
            this.label19.TabIndex = 63;
            this.label19.Text = "Fabrication Reject:";
            // 
            // invTB
            // 
            this.invTB.Location = new System.Drawing.Point(149, 276);
            this.invTB.Margin = new System.Windows.Forms.Padding(2);
            this.invTB.Name = "invTB";
            this.invTB.Size = new System.Drawing.Size(47, 20);
            this.invTB.TabIndex = 51;
            this.invTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 276);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Quantity To Inventory:";
            // 
            // OpenPOGrid
            // 
            this.OpenPOGrid.AllowUserToAddRows = false;
            this.OpenPOGrid.AllowUserToDeleteRows = false;
            this.OpenPOGrid.AllowUserToResizeColumns = false;
            this.OpenPOGrid.AllowUserToResizeRows = false;
            this.OpenPOGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpenPOGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.POnum,
            this.RCVdate,
            this.InvQty,
            this.PaintReject,
            this.FabReject,
            this.AvailQty,
            this.InvCmt,
            this.Cmt});
            this.OpenPOGrid.Location = new System.Drawing.Point(44, 113);
            this.OpenPOGrid.Margin = new System.Windows.Forms.Padding(2);
            this.OpenPOGrid.Name = "OpenPOGrid";
            this.OpenPOGrid.ReadOnly = true;
            this.OpenPOGrid.RowTemplate.Height = 24;
            this.OpenPOGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OpenPOGrid.Size = new System.Drawing.Size(515, 130);
            this.OpenPOGrid.TabIndex = 50;
            this.OpenPOGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OpenPOGrid_CellContentClick);
            // 
            // POnum
            // 
            this.POnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.POnum.DividerWidth = 1;
            this.POnum.HeaderText = "P.O. #";
            this.POnum.MinimumWidth = 75;
            this.POnum.Name = "POnum";
            this.POnum.ReadOnly = true;
            this.POnum.Width = 75;
            // 
            // RCVdate
            // 
            this.RCVdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RCVdate.HeaderText = "Received Date";
            this.RCVdate.MinimumWidth = 120;
            this.RCVdate.Name = "RCVdate";
            this.RCVdate.ReadOnly = true;
            this.RCVdate.Width = 120;
            // 
            // InvQty
            // 
            this.InvQty.HeaderText = "Inventory Qty";
            this.InvQty.MinimumWidth = 60;
            this.InvQty.Name = "InvQty";
            this.InvQty.ReadOnly = true;
            this.InvQty.Width = 60;
            // 
            // PaintReject
            // 
            this.PaintReject.HeaderText = "Paint Reject";
            this.PaintReject.MinimumWidth = 60;
            this.PaintReject.Name = "PaintReject";
            this.PaintReject.ReadOnly = true;
            this.PaintReject.Width = 60;
            // 
            // FabReject
            // 
            this.FabReject.HeaderText = "Fab Reject";
            this.FabReject.MinimumWidth = 60;
            this.FabReject.Name = "FabReject";
            this.FabReject.ReadOnly = true;
            this.FabReject.Width = 60;
            // 
            // AvailQty
            // 
            this.AvailQty.HeaderText = "Avail Qty";
            this.AvailQty.MinimumWidth = 60;
            this.AvailQty.Name = "AvailQty";
            this.AvailQty.ReadOnly = true;
            this.AvailQty.Width = 60;
            // 
            // InvCmt
            // 
            this.InvCmt.HeaderText = "Inventory Comment";
            this.InvCmt.MaxInputLength = 512;
            this.InvCmt.Name = "InvCmt";
            this.InvCmt.ReadOnly = true;
            this.InvCmt.Visible = false;
            // 
            // Cmt
            // 
            this.Cmt.HeaderText = "Inv Cmt";
            this.Cmt.MaxInputLength = 1;
            this.Cmt.MinimumWidth = 30;
            this.Cmt.Name = "Cmt";
            this.Cmt.ReadOnly = true;
            this.Cmt.Width = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 94);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "Open P.O. List:";
            // 
            // PartCombo
            // 
            this.PartCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartCombo.FormattingEnabled = true;
            this.PartCombo.Location = new System.Drawing.Point(113, 57);
            this.PartCombo.Margin = new System.Windows.Forms.Padding(2);
            this.PartCombo.Name = "PartCombo";
            this.PartCombo.Size = new System.Drawing.Size(219, 21);
            this.PartCombo.TabIndex = 49;
            this.PartCombo.SelectedIndexChanged += new System.EventHandler(this.PartCombo_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 60);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Part Number:";
            // 
            // custNameLbl
            // 
            this.custNameLbl.AutoSize = true;
            this.custNameLbl.ForeColor = System.Drawing.Color.Blue;
            this.custNameLbl.Location = new System.Drawing.Point(113, 35);
            this.custNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.custNameLbl.Name = "custNameLbl";
            this.custNameLbl.Size = new System.Drawing.Size(111, 13);
            this.custNameLbl.TabIndex = 59;
            this.custNameLbl.Text = "Customer Name Label";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Customer Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 13);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Customer ID:";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(594, 409);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.TquanAvail);
            this.Controls.Add(this.label214);
            this.Controls.Add(this.CustCombo);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.paintRjTB);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.fabRejTB);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.invTB);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.OpenPOGrid);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.PartCombo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.custNameLbl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Name = "Form4";
            this.Text = "Count Verification/Inventory";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OpenPOGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label TquanAvail;
        private System.Windows.Forms.Label label214;
        private System.Windows.Forms.ComboBox CustCombo;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox paintRjTB;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox fabRejTB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox invTB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView OpenPOGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn POnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RCVdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaintReject;
        private System.Windows.Forms.DataGridViewTextBoxColumn FabReject;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvCmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox PartCombo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label custNameLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}