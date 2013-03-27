using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AFIObjects;

namespace AFIPO
{
    public partial class PartsForm : Form
    {

        private PartsList PartsL;
        private ColorsList ColorsL;

        private string[] cFeet =   {  "0","1","2","3","4",      // 1 
                                        "5","6","7","8","9",    // 2 
                                        "10","11","12","13" };  // 3 

        private string[] cConvSpeed = {  "0","1","2","3","4",   // 1 
                                         "5","6","7","8","9",   // 2 
                                         "10","11","12","13",   // 3
                                         "14", "15", "16" };  
        // 4 
        private string[] cHangers = { "A","B","C","D","E","F",  // 1
                                      "G","H","I","J","K","L",  // 2
                                      "M","N","O","P","Q","R",  // 3
                                      "S","T","U","V","W" };
                    

        private ArrayList PartsCustDelList = new ArrayList();
        private ArrayList PartsCustAddList = new ArrayList();

                                        
        public PartsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PartsL = new PartsList();
            PartNoCombo.DataSource = PartsL.ListParts();
            FeetCB.DataSource = cFeet;
            MinConvCB.DataSource = cConvSpeed;
            HangerCB.DataSource = cHangers;
            PartsSelectedCustList.Items.Clear();
            PartsUnSelectedCustList.Items.Clear();
            ColorsL = new ColorsList();
            PartColorCombo.DataSource = ColorsL.ListColors();
            Colors c = new Colors();
            c = ColorsL.SearchColor(PartColorCombo.SelectedItem.ToString());
            powderlbl.Text = c.ColorNumber;
            if (PartsL.PartExists(PartNoCombo.Text))
            {
                Part p1 = PartsL.SearchPart(PartNoCombo.Text);
                PartNoCombo.DataSource =PartsL.ListParts();
                Object2Form(p1);
            }
        }

        private void PartNoCombo_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void PartNoCombo_Validated(object sender, EventArgs e)
        {
            try
            {
                // If it is there then have it fill in fields
                if (PartsL.PartExists(PartNoCombo.Text))
                {
                    Part p1 = PartsL.SearchPart(PartNoCombo.Text);
                    PartNoCombo.DataSource =PartsL.ListParts();
                    Object2Form(p1);

                }
                // If not have it add item and then fill field from it;
                else
                {
                    Part p2 = PartsL.SearchPart(PartNoCombo.Text);
                    PartsL.AddItem(PartNoCombo.Text);
                    PartNoCombo.DataSource = PartsL.ListParts();
                    Object2Form(p2);
                }
                PartDescTB.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AlreadyHere " + ex.Message);
            }
        }
        private int Preformat(string s)
        {
            int i;

            if (!(int.TryParse(s, out i)))
            {
                return 0;
            }
            return i;
        }
        private Part Form2Object()
        {

            Part p = new Part(PartNoCombo.Text);
            
            p.Atomizing1 = Preformat(AA1TB.Text);
            p.Atomizing2 = Preformat(AA2TB.Text);
            if (BlowCb.Checked == true)
            {
                p.BlowExcessWater = "Y";
            }
            else
            { 
                p.BlowExcessWater = "N"; 
            }
            
            p.CapsQty = Preformat(TotalCaplbl.Text);
            p.ColorName = PartColorCombo.Text;
            p.CureTemp = Preformat(CureTempTB.Text);
            p.PartDesc = PartDescTB.Text;
            p.DotsQty = Preformat(TotalDotlbl.Text);
            p.Feet = Preformat(FeetCB.Text);
            p.FlowRate1 = Preformat(FR1TB.Text);
            p.FlowRate2 = Preformat(FR2TB.Text);
            p.Kv1 = Preformat(KV1TB.Text);
            p.Kv2 = Preformat(KV2TB.Text);
            p.MaskTime = double.Parse(MaskTimeTB.Text);
            p.Millage = Preformat(MillageTB.Text);
            p.MinConvSpeed = Preformat(MinConvCB.Text);
            p.MinPartsPerRack = Preformat(MinPartsPerTB.Text);
            p.MinPiecesPer = Preformat(MinPiecesTB.Text);
            p.PaintTime = double.Parse(PaintTimelbl.Text);
            p.PoundsPer = double.Parse(PoundsTB.Text);
            p.PlugsQty = Preformat(TotalPlugslbl.Text);
            p.PowderNumber = powderlbl.Text;
            if (PreMaskcb.Checked)
            {
                p.PreMask = "Y";
            }
            else
            {
                p.PreMask = "N";
            }
            p.Receipe1 = REC1TB.Text;
            p.Receipe2 = REC2TB.Text;
            p.SpecialNotes = SpecialNotesTB.Text;
            //p.SpotFace = SpotFaceTB.Text;
            p.SqFeet = double.Parse(SqFeetTB.Text);
            return (p);
           
        }

