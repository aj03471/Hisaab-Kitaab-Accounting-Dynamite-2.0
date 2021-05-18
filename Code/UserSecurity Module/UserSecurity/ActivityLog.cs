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
    public partial class ActivityLog : Form
    {
        public List<Activity> activities = new List<Activity>();
        DBConnection db = new DBConnection();
        DataTable dt = new DataTable();

        SqlConnection conn = new SqlConnection();

        public int selected_id;
      
public ActivityLog()
        {
            InitializeComponent();

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
                    comboBox_SelectUser.Items.Add(drd["USER_NAME"].ToString());
                    comboBox_SelectUser.ValueMember = drd["USER_ID"].ToString();
                    comboBox_SelectUser.DisplayMember = drd["USER_NAME"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }

            selected_id = Convert.ToInt32(comboBox_SelectUser.SelectedValue.ToString());
            dt = db.SelectQuery("Select * FROM UsersLogActivities where USER_ID =" + selected_id);
            dataGridView_Log.DataSource = dt;
            FontFamily myFontFamily = new FontFamily("Cambria");
            dataGridView_Log.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Log.Columns[0].Frozen = true;
            dataGridView_Log.AutoSize = false;
            dataGridView_Log.ScrollBars = ScrollBars.Both;
            dataGridView_Log.Font = new Font(myFontFamily, 12, FontStyle.Regular);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ActivityLog_Load(object sender, EventArgs e)
        {

        }
    }

    public class Activity
    {
        public int UserID;
        public int ActivityType;
        public string Description;
        public DateTime ActivityDate;
        public string ActivityTime;

        public Activity(int userID, int type)
        {
            UserID = 1;
            ActivityType = type;
            ActivityDate = DateTime.Now.Date;
            ActivityTime = DateTime.Now.ToString("t");

            if (type == 1)
            {
                Description = "Add User";
            }
            else if (type == 2)
            {
                Description = "List User";
            }
            else if (type == 2)
            {
                Description = "List User";
            }
        }
    }

}
