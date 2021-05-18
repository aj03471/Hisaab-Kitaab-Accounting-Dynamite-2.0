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
    public partial class Credit_Note_Sales_Return : Form
    {
        public Credit_Note_Sales_Return()
        {
            InitializeComponent();
            label_Credit_Note_Sales_Return.ForeColor = ColorTranslator.FromHtml("#293574");
            label_Supplier.ForeColor = ColorTranslator.FromHtml("#293574");
            dataGridView_Credit_Node_Sales_Return.ColumnHeadersDefaultCellStyle.BackColor = HelperClass.darkBlue;
            dataGridView_Credit_Node_Sales_Return.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Credit_Node_Sales_Return.ColumnHeadersDefaultCellStyle.Font = HelperClass.SetFont('C', 12, FontStyle.Bold);
            dataGridView_Credit_Node_Sales_Return.Columns[0].Width = 100;
            dataGridView_Credit_Node_Sales_Return.Columns[1].Width = 100;
            dataGridView_Credit_Node_Sales_Return.Columns[2].Width = 200;
            dataGridView_Credit_Node_Sales_Return.Columns[3].Width = 300;
            dataGridView_Credit_Node_Sales_Return.Columns[4].Width = 80;
            dataGridView_Credit_Node_Sales_Return.Columns[5].Width = 80;
            //dataGridViewOtherBooks.Columns[6].Width = 80;
            dataGridView_Credit_Node_Sales_Return.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Credit_Node_Sales_Return.AlternatingRowsDefaultCellStyle.BackColor = HelperClass.lightBlue;
            this.Icon = new Icon("D:\\FYP\\Hisaab-Kitaab\\Hisaab-Kitaab\\Resources\\SDS1-removebg-preview.ico");


        }

        private void label_Purchase_Bill_Approval_Click(object sender, EventArgs e)
        {

        }

        private void label_Supplier_Click(object sender, EventArgs e)
        {

        }

        private void Credit_Note_Sales_Return_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Sales_Inquiry SE = new Sales_Inquiry();
            SE.ShowDialog();
        }

        private void dataGridView_Credit_Node_Sales_Return_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
