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
    public partial class List_Inventory_Parent_Head_Add : Form
    {
        dataconnection dcon = new dataconnection();
        DataTable dt = new DataTable();
        public string parent_code = "";
        public string parent_title = "";
        int x = 0;


        //Inara part
        Color col2 = System.Drawing.ColorTranslator.FromHtml("#f2f4ff");
        Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
      
        public string type1 = "I";
        public string type2 = "B";
        //public string refresh = ""; //Bs or IncSt
        MaskedTextBox textBox;
        int temp_lvl = -1;
        //--


        public List_Inventory_Parent_Head_Add(int lvl, string code)
        {
            InitializeComponent();
            /*
            dt = dcon.SelectQuery("SELECT TOP 1 * FROM PARENT_HEADS Order by PARENTHEAD_ID DESC");
            x = Convert.ToInt32(dt.Rows[0][0]);
            textBox_Parent_Head_Code.Text = dt.Rows[0][2].ToString();
            textBox_Parent_Head_Title.Text = dt.Rows[0][3].ToString();
            label_AccParentHead.ForeColor = ColorTranslator.FromHtml("#293574");
            button_Add.BackColor = ColorTranslator.FromHtml("#293574");
            button_Add.ForeColor = ColorTranslator.FromHtml("#ffffff");
            */
            //Inara's part
            temp_lvl = lvl;
            if (lvl == 2)
            {
                maskedTextBox_ParentCode_lvl1.SelectedItem = code.Substring(0, 3);
                maskedTextBox_ParentCode_lvl2.ReadOnly = false;
                maskedTextBox_ParentCode_lvl2.BackColor = Color.White;
                textBox = maskedTextBox_ParentCode_lvl2;
                maskedTextBox_ParentCode_lvl3.Text = code.Substring(6, 3);
                maskedTextBox_ParentCode_lvl4.Text = code.Substring(9, 3);
            }
            else if (lvl == 3)
            {
                maskedTextBox_ParentCode_lvl1.Text = code.Substring(0, 3);
                maskedTextBox_ParentCode_lvl2.Text = code.Substring(3, 3);
                maskedTextBox_ParentCode_lvl3.ReadOnly = false;
                maskedTextBox_ParentCode_lvl3.BackColor = Color.White;
                textBox = maskedTextBox_ParentCode_lvl3;
                maskedTextBox_ParentCode_lvl4.Text = code.Substring(9, 3);
            }
            else if (lvl == 4)
            {
                maskedTextBox_ParentCode_lvl1.Text = code.Substring(0, 3);
                maskedTextBox_ParentCode_lvl2.Text = code.Substring(3, 3);
                maskedTextBox_ParentCode_lvl3.Text = code.Substring(6, 3);
                maskedTextBox_ParentCode_lvl4.ReadOnly = false;
                maskedTextBox_ParentCode_lvl4.BackColor = col2;//Color.White;
                textBox = maskedTextBox_ParentCode_lvl4;
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
        private bool IsValidParentCode(string code)
        {
            bool ans = false;
            if (code.Length == 12)
            {
                string str_lvl_1 = code.Substring(0, 3);
                string str_lvl_2 = code.Substring(3, 3);
                string str_lvl_3 = code.Substring(6, 3);
                string str_lvl_4 = code.Substring(9, 3);


            }
            return ans;
        }
        //----

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void List_Inventory_Parent_Head_Add_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            /*
            x++;
            string a = "I";
            //database.InsertQuery("Insert into DBProperties (Db_ID,DB_NAME, DB_START,DB_END,DB_COMPANYNAME,DB_COMPLOGO_PATH,DB_DBSTORAGE_PATH,DB_CNICRECORD_PATH,DB_BACKUPDATA_PATH,DB_PHOTORECORD_PATH) Values (" + (x).ToString() + ",'" + textBox_DatabaseName.Text.ToString() + "','" + dateTimePicker_DatabaseStartDate.Value + "','" + dateTimePicker_DatabaseEndDate.Value + "','" + textBox_DatabaseStoragePath.Text.ToString() + "','" + textBox_CompanyName.Text.ToString() + "','" + textBox_CompanyLogoPath.Text.ToString() + "','" + textBox_CNICPath.Text.ToString() + "','" + textBox_BackupDataPath.Text.ToString() + "','" + textBox_PhotoRecordPath.Text.ToString() + "')");
            dcon.InsertQuery("Insert into PARENT_HEADS (PARENTHEAD_ID,PARENTHEAD_TYPE,PARENTHEAD_CODE,PARENTHEAD_TITLE,PARENTHEAD_TYPEII) VALUES (" + x.ToString() + ",'"+ a + "','" + textBox_Parent_Head_Code.Text.ToString() + "','" + textBox_Parent_Head_Title.Text.ToString() +"', 'B')");
            MessageBox.Show("Database has been updated");
            this.DialogResult = DialogResult.OK;
            */

            //Inara
            //maskedTextBox_ParentCode_lvl1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBox_ParentCode_lvl2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBox_ParentCode_lvl3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBox_ParentCode_lvl4.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            MessageBox.Show("My textBox: " + textBox.Text);
            int parsedVal;
            //MessageBox.Show(textBox.Text);
            if (int.TryParse(textBox.Text, out parsedVal) == false)
            {
                MessageBox.Show("Invalid code: Please enter a valid number");
            }
            else
            {
                int code_lvl = int.Parse(textBox.Text);
                string code_lvl_str = string.Format("{0:000}", code_lvl);
                MessageBox.Show("Val: " + code_lvl_str);
                textBox.Text = code_lvl_str;
                parent_code = maskedTextBox_ParentCode_lvl1.Text + "-" + maskedTextBox_ParentCode_lvl2.Text + "-" + maskedTextBox_ParentCode_lvl3.Text + "-" + maskedTextBox_ParentCode_lvl4.Text;
                MessageBox.Show(parent_code);
                if (String.IsNullOrWhiteSpace(textBox_Parent_Head_Title.Text) == true)
                {
                    MessageBox.Show("Please enter a valid Title");
                }
                else
                {
                    dt = dcon.SelectQuery("SELECT * FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '" + parent_code + "'AND PARENTHEAD_TYPE = '" + type1 + "'AND PARENTHEAD_TYPEII = '" + type2 + "';");
                    
                    if (dt.Rows.Count == 0)
                    {
                        try
                        {
                            Int64 Ph_ID;// The most recent Parent Head  ID 
                            dt = dcon.SelectQuery("SELECT TOP 1 PARENTHEAD_ID from PARENT_HEADS Order by PARENTHEAD_ID Desc");
                            Ph_ID = Convert.ToInt64(dt.Rows[0][0].ToString()) + 1;
                            parent_title = textBox_Parent_Head_Title.Text;

                            dcon.InsertQuery("INSERT INTO PARENT_HEADS values(" + Ph_ID + ", '" + type1 + "', '" + parent_code + "', '" + parent_title + "', '" + type2 + "');");
                            //"Insert into PARENT_HEADS (PARENTHEAD_ID,PARENTHEAD_TYPE,PARENTHEAD_CODE,PARENTHEAD_TITLE,PARENTHEAD_TYPEII) VALUES (" + x.ToString() + ",'" + a + "','" + textBox_Parent_Head_Code.Text.ToString() + "','" + textBox_Parent_Head_Title.Text.ToString() + "', 'B')"
                            MessageBox.Show("Parent Head has been added to the database");
                            this.DialogResult = DialogResult.OK;
                        }
                        catch (Exception excep)
                        {
                            MessageBox.Show(excep.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Parent Code Already Exists");
                    }

                    

                }

            }
        }

        private void label_AccParentHead_Click(object sender, EventArgs e)
        {

        }

        
    }
}
