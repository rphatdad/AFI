namespace AFIPO
{
    partial class ShippingForm
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
            this.ShipColorLbl = new System.Windows.Forms.Label();
            this.BackOrderlbl = new System.Windows.Forms.Label();
            this.label215 = new System.Windows.Forms.Label();
            this.InvPOGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CustCombo = new System.Windows.Forms.ComboBox();
            this.PackListComment = new System.Windows.Forms.Button();
            this.Ship = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label75 = new System.Windows.Forms.Label();
            this.CompanyNamelbl = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.Addrlbl = new System.Windows.Forms.Label();
            this.AddrCombo = new System.Windows.Forms.ComboBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.BillToCombo = new System.Windows.Forms.ComboBox();
            this.label67 = new System.Windows.Forms.Label();
            this.LastShipLbl = new System.Windows.Forms.Label();
            this.ShipOnHandQtyLbl = new System.Windows.Forms.Label();
            this.ShippedQtyLbl = new System.Windows.Forms.Label();
            this.ShipInitRcvQty = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.BoxesTB = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.ShipViaCombo = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.TrackingTB = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.ToShipTB = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.PartCombo = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.custNamelbl = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FabRej = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaintRej = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.InvPOGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShipColorLbl
            // 
            this.ShipColorLbl.AutoSize = true;
            this.ShipColorLbl.ForeColor = System.Drawing.Color.Blue;
            this.ShipColorLbl.Location = new System.Drawing.Point(439, 66);
            this.ShipColorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShipColorLbl.Name = "ShipColorLbl";
            this.ShipColorLbl.Size = new System.Drawing.Size(60, 13);
            this.ShipColorLbl.TabIndex = 129;
            this.ShipColorLbl.Text = "Color Label";
            // 
            // BackOrderlbl
            // 
            this.BackOrderlbl.AutoSize = true;
            this.BackOrderlbl.ForeColor = System.Drawing.Color.Blue;
            this.BackOrderlbl.Location = new System.Drawing.Point(600, 315);
            this.BackOrderlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BackOrderlbl.Name = "BackOrderlbl";
            this.BackOrderlbl.Size = new System.Drawing.Size(87, 13);
            this.BackOrderlbl.TabIndex = 128;
            this.BackOrderlbl.Text = "BackOrder Label";
            // 
            // label215
            // 
            this.label215.AutoSize = true;
            this.label215.Location = new System.Drawing.Point(4, 89);
            this.label215.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label215.Name = "label215";
            this.label215.Size = new System.Drawing.Size(79, 13);
            this.label215.TabIndex = 127;
            this.label215.Text = "Open P.O. List:";
            // 
            // InvPOGrid
            // 
            this.InvPOGrid.AllowUserToAddRows = false;
            this.InvPOGrid.AllowUserToDeleteRows = false;
            this.InvPOGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvPOGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.RecQty,
            this.FabRej,
            this.PaintRej,
            this.dataGridViewTextBoxColumn15,
            this.Shipped,
            this.Status,
            this.ID,
            this.OnHand});
            this.InvPOGrid.Location = new System.Drawing.Point(97, 96);
            this.InvPOGrid.Margin = new System.Windows.Forms.Padding(2);
            this.InvPOGrid.Name = "InvPOGrid";
            this.InvPOGrid.ReadOnly = true;
            this.InvPOGrid.RowTemplate.Height = 24;
            this.InvPOGrid.Size = new System.Drawing.Size(582, 104);
            this.InvPOGrid.TabIndex = 126;
            this.InvPOGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView8_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 220);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker1.TabIndex = 125;
            // 
            // CustCombo
            // 
            this.CustCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CustCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustCombo.DisplayMember = "CUSTSHORTNAME";
            this.CustCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustCombo.FormattingEnabled = true;
            this.CustCombo.Location = new System.Drawing.Point(96, 16);
            this.CustCombo.Margin = new System.Windows.Forms.Padding(2);
            this.CustCombo.Name = "CustCombo";
            this.CustCombo.Size = new System.Drawing.Size(112, 21);
            this.CustCombo.TabIndex = 92;
            this.CustCombo.ValueMember = "ID";
            this.CustCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.CustCombo.Validated += new System.EventHandler(this.comboBox4_Validated);
            // 
            // PackListComment
            // 
            this.PackListComment.Location = new System.Drawing.Point(43, 418);
            this.PackListComment.Margin = new System.Windows.Forms.Padding(2);
            this.PackListComment.Name = "PackListComment";
            this.PackListComment.Size = new System.Drawing.Size(168, 27);
            this.PackListComment.TabIndex = 122;
            this.PackListComment.Text = "Add Packing List Comment";
            this.PackListComment.UseVisualStyleBackColor = true;
            this.PackListComment.Click += new System.EventHandler(this.button23_Click);
            // 
            // Ship
            // 
            this.Ship.Location = new System.Drawing.Point(454, 418);
            this.Ship.Margin = new System.Windows.Forms.Padding(2);
            this.Ship.Name = "Ship";
            this.Ship.Size = new System.Drawing.Size(56, 27);
            this.Ship.TabIndex = 124;
            this.Ship.Text = "Cancel";
            this.Ship.UseVisualStyleBackColor = true;
            this.Ship.Click += new System.EventHandler(this.Ship_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(351, 418);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(47, 27);
            this.Cancel.TabIndex = 123;
            this.Cancel.Text = "Ship";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button25_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label75);
            this.groupBox1.Controls.Add(this.CompanyNamelbl);
            this.groupBox1.Controls.Add(this.label73);
            this.groupBox1.Controls.Add(this.Addrlbl);
            this.groupBox1.Controls.Add(this.AddrCombo);
            this.groupBox1.Controls.Add(this.label71);
            this.groupBox1.Controls.Add(this.label70);
            this.groupBox1.Controls.Add(this.label69);
            this.groupBox1.Location = new System.Drawing.Point(1, 330);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(568, 80);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SHIP TO:";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.ForeColor = System.Drawing.Color.Blue;
            this.label75.Location = new System.Drawing.Point(89, 87);
            this.label75.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(58, 13);
            this.label75.TabIndex = 85;
            this.label75.Text = "Cont Label";
            // 
            // CompanyNamelbl
            // 
            this.CompanyNamelbl.AutoSize = true;
            this.CompanyNamelbl.ForeColor = System.Drawing.Color.Blue;
            this.CompanyNamelbl.Location = new System.Drawing.Point(89, 61);
            this.CompanyNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanyNamelbl.Name = "CompanyNamelbl";
            this.CompanyNamelbl.Size = new System.Drawing.Size(63, 13);
            this.CompanyNamelbl.TabIndex = 84;
            this.CompanyNamelbl.Text = "Comp Label";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.ForeColor = System.Drawing.Color.Blue;
            this.label73.Location = new System.Drawing.Point(346, 87);
            this.label73.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(61, 13);
            this.label73.TabIndex = 83;
            this.label73.Text = "Add2 Label";
            // 
            // Addrlbl
            // 
            this.Addrlbl.AutoSize = true;
            this.Addrlbl.ForeColor = System.Drawing.Color.Blue;
            this.Addrlbl.Location = new System.Drawing.Point(346, 61);
            this.Addrlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Addrlbl.Name = "Addrlbl";
            this.Addrlbl.Size = new System.Drawing.Size(61, 13);
            this.Addrlbl.TabIndex = 78;
            this.Addrlbl.Text = "Add1 Label";
            // 
            // AddrCombo
            // 
            this.AddrCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddrCombo.FormattingEnabled = true;
            this.AddrCombo.Location = new System.Drawing.Point(59, 35);
            this.AddrCombo.Margin = new System.Windows.Forms.Padding(2);
            this.AddrCombo.Name = "AddrCombo";
            this.AddrCombo.Size = new System.Drawing.Size(434, 21);
            this.AddrCombo.TabIndex = 82;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(10, 40);
            this.label71.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(45, 13);
            this.label71.TabIndex = 81;
            this.label71.Text = "Address";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(4, 87);
            this.label70.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(78, 13);
            this.label70.TabIndex = 80;
            this.label70.Text = "Contact Name:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(4, 61);
            this.label69.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(85, 13);
            this.label69.TabIndex = 78;
            this.label69.Text = "Company Name:";
            // 
            // BillToCombo
            // 
            this.BillToCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BillToCombo.FormattingEnabled = true;
            this.BillToCombo.Location = new System.Drawing.Point(97, 308);
            this.BillToCombo.Margin = new System.Windows.Forms.Padding(2);
            this.BillToCombo.Name = "BillToCombo";
            this.BillToCombo.Size = new System.Drawing.Size(254, 21);
            this.BillToCombo.TabIndex = 120;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(7, 308);
            this.label67.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(50, 13);
            this.label67.TabIndex = 119;
            this.label67.Text = "BILL TO:";
            // 
            // LastShipLbl
            // 
            this.LastShipLbl.AutoSize = true;
            this.LastShipLbl.ForeColor = System.Drawing.Color.Blue;
            this.LastShipLbl.Location = new System.Drawing.Point(600, 291);
            this.LastShipLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastShipLbl.Name = "LastShipLbl";
            this.LastShipLbl.Size = new System.Drawing.Size(57, 13);
            this.LastShipLbl.TabIndex = 118;
            this.LastShipLbl.Text = "LSD Label";
            // 
            // ShipOnHandQtyLbl
            // 
            this.ShipOnHandQtyLbl.AutoSize = true;
            this.ShipOnHandQtyLbl.ForeColor = System.Drawing.Color.Blue;
            this.ShipOnHandQtyLbl.Location = new System.Drawing.Point(600, 267);
            this.ShipOnHandQtyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShipOnHandQtyLbl.Name = "ShipOnHandQtyLbl";
            this.ShipOnHandQtyLbl.Size = new System.Drawing.Size(52, 13);
            this.ShipOnHandQtyLbl.TabIndex = 116;
            this.ShipOnHandQtyLbl.Text = "OH Label";
            // 
            // ShippedQtyLbl
            // 
            this.ShippedQtyLbl.AutoSize = true;
            this.ShippedQtyLbl.ForeColor = System.Drawing.Color.Blue;
            this.ShippedQtyLbl.Location = new System.Drawing.Point(600, 243);
            this.ShippedQtyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShippedQtyLbl.Name = "ShippedQtyLbl";
            this.ShippedQtyLbl.Size = new System.Drawing.Size(57, 13);
            this.ShippedQtyLbl.TabIndex = 115;
            this.ShippedQtyLbl.Text = "Ship Label";
            // 
            // ShipInitRcvQty
            // 
            this.ShipInitRcvQty.AutoSize = true;
            this.ShipInitRcvQty.ForeColor = System.Drawing.Color.Blue;
            this.ShipInitRcvQty.Location = new System.Drawing.Point(600, 219);
            this.ShipInitRcvQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShipInitRcvQty.Name = "ShipInitRcvQty";
            this.ShipInitRcvQty.Size = new System.Drawing.Size(59, 13);
            this.ShipInitRcvQty.TabIndex = 114;
            this.ShipInitRcvQty.Text = "Rec. Label";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(514, 291);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(80, 13);
            this.label61.TabIndex = 113;
            this.label61.Text = "Last Ship Date:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(514, 267);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(72, 13);
            this.label59.TabIndex = 111;
            this.label59.Text = "On Hand Qty:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(514, 243);
            this.label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(68, 13);
            this.label58.TabIndex = 110;
            this.label58.Text = "Shipped Qty:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(514, 219);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(79, 13);
            this.label57.TabIndex = 109;
            this.label57.Text = "Initial Rec. Qty:";
            // 
            // BoxesTB
            // 
            this.BoxesTB.Location = new System.Drawing.Point(97, 285);
            this.BoxesTB.Margin = new System.Windows.Forms.Padding(2);
            this.BoxesTB.Name = "BoxesTB";
            this.BoxesTB.Size = new System.Drawing.Size(47, 20);
            this.BoxesTB.TabIndex = 108;
            this.BoxesTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_KeyPress);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(7, 287);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(39, 13);
            this.label56.TabIndex = 107;
            this.label56.Text = "Boxes:";
            // 
            // ShipViaCombo
            // 
            this.ShipViaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShipViaCombo.FormattingEnabled = true;
            this.ShipViaCombo.Location = new System.Drawing.Point(254, 252);
            this.ShipViaCombo.Margin = new System.Windows.Forms.Padding(2);
            this.ShipViaCombo.Name = "ShipViaCombo";
            this.ShipViaCombo.Size = new System.Drawing.Size(126, 21);
            this.ShipViaCombo.TabIndex = 106;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(196, 259);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(49, 13);
            this.label55.TabIndex = 105;
            this.label55.Text = "Ship Via:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(390, 66);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(34, 13);
            this.label54.TabIndex = 104;
            this.label54.Text = "Color:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(4, 254);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(59, 13);
            this.label53.TabIndex = 103;
            this.label53.Text = "Tracking #";
            // 
            // TrackingTB
            // 
            this.TrackingTB.Location = new System.Drawing.Point(78, 252);
            this.TrackingTB.Margin = new System.Windows.Forms.Padding(2);
            this.TrackingTB.Name = "TrackingTB";
            this.TrackingTB.Size = new System.Drawing.Size(101, 20);
            this.TrackingTB.TabIndex = 102;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(200, 220);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(57, 13);
            this.label51.TabIndex = 101;
            this.label51.Text = "Ship Date:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(514, 315);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(61, 13);
            this.label50.TabIndex = 100;
            this.label50.Text = "Back Order";
            // 
            // ToShipTB
            // 
            this.ToShipTB.Location = new System.Drawing.Point(97, 220);
            this.ToShipTB.Margin = new System.Windows.Forms.Padding(2);
            this.ToShipTB.Name = "ToShipTB";
            this.ToShipTB.Size = new System.Drawing.Size(47, 20);
            this.ToShipTB.TabIndex = 98;
            this.ToShipTB.TextChanged += new System.EventHandler(this.ToShipTB_TextChanged);
            this.ToShipTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_KeyPress);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(4, 220);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(86, 13);
            this.label52.TabIndex = 99;
            this.label52.Text = "Quantity To Ship";
            // 
            // PartCombo
            // 
            this.PartCombo.FormattingEnabled = true;
            this.PartCombo.Location = new System.Drawing.Point(96, 63);
            this.PartCombo.Margin = new System.Windows.Forms.Padding(2);
            this.PartCombo.Name = "PartCombo";
            this.PartCombo.Size = new System.Drawing.Size(254, 21);
            this.PartCombo.TabIndex = 93;
            this.PartCombo.SelectedIndexChanged += new System.EventHandler(this.PartCombo_SelectedIndexChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(4, 65);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(69, 13);
            this.label46.TabIndex = 97;
            this.label46.Text = "Part Number:";
            // 
            // custNamelbl
            // 
            this.custNamelbl.AutoSize = true;
            this.custNamelbl.ForeColor = System.Drawing.Color.Blue;
            this.custNamelbl.Location = new System.Drawing.Point(96, 41);
            this.custNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.custNamelbl.Name = "custNamelbl";
            this.custNamelbl.Size = new System.Drawing.Size(111, 13);
            this.custNamelbl.TabIndex = 96;
            this.custNamelbl.Text = "Customer Name Label";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(4, 41);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(85, 13);
            this.label48.TabIndex = 95;
            this.label48.Text = "Customer Name:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(4, 19);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(68, 13);
            this.label49.TabIndex = 94;
            this.label49.Text = "Customer ID:";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn13.DividerWidth = 1;
            this.dataGridViewTextBoxColumn13.HeaderText = "P.O. #";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 75;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn14.HeaderText = "Received Date";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 120;
            // 
            // RecQty
            // 
            this.RecQty.HeaderText = "Rcv Qty";
            this.RecQty.MinimumWidth = 60;
            this.RecQty.Name = "RecQty";
            this.RecQty.ReadOnly = true;
            this.RecQty.Width = 60;
            // 
            // FabRej
            // 
            this.FabRej.HeaderText = "Fab Reject";
            this.FabRej.MinimumWidth = 60;
            this.FabRej.Name = "FabRej";
            this.FabRej.ReadOnly = true;
            this.FabRej.Width = 60;
            // 
            // PaintRej
            // 
            this.PaintRej.HeaderText = "Paint Reject";
            this.PaintRej.MinimumWidth = 60;
            this.PaintRej.Name = "PaintRej";
            this.PaintRej.ReadOnly = true;
            this.PaintRej.Width = 60;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Avail To Ship";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 80;
            // 
            // Shipped
            // 
            this.Shipped.HeaderText = "Shipped";
            this.Shipped.MinimumWidth = 80;
            this.Shipped.Name = "Shipped";
            this.Shipped.ReadOnly = true;
            this.Shipped.Width = 80;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // OnHand
            // 
            this.OnHand.HeaderText = "OnHand";
            this.OnHand.Name = "OnHand";
            this.OnHand.ReadOnly = true;
            this.OnHand.Visible = false;
            // 
            // Shipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.ShipColorLbl);
            this.Controls.Add(this.BackOrderlbl);
            this.Controls.Add(this.label215);
            this.Controls.Add(this.InvPOGrid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CustCombo);
            this.Controls.Add(this.PackListComment);
            this.Controls.Add(this.Ship);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BillToCombo);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.LastShipLbl);
            this.Controls.Add(this.ShipOnHandQtyLbl);
            this.Controls.Add(this.ShippedQtyLbl);
            this.Controls.Add(this.ShipInitRcvQty);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.BoxesTB);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.ShipViaCombo);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.TrackingTB);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.ToShipTB);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.PartCombo);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.custNamelbl);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label49);
            this.Name = "Form2";
            this.Text = "Shipping";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvPOGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShipColorLbl;
        private System.Windows.Forms.Label BackOrderlbl;
        private System.Windows.Forms.Label label215;
        private System.Windows.Forms.DataGridView InvPOGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CustCombo;
        private System.Windows.Forms.Button PackListComment;
        private System.Windows.Forms.Button Ship;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label CompanyNamelbl;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label Addrlbl;
        private System.Windows.Forms.ComboBox AddrCombo;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.ComboBox BillToCombo;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label LastShipLbl;
        private System.Windows.Forms.Label ShipOnHandQtyLbl;
        private System.Windows.Forms.Label ShippedQtyLbl;
        private System.Windows.Forms.Label ShipInitRcvQty;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox BoxesTB;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox ShipViaCombo;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox TrackingTB;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox ToShipTB;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ComboBox PartCombo;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label custNamelbl;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn FabRej;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaintRej;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnHand;
    }
}