using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hisaab_Kitaab
{
    public partial class Select_Database : Form
    {
        Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
        Color col2 = System.Drawing.ColorTranslator.FromHtml("#E7E7F2");
        Color col3 = System.Drawing.ColorTranslator.FromHtml("#F2F2F9");
        Color col4 = HelperClass.lightBlue;//System.Drawing.ColorTranslator.FromHtml("#f2f4ff");
        dataconnection db_conn = new dataconnection();
        DataTable dt_table = new DataTable();
        bool db_exist = true;
        public Select_Database()
        {
            InitializeComponent();
            //FontFamily myFontFamily = new FontFamily("Cambria");
            //dataGridView_SelDB.Font = new Font(myFontFamily, 12, FontStyle.Regular);
            dt_table = db_conn.SelectQuery_Users("SELECT DB_ID AS 'Serial #', DB_NAME AS 'DATABASE NAME' FROM DBProperties");
            Program.db_name = dt_table.Rows[0][1].ToString();
            dataGridView_SelDB.DataSource = dt_table;

            dataGridView_SelDB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_SelDB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_SelDB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_SelDB.RowTemplate.Height = 40;
            textBox1.BackColor = col4;
            textBox3.BackColor = col4;
            textBox4.BackColor = col4;
            textBox6.BackColor = col4;
            textBox7.BackColor = col4;
            textBox8.BackColor = col4;
            textBox9.BackColor = col4;
            //textBox1.ForeColor = Color.Black;
            //HelperClass.SetAllFonts(this.Controls);
           // HelperClass.SetAllButtons(this.Controls);


        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (dataGridView_SelDB.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_SelDB.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_SelDB.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Serial #"].Value);
                dt_table = db_conn.SelectQuery_Users("SELECT * FROM DBProperties WHERE DB_ID = " + cellValue);
                if (dt_table.Rows.Count == 1)
                {
                    HelperClass.dbID = cellValue;
                    DateTime dtTo = Convert.ToDateTime(dt_table.Rows[0][3].ToString());
                    DateTime dtFrom = Convert.ToDateTime(dt_table.Rows[0][2].ToString());
                    //dt = DateTime.ParseExact(dt_table.Rows[0][3].ToString(), "dd-M-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    textBox1.Text = dtFrom.Date.ToString("dd-MMMM-yyyy");
                    textBox3.Text = dtTo.Date.ToString("dd-MMMM-yyyy");
                    textBox4.Text = dt_table.Rows[0][4].ToString();
                    textBox6.Text = dt_table.Rows[0][6].ToString();
                    Program.db_path = dt_table.Rows[0][6].ToString();
                    textBox7.Text = dt_table.Rows[0][7].ToString();
                    textBox8.Text = dt_table.Rows[0][8].ToString();
                    textBox9.Text = dt_table.Rows[0][9].ToString();
                    pictureBox5.ImageLocation = dt_table.Rows[0][5].ToString();
                    db_exist = true;

                }
                else
                {
                    MessageBox.Show("Error while loading data");
                    db_exist = false;
                }
            }


            //
            //splitContainer1.Panel1.BackColor = col3;           


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }   

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            if(db_exist == true)
            {
                Main_Menu form3 = new Main_Menu();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The database doesnot exist");
                this.Close();
            }
        }

        private void dataGridView_SelDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView_SelDB.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView_SelDB.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView_SelDB.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["Serial #"].Value);
                    dt_table = db_conn.SelectQuery_Users("SELECT * FROM DBProperties WHERE DB_ID = "+cellValue);
                    if (dt_table.Rows.Count == 1)
                    { 
                        textBox1.Text = dt_table.Rows[0][2].ToString();
                        textBox3.Text = dt_table.Rows[0][3].ToString();
                        textBox4.Text = dt_table.Rows[0][4].ToString();
                        textBox6.Text = dt_table.Rows[0][6].ToString();
                        Program.db_path = dt_table.Rows[0][6].ToString();
                        textBox7.Text = dt_table.Rows[0][7].ToString();
                        textBox8.Text = dt_table.Rows[0][8].ToString();
                        textBox9.Text = dt_table.Rows[0][9].ToString();
                        pictureBox5.ImageLocation = dt_table.Rows[0][5].ToString();
                        db_exist = true;

                    }
                    else
                    {
                        MessageBox.Show("Error while loading data");
                        db_exist = false;
                    }
                   
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            //dt_table = db_conn.SelectQuery_Users("SELECT * FROM DBProperties WHERE DB_ID = ");

        }
    }
}
