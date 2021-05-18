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
    public partial class Rights : Form
    {
        public DataTable dt = new DataTable();
        public DBConnection db = new DBConnection();
        public Rights()
        {
            InitializeComponent();

            

            Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
            Color lightBlue = System.Drawing.ColorTranslator.FromHtml("#f2f4ff");

            button2.ForeColor = Color.White;
            button2.BackColor = col;
            button1.ForeColor = Color.White;
            button1.BackColor = col;

            menuStrip1.BackColor = col;
            usersToolStripMenuItem.ForeColor = Color.White;
            logToolStripMenuItem.ForeColor = Color.White;
            databasesToolStripMenuItem.ForeColor = Color.White;

            dt = db.SelectQuery("Select [Menu_ID] as [Menu ID] ,[Menu_Description] as [Menu Option]from DBMenu; ");
            //dataGridView1.DataSource = dt;

            StyleDGV(dataGridView1);
        }

        /*
       private void dataGridView1_DefaultValuesNeeded(object sender,
       System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Menu ID"].Value = "1";
            e.Row.Cells["Menu Option"].Value = "Charting";
            e.Row.Cells["Add"].Value = true;
            e.Row.Cells["Modify"].Value = true;
            e.Row.Cells["Remove"].Value = false;
            e.Row.Cells["Print"].Value = true;
        }*/
        private void button2_Click(object sender, EventArgs e)
        {
            Menu1 menuu = new Menu1();
            menuu.Show();
            this.Close();
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log lg = new Log();
            lg.Show();
            this.Hide();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rights_Load(object sender, EventArgs e)
        {

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

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser a = new AddUser();
            a.ShowDialog();
        }
    }
    
}
