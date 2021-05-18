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
    public partial class List_Inventory_Head_Properties : Form
    {
        dataconnection dcon = new dataconnection();
        DataTable dt = new DataTable();
        public static string ChosenParentHead2 = "";
        public static string consumption1 = "";
        public static string consumption2 = "";

        public List_Inventory_Head_Properties()
        {
            InitializeComponent();
            label19.ForeColor = ColorTranslator.FromHtml("#293574");
            label_FILHAAAL.ForeColor = ColorTranslator.FromHtml("#293574");
            button1.BackColor = ColorTranslator.FromHtml("#293574");
            button1.ForeColor = ColorTranslator.FromHtml("#ffffff");
            label13.ForeColor = ColorTranslator.FromHtml("#293574");
            label14.ForeColor = ColorTranslator.FromHtml("#293574");
            label15.ForeColor = ColorTranslator.FromHtml("#293574");
            label9.ForeColor = ColorTranslator.FromHtml("#293574");
            label10.ForeColor = ColorTranslator.FromHtml("#293574");
            label11.ForeColor = ColorTranslator.FromHtml("#293574");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog ();
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Textbox_INVHEAD_ID.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void List_Inventory_Head_Properties_Load(object sender, EventArgs e)
        {
           



            //List_Account_Head_Properties myform = new List_Account_Head_Properties();
            // myform.textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            //myform.textBox1.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            // myform.textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            // dataconnection database = new dataconnection();
            // DataTable da = new DataTable();



            //da = db.SelectQuery("Select * FROM DEPRICIATION_CARD WHERE  ACCHEAD_ID  like '" + myform.textBox2.Text + "%'  ");

            //     int x = 0;
            // int y = 0;
            // dt = db.SelectQuery("Select * FROM DEPRECIATION_CARD ");
            // dataGridView2.DataSource = dt;
            //  x = Convert.ToInt32(dt.Rows[0][1]);
            //  y = Convert.ToInt32(dt.Rows[0][3]);

            //myform.textBox3.Text = da.Rows[0][0].ToString();

            // int index = e.RowIndex;
            //  DataGridViewRow selectedRow = Inventory_Head_Grid.Rows[index];

            //  List_Inventory_Head_Properties.ChosenParentHead2 = selectedRow.Cells[1].Value.ToString();
            //  List_Inventory_Head_Properties myform = new List_Inventory_Head_Properties();

            // List_Inventory_Head my = new List_Inventory_Head();

            // dt = dcon.SelectQuery("SELECT PH.PARENTHEAD_TITLE,IH.INVHEAD_ID,IH.INVHEAD_NAME, ISP.INV_SPECIFICATIONS, IA.BALANCE_LOOSE_UNIT,  IA.BALANCE_PACKING_UNIT, IA.BALANCE_STOCK_UNIT, IA.CONSUMPTION_DR_ACC,IA.COST_LOOSE_UNIT,IA.COST_PACKING_UNIT,IA.COST_STOCK_UNIT, IA.LOOSE_UNIT, IA.PACKING_UNIT,IA.PRODUCTION_DR_ACC,IA.PURCHASE_DR_ACC,IA.RATE_PER_LOOSE_UNIT,IA.RATE_PER_PACKING_UNIT, IA.RATE_PER_STOCK_UNIT,IA.RATE_PRICE_LOOSE_UNIT,IA.RATE_PRICE_PACKING_UNIT, IA.RATE_PRICE_STOCK_UNIT,IA.SALE_CR_ACC,IA.STOCK_UNIT FROM PARENT_HEADS AS PH INNER JOIN INVENTORY_HEADS AS IH on PH.PARENTHEAD_ID = IH.INVPARENTHEAD_ID INNER JOIN INVENTORY_SPECIFICATIONS AS ISP on IH.INVHEAD_ID = ISP.INVHEAD_ID INNER JOIN INVENTORY_ATTRIBUTES AS IA on IA.INVHEAD_ID = IH.INVHEAD_ID");

            //Textbox_SALE_CR_ACC.Text = my.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            //  Textbox_SALE_CR_ACC.Text
            // Textbox_PARENT_ID.Text = dt.Rows[0][0].ToString();
            //  Textbox_INVHEAD_ID.Text = dt.Rows[0][1].ToString();

            //  Textbox_STOCK_UNIT.Text = dt.Rows[0][22].ToString();
            //  Textbox_PACKING_UNIT.Text = dt.Rows[0][12].ToString();
            //  Textbox_LOOSE_UNIT.Text = dt.Rows[0][11].ToString();
            ///   Textbox_RATE_PER_LOOSE_UNIT.Text = dt.Rows[0][15].ToString();
            //  Textbox_RATE_PER_STOCK_UNIT.Text = dt.Rows[0][17].ToString();
            //  Textbox_RATE_PER_PACKING_UNIT.Text = dt.Rows[0][16].ToString();
            // Textbox_RATE_PRICE_LOOSE_UNIT.Text = dt.Rows[0][18].ToString();
            // richTextBox_INV_SPECIFICATION.Text = dt.Rows[0][3].ToString();
            // Textbox_RATE_PRICE_PACKING_UNIT.Text = dt.Rows[0][19].ToString();
            // Textbox_RATE_PRICE_STOCK_UNIT.Text = dt.Rows[0][20].ToString();
            // Textbox_BALANCE_STOCK_UNIT.Text = dt.Rows[0][6].ToString();
            // Textbox_BALANCE_LOOSE_UNIT.Text = dt.Rows[0][4].ToString();
            // Textbox_BALANCE_PACKING_UNIT.Text = dt.Rows[0][5].ToString();
            // Textbox_COST_LOOSE_UNIT.Text = dt.Rows[0][8].ToString();
            // Textbox_COST_STOCK_UNIT.Text = dt.Rows[0][10].ToString();
            // Textbox_COST_PACKING_UNIT.Text = dt.Rows[0][9].ToString();
            //  Textbox_SALE_CR_ACC.Text = dt.Rows[0][21].ToString();
            //  Textbox_PURCHASE_DR_ACC.Text = dt.Rows[0][14].ToString();
            // Textbox_CONSUMPTION_DR_ACC.Text = dt.Rows[0][7].ToString();
            // Textbox_PRODUCTION_DR_ACC.Text = dt.Rows[0][13].ToString();
            //   label_FILHAAAL.Text = dt.Rows[0][2].ToString();
        }

        private void Textbox_INVHEAD_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_INV_SPECIFICATION_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            Textbox_PARENT_ID.Enabled = true;
            Textbox_INVHEAD_ID.Enabled = true;
            Textbox_STOCK_UNIT.Enabled = true;
            Textbox_PACKING_UNIT.Enabled = true;
            Textbox_LOOSE_UNIT.Enabled = true;
            Textbox_RATE_PER_LOOSE_UNIT.Enabled = true;
            Textbox_RATE_PER_STOCK_UNIT.Enabled = true;
            Textbox_RATE_PER_PACKING_UNIT.Enabled = true;
            Textbox_RATE_PRICE_LOOSE_UNIT.Enabled = true;
            richTextBox_INV_SPECIFICATION.Enabled = true;
            Textbox_RATE_PRICE_PACKING_UNIT.Enabled = true;
            Textbox_RATE_PRICE_STOCK_UNIT.Enabled = true;
            Textbox_BALANCE_STOCK_UNIT.Enabled = true;
            Textbox_BALANCE_LOOSE_UNIT.Enabled = true;
            Textbox_BALANCE_PACKING_UNIT.Enabled = true;
            Textbox_COST_LOOSE_UNIT.Enabled = true;
            Textbox_COST_STOCK_UNIT.Enabled = true;
            Textbox_COST_PACKING_UNIT.Enabled = true;
            Textbox_SALE_CR_ACC.Enabled = true;
            Textbox_PURCHASE_DR_ACC.Enabled = true;
            Textbox_CONSUMPTION_DR_ACC.Enabled = true;
            Textbox_PRODUCTION_DR_ACC.Enabled = true;
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            dcon.InsertQuery("DELETE FROM  INVENTORY_ATTRIBUTES WHERE INVHEAD_ID = " + Textbox_INVHEAD_ID.Text + " ");

            //WHERE INVHEAD_ID = '" + Textbox_INVHEAD_ID.Text + "'
            // dcon.InsertQuery("delete from INVENTORY_SPECIFICATIONS WHERE INVHEAD_ID = '" + Int64.Parse(Textbox_INVHEAD_ID.Text.ToString()) + "' ");

            MessageBox.Show("Data has been deleted");
            
        }


        private void button_Modify_Click_1(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;

            button_OK.Visible = true;
            Textbox_PARENT_ID.Enabled = true;
            Textbox_INVHEAD_ID.Enabled = true;
            Textbox_STOCK_UNIT.Enabled = true;
            Textbox_PACKING_UNIT.Enabled = true;
            Textbox_LOOSE_UNIT.Enabled = true;
            Textbox_RATE_PER_LOOSE_UNIT.Enabled = true;
            Textbox_RATE_PER_STOCK_UNIT.Enabled = true;
            Textbox_RATE_PER_PACKING_UNIT.Enabled = true;
            Textbox_RATE_PRICE_LOOSE_UNIT.Enabled = true;
            richTextBox_INV_SPECIFICATION.Enabled = true;
            Textbox_RATE_PRICE_PACKING_UNIT.Enabled = true;
            Textbox_RATE_PRICE_STOCK_UNIT.Enabled = true;
            Textbox_BALANCE_STOCK_UNIT.Enabled = true;
            Textbox_BALANCE_LOOSE_UNIT.Enabled = true;
            Textbox_BALANCE_PACKING_UNIT.Enabled = true;
            Textbox_COST_LOOSE_UNIT.Enabled = true;
            Textbox_COST_STOCK_UNIT.Enabled = true;
            Textbox_COST_PACKING_UNIT.Enabled = true;
         //   Textbox_SALE_CR_ACC.Enabled = true;
          //  Textbox_PURCHASE_DR_ACC.Enabled = true;
          //  Textbox_CONSUMPTION_DR_ACC.Enabled = true;
          //  Textbox_PRODUCTION_DR_ACC.Enabled = true;
            
        }

        private void button_OK_Click(object sender, EventArgs e)
        {




            dcon.InsertQuery("UPDATE INVENTORY_ATTRIBUTES SET  INVHEAD_ID ='" + Textbox_INVHEAD_ID.Text.ToString() + "', STOCK_UNIT =" + Textbox_STOCK_UNIT.Text + "" +
                ", PACKING_UNIT =" + Textbox_PACKING_UNIT.Text + ", LOOSE_UNIT =" + Textbox_LOOSE_UNIT.Text + "" +
                ", RATE_PER_LOOSE_UNIT =" + Textbox_RATE_PER_LOOSE_UNIT.Text + ", RATE_PER_PACKING_UNIT =" + Textbox_RATE_PER_PACKING_UNIT.Text + "" +
                ", RATE_PER_STOCK_UNIT =" + Textbox_RATE_PER_STOCK_UNIT.Text + ", RATE_PRICE_LOOSE_UNIT=" + Textbox_RATE_PRICE_LOOSE_UNIT.Text + "" +
                ",  RATE_PRICE_PACKING_UNIT =" + Textbox_RATE_PRICE_PACKING_UNIT.Text + "" +
                ", RATE_PRICE_STOCK_UNIT =" + Textbox_RATE_PRICE_STOCK_UNIT.Text + ", BALANCE_STOCK_UNIT=" + Textbox_BALANCE_STOCK_UNIT.Text + "" +
                ", BALANCE_LOOSE_UNIT =" + Textbox_BALANCE_LOOSE_UNIT.Text + ", BALANCE_PACKING_UNIT =" + Textbox_BALANCE_PACKING_UNIT.Text + "" +
                ", COST_LOOSE_UNIT =" + Textbox_COST_LOOSE_UNIT.Text + ", COST_STOCK_UNIT =" + Textbox_COST_STOCK_UNIT.Text + "" +
                ", COST_PACKING_UNIT =" + Textbox_COST_PACKING_UNIT.Text + ", SALE_CR_ACC =" + Textbox_SALE_CR_ACC.Text + "" +
                ", PURCHASE_DR_ACC =" + Textbox_PURCHASE_DR_ACC.Text + ", CONSUMPTION_DR_ACC =" + Textbox_CONSUMPTION_DR_ACC.Text + "" +
                ", PRODUCTION_DR_ACC =" + Textbox_PRODUCTION_DR_ACC.Text + " WHERE INVHEAD_ID ='" + Textbox_INVHEAD_ID.Text.ToString() + "'");

            //   dcon.InsertQuery("UPDATE INVENTORY_SPECIFICATIONS SET  INV_SPECIFICATIONS =  '" + richTextBox_INV_SPECIFICATION.Text + "' WHERE INVHEAD_ID ='" + Textbox_INVHEAD_ID.Text + "'");

            // INV_SPECIFICATIONS = '" + richTextBox_INV_SPECIFICATION.Text + "',

         //   MessageBox.Show("d"+Textbox_INVHEAD_ID.Text+"d");
             MessageBox.Show("Database has been modified.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List_Inventory_Head_Properties_CChoose IP = new List_Inventory_Head_Properties_CChoose();

            if (IP.ShowDialog() == DialogResult.OK)
            {
                textBox20.Text = consumption2;
                Textbox_CONSUMPTION_DR_ACC.Text = consumption1;

            }

        


            // ..  IP.button_Modify.Visible = true;
            //  IP.button_Remove.Visible = true;



          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List_Inventory_Head_Properties_SChoose IP = new List_Inventory_Head_Properties_SChoose();

            if (IP.ShowDialog() == DialogResult.OK)
            {
                textBox22.Text = consumption2;
                Textbox_SALE_CR_ACC.Text = consumption1;

            }
            // IPHP.Textbox_SALE_CR_ACC.Text = List_Inventory_Head_Properties.chosenParentHead2;

            // ..  IP.button_Modify.Visible = true;
            //  IP.button_Remove.Visible = true;

            //MessageBox.Show(consumption1, consumption2);

            //OpenFileDialog open = new OpenFileDialog();
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    Textbox_CONSUMPTION_DR_ACC.Text = consumption1;
            //    textBox20.Text = consumption2;

            //}




           // IP.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List_Inventory_Head_Properties_PChoose IP = new List_Inventory_Head_Properties_PChoose();

            // IPHP.Textbox_SALE_CR_ACC.Text = List_Inventory_Head_Properties.chosenParentHead2;

            // ..  IP.button_Modify.Visible = true;
            //  IP.button_Remove.Visible = true;

            if (IP.ShowDialog() == DialogResult.OK)
            {
                textBox21.Text = consumption2;
                Textbox_PURCHASE_DR_ACC.Text = consumption1;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List_Inventory_Head_Properties_PrChoose IP = new List_Inventory_Head_Properties_PrChoose();

            // IPHP.Textbox_SALE_CR_ACC.Text = List_Inventory_Head_Properties.chosenParentHead2;

            // ..  IP.button_Modify.Visible = true;
            //  IP.button_Remove.Visible = true;

            if (IP.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = consumption2;
                Textbox_PRODUCTION_DR_ACC.Text = consumption1;

            }

           
        }

        private void Textbox_CONSUMPTION_DR_ACC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Textbox_SALE_CR_ACC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
