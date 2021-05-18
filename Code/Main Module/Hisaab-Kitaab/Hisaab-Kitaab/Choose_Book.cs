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
    public partial class Choose_Book : Form
    {
        dataconnection DtConn = new dataconnection();
        DataTable DtTable = new DataTable();
        public string choosenBook = ""; //passes book id to previous form
        public char choosenType = '0'; //passes book type to previous form


        public Choose_Book(char type)
        {
            InitializeComponent();

            //If type = 'S', load list of Single Entry books, type == 'D' load list of Double Entry Books, else Cancel. 
            if (type == 'S')
            {

            }
            else if (type == 'D')
            {

            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void Load_SingleEntry_List()
        {
            string line1 = "Select BP.BOOK_ID As 'Book No.', BP.BOOK_TITLE as 'Book Title', AH.ACCHEAD_NAME as 'Account Title' ";
            string line2 = "from BOOKProperties as BP inner join ACCOUNT_HEADS as AH on BP.ACCHEAD_ID = AH.ACCHEAD_ID";
            string line3 = " WHERE BOOK_TYPE = 'S'";
            string query = line1 + line2 + line3;
            try
            {
                DtTable = DtConn.SelectQuery(query);
                dataGridView_BookList.DataSource = DtTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void Load_DoubleEntry_List()
        {
            string line1 = "Select BP.BOOK_ID As 'Book No.', BP.BOOK_TITLE as 'Book Title', AH.ACCHEAD_NAME as 'Account Title' ";
            string line2 = "from BOOKProperties as BP inner join ACCOUNT_HEADS as AH on BP.ACCHEAD_ID = AH.ACCHEAD_ID";
            string line3 = " WHERE BOOK_TYPE = 'D'";
            string query = line1 + line2 + line3;
            try
            {
                DtTable = DtConn.SelectQuery(query);
                dataGridView_BookList.DataSource = DtTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (dataGridView_BookList.SelectedCells.Count > 0)
            {
                //int selectedcolindex = dataGridViewOtherBooks.SelectedCells[0].ColumnIndex;
                int selectedrowindex = dataGridView_BookList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_BookList.Rows[selectedrowindex];
                choosenBook = Convert.ToString(selectedRow.Cells[0].Value).Trim();
               
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
