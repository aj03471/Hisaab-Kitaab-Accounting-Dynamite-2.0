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
    public partial class Dialogue_Box_Account_Head : Form
    {
        public string choosenHead = "";
        public List<string> choosenHeader = new List<string>();
        dataconnection dtConn = new dataconnection();
        DataTable dtTable = new DataTable();

        public Dialogue_Box_Account_Head()
        {
            InitializeComponent();
            string line1 = "SELECT PARENT_HEADS.PARENTHEAD_ID, PARENT_HEADS.PARENTHEAD_CODE AS 'Parent Code', PARENT_HEADS.PARENTHEAD_TITLE AS 'Parent Title',";
            string line2 = "RIGHT ('0000000' + CONVERT(VARCHAR(7), ACCOUNT_HEADS.ACCHEAD_ID), 7) AS 'Account Code', ACCHEAD_NAME AS 'Account Title' FROM ACCOUNT_HEADS	";
            string line3 = "INNER JOIN PARENT_HEADS ON ACCOUNT_HEADS.ACCPARENTHEAD_ID = PARENT_HEADS.PARENTHEAD_ID";
            string query = line1 + line2 +line3;
            dtTable = dtConn.SelectQuery(query);
            dataGridViewAccountHead3.DataSource = dtTable;
            dataGridViewAccountHead3.Columns[0].Visible = false;//("PARENTHEAD_ID");
            dataGridViewAccountHead3.Columns[1].Visible = false;//.Remove("Parent Code");
            dataGridViewAccountHead3.Columns[2].Visible = false;//.Remove("Parent Title");
            dataGridViewAccountHead3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewAccountHead3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAccountHead3.Font = HelperClass.SetFont();
            HelperClass.StyleDGV(dataGridViewAccountHead3);
        }

        private void labelHeading_Click(object sender, EventArgs e)
        {

        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            string BB = dataGridViewAccountHead3.SelectedRows[0].Cells[3].Value.ToString();


           // MessageBox.Show(BB);
           
            Data_Range_Dialogue_Box.consumption667 = BB;

           
                Data_Range_Dialogue_Box.consumption668 = BB;
            


        }

        private void Dialogue_Box_Account_Head_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewAccountHead3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
