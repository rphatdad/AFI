using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Collections;
using System.Windows.Forms;


namespace AFI
{

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        private ArrayList PartsCustDelList = new ArrayList();
        private ArrayList PartsCustAddList = new ArrayList();
        private Boolean PartSaveClicked = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'afiPartsDataSet1.LINESPEED' table. You can move, or remove it, as needed.
            this.lINESPEEDTableAdapter.Fill(this.afiPartsDataSet1.LINESPEED);
            // TODO: This line of code loads data into the 'afiPartsDataSet1.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.afiPartsDataSet1.Parts);
            this.custBillShipAddrTableAdapter1.Fill(afiPartsDataSet1.CustBillShipAddr);
            this.customerTableAdapter1.Fill(afiPartsDataSet1.Customer);
            this.colorTableAdapter1.Fill(afiPartsDataSet1.Color);
            this.lINESPEEDTableAdapter.Fill(afiPartsDataSet1.LINESPEED);
        }

        

        private void label218_Click(object sender, EventArgs e)
        {   //BACKORDER
            //Initial Received - Inventory -FAB Reject
        }

        private void label62_Click(object sender, EventArgs e)
        {
            //Initial Received QTY 
            //total quantity off all Pos receivedqty per part number
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //PO NUMBER FOR MOTORSPORTS is AUTOGEN
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hello world");
        }

        

        private void button68_Click(object sender, EventArgs e)
        {
            
            Form2 f = new Form2(int.Parse(CustIDcombo.SelectedValue.ToString()),"NEW");
            f.ShowDialog();
           
            poplist();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //Delete the current record.
            //afiPartsDataSet1.CustBillShipAddr.AddCustBillShipAddrRow(99, textBox25.Text, comboBox1.SelectedText, textBox26.Text, textBox1.Text, textBox27.Text, comboBox19.SelectedText, textBox28.Text);
            if (CustIDcombo.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the current Customer? " +
                    "Doing so will also delete all the BillTo and ShipTo Addresses contained for that customer.",
                    "Delete Customer?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

                if (result == DialogResult.Yes)
                {

                    try
                    {

                        // Delete all the Channels for the current Folder.
                        int custID = (int)CustIDcombo.SelectedValue;
                        //Call function to delete custid stuff from billto shipto table
                        // Delete the Customer itself.
                        AFIPartsDataSet.CustomerRow customer = afiPartsDataSet1.Customer.FindByID(custID);
                        customer.Delete();

                        int rowsAffected = customerTableAdapter1.Update(afiPartsDataSet1);

                        if (rowsAffected > 0)
                        {
                            statusLabel.Text = "Customer successfully deleted.";
                        }
                        deleteallcustaddr(custID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem when deleting customer:" + ex.Message);
                    }
                    poplist();
                }
            }
        }

        
        private void CustIDcombo_Validated(object sender, EventArgs e)
        {
            afiPartsDataSet1.Customer.CUSTSHORTNAMEColumn.Unique = true;
            try
            {
                AFIPartsDataSet.CustomerRow customer = afiPartsDataSet1.Customer.NewCustomerRow();
                customer.CUSTSHORTNAME = CustIDcombo.Text;
                afiPartsDataSet1.Customer.AddCustomerRow(customer);
                int index;
                // Search the Item that matches the string typed
                index = CustIDcombo.FindString(customer.CUSTSHORTNAME);
                // Select the Item in the Combo
                CustIDcombo.SelectedIndex = index;
                textBox24.Focus();
                clearlist();
            }
            catch (Exception ex)
            {
                poplist();
                //MessageBox.Show("AlreadyHere "+ ex.Message);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //Update the current record.
            CustomerBindingSource.EndEdit();
            int result;
            result = customerTableAdapter1.Update(afiPartsDataSet1);
            MessageBox.Show(result.ToString() + " records updated");
        }

        private void clearlist()
        {
            int i;
            i = dataGridView5.RowCount-1;
            while (dataGridView5.RowCount > 0)
            {
                dataGridView5.Rows.RemoveAt(i);
                i--;
            }
        }

        private void deleteallcustaddr(int custid)
        {
            try
            {
                if(dataGridView5.SelectedCells.Count > 0)
                {
                    SqlConnection sqlConnection1 = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
                    SqlCommand cmd = new SqlCommand();
                                
                    cmd.CommandText = "Delete FROM CustBillShipAddr where CUSTOMERID ='" + custid.ToString() + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlConnection1;

                    sqlConnection1.Open();
                    int rowsdeleted;
                    rowsdeleted = cmd.ExecuteNonQuery();
               
                    // Data is accessible through the DataReader object here.

                    sqlConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void poplist()
        {
            try
            {
                SqlConnection sqlConnection1 = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                cmd.CommandText = "SELECT ADDRESSNAME, ADDRESSTYPE FROM CustBillShipAddr where CUSTOMERID ='" + CustIDcombo.SelectedValue.ToString() + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                clearlist();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dataGridView5);
                    item.Cells[0].Value = reader[0];
                    item.Cells[1].Value = reader[1];
                    dataGridView5.Rows.Add(item);
                }
                reader.Close();

                // Data is accessible through the DataReader object here.

                sqlConnection1.Close();
            }
            catch (Exception ex)
            { }
        }
        private void tabPage6_Enter(object sender, EventArgs e)
        {
            poplist();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            poplist();
        }
         
        private void CustIDcombo_SelectedValueChanged(object sender, EventArgs e)
        {
            poplist();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            // Delete Address
            if (dataGridView5.SelectedCells.Count > 0)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete the current Address? " +
                    "Doing so will also delete the  selected BillTo or ShipTo Address.",
                    "Delete Address?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection sqlConnection1 = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
                        SqlCommand cmd = new SqlCommand();
                        String strAddrName;
                        String strAddrType;

                        strAddrName = dataGridView5.SelectedCells[0].Value.ToString();
                        strAddrType = dataGridView5.SelectedCells[1].Value.ToString();
                        cmd.CommandText = "Delete FROM CustBillShipAddr where CUSTOMERID ='" + CustIDcombo.SelectedValue.ToString() + "' AND ADDRESSNAME ='" + strAddrName + "' AND ADDRESSTYPE ='" + strAddrType + "'";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = sqlConnection1;
                        sqlConnection1.Open();
                        int rowsdeleted;
                        rowsdeleted = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsdeleted.ToString());

                        // Data is accessible through the DataReader object here.

                        sqlConnection1.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    poplist();
                }
            }
        }

        private void dataGridView5_DoubleClick(object sender, EventArgs e)
        {
            EditAddress();
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            EditAddress();
        }

        private void EditAddress()
        {
            try
            {
                SqlConnection sqlConnection1 = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                DataGridViewRow item = dataGridView5.SelectedRows[0];
                String strAddrName = item.Cells[0].Value.ToString(); ;
                String strAddrType = item.Cells[1].Value.ToString();
                String Result;
                cmd.CommandText = "SELECT ID,ADDRESS1,ADDRESS2,CITY,STATE,ZIP FROM CustBillShipAddr where CUSTOMERID ='" + CustIDcombo.SelectedValue.ToString() + "' AND ADDRESSNAME ='" + strAddrName + "' AND ADDRESSTYPE = '" +strAddrType +"'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                clearlist();
                Result = "";
              
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    /*0 ID 
                      1 Name 
                      2 Type 
                      3 Address1 
                      4 Address2 
                      5 City 
                      6 State 
                      7 ZIP*/
                    Result = reader[0].ToString() +"~" + strAddrName + "~" + strAddrType + "~" + reader[1].ToString() + "~" + reader[2].ToString() + "~" + reader[3].ToString() + "~" + reader[4].ToString() + "~" + reader[5].ToString();              
                }
                reader.Close();

                // Data is accessible through the DataReader object here.

                sqlConnection1.Close();

                Form2 f = new Form2(int.Parse(CustIDcombo.SelectedValue.ToString()), Result);
                f.ShowDialog();
                poplist();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Edit Address " + ex.Message);
            }
        }

        private void abbrevBox_Validated(object sender, EventArgs e)
        {
            afiPartsDataSet1.Color.ABREVColumn.Unique = true;
            try
            {
                AFIPartsDataSet.ColorRow Ccolor = afiPartsDataSet1.Color.NewColorRow();
                Ccolor.ABREV = abbrevBox.Text;
                afiPartsDataSet1.Color.AddColorRow(Ccolor);
                int index;
                // Search the Item that matches the string typed
                index = abbrevBox.FindString(Ccolor.ABREV);
                // Select the Item in the Combo
                abbrevBox.SelectedIndex = index;
                textBox25.Focus();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("AlreadyHere "+ ex.Message);
            }
        }

        private void button71_Click(object sender, EventArgs e)
         {
            try
            {
                //Save for Color
                if (abbrevBox.Text != "")
                {
                    ColorBindingSource.EndEdit();
                    int result;
                    result = colorTableAdapter1.Update(afiPartsDataSet1);
                    MessageBox.Show(result.ToString() + " records updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            // Delete Color
            if (abbrevBox.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the current Color? " +
                    "Doing so will also perminately delete the color from the database.",
                    "Delete Color?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //Update the current record.

                        SqlConnection sqlConnection1 = new SqlConnection(colorTableAdapter1.Connection.ConnectionString);
                        SqlCommand cmd = new SqlCommand();

                        cmd.CommandText = "Delete FROM Color where ID ='" + abbrevBox.SelectedValue.ToString() + "'";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = sqlConnection1;

                        sqlConnection1.Open();
                        int rowsdeleted;
                        rowsdeleted = cmd.ExecuteNonQuery();
                        sqlConnection1.Close();
                        this.colorTableAdapter1.Fill(afiPartsDataSet1.Color);
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void PartNoCombo_Validated(object sender, EventArgs e)
        {
            afiPartsDataSet1.Parts.PARTNOColumn.Unique = true;
            try
            {
                AFIPartsDataSet.PartsRow Part = afiPartsDataSet1.Parts.NewPartsRow();
                Part.PARTNO = PartNoCombo.Text;
                afiPartsDataSet1.Parts.AddPartsRow(Part);
                int index;
                // Search the Item that matches the string typed
                index = PartNoCombo.FindString(Part.PARTNO);
                // Select the Item in the Combo
                PartNoCombo.SelectedIndex = index;
                InitPartsPage();
                PartImageTB.Focus();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("AlreadyHere "+ ex.Message);
            }
        }

        private void comboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void LoadPartsCombos(int partID)
        {

        }

        private void LoadUnAssignedCustomers(int partID)
        {
            PartsUnSelectedCustList.Items.Clear();
            
            SqlConnection conn = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
            SqlCommand command = new SqlCommand("SPGetUnusedCust", conn);
            command.CommandType = CommandType.StoredProcedure;    
            command.Parameters.Add("@parameter1", SqlDbType.Int).Value = partID;   
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PartsUnSelectedCustList.Items.Add(reader["CUSTSHORTNAME"]);
            }
            reader.Close();
            conn.Close();    

        }
        private int GetCustID(string CustName)
        {
            SqlConnection conn = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
            SqlCommand command = new SqlCommand("SPGetCustID", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@parameter1", SqlDbType.VarChar).Value = CustName;
            conn.Open();
            int rval = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               rval  = int.Parse((reader["ID"]).ToString());
            }
            reader.Close();
            conn.Close();
            return rval;
        }

        private void LoadAssignedCustomers(int partID)
        {
            PartsSelectedCustList.Items.Clear();

            SqlConnection conn = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
            SqlCommand command = new SqlCommand("SPGetPartsCust", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@parameter1", SqlDbType.Int).Value = partID;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PartsSelectedCustList.Items.Add(reader["CUSTSHORTNAME"]);
            }
            reader.Close();
            conn.Close();    

        }

        /// <summary>
        /// PARTS TAB CONTROLS AND LOGIC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PartNoCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            InitPartsPage();
        }



        private void tabPage7_Enter(object sender, EventArgs e)
        {
            InitPartsPage();

        }

        private void InitPartsPage()
        {
            try
            {
                if (!PartSaveClicked)
                {
                    PartsCustDelList.Clear();
                    PartsCustAddList.Clear();
                    LoadAssignedCustomers(int.Parse(PartNoCombo.SelectedValue.ToString()));
                    LoadUnAssignedCustomers(int.Parse(PartNoCombo.SelectedValue.ToString()));
                    LoadPartsCombos(int.Parse(PartNoCombo.SelectedValue.ToString()));
                }
            }
            catch (Exception ex)
            { }

        }


        private void PartsUnSelectedCustList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PartsSelectedCustList.SelectedIndex != -1)
            {
                PartsSelectedCustList.ClearSelected();
            }
        }

        private void PartsSelectedCustList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PartsUnSelectedCustList.SelectedIndex != -1)
            {
                PartsUnSelectedCustList.ClearSelected();
            }
        }

        private void PartFolderButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(Parts Images)|*.jpg;*.gif;*.pdf";
            openFileDialog1.ShowDialog();
        }

        

        private void PartViewrButton_Click(object sender, EventArgs e)
        {
            //To Do PartView
        }

        private void PartaddCustButton_Click(object sender, EventArgs e)
        {
            //Add Part
            try
            {
                if (PartsUnSelectedCustList.SelectedItem.ToString() != "")
                {
                    PartsCustAddList.Add(PartsUnSelectedCustList.SelectedItem.ToString());
                    PartsSelectedCustList.Items.Add(PartsUnSelectedCustList.SelectedItem.ToString());
                    PartsUnSelectedCustList.Items.Remove(PartsUnSelectedCustList.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void PartDelButton_Click(object sender, EventArgs e)
        {
            //PartDeleteButton
            if (PartNoCombo.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the current Part? " +
                    "Doing so will also perminately delete the part from the database.",
                    "Delete Part?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //Update the current record.

                        SqlConnection sqlConnection1 = new SqlConnection(colorTableAdapter1.Connection.ConnectionString);
                        SqlCommand cmd = new SqlCommand();

                        cmd.CommandText = "Delete FROM Parts where ID ='" + PartNoCombo.SelectedValue.ToString() + "'";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = sqlConnection1;

                        sqlConnection1.Open();
                        int rowsdeleted;
                        rowsdeleted = cmd.ExecuteNonQuery();

                        cmd.CommandText = "Delete FROM PartCustLink where PartID ='" + PartNoCombo.SelectedValue.ToString() + "'";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = sqlConnection1;
                       
                        rowsdeleted = cmd.ExecuteNonQuery();
                        sqlConnection1.Close();
                        this.partsTableAdapter.Fill(afiPartsDataSet1.Parts);
                        InitPartsPage();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }



        private void PartdelCustButton_Click(object sender, EventArgs e)
        {
            //Delete Customer
            try
            {
                if (PartsSelectedCustList.SelectedItem.ToString() != "")
                {
                    PartsCustDelList.Add(PartsSelectedCustList.SelectedItem.ToString());
                    PartsUnSelectedCustList.Items.Add(PartsSelectedCustList.SelectedItem);
                    PartsSelectedCustList.Items.Remove(PartsSelectedCustList.SelectedItem);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void UpdateUnBoundPartsFields(string partno, string Col, string MinConvSpeed, Boolean Checked)
        {
            try
            {
                SqlConnection conn = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
                SqlCommand command = new SqlCommand("SPPartsUnBound", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Original_ID", SqlDbType.Int).Value = int.Parse(partno);
                command.Parameters.Add("@COLORNAME", SqlDbType.VarChar).Value = Col;
                command.Parameters.Add("@MINCONVSPEED", SqlDbType.NVarChar).Value = MinConvSpeed;
                command.Parameters.Add("@BLOWEXCESSWATER", SqlDbType.VarChar).Value = (Checked ? "Y" : "N");
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex){}
        }
        private void PartSaveButton_Click(object sender, EventArgs e)
        {
            //Parts Save Button
            /* if partid exist tnen update parts table
             * else 
             * insert into table
             * 
             * delete all from partcustlink
             * insert all from column into partcust link
             */
            PartSaveClicked = true;
            if (PartNoCombo.Text != "")
            {
                try
                {
                    //Update the current record.
                    PartsBindingSource.EndEdit();
                    int result;
                    //DataRow dr = new DataRow();
                    
                    result = partsTableAdapter.Update(afiPartsDataSet1);
                    //result = partsTableAdapter.Update(PartNoCombo.Text,PartImageTB.Text,PartDescTB.Text,
                     //   PartColorCombo.Text,PowderNoTB.Text,int.Parse(CureTempTB.Text),int.Parse(MillageTB.Text),
                       // int.Parse(comboBox3.Text),int.Parse(MinPiecesTB.Text),
                    UpdateUnBoundPartsFields(PartNoCombo.SelectedValue.ToString(),PartColorCombo.Text,comboBox3.Text,checkBox2.Checked);
                    MessageBox.Show(result.ToString() + " records updated");

                    SqlConnection sqlConnection1 = new SqlConnection(colorTableAdapter1.Connection.ConnectionString);
                    SqlCommand cmd = new SqlCommand();
                    int rowsdeleted;
                    int rowsadded;

                    sqlConnection1.Open();

                    cmd.CommandText = "Delete FROM PartCustLink where PartID ='" + PartNoCombo.SelectedValue.ToString() + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlConnection1;

                    rowsdeleted = cmd.ExecuteNonQuery();
                    foreach (string cust in PartsSelectedCustList.Items)
                    {
                        cmd.CommandText = "INSERT INTO PARTCUSTLINK (PARTID, CUSTID) VALUES ('" + PartNoCombo.SelectedValue.ToString() + "','" + GetCustID(cust) + "')";
                        //MessageBox.Show(cmd.CommandText);
                        rowsadded = cmd.ExecuteNonQuery();
                    }

                    sqlConnection1.Close();
                    PartsBindingSource.EndEdit();
                    this.partsTableAdapter.Fill(afiPartsDataSet1.Parts);
                    PartSaveClicked = false;
                    InitPartsPage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void PartCancelButton_Click(object sender, EventArgs e)
        {
            //PartsCancelButton
        }

        private void PartNoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button72_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Parts Tab
            tabControl1.SelectedTab = this.tabPage7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearRcv();
        }

        private void ClearRcv()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            label68.Text = "";
            checkBox1.Checked = false;
            dateTimePicker2.Value = System.DateTime.Now;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearRcv();
            PopPartsList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearRcv();
            int custID = int.Parse(comboBox2.SelectedValue.ToString());
            SqlConnection conn = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
            SqlCommand command = new SqlCommand("SPGetPartColor", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@parameter1", SqlDbType.Int).Value = custID;
            command.Parameters.Add("@parameter2", SqlDbType.VarChar).Value = comboBox1.Text.ToString();

            conn.Open();
            label68.Text = command.ExecuteScalar().ToString();
            conn.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PopPartsList()
        {
            try
            {
                int custID = int.Parse(comboBox2.SelectedValue.ToString());

                comboBox1.Items.Clear();

                SqlConnection conn = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
                SqlCommand command = new SqlCommand("SPGetCustParts", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@parameter1", SqlDbType.Int).Value = custID;
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["PartNO"]);
                    
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
               
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                ClearRcv();
                PopPartsList();
            }
        } 

        private void button4_Click(object sender, EventArgs e)
        {
            // Search functionality Needs to call stored procedure
            // that uses custnumber and partnumber to bring a list of PO's
            // on another form if not it displays none found if there is 
            // only 1 it displays it.

            //BUGS IN HERE DUDE
            //Bug 1 Check to make sure both parameters have values
            //Bug 2 Date Time fucked

            Form3 SelectionDlg = new Form3(comboBox1.SelectedItem.ToString(), int.Parse(comboBox2.SelectedValue.ToString()));
            SelectionDlg.ShowDialog();
            if (SelectionDlg.rcvPO == null)
            {
                SelectionDlg.Close();
                SelectionDlg.Dispose();
            }
            else
            {
                label68.Text = SelectionDlg.rcvPO.Color;
                textBox7.Text = SelectionDlg.rcvPO.Comments;
                textBox2.Text = SelectionDlg.rcvPO.PoNumber;
                textBox3.Text = SelectionDlg.rcvPO.Qty.ToString();
                dateTimePicker2.Value = SelectionDlg.rcvPO.RcvDate;
                textBox4.Text = SelectionDlg.rcvPO.TrackingNumber;
                checkBox1.Checked = SelectionDlg.rcvPO.HotPart;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete removes current PO from system
            //Needs SP to do delete based on PartNO PO NO and custNO
            string connectionString = ConfigurationManager.ConnectionStrings["AFI.Properties.Settings.Database1ConnectionString"].ConnectionString;

            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SPGetRCVPO", sqlConnection1);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@CUSTOMERID", SqlDbType.Int).Value = int.Parse(comboBox2.SelectedValue.ToString());
            command.Parameters.Add("@PARTNUMBER", SqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();
            command.Parameters.Add("@PONUMBER", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@RECEIVEDATE", SqlDbType.DateTime).Value = dateTimePicker2.Value;
            sqlConnection1.Open();
            command.ExecuteNonQuery();
            sqlConnection1.Close();
            ClearRcv();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string eMess = ReceivingValidate();
            if (eMess == "")
            {
            // Saves current record to the database
                SqlConnection conn = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
                SqlCommand command = new SqlCommand("SPRCVPOUpdate", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PONUMBER", SqlDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@CUSTOMERID", SqlDbType.Int).Value = int.Parse(comboBox2.SelectedValue.ToString());
                command.Parameters.Add("@PARTNUMBER", SqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();
                command.Parameters.Add("@TRACKINGNUMBER", SqlDbType.VarChar).Value = textBox4.Text;
                command.Parameters.Add("@RECEIVEDATE", SqlDbType.DateTime).Value = dateTimePicker2.Value.ToString();
                command.Parameters.Add("@HOTPART", SqlDbType.VarChar).Value = (checkBox1.Checked ? "Y" : "N");
                command.Parameters.Add("@COLOR", SqlDbType.VarChar).Value = label68.Text;
                command.Parameters.Add("@COMMENTS", SqlDbType.VarChar).Value = textBox7.Text;
                command.Parameters.Add("@INITIALQTY", SqlDbType.Int).Value = int.Parse(textBox3.Text);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                  MessageBox.Show(eMess,"Receiving Validation Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Prints Router Report based on current dataset

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Now in " + this.tabControl1.SelectedTab.Text.ToString());
            if (this.tabControl1.SelectedTab.Text.ToString() == "Count Verification/Inventory")
            {
                //RSSTUB FOR Clear Inv Form
                clearinvlist();
                ClearInv();
            }
        }

        private string ReceivingValidate()
        {
            string sMess = "";
            if (comboBox1.SelectedItem == "")
            {
                sMess = "No Part Number Selected.\n";
            }
            if (textBox2.Text == "")
            {
                sMess = sMess + "No PO Entered.\n";
            }
            if (textBox3.Text =="" )
            {
                sMess = sMess + "No Quantity Entered.\n";
            }
            if (textBox4.Text == "")
            {
                sMess = sMess + "No Tracking Number Entered.\n";
            }
            return sMess;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // To Inv Ship
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                EditInvComment();
                button10_Click(sender, e);
            }
        }


        private void ClearInv()
        {
            textBox6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            label13.Text = "";
            clearinvlist();
            comboBox5.Items.Clear();
            //Clear DataGridview
            //Clear Inv Comments
        }

        private void PopInvPartsList()
        {
            try
            {
                int custID = int.Parse(comboBox20.SelectedValue.ToString());

                comboBox5.Items.Clear();

                SqlConnection conn = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
                SqlCommand command = new SqlCommand("SPGetCustParts", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@parameter1", SqlDbType.Int).Value = custID;
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox5.Items.Add(reader["PartNO"]);

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }



        private void clearinvlist()
        {
            int i;
            try
            {
                i = dataGridView1.RowCount - 1;
                while (dataGridView1.RowCount > 0)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;
                }
            }
            catch (Exception ex)
            { }
        }

        private int popinvlist()
        {
            int count = 0;
            try
            {
                int totalavqty = 0;
                string connectionString = ConfigurationManager.ConnectionStrings["AFI.Properties.Settings.Database1ConnectionString"].ConnectionString;

                SqlConnection sqlConnection1 = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("SPGetOpenPOS", sqlConnection1);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@CUSTOMERID", SqlDbType.Int).Value = int.Parse(comboBox20.SelectedValue.ToString());
                command.Parameters.Add("@PARTNUMBER", SqlDbType.VarChar).Value = comboBox5.SelectedItem.ToString();

                sqlConnection1.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dataGridView1);
                    item.Cells[0].Value = reader["PONUMBER"];
                    item.Cells[1].Value = reader["RECEIVEDATE"];
                    item.Cells[2].Value = reader["INVENTORYQTY"];
                    item.Cells[3].Value = reader["PAINTREJECTQTY"];
                    item.Cells[4].Value = reader["FABREJECTQTY"];
                    item.Cells[5].Value = reader["ONHANDQTY"];
                    item.Cells[6].Value = reader["INVCOMMENT"];
                    if (item.Cells[2].Value.ToString() == "")
                    {
                        item.Cells[2].Value = "0";
                    }
                    if (item.Cells[3].Value.ToString() == "")
                    {
                        item.Cells[3].Value = "0";
                    }
                    if (item.Cells[4].Value.ToString() == "")
                    {
                        item.Cells[4].Value = "0";
                    }
                    if (item.Cells[5].Value.ToString() == "")
                    {
                        item.Cells[5].Value = "0";
                    }
                    if (item.Cells[6].Value.ToString() != "")
                    {
                        item.Cells[7].Value = "*";
                    }
                    else
                    {
                        item.Cells[7].Value = "";
                    }
                    totalavqty = totalavqty+int.Parse(item.Cells[5].Value.ToString());
                    dataGridView1.Rows.Add(item);
                    count++;
                }
                reader.Close();
                label213.Text = totalavqty.ToString();
                // Data is accessible through the DataReader object here.

                sqlConnection1.Close();
                return count;
            }
            catch (Exception ex)
            { return count; }
        }




        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearinvlist();
            if (popinvlist() == 0)
            {
                MessageBox.Show("There are no Open PO's for this part");
            }
        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
            if (comboBox5.Items.Count == 0)
            {
                ClearInv();
                PopInvPartsList();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //To Inv Button
            int totalqty = 0;
            int qtytoinv = 0;
            int fabreject = 0;
            int paintreject = 0;

            totalqty = int.Parse(label213.Text);
            if (textBox6.Text != "")
            {
                qtytoinv = int.Parse(textBox6.Text);
            }
            if (textBox8.Text != "")
            {
                fabreject = int.Parse(textBox8.Text);
            }
            if (textBox9.Text != "")
            {
                paintreject = int.Parse(textBox9.Text);
            }

            
            if (VerifyInv(totalqty,qtytoinv,fabreject,paintreject))
            {
                int TotalInvUsed = qtytoinv + fabreject;
                UpdatePOInv(totalqty, qtytoinv, fabreject, paintreject);
                MessageBox.Show("Inventory has been updated!");
                
            }
        }

        private void UpdatePOInv(int TQ, int IQ, int FR, int PR)
        {
            int DataGrid_PO = 0;
            string DataGrid_RcvDate;
            int DataGrid_OnHand = 0;
            int DataGrid_FabR = 0;
            int DataGrid_PaintR = 0;
            int DataGrid_InvQuan = 0;
            int totalavqty = 0;
            String DataGrid_POStat;

           /* item.Cells[0].Value = reader["PONUMBER"];
            item.Cells[1].Value = reader["RECEIVEDATE"];
            item.Cells[2].Value = reader["INVENTORYQTY"];
            item.Cells[3].Value = reader["FABREJECTQTY"];
            item.Cells[4].Value = reader["PAINTREJECTQTY"];
            item.Cells[5].Value = reader["ONHANDQTY"];
            */
            
            int j = 0;
            while (j < dataGridView1.RowCount)
            {
                if (!((IQ == 0) && (FR == 0) && (PR == 0)))
                {
                    DataGrid_POStat = "OPEN";
                    DataGrid_PO = int.Parse(dataGridView1.Rows[j].Cells[0].Value.ToString());
                    DataGrid_InvQuan = int.Parse(dataGridView1.Rows[j].Cells[2].Value.ToString());
                    DataGrid_FabR = int.Parse(dataGridView1.Rows[j].Cells[4].Value.ToString());
                    DataGrid_PaintR = int.Parse(dataGridView1.Rows[j].Cells[3].Value.ToString());
                    DataGrid_OnHand = int.Parse(dataGridView1.Rows[j].Cells[5].Value.ToString());
                    if (DataGrid_OnHand <= IQ)
                    {
                        DataGrid_InvQuan = DataGrid_InvQuan + DataGrid_OnHand;
                        IQ = IQ - DataGrid_OnHand;
                        DataGrid_OnHand = 0;
                        DataGrid_POStat = "INV";
                    }
                    else
                    {
                        DataGrid_InvQuan = DataGrid_InvQuan + IQ;
                        DataGrid_OnHand = DataGrid_OnHand - IQ;
                        IQ = 0;
                        DataGrid_POStat = "OPEN_INV";
                    }

                    if (DataGrid_OnHand <= FR)
                    {
                        DataGrid_FabR = DataGrid_FabR + DataGrid_OnHand;
                        FR = FR - DataGrid_OnHand;
                        DataGrid_OnHand = 0;
                        DataGrid_POStat = "INV";
                    }
                    else
                    {
                        DataGrid_FabR = DataGrid_FabR + FR;
                        DataGrid_OnHand = DataGrid_OnHand - FR;
                        FR = 0;
                        DataGrid_POStat = "OPEN_INV";
                    }
                    // Paint Rejects not taken from onhand since need fixed
                    if (DataGrid_OnHand <= PR)
                    {
                        DataGrid_PaintR = DataGrid_PaintR + DataGrid_OnHand;
                        PR = PR - DataGrid_OnHand;

                    }
                    else
                    {
                        DataGrid_PaintR = DataGrid_PaintR + PR;
                        PR = 0;
                    }

                    dataGridView1.Rows[j].Cells[2].Value = DataGrid_InvQuan.ToString();
                    dataGridView1.Rows[j].Cells[4].Value = DataGrid_FabR.ToString();
                    dataGridView1.Rows[j].Cells[3].Value = DataGrid_PaintR.ToString();
                    dataGridView1.Rows[j].Cells[5].Value = DataGrid_OnHand.ToString();
                    SqlConnection conn = new SqlConnection(customerTableAdapter1.Connection.ConnectionString);
                    SqlCommand command = new SqlCommand("SPINVPOUpdate", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@PONUMBER", SqlDbType.VarChar).Value =  DataGrid_PO;
                    command.Parameters.Add("@CUSTOMERID", SqlDbType.Int).Value = int.Parse(comboBox20.SelectedValue.ToString());
                    command.Parameters.Add("@PARTNUMBER", SqlDbType.VarChar).Value = comboBox5.SelectedItem.ToString();
                    command.Parameters.Add("@RECEIVEDATE", SqlDbType.DateTime).Value =  dataGridView1.Rows[j].Cells[1].Value.ToString();
                    command.Parameters.Add("@INVCOMMENTS", SqlDbType.VarChar).Value = dataGridView1.Rows[j].Cells[6].Value;
                    command.Parameters.Add("@INVQTY", SqlDbType.Int).Value = int.Parse(DataGrid_InvQuan.ToString());
                    command.Parameters.Add("@FABR", SqlDbType.Int).Value = int.Parse(DataGrid_FabR.ToString());
                    command.Parameters.Add("@PAINTR", SqlDbType.Int).Value = int.Parse(DataGrid_PaintR.ToString());
                    command.Parameters.Add("@AVAIL", SqlDbType.Int).Value = int.Parse(DataGrid_OnHand.ToString());
                    command.Parameters.Add("@POSTAT", SqlDbType.VarChar).Value = DataGrid_POStat; 
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    //Update Database
                }
                j++;
                
                totalavqty = totalavqty + DataGrid_OnHand;

                //Clear form

            }

            textBox6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            label213.Text = totalavqty.ToString();
        }

        private bool VerifyInv(int TQ, int QI, int FR, int PR)
        {
            bool failure = true;
            string message="";
            if ((QI + FR + PR) > TQ )
            { 
                message = "Error: Total Entered Quantity exceeds total Quantity\n";
                failure = false;
            }
            if(QI > TQ )
            {
                message = message + "       Quantity To Inventory exceeds total Quantity\n";
                failure = false;
            }
            if (FR > TQ)
            {
                message = message + "       Fab Reject Quantity exceeds total Quantity\n";
                failure = false;
            }
            if (PR > TQ)
            {
                message = message + "       Paint Reject Quantity exceeds total Quantity\n";
                failure = false;
            }
            if (!failure)
            {
                MessageBox.Show(message, "Quantity Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return failure;

        }
        private void EditInvComment()
        {
            int totalqty = 0;
            totalqty = int.Parse(label213.Text);
            DataGridViewRow item = dataGridView1.SelectedRows[0];
            Form4 InvCmt;
            if (item.Cells[7].Value.ToString() == "*")
            {
                InvCmt = new Form4(item.Cells[6].Value.ToString());
            }
            else
            {
                InvCmt = new Form4("");
            }
            InvCmt.ShowDialog();
            if (InvCmt.Comment != "")
            {
                item.Cells[7].Value = "*";
            }
            else
            {
                item.Cells[7].Value = "";
            }
            item.Cells[6].Value = InvCmt.Comment;
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label213_Click(object sender, EventArgs e)
        {

        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInv();
            PopInvPartsList();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Packing List Comment Shipping Screen
        }

        
        private void ClearShip()
        {
            ShipPartCombo.Items.Clear();
            ShipInitRcvQty.Text = "";
            ShippedQtyLbl.Text = "";
            ShipOnHandQtyLbl.Text = "";
            label65.Text = "";
            label66.Text = "";
            label72.Text = "";
            label73.Text = "";
            label74.Text = ""; 
            label75.Text = "";
            ShipColorLbl.Text = "";
            label218.Text = "";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            //Prints Packing Slip

        }

        private void ShipPartCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Shipping Parts 
            ClearShip();
            /* PopInvPartsList();
            */
        }
   }
}