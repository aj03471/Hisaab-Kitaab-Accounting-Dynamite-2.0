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
    public partial class Choose_Account_Parent_Head : Form
    {
        
        Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
        public string selected_head = "";

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

        DataTable dt_AccHeadQuery = new DataTable();

        public string SetValueForText1 { get; private set; }

        public Choose_Account_Parent_Head()
        {

            InitializeComponent();
            populate_tree_BalTab();
            populate_tree_IncTab();
            this.Icon = new Icon("D:\\FYP\\Hisaab-Kitaab\\Hisaab-Kitaab\\Resources\\SDS1-removebg-preview.ico");
            //  labelAccHead.ForeColor = col;
            label_AccParentHead.ForeColor = col;

          //  buttonPropertiesAccHead.ForeColor = col;
          //  buttonPropertiesAccHead.BackColor = Color.White;

            Button_Ok.ForeColor = col;
            Button_Ok.BackColor = Color.White;

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

            dt_count_lvl1 = dcon.SelectQuery("EXEC Count_Heads '%-000-000-000','A','B';");
            level1 = Convert.ToInt32(dt_count_lvl1.Rows[0][0].ToString()); //Total records of top level
            dt_data_lvl1 = dcon.SelectQuery("EXEC Heads_CodeTitle '%-000-000-000','A','B';");

            if (level1 > 0)
            {
                for (int i = 0; i < level1; i++)
                {
                    treeView_BSAccHead.Nodes.Add(dt_data_lvl1.Rows[i][0].ToString().Trim() + "  " + dt_data_lvl1.Rows[i][1].ToString().Trim());
                    temp = dt_data_lvl1.Rows[i][0].ToString();
                    updated_code = temp.Substring(0, 3) + "-%-000-000";

                    dt_count_lvl2 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','A','B';");
                    level2 = Convert.ToInt32(dt_count_lvl2.Rows[0][0].ToString());
                    dt_data_lvl2 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','A','B';");

                    if (level2 > 1)
                    {
                        for (int j = 1; j < level2; j++)
                        {
                            treeView_BSAccHead.Nodes[i].Nodes.Add(dt_data_lvl2.Rows[j][0].ToString().Trim() + "  " + dt_data_lvl2.Rows[j][1].ToString().Trim());
                            temp = dt_data_lvl2.Rows[j][0].ToString();
                            updated_code = temp.Substring(0, 7) + "-%-000";

                            dt_count_lvl3 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','A','B';");
                            level3 = Convert.ToInt32(dt_count_lvl3.Rows[0][0].ToString());
                            dt_data_lvl3 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','A','B';");


                            if (level3 > 1)
                            {
                                for (int k = 1; k < level3; k++)
                                {

                                    treeView_BSAccHead.Nodes[i].Nodes[j - 1].Nodes.Add(dt_data_lvl3.Rows[k][0].ToString().Trim() + "  " + dt_data_lvl3.Rows[k][1].ToString().Trim());
                                    temp = dt_data_lvl3.Rows[k][0].ToString();
                                    updated_code = temp.Substring(0, 11) + "-%";

                                    dt_count_lvl4 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','A','B';");
                                    level4 = Convert.ToInt32(dt_count_lvl4.Rows[0][0].ToString());
                                    dt_data_lvl4 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','A','B';");

                                    if (level4 > 1)
                                    {
                                        for (int l = 1; l < level4; l++)
                                        {
                                            treeView_BSAccHead.Nodes[i].Nodes[j - 1].Nodes[k - 1].Nodes.Add(dt_data_lvl4.Rows[l][0].ToString().Trim() + "  " + dt_data_lvl4.Rows[l][1].ToString().Trim());
                                        }
                                    }


                                }
                            }


                        }
                    }



                }

            }

        }

        public void populate_tree_IncTab()
        {
            int level1 = 0;
            int level2 = 0;
            int level3 = 0;
            int level4 = 0;

            string updated_code;
            string temp;

            dt_count_lvl1 = dcon.SelectQuery("EXEC Count_Heads '%-000-000-000','A','I';");
            level1 = Convert.ToInt32(dt_count_lvl1.Rows[0][0].ToString()); //Total records of top level
            dt_data_lvl1 = dcon.SelectQuery("EXEC Heads_CodeTitle '%-000-000-000','A','I';");

            if (level1 > 0)
            {
                for (int i = 0; i < level1; i++)
                {
                    treeView_IncAccHead.Nodes.Add(dt_data_lvl1.Rows[i][0].ToString().Trim() + "  " + dt_data_lvl1.Rows[i][1].ToString().Trim());
                    temp = dt_data_lvl1.Rows[i][0].ToString();
                    updated_code = temp.Substring(0, 3) + "-%-000-000";


                    dt_count_lvl2 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','A','I';");
                    level2 = Convert.ToInt32(dt_count_lvl2.Rows[0][0].ToString());
                    dt_data_lvl2 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','A','I';");

                    if (level2 > 1)
                    {
                        for (int j = 1; j < level2; j++)
                        {
                            treeView_IncAccHead.Nodes[i].Nodes.Add(dt_data_lvl2.Rows[j][0].ToString().Trim() + "  " + dt_data_lvl2.Rows[j][1].ToString().Trim());
                            temp = dt_data_lvl2.Rows[j][0].ToString();
                            updated_code = temp.Substring(0, 7) + "-%-000";

                            dt_count_lvl3 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','A','I';");
                            level3 = Convert.ToInt32(dt_count_lvl3.Rows[0][0].ToString());
                            dt_data_lvl3 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','A','I';");


                            if (level3 > 1)
                            {
                                for (int k = 1; k < level3; k++)
                                {

                                    treeView_IncAccHead.Nodes[i].Nodes[j - 1].Nodes.Add(dt_data_lvl3.Rows[k][0].ToString().Trim() + "  " + dt_data_lvl3.Rows[k][1].ToString().Trim());
                                    temp = dt_data_lvl3.Rows[k][0].ToString();
                                    updated_code = temp.Substring(0, 11) + "-%";

                                    dt_count_lvl4 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','A','I';");
                                    level4 = Convert.ToInt32(dt_count_lvl4.Rows[0][0].ToString());
                                    dt_data_lvl4 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','A','I';");

                                    if (level4 > 1)
                                    {
                                        for (int l = 1; l < level4; l++)
                                        {
                                            treeView_IncAccHead.Nodes[i].Nodes[j - 1].Nodes[k - 1].Nodes.Add(dt_data_lvl4.Rows[l][0].ToString().Trim() + "  " + dt_data_lvl4.Rows[l][1].ToString().Trim());
                                        }
                                    }


                                }
                            }


                        }
                    }



                }

            }

        }

        private void List_Account_Attributes_Choose_Load(object sender, EventArgs e)
        {
           

            
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (treeView_BSAccHead.SelectedNode != null) 
            {
                selected_head = treeView_BSAccHead.SelectedNode.Text.ToString();
                //MessageBox.Show("Kia?");
            }
            else if (treeView_IncAccHead.SelectedNode != null)
            {
                selected_head = treeView_IncAccHead.SelectedNode.Text.ToString();
            }
            else if (treeView_BSAccHead.SelectedNode == null && treeView_IncAccHead.SelectedNode == null)
            {
                selected_head = "999-000-000-000  UNSPECIFIED PARENT CODE";
                //MessageBox.Show("999-000-000-000  UNSPECIFIED PARENT CODE");
            }

           // List_Account_Attributes.chosenParentHead = treeView_BSAccHead.SelectedNode.Text.Substring(17);



        }

        private void Choose_Account_Parent_Head_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.DialogResult == DialogResult.Cancel)
            {
                selected_head = "999-000-000-000  UNSPECIFIED PARENT CODE";
            }
            
        }
    }
}