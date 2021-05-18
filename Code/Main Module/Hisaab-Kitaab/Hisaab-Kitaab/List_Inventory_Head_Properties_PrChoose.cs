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
    public partial class List_Inventory_Head_Properties_PrChoose : Form
    {
        dataconnection dt_conn = new dataconnection();
        DataTable dt_table = new DataTable();
        public List_Inventory_Head_Properties_PrChoose()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void List_Inventory_Head_Properties_PrChoose_Load(object sender, EventArgs e)
        {
            dt_table = dt_conn.SelectQuery("SELECT AH.ACCHEAD_ID, PH.PARENTHEAD_TITLE, AH.ACCHEAD_NAME FROM ACCOUNT_HEADS AS AH INNER JOIN PARENT_HEADS AS PH ON AH.ACCPARENTHEAD_ID = PH.PARENTHEAD_ID");
            dataGridView1.DataSource = dt_table;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            string b = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


            string c = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string d = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();


            List_Inventory_Head_Properties.consumption1 = c + "," + d;
            List_Inventory_Head_Properties.consumption2 = b;
        }
    }
}
