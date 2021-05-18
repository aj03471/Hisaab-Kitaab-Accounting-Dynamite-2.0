using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hisaab_Kitaab
{
    public partial class List_Inventory_Head_Add : Form
    {
        dataconnection dcon = new dataconnection();
        DataTable dt = new DataTable();
        public static string consumption3 = "";
        public List_Inventory_Head_Add()
        {
            InitializeComponent();
            label_Add.ForeColor = ColorTranslator.FromHtml("#293574");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listAccountHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void List_Inventory_Head_Add_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            string f = Regex.Match(textBox_parentHead.Text, @"\d+").Value;
            // string f = Regex.Split("\D+");
            //   string f = textBox_parentHead.Text.Substring(2);
            // Int64 f = Int64.Parse(textBox_parentHead.Text.Substring(2));
            //   MessageBox.Show(f.ToString());



            // Int64 Ph_ID;// The most recent Parent Head  ID 
            //  dt = dcon.SelectQuery("SELECT TOP 1 PARENTHEAD_ID from PARENT_HEADS Order by PARENTHEAD_ID Desc");
            //Ph_ID = Int64.Parse(f);


            //  MessageBox.Show(f.ToString(),h.ToString());
            //SELECT LAST(CustomerName) AS LastCustomer FROM Customers;
            //SELECT TOP 1 column_name FROM table_name
           // ORDER BY column_name DESC;
            dt = dcon.SelectQuery("Select TOP 1 INVHEAD_ID FROM INVENTORY_HEADS  ORDER BY INVHEAD_ID DESC ");

            // int f = Regex.Match(dt.Rows[0][0].ToStrin, @"\d+").Value;
            Int64 fr = Int64.Parse(dt.Rows[0][0].ToString()) + 1;
           
                

         //   MessageBox.Show(fr.ToString());


            dcon.InsertQuery("Insert into INVENTORY_HEADS (INVHEAD_ID,INVPARENTHEAD_ID) VALUES (" + fr + ",'" + f + "')");
            MessageBox.Show("Data has been added");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List_Inventory_Head_Add_Choose IP = new List_Inventory_Head_Add_Choose();

            if (IP.ShowDialog() == DialogResult.OK)
            {

                textBox_parentHead.Text = consumption3;

            }
        }

        private void textBox_parentHead_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
