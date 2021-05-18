using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace UserSecurity
{
    public partial class Log : Form
    {
        //string constr = "Data Source=LFK-HP;Initial Catalog=USALS-2;Integrated Security=True";
        DBConnection db = new DBConnection();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public static int selected_userid; //by deafult current user ka apna log dikhaey
        SqlConnection conn = new SqlConnection();
        public Log()
        {
            InitializeComponent();
            
            tabPage1.Name ="Login Log";
            tabPage1.Text = "Login Log";
            tabPage2.Name = "Activity Log";
            tabPage2.Text = "Activity Log";

            Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
            Color lightBlue = System.Drawing.ColorTranslator.FromHtml("#f2f4ff");
            menuStrip1.BackColor = col;
            usertoolStripMenuItem.ForeColor = Color.White;
            userLogintoolStripMenuItem.ForeColor = Color.White;
            databasesToolStripMenuItem.ForeColor = Color.White;
            label2.Text = Program.logindatetime.ToString();
            label2.ForeColor = col;
            label1.ForeColor = col;
            label1.Text = Program.globalString;


            //combox Select User jiska log chahye
            try
            {
                conn = new SqlConnection("Data Source=LFK-HP;Initial Catalog=USALS-2;Integrated Security=True");
                string query = "select USER_ID, USER_NAME from DBUsers";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    comboBox_SelectUser.Items.Add(drd["USER_ID"].ToString());
                    comboBox_SelectUser.ValueMember = drd["USER_ID"].ToString();
                    comboBox_SelectUser.DisplayMember = drd["USER_NAME"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }
            


                  


        }

       
        
        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void Log_Load(object sender, EventArgs e)
        {
            Color col = System.Drawing.ColorTranslator.FromHtml("#293574");

            Button_Search.ForeColor = Color.White;
            Button_Search.BackColor = col;
            menuStrip1.BackColor = col;
            usertoolStripMenuItem.ForeColor = Color.White;
            userLogintoolStripMenuItem.ForeColor = Color.White;
            databasesToolStripMenuItem.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = db.SelectQuery("Select * FROM UsersLogs;");
            dataGridView_Login.DataSource = dt;
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu1 menuu = new Menu1();
            menuu.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {



        }
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser Add = new AddUser();
            Add.Show();
        }
        private void listUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListUsers lstUsers = new ListUsers();
            lstUsers.Show();
            this.Hide();
        }
        private void databasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Databases datab = new Databases();
            datab.Show();
            this.Hide();
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log lg = new Log();
            lg.Show();
            this.Hide();

        }

        private void userActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Login_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            if (comboBox_SelectUser.SelectedItem != null)
            {
                selected_userid = Convert.ToInt32(comboBox_SelectUser.SelectedItem.ToString());
                MessageBox.Show("Searching logs for User: " + selected_userid.ToString());

                dt = db.SelectQuery("Select * FROM UsersLogs where USER_ID = '" + selected_userid.ToString() + "';");
                dt2 = db.SelectQuery("Select * FROM UsersLogActivities where LOG_ID in ( Select LOG_ID FROM UsersLogs where USER_ID = '" + selected_userid.ToString() + "');");

            }
            else
            {
                MessageBox.Show("Select a User to search their logs. Showing all logs as Default.");
                selected_userid = Program.userid;
                dt = db.SelectQuery("Select * FROM UsersLogs");
                dt2 = db.SelectQuery("Select * FROM UsersLogActivities");
            }


            //Login Log
            
            dataGridView_Login.DataSource = dt;
            FontFamily myFontFamily = new FontFamily("Cambria");
            dataGridView_Login.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Login.Columns[0].Frozen = true;
            dataGridView_Login.AutoSize = false;
            dataGridView_Login.ScrollBars = ScrollBars.Both;
            dataGridView_Login.Font = new Font(myFontFamily, 12, FontStyle.Regular);

            //User Activity Log
            
            dataGridView_Log.DataSource = dt2;
            dataGridView_Log.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Log.Columns[0].Frozen = true;
            dataGridView_Log.AutoSize = false;
            dataGridView_Log.ScrollBars = ScrollBars.Both;
            dataGridView_Log.Font = new Font(myFontFamily, 12, FontStyle.Regular);

        }

        private void usertoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
