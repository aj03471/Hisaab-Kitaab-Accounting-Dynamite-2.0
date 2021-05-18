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
    public partial class List_Single_Entry_Book : Form
    {
        dataconnection DtConn = new dataconnection();
        DataTable DtTable = new DataTable();
        public List_Single_Entry_Book()
        {
            InitializeComponent();
            UpdateDGV_SEB();
            //Designing
            dataGridView_SingleEntryBook.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_SingleEntryBook.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_SingleEntryBook.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_SingleEntryBook.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void UpdateDGV_SEB()
        {
            string line1 = "SELECT BOOK_ID as 'S.#', BOOK_TITLE as 'Book Title', RIGHT('0000000' + CONVERT(VARCHAR(7), B.ACCHEAD_ID), 7) AS 'Account Code', A.ACCHEAD_NAME AS 'Account Title' FROM";
            string line2 = " BOOKProperties AS B INNER JOIN ACCOUNT_HEADS AS A ON B.ACCHEAD_ID = A.ACCHEAD_ID WHERE BOOK_TYPE = 'S'";
            string query = line1 + line2;
            DtTable = DtConn.SelectQuery(query);
            dataGridView_SingleEntryBook.DataSource = DtTable;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            /*
            Single_Entry_Book_Add form_SEBA = new Single_Entry_Book_Add();
            DialogResult result = form_SEBA.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateDGV_SEB();
            }
            */
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            if (dataGridView_SingleEntryBook.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_SingleEntryBook.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_SingleEntryBook.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value);

                DtTable = DtConn.SelectQuery("SELECT * FROM BOOKProperties WHERE BOOK_ID = "+cellValue+";");


            }
            else
            {
                MessageBox.Show("Please Select the Book you want to remove");
            }
            Single_Entry_Book_Modify form_SEBM = new Single_Entry_Book_Modify();
            DialogResult result = form_SEBM.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateDGV_SEB();
            }

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_SingleEntryBook.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_SingleEntryBook.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_SingleEntryBook.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + Convert.ToString(selectedRow.Cells[1].Value).Trim() + " ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DtTable = DtConn.SelectQuery("SELECT * FROM ACC_TRANS_HEADER As H inner join ACC_TRANS_BODY As B on H.ATHEADER_ID = B.ATHEADER_ID Where BOOKID = "+cellValue+"; ");
                        if (DtTable.Rows.Count == 0)
                        {
                            DtConn.InsertQuery("DELETE FROM BOOKProperties WHERE BOOK_ID = " + cellValue + ";");
                            UpdateDGV_SEB();
                        }
                        else
                        {
                            MessageBox.Show("There are transactions in this book, so it cannot be deleted.");
                        }


                    }
                    catch (Exception exSEB)
                    {
                        MessageBox.Show(exSEB.Message);
                    }
                }
                
                
                /*
                int accHeadID = Convert.ToInt32(cellValue);
                List_Account_Head_Add_Address form_add = new List_Account_Head_Add_Address(accHeadID);
                DialogResult result = new DialogResult();
                result = form_add.ShowDialog();
                if (result == DialogResult.OK)
                {
                    UpdateDGV_SEB();
                }
                */
            }
            else
            {
                MessageBox.Show("Please Select the Book you want to remove");
            }
        }
    }
}
