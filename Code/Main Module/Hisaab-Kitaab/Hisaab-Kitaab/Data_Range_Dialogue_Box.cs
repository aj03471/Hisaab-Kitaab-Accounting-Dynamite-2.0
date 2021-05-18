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
    public partial class Data_Range_Dialogue_Box : Form
    {
        public static string consumption669 = "";
        public static string consumption667 = "";
        public static string consumption668 = "";
        public static class ControlID
        {
            public static string TextData { get; set; }
        }

        public Data_Range_Dialogue_Box()
        {
            InitializeComponent();
          //  choose1.Enabled = false;
          //  choose2.Enabled = false;
          //  button2.Enabled = false;
          //  button3.Enabled = false;
        }

        private void Button_Choose_Click(object sender, EventArgs e)
        {
            
            if (accountcode.Checked==true) {
              //  choose1.Enabled = true;


                Dialogue_Box_Account_Head IPP = new Dialogue_Box_Account_Head();
          

            if (IPP.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = consumption667;

            }

            }
        }

        private void Data_Range_Dialogue_Box_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (accountcode.Checked == true)

            {
               // choose2.Enabled = true;
                Dialogue_Box_Account_Head IPP = new Dialogue_Box_Account_Head();


                if (IPP.ShowDialog() == DialogResult.OK)
                {

                    textBox2.Text = consumption668;

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (parentcode.Checked == true)
            {
               // button3.Enabled = true;
                Dialogue_Box_Parent_Head IPP = new Dialogue_Box_Parent_Head();


                if (IPP.ShowDialog() == DialogResult.OK)
                {
                    ParentTitlePrintForm IP = new ParentTitlePrintForm();
                    textBox4.Text = IPP.selected_head1;
                    IP.parentstart.Text= IPP.selected_head1;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (parentcode.Checked == true)
            {
               // button2.Enabled = true;
                Dialogue_Box_Parent_Head IPP = new Dialogue_Box_Parent_Head();


                if (IPP.ShowDialog() == DialogResult.OK)
                {

                    textBox5.Text = IPP.selected_head2;

                }
            }
        }

        private void accountcode_CheckedChanged(object sender, EventArgs e)
        {
            if (accountcode.Checked == true)
            {
                panel1.Enabled = true;
                choose1.ForeColor = Color.White;
                choose1.BackColor = HelperClass.darkBlue;
                choose2.ForeColor = Color.White;
                choose2.BackColor = HelperClass.darkBlue;

            }
            else
            {
                panel1.Enabled = false;
                choose1.ForeColor = Color.Black;
                choose1.BackColor = Color.White;
                choose2.ForeColor = Color.Black;
                choose2.BackColor = Color.White;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            if (accountcode.Checked == true)
            { AccountCodePrintForm f = new AccountCodePrintForm();
                f.accountstart.Text = textBox1.Text;

                f.accountend.Text = textBox2.Text;

                f.ShowDialog();
            }

            else if (parentcode.Checked == true)
            {
                ParentTitlePrintForm f = new ParentTitlePrintForm();

                f.parentstart.Text = textBox4.Text;

                f.parentend.Text = textBox5.Text;
                //  ControlID.TextData = textBox4.Text;
                f.ShowDialog();


            }
        }

        private void parentcode_CheckedChanged(object sender, EventArgs e)
        {
            if(parentcode.Checked == true)
            {
                panel2.Enabled = true;
                button2.BackColor = HelperClass.darkBlue;
                button2.ForeColor = Color.White;
                button3.BackColor = HelperClass.darkBlue;
                button3.ForeColor = Color.White;
            }
            else
            {
                panel2.Enabled = false;
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;
            }
        }
    }
}
