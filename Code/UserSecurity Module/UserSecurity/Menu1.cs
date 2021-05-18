using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserSecurity
{
    public partial class Menu1 : Form
    { 
        public Menu1()
        {
            InitializeComponent();
            Color col = System.Drawing.ColorTranslator.FromHtml("#293574");

            menuStrip1.BackColor = col;
            usersToolStripMenuItem.ForeColor = Color.White;
            logToolStripMenuItem.ForeColor = Color.White;
            databasesToolStripMenuItem.ForeColor = Color.White;

            Label20.Text = Program.globalString;
            Label22.Text = Program.logindatetime.ToString();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListUsers lstUsers = new ListUsers();
            lstUsers.ShowDialog();
            
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log lg = new Log();
            lg.ShowDialog();
            

        }

        private void databasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Databases datab = new Databases();
            datab.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lgin = new Login();
            lgin.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddUser Add = new AddUser();
            //Add.Show();
        }
        
        private void Menu1_Load(object sender, EventArgs e)
        {
            Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
          //  menuStrip1.BackColor = col;
          
            Label_Loginuser.Text = Program.globalString;
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log lg = new Log();
            lg.ShowDialog();
            

        }

        private void userActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void pATHOFPHOTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser a = new AddUser();
            a.ShowDialog();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void defaultAutocodesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
