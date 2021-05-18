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
    public partial class Delivery_Note : Form
    {
        public Delivery_Note()
        {
            InitializeComponent();
            label_Delivery_Note.ForeColor = ColorTranslator.FromHtml("#293574");
            label_Customer.ForeColor = ColorTranslator.FromHtml("#293574");
            dataGridView_Credit_Node_Sales_Return.ColumnHeadersDefaultCellStyle.BackColor = HelperClass.darkBlue;
            dataGridView_Credit_Node_Sales_Return.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Credit_Node_Sales_Return.ColumnHeadersDefaultCellStyle.Font = HelperClass.SetFont('C', 12, FontStyle.Bold);
            dataGridView_Credit_Node_Sales_Return.Columns[0].Width = 100;
            dataGridView_Credit_Node_Sales_Return.Columns[1].Width = 100;
            dataGridView_Credit_Node_Sales_Return.Columns[2].Width = 200;
            dataGridView_Credit_Node_Sales_Return.Columns[3].Width = 300;
            //dataGridView_Credit_Node_Sales_Return.Columns[4].Width = 80;
            //dataGridViewOtherBooks.Columns[6].Width = 80;
            dataGridView_Credit_Node_Sales_Return.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Credit_Node_Sales_Return.AlternatingRowsDefaultCellStyle.BackColor = HelperClass.lightBlue;
            this.Icon = new Icon("D:\\FYP\\Hisaab-Kitaab\\Hisaab-Kitaab\\Resources\\SDS1-removebg-preview.ico");

        }

        private void label_Delivery_Note_Click(object sender, EventArgs e)
        {

        }

        private void label_Customer_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Commission_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Delivery_Terms_Click(object sender, EventArgs e)
        {

        }

        private void label_Commission_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Terms_And_Conditions_TextChanged(object sender, EventArgs e)
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

        private void textBox_Delivery_Terms_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delivery_Note_Load(object sender, EventArgs e)
        {

        }
    }
}
