using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hisaab_Kitaab
{
    public partial class Other_Book : Form
    {
        dataconnection dtConn = new dataconnection();
        DataTable dtTable = new DataTable();
        List<string> accountHeads = new List<string>();
        List<string> selectedHead = new List<string>();


        public Other_Book()
        {
            InitializeComponent();                        
            dtTable = dtConn.SelectQuery("SELECT ACCHEAD_ID,ACCHEAD_NAME FROM ACCOUNT_HEADS");            
            //comboBoxAccountHeads.DropDownWidth = 500;
            for (int i = 0; i<dtTable.Rows.Count; i++)
            {
                accountHeads.Add(dtTable.Rows[i][0].ToString().Trim()+". "+dtTable.Rows[i][1].ToString().Trim());
            }

            //comboBoxAccountHeads.DataSource = accountHeads;
            //(dataGridViewOtherBooks.Columns[1] as DataGridViewComboBoxColumn).DataSource = accountHeads;
            //(dataGridViewOtherBooks.Columns[1] as DataGridViewComboBoxColumn).FlatStyle = FlatStyle.Flat;
            //DataGridView styling: 
            //comboBoxAccountHeads.DropDownHeight = 100;
            dataGridViewOtherBooks.Font = HelperClass.SetFont();
            dataGridViewOtherBooks.ColumnHeadersDefaultCellStyle.BackColor = HelperClass.darkBlue;
            dataGridViewOtherBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewOtherBooks.ColumnHeadersDefaultCellStyle.Font = HelperClass.SetFont('C', 12, FontStyle.Bold);
            dataGridViewOtherBooks.Columns[0].Width = 100;
            dataGridViewOtherBooks.Columns[1].Width = 100;
            dataGridViewOtherBooks.Columns[2].Width = 200;
            dataGridViewOtherBooks.Columns[3].Width = 300;
            dataGridViewOtherBooks.Columns[4].Width = 80;
            dataGridViewOtherBooks.Columns[5].Width = 80;
            //dataGridViewOtherBooks.Columns[6].Width = 80;
            dataGridViewOtherBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOtherBooks.AlternatingRowsDefaultCellStyle.BackColor = HelperClass.lightBlue;
            //dataGridViewOtherBooks.DefaultCellStyle.SelectionBackColor = HelperClass.darkBlue;
            //dataGridViewOtherBooks.DefaultCellStyle.SelectionForeColor = Color.White;


            //dataGridViewOtherBooks.ColumnHeadersDefaultCellStyle.Font = HelperClass.SetFont('H');

            //Combo1.DataSource = dtbl;
            //comboBoxAccountHeads.DataTextField = dtbl.Columns["ClerkId"].ToString();
            //comboBoxAccountHeads.DataBind();
            HelperClass.SetAllButtons(this.Controls);

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewOtherBooks_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewOtherBooks.SelectedCells.Count > 0)
            {
                int selectedcolindex = dataGridViewOtherBooks.SelectedCells[0].ColumnIndex;
                int selectedrowindex = dataGridViewOtherBooks.SelectedCells[0].RowIndex;
                if ((e.Button == MouseButtons.Right) && (selectedcolindex == 2))
                {
                    Choose_Account_Head formChooseAccountHead = new Choose_Account_Head();
                    DialogResult result = formChooseAccountHead.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        dataGridViewOtherBooks.CurrentCell = this.dataGridViewOtherBooks[selectedcolindex,selectedrowindex];
                        dataGridViewOtherBooks.CurrentCell.Value = formChooseAccountHead.choosenHeader[3];
                        selectedHead = formChooseAccountHead.choosenHeader;
                        textBoxAccountTitle.Text = formChooseAccountHead.choosenHeader[4];
                        textBoxParentHead.Text = formChooseAccountHead.choosenHeader[1] + " " + formChooseAccountHead.choosenHeader[2];
                    }

                }


            }

        }

        private void dataGridViewOtherBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if ((dataGridViewOtherBooks.SelectedCells.Count > 0) && selectedHead.Count != 0)
            {
                //int selectedcolindex = dataGridViewOtherBooks.SelectedCells[0].ColumnIndex;
                int selectedrowindex = dataGridViewOtherBooks.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewOtherBooks.Rows[selectedrowindex];
                int cellValue = Convert.ToInt32(selectedRow.Cells[2].Value);
                if (cellValue > 0)
                {
                    dtTable = dtConn.SelectQuery("SELECT PARENTHEAD_CODE, PARENTHEAD_TITLE, ACCHEAD_NAME FROM ACCOUNT_HEADS INNER JOIN PARENT_HEADS ON ACCOUNT_HEADS.ACCPARENTHEAD_ID = PARENT_HEADS.PARENTHEAD_ID WHERE ACCHEAD_ID = " + cellValue.ToString());
                    textBoxParentHead.Text = dtTable.Rows[0][0].ToString().Trim() + " " + dtTable.Rows[0][1].ToString().Trim();
                    textBoxAccountTitle.Text = dtTable.Rows[0][2].ToString().Trim();
                }
                //MessageBox.Show("Content: " + cellValue.ToString());







            }
          
        }
    }
}
