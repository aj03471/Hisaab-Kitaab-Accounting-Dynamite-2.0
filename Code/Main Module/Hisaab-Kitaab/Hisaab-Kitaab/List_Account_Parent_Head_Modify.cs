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
    public partial class List_Account_Parent_Head_Modify : Form
    {
        Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
        Color col2 = System.Drawing.ColorTranslator.FromHtml("#f2f4ff");
        public string modified_type = "";
        string str_id = "";
        dataconnection dt_conn = new dataconnection();
        DataTable dt_table = new DataTable();
        
        public List_Account_Parent_Head_Modify(Int64 id, string code, string title, string type)
        {
            InitializeComponent();
            toolTip1.BackColor = col2;
            toolTip1.ForeColor = col;         
            
            comboBox1_ParentCode_lvl1.SelectedItem = code.Substring(0, 3);
            maskedTextBox_ParentCode_lvl2.Text = code.Substring(4, 3);
            maskedTextBox_ParentCode_lvl2.BackColor = col2;
            maskedTextBox_ParentCode_lvl3.Text = code.Substring(8, 3);
            maskedTextBox_ParentCode_lvl3.BackColor = col2;
            maskedTextBox_ParentCode_lvl4.Text = code.Substring(12, 3);
            maskedTextBox_ParentCode_lvl4.BackColor = col2;
          
            textBox_ParentTitle.Text = title.Trim();
            modified_type = type;
            str_id = id.ToString();
            if (type == "B") 
            {
                radioButton_Bs.Checked = true;
            }
            else if (type == "I")
            {
                radioButton_IncSt.Checked = true;
                radioButton_IncSt.Checked = true;
            }
        }

        private string AddHyphens(string code)
        {
            string new_code = "";
            for (int i = 0; i < code.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    new_code = new_code + "-" + code[i];

                }
                else
                {
                    new_code = new_code + code[i];
                }
            }
            return new_code;
        }

        private void radioButton_Bs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Bs.Checked == true)
            {
                modified_type = "B";
            }
            else
            {
                modified_type = "";
            }

        }

        private void radioButton_IncSt_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_IncSt.Checked == true)
            {
                modified_type = "I";
            }
            else
            {
                modified_type = "";
            }
        }
        
        //enter code without hyphens
        private bool IsValidCode(string code)
        {
            //Valid codes:
            //010-000-000-000
            //010-030-000-000 given that 010-000-000-000 exists
            //010-030-004-000 given that 010-030-000-000 exists
            //010-030-004-001 given that 010-030-004-000 exists

            string lvl1 = code.Substring(0, 3);
            string lvl2 = code.Substring(3, 3);
            string lvl3 = code.Substring(6, 3);
            string lvl4 = code.Substring(9, 3);
            string test_code = "";

            //010-000-000-000
            if (Convert.ToInt32(lvl1) != 0 && Convert.ToInt32(lvl2) == 0 && Convert.ToInt32(lvl3) == 0 && Convert.ToInt32(lvl3) == 0)
            {
                return true;
            }
            //010-040-000-000
            else if (Convert.ToInt32(lvl1) != 0 && Convert.ToInt32(lvl2) != 0 && Convert.ToInt32(lvl3) == 0 && Convert.ToInt32(lvl3) == 0)
            {
                test_code = lvl1 + "-000-000-000";
                dt_table = dt_conn.SelectQuery("SELECT * FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '" + test_code + "' AND PARENTHEAD_TYPE = 'A';");
                if (dt_table.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            //010-040-003-000
            else if (Convert.ToInt32(lvl1) != 0 && Convert.ToInt32(lvl2) != 0 && Convert.ToInt32(lvl3) != 0 && Convert.ToInt32(lvl3) == 0)
            {
                test_code = lvl1 + "-" + lvl2 + "-000-000";
                dt_table = dt_conn.SelectQuery("SELECT * FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '" + test_code + "' AND PARENTHEAD_TYPE = 'A';");
                if (dt_table.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else if (Convert.ToInt32(lvl1) != 0 && Convert.ToInt32(lvl2) != 0 && Convert.ToInt32(lvl3) != 0 && Convert.ToInt32(lvl3) != 0)
            {
                test_code = lvl1 + "-" + lvl2 + "-" + lvl3 + "-000";
                dt_table = dt_conn.SelectQuery("SELECT * FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '" + test_code + "' AND PARENTHEAD_TYPE = 'A';");
                if (dt_table.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;              
            }

        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            int ParsedVal;
            if ( !int.TryParse(maskedTextBox_ParentCode_lvl2.Text, out ParsedVal) || !int.TryParse(maskedTextBox_ParentCode_lvl3.Text, out ParsedVal) || !int.TryParse(maskedTextBox_ParentCode_lvl4.Text, out ParsedVal))
            {
                MessageBox.Show("Please Enter a Valid Parent Code");
            }
            else
            {
                maskedTextBox_ParentCode_lvl2.Text = String.Format("{0:000}",int.Parse(maskedTextBox_ParentCode_lvl2.Text));
                maskedTextBox_ParentCode_lvl3.Text = String.Format("{0:000}", int.Parse(maskedTextBox_ParentCode_lvl3.Text));
                maskedTextBox_ParentCode_lvl4.Text = String.Format("{0:000}", int.Parse(maskedTextBox_ParentCode_lvl4.Text));
                string new_code = comboBox1_ParentCode_lvl1.SelectedItem.ToString() + maskedTextBox_ParentCode_lvl2.Text + maskedTextBox_ParentCode_lvl3.Text + maskedTextBox_ParentCode_lvl4.Text;
                //MessageBox.Show("New code: " + new_code);
                if (IsValidCode(new_code) == true)
                {
                    if (string.IsNullOrWhiteSpace(textBox_ParentTitle.Text) == false)
                    {
                        if (radioButton_Bs.Checked == false && radioButton_IncSt.Checked == false)
                        {
                            MessageBox.Show("Please choose a category");
                        }
                        else
                        {
                            new_code = AddHyphens(new_code);
                            dt_table = dt_conn.SelectQuery("SELECT * FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '" + new_code + "' AND PARENTHEAD_TYPE = 'A'");
                            //MessageBox.Show(dt_table.Rows.Count.ToString());
                            try
                            {
                                MessageBox.Show(dt_table.Rows[0][0].ToString() + " " + str_id);
                                if (dt_table.Rows.Count == 1 && dt_table.Rows[0][0].ToString() == str_id)
                                {
                                    //update
                                    //string new_code = AddHyphens(maskedTextBox_ParentCode.Text);
                                    
                                    dt_conn.InsertQuery("UPDATE PARENT_HEADS SET PARENTHEAD_CODE = '" + new_code + "', PARENTHEAD_TITLE = '" + textBox_ParentTitle.Text.Trim() + "', PARENTHEAD_TYPEII = '" + modified_type + "' WHERE PARENTHEAD_ID = " + str_id + ";");
                                    this.DialogResult = DialogResult.OK;
                                    MessageBox.Show("Database has been updated");
                                }
                                else
                                {
                                    MessageBox.Show("You are trying to replace the code of an already existing Parent Code!");
                                }

                            }
                            catch (Exception idk)
                            {
                                MessageBox.Show(idk.Message);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid title");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Parent code! Please change the code");
                }
            }
            //maskedTextBox_ParentCode.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //if (String.IsNullOrWhiteSpace(maskedTextBox_ParentCode.Text) == false & String.IsNullOrWhiteSpace(textBox_ParentTitle.Text) == false)
            //{
            //    if (maskedTextBox_ParentCode.Text.Length == 12)
            //    {
            //        //Update query
            //        string new_code = AddHyphens(maskedTextBox_ParentCode.Text);
            //        dt_conn.InsertQuery("UPDATE PARENT_HEADS SET PARENTHEAD_CODE = '"+new_code+"', PARENTHEAD_TITLE = '"+textBox_ParentTitle.Text.Trim()+"', PARENTHEAD_TYPEII = '"+modified_type+"' WHERE PARENTHEAD_ID = "+str_id+";");
            //        this.DialogResult = DialogResult.OK;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid length of Parent code");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter a valid Parent Code or Title!");
            //}
        }

        private void List_Account_Parent_Head_Modify_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_ParentCode_lvl2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Double Click to edit the code", maskedTextBox_ParentCode_lvl2);
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
        private void maskedTextBox_ParentCode_lvl2_LostFocus(object sender, EventArgs e)
        {
            maskedTextBox_ParentCode_lvl2.ReadOnly = true;
            maskedTextBox_ParentCode_lvl2.BackColor = col2;
           
        }

        private void List_Account_Parent_Head_Modify_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        //Lvl2
        private void maskedTextBox_ParentCode_lvl2_Click(object sender, EventArgs e)
        {
            maskedTextBox_ParentCode_lvl2.ReadOnly = false;
            maskedTextBox_ParentCode_lvl2.BackColor = Color.White;
        }
        private void maskedTextBox_ParentCode_lvl2_Leave(object sender, EventArgs e)
        {
            maskedTextBox_ParentCode_lvl2.ReadOnly = true;
            maskedTextBox_ParentCode_lvl2.BackColor = col2;            
        }

        //Lvl3
        private void maskedTextBox_ParentCode_lvl3_Click(object sender, EventArgs e)
        {
            maskedTextBox_ParentCode_lvl3.ReadOnly = false;
            maskedTextBox_ParentCode_lvl3.BackColor = Color.White;
        }
        private void maskedTextBox_ParentCode_lvl3_Leave(object sender, EventArgs e)
        {
            maskedTextBox_ParentCode_lvl3.ReadOnly = true;
            maskedTextBox_ParentCode_lvl3.BackColor = col2;
        }

        //Lvl4
        private void maskedTextBox_ParentCode_lvl4_Click(object sender, EventArgs e)
        {
            maskedTextBox_ParentCode_lvl4.ReadOnly = false;
            maskedTextBox_ParentCode_lvl4.BackColor = Color.White;
        }
        private void maskedTextBox_ParentCode_lvl4_Leave(object sender, EventArgs e)
        {
            maskedTextBox_ParentCode_lvl4.ReadOnly = true;
            maskedTextBox_ParentCode_lvl4.BackColor = col2;
        }



    }
}
