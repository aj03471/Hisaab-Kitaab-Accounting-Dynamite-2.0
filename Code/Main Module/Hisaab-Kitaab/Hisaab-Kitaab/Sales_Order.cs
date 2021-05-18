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
    public partial class Sales_Order : Form
    {
        public Sales_Order()
        {
            InitializeComponent();
            label_Sales_Order.ForeColor = ColorTranslator.FromHtml("#293574");
            label_Customer.ForeColor = ColorTranslator.FromHtml("#293574");
            dataGridView_Credit_Node_Sales_Return.ColumnHeadersDefaultCellStyle.BackColor = HelperClass.darkBlue;
            dataGridView_Credit_Node_Sales_Return.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Credit_Node_Sales_Return.ColumnHeadersDefaultCellStyle.Font = HelperClass.SetFont('C', 12, FontStyle.Bold);
            dataGridView_Credit_Node_Sales_Return.Columns[0].Width = 100;
            dataGridView_Credit_Node_Sales_Return.Columns[1].Width = 100;
            dataGridView_Credit_Node_Sales_Return.Columns[2].Width = 200;
            dataGridView_Credit_Node_Sales_Return.Columns[3].Width = 300;
            dataGridView_Credit_Node_Sales_Return.Columns[4].Width = 80;
            //dataGridViewOtherBooks.Columns[6].Width = 80;
            dataGridView_Credit_Node_Sales_Return.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Credit_Node_Sales_Return.AlternatingRowsDefaultCellStyle.BackColor = HelperClass.lightBlue;

        }

        private void label_Sales_Order_Click(object sender, EventArgs e)
        {

        }

        private void label_Terms_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Equity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Equity_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Delivery_Terms_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Commission_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Delivery_Click(object sender, EventArgs e)
        {

        }

        private void label_Commission_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Agent_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Dispatched_By_Click(object sender, EventArgs e)
        {

        }

        private void label_Delivery_Note_Number_Click(object sender, EventArgs e)
        {

        }

        private void label_Date_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Credit_Node_Sales_Return_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_Customer_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Terms_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Terms_And_Conditions_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sales_Order_Load(object sender, EventArgs e)
        {

        }
    }
}
