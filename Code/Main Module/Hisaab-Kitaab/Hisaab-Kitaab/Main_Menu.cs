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
    public partial class Main_Menu : Form
    {

        Color col = System.Drawing.ColorTranslator.FromHtml("#293574"); //blue-dark
        Color col2 = System.Drawing.ColorTranslator.FromHtml("#741300"); //magenta
        dataconnection dt_conn = new dataconnection();

        public Main_Menu()
        {
            InitializeComponent();
            HelperClass.SetAllFonts(this.Controls);
            Label_Email.ForeColor = col2;
            label1.ForeColor = col; 
            label2.ForeColor = col2; 
            label3.ForeColor = col; 
            label4.ForeColor = col; 
            label5.ForeColor = col2;
            label6.ForeColor = col;
            label7.ForeColor = col;
            Label_User.Text = "Welcome back, "+ Program.globalString;
            Label_User.ForeColor = col;
            //label8.ForeColor = col;
            //label8.Text = "Database Path: "+Program.db_path;
            if (Program.userid == 2)
            {
                listAccountParentHeadToolStripMenuItem.Enabled = false;
            }
            



        }

        private void productionConsumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productionConsumptionToolStripMenuItem.ForeColor = col;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            menuStrip1.BackColor = col;
            menuStrip1.ForeColor = Color.White;
            button_logout.BackColor = col;
            button_logout.ForeColor = Color.White;
            

            
        }

        private void chartingToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            chartingToolStripMenuItem.ForeColor = col;
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void chartingToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            chartingToolStripMenuItem.ForeColor = Color.White;
        }

        private void chartingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartingToolStripMenuItem.ForeColor = col;
        }

        private void generateAndPrintInvoiceWiseOutstandingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateAndPrintPaymentsAndPurchaseReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateAndPrintSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label_Username_Click(object sender, EventArgs e)
        {

        }

        private void listAccountHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Account_Head form_new = new List_Account_Head();
            form_new.ShowDialog();
        }

        private void listInventoryHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Inventory_Head form_new = new List_Inventory_Head();
            form_new.ShowDialog();
        }

        private void listBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Books form_new = new List_Books();
            form_new.ShowDialog();

        }

        private void listAccountParentHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Account_Parent_Head form_new = new List_Account_Parent_Head();
            form_new.ShowDialog();
        }

        private void listInventoryParentHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Inventory_Parent_Head form_new = new List_Inventory_Parent_Head();
            form_new.ShowDialog();
        }

        private void listAccountAttributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Account_Attributes form_new = new List_Account_Attributes();
            form_new.ShowDialog();
        }

        private void chartingToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            chartingToolStripMenuItem.ForeColor = col;
        }

        private void chartingToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            chartingToolStripMenuItem.ForeColor = Color.White;
        }

        private void chartingToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            chartingToolStripMenuItem.ForeColor = col;
        }


        private void defineNumberOfUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Define_Number_of_Units form_units = new Define_Number_of_Units();
            form_units.ShowDialog();

        }

        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {            
            dt_conn.InsertQuery_Users("UPDATE UsersLogs SET LOGOUT_DATE = CAST( GETDATE() AS Date ), LOGOUT_TIME = CAST( GETDATE() AS Time ) WHERE LOG_ID = " + Program.thislogin_logid.ToString() + " AND USER_ID = " + Program.userid.ToString());
            this.Close();


        }



        private void button_logout_Click(object sender, EventArgs e)
        {

            dt_conn.InsertQuery_Users("UPDATE UsersLogs SET LOGOUT_DATE = CAST( GETDATE() AS Date ), LOGOUT_TIME = CAST( GETDATE() AS Time ) WHERE LOG_ID = " + Program.thislogin_logid.ToString() + " AND USER_ID = " + Program.userid.ToString());
            Login form_login = new Login();
            form_login.Show();
            this.Close();

        }

        private void openingBalancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openingBalancesToolStripMenuItem.ForeColor = col;

        }

        private void openingBalancesToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            openingBalancesToolStripMenuItem.ForeColor = Color.White;
        }

        private void openingBalancesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            openingBalancesToolStripMenuItem.ForeColor = col;
        }

        private void openingBalancesToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            openingBalancesToolStripMenuItem.ForeColor = col;
        }

        private void accountingTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountingTransactionsToolStripMenuItem.ForeColor = col;
        }

        private void accountingTransactionsToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            accountingTransactionsToolStripMenuItem.ForeColor = Color.White;
        }

        private void accountingTransactionsToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accountingTransactionsToolStripMenuItem.ForeColor = col;
        }

        private void accountingTransactionsToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            accountingTransactionsToolStripMenuItem.ForeColor = col;
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchasesToolStripMenuItem.ForeColor = col;
        }

        private void purchasesToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            purchasesToolStripMenuItem.ForeColor =Color.White;
        }

        private void purchasesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            purchasesToolStripMenuItem.ForeColor = col;
        }

        private void purchasesToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            purchasesToolStripMenuItem.ForeColor = col;
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesToolStripMenuItem.ForeColor = col;
        }

        private void salesToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            salesToolStripMenuItem.ForeColor = Color.White;
        }

        private void salesToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            salesToolStripMenuItem.ForeColor = col;
        }

        private void productionConsumptionToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            productionConsumptionToolStripMenuItem.ForeColor = Color.White;
        }

        private void productionConsumptionToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            productionConsumptionToolStripMenuItem.ForeColor = col;
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportsToolStripMenuItem.ForeColor = col;
        }

        private void reportsToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            reportsToolStripMenuItem.ForeColor = Color.White;
        }

        private void reportsToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            reportsToolStripMenuItem.ForeColor = col;
        }

        private void allocationDistributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allocationDistributionToolStripMenuItem.ForeColor = col;
        }

        private void allocationDistributionToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            allocationDistributionToolStripMenuItem.ForeColor = Color.White;
        }

        private void allocationDistributionToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            allocationDistributionToolStripMenuItem.ForeColor = col;
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setupToolStripMenuItem.ForeColor = col;
        }

        private void setupToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            setupToolStripMenuItem.ForeColor = Color.White;
        }

        private void setupToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            setupToolStripMenuItem.ForeColor = col;
        }

        private void listInventoryAttributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Inventory_Attributes form_LIA = new List_Inventory_Attributes();
            form_LIA.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listPurchaseBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Bill_Approval form_PB = new Purchase_Bill_Approval();
            form_PB.ShowDialog();


        }

        private void listPurchaseReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Returns_Debit_Node form_PRDN = new Purchase_Returns_Debit_Node();
            form_PRDN.ShowDialog();

        }

        private void listSalesInquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Inquiry form_SE = new Sales_Inquiry();
            form_SE.ShowDialog();
        }

        private void listSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Order form_SO = new Sales_Order();
            form_SO.ShowDialog();

        }

        private void listDeliveryNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delivery_Note form_DN = new Delivery_Note();
            form_DN.ShowDialog();

        }

        private void listSalesInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cash_Sales_Invoice form_SI = new Cash_Sales_Invoice();
            form_SI.ShowDialog();
        }

        private void listCashMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listSalesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credit_Note_Sales_Return form_SRCN = new Credit_Note_Sales_Return();
            form_SRCN.ShowDialog();
        }

        private void listImportBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listPurchaseRequisitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Purchase_Requistion form_PR = new List_Purchase_Requistion();
            form_PR.ShowDialog();
        }

        private void listStoreIssueSlipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Store_Issue_Slips form_SIS = new List_Store_Issue_Slips();
            form_SIS.ShowDialog();

        }

        private void singleEntryBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doubleEntryBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paymentVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void receiptVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt_Register form_RR = new Receipt_Register();
            form_RR.ShowDialog();
        }

        private void listSalesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liquidity_Ratios form_LR = new Liquidity_Ratios();
            form_LR.ShowDialog();
        }

        private void listPurchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Order form_PO = new Purchase_Order();
            form_PO.ShowDialog();
        }

        private void listGoodsRecieptNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Good_Receipt_Note form_GRN = new Good_Receipt_Note();
            form_GRN.ShowDialog();

        }

        private void singleEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Single_Entry_Book form_SEB = new List_Single_Entry_Book();
            form_SEB.ShowDialog();
        }

        private void doubleEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Double_Entry_Book form_DEB = new Double_Entry_Book();
            form_DEB.ShowDialog();
        }



        private void listAccountHeadOpeningBalancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Account_Head_Opening_Balances form_LAHOB = new List_Account_Head_Opening_Balances();
            form_LAHOB.ShowDialog();
        }

        private void generateAndPrintLedgerOfAccountHeadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ledger_Accounts form_LA = new Ledger_Accounts();
            form_LA.ShowDialog();
        }
    }
}
