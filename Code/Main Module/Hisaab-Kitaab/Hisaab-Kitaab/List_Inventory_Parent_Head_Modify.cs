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
    public partial class List_Inventory_Parent_Head_Modify : Form
    {
        dataconnection dcon = new dataconnection();
        DataTable dt = new DataTable();
        public string parent_code = "";
        public string parent_title = "";
        int x = 0;

        public List_Inventory_Parent_Head_Modify(string code,string title)
        {
           
           // string temp;
           // temp = treeView_BSInvHead.SelectedNode.Text.ToString();
            InitializeComponent();
            dt = dcon.SelectQuery("SELECT TOP 1 * FROM PARENT_HEADS Order by PARENTHEAD_ID DESC");
            x = Convert.ToInt32(dt.Rows[0][0]);
            textBox_Parent_Head_Code.Text = code;
            textBox_Parent_Head_Title.Text = title;
            button_Modify.BackColor = ColorTranslator.FromHtml("#293574");
            button_Modify.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        
        private void button_Modify_Click(object sender, EventArgs e)
        {

            dcon.InsertQuery("UPDATE PARENT_HEADS SET PARENTHEAD_CODE = '"+ textBox_Parent_Head_Code.Text.ToString() +"', PARENTHEAD_TITLE ='" + textBox_Parent_Head_Title.Text.ToString() + "' WHERE PARENTHEAD_CODE ='" + textBox_Parent_Head_Code.Text.ToString() + "'");
            MessageBox.Show("Database has been updated");
            this.DialogResult = DialogResult.OK;
            parent_code = textBox_Parent_Head_Code.Text;
            parent_title = textBox_Parent_Head_Title.Text;
        }
        private void textBox_Parent_Head_Code_TextChanged(object sender, EventArgs e)
        {
            dt = dcon.SelectQuery("SELECT PARENTHEAD_CODE,PARENTHEAD_TITLE FROM PARENT_HEADS where PARENTHEAD_CODE = " + textBox_Parent_Head_Code.Text);
           
            textBox_Parent_Head_Title.Text = dt.Rows[0][1].ToString();


        }
            private void List_Inventory_Parent_Head_Modify_Load(object sender, EventArgs e)
        {
        }

        
    }
}
