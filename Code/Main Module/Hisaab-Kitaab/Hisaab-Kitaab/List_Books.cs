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
    public partial class List_Books : Form
    {
        public List_Books()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           

          



        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument2;
            printDialog1.ShowDialog();
            


           
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            /*
            if (comboBox1.SelectedIndex == 0)

            {
                List_Books_Add_Single f = new List_Books_Add_Single();
                f.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                List_Books_Add_Double f = new List_Books_Add_Double();
                f.ShowDialog();

            }
            */

           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
