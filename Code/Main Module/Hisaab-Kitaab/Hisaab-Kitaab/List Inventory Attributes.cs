using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hisaab_Kitaab
{
    public partial class List_Inventory_Attributes : Form
    {
        public static string invParentHead = "";
        public static string invParentHeadCode = "";
        dataconnection dcon = new dataconnection();
        DataTable dt_InvAttQuery = new DataTable();
        public List_Inventory_Attributes()
        {
            InitializeComponent();
            
        }

        private void Button_Choose_Click(object sender, EventArgs e)
        {
            
            ListInventoryAttributesChoose choose = new ListInventoryAttributesChoose();

            DialogResult result = new DialogResult();
            result = choose.ShowDialog();
            MessageBox.Show(result.ToString());

            if (result == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(invParentHead) == false)
                {
                    textBox1.Text = invParentHead;
                    FontFamily myFontFamily = new FontFamily("Cambria");

                    //Run Query Depending on What Units Are Chosen
                    if(Program.inv_units == "SPL")
                    {
                        dt_InvAttQuery = dcon.SelectQuery("EXEC InventoryAttributesGivenParentHead '" + invParentHeadCode + "';");
                    }
                    else if (Program.inv_units == "S")
                    {
                        dt_InvAttQuery = dcon.SelectQuery("EXEC InventoryAttributesGivenParentHead_Stock '" + invParentHeadCode + "';");
                    }
                    else if (Program.inv_units == "P")
                    {
                        dt_InvAttQuery = dcon.SelectQuery("EXEC InventoryAttributesGivenParentHead_Packing '" + invParentHeadCode + "';");
                    }
                    else if (Program.inv_units == "L")
                    {
                        dt_InvAttQuery = dcon.SelectQuery("EXEC InventoryAttributesGivenParentHead_Loose '" + invParentHeadCode + "';");
                    }
                    else if (Program.inv_units == "SP")
                    {
                        dt_InvAttQuery = dcon.SelectQuery("EXEC InventoryAttributesGivenParentHead_StockPacking '" + invParentHeadCode + "';");
                    }
                    else if (Program.inv_units == "SL")
                    {
                        dt_InvAttQuery = dcon.SelectQuery("EXEC InventoryAttributesGivenParentHead_StockLoose '" + invParentHeadCode + "';");
                    }
                    else if (Program.inv_units == "PL")
                    {
                        dt_InvAttQuery = dcon.SelectQuery("EXEC InventoryAttributesGivenParentHead_PackingLoose '" + invParentHeadCode + "';");
                    }

                    dataGridView_InvAttributes.DataSource = dt_InvAttQuery;
                    dataGridView_InvAttributes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_InvAttributes.Columns[0].Frozen = true;
                    dataGridView_InvAttributes.AutoSize = false;
                    dataGridView_InvAttributes.ScrollBars = ScrollBars.Both;
                    dataGridView_InvAttributes.Font = new Font(myFontFamily, 12, FontStyle.Regular);

                }
                else
                {

                }

            }
        }

        

        private void ListInventoryAttributes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_InvAttributes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
