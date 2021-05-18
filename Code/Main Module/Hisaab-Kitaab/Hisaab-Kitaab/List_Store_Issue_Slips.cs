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
    public partial class List_Store_Issue_Slips : Form
    {
        public static string consumption4 = "";
        dataconnection dcon = new dataconnection();
        DataTable dt = new DataTable();
        public List_Store_Issue_Slips()
        {
            InitializeComponent();

            buttonsave.Visible = true;
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            textBox1.Text = r;

            
            String y = generator.Next(0, 1000000).ToString("D6");
            textBox2.Text = y;


            dataGridViewStoreSlips.Font = HelperClass.SetFont();
            dataGridViewStoreSlips.ColumnHeadersDefaultCellStyle.BackColor = HelperClass.darkBlue;
            dataGridViewStoreSlips.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewStoreSlips.ColumnHeadersDefaultCellStyle.Font = HelperClass.SetFont('C', 12, FontStyle.Bold);
            dataGridViewStoreSlips.Columns[0].Width = 100;
            dataGridViewStoreSlips.Columns[1].Width = 100;
            dataGridViewStoreSlips.Columns[2].Width = 200;
            dataGridViewStoreSlips.Columns[3].Width = 300;
            dataGridViewStoreSlips.Columns[4].Width = 80;
            dataGridViewStoreSlips.Columns[5].Width = 80;
            //dataGridViewOtherBooks.Columns[6].Width = 80;
            dataGridViewStoreSlips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStoreSlips.AlternatingRowsDefaultCellStyle.BackColor = HelperClass.lightBlue;

            HelperClass.SetAllButtons(this.Controls);
        }

        private void List_Store_Issue_Slips_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewStoreSlips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // Choose_Inventory_Head f2 = new Choose_Inventory_Head();
           // f2.dataGridViewChooseInvHead.SelectedCells[1].ToString= this.dataGridViewStoreSlips.CurrentRow.Cells[1].Value.ToString();

           

        }

        private void dataGridViewStoreSlips_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewStoreSlips_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridViewStoreSlips.CurrentRow.Cells[1].Selected== true)
            // dataGridViewStoreSlips.CurrentRow.Selected = true;
            { 
                Choose_Inventory_Head IPHP = new Choose_Inventory_Head();


               

                if (IPHP.ShowDialog() == DialogResult.OK)
                {

                    ///dataGridViewStoreSlips.CurrentRow.Cells[1].Value.ToString() = consumption4;
                    ///
                    dataGridViewStoreSlips.CurrentRow.Cells[1].Value= consumption4;



                   // textBox_parentHead.Text = consumption3;

                }



            }
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
           

          //  dt =dcon.InsertQuery("UPDATE INVENTORY_ SET  INVHEAD_ID ='" + Textbox_INVHEAD_ID.Text.ToString() + "'
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  dt =dcon.InsertQuery("UPDATE INVENTORY_ SET  INVHEAD_ID ='" + Textbox_INVHEAD_ID.Text.ToString() + "'


            MessageBox.Show("Data is Saved");
        }
    }
}
