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


    public partial class Login : Form
    {

        DateTime var = new DateTime();
        dataconnection dt_conn = new dataconnection();
        DataTable dt_table = new DataTable();
        Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
        Color col2 = System.Drawing.ColorTranslator.FromHtml("#741300");

        public Login()
        {
            InitializeComponent();
            textBox_Password.UseSystemPasswordChar = true;
            textBoxDate.Text = "Date: " + DateTime.Now.Date.ToShortDateString().ToString();
            textBox1.Text = "Username: ";
            
        }

      


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            menuStrip1.BackColor = col;
            Button_Login.ForeColor = Color.White;
            Button_Login.BackColor = col;
            Label_Email.ForeColor = col2;
            Label_Login.ForeColor = col;
            Label_Password.ForeColor = col;
            Label_Username.ForeColor = col;
            label1.ForeColor = col;
            label2.ForeColor = col2;
            label3.ForeColor = col;
            label4.ForeColor = col;
            label5.ForeColor = col2;
            label6.ForeColor = col;
            Label_Warning.ForeColor = col2;
            HelperClass.SetAllFonts(this.Controls);





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Login_Click(object sender, EventArgs e)
        {

        }

        private void Button_Login_Click(object sender, EventArgs e)
        {

            dt_table = dt_conn.SelectQuery_Users("SELECT * FROM DBUsers where USER_NAME = '" + textBox_Username.Text.ToString() + "' AND USER_PASSWORD = '" + textBox_Password.Text.ToString() + "';");
            //dataGridView1.DataSource = dt_table;
            //MessageBox.Show("Wait");
            if (dt_table.Rows.Count == 1)
            {
                //DateTime currentDateTime = DateTime.Now;  //returns current date and time
                //DateTime todaysDate = DateTime.Today;
                dt_table = dt_conn.SelectQuery_Users("Select distinct max(LOG_ID) from UsersLogs");
                //MessageBox.Show("Wait "+dt_table.Rows.Count.ToString());
                if (dt_table.Rows[0][0].ToString() == "")
                {
                    dt_table = dt_conn.SelectQuery_Users("SELECT distinct USER_ID FROM DBUsers where USER_NAME = '" + textBox_Username.Text.ToString() + "';");
                    Program.userid = Convert.ToInt32(dt_table.Rows[0][0].ToString());


                    dt_conn.InsertQuery_Users("Insert into UsersLogs (LOG_ID, USER_ID, LOGIN_DATE, LOGIN_TIME, MODULE_TYPE) values (1," + Program.userid + ",CAST( GETDATE() AS Date ), CAST( GETDATE() AS Time ), 'A')");
                    Program.globalString = textBox_Username.Text.ToString();
                    Select_Database Form_SelDB = new Select_Database();
                    Form_SelDB.Show();
                    this.Hide();

                }
                else
                {
                    int x = Convert.ToInt32(dt_table.Rows[0][0].ToString());

                    Program.thislogin_logid = x + 1;

                    dt_table = dt_conn.SelectQuery_Users("SELECT distinct USER_ID FROM DBUsers where USER_NAME = '" + textBox_Username.Text.ToString() + "';");
                    Program.userid = Convert.ToInt32(dt_table.Rows[0][0].ToString());


                    dt_conn.InsertQuery_Users("Insert into UsersLogs (LOG_ID, USER_ID, LOGIN_DATE, LOGIN_TIME, MODULE_TYPE) values (" + Program.thislogin_logid + "," + Program.userid + ",CAST( GETDATE() AS Date ), CAST( GETDATE() AS Time ), 'A')");
                    Program.globalString = textBox_Username.Text.ToString();
                    //Menu1 MyMenu1 = new Menu1();
                    //MyMenu1.Show();
                    Select_Database Form_SelDB = new Select_Database();
                    Form_SelDB.Show();
                    this.Hide();
                    //MessageBox.Show(Program.thislogin_logid.ToString() + "   id:" + Program.userid.ToString());

                }

            }
            else
            {
                Label_Warning.Visible = true;
                textBox_Username.Text = null;
                textBox_Password.Text = null;

            }





        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //button_EyePass
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Password.UseSystemPasswordChar == true)
            {
                //textBox_Password.Font = new Font(textBox_Password.Font.FontFamily, 12);
                textBox_Password.UseSystemPasswordChar = false;
                button_EyePass.BackgroundImage = Properties.Resources.Password_Eye_open;
            }
            else if (textBox_Password.UseSystemPasswordChar == false)
            {
                //textBox_Password.Font = new Font(textBox_Password.Font.FontFamily, 12);
                textBox_Password.UseSystemPasswordChar = true;
                button_EyePass.BackgroundImage = Properties.Resources.Password_Eye_close;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Button_Login_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Hello");
            if ( e.KeyCode == Keys.Enter)
            {
               if (Button_Login.Focused == true)
                {
                    dt_table = dt_conn.SelectQuery_Users("SELECT * FROM DBUsers where USER_NAME = '" + textBox_Username.Text.ToString() + "' AND USER_PASSWORD = '" + textBox_Password.Text.ToString() + "';");
                    //dataGridView1.DataSource = dt_table;
                    //MessageBox.Show("Wait");
                    if (dt_table.Rows.Count == 1)
                    {
                        //DateTime currentDateTime = DateTime.Now;  //returns current date and time
                        //DateTime todaysDate = DateTime.Today;
                        dt_table = dt_conn.SelectQuery_Users("Select distinct max(LOG_ID) from UsersLogs");
                        //MessageBox.Show("Wait "+dt_table.Rows.Count.ToString());
                        if (dt_table.Rows[0][0].ToString() == "")
                        {
                            dt_table = dt_conn.SelectQuery_Users("SELECT distinct USER_ID FROM DBUsers where USER_NAME = '" + textBox_Username.Text.ToString() + "';");
                            Program.userid = Convert.ToInt32(dt_table.Rows[0][0].ToString());


                            dt_conn.InsertQuery_Users("Insert into UsersLogs (LOG_ID, USER_ID, LOGIN_DATE, LOGIN_TIME, MODULE_TYPE) values (1," + Program.userid + ",CAST( GETDATE() AS Date ), CAST( GETDATE() AS Time ), 'A')");
                            Program.globalString = textBox_Username.Text.ToString();
                            Select_Database Form_SelDB = new Select_Database();
                            Form_SelDB.Show();
                            this.Hide();

                        }
                        else
                        {
                            int x = Convert.ToInt32(dt_table.Rows[0][0].ToString());

                            Program.thislogin_logid = x + 1;

                            dt_table = dt_conn.SelectQuery_Users("SELECT distinct USER_ID FROM DBUsers where USER_NAME = '" + textBox_Username.Text.ToString() + "';");
                            Program.userid = Convert.ToInt32(dt_table.Rows[0][0].ToString());


                            dt_conn.InsertQuery_Users("Insert into UsersLogs (LOG_ID, USER_ID, LOGIN_DATE, LOGIN_TIME, MODULE_TYPE) values (" + Program.thislogin_logid + "," + Program.userid + ",CAST( GETDATE() AS Date ), CAST( GETDATE() AS Time ), 'A')");
                            Program.globalString = textBox_Username.Text.ToString();
                            //Menu1 MyMenu1 = new Menu1();
                            //MyMenu1.Show();
                            Select_Database Form_SelDB = new Select_Database();
                            Form_SelDB.Show();
                            this.Hide();
                            //MessageBox.Show(Program.thislogin_logid.ToString() + "   id:" + Program.userid.ToString());

                        }

                    }
                    else
                    {
                        Label_Warning.Visible = true;
                        textBox_Username.Text = null;
                        textBox_Password.Text = null;

                    }


                }



            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox_Username_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_Username.Focused == true)
                {
                    textBox_Password.Focus();
                }
            }

            
        }

        private void Login_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            
        }

        private void textBox_Password_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_Password.Focused == true)
                {
                    Button_Login.Focus();
                    
                }
            }


        }
    }


}
