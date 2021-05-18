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
    public partial class Choose_Inventory_Head : Form
    {
        public string choosenHead = "";
        public List<string> choosenHeader = new List<string>();
        dataconnection dtConn = new dataconnection();
        DataTable dtTable = new DataTable();

        public Choose_Inventory_Head()
        {
            InitializeComponent();
            string line1 = "SELECT PARENT_HEADS.PARENTHEAD_ID, PARENT_HEADS.PARENTHEAD_CODE AS 'Parent Code', PARENT_HEADS.PARENTHEAD_TITLE AS 'Parent Title',";
            string line2 = "RIGHT ('0000000' + CONVERT(VARCHAR(7), INVENTORY_HEADS.INVHEAD_ID), 7) AS 'Inventory Code', INVHEAD_NAME AS 'Inventory Title' FROM INVENTORY_HEADS	";
            string line3 = "INNER JOIN PARENT_HEADS ON INVENTORY_HEADS.INVPARENTHEAD_ID = PARENT_HEADS.PARENTHEAD_ID";
            string query = line1+ line2+line3 ;
            dtTable = dtConn.SelectQuery(query);
            dataGridViewChooseInvHead.DataSource = dtTable;
            dataGridViewChooseInvHead.Columns[0].Visible = false;//("PARENTHEAD_ID");
            dataGridViewChooseInvHead.Columns[1].Visible = false;//.Remove("Parent Code");
            dataGridViewChooseInvHead.Columns[2].Visible = false;//.Remove("Parent Title");
            dataGridViewChooseInvHead.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewChooseInvHead.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewChooseInvHead.Font = HelperClass.SetFont();
            this.Icon = new Icon("D:\\FYP\\Hisaab-Kitaab\\Hisaab-Kitaab\\Resources\\SDS1-removebg-preview.ico");
            HelperClass.StyleDGV(dataGridViewChooseInvHead);


        }

        private void Choose_Inventory_Head_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewAccountHead_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string B = dataGridViewChooseInvHead.SelectedRows[0].Cells[1].Value.ToString();
      



            List_Store_Issue_Slips.consumption4 = B ;

            List_Purchase_Requistion.consumption4 = B;
        }
    }
}
