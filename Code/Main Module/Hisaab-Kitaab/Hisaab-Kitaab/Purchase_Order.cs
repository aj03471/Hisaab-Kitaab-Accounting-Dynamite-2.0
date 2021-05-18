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
namespace Hisaab_Kitaab
{
    public partial class Purchase_Order : Form
    {
        dataconnection dt_conn = new dataconnection();
        DataTable dt_table = new DataTable();
        public int doc_no;
        public Purchase_Order()
        {
            InitializeComponent();
            dt_table = dt_conn.SelectQuery("Select distinct Cast(max(ITHEADER_DOCNO) as int) from Inv_Trans_Header where ITHEADER_DOCTYPE = 8");
            doc_no = Convert.ToInt32(dt_table.Rows[0][0].ToString());
            //Convert.ToInt32(dtable.Rows[0][0].ToString());
            doc_no = doc_no + 1;
            //MessageBox.Show(Convert.ToInt32(dt_table.ToString()).ToString());
            label_Purchase_Order.ForeColor = ColorTranslator.FromHtml("#293574");


            

            dataGridView_Purchase_Order.Rows.Add("1" , "1", "Pencils", "50","Pieces", "10", "500");
            dataGridView_Purchase_Order.Rows.Add("2", "4", "Pens", "150", "Pieces", "10", "1500");

       

            HelperClass.StyleDGV(dataGridView_Purchase_Order);

            //Assigning default values
            dateTimePicker_Date.Text = "01-01-2021";
            dateTimePicker_Date.CalendarForeColor = HelperClass.darkBlue;
            textBox_PO_Number.Text = doc_no.ToString();
            textBox_Delivered_BY.Text = "Truck";
            textBox_Approved_By.Text = "Inara";
            textbox_Purchase_Ordered_By.Text = "Laiba";
            textBox_Total_Amount.Text = 2000.ToString();
            textBox_AmountWords.Text = "Two Thousand Rupees Only";
            textBox_TnC.Text = " “Purchase Order” means the purchase order between Buyer and Supplier for the purchase and sale of Goods and/or Services, to which these Standard Purchase Terms are attached or are incorporated by reference";
            //label_Amount_In_Words.Text = "Amount in words";
            //textBox_Terms_And_Conditions.Text = "Terms And Conditions \n I am Bakhtawar";
           

            textBox_Supplier.Text = "Ali Ahmed Co. \r\nBlock2, Gulistan-e-Johar, Karachi \r\n03015266915";
            textBox_Supplier.ContextMenu = new ContextMenu();
            textBox_Supplier.MouseDown += new MouseEventHandler(textBox_Supplier_MouseDown);

        }
        void textBox_Supplier_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Supplier_Details Supplier = new Supplier_Details();
                DialogResult result = Supplier.ShowDialog();
                if (result == DialogResult.OK)
                {
                   
                 }

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_Purchase_Bill_Approval_Click(object sender, EventArgs e)
        {

        }

        private void label_Supplier_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Purchase_Bill_Approval_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Purchase_Returns_Debit_Node PRDN = new Purchase_Returns_Debit_Node();
            PRDN.ShowDialog();
        }

        private void Purchase_Bill_Approval_Load(object sender, EventArgs e)
        {

        }

        private void label_Amount_In_Words_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            int x;
            dt_table = dt_conn.SelectQuery("Select distinct max (ITHEADER_ID) from Inv_Trans_Header");
            x = Convert.ToInt32(dt_table.Rows[0][0].ToString());
            x = x + 1;
            //database.InsertQuery("Insert into UsersLogs (LOG_ID, USER_ID, LOGIN_DATE, LOGIN_TIME, MODULE_TYPE) values (" + Program.thislogin_logid + "," + Program.userid + ",CAST( GETDATE() AS Date ), CAST( GETDATE() AS Time ), 'S')");
            dt_conn.InsertQuery("Insert into Inv_Trans_Header ([ITHEADER_ID],[ITHEADER_DOCNO],[ITHEADER_DOCTYPE]) values (" + x + "," + doc_no.ToString() + ",'8')");
            // inv trans header is complete now
            //Inventory trans body
            /*
            foreach (DataGridViewRow row in dataGridView_Purchase_Order.Rows)
            {
                int y;
                dt_table = dt_conn.SelectQuery("Select distinct Cast(max (ITBODY_ID)) from Inv_Trans_Body");
                y = Convert.ToInt32(dt_table.Rows[0][0].ToString());
                y = y + 1;
                float Quantity, Rate, Amount;
                string item, unit;
                int invHeadID;
                Quantity = float.Parse(row.Cells["Quantity"].Value.ToString());
                Rate = float.Parse(row.Cells["Rate"].Value.ToString());
                Amount = float.Parse(row.Cells["Amount"].Value.ToString());
                item = row.Cells["Item"].Value.ToString();
                unit = row.Cells["Unit"].Value.ToString();

                dt_table = dt_conn.SelectQuery("Select distinct INVHEAD_ID from Inventory_Heads where INVHEAD_Name =" + item.ToString() +" )");
                invHeadID = Convert.ToInt32(dt_table.Rows[0][0].ToString());
                dt_conn.InsertQuery("Insert into Inv_Trans_Body ([ITBODY_ID],[ITHEADER_ID],[USER_ID],[INVHEAD_ID],[ITBODY_DOCSNO],[ITBODY_DATE_TRANS],[ITBODY_DATE_SYSTEM],[ITBODY_TIME_SYSTEM],[ITBODY_QUANTITY],[ITBODY_QUANTITY_UNIT],[ITBODY_RATE],[ITBODY_AMOUNT]) values ("+y+","+x+","+Program.userid+","+invHeadID+","+doc_no.ToString()+",Cast("+dateTimePicker_Date.Text+" as Date),Cast(GetDate() as Date),Cast(GetDate() as Time),"+ Quantity+","+unit+","+Rate+","+Amount+")");
                //currQty += row.Cells["qty"].Value;
                //More code here
            }*/
            //dataGridView_Purchase_Bill_Approval

            MessageBox.Show("Purchase Order saved.");
        }

        private void label1_Purchase_Ordered_By_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Delivered_BY_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
