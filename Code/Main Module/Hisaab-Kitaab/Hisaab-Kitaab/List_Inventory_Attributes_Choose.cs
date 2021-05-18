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
    public partial class ListInventoryAttributesChoose : Form
    {
        Color col = System.Drawing.ColorTranslator.FromHtml("#293574");

        public DataTable dt = new DataTable();
        public DataTable da = new DataTable();
        public DataTable dat = new DataTable();
        public DataTable dat2 = new DataTable();
        public DataTable dat3 = new DataTable();
        public dataconnection db = new dataconnection();

        dataconnection dcon = new dataconnection();
        DataTable dt_count_lvl1 = new DataTable();
        DataTable dt_data_lvl1 = new DataTable();

        DataTable dt_count_lvl2 = new DataTable();
        DataTable dt_data_lvl2 = new DataTable();

        DataTable dt_count_lvl3 = new DataTable();
        DataTable dt_data_lvl3 = new DataTable();

        DataTable dt_count_lvl4 = new DataTable();
        DataTable dt_data_lvl4 = new DataTable();

        DataTable dt_InvAttQuery = new DataTable();

        public string SetValueForText1 { get; private set; }
        public ListInventoryAttributesChoose()
        {
            InitializeComponent();
            populate_tree_BalTab();
            
            //  labelAccHead.ForeColor = col;
            label_InvParentHead.ForeColor = col;

            //  buttonPropertiesAccHead.ForeColor = col;
            //  buttonPropertiesAccHead.BackColor = Color.White;

            Button_Add.ForeColor = col;
            Button_Add.BackColor = Color.White;

            // Button_Print.ForeColor = col;
            // Button_Print.BackColor = Color.White;

            // Button_Properties.ForeColor = col;
            // Button_Properties.BackColor = Color.White;
        }
        public void populate_tree_BalTab()
        {
            int level1 = 0;
            int level2 = 0;
            int level3 = 0;
            int level4 = 0;

            string updated_code;
            string temp;

            dt_count_lvl1 = dcon.SelectQuery("EXEC Count_Heads '%-000-000-000','I','B';");
            level1 = Convert.ToInt32(dt_count_lvl1.Rows[0][0].ToString()); //Total records of top level
            dt_data_lvl1 = dcon.SelectQuery("EXEC Heads_CodeTitle '%-000-000-000','I','B';");

            if (level1 > 0)
            {
                for (int i = 0; i < level1; i++)
                {
                    treeView_BSAccHead.Nodes.Add(dt_data_lvl1.Rows[i][0].ToString() + "  " + dt_data_lvl1.Rows[i][1].ToString());
                    temp = dt_data_lvl1.Rows[i][0].ToString();
                    updated_code = temp.Substring(0, 3) + "-%-000-000";

                    dt_count_lvl2 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','I','B';");
                    level2 = Convert.ToInt32(dt_count_lvl2.Rows[0][0].ToString());
                    dt_data_lvl2 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','I','B';");

                    if (level2 > 1)
                    {
                        for (int j = 1; j < level2; j++)
                        {
                            treeView_BSAccHead.Nodes[i].Nodes.Add(dt_data_lvl2.Rows[j][0].ToString() + "  " + dt_data_lvl2.Rows[j][1].ToString());
                            temp = dt_data_lvl2.Rows[j][0].ToString();
                            updated_code = temp.Substring(0, 7) + "-%-000";

                            dt_count_lvl3 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','I','B';");
                            level3 = Convert.ToInt32(dt_count_lvl3.Rows[0][0].ToString());
                            dt_data_lvl3 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','I','B';");


                            if (level3 > 1)
                            {
                                for (int k = 1; k < level3; k++)
                                {

                                    treeView_BSAccHead.Nodes[i].Nodes[j - 1].Nodes.Add(dt_data_lvl3.Rows[k][0].ToString() + "  " + dt_data_lvl3.Rows[k][1].ToString());
                                    temp = dt_data_lvl3.Rows[k][0].ToString();
                                    updated_code = temp.Substring(0, 11) + "-%";

                                    dt_count_lvl4 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','I','B';");
                                    level4 = Convert.ToInt32(dt_count_lvl4.Rows[0][0].ToString());
                                    dt_data_lvl4 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','I','B';");

                                    if (level4 > 1)
                                    {
                                        for (int l = 1; l < level4; l++)
                                        {
                                            treeView_BSAccHead.Nodes[i].Nodes[j - 1].Nodes[k - 1].Nodes.Add(dt_data_lvl4.Rows[l][0].ToString() + "  " + dt_data_lvl4.Rows[l][1].ToString());
                                        }
                                    }


                                }
                            }


                        }
                    }



                }

            }

        }
        

        private void ListInventoryAttributesChoose_Load(object sender, EventArgs e)
        {

        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (treeView_BSAccHead.SelectedNode!=null)
            {
                List_Inventory_Attributes.invParentHead = treeView_BSAccHead.SelectedNode.Text.Substring(17);
                List_Inventory_Attributes.invParentHeadCode = treeView_BSAccHead.SelectedNode.Text.Substring(0,17);
                //ListInventoryAttributes.invParentHeadCode = dcon.SelectQuery("Select PARENTHEAD_CODE from PARENT_HEADS where PARENTHEAD_TITLE = " + ListInventoryAttributes.invParentHead).ToString();
                MessageBox.Show(List_Inventory_Attributes.invParentHeadCode.ToString());
            }
            else
            {
                MessageBox.Show("Please choose a Parent Head.");
            }

            this.Hide();
        }
    }
}
