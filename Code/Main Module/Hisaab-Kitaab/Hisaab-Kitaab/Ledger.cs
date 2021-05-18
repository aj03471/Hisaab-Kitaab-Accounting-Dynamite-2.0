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
    public partial class Ledger : Form
    {
        dataconnection DtConn = new dataconnection();
        DataTable DtTable = new DataTable();

        public Ledger(string accHeadID)
        {
            InitializeComponent();

        }
    }
}