        private void Object2Form(Part p)
        {
            PartMaskLinkList pmList;

            AA1TB.Text = p.Atomizing1.ToString();
            AA2TB.Text = p.Atomizing2.ToString();
            if (p.BlowExcessWater == "Y")
            {
                BlowCb.Checked = true;
            }
            else
            {
                BlowCb.Checked = false;
            }
            pmList = new PartMaskLinkList(p.Id);

            TotalCaplbl.Text = pmList.GetMaskTotal("Cap").ToString();
            TotalPlugslbl.Text = pmList.GetMaskTotal("Plug").ToString();
            TotalDotlbl.Text = pmList.GetMaskTotal("Dot").ToString();

            int Index2 = PartColorCombo.FindString(p.ColorName);
            PartColorCombo.SelectedIndex = Index2;
            CureTempTB.Text = p.CureTemp.ToString();
            PartDescTB.Text = p.PartDesc;
            
            FeetCB.Text = p.Feet.ToString();
            FR1TB.Text = p.FlowRate1.ToString();
            FR2TB.Text = p.FlowRate2.ToString();
            KV1TB.Text = p.Kv1.ToString();
            KV2TB.Text = p.Kv2.ToString();
            MaskTimeTB.Text = p.MaskTime.ToString();
            MillageTB.Text = p.Millage.ToString();
            MinConvCB.Text = p.MinConvSpeed.ToString();
            MinPartsPerTB.Text = p.MinPartsPerRack.ToString();
            MinPiecesTB.Text = p.MinPiecesPer.ToString();
            PaintTimelbl.Text = p.PaintTime.ToString();
            int Index = PartNoCombo.FindString(p.PartNo);
            PartNoCombo.SelectedIndex = Index;
            PoundsTB.Text = p.PoundsPer.ToString();
            powderlbl.Text = p.PowderNumber;
            if (p.PreMask == "Y")
            {
                PreMaskcb.Checked = true;
            }
            else
            {
                PreMaskcb.Checked = false;
            }
            REC1TB.Text = p.Receipe1;
            REC2TB.Text = p.Receipe2;
            SpecialNotesTB.Text = p.SpecialNotes;
            //SpotFaceTB.Text = p.SpotFace;
            SqFeetTB.Text = p.SqFeet.ToString();
            // Load Parts Combos
            PartsSelectedCustList.Items.Clear();
            PartsUnSelectedCustList.Items.Clear();
            PartsCustAddList = PartsL.LoadAssignedCustomers(p.Id);
            PartsCustDelList = PartsL.LoadUnAssignedCustomers(p.Id);
            foreach (string sPart in PartsCustAddList)
            {
                PartsSelectedCustList.Items.Add(sPart);
            }
            foreach (string sPart in PartsCustDelList)
            {
                PartsUnSelectedCustList.Items.Add(sPart);
            }
        }

