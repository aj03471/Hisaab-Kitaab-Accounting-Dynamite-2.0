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
    public partial class List_Inventory_Head_Add_Choose : Form
    {
        dataconnection dt_conn = new dataconnection();
        DataTable dt_table = new DataTable();
        public List_Inventory_Head_Add_Choose()
        {
            InitializeComponent();
        }

        private void List_Inventory_Head_Add_Choose_Load(object sender, EventArgs e)
        {
            dt_table = dt_conn.SelectQuery("SELECT * FROM PARENT_HEADS");
            CdataGridView1.DataSource = dt_table;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {


            string B = CdataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string c = CdataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           


            List_Inventory_Head_Add.consumption3 = B+"  "+c;
          
        }

        private void CdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
