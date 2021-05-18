using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hisaab_Kitaab
{
    public partial class Good_Receipt_Note
        : Form
    {
        public Good_Receipt_Note()
        {
            InitializeComponent();
            label_Purchase_Order.ForeColor = ColorTranslator.FromHtml("#293574");
            //label_Supplier.ForeColor = ColorTranslator.FromHtml("#293574");

            HelperClass.StyleDGV(dataGridView_Goods_Receipt_Note);
            dataGridView_Goods_Receipt_Note.Rows.Add("1", "1", "Pencils", "50", "10", "pieces", "500");
            dataGridView_Goods_Receipt_Note.Rows.Add("2", "4", "Pens", "150", "10", "pieces", "1500");

            //Assigning default values
            dateTimePicker_Date.Text = "01-01-2021";
            textBox_PONo.Text = "00001";
            textBox_PurchaseNo.Text = "00001";
            textBox_GRN.Text = "00001";
            textBox_Prepared_By.Text = "Bakhtawar";
            textbox_Store_Keeper.Text = "Hasan";
            textBox_Total_Amount.Text = "2000";
            textBox_AmountWords.Text = "Two Thousand Rupees Only";
            textBox_TnC.Text = "Title and risk of loss or damage shall pass to Buyer upon receipt of Goods at the Delivery Point, unless otherwise agreed to by the Buyer in writing. Buyer has no obligation to obtain insurance while Goods are in transit from Supplier to the Delivery Point.";
            //label_Amount_In_Words.Text = "Amount in words";
            //////textBox_Terms_And_Conditions.Text = "Terms And Conditions \n I am Bakhtawar";


            textBox_Supplier.Text = "Ali Ahmed Co. \r\nBlock2, Gulistan-e-Johar, Karachi \r\n03015266915";
            textBox_Supplier.ContextMenu = new ContextMenu();
            textBox_Supplier.MouseDown += new MouseEventHandler(textBox_Supplier_MouseDown);

        }
        void textBox_Supplier_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Supplier_Details Supplier = new Supplier_Details();
                DialogResult result = Supplier.ShowDialog();
                if (result == DialogResult.OK)
                {
                   
                 }

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_Purchase_Bill_Approval_Click(object sender, EventArgs e)
        {

        }

        private void label_Supplier_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Purchase_Bill_Approval_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Purchase_Returns_Debit_Node PRDN = new Purchase_Returns_Debit_Node();
            PRDN.ShowDialog();
        }

        private void Purchase_Bill_Approval_Load(object sender, EventArgs e)
        {

        }

        private void label_Amount_In_Words_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goods Receipt Note is saved.");
        }
    }
}
