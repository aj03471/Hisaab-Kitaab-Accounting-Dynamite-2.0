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
    public partial class List_Account_Attributes : Form
    {
        public static string chosenParentHead = "";
        dataconnection dt_conn = new dataconnection();
        DataTable dt_table = new DataTable();

        /*
        Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
        Color col2 = System.Drawing.ColorTranslator.FromHtml("#cfe8ff");
        */
        public List_Account_Attributes()
        {
            InitializeComponent();
            HelperClass.StyleDGV(dataGridView_AccAddress);
            HelperClass.StyleDGV(dataGridView_AccAttributes);
            HelperClass.StyleDGV(dataGridView_AccDepAttr);
            HelperClass.StyleDGV(dataGridView_AccDepriciation);
            HelperClass.StyleDGV(dataGridView_DepYearlyRate);

            UpdateDGV();

            /*
            //textBox1.Text = chosenParentHead;
            Button_Choose.ForeColor = col;
            Button_Choose.FlatAppearance.BorderColor = col;

            label1.ForeColor = col;
            label2.ForeColor = col;

            textBox1.BackColor = col2;
            FontFamily myFontFamily = new FontFamily("Cambria");
            dataGridView_AccAttributes.Font = new Font(myFontFamily, 12, FontStyle.Regular);
            dataGridView_AccAttributes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            */



        }      

        private void UpdateDGV()
        {
            dt_table = dt_conn.SelectQuery("SELECT ACC_ADDR_ID , RIGHT('0000000' + CONVERT(VARCHAR(7), ACCHEAD_ID), 7) AS 'ACCHEAD_ID', CONCAT(TRIM(ADDRESS_LINE1),' ',TRIM(ADDRESS_LINE2),' ',TRIM(ADDRESS_LINE3)) AS 'ADDRESS',CITY,COUNTRY,CONCAT(TRIM(PHONE1),' - ',TRIM(PHONE2)) AS 'CONTACT', EMAIL,CR_LIMIT_AMOUNT,CR_LIMIT_DAYS,PIC_PATH FROM ADDRESS_CARD");
            dataGridView_AccAddress.DataSource = dt_table;

            dt_table = dt_conn.SelectQuery("SELECT DEPCARD_ID, RIGHT('0000000' + CONVERT(VARCHAR(7), ACCHEAD_ID), 7) AS 'ACCHEAD_ID', DEP_PURCHASEDATE,CONCAT(DEP_RATE,' %') AS 'DEP_RATE', CASE WHEN DEP_METHOD = 'S' THEN 'Single Line Method' WHEN DEP_METHOD = 'M' THEN 'Reducing Balance Method' ELSE ' ' END AS 'DEP_METHOD',DEP_LIFE,ACCATTRIBUTE_DEP_SALVAGE,DEP_YEARLYRATE,DEP_PIC_PATH FROM DEPRICIATION_CARD");
            dataGridView_AccDepriciation.DataSource = dt_table;

            dt_table = dt_conn.SelectQuery("SELECT * FROM DEPRICIATION_YEARLYRATES WHERE DEPCARD_ID = 1");
        }

        private void List_Account_Attributes_Load(object sender, EventArgs e)
        {
            
        }

        /*
        private Int64 Remove_hyphens(string code)
        {
            string int_code="";
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

        private void Button_Choose_Click(object sender, EventArgs e)
        {
            /*
            Choose_Account_Parent_Head choose = new Choose_Account_Parent_Head();
            DialogResult result = new DialogResult();
            result = choose.ShowDialog();
            MessageBox.Show(result.ToString());
            if (result == DialogResult.OK)
            {
                textBox1.Text = choose.selected_head;
                string code_str = choose.selected_head.Substring(0, 15);
                Int64 code = Remove_hyphens(code_str);
                switch (0)
                {
                    //Motor Vehicles, Land, Building and Property id 2,3,8,12
                    case 0 when ((code >= 010001000000 && code <= 010002999999) || (code >= 010010003000 && code <= 010010003999)):
                        MessageBox.Show(choose.selected_head);
                        dt_table = dt_conn.SelectQuery("Execute AccAtt '"+code_str+"';");
                        dataGridView_AccAttributes.DataSource = dt_table;
                        break;
                    //TR & TP
                    case 0 when ((code >= 020003000000 && code <= 020003999999) || (code >= 030002000000 && code <= 030002999999)):
                        MessageBox.Show(choose.selected_head);
                        dt_table = dt_conn.SelectQuery("Execute AddCard '" + code_str + "';");
                        dataGridView_AccAttributes.DataSource = dt_table;
                        break;
                    //ids 4 to 7
                    case 0 when (code >= 010003000000 && code <= 010006999999):
                        MessageBox.Show(choose.selected_head);
                        dt_table = dt_conn.SelectQuery("Execute DepCard_DepYearly '" + code_str + "';");
                        dataGridView_AccAttributes.DataSource = dt_table;
                        break;
                    //id 8
                    case 0 when (code >= 010007000000 && code <= 010007999999):
                        MessageBox.Show(choose.selected_head);
                        dt_table = dt_conn.SelectQuery("Execute AccAtt_DepCar_DepYearly '" + code_str + "';");
                        dataGridView_AccAttributes.DataSource = dt_table;
                        break;
                    default:
                        MessageBox.Show(choose.selected_head + " has no attributes!","Error");
                        break;
                }                

                //dataGridView_AccAttributes.DataSource
            }
            else if (result == DialogResult.Cancel)
            {
                textBox1.Text = choose.selected_head;
            }
            */
        }

        private void dataGridView_AccDepriciation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("selected");
            /*
            if (dataGridView_AccHead.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_AccHead.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_AccHead.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value); //Account Code uthaya
                int accHeadID = Convert.ToInt32(cellValue);
                //MessageBox.Show(accHeadID.ToString());

                dt_table = dt_conn.SelectQuery("SELECT p.PARENTHEAD_CODE, a.ACCHEAD_ID FROM ACCOUNT_HEADS as a inner join PARENT_HEADS as p on a.ACCPARENTHEAD_ID = p.PARENTHEAD_ID WHERE ACCHEAD_ID = " + accHeadID.ToString());
                type_chosen = AccPropertyType(dt_table.Rows[0][0].ToString());

                
                
            }
            else
            {
                MessageBox.Show("Please Select the Account Head you want to view the properties of.");
            }
            */
        }

        private void dataGridView_AccDepriciation_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Selection change");
            
        }

        private void dataGridView_AccDepriciation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_AccDepriciation.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_AccDepriciation.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_AccDepriciation.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value); //Dep Table ki key uthai
                MessageBox.Show(cellValue);

                if(String.IsNullOrEmpty(cellValue) == false)
                {
                    dt_table = dt_conn.SelectQuery("SELECT DEPCARD_RATE_ID,DEPCARD_ID,YEARNO,CONCAT(YEARRATE,' %') AS 'YEARRATE' FROM DEPRICIATION_YEARLYRATES WHERE DEPCARD_ID = " + cellValue);
                    dataGridView_DepYearlyRate.DataSource = dt_table;
                }
                else
                {
                    dt_table = dt_conn.SelectQuery("SELECT DEPCARD_RATE_ID,DEPCARD_ID,YEARNO,CONCAT(YEARRATE,' %') AS 'YEARRATE' FROM DEPRICIATION_YEARLYRATES WHERE DEPCARD_ID = 0 ");
                    dataGridView_DepYearlyRate.DataSource = dt_table;
                }
                //int accHeadID = Convert.ToInt32(cellValue);
                //MessageBox.Show(accHeadID.ToString());


            }
            
        }
    }
}
