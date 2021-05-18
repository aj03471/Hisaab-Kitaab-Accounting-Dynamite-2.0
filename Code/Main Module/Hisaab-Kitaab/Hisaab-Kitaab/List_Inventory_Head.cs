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
    public partial class List_Inventory_Head : Form
    {
        dataconnection dt_conn = new dataconnection();
        DataTable dt_table = new DataTable();
        public static string invParentHeadCode ="";

        // int x = 0;




        public List_Inventory_Head()
        {
            InitializeComponent();
            // dt_InvHeadQuery = dcon.SelectQuery("Select INVHEAD_ID, INVPARENTHEAD_ID from INVENTORY_HEADS " );
            // dataGridView1.DataSource = dt_InvHeadQuery;


            // dt_table = dt_conn.SelectQuery("Execute RetrieveINVHeadscode;");
            // dataGridView1.DataSource = dt_table;

            if (Program.inv_units == "SPL")
            {
                dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode ;");
                dataGridView1.DataSource = dt_table;
              
            }
            else if (Program.inv_units == "S")
            {
                dt_table = dt_conn.SelectQuery("EXEC  RetrieveINVHeadscode  ;");
                dataGridView1.DataSource = dt_table;
                dataGridView1.Columns["PACKING_UNIT"].Visible = false;
                dataGridView1.Columns["LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PER_LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PER_PACKING_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PRICE_LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PRICE_PACKING_UNIT"].Visible = false;
                dataGridView1.Columns["BALANCE_LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["COST_LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["COST_PACKING_UNIT"].Visible = false;
                dataGridView1.Columns["BALANCE_PACKING_UNIT"].Visible = false;
               
            }
            else if (Program.inv_units == "P")
            {
                dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_packing ;");
                dataGridView1.DataSource = dt_table;
                dataGridView1.Columns["STOCK_UNIT"].Visible = false;
                dataGridView1.Columns["LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PER_LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PER_STOCK_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PRICE_LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PRICE_STOCK_UNIT"].Visible = false;
                dataGridView1.Columns["BALANCE_LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["COST_LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["COST_STOCK_UNIT"].Visible = false;
                dataGridView1.Columns["BALANCE_STOCK_UNIT"].Visible = false;
            }
            else if (Program.inv_units == "L")
            {
                dt_table = dt_conn.SelectQuery("EXEC  RetrieveINVHeadscode_loose;");
                dataGridView1.DataSource = dt_table;

                dataGridView1.Columns["PACKING_UNIT"].Visible = false;
                dataGridView1.Columns["STOCK_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PER_STOCK_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PER_PACKING_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PRICE_STOCK_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PRICE_PACKING_UNIT"].Visible = false;
                dataGridView1.Columns["BALANCE_STOCK_UNIT"].Visible = false;
                dataGridView1.Columns["COST_STOCK_UNIT"].Visible = false;
                dataGridView1.Columns["COST_PACKING_UNIT"].Visible = false;
                dataGridView1.Columns["BALANCE_PACKING_UNIT"].Visible = false;
            }
            else if (Program.inv_units == "SP")
            {
                dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_stockloose ;");
                dataGridView1.DataSource = dt_table;
                dataGridView1.Columns["PACKING_UNIT"].Visible = false;
               
                
                dataGridView1.Columns["RATE_PER_PACKING_UNIT"].Visible = false;
              
                dataGridView1.Columns["RATE_PRICE_PACKING_UNIT"].Visible = false;
               
                dataGridView1.Columns["COST_PACKING_UNIT"].Visible = false;
                dataGridView1.Columns["BALANCE_PACKING_UNIT"].Visible = false;
            }
            else if (Program.inv_units == "SL")
            {
                dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_stockpacking ;");
                dataGridView1.DataSource = dt_table;
               
                dataGridView1.Columns["LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PER_LOOSE_UNIT"].Visible = false;
               
                dataGridView1.Columns["RATE_PRICE_LOOSE_UNIT"].Visible = false;
              
                dataGridView1.Columns["BALANCE_LOOSE_UNIT"].Visible = false;
                dataGridView1.Columns["COST_LOOSE_UNIT"].Visible = false;
              
               

            }
            else if (Program.inv_units == "PL")
            {
                dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_packingloose ;");
                dataGridView1.DataSource = dt_table;
               
                dataGridView1.Columns["STOCK_UNIT"].Visible = false;
                dataGridView1.Columns["RATE_PER_STOCK_UNIT"].Visible = false;
               
                dataGridView1.Columns["RATE_PRICE_STOCK_UNIT"].Visible = false;
               
                dataGridView1.Columns["BALANCE_STOCK_UNIT"].Visible = false;
                dataGridView1.Columns["COST_STOCK_UNIT"].Visible = false;
               
            }


        }
      


        private void Button_Add_Click(object sender, EventArgs e)
        {
            new List_Inventory_Head_Add().Show();

            List_Inventory_Head_Add form_new = new List_Inventory_Head_Add();
            form_new.ShowDialog();
        }

        private void List_Inventory_Head_Load(object sender, EventArgs e)
        {
           // InitializeComponent();
            //  dt = db.SelectQuery("Select * FROM PARENT_HEADS ");
            //database.InsertQuery("Insert into DBProperties (Db_ID,DB_NAME, DB_START,DB_END,DB_COMPANYNAME,DB_COMPLOGO_PATH,DB_DBSTORAGE_PATH,DB_CNICRECORD_PATH,DB_BACKUPDATA_PATH,DB_PHOTORECORD_PATH) Values (" + (x).ToString() + ",'" + textBox_DatabaseName.Text.ToString() + "','" + dateTimePicker_DatabaseStartDate.Value + "','" + dateTimePicker_DatabaseEndDate.Value + "','" + textBox_DatabaseStoragePath.Text.ToString() + "','" + textBox_CompanyName.Text.ToString() + "','" + textBox_CompanyLogoPath.Text.ToString() + "','" + textBox_CNICPath.Text.ToString() + "','" + textBox_BackupDataPath.Text.ToString() + "','" + textBox_PhotoRecordPath.Text.ToString() + "')");
            //  dcon.InsertQuery("Insert into PARENT_HEADS (PARENTHEAD_ID,PARENTHEAD_TYPE,PARENTHEAD_CODE,PARENTHEAD_TITLE) VALUES (" + x.ToString() + ",'" + a + "','" + textBox_Parent_Head_Code.Text.ToString() + "','" + textBox_Parent_Head_Title.Text.ToString() + "')");
            

      
        }


        private void Button_Print_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument2;
            printDialog1.ShowDialog();
        }

        private void Button_Properties_Click(object sender, EventArgs e)
        {
            new List_Inventory_Head_Properties().Show();




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List_Inventory_Head_Add IPHP = new List_Inventory_Head_Add();
           

            IPHP.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (searchby.SelectedIndex == 0)
            {
                invParentHeadCode = search.Text;
                if (Program.inv_units == "SPL")
                {
                    dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }
                else if (Program.inv_units == "S")
                {
                  //  MessageBox.Show("d"+invParentHeadCode+"d");
                    dt_table = dt_conn.SelectQuery("EXEC  RetrieveINVHeadscode_stock '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }
                else if (Program.inv_units == "P")
                {
                    dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_packing '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }
                else if (Program.inv_units == "L")
                {
                    dt_table = dt_conn.SelectQuery("EXEC  RetrieveINVHeadscode_loose'" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }
                else if (Program.inv_units == "SP")
                {
                    dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_stockloose '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }
                else if (Program.inv_units == "SL")
                {
                    dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_stockpacking '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;

                }
                else if (Program.inv_units == "PL")
                {
                    dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_packingloose '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }
            }

            else if (searchby.SelectedIndex == 1)
            {
                invParentHeadCode = search.Text.ToUpper();
                if (Program.inv_units == "SPL")
                {
                    dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }
                else if (Program.inv_units == "S")
                {
                   // MessageBox.Show("d" + invParentHeadCode + "d");
                    dt_table = dt_conn.SelectQuery("EXEC  RetrieveINVHeadscode_stockt '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }
                else if (Program.inv_units == "P")
                {
                    dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_packingt '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }
                else if (Program.inv_units == "L")
                {
                    dt_table = dt_conn.SelectQuery("EXEC  RetrieveINVHeadscode_looset'" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }
                else if (Program.inv_units == "SP")
                {
                    dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_stocklooset '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }
                else if (Program.inv_units == "SL")
                {
                    dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_stockpackingt '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;

                }
                else if (Program.inv_units == "PL")
                {
                    dt_table = dt_conn.SelectQuery("EXEC RetrieveINVHeadscode_packinglooset '" + invParentHeadCode + "';");
                    dataGridView1.DataSource = dt_table;
                }


            }



            }

        private void button3_Click(object sender, EventArgs e)
        {
            List_Inventory_Head_Properties IPHP = new List_Inventory_Head_Properties();
            //IPHP.button_Modify.Visible = true;
            //IPHP.button_Remove.Visible = true;

            IPHP.ShowDialog();
            
            

        }
    }
}
