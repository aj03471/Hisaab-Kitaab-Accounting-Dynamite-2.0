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
    public partial class Databases : Form
    {

        public DataTable dt = new DataTable();
        public DBConnection db = new DBConnection();
        public Databases()
        {
            InitializeComponent();
            Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
            Color lightBlue = System.Drawing.ColorTranslator.FromHtml("#f2f4ff");


            menuStrip1.BackColor = col;
            usersToolStripMenuItem.ForeColor = Color.White;
            logToolStripMenuItem.ForeColor = Color.White;
            databasesToolStripMenuItem.ForeColor = Color.White;
            Label2.Text = Program.logindatetime.ToString();
            Label2.ForeColor = col;
            Label1.ForeColor = col;
            Label1.Text = Program.globalString;


            button_Back.ForeColor = Color.White;
            button_Back.BackColor = col;

            dt = db.SelectQuery("Select [DB_ID] as [Database ID] ,[DB_NAME] as [Database], [DB_START] as [Database Start],[DB_END] as [Database End],[DB_COMPANYNAME] as [Company Name],[DB_COMPLOGO_PATH] as [Company Logo] ,[DB_DBSTORAGE_PATH] as [Storage Path], [DB_CNICRECORD_PATH] as [CNIC Record],[DB_BACKUPDATA_PATH] as [Backup Path],[DB_PHOTORECORD_PATH] as [Photo Record] FROM [DBProperties]; ");
            dataGridView1.DataSource = dt;

            StyleDGV(dataGridView1);

        }




        private void databasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Databases datab = new Databases();
            datab.Show();
            this.Hide();
        }

        public static Color darkBlue = System.Drawing.ColorTranslator.FromHtml("#293574"); //rgb(41, 53, 116)
        public static Color lightBlue = System.Drawing.ColorTranslator.FromHtml("#f2f4ff"); //rgb(242, 244, 255)
        public static Color magenta = System.Drawing.ColorTranslator.FromHtml("#741300");  //rgb(116, 19, 0)   
        public static void StyleDGV(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = lightBlue;
            dgv.DefaultCellStyle.ForeColor = darkBlue;
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);

            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = darkBlue;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 45;


            dgv.AlternatingRowsDefaultCellStyle.BackColor = lightBlue;
            dgv.RowTemplate.Height = 40;
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.White;//darkBlue;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersWidth = 20;

            //dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


        }

        private void logToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Log lg = new Log();
            lg.ShowDialog();
            
        }

        private void listUsersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListUsers lstUsers = new ListUsers();
            lstUsers.ShowDialog();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu1 menuu = new Menu1();
            menuu.Show();
            this.Close();

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            au.ShowDialog();
        }

        private void Databases_Load(object sender, EventArgs e)
        {
            

        }
    }
}
