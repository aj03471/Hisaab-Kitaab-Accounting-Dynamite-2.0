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
    public partial class Choose_CLCA : Form
    {
        dataconnection DtConn = new dataconnection();
        DataTable DtTable = new DataTable();
        public List<String> AccountCodes = new List<string> { };
        public Choose_CLCA(string var)
        {
            InitializeComponent();
            
            if (var == "CA")
            {
                GetID("17");
            }
            else if (var == "CL")
            {
                GetID("38");
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            HelperClass.StyleDGV(dataGridView1);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //DtTable = DtConn.SelectQuery("Select ACCHEAD_ID, ACCHEAD_NAME From ACCOUNT_HEADS");
            //dataGridView1.DataSource = DtTable;

        }

        private void GetID(string id)
        {
            string code = "";
            string new_code = "";
            string q1 = "Select PARENTHEAD_CODE, PARENTHEAD_TITLE from PARENT_HEADS WHERE PARENTHEAD_ID = " + id;
            try
            {
                DtTable = DtConn.SelectQuery(q1);
                code = DtTable.Rows[0][0].ToString();
                new_code = code.Substring(0, 3) + "-999-999-999";
                //MessageBox.Show(new_code);

                string q2_l1 = "Select ACCHEAD_ID, ACCHEAD_NAME From ACCOUNT_HEADS AS AH";
                string q2_l2 = "INNER JOIN PARENT_HEADS AS PH ON AH.ACCPARENTHEAD_ID = PH.PARENTHEAD_ID";
                string q2_l3 = "WHERE PH.PARENTHEAD_CODE between '" + code + "' and '" + new_code + "';";
                string q2 = q2_l1 + " " + q2_l2 + " " + q2_l3;
                //MessageBox.Show(q2);
                DtTable = DtConn.SelectQuery(q2);
                //dataGridView1.Columns[1].DataPropertyName = "AH.ACCHEAD_ID";
                //dataGridView1.Columns[2].DataPropertyName = "AH.ACCHEAD_NAME";
                dataGridView1.DataSource = DtTable;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                this.DialogResult = DialogResult.Cancel;
            }           

        }



        private void checkBox_SelectAll_CheckStateChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Check state triggered");
            //if (checkBox_SelectAll.Checked == true)
            //{
                //checkBox_SelectAll.CheckState = CheckState.Unchecked;
             
            //}
        }

        private void checkBox_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Check triggered");
            if (checkBox_SelectAll.Checked == true)
            { 
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].SetValues(true);
                    //MessageBox.Show(dataGridView1.Rows[row.Index].ToString() + " - " +row.Index.ToString());
                }                
            }
            else if (checkBox_SelectAll.Checked == false)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].SetValues(false);
                }
                
            }
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //MessageBox.Show(row.Cells[0].Value.ToString());
                if(row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString().Trim() == "True")
                    {
                        //MessageBox.Show("Account code: " + row.Cells[1].Value.ToString().Trim());
                        AccountCodes.Add(row.Cells[1].Value.ToString().Trim());
                    }
                }
                
                //MessageBox.Show(dataGridView1.Rows[row.Index].ToString() + " - " +row.Index.ToString());
            }
            this.DialogResult = DialogResult.OK;

        }
    }
}
