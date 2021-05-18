using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UserSecurity
{

    public partial class Login : Form
    {
        //private readonly object Database;
        DataTable Dtable = new DataTable();
        DBConnection Database = new DBConnection();
        
        // public valriable

         

        public Login()
        {
           
            InitializeComponent();

            TextBox_Password.UseSystemPasswordChar = true;

            //this.BackColor = Color.Blue;
            DateTime MyLogin = DateTime.Now;
            Program.logindatetime = MyLogin;
            Label22.Text = MyLogin.ToString();


            Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
            Label1.ForeColor = col;
            // label7.ForeColor = col;
            Label2.ForeColor = col;




            //        Label7.Visible = false;
            //         menuStrip1.BackColor = col;
            //       TextBox_Password.

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu1 MyMenu1 = new Menu1();
            MyMenu1.Show();
            this.Close();
            /*

            if (TextBox1.Text == "" && TextBox2.Text == "")
            {
                Label7.Visible = true;
            }
            else
            {
                Label7.Visible = false;
                var = DateTime.Now;
                //this.Hide();
                MyMenu1.Show();
                this.Close();
                //this.Hide();


            }*/
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void Button_Login_Click(object sender, EventArgs e)
        {
            Dtable = Database.SelectQuery("SELECT * FROM DBUsers where USER_NAME = '"+TextBox_Username.Text.ToString()+"' AND USER_PASSWORD = '"+TextBox_Password.Text.ToString()+"';");
            try
            {
                if (Dtable.Rows.Count == 1)
                {
                    /*DateTime currentDateTime = DateTime.Now;  //returns current date and time
                    DateTime todaysDate = DateTime.Today;*/
                    Dtable = Database.SelectQuery("Select distinct max(LOG_ID) from UsersLogs");
                    int x = Convert.ToInt32(Dtable.Rows[0][0].ToString());
                    Program.thislogin_logid = x + 1;

                    Dtable = Database.SelectQuery("SELECT distinct USER_ID FROM DBUsers where USER_NAME = '" + TextBox_Username.Text.ToString() + "';");
                    Program.userid = Convert.ToInt32(Dtable.Rows[0][0].ToString());


                    Database.InsertQuery("Insert into UsersLogs (LOG_ID, USER_ID, LOGIN_DATE, LOGIN_TIME, MODULE_TYPE) values (" + Program.thislogin_logid + "," + Program.userid + ",CAST( GETDATE() AS Date ), CAST( GETDATE() AS Time ), 'S')");
                    Program.globalString = TextBox_Username.Text.ToString();
                    Menu1 MyMenu1 = new Menu1();
                    MyMenu1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password! Please try again", "User Name or Password Invalid!");
                    TextBox_Username.Text = "";
                    TextBox_Password.Text = "";
                    
                    TextBox_Username.Focus();

                }
            }
            catch(Exception exception1)
            {
                MessageBox.Show(exception1.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox_Password.UseSystemPasswordChar == true)
            {
                TextBox_Password.Font = new Font(TextBox_Password.Font.FontFamily, 12);
                TextBox_Password.UseSystemPasswordChar = false;
                button1.BackgroundImage = Properties.Resources.Password_Eye_open;
            }
            else if (TextBox_Password.UseSystemPasswordChar == false)
            {
                TextBox_Password.Font = new Font(TextBox_Password.Font.FontFamily, 10);
                TextBox_Password.UseSystemPasswordChar = true;
                button1.BackgroundImage = Properties.Resources.Password_Eye_close;
            }
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }
        
       
        private void Label17_Click(object sender, EventArgs e)
         {

        }
      
        private void Label15_Click(object sender, EventArgs e)
        {

        }
    
        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void Label25_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
