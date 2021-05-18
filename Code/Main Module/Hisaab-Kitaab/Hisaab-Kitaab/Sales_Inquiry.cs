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
    public partial class Sales_Inquiry : Form
    {
        public Sales_Inquiry()
        {
            InitializeComponent();
            label_Sales_Equity.ForeColor = ColorTranslator.FromHtml("#293574");
            label_Customer.ForeColor = ColorTranslator.FromHtml("#293574");
            dataGridView_Sales_Equity.ColumnHeadersDefaultCellStyle.BackColor = HelperClass.darkBlue;
            dataGridView_Sales_Equity.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Sales_Equity.ColumnHeadersDefaultCellStyle.Font = HelperClass.SetFont('C', 12, FontStyle.Bold);
            dataGridView_Sales_Equity.Columns[0].Width = 100;
            dataGridView_Sales_Equity.Columns[1].Width = 100;
            dataGridView_Sales_Equity.Columns[2].Width = 200;
            dataGridView_Sales_Equity.Columns[3].Width = 300;
            dataGridView_Sales_Equity.Columns[4].Width = 80;
            dataGridView_Sales_Equity.Columns[5].Width = 80;
            dataGridView_Sales_Equity.Columns[6].Width = 80;
            //dataGridViewOtherBooks.Columns[6].Width = 80;
            dataGridView_Sales_Equity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Sales_Equity.AlternatingRowsDefaultCellStyle.BackColor = HelperClass.lightBlue;

        }

        private void label_Sales_Equity_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Sales_Order SO = new Sales_Order();
            SO.ShowDialog();
        }

        private void dataGridView_Sales_Equity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
