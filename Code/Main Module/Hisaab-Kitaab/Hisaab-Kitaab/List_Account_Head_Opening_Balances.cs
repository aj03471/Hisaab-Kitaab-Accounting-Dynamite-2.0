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
    public partial class List_Account_Head_Opening_Balances : Form
    {
        dataconnection DtConn = new dataconnection();
        DataTable DtTable = new DataTable();
        //DataTable DtTable2 = new DataTable();

        public List_Account_Head_Opening_Balances()
        {
            InitializeComponent();
            HelperClass.StyleDGV(dataGridView_OpeningBal);
            dataGridView_OpeningBal.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_OpeningBal.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_OpeningBal.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_OpeningBal.GridColor = HelperClass.darkBlue;
            
            UpdateDGV();


        }

        private void UpdateDGV()
        {
            string l1 = "SELECT RIGHT('0000000' + CONVERT(VARCHAR(7), b.ACCHEAD_ID), 7) AS 'Account Code',a.ACCHEAD_NAME As 'Account Title',  IIF(b.ATBODY_AMOUNT_TRANS > 0, b.ATBODY_AMOUNT_TRANS,NULL) As 'Debit', IIF(b.ATBODY_AMOUNT_TRANS < 0, ABS(b.ATBODY_AMOUNT_TRANS),NULL) As 'Credit' FROM ACC_TRANS_HEADER as h inner join ACC_TRANS_BODY as b on h.ATHEADER_ID = b.ATHEADER_ID";
            string l2 = " inner join ACCOUNT_HEADS as a on a.ACCHEAD_ID = b.ACCHEAD_ID WHERE h.ATHEADER_DOCTYPE = 25";

            DtTable = DtConn.SelectQuery(l1 + l2);
            dataGridView_OpeningBal.DataSource = DtTable;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Add_Opening_Bal form_Add = new Add_Opening_Bal();
            DialogResult result = form_Add.ShowDialog();
            if(result == DialogResult.OK)
            {
                UpdateDGV();
            }
        }
    }
}
