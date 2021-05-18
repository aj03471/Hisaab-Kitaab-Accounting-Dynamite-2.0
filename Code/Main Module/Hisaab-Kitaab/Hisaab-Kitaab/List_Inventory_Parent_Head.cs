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
    public partial class List_Inventory_Parent_Head : Form
    {
        public List_Inventory_Parent_Head()
        {
            InitializeComponent();
            populate_tree_BalTab();
            label_AccParentHead.ForeColor = ColorTranslator.FromHtml("#293574");
            labelAccHead.ForeColor = ColorTranslator.FromHtml("#293574");
            labelCode.ForeColor = ColorTranslator.FromHtml("#293574");
            Button_Add.BackColor = ColorTranslator.FromHtml("#293574");
            Button_Add.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            Button_Modify.BackColor = ColorTranslator.FromHtml("#293574");
            Button_Modify.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            Button_Print.BackColor = ColorTranslator.FromHtml("#293574");
            Button_Print.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            buttonPropertiesAccHead.BackColor = ColorTranslator.FromHtml("#293574");
            buttonPropertiesAccHead.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }
        DataTable dt_AccHeadQuery = new DataTable();
        dataconnection dcon = new dataconnection();
        DataTable dt_count_lvl1 = new DataTable();
        DataTable dt_data_lvl1 = new DataTable();

        DataTable dt_count_lvl2 = new DataTable();
        DataTable dt_data_lvl2 = new DataTable();

        DataTable dt_count_lvl3 = new DataTable();
        DataTable dt_data_lvl3 = new DataTable();

        DataTable dt_count_lvl4 = new DataTable();
        DataTable dt_data_lvl4 = new DataTable();
        string code1;
        int lvl;
        
        DataTable dt_InvHeadQuery = new DataTable();

        private void List_Inventory_Parent_Head_Load(object sender, EventArgs e)
        {

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
                    treeView_BSInvHead.Nodes.Add(dt_data_lvl1.Rows[i][0].ToString() + "  " + dt_data_lvl1.Rows[i][1].ToString());
                    temp = dt_data_lvl1.Rows[i][0].ToString();
                    updated_code = temp.Substring(0, 3) + "-%-000-000";

                    dt_count_lvl2 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','I','B';");
                    level2 = Convert.ToInt32(dt_count_lvl2.Rows[0][0].ToString());
                    dt_data_lvl2 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','I','B';");

                    if (level2 > 1)
                    {
                        for (int j = 1; j < level2; j++)
                        {
                            treeView_BSInvHead.Nodes[i].Nodes.Add(dt_data_lvl2.Rows[j][0].ToString() + "  " + dt_data_lvl2.Rows[j][1].ToString());
                            temp = dt_data_lvl2.Rows[j][0].ToString();
                            updated_code = temp.Substring(0, 7) + "-%-000";

                            dt_count_lvl3 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','I','B';");
                            level3 = Convert.ToInt32(dt_count_lvl3.Rows[0][0].ToString());
                            dt_data_lvl3 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','I','B';");


                            if (level3 > 1)
                            {
                                for (int k = 1; k < level3; k++)
                                {

                                    treeView_BSInvHead.Nodes[i].Nodes[j - 1].Nodes.Add(dt_data_lvl3.Rows[k][0].ToString() + "  " + dt_data_lvl3.Rows[k][1].ToString());
                                    temp = dt_data_lvl3.Rows[k][0].ToString();
                                    updated_code = temp.Substring(0, 11) + "-%";

                                    dt_count_lvl4 = dcon.SelectQuery("EXEC Count_Heads '" + updated_code + "','I','B';");
                                    level4 = Convert.ToInt32(dt_count_lvl4.Rows[0][0].ToString());
                                    dt_data_lvl4 = dcon.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','I','B';");

                                    if (level4 > 1)
                                    {
                                        for (int l = 1; l < level4; l++)
                                        {
                                            treeView_BSInvHead.Nodes[i].Nodes[j - 1].Nodes[k - 1].Nodes.Add(dt_data_lvl4.Rows[l][0].ToString() + "  " + dt_data_lvl4.Rows[l][1].ToString());
                                        }
                                    }


                                }
                            }


                        }
                    }



                }

            }

        }

        private void treeView_BSInvHead_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(treeView_BSAccHead.SelectedNode.Text.ToString());
            FontFamily myFontFamily = new FontFamily("Cambria");
            string temp;
            temp = treeView_BSInvHead.SelectedNode.Text.ToString();
            string code = temp.Substring(0, 15);
            string title;
            title = temp.Substring(15, temp.Length - 15);
            title = title.Trim(' ');
            labelAccHead.Text = "Inventory Heads of " + title;
            labelCode.Text = code;
            dt_InvHeadQuery = dcon.SelectQuery("EXEC InventoryHeadGivenParentHead '" + code + "';");
            dataGridView_AccHead.DataSource = dt_InvHeadQuery;
            dataGridView_AccHead.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_AccHead.Font = new Font(myFontFamily, 12, FontStyle.Regular);
            code1 = treeView_BSInvHead.SelectedNode.Text.Substring(0,15);
            lvl = treeView_BSInvHead.SelectedNode.Level;



        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            //if (treeView_BSInvHead.SelectedNode != null)
            //{

                List_Inventory_Parent_Head_Add IPHA = new List_Inventory_Parent_Head_Add(lvl,code1);
                
                DialogResult result = new DialogResult();
                result = IPHA.ShowDialog();
                if (result == DialogResult.OK)
                {
                    treeView_BSInvHead.Nodes.Clear();
                    populate_tree_BalTab();

                }
                
            //}
            //else
            //{
            //    MessageBox.Show("Please select inventory head");
            //}
        }

        private void Button_Modify_Click(object sender, EventArgs e)
        {
            if (treeView_BSInvHead.SelectedNode != null)
                {
                List_Inventory_Parent_Head_Modify IPHM = new List_Inventory_Parent_Head_Modify(treeView_BSInvHead.SelectedNode.Text.Substring(0,15), treeView_BSInvHead.SelectedNode.Text.Substring(17));
                DialogResult result = new DialogResult();
                result=IPHM.ShowDialog();
                if (result==DialogResult.OK)
                    {
                    treeView_BSInvHead.Nodes.Clear();
                    populate_tree_BalTab();

                }
                
            }
            else
            {
                MessageBox.Show("Please select inventory head");
            }
            
           
        }

        private void buttonPropertiesAccHead_Click(object sender, EventArgs e)
        {
            List_Inventory_Head_Properties IPHP = new List_Inventory_Head_Properties();
            IPHP.ShowDialog();
        }
        private void ClearRecursive(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.BackColor = Color.White;
                ClearRecursive(tn);
            }
        }
        private void ClearBackColor()
        {
            TreeNodeCollection nodes = treeView_BSInvHead.Nodes;
            foreach (TreeNode n in nodes)
            {
                ClearRecursive(n);
            }
        }

        private void FindByText()
        {
            TreeNodeCollection nodes = treeView_BSInvHead.Nodes;
            foreach (TreeNode n in nodes)
            {
                FindRecursive(n);
            }
        }
        private void FindByText1()
        {
            TreeNodeCollection nodes = treeView_BSInvHead.Nodes;
            foreach (TreeNode n in nodes)
            {
                FindRecursive1(n);
            }
        }
        private void FindRecursive(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                string str = tn.Text.Substring(15);
                str = str.Trim();
                // if the text properties match, color the item  
                 //// MessageBox.Show("d"+str+"d", "d"+inventorysearch.Text+"d");
                if (str ==inventorysearch.Text)
                {  tn.BackColor = HelperClass.lightBlue;
                return;
                 }
               
                
                
                FindRecursive(tn);
                
            }
        }

        private void FindRecursive1(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                string str = tn.Text.Substring(0,15);
                str = str.Trim();
                // if the text properties match, color the item  
                //// MessageBox.Show("d"+str+"d", "d"+inventorysearch.Text+"d");
                if (str == inventorysearch.Text)
                {
                    tn.BackColor = HelperClass.lightBlue;
                    return;
                }



                FindRecursive(tn);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox_SearchByParentHead.SelectedIndex == 1)
            {
                ClearBackColor();
                FindByText();
            }
            if (comboBox_SearchByParentHead.SelectedIndex == 0)
            {
                ClearBackColor();
                FindByText1();
            }

        }

        private void dataGridView_AccHead_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // INVPARENTHEAD_ID = "+ code1  +" A
            // DataTable dt_AccHeadQuery = new DataTable()
            string a = "a";
            int b = 1;
            if (textBox1.Text == "Search")
            {
                MessageBox.Show("Please enter something in order to search");
            }
            else if (comboBox_SearchByAccHead.SelectedIndex == 0  && textBox1.Text == "")
            {
                MessageBox.Show("Please enter a numeric value in order to search");
            }
            else if (comboBox_SearchByAccHead.SelectedIndex == 1 && textBox1.Text == "")
            {
                MessageBox.Show("Please enter a text in order to search");
            }
            //else if (comboBox_SearchByAccHead.SelectedIndex == 0 && textBox1.Text.GetType() != b.GetType())
            //{
            //    MessageBox.Show("Please enter a numeric value");
            //}
            else if (comboBox_SearchByAccHead.SelectedIndex == 1 && textBox1.Text.GetType() != a.GetType())
            {
                MessageBox.Show("Please enter an alphabetic value");
            }
            else
            {

                if (comboBox_SearchByAccHead.SelectedIndex == 0)
              
                {
                   // MessageBox.Show("Code");
                    dt_AccHeadQuery = dcon.SelectQuery("Select INVHEAD_ID,INVHEAD_NAME from INVENTORY_HEADS WHERE  INVHEAD_ID=" + textBox1.Text.ToString() + "");
                    dataGridView_AccHead.DataSource = dt_AccHeadQuery;
                }
                else if (comboBox_SearchByAccHead.SelectedIndex == 1)
                {
                   // MessageBox.Show("Title");

                    dt_AccHeadQuery = dcon.SelectQuery("Select * from INVENTORY_HEADS INNER JOIN PARENT_HEADS ON PARENT_HEADS.PARENTHEAD_ID = INVENTORY_HEADS.INVPARENTHEAD_ID WHERE INVHEAD_NAME like '" +  textBox1.Text.ToString() + "'");
          
                    dataGridView_AccHead.DataSource = dt_AccHeadQuery;

                }
                else 
                {
                    dt_AccHeadQuery = dcon.SelectQuery("Select * from INVENTORY_HEADS");
                    dataGridView_AccHead.DataSource = dt_AccHeadQuery;

                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_SearchByAccHead_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inventorysearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label_AccParentHead_Click(object sender, EventArgs e)
        {

        }

        private void labelAccHead_Click(object sender, EventArgs e)
        {

        }

        private void labelCode_Click(object sender, EventArgs e)
        {

        }
        
    }
}
