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
    public partial class Add_Opening_Bal : Form
    {
        dataconnection DtConn = new dataconnection();
        DataTable DtTable = new DataTable();
        string accHeadID = "";
        string amount = "";

        public Add_Opening_Bal()
        {
            InitializeComponent();
           
        }

        private void labelAccHead_Click(object sender, EventArgs e)
        {

        }

        private void Add_Opening_Bal_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Choose_Account_Head form_chooseAH = new Choose_Account_Head();
            DialogResult result = form_chooseAH.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxAccCode.Text = form_chooseAH.choosenHeader[3];
                accHeadID = Convert.ToInt32(form_chooseAH.choosenHeader[3]).ToString();
                textBoxAccTitle.Text = form_chooseAH.choosenHeader[4];
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            if (radioButtonCredit.Checked == true)
            {
                amount = "- " + textBoxAmount.Text;
            }
            else
            {
                amount = textBoxAmount.Text;
            }
            DtTable = DtConn.SelectQuery("SELECT Max(ATHEADER_ID) AS 'ID' FROM ACC_TRANS_HEADER");
            string headerID = (Convert.ToInt32(DtTable.Rows[0][0].ToString()) + 1).ToString();

            DtTable = DtConn.SelectQuery("Select max(ATBODY_ID) AS 'ID' from ACC_TRANS_BODY");
            string bodyID = (Convert.ToInt32(DtTable.Rows[0][0].ToString()) + 1).ToString();

            string q1 = "Insert into ACC_TRANS_HEADER Values ("+headerID+",NULL,25, NULL,NULL,NULL,NULL,NULL,NULL);";
            string q2 = "Insert into ACC_TRANS_BODY VALUES(" + bodyID + "," + headerID + ", "+ HelperClass.userid +", "+accHeadID+", NULL, '"+dateTimePicker1.Text+ "', Cast (Getdate() as Date), Cast (Getdate() as time), " + amount+", NULL);";
            //MessageBox.Show("Query1: " + q1);
            //MessageBox.Show("Query2: " + q2);
            try
            {
                DtConn.InsertQuery(q1);
                DtConn.InsertQuery(q2);
                MessageBox.Show("Opening Balances Updated");
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                this.DialogResult = DialogResult.Cancel;
            }

        }
    }
}
