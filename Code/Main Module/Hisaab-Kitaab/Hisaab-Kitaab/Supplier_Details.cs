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
    public partial class Supplier_Details : Form
    {
        public Supplier_Details()
        {
            InitializeComponent();
            label_Supplier_Details.ForeColor = ColorTranslator.FromHtml("#293574");
            dataGridView_Supplier_Details.ColumnHeadersDefaultCellStyle.BackColor = HelperClass.darkBlue;
            dataGridView_Supplier_Details.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Supplier_Details.ColumnHeadersDefaultCellStyle.Font = HelperClass.SetFont('C', 12, FontStyle.Bold);
            dataGridView_Supplier_Details.Columns[0].Width = 100;
            dataGridView_Supplier_Details.Columns[1].Width = 100;
            dataGridView_Supplier_Details.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Supplier_Details.AlternatingRowsDefaultCellStyle.BackColor = HelperClass.lightBlue;

        }

        private void Supplier_Details_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_Supplier_Details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
