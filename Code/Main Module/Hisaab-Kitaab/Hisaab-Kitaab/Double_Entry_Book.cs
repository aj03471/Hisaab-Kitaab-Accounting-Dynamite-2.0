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
    public partial class Double_Entry_Book : Form
    {
        dataconnection DtConn = new dataconnection();
        DataTable DtTable = new DataTable();
        public Double_Entry_Book()
        {
            InitializeComponent();
            UpdateDGV_DEB();
            //Designing
            dataGridView_DoubleEntryBook.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_DoubleEntryBook.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_DoubleEntryBook.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_DoubleEntryBook.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void UpdateDGV_DEB()
        {
            string line1 = "SELECT BOOK_ID as 'S.#', BOOK_TITLE as 'Book Title', RIGHT('0000000' + CONVERT(VARCHAR(7), B.ACCHEAD_ID), 7) AS 'Account Code', A.ACCHEAD_NAME AS 'Account Title' FROM";
            string line2 = " BOOKProperties AS B INNER JOIN ACCOUNT_HEADS AS A ON B.ACCHEAD_ID = A.ACCHEAD_ID WHERE BOOK_TYPE = 'D'";
            string query = line1 + line2;
            DtTable = DtConn.SelectQuery(query);
            dataGridView_DoubleEntryBook.DataSource = DtTable;
        }
    }
}
