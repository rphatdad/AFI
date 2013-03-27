using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace AFIParts
{
    public partial class Form1 : Form
    {

        private PartsList PartsL;
        private ColorsList ColorsL;

        private string[] cFeet =   {  "0","1","2","3","4",      // 1 
                                        "5","6","7","8","9",    // 2 
                                        "10","11","12","13" };  // 3 

        private string[] cConvSpeed = {  "0","1","2","3","4",   // 1 
                                         "5","6","7","8","9",   // 2 
                                         "10","11","12","13",   // 3
                                         "14", "15", "16" };    // 4 

        private ArrayList PartsCustDelList = new ArrayList();
        private ArrayList PartsCustAddList = new ArrayList();

                                        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PartsL = new PartsList();
            PartNoCombo.DataSource = PartsL.ListParts();
            FeetCB.DataSource = cFeet;
            MinConvCB.DataSource = cConvSpeed;
            PartsSelectedCustList.Items.Clear();
            PartsUnSelectedCustList.Items.Clear();
            ColorsL = new ColorsList();
            PartColorCombo.DataSource = ColorsL.ListColors();
            Colors c = new Colors();
            c = ColorsL.SearchColor(PartColorCombo.SelectedItem.ToString());
            powderlbl.Text = c.ColorNumber;
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

        private Part Form2Object()
        {
            Part p = new Part(PartNoCombo.Text);
            p.Atomizing1 = int.Parse(AA1TB.Text);
            p.Atomizing2 = int.Parse(AA2TB.Text);
            if (BlowCb.Checked == true)
            {
                p.BlowExcessWater = "Y";
            }
            else
            { 
                p.BlowExcessWater = "N"; 
            }
            p.CapsQty = int.Parse(CapsQtyTB.Text.ToString());
            p.ColorName = PartColorCombo.Text;
            p.CureTemp = int.Parse(CureTempTB.Text);
            p.PartDesc = PartDescTB.Text;
            p.DotsQty = int.Parse(DotsTB.Text);
            p.Feet = int.Parse(FeetCB.Text);
            p.FlowRate1 = int.Parse(FR1TB.Text);
            p.FlowRate2 = int.Parse(FR2TB.Text);
            p.Kv1 = int.Parse(KV1TB.Text);
            p.Kv2 = int.Parse(KV2TB.Text);
            p.MaskTime = double.Parse(MaskTimeTB.Text);
            p.Millage = int.Parse(MillageTB.Text);
            p.MinConvSpeed = int.Parse(MinConvCB.Text);
            p.MinPartsPerRack = int.Parse(MinPartsPerTB.Text);
            p.MinPiecesPer = int.Parse(MinPiecesTB.Text);
            p.PaintTime = double.Parse(PaintTimelbl.Text);
            p.PlugsQty = int.Parse(PlugsQtyTB.Text);
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
            p.SpotFace = SpotFaceTB.Text;
            p.SqFeet = double.Parse(SqFeetTB.Text);
            return (p);
           
        }

        private void Object2Form(Part p)
        {
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
            CapsQtyTB.Text = p.CapsQty.ToString();
            int Index2 = PartColorCombo.FindString(p.ColorName);
            PartColorCombo.SelectedIndex = Index2;
            CureTempTB.Text = p.CureTemp.ToString();
            PartDescTB.Text = p.PartDesc;
            DotsTB.Text = p.DotsQty.ToString();
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
            PlugsQtyTB.Text = p.PlugsQty.ToString();
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
            SpotFaceTB.Text = p.SpotFace;
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
                            CapsQtyTB.Text = "";
                            CureTempTB.Text = "";
                            PartDescTB.Text = "";
                            DotsTB.Text = "";
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
                            PaintTimelbl.Text = "";
                            PlugsQtyTB.Text = "";
                            powderlbl.Text = "";
                            PreMaskcb.Checked = false;
                            REC1TB.Text = "";
                            REC2TB.Text = "";
                            SpecialNotesTB.Text = "";
                            SpotFaceTB.Text = "";
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

        private void DotsTB_TextChanged(object sender, EventArgs e)
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



    }
}