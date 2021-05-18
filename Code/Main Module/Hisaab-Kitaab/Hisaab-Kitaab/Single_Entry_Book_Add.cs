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
    public partial class Single_Entry_Book_Add : Form
    {
        dataconnection DtConn = new dataconnection();
        DataTable DtTable = new DataTable();
        public Single_Entry_Book_Add()
        {
            InitializeComponent();
            DtTable = DtConn.SelectQuery("Select Top 1 BOOK_ID from BOOKProperties ORDER BY BOOK_ID DESC");
            if (DtTable.Rows.Count == 1)
            {
                textBox_BookID.Text = (Convert.ToInt32(DtTable.Rows[0][0].ToString())+1).ToString();
            }

        }

        private void Single_Entry_Book_Add_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                string line1 = "INSERT INTO BOOKProperties Values ";
                string line2 = "(" + textBox_BookID.Text + ",'" + textBox_BookTitle.Text + "', " + (Convert.ToInt32(textBox_AccCode.Text)).ToString();
                string line3 = ", " + textBox_RVNo.Text + ", '"+maskedTextBox_RVP.Text+"', '"+textBox_RVTitle.Text+"', "+textBox1_PVNo.Text+", '"+maskedTextBox_PVP.Text+"', '"+textBox_PVTitle.Text+"', 'S')";
                string line4 = "'"+textBox_SigN1.Text+"','"+textBox_SigN2.Text+"', '"+textBox_SigN3.Text+"',";
                string line5 = "'"+textBox_SigDesig1.Text+"','"+textBox_SigDesig2.Text+"','"+textBox_SigDesig3.Text+"',"+maskedTextBox_M1.Text+","+maskedTextBox_M2.Text+","+maskedTextBox_M3.Text+")";
                */
                string line1 = "INSERT INTO BOOKProperties Values ";
                string line2 = "(" + textBox_BookID.Text + ",'" + textBox_BookTitle.Text + "', " + (Convert.ToInt32(textBox_AccCode.Text)).ToString();
                string line3 = ", NULL, NULL, NULL, NULL, NULL, NULL, 'S', ";
                string line4 = "NULL,NULL, NULL,";
                string line5 = "NULL,NULL,NULL,NULL,NULL,NULL)";
                string query = line1 + line2 + line3 + line4 + line5;
                
                //MessageBox.Show("Query: " + query);
                DtConn.InsertQuery(query);
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex_SE)
            {
                MessageBox.Show(ex_SE.Message);
            }
        }

        private void textBox_AccCode_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Choose_Account_Head formChooseAccountHead = new Choose_Account_Head();
                DialogResult result = formChooseAccountHead.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //dataGridViewOtherBooks.CurrentCell = this.dataGridViewOtherBooks[selectedcolindex, selectedrowindex];
                    textBox_AccCode.Text = formChooseAccountHead.choosenHeader[3];
                    //selectedHead = formChooseAccountHead.choosenHeader;
                    //textBoxAccountTitle.Text = formChooseAccountHead.choosenHeader[4];
                    //textBoxParentHead.Text = formChooseAccountHead.choosenHeader[1] + " " + formChooseAccountHead.choosenHeader[2];
                }

            }
        }
    }
}
