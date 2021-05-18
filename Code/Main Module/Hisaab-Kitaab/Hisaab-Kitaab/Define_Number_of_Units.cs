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
    public partial class Define_Number_of_Units : Form
    {
        Color col = System.Drawing.ColorTranslator.FromHtml("#293574");
        
        public Define_Number_of_Units()
        {
            InitializeComponent();
            button_Save.ForeColor = col;
            checkBox_StockUnits.Checked= true;
            this.Icon = new Icon("D:\\FYP\\Hisaab-Kitaab\\Hisaab-Kitaab\\Resources\\SDS1-removebg-preview.ico");

        }

        private void Define_Number_of_Units_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if(checkBox_StockUnits.Checked==true & checkBox_LooseUnits.Checked == true & checkBox_PackingUnits.Checked == true)
            {
                Program.inv_units = "SPL";
                this.Close();
            }
            else if(checkBox_StockUnits.Checked == true & checkBox_LooseUnits.Checked == true)
            {
                Program.inv_units = "SL";
                this.Close();
            }
            else if (checkBox_StockUnits.Checked == true & checkBox_PackingUnits.Checked == true)
            {
                Program.inv_units = "SP";
                this.Close();
            }
            else if (checkBox_PackingUnits.Checked == true & checkBox_LooseUnits.Checked == true)
            {
                Program.inv_units = "PL";
                this.Close();
            }
            else if (checkBox_StockUnits.Checked == true)
            {
                Program.inv_units = "S";
                this.Close();
            }
            else if (checkBox_LooseUnits.Checked == true)
            {
                Program.inv_units = "L";
                this.Close();
            }
            else if (checkBox_PackingUnits.Checked == true)
            {
                Program.inv_units = "P";
                this.Close();
            }
            else
            {
                MessageBox.Show("At least one box should be checked.");
            }
        }
    }
}
