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
    public partial class Define_Department : Form
    {
        dataconnection DtConn = new dataconnection();
        DataTable DtTable = new DataTable();
        int save_flag = -1; //0 = edit, 1 = add 
        public Define_Department()
        {
            InitializeComponent();
            UpdateDGV();
            dataGridView_Dep.RowTemplate.Height = 40;
            dataGridView_Dep.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_Dep.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void UpdateDGV()
        {
            DtTable = DtConn.SelectQuery("Select DEP_ID as 'Dep ID', DEP_NAME as 'Dep Name' From DEPARTMENT_TABLE");
            dataGridView_Dep.DataSource = DtTable;
        }

        private void button_AddDep_Click(object sender, EventArgs e)
        {
            save_flag = 1;
            //dataGridView_Dep.AllowUserToAddRows = true;
            //dataGridView_Dep.AllowUserToDeleteRows = true;
            button_AddDep.Visible = false;
            button_AddDep.Enabled = false;
            button_EditDep.Visible = false;
            button_EditDep.Enabled = false;
            button_DeleteDep.Visible = false;
            button_DeleteDep.Enabled = false;
            button_CancelDep.Visible = true;
            button_CancelDep.Enabled = true;
            button_SaveDep.Visible = true;
            button_SaveDep.Enabled = true;
            textBox_DepName.Enabled = true;

            DtTable = DtConn.SelectQuery("Select top 1 DEP_ID From DEPARTMENT_TABLE ORDER BY DEP_ID DESC");
            int id = Convert.ToInt32(DtTable.Rows[0][0].ToString());
            int new_id = id + 1;
            textBox_DepID.Text = new_id.ToString();

            


        }

        private void button_SaveDep_Click(object sender, EventArgs e)
        {
            if (save_flag == 0)
            {
                //edit
            }
            else if (save_flag == 1)
            {
                //add
                try
                {
                    DtConn.InsertQuery("Insert into DEPARTMENT_TABLE VALUES (" + textBox_DepID.Text + ",'" + textBox_DepName.Text + "');");
                    UpdateDGV();
                }
                catch (Exception add_dep_ex)
                {
                    MessageBox.Show(add_dep_ex.Message);
                }
                
                
            }

            //update data grid view

            //dataGridView_Dep.AllowUserToAddRows = false;
            //dataGridView_Dep.AllowUserToDeleteRows = false;
            button_AddDep.Visible = true;
            button_AddDep.Enabled = true;
            button_EditDep.Visible = true;
            button_EditDep.Enabled = true;
            button_DeleteDep.Visible = true;
            button_DeleteDep.Enabled = true;
            button_CancelDep.Visible = false;
            button_CancelDep.Enabled = false;
            button_SaveDep.Visible = false;
            button_SaveDep.Enabled = false;
            textBox_DepName.Enabled = false;


        }

        private void button_CancelDep_Click(object sender, EventArgs e)
        {
            save_flag = -1;
            //hide: cancel, save - show: add, edit - clear: textboxes
            //dataGridView_Dep.AllowUserToAddRows = false;
            //dataGridView_Dep.AllowUserToDeleteRows = false;
            button_AddDep.Visible = true;
            button_AddDep.Enabled = true;
            button_EditDep.Visible = true;
            button_EditDep.Enabled = true;
            button_DeleteDep.Visible = true;
            button_DeleteDep.Enabled = true;
            button_CancelDep.Visible = false;
            button_CancelDep.Enabled = false;
            button_SaveDep.Visible = false;
            button_SaveDep.Enabled = false;
            textBox_DepName.Enabled = false;

        }

        private void button_EditDep_Click(object sender, EventArgs e)
        {
            save_flag = 0;
            //hide: add, edit - show: save, cancel - clear: textboxes
            button_AddDep.Visible = false;
            button_AddDep.Enabled = false;
            button_EditDep.Visible = false;
            button_EditDep.Enabled = false;
            button_DeleteDep.Visible = false;
            button_DeleteDep.Enabled = false;
            button_CancelDep.Visible = true;
            button_CancelDep.Enabled = true;
            button_SaveDep.Visible = true;
            button_SaveDep.Enabled = true;
            textBox_DepName.Enabled = true;

        }
    }
}
