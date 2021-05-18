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
    public partial class List_Inventory_Head_Properties_CChoose : Form
    {
        dataconnection dt_conn = new dataconnection();
        DataTable dt_table = new DataTable();

        public List_Inventory_Head_Properties_CChoose()
        {
            InitializeComponent();
        }

        private void List_Inventory_Head_Properties_CChoose_Load(object sender, EventArgs e)
        {
            dt_table = dt_conn.SelectQuery("SELECT AH.ACCHEAD_ID, PH.PARENTHEAD_TITLE, AH.ACCHEAD_NAME FROM ACCOUNT_HEADS AS AH INNER JOIN PARENT_HEADS AS PH ON AH.ACCPARENTHEAD_ID = PH.PARENTHEAD_ID");
            CdataGridView1.DataSource = dt_table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
             

            // int index =CdataGridView1.SelectedCells[0].RowIndex;
            //  DataGridViewRow selectedRow = CdataGridView1.Rows[index];
            // string s = selectedRow.Cells["ACCHEAD_ID"].Value.ToString();

            //   SrNo = selectedRow.Cells["SrNo"].Value.ToString();

            //  List_Inventory_Head_Properties.chosenParentHead1 =s;
            // MessageBox.Show(List_Inventory_Head_Properties.ChosenParentHead2);
            // this.Hide();

           // List_Inventory_Head_Properties IP = new List_Inventory_Head_Properties();

            // IPHP.Textbox_SALE_CR_ACC.Text = List_Inventory_Head_Properties.chosenParentHead2;
            //  List_Inventory_Head_Properties.vis

            string b = CdataGridView1.SelectedRows[0].Cells[1].Value.ToString();


            string c = CdataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string d = CdataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            

            List_Inventory_Head_Properties.consumption1 = c+","+d;
            List_Inventory_Head_Properties.consumption2 = b;

          //  List_Inventory_Head_Properties Form2 = new List_Inventory_Head_Properties();

           // if (Form2.ShowDialog() == DialogResult.OK)
                //label1.Text = "Hello " + oForm2.UserName;

              //  Form2.Textbox_SALE_CR_ACC.Text = Form2.textBox20.Text.ToString();

            //   this.DialogResult = DialogResult.OK;
            // MessageBox.Show(List_Inventory_Head_Properties.consumption1);
            //IP.ShowDialog();


            // IP.Textbox_PRODUCTION_DR_ACC.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            //  IP.label_FILHAAAL.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            //}
        }
    }
}
