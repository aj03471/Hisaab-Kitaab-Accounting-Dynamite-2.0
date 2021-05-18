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
    public partial class Ledger_Accounts : Form
    {
        dataconnection DtConn = new dataconnection();
        DataTable DtTable = new DataTable();

        public Ledger_Accounts()
        {
            InitializeComponent();
            HelperClass.StyleDGV(dataGridView_AccHeads);
            DtTable = DtConn.SelectQuery("Select RIGHT('0000000' + CONVERT(VARCHAR(7), ACCHEAD_ID), 7) AS 'ACCHEAD_ID', ACCHEAD_NAME FROM ACCOUNT_HEADS");
            dataGridView_AccHeads.DataSource = DtTable;
        }

        private void dataGridView_AccHeads_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_AccHeads.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_AccHeads.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_AccHeads.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value); //Account Code uthaya
                int accHeadID = Convert.ToInt32(cellValue);
                //MessageBox.Show(accHeadID.ToString());

                //dt_table = dt_conn.SelectQuery("SELECT p.PARENTHEAD_CODE, a.ACCHEAD_ID FROM ACCOUNT_HEADS as a inner join PARENT_HEADS as p on a.ACCPARENTHEAD_ID = p.PARENTHEAD_ID WHERE ACCHEAD_ID = " + accHeadID.ToString());
                //type_chosen = AccPropertyType(dt_table.Rows[0][0].ToString());

                Ledger form_ledger = new Ledger(cellValue);
                DialogResult result = form_ledger.ShowDialog();
            }
        }
    }
}
