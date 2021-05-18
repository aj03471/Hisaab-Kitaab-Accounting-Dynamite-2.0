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
    public partial class List_Account_Head : Form
    {
        dataconnection dt_conn = new dataconnection();
        DataTable dt_table = new DataTable();
        BindingSource bs = new BindingSource();
        Color col = System.Drawing.ColorTranslator.FromHtml("#293574");

        enum Attribute_Type
        {
            Depriciation,
            Attributes,
            Address,
            DepNAttr,
            Other,
            Unspecified

        }
        Attribute_Type type = Attribute_Type.Other;
        Attribute_Type type_chosen = Attribute_Type.Other;



        public List_Account_Head()
        {
            InitializeComponent();


            Update_AccHead();
            dataGridView_AccHead.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_AccHead.AllowUserToResizeColumns = true;
            dataGridView_AccHead.ReadOnly = true;
            this.dataGridView_AccHead.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView_AccHead.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            HelperClass.StyleDGV(this.dataGridView_AccHead);



        }
        private void Update_AccHead()
        {
            dt_table = dt_conn.SelectQuery("Execute RetrieveAccHeads;");
            dataGridView_AccHead.DataSource = dt_table;
        }

        private void Button_AccAdd_Click(object sender, EventArgs e)
        {
            List_Account_Head_Add add_head = new List_Account_Head_Add();
            if (add_head.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Okay");
            }
        }

        private void Button_AccAdd_Click_1(object sender, EventArgs e)
        {

        }

        //pass code with dash
        private Attribute_Type AccPropertyType(string my_code)
        {

            //string code_str = my_code.Substring(0, 15);
            Int64 code = Convert.ToInt64(HelperClass.RemoveHyphens(my_code));
            switch (0)
            {
                //Motor Vehicles, Land, Building and Property id 2,3,8,12
                case 0 when ((code >= 010001000000 && code <= 010002999999) || (code >= 010010003000 && code <= 010010003999)):
                    //MessageBox.Show(choosen_AccParentHead);
                    type = Attribute_Type.Attributes;
                    return type;
                //TR & TP
                case 0 when ((code >= 020003000000 && code <= 020003999999) || (code >= 030002000000 && code <= 030002999999)):
                    //MessageBox.Show(choosen_AccParentHead);
                    type = Attribute_Type.Address;
                    return type;
                //ids 4 to 7
                case 0 when (code >= 010003000000 && code <= 010006999999):
                    //MessageBox.Show(choosen_AccParentHead);
                    type = Attribute_Type.Depriciation;
                    return type;
                //id 8
                case 0 when (code >= 010007000000 && code <= 010007999999):
                    //MessageBox.Show(choosen_AccParentHead);
                    type = Attribute_Type.DepNAttr;
                    return type;
                case 0 when (code >= 999000000000 && code <= 999000000000):
                    //MessageBox.Show(choosen_AccParentHead);
                    type = Attribute_Type.Unspecified;
                    return type;
                default:
                    //MessageBox.Show(choosen_AccParentHead);
                    type = Attribute_Type.Other;
                    return type;
            }

        }

        private void Button_AccProperties_Click(object sender, EventArgs e)
        {
            if (dataGridView_AccHead.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_AccHead.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_AccHead.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value); //Account Code uthaya
                int accHeadID = Convert.ToInt32(cellValue);
                //MessageBox.Show(accHeadID.ToString());

                dt_table = dt_conn.SelectQuery("SELECT p.PARENTHEAD_CODE, a.ACCHEAD_ID FROM ACCOUNT_HEADS as a inner join PARENT_HEADS as p on a.ACCPARENTHEAD_ID = p.PARENTHEAD_ID WHERE ACCHEAD_ID = " + accHeadID.ToString());
                type_chosen = AccPropertyType(dt_table.Rows[0][0].ToString());

                if (type_chosen == Attribute_Type.Address)
                {
                    List_Account_Head_Add_Address form_Address = new List_Account_Head_Add_Address(Convert.ToInt32(dt_table.Rows[0][1].ToString()));

                    DialogResult result = form_Address.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Update_AccHead();
                    }
                }
                else if (type_chosen == Attribute_Type.Attributes)
                {

                    List_Account_Head_Add_Attributes form_Attributes = new List_Account_Head_Add_Attributes(dt_table.Rows[0][1].ToString());// Convert.ToInt32(AccPropertyType(dt_table.Rows[0][1].ToString())));
                    DialogResult result = form_Attributes.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Update_AccHead();
                    }

                }
                else if (type_chosen == Attribute_Type.DepNAttr)
                {
                    List_Account_Head_Add_Attr_Dep form_DepAttr = new List_Account_Head_Add_Attr_Dep(dt_table.Rows[0][1].ToString());
                    DialogResult result = form_DepAttr.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Update_AccHead();
                    }
                }
                else if (type_chosen == Attribute_Type.Depriciation)
                {
                    List_Account_Head_Add_Depriciation form_Dep = new List_Account_Head_Add_Depriciation(dt_table.Rows[0][1].ToString());
                    DialogResult result = form_Dep.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Update_AccHead();
                    }
                }
                else
                {
                    List_Account_Head_Add_Other form_Other = new List_Account_Head_Add_Other(dt_table.Rows[0][1].ToString());
                    DialogResult result = form_Other.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Update_AccHead();
                    }

                }
                /*
                List_Account_Head_Add_Address form_add = new List_Account_Head_Add_Address(accHeadID);
                DialogResult result = new DialogResult();
                result = form_add.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dataGridView_AccHead.Invalidate();
                }
                */
            }
            else
            {
                MessageBox.Show("Please Select the Account Head you want to view the properties of.");
            }
        }

        private void Button_AccPrint_Click(object sender, EventArgs e)
        {

        }

        private void Button_AccAdd_Click_2(object sender, EventArgs e)
        {
            List_Account_Head_Add add_Acc_head = new List_Account_Head_Add();
            DialogResult result = add_Acc_head.ShowDialog();

            //MessageBox.Show(type.ToString());
            if (result == DialogResult.OK)
            {
                MessageBox.Show("In progress");
                //dataGridView_AccHead.Invalidate();
                //textBox1.Text = choose.selected_head;
                // this.BindCheckBox();
                Update_AccHead();






            }

        }

        private void Button_AccProperties_Click_1(object sender, EventArgs e)
        {






        }

        private void Button_AccPrint_Click_1(object sender, EventArgs e)
        {
            Data_Range_Dialogue_Box form_DRDB = new Data_Range_Dialogue_Box();
            form_DRDB.ShowDialog();


            //AccountCodePrintForm form_ACPF = new AccountCodePrintForm();

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView_AccHead.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_AccHead.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_AccHead.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value); //Account Code uthaya
                //int accHeadID = Convert.ToInt32(cellValue);
                //MessageBox.Show(accHeadID.ToString());

                dt_table = dt_conn.SelectQuery("SELECT * FROM ACC_TRANS_BODY WHERE ACCHEAD_ID = " + cellValue);
                if (dt_table.Rows.Count > 0)
                {
                    MessageBox.Show("This Account cannot be deleted. It has {0} transactions related to it.", dt_table.Rows.Count.ToString());
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are You sure you want to delete this Account Head?", "Confirmation", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        dt_conn.InsertQuery("DELETE FROM ACCOUNT_HEADS WHERE  ACCHEAD_ID = " + cellValue);
                        Update_AccHead();
                    }
                    
                }
                //type_chosen = AccPropertyType(dt_table.Rows[0][0].ToString());

            }
        }
    }
}
