using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hisaab_Kitaab
{
    public partial class ParentTitlePrintForm : Form
    {
        public string heads1 = "";
        public string heads2 = "";
        dataconnection dtConn = new dataconnection();
        DataTable dtTable = new DataTable();
        public ParentTitlePrintForm()
        {
            InitializeComponent();

            Dialogue_Box_Parent_Head IPP = new Dialogue_Box_Parent_Head();


            //  if (IPP.ShowDialog() == DialogResult.OK)
            //  {

            //    parentstart.Text = IPP.selected_head1;

            //   parentend.Text = IPP.selected_head2;

            //  }

            //Data_Range_Dialogue_Box f = new Data_Range_Dialogue_Box();

            //  Data_Range_Dialogue_Box f = new Data_Range_Dialogue_Box();
            //  Dialogue_Box_Parent_Head fa = new Dialogue_Box_Parent_Head();


            // string text = Data_Range_Dialogue_Box.ControlID.TextData;

            //  parentstart.Text=text;
            // parentend.Text = fa.selected_head2;



        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        public void createtable()
        {

            DataTable custTable = new DataTable("Customers");
            DataColumn[] dtColumn = { new DataColumn("ID"), new DataColumn("Value") };
            //      DataRow myDataRow;
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //  //Query Print
            string line0 = "Select a.ACCHEAD_NAME,p.PARENTHEAD_CODE,p.PARENTHEAD_TITLE,RIGHT ('0000000' + CONVERT(VARCHAR(7),a.ACCHEAD_ID),7) as ACCHEAD_ID from dbo.PARENT_HEADS AS p inner join dbo.ACCOUNT_HEADS as a on a.ACCPARENTHEAD_ID = p.PARENTHEAD_ID where p.PARENTHEAD_CODE BETWEEN '" + parentstart.Text + "' and '" + parentend.Text + "'";
            //  string line1 = "SELECT PARENT_HEADS.PARENTHEAD_ID, PARENT_HEADS.PARENTHEAD_CODE AS 'Parent Code', PARENT_HEADS.PARENTHEAD_TITLE AS 'Parent Title',";
            //  string line2 = "RIGHT ('0000000' + CONVERT(VARCHAR(7), INVENTORY_HEADS.INVHEAD_ID), 7) AS 'Inventory Code', INVHEAD_NAME AS 'Inventory Title' FROM INVENTORY_HEADS	";
            //  string line3 = "INNER JOIN PARENT_HEADS ON INVENTORY_HEADS.INVPARENTHEAD_ID = PARENT_HEADS.PARENTHEAD_ID";
            string query = line0;


            dtTable = dtConn.SelectQuery(query);



            // using MySqlDataReader rdr = cmd.ExecuteReader();

            // while (rdr.Read())
            //  {


            //  }

            int count6 = 50;
            for (int i = 0; i < dtTable.Rows.Count; i++)




            {

                // string tt = dtTable.Rows[i][j].ToString();

                e.Graphics.DrawString(dtTable.Rows[i][0].ToString(), new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(650, 180 + count6));
              

                e.Graphics.DrawString(dtTable.Rows[i][1].ToString(), new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(60, 180 + count6));
              


                e.Graphics.DrawString(dtTable.Rows[i][2].ToString(), new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(200, 180 + count6));
               


                e.Graphics.DrawString(dtTable.Rows[i][3].ToString(), new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(470, 180 + count6));
                count6 = count6 + 20;

            }



            //Dialogue_Box_Account_Head frm1 = new Dialogue_Box_Account_Head();
            //int count3 = 50;

            //for (int i = 0; i < frm1.dataGridViewAccountHead3.Rows.Count; i++)
            //{

            //    string tt = Convert.ToString(frm1.dataGridViewAccountHead3.Rows[i].Cells["Account Code"].Value);
            //    e.Graphics.DrawString(tt, new Font("Cambria", 10, FontStyle.Regular), Brushes.Black, new Point(470, 180 + count3));



            //    string m = Convert.ToString(frm1.dataGridViewAccountHead3.Rows[i].Cells["Account Title"].Value);
            //    e.Graphics.DrawString(m, new Font("Cambria", 6, FontStyle.Regular), Brushes.Black, new Point(650, 180 + count3));
            //    count3 = count3 + 20;


            //}






            //Image Upload
            if(String.IsNullOrEmpty(image3.ImageLocation) == false)
            {
                e.Graphics.DrawImage(image3.Image, (e.PageBounds.Width - image3.Width) / 9, 25, 50, 50);
            }








            // sngCenterPage = Convert.ToSingle(e.PageBounds.Width / 2 - e.Graphics.MeasureString("Your String Here").Width / 2)
            string n = companyname.Text;
            int t = ((e.PageBounds.Width / 2) - (n.Length / 2)) / 2;
            int w = 30;
            //Center = Convert.ToSingle(e.PageBounds.Width / 2 - e.Graphics.MeasureString("Valley boulevard Auto Center", HeadingFont).Width / 2)
            e.Graphics.DrawString(companyname.Text, new Font("Cambria", 20, FontStyle.Bold), Brushes.Black, new Point(t, w));
            //  Trial Balance From30 / 06 / 2008 Upto 30 / 06 / 2008
            //  AS AT 30TH JUNE 2008


            //Trial Balance From 30/06/2008 Upto 30/06/2008 Cont'd...Page/3


            Pen blackPen = new Pen(Color.Black, 1);
            int pageCount = 1;

            DateTime today = DateTime.Today;
            string pageHeader = "Page " + pageCount;

            int r = pageCount + 1;
            heads1 = parentstart.Text;
            heads2 = parentend.Text;
            string footer = "Account Head From " + heads1 + " Upto " + heads2 + " Cont'd...Page/" + r;
            e.Graphics.DrawString(footer, new Font("Cambria", 9, FontStyle.Regular), Brushes.Black, new Point(350, 1020));

            string tow = "Account Head From " + heads1 + " Upto " + heads2;
            e.Graphics.DrawString(tow, new Font("Cambria", 12, FontStyle.Bold), Brushes.Black, new Point(t, 60));


            e.Graphics.DrawString(pageHeader, new Font("Cambria", 12, FontStyle.Bold), Brushes.Black, new Point(750, 120));
            int today1 = DateTime.Today.Day;
            DateTime now = DateTime.Now;

            int month = DateTime.Today.Month;

            int year = DateTime.Today.Year;

            string pageprintedon = "Printed on " + now.ToString("MMMM") + " " + today1.ToString() + "," + " " + year.ToString() + " " + "At" + " " + DateTime.Now.ToString("hh:mm:ss");


            e.Graphics.DrawString(pageprintedon, new Font("Cambria", 12, FontStyle.Bold), Brushes.Black, new Point(50, 120));
            // Create coordinates of points that define line.
            int x1 = 50;
            int y1 = 140;
            int x2 = 800;
            int y2 = 140;

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);



            int x3 = 50;
            int y3 = 180;
            int x4 = 800;
            int y4 = 180;


            e.Graphics.DrawLine(blackPen, x3, y3, x4, y4);

            int x5 = 50;
            int y5 = 1000;
            int x6 = 50;
            int y6 = 140;


            e.Graphics.DrawLine(blackPen, x5, y5, x6, y6);

            int x7 = 610;
            int y7 = 1000;
            int x8 = 610;
            int y8 = 140;


            e.Graphics.DrawLine(blackPen, x7, y7, x8, y8);


            int x9 = 200;
            int y9 = 1000;
            int x10 = 200;
            int y10 = 140;


            e.Graphics.DrawLine(blackPen, x9, y9, x10, y10);


            int x90 = 800;
            int y90 = 1000;
            int x100 = 800;
            int y100 = 140;


            e.Graphics.DrawLine(blackPen, x90, y90, x100, y100);


            int x11 = 450;
            int y11 = 1000;
            int x12 = 450;
            int y12 = 140;


            e.Graphics.DrawLine(blackPen, x11, y11, x12, y12);


            int x13 = 50;
            int y13 = 1000;
            int x14 = 800;
            int y14 = 1000;

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, x13, y13, x14, y14);





            Dialogue_Box_Parent_Head frm = new Dialogue_Box_Parent_Head();
            int count = 50;
            e.Graphics.DrawString("PARENT CODE", new Font("Cambria", 12, FontStyle.Bold), Brushes.Black, new Point(70, 100 + count));
            e.Graphics.DrawString("PARENT TITLE", new Font("Cambria", 12, FontStyle.Bold), Brushes.Black, new Point(260, 100 + count));

            e.Graphics.DrawString("ACCOUNT CODE", new Font("Cambria", 12, FontStyle.Bold), Brushes.Black, new Point(470, 100 + count));
            e.Graphics.DrawString("ACCOUNT TITLE", new Font("Cambria", 12, FontStyle.Bold), Brushes.Black, new Point(650, 100 + count));


            //Dialogue_Box_Account_Head frm1 = new Dialogue_Box_Account_Head();
            //int count3 = 50;

            //for (int i = 0; i < frm1.dataGridViewAccountHead3.Rows.Count; i++)
            //{

            //    string tt = Convert.ToString(frm1.dataGridViewAccountHead3.Rows[i].Cells["Account Code"].Value);
            //    e.Graphics.DrawString(tt, new Font("Cambria", 10, FontStyle.Regular), Brushes.Black, new Point(470, 180 + count3));



            //    string m = Convert.ToString(frm1.dataGridViewAccountHead3.Rows[i].Cells["Account Title"].Value);
            //    e.Graphics.DrawString(m, new Font("Cambria", 6, FontStyle.Regular), Brushes.Black, new Point(650, 180 + count3));
            //    count3 = count3 + 20;


            //}












            //Trial Balance From 30/06/2008 Upto 30/06/2008 Cont'd...Page/3


            // e.Graphics.DrawString("ACCHEAD_NAME", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(470, 100 + count));



            //for (int i = 0; i < frm..Rows.Count; i++)
            //{
            //    count = count + 50;
            //    string tt = Convert.ToString(frm.dataGridView_AccHead.Rows[i].Cells["ACCHEAD_ID"].Value);
            //    e.Graphics.DrawString(tt, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 100 + i + count));

            //    string ww = Convert.ToString(frm.dataGridView_AccHead.Rows[i].Cells["ACCPARENTHEAD_ID"].Value);
            //    e.Graphics.DrawString(ww, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 100 + i + count));

            //    string m = Convert.ToString(frm.dataGridView_AccHead.Rows[i].Cells["ACCHEAD_NAME"].Value);
            //    e.Graphics.DrawString(m, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 100 + i + count));

            //    // Draw line to screen.
            //    // e.Graphics.DrawLine(blackPen, 100 + i + count, 140, 200 + i + count, 140);

            //}

            //TreeNode tn = new TreeNode();
            ////string temp = search2.Text.ToString();
            //int level1, level2, level3, level4;

            //Dialogue_Box_Parent_Head q = new Dialogue_Box_Parent_Head();

            //string start;
            //string end;
            //start = heads1;
            //end = heads2;
            //if (String.IsNullOrWhiteSpace(start) == false)
            //{
            //    //MessageBox.Show("0");
            //    //Search by Parent Code
            //    //dt = db.SelectQuery("Select PARENTHEAD_ID, PARENTHEAD_CODE, PARENTHEAD_TITLE FROM PARENT_HEADS  WHERE PARENTHEAD_CODE LIKE '" + temp + "%'");
            //    //if (dt.Rows.Count > 0)
            //    //{
            //    level1 = q.ParenHeadTree.GetNodeCount(false);
            //    string end1 = "";
            //    // MessageBox.Show(start, "s1 level");
            //    // MessageBox.Show(end, "s2 level");
            //    int count1 = 50;
            //    for (int i = 0; i < level1; i++)
            //    {
            //        string temp2 = q.ParenHeadTree.Nodes[i].Text.ToString();
            //        string a = temp2.Substring(0, 15);
            //      //  int b = 0;
            //        //if (b == 1) { a = start; }

            //        if (a == start )
            //        {
            //              //  b = b + 1;









            //            e.Graphics.DrawString(" " + q.ParenHeadTree.Nodes[i].Text.Substring(0, 15), new Font("Cambria", 10, FontStyle.Bold), Brushes.Black, new Point(76, 180 + count1));

            //            e.Graphics.DrawString(" " + q.ParenHeadTree.Nodes[i].Text.Substring(15), new Font("Cambria", 6, FontStyle.Bold), Brushes.Black, new Point(260, 180 + count1));
            //            count1 = count1 + 20;
            //            end1 = q.ParenHeadTree.Nodes[i].Text.Substring(0, 15);
            //            start = end1;


            //            //MessageBox.Show("1", end1);
            //            if (end1 == end) { return; }


            //            //return e.Graphics.DrawString(q.ParenHeadTree.Nodes[i].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 100));


            //            level2 = q.ParenHeadTree.Nodes[i].GetNodeCount(false);
            //            for (int j = 0; j < level2; j++)
            //            {
            //                string temp3 = q.ParenHeadTree.Nodes[i].Nodes[j].Text.ToString();
            //               // if (temp2.Substring(0, 15) == start)
            //                {
            //                    //MessageBox.Show("2", end1);


            //                    e.Graphics.DrawString("  " + q.ParenHeadTree.Nodes[i].Nodes[j].Text.Substring(0, 15), new Font("Cambria", 10, FontStyle.Regular), Brushes.Black, new Point(77, 180 + count1));
            //                    e.Graphics.DrawString("  " + q.ParenHeadTree.Nodes[i].Nodes[j].Text.Substring(15), new Font("Cambria", 6, FontStyle.Regular), Brushes.Black, new Point(261, 180 + count1));
            //                    count1 = count1 + 20;
            //                    end1 = q.ParenHeadTree.Nodes[i].Nodes[j].Text.Substring(0, 15);
            //                   // start = end1;


            //                    if (end1 == end) { return; }


            //                }
            //                level3 = q.ParenHeadTree.Nodes[i].Nodes[j].GetNodeCount(false);
            //                for (int k = 0; k < level3; k++)
            //                {
            //                    string temp4 = q.ParenHeadTree.Nodes[i].Nodes[j].Nodes[k].Text.ToString();
            //                  //  if (temp2.Substring(0, 15) == start)
            //                    {
            //                        // MessageBox.Show("3 level", end1);


            //                        e.Graphics.DrawString("   " + q.ParenHeadTree.Nodes[i].Nodes[j].Nodes[k].Text.Substring(0, 15), new Font("Cambria", 10, FontStyle.Regular), Brushes.Black, new Point(78, 180 + count1));
            //                        e.Graphics.DrawString("   " + q.ParenHeadTree.Nodes[i].Nodes[j].Nodes[k].Text.Substring(15), new Font("Cambria", 6, FontStyle.Regular), Brushes.Black, new Point(262, 180 + count1));
            //                        count1 = count1 + 20;
            //                        end1 = q.ParenHeadTree.Nodes[i].Nodes[j].Nodes[k].Text.Substring(0, 15);
            //                       // start = end1;


            //                        if (end1 == end) { return; }




            //                    }
            //                    level4 = q.ParenHeadTree.Nodes[i].Nodes[j].Nodes[k].GetNodeCount(false);
            //                    for (int l = 0; l < level4; l++)
            //                    {
            //                        ////MessageBox.Show("4 level");
            //                        string temp5 = q.ParenHeadTree.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Text.ToString();
            //                      //  if (temp2.Substring(0, 15) == start)
            //                        {


            //                            e.Graphics.DrawString("    " + q.ParenHeadTree.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Text.Substring(0, 15), new Font("Cambria", 10, FontStyle.Regular), Brushes.Black, new Point(79, 180 + count1));
            //                            e.Graphics.DrawString("    " + q.ParenHeadTree.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Text.Substring(15), new Font("Cambria", 6, FontStyle.Regular), Brushes.Black, new Point(260, 180 + count1));
            //                            count1 = count1 + 20;
            //                            end1 = q.ParenHeadTree.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Text.Substring(0, 15);
            //                           // start = end1;
            //                            if (end1 == end) { return; }
            //                       }
            //                  }


            //               }
            //           }
            //        }
            //    }

        }


        //}


    

        

            private void button2_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ParentTitlePrintForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imagelocation = "";
            try

            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    image3.ImageLocation = imagelocation;


                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while uploading.Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
