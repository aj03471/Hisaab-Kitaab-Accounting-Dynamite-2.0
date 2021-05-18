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
    public partial class Purchase_Bill_Approval : Form
    {
        public Purchase_Bill_Approval()
        {
            InitializeComponent();
            label_Purchase_Bill_Approval.ForeColor = ColorTranslator.FromHtml("#293574");
            //label_Supplier.ForeColor = ColorTranslator.FromHtml("#293574");

            HelperClass.StyleDGV(dataGridView_Purchase_Bill_Approval);

            dataGridView_Purchase_Bill_Approval.Rows.Add("1", "00001", "1", "Pencils", "50", "10", "500" );
            dataGridView_Purchase_Bill_Approval.Rows.Add("2", "00001", "4", "Pens", "150", "10", "1500");

            //Assigning default values
            dateTimePicker_Date.Text = "01-01-2021";
            dateTimePicker_Due.Text = "01-07-2021";
            textBox_Approved_By.Text = "Inara";
            textBox_PBillNo.Text = "00001";
            //label_Amount_In_Words.Text = "Amount in words";
            textBox_AmountWords.Text = "Two Thousand Rupees Only";
            textBox_Total_Amount.Text = "2000";
            textBox_TnC.Text = "Unless otherwise stated in a Purchase Order, all prices or other payments stated in the Purchase Order are exclusive of any taxes.";
            

            textBox_Supplier.Text = "Ali Ahmed Co. \r\n060-050-010-020  \r\nBlock2, Gulistan-e-Johar, Karachi \r\n03015266915";
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

        private void button_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Purchase Bill Approval saved.");
        }
    }
}
