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
    public partial class List_Purchase_Requistion : Form
    {
        public static string consumption4 = "";
        dataconnection dcon = new dataconnection();
        DataTable dt = new DataTable();
        public List_Purchase_Requistion()
        {
            InitializeComponent();
            // for (int i = 0; i < dtTable.Rows.Count; i++)
            // {
            //  accountHeads.Add(dtTable.Rows[i][0].ToString().Trim() + ". " + dtTable.Rows[i][1].ToString().Trim());
            /// }

            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            textBox1.Text = r;


            String y = generator.Next(0, 1000000).ToString("D6");
            textBox2.Text = y;
            dataGridViewPurchase.Font = HelperClass.SetFont();
            dataGridViewPurchase.ColumnHeadersDefaultCellStyle.BackColor = HelperClass.darkBlue;
            dataGridViewPurchase.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewPurchase.ColumnHeadersDefaultCellStyle.Font = HelperClass.SetFont('C', 12, FontStyle.Bold);
            dataGridViewPurchase.Columns[0].Width = 100;
            dataGridViewPurchase.Columns[1].Width = 100;
            dataGridViewPurchase.Columns[2].Width = 200;
            dataGridViewPurchase.Columns[3].Width = 300;
            dataGridViewPurchase.Columns[4].Width = 80;
            dataGridViewPurchase.Columns[5].Width = 80;
            //dataGridViewOtherBooks.Columns[6].Width = 80;
            dataGridViewPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPurchase.AlternatingRowsDefaultCellStyle.BackColor = HelperClass.lightBlue;
            
            HelperClass.SetAllButtons(this.Controls);
        }

        private void List_Purchase_Requistion_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewPurchase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridViewPurchase.CurrentRow.Cells[1].Selected == true)
            // dataGridViewStoreSlips.CurrentRow.Selected = true;
            {

                Choose_Inventory_Head IPHP = new Choose_Inventory_Head();




                if (IPHP.ShowDialog() == DialogResult.OK)
                {

                    ///dataGridViewStoreSlips.CurrentRow.Cells[1].Value.ToString() = consumption4;
                    ///
                    dataGridViewPurchase.CurrentRow.Cells[1].Value = consumption4;



                    // textBox_parentHead.Text = consumption3;

                }



            }
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data is Saved");
        }
    }
}
