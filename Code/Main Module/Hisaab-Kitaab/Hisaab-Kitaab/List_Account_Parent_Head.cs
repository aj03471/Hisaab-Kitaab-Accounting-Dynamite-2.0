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
    
    public partial class List_Account_Parent_Head : Form
    {    
        string Add_parent_code,Add_parent_title = "";
        string previous_content = "";
        string selected_type = "";
        string selected_parent_code = "";

        dataconnection db = new dataconnection();
        dataconnection dcon = new dataconnection();       
        DataTable dt = new DataTable();
        DataTable da = new DataTable();
        DataTable dat = new DataTable();
        DataTable dat2 = new DataTable();
        DataTable dat3 = new DataTable();        
        DataTable dt_AccHeadQuery = new DataTable();
        DataTable AddPH = new DataTable();
        DataTable dt_table = new DataTable();

        public List_Account_Parent_Head()
        {          
            InitializeComponent();
            HelperClass.PopulateTreeView(treeView_BSAccHead, "A", "B");
            HelperClass.PopulateTreeView(treeView_IncAccHead, "A", "I"); 

            labelAccHead.ForeColor = HelperClass.darkBlue;
            label_AccParentHead.ForeColor = HelperClass.darkBlue;
            buttonPropertiesAccHead.ForeColor = HelperClass.darkBlue;
            buttonPropertiesAccHead.BackColor = Color.White;
            Button_Add.ForeColor = HelperClass.darkBlue;
            Button_Add.BackColor = Color.White;
            Button_Print.ForeColor = HelperClass.darkBlue;
            Button_Print.BackColor = Color.White;
            Button_Modify.ForeColor = HelperClass.darkBlue;
            Button_Modify.BackColor = Color.White;
        }

        private void List_Account_Head_Load(object sender, EventArgs e)
        {         
            dt = db.SelectQuery("Select * FROM PARENT_HEADS ");
            //dataGridView2.DataSource = dt;
            //dataGridView3.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
        

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument2;
            printDialog1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new List_Account_Parent_Head_Add().Show();
           
        }

        private void Button_Properties_Click(object sender, EventArgs e)
        {
            //List_Account_Head_Properties myform = new List_Account_Head_Properties();
            // myform.textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            //myform.textBox1.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
           // myform.textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            // dataconnection database = new dataconnection();
            // DataTable da = new DataTable();



            //da = db.SelectQuery("Select * FROM DEPRICIATION_CARD WHERE  ACCHEAD_ID  like '" + myform.textBox2.Text + "%'  ");

         //     int x = 0;
           // int y = 0;
            // dt = db.SelectQuery("Select * FROM DEPRECIATION_CARD ");
            // dataGridView2.DataSource = dt;
           //  x = Convert.ToInt32(dt.Rows[0][1]);
          //  y = Convert.ToInt32(dt.Rows[0][3]);

             //myform.textBox3.Text = da.Rows[0][0].ToString();
             //myform.textBox4.Text = da.Rows[0][2].ToString();
             //myform.textBox5.Text = da.Rows[0][3].ToString();
             //myform.textBox6.Text = da.Rows[0][4].ToString();
             //myform.textBox7.Text = da.Rows[0][5].ToString();

          //  dat = db.SelectQuery("Select * FROM DEPRICIATION_YEARLYRATES WHERE  DEPCARD_ID  like '" + myform.textBox3.Text + "%'  ");

          //  myform.textBox8.Text = dat.Rows[0][0].ToString();
          //  myform.textBox10.Text = dat.Rows[0][2].ToString();
          //  myform.textBox11.Text = dat.Rows[0][3].ToString();


          //  dat2 = db.SelectQuery("Select * FROM ACCOUNT_ATTRIBUTES WHERE  ACCHEAD_ID  like '" + myform.textBox2.Text + "%'  ");

          //  myform.textBox9.Text = dat2.Rows[0][0].ToString();
          //  myform.textBox12.Text = dat2.Rows[0][2].ToString();



          //  dat3 = db.SelectQuery("Select * FROM ADDRESS_CARD WHERE  ACCHEAD_ID  like '" + myform.textBox2.Text + "%'  ");

          //  myform.textBox90.Text = dat3.Rows[0][0].ToString();
          ////  string a = "";
          // // a =a + dat3.Rows[0][2].ToString() + dat3.Rows[0][3].ToString() + dat3.Rows[0][4].ToString();

          //  myform.textBox91.Text = dat3.Rows[0][2].ToString();
          //  myform.textBox92.Text = dat3.Rows[0][3].ToString();
          //  myform.textBox93.Text = dat3.Rows[0][4].ToString();
          //  myform.textBox94.Text = dat3.Rows[0][5].ToString();
          //  myform.textBox95.Text = dat3.Rows[0][6].ToString();
          //  myform.textBox96.Text = dat3.Rows[0][7].ToString();



          //  myform.ShowDialog();
            //  new List_Account_Head_Properties().Show();

        }


       // }

        private void listAccountHeadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listInventoryHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new List_Inventory_Head().Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // List_Account_Head_Properties  myform = new List_Account_Head_Properties();
            // myform.textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
             //  myform.textBox1.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
              // myform.textBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
              // myform.ShowDialog();
            //AnotherForm anotherForm = new AnotherForm();
            // anotherForm.Show();
            // anotherForm.TB.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            // List_Account_Head_Properties frm = (List_Account_Head_Properties)Application.OpenForms["List_Account_Head_Properties"];
            // int row = this.dataGridView2.CurrentRow.Index;
            //frm.textBox1.Text = Convert.ToString(this.dataGridView2[0, row].Value);
            // frm.textBox2.Text = Convert.ToString(this.dataGridView2[1, row].Value);



        }

        private void search2_TextChanged(object sender, EventArgs e)
        {

        }

        private TreeNode SearchNodeinTree(string temp)
        {
            TreeNode tn = new TreeNode();
            //string temp = search2.Text.ToString();
            int level1, level2, level3, level4;

            if (String.IsNullOrWhiteSpace(temp) == false)
            {
                //Search by Parent Code
                //dt = db.SelectQuery("Select PARENTHEAD_ID, PARENTHEAD_CODE, PARENTHEAD_TITLE FROM PARENT_HEADS  WHERE PARENTHEAD_CODE LIKE '" + temp + "%'");
                //if (dt.Rows.Count > 0)
                //{
                level1 = treeView_BSAccHead.GetNodeCount(false);
                for (int i = 0; i < level1; i++)
                {
                    string temp2 = treeView_BSAccHead.Nodes[i].Text.ToString();
                    if (temp2.Substring(0, 15) == temp)
                    {
                        MessageBox.Show("Found it 1st"+ temp2.Substring(0, 15).ToString());
                        return treeView_BSAccHead.Nodes[i];

                    }
                    level2 = treeView_BSAccHead.Nodes[i].GetNodeCount(false);
                    for (int j = 0; j < level2; j++)
                    {
                        string temp3 = treeView_BSAccHead.Nodes[i].Nodes[j].Text.ToString();
                        if (temp2.Substring(0, 15) == temp)
                        {
                            MessageBox.Show("Found it 2nd");
                            return treeView_BSAccHead.Nodes[i].Nodes[j];

                        }
                        level3 = treeView_BSAccHead.Nodes[i].Nodes[j].GetNodeCount(false);
                        for (int k = 0; k < level3; k++)
                        {
                            string temp4 = treeView_BSAccHead.Nodes[i].Nodes[j].Nodes[k].Text.ToString();
                            if (temp2.Substring(0, 15) == temp)
                            {
                                MessageBox.Show("Found it 3rd");
                                return treeView_BSAccHead.Nodes[i].Nodes[j].Nodes[k];

                            }
                            level4 = treeView_BSAccHead.Nodes[i].Nodes[j].Nodes[k].GetNodeCount(false);
                            for (int l = 0; l < level4; l++)
                            {
                                string temp5 = treeView_BSAccHead.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Text.ToString();
                                if (temp2.Substring(0, 15) == temp)
                                {
                                    MessageBox.Show("Found it 4th");
                                    return treeView_BSAccHead.Nodes[i].Nodes[j].Nodes[k].Nodes[l];

                                }
                            }
                        }
                    }
                                               
                }

                
            }



            MessageBox.Show("Nahi mila");
            return tn;

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
            TreeNodeCollection nodes = treeView_BSAccHead.Nodes;
            foreach (TreeNode n in nodes)
            {
                ClearRecursive(n);
            }
        }

        private void FindByText()
        {
            TreeNodeCollection nodes = treeView_BSAccHead.Nodes;
            foreach (TreeNode n in nodes)
            {
                FindRecursive(n);
            }
        }
        private void FindByText1()
        {
            TreeNodeCollection nodes = treeView_BSAccHead.Nodes;
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
                if (str == search2.Text)
                {
                    tn.BackColor = Color.Yellow;
                    return;
                }



                FindRecursive(tn);

            }
        }

        private void FindRecursive1(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                string str = tn.Text.Substring(0, 15);
                str = str.Trim();
                // if the text properties match, color the item  
                //// MessageBox.Show("d"+str+"d", "d"+inventorysearch.Text+"d");
                if (str == search2.Text)
                {
                    tn.BackColor = HelperClass.lightBlue;
                    return;
                }



                FindRecursive(tn);

            }
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    if (comboBox_SearchByParentHead.SelectedIndex == 1)
        //    {
        //        ClearBackColor();
        //        FindByText();
        //    }
        //    if (comboBox_SearchByParentHead.SelectedIndex == 0)
        //    {
        //        ClearBackColor();
        //        FindByText1();
        //    }

        //}

        private void button4_Click(object sender, EventArgs e)
        {
            //Search       
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
        
 
        private int Levelno(string code)
        {
            //010-020-030-040
            string lvl1 = code.Substring(0, 3);
            string lvl2 = code.Substring(3, 3);
            string lvl3 = code.Substring(6, 3);
            string lvl4 = code.Substring(9, 3);
            if (Convert.ToInt32(lvl1) != 0)
            {
                if (Convert.ToInt32(lvl2) == 0)
                {
                    //yani yahan add karna hai
                    return 2;
                }
                else
                {
                    if (Convert.ToInt32(lvl3) == 0)
                    {
                        return 3;
                        //yani yahan add karna hai
                    }
                    else 
                    {
                        if (Convert.ToInt32(lvl4) == 0)
                        {
                            return 4;
                        }
                        else
                        {
                            return -1;
                        }
                    }     
                }               
            }
            else
            {
                return -1;
            }
            
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected_type != "")
                {
                    //person cannot add anything at lvl 1 and lvl 5
                    int lvl = Levelno(HelperClass.RemoveHyphens(selected_parent_code));
                    if(lvl == 2)
                    {
                        List_Account_Parent_Head_Add Form_Add = new List_Account_Parent_Head_Add(2,HelperClass.RemoveHyphens(selected_parent_code));
                        DialogResult result = new DialogResult();
                        result = Form_Add.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            try
                            {
                                if (Form_Add.refresh == "Bs")
                                {
                                    treeView_BSAccHead.Nodes.Clear();
                                    HelperClass.PopulateTreeView(treeView_BSAccHead,"A","B");
                                }
                                else if (Form_Add.refresh == "IncSt")
                                {
                                    treeView_IncAccHead.Nodes.Clear();
                                    HelperClass.PopulateTreeView(treeView_IncAccHead, "A", "I");
                                }
                                else
                                {
                                    MessageBox.Show("Could not refresh the tree view");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                    else if (lvl == 3)
                    {
                        List_Account_Parent_Head_Add Form_Add = new List_Account_Parent_Head_Add(3, HelperClass.RemoveHyphens(selected_parent_code));
                        DialogResult result = new DialogResult();
                        result = Form_Add.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            try
                            {
                                if (Form_Add.refresh == "Bs")
                                {
                                    treeView_BSAccHead.Nodes.Clear();
                                    HelperClass.PopulateTreeView(treeView_BSAccHead, "A", "B");
                                }
                                else if (Form_Add.refresh == "IncSt")
                                {
                                    treeView_IncAccHead.Nodes.Clear();
                                    HelperClass.PopulateTreeView(treeView_IncAccHead, "A", "I");
                                }
                                else
                                {
                                    MessageBox.Show("Could not refresh the tree view");
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                    else if (lvl == 4)
                    {
                        List_Account_Parent_Head_Add Form_Add = new List_Account_Parent_Head_Add(4, HelperClass.RemoveHyphens(selected_parent_code));
                        DialogResult result = new DialogResult();
                        result = Form_Add.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            try
                            {
                                if (Form_Add.refresh == "Bs")
                                {
                                    treeView_BSAccHead.Nodes.Clear();
                                    HelperClass.PopulateTreeView(treeView_BSAccHead, "A", "B");
                                }
                                else if (Form_Add.refresh == "IncSt")
                                {
                                    treeView_IncAccHead.Nodes.Clear();
                                    HelperClass.PopulateTreeView(treeView_IncAccHead, "A", "I");
                                }
                                else
                                {
                                    MessageBox.Show("Could not refresh the tree view");
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot Add a new Parent Head");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a Parent Head to add a new one under it!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in Account Parent Head Add button: "+ ex.Message);
            }
           
        }

        private void Button_Properties_Click_1(object sender, EventArgs e)
        {

        }

        private void Button_Print_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView_AccHead.SelectedRows.Count != 0)
            {
                MessageBox.Show("ID: " + dataGridView_AccHead.SelectedRows[0].Cells[0].Value.ToString() + ", Acc Head: " + dataGridView_AccHead.SelectedRows[0].Cells[1].Value.ToString());
            }
            else
            {

            }
        }

      

        private void treeView_BSAccHead_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            selected_type = "B";
            //MessageBox.Show(treeView_BSAccHead.SelectedNode.Text.ToString());            
            dataGridView_AccHead.Font = HelperClass.SetFont();
            
            string temp;
            string code;
            string title;

            temp = treeView_BSAccHead.SelectedNode.Text.ToString();
            code = temp.Substring(0, 15);
   
            title = temp.Substring(15, temp.Length-15);
            title = title.Trim(' ');
            labelAccHead.Text = "Account Heads of " + title;
            labelCode.Text = code;
            dt_AccHeadQuery = dcon.SelectQuery("EXEC AccountHeadGivenParentHead '"+ code +"';");
            dataGridView_AccHead.DataSource = dt_AccHeadQuery;
            dataGridView_AccHead.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;            
            selected_parent_code = code;

        }

        private int NoOfParents(string code)
        {
            int total = 0;
            //string lvl1 = code.Substring

            return total; 
        }

        private void Button_Modify_Click(object sender, EventArgs e)
        {
            string selected_text = "";
            if (treeView_BSAccHead.SelectedNode != null)
            {
                selected_text = treeView_BSAccHead.SelectedNode.Text;
                MessageBox.Show("Text:" + selected_text);
                dt_table = dcon.SelectQuery("SELECT * FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '"+selected_text.Substring(0,15)+"' AND PARENTHEAD_TYPE = 'A' AND PARENTHEAD_TYPEII = 'B';"  );
                Int64 id = Convert.ToInt64(dt_table.Rows[0][0].ToString()); //Primary key of the Parent Head
                string code = dt_table.Rows[0][2].ToString();
                string title = dt_table.Rows[0][3].ToString();
                string type2 = dt_table.Rows[0][4].ToString();
                List_Account_Parent_Head_Modify Form_Modify = new List_Account_Parent_Head_Modify(id, code, title,type2);
                DialogResult result = new DialogResult();
                result = Form_Modify.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if(Form_Modify.modified_type == "B")
                    {
                        treeView_BSAccHead.Nodes.Clear();
                        HelperClass.PopulateTreeView(treeView_BSAccHead, "A", "B");
                    }
                    else if(Form_Modify.modified_type == "I")
                    {
                        treeView_IncAccHead.Nodes.Clear();
                        HelperClass.PopulateTreeView(treeView_IncAccHead, "A", "I");
                    }
                }
                
            }
            else if(treeView_IncAccHead.SelectedNode != null)
            {
                //treeView_BSAccHead.SelectedNode.ForeColor = Color.White;
                //treeView_BSAccHead.SelectedNode.BackColor = col;
                selected_text = treeView_IncAccHead.SelectedNode.Text;
                MessageBox.Show("Text:" + selected_text);
                dt_table = dcon.SelectQuery("SELECT * FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '" + selected_text.Substring(0, 15) + "' AND PARENTHEAD_TYPE = 'A' AND PARENTHEAD_TYPEII = 'I';");
                Int64 id = Convert.ToInt64(dt_table.Rows[0][0].ToString());
                string code = dt_table.Rows[0][2].ToString();
                string title = dt_table.Rows[0][3].ToString();
                string type2 = dt_table.Rows[0][4].ToString();
                List_Account_Parent_Head_Modify Form_Modify = new List_Account_Parent_Head_Modify(id, code, title, type2);
                DialogResult result = new DialogResult();
                result = Form_Modify.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (Form_Modify.modified_type == "B")
                    {
                        treeView_BSAccHead.Nodes.Clear();
                        HelperClass.PopulateTreeView(treeView_BSAccHead, "A", "B");
                    }
                    else if (Form_Modify.modified_type == "I")
                    {
                        treeView_IncAccHead.Nodes.Clear();
                        HelperClass.PopulateTreeView(treeView_IncAccHead, "A", "I");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a Parent Head to modify it.");
            }
        }

        private void treeView_BSAccHead_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //if (treeView_BSAccHead.SelectedNode != null)
            //{
            //    treeView_BSAccHead.SelectedNode.ForeColor = Color.Black;
            //    treeView_BSAccHead.SelectedNode.BackColor = Color.White;

            //}
        }

        private void treeView_IncAccHead_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selected_type = "I";
            
            //MessageBox.Show(treeView_BSAccHead.SelectedNode.Text.ToString());
            FontFamily myFontFamily = new FontFamily("Cambria");
            string temp;
            string code;
            string title;

            temp = treeView_IncAccHead.SelectedNode.Text.ToString();
            code = temp.Substring(0, 15);

            title = temp.Substring(15, temp.Length - 15);
            title = title.Trim(' ');
            labelAccHead.Text = "Account Heads of " + title;
            labelCode.Text = code;
            dt_AccHeadQuery = dcon.SelectQuery("EXEC AccountHeadGivenParentHead '" + code + "';");
            dataGridView_AccHead.DataSource = dt_AccHeadQuery;
            dataGridView_AccHead.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_AccHead.Font = new Font(myFontFamily, 12, FontStyle.Regular);
            selected_parent_code = code;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (selected_parent_code == "")
            {
                MessageBox.Show("Select a Parent Head from the Tree View to see it's corresponding Account Heads");
            }
            else
            {
                if (comboBox_SearchByAccHead.SelectedIndex == 0)
                {
                    //Check to make sure only an integer is entered in case of an account code.
                    Int64 ParsedVal;
                    if (!Int64.TryParse(textBox1.Text, out ParsedVal))
                    {
                        MessageBox.Show("Invalid Account Code entered! Please add a valid number");

                    }
                    else
                    {
                        dt_table = dcon.SelectQuery("SELECT ACCHEAD_ID,ACCHEAD_NAME FROM ACCOUNT_HEADS INNER JOIN PARENT_HEADS ON PARENT_HEADS.PARENTHEAD_ID = ACCOUNT_HEADS.ACCPARENTHEAD_ID WHERE PARENTHEAD_CODE = '" + selected_parent_code + "'AND ACCOUNT_HEADS.ACCHEAD_ID = " + textBox1.Text + "; ");
                        dataGridView_AccHead.DataSource = dt_table;
                    }
                }
                else if (comboBox_SearchByAccHead.SelectedIndex == 1)
                {
                    dt_table = dcon.SelectQuery("SELECT ACCHEAD_ID,ACCHEAD_NAME FROM ACCOUNT_HEADS INNER JOIN PARENT_HEADS ON PARENT_HEADS.PARENTHEAD_ID = ACCOUNT_HEADS.ACCPARENTHEAD_ID WHERE PARENTHEAD_CODE = '" + selected_parent_code + "'AND ACCOUNT_HEADS.ACCHEAD_NAME LIKE '%" + textBox1.Text + "%';");
                    dataGridView_AccHead.DataSource = dt_table;
                }
                else if (comboBox_SearchByAccHead.SelectedIndex == 2)
                {
                    dt_table = dcon.SelectQuery("SELECT ACCHEAD_ID,ACCHEAD_NAME FROM ACCOUNT_HEADS INNER JOIN PARENT_HEADS ON PARENT_HEADS.PARENTHEAD_ID = ACCOUNT_HEADS.ACCPARENTHEAD_ID WHERE PARENTHEAD_CODE = '" + selected_parent_code + "'; ");
                    dataGridView_AccHead.DataSource = dt_table;
                }

            }
            
            
        }

        private void labelCode_Click(object sender, EventArgs e)
        {

        }

    }
}
