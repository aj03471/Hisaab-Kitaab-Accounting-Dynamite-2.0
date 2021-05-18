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
    public partial class List_Account_Head_Add_Depriciation : Form
    {
        public List_Account_Head_Add_Depriciation(string accHeadID)
        {
            InitializeComponent();
            HelperClass.StyleDGV(dataGridView_DEPYEARLYRATE);
            dataGridView_DEPYEARLYRATE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView_DEPYEARLYRATE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                panel1.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
            }
        }

        private void panel1_EnabledChanged(object sender, EventArgs e)
        {
            if(panel1.Enabled == false)
            {
                button_DRYRemove.BackColor = Color.White;
                button_DYRAdd.BackColor = Color.White;
                button_DYRModify.BackColor = Color.White;

                button_DYRModify.FlatAppearance.BorderColor = Color.Black;
                button_DYRModify.FlatAppearance.BorderSize = 1;
                button_DYRAdd.FlatAppearance.BorderColor = Color.Black;
                button_DYRAdd.FlatAppearance.BorderSize = 1;
                button_DRYRemove.FlatAppearance.BorderColor = Color.Black;
                button_DRYRemove.FlatAppearance.BorderSize = 1;

            }
            else
            {
                button_DRYRemove.BackColor = HelperClass.darkBlue;
                button_DYRAdd.BackColor = HelperClass.darkBlue;
                button_DYRModify.BackColor = HelperClass.darkBlue;

                button_DRYRemove.ForeColor = Color.White;
                button_DYRAdd.ForeColor = Color.White;
                button_DYRModify.ForeColor = Color.White;



                button_DYRModify.FlatAppearance.BorderColor = Color.Black;
                button_DYRModify.FlatAppearance.BorderSize = 0;
                button_DYRAdd.FlatAppearance.BorderColor = Color.Black;
                button_DYRAdd.FlatAppearance.BorderSize = 0;
                button_DRYRemove.FlatAppearance.BorderColor = Color.Black;
                button_DRYRemove.FlatAppearance.BorderSize = 0;
            }
        }
    }
}
