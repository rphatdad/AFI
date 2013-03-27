using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AFIObjects;

namespace AFIPO
{
    public partial class AFIMenuForm : Form
    {
        public AFIMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartsForm f1 = new PartsForm();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceivingForm f3 = new ReceivingForm();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InventoryForm f4 = new InventoryForm();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShippingForm f2 = new ShippingForm();
            f2.ShowDialog();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Receiving";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Count Verification";
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Shipping";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Parts";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Colors
            ColorMaintForm f8 = new ColorMaintForm();
            f8.ShowDialog();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Colors";
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Customers";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Customers
            CustomerMaintForm f9 = new CustomerMaintForm();
            f9.ShowDialog();
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Reports";
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Shippers";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShippersForm f11 = new ShippersForm();
            f11.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Reports

            //OpenOrdersReportForm f16 = new OpenOrdersReportForm();
            //f16.ShowDialog();
            //DotCapPlugEntryForm f18 = new DotCapPlugEntryForm();
            //f18.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DotCapPlugEntryForm f18 = new DotCapPlugEntryForm();
            f18.ShowDialog();
        }

        private void AFIMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Dots, Caps, Plugs";
        }
    }
}