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
    public partial class Cash_Sales_Invoice : Form
    {
        public Cash_Sales_Invoice()
        {
            InitializeComponent();
            label_Cash_Sales_Invoice.ForeColor = ColorTranslator.FromHtml("#293574");
            label_Customer.ForeColor = ColorTranslator.FromHtml("#293574");
            dataGridView_Cash_Sales_Invoice.ColumnHeadersDefaultCellStyle.BackColor = HelperClass.darkBlue;
            dataGridView_Cash_Sales_Invoice.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Cash_Sales_Invoice.ColumnHeadersDefaultCellStyle.Font = HelperClass.SetFont('C', 12, FontStyle.Bold);
            dataGridView_Cash_Sales_Invoice.Columns[0].Width = 100;
            dataGridView_Cash_Sales_Invoice.Columns[1].Width = 100;
            dataGridView_Cash_Sales_Invoice.Columns[2].Width = 200;
            dataGridView_Cash_Sales_Invoice.Columns[3].Width = 300;
            dataGridView_Cash_Sales_Invoice.Columns[4].Width = 80;
            dataGridView_Cash_Sales_Invoice.Columns[5].Width = 80;
            dataGridView_Cash_Sales_Invoice.Columns[6].Width = 80;
            //dataGridViewOtherBooks.Columns[6].Width = 80;
            dataGridView_Cash_Sales_Invoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Cash_Sales_Invoice.AlternatingRowsDefaultCellStyle.BackColor = HelperClass.lightBlue;
            this.Icon = new Icon("D:\\FYP\\Hisaab-Kitaab\\Hisaab-Kitaab\\Resources\\SDS1-removebg-preview.ico");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cash_Sales_Invoice_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Credit_Note_Sales_Return SE = new Credit_Note_Sales_Return();
            SE.ShowDialog();

        }

        private void label_Cash_Sales_Invoice_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Cash_Sales_Invoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
