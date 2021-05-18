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
    public partial class Choose_Account_Head : Form
    {
        public string choosenHead = "";
        public List<string> choosenHeader = new List<string>();
        dataconnection dtConn = new dataconnection();
        DataTable dtTable = new DataTable();
        public Choose_Account_Head()
        {
            InitializeComponent();
            string line1 = "SELECT PARENT_HEADS.PARENTHEAD_ID, PARENT_HEADS.PARENTHEAD_CODE AS 'Parent Code', PARENT_HEADS.PARENTHEAD_TITLE AS 'Parent Title',";
            string line2 = "RIGHT('0000000' + CONVERT(VARCHAR(7), ACCOUNT_HEADS.ACCHEAD_ID), 7) AS 'Account Code', ACCHEAD_NAME AS 'Account Title' FROM ACCOUNT_HEADS	";
            string line3 = "INNER JOIN PARENT_HEADS ON ACCOUNT_HEADS.ACCPARENTHEAD_ID = PARENT_HEADS.PARENTHEAD_ID";
            string query = line1 + line2 + line3;
            dtTable = dtConn.SelectQuery(query);
            dataGridViewAccountHead.DataSource = dtTable;
            dataGridViewAccountHead.Columns[0].Visible = false;//("PARENTHEAD_ID");
            dataGridViewAccountHead.Columns[1].Visible = false;//.Remove("Parent Code");
            dataGridViewAccountHead.Columns[2].Visible = false;//.Remove("Parent Title");
            dataGridViewAccountHead.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewAccountHead.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAccountHead.Font = HelperClass.SetFont();
            this.Icon = new Icon("D:\\FYP\\Hisaab-Kitaab\\Hisaab-Kitaab\\Resources\\SDS1-removebg-preview.ico");
            HelperClass.StyleDGV(dataGridViewAccountHead);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccountHead.SelectedCells.Count > 0)
            {
                //int selectedcolindex = dataGridViewOtherBooks.SelectedCells[0].ColumnIndex;
                int selectedrowindex = dataGridViewAccountHead.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewAccountHead.Rows[selectedrowindex];
                choosenHeader.Add(Convert.ToString(selectedRow.Cells["PARENTHEAD_ID"].Value).Trim());
                choosenHeader.Add(Convert.ToString(selectedRow.Cells["Parent Code"].Value).Trim());
                choosenHeader.Add(Convert.ToString(selectedRow.Cells["Parent Title"].Value).Trim());
                choosenHeader.Add(Convert.ToString(selectedRow.Cells["Account Code"].Value).Trim());
                choosenHeader.Add(Convert.ToString(selectedRow.Cells["Account Title"].Value).Trim());

                //choosenHead = Convert.ToString(selectedRow.Cells["Account Code"].Value).Trim() + ". " + Convert.ToString(selectedRow.Cells["Account Title"].Value).Trim();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
