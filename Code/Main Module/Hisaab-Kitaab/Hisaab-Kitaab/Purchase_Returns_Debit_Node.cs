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
    public partial class Purchase_Returns_Debit_Node : Form
    {
        public Purchase_Returns_Debit_Node()
        {
            InitializeComponent();
            label_Purchase_Returns_Debit_Note.ForeColor = ColorTranslator.FromHtml("#293574");
            dataGridView_Purchase_Returns_Debit_Note.ColumnHeadersDefaultCellStyle.BackColor = HelperClass.darkBlue;
            dataGridView_Purchase_Returns_Debit_Note.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Purchase_Returns_Debit_Note.ColumnHeadersDefaultCellStyle.Font = HelperClass.SetFont('C', 12, FontStyle.Bold);
            dataGridView_Purchase_Returns_Debit_Note.Columns[0].Width = 100;
            dataGridView_Purchase_Returns_Debit_Note.Columns[1].Width = 100;
            dataGridView_Purchase_Returns_Debit_Note.Columns[2].Width = 200;
            dataGridView_Purchase_Returns_Debit_Note.Columns[3].Width = 300;
            dataGridView_Purchase_Returns_Debit_Note.Columns[4].Width = 80;
            dataGridView_Purchase_Returns_Debit_Note.Columns[5].Width = 80;
            dataGridView_Purchase_Returns_Debit_Note.Columns[6].Width = 80;
            //dataGridViewOtherBooks.Columns[6].Width = 80;
            dataGridView_Purchase_Returns_Debit_Note.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Purchase_Returns_Debit_Note.AlternatingRowsDefaultCellStyle.BackColor = HelperClass.lightBlue;

            textBox_Supplier.Text = "Supplier Name \n Supplier Account Number \n Supplier Address \n Supplier Contact Number";
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
        private void label_Purchase_Returns_Debit_Note_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Cash_Sales_Invoice CSI = new Cash_Sales_Invoice();
            CSI.ShowDialog();
        }

        private void Purchase_Returns_Debit_Node_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_Purchase_Returns_Debit_Note_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
