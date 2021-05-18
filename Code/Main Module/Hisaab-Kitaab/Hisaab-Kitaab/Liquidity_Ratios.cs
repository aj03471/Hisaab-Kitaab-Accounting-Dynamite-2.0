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
    public partial class Liquidity_Ratios : Form
    {
        dataconnection DtConn = new dataconnection();
        DataTable DtTable = new DataTable();
        public Liquidity_Ratios()
        {
            InitializeComponent();
            label_LiqRatio.Text = "Liquidity & Solvency Ratios";
            this.Text = "Liquidity & Solvency Ratios";
            AvgCollPeriod();
        }
        private void AvgCollPeriod()
        {
            DtTable = DtConn.SelectQuery("SELECT Year, Value FROM DataAnalysis where Ratio = 'AP'");
            chart_AP.Series["Avg. Collection Period"].XValueMember = "Year";
            chart_AP.Series["Avg. Collection Period"].YValueMembers = "Value";
            chart_AP.DataSource = DtTable;
            chart_AP.DataBind();
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart_AP.Visible = true;
            textBox1.Visible = true;
        }
    }
}
