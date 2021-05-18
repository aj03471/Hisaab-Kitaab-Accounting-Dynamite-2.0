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
    public partial class ListUsers : Form
    {
        public DataTable dt = new DataTable();
        public DBConnection db = new DBConnection();
        public ListUsers()
        {
            InitializeComponent(); 
            
            Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
            Color lightBlue = System.Drawing.ColorTranslator.FromHtml("#f2f4ff");


            menuStrip1.BackColor = col;
            usersToolStripMenuItem.ForeColor = Color.White;
            logToolStripMenuItem.ForeColor = Color.White;
            databasesToolStripMenuItem.ForeColor = Color.White;
            label_Logintime.Text = Program.logindatetime.ToString();
            label_Logintime.ForeColor = col;
            label_Loginuser.ForeColor = col;
            label_Loginuser.Text = Program.globalString;


            button_Back.ForeColor = Color.White;
            button_Print.ForeColor = Color.White;
            RightsButton.ForeColor = Color.White;
            button_Back.BackColor = col;
            button_Print.BackColor = col;
            RightsButton.BackColor = col;

            dataGridView_Userrecord.ColumnHeadersDefaultCellStyle.BackColor = col;
            dataGridView_Userrecord.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            FontFamily myfam = new FontFamily("Tahoma");
            dataGridView_Userrecord.Font = new Font(myfam, 10, FontStyle.Regular);
            dataGridView_Userrecord.ColumnHeadersDefaultCellStyle.Font = new Font(myfam, 10, FontStyle.Bold);
            dataGridView_Userrecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Userrecord.AlternatingRowsDefaultCellStyle.BackColor = lightBlue;
            


        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            RightsButton.Enabled = false;
            dt = db.SelectQuery("Select [USER_ID] as [User ID],[USER_NAME] as [User Name],[USER_PASSWORD] as [User Password],[USER_PATH_PHOTO] as [User Photo Path], [USER_PATH_CNIC] as [User CNIC Path], [USER_POSITION] as [User Position],[USER_LOCATION] as [User Location],[USER_ACCOPENDATE] as [Account Opening Date], [USER_ACCOPENTIME] as [Account Opening Time] FROM DBUsers;");
            dataGridView_Userrecord.DataSource = dt;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            RightsButton.Enabled = true;
        }

        private void RightsButton_Click(object sender, EventArgs e)
        {
            Rights ryts = new Rights();
            ryts.Show();
            this.Hide();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log lg = new Log();
            lg.Show();
            this.Hide();
        }

        private void databasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Databases datab = new Databases();
            datab.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu1 menuu = new Menu1();
            menuu.Show();
            this.Close();
        }

        private void RightsButton_Click_1(object sender, EventArgs e)
        {
            Rights ryts = new Rights();
            ryts.ShowDialog();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

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
            printPreviewDialog1.Document = printDocument1;
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

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser Add = new AddUser();
            Add.Show();
            this.Hide();
        }

        private void listUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListUsers lstUsers = new ListUsers();
            lstUsers.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    
}
