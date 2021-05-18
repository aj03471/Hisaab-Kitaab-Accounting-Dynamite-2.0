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
    public partial class Receipt_Register : Form
    {
        public Receipt_Register()
        {
            InitializeComponent();
            dataGridViewOtherBooks.Rows.Add("06-01-2021", "2", "BDR-000001", "00000001", "INV#001095 upto 30 JUN 2021","6000");
            dataGridViewOtherBooks.Rows.Add("08-01-2021", "3", "BDR-000002", "00000002", "INV#001096 upto 30 JUN 2021", "3000");
            dataGridViewOtherBooks.Rows.Add("27-02-2021", "4", "BDR-000003", "00000009", "INV#001097 upto 30 JUN 2021", "9000");
            dataGridViewOtherBooks.Rows.Add("13-03-2021", "5", "BDR-000004", "00000001", "Money Transfered from Inara ACC", "50000");
            dataGridViewOtherBooks.Rows.Add("01-05-2021", "6", "BDR-000005", "000000018", "Remitances recieved", "100000");
            textBox_AccountTitle.Text = "Bank Al Habib Acc";
            textBox_AccCode.Text = "0000013";
            dataGridViewOtherBooks.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewOtherBooks.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewOtherBooks.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewOtherBooks.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}