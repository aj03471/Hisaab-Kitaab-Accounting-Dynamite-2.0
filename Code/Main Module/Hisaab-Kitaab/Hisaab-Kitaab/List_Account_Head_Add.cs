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
    public partial class List_Account_Head_Add : Form
    {
        Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
        Color col2 = System.Drawing.ColorTranslator.FromHtml("#f2f4ff");
        public string choosen_AccParentHead = "";
        public string choosen_AccHeadTitle = "";

        dataconnection dt_conn = new dataconnection();
        DataTable dt_table = new DataTable();

        
        enum Attribute_Type
        {
            Depriciation,
            Attributes,
            Address,
            DepNAttr,
            Other,
            Unspecified

        }
        

        public List_Account_Head_Add()
        {
            InitializeComponent();


        }

        private void button_ParentHeadChoose_Click(object sender, EventArgs e)
        {
            Choose_Account_Parent_Head form_choose = new Choose_Account_Parent_Head();
            form_choose.ShowDialog();
            textBox_parentHead.Text = form_choose.selected_head;                

        }

        /*
        private Int64 Remove_hyphens(string code)
        {
            string int_code = "";
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] != '-')
                {
                    int_code = int_code + code[i];
                }
            }

            return Convert.ToInt64(int_code);

        }
        */

        private void button_Create_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_AccTitle.Text.ToString()) == false && String.IsNullOrWhiteSpace(textBox_parentHead.Text.ToString()) == false)
            {
                this.DialogResult = DialogResult.OK;
                string a_id;
                string p_id;
                //Acc id
                dt_table = dt_conn.SelectQuery("SELECT MAX(ACCHEAD_ID) FROM ACCOUNT_HEADS");
                a_id = dt_table.Rows[0][0].ToString();
                a_id = (Convert.ToInt32(a_id) + 1).ToString();

                //Parent id
                dt_table = dt_conn.SelectQuery("SELECT PARENTHEAD_ID FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '"+textBox_parentHead.Text.ToString().Substring(0,15)+"' AND PARENTHEAD_TYPE = 'A';");
                p_id = dt_table.Rows[0][0].ToString();              
                
                dt_conn.InsertQuery("INSERT INTO ACCOUNT_HEADS VALUES(" +a_id+ ", "+p_id+", '"+ textBox_AccTitle.Text.ToString() + "', 0, 0, 0, 0,0,0,0)");

            }
            else
            {
                MessageBox.Show("Inavlid title or code!");
            }
        }

        private int AccPropertyType(string my_code)
        {
            int type = -1;
            string code_str = my_code.Substring(0, 15);
            Int64 code = Convert.ToInt64(HelperClass.RemoveHyphens(code_str));
            switch (0)
            {
                // Land, Building and Property id 2,3,8,12
                case 0 when ((code >= 010001000000 && code <= 010002999999) || (code >= 010010003000 && code <= 010010003999)):
                    //MessageBox.Show(choosen_AccParentHead);
                    type = (int)Attribute_Type.Attributes;
                    return type;
                //TR & TP
                case 0 when ((code >= 020003000000 && code <= 020003999999) || (code >= 030002000000 && code <= 030002999999)):
                    MessageBox.Show(choosen_AccParentHead);
                    type = (int)Attribute_Type.Address;
                    return type;
                //ids 4 to 7
                case 0 when (code >= 010003000000 && code <= 010006999999):
                    MessageBox.Show(choosen_AccParentHead);
                    type = (int)Attribute_Type.Depriciation;
                    return type;
                //id 8 Motor Vehicles
                case 0 when (code >= 010007000000 && code <= 010007999999):
                    MessageBox.Show(choosen_AccParentHead);
                    type = (int)Attribute_Type.DepNAttr;
                    return type;
                case 0 when (code >= 999000000000 && code <= 999000000000):
                    MessageBox.Show(choosen_AccParentHead);
                    type = (int)Attribute_Type.Unspecified;
                    return type;
                default:
                    MessageBox.Show(choosen_AccParentHead);
                    type = (int)Attribute_Type.Other;
                    return type;
            }

        }

        /*
        private void button_Next_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_AccTitle.Text.ToString()) == false && String.IsNullOrWhiteSpace(textBox_parentHead.Text.ToString()) == false)
            {
                this.DialogResult = DialogResult.OK;
                choosen_AccHeadTitle = textBox_AccTitle.Text;
                choosen_AccParentHead = textBox_parentHead.Text;
                int type = -1;
                string code_str = choosen_AccParentHead.Substring(0, 15);
                Int64 code = Remove_hyphens(code_str);
                switch (0)
                {
                    //Motor Vehicles, Land, Building and Property id 2,3,8,12
                    case 0 when ((code >= 010001000000 && code <= 010002999999) || (code >= 010010003000 && code <= 010010003999)):
                        MessageBox.Show(choosen_AccParentHead);
                        type = (int)Attribute_Type.Attributes;
                        break;
                    //TR & TP
                    case 0 when ((code >= 020003000000 && code <= 020003999999) || (code >= 030002000000 && code <= 030002999999)):
                        MessageBox.Show(choosen_AccParentHead);
                        type = (int)Attribute_Type.Address;
                        break;
                    //ids 4 to 7
                    case 0 when (code >= 010003000000 && code <= 010006999999):
                        MessageBox.Show(choosen_AccParentHead);
                        type = (int)Attribute_Type.Depriciation;
                        break;
                    //id 8
                    case 0 when (code >= 010007000000 && code <= 010007999999):
                        MessageBox.Show(choosen_AccParentHead);
                        type = (int)Attribute_Type.DepNAttr;
                        break;
                    case 0 when (code >= 999000000000 && code <= 999000000000):
                        MessageBox.Show(choosen_AccParentHead);
                        type = (int)Attribute_Type.Unspecified;
                        break;
                    default:
                        MessageBox.Show(choosen_AccParentHead);
                        type = (int)Attribute_Type.Other;
                        break;
                }
                if (type == 4 || type == 5)
                {
                    //Add title without an details

                }
                else if (type >= 0 && type <= 3)
                {
                    List_Account_Head_Add_Attributes form_add_pt2 = new List_Account_Head_Add_Attributes(type, choosen_AccParentHead, choosen_AccHeadTitle);
                    form_add_pt2.ShowDialog();


                }
                else if (type == -1)
                {
                    MessageBox.Show("An Error occured while adding the Account Head");
                }

            }
            else if (String.IsNullOrWhiteSpace(textBox_AccTitle.Text.ToString()) == true)
            {
                MessageBox.Show("Please Enter a Valid Account Title", "Invalid Entry");
            }
        }
        */


    }
}