        private void PartaddCustButton_Click(object sender, EventArgs e)
        {
            //Add Part
            try
            {
                if (PartsUnSelectedCustList.SelectedItem.ToString() != "")
                {
                    PartsCustAddList.Add(PartsUnSelectedCustList.SelectedItem.ToString());
                    PartsCustDelList.Remove(PartsUnSelectedCustList.SelectedItem.ToString());
                    PartsSelectedCustList.Items.Add(PartsUnSelectedCustList.SelectedItem.ToString());
                    PartsUnSelectedCustList.Items.Remove(PartsUnSelectedCustList.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
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
                    PartsCustAddList.Remove(PartsSelectedCustList.SelectedItem.ToString());
                    PartsUnSelectedCustList.Items.Add(PartsSelectedCustList.SelectedItem);
                    PartsSelectedCustList.Items.Remove(PartsSelectedCustList.SelectedItem);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void PartSaveButton_Click(object sender, EventArgs e)
        {
            if (PartNoCombo.Text != "")
                {
                    if (PartsL.PartInDB(PartNoCombo.Text))
                    {
                        Part p = PartsL.SearchPart(PartNoCombo.Text);
                        int id = p.Id;
                        p = Form2Object();
                        p.Id = id;
                        PartsL.UpdatePart(p);
                        
                    }
                    else
                    {
                        PartsL.AddPart(Form2Object());
                    }
                    Part p2 = new Part();
                    p2 = PartsL.SearchPart(PartNoCombo.Text);
                    //CustIDcombo.DataSource = CustList.ListCustomers();
                    if (p2.Id > 0)
                    {
                        PartsL.SavePartsCustLink(p2.Id, PartsCustAddList);
                    }
                }
                
        }

        private void PartDelButton_Click(object sender, EventArgs e)
        {
            //Delete Customer
            if (PartNoCombo.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the current Part? " +
                    "Doing so will also perminately delete the Part from the database.",
                    "Part Customer?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly,
                    false);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Part p1 = new Part();
                        p1 = PartsL.SearchPart(PartNoCombo.Text);
                        PartsL.DeletePart(p1.Id);
                        PartNoCombo.DataSource = PartsL.ListParts();

                        if (PartNoCombo.Items.Count == 0)
                        {
                            AA1TB.Text = "";
                            AA2TB.Text = "";
                            BlowCb.Checked = false;
                            TotalCaplbl.Text = "0";
                            CureTempTB.Text = "";
                            PartDescTB.Text = "";
                            TotalDotlbl.Text= "0";
                            FeetCB.Text = "";
                            FR1TB.Text = "";
                            FR2TB.Text = "";
                            KV1TB.Text = "";
                            KV2TB.Text = "";
                            MaskTimeTB.Text = "";
                            MillageTB.Text = "";
                            MinConvCB.Text = "";
                            MinPartsPerTB.Text = "";
                            MinPiecesTB.Text = "";
                            PoundsTB.Text = "0";
                            PaintTimelbl.Text = "";
                            TotalPlugslbl.Text = "0";
                            powderlbl.Text = "";
                            PreMaskcb.Checked = false;
                            REC1TB.Text = "";
                            REC2TB.Text = "";
                            SpecialNotesTB.Text = "";
                           // SpotFaceTB.Text = "";
                            SqFeetTB.Text = "";
                            FeetCB.DataSource = cFeet;
                            MinConvCB.DataSource = cConvSpeed;
                            PartsSelectedCustList.Items.Clear();
                            PartsUnSelectedCustList.Items.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void PartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool txtNumericStringIsValid(TextBox txtNumericString)
        {
            if (txtNumericString.Text == string.Empty)
            {
                return true;
            }
            char[] testArr = txtNumericString.Text.ToCharArray();
            bool testBool = false;
            for (int i = 0; i < testArr.Length; i++)
            {
                if (!char.IsNumber(testArr[i]))
                {
                    testBool = true;
                }
            }
            return testBool;
        }

        private void PartsSelectedCustList_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        
        private void DotsTB_KeyPress(object sender, KeyPressEventArgs e)
        {
             // allows only numbers
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PartNoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Part p1 = PartsL.SearchPart(PartNoCombo.Text);
            Object2Form(p1);
        }

        private void PartColorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Colors c = new Colors();
            c = ColorsL.SearchColor(PartColorCombo.SelectedItem.ToString());
            powderlbl.Text = c.ColorNumber;
        }

        private void label232_Click(object sender, EventArgs e)
        {

        }

        private void SpotFaceTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DotCapPlugForm f17 = new DotCapPlugForm();
            f17.ShowDialog();
        }

        private void MinPiecesTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Call Dot Cap Plug Detail for this part number
            if (PartsL.PartExists(PartNoCombo.Text))
            {
                Part p1 = PartsL.SearchPart(PartNoCombo.Text);
                DotCapPlugForm f2 = new DotCapPlugForm(p1.PartNo, p1.Id);
                f2.ShowDialog();

                PartMaskLinkList pmList = new PartMaskLinkList(p1.Id);

                TotalCaplbl.Text = pmList.GetMaskTotal("Cap").ToString();
                TotalPlugslbl.Text = pmList.GetMaskTotal("Plug").ToString();
                TotalDotlbl.Text = pmList.GetMaskTotal("Dot").ToString();

            }
            else
            {
                MessageBox.Show("Part is not in Database");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Router
            PartSaveButton_Click(sender, e);
            Part p1 = PartsL.SearchPart(PartNoCombo.Text);
            PartMaskLinkList pmList = new PartMaskLinkList(p1.Id);
            string ctemp;
            ctemp = "No Customer Selected Please Update Part Database";
            for(int i = 0; i< PartsSelectedCustList.Items.Count; i++)
            {
                if (i == 0)
                {
                    ctemp = PartsSelectedCustList.Items[i].ToString();
                }
                else
                {
                    ctemp += ", " + PartsSelectedCustList.Items[i].ToString();
                }
            }

            Object_Test f1 = new Object_Test(p1,pmList,ctemp);
            f1.ShowDialog();

        }
        private void Int_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AA1TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void HangerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}