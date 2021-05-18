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
    static class HelperClass
    {
        //define global variables for easy access across the forms: 
        public static string globalParentHead = "";
        public static string inv_units = "S"; // SPL,SP,SL,PL,S,P,L
        public static string globalString = ""; //user name
        public static int userid = 1;
        public static int thislogin_logid = -1;
        public static string db_name = "";
        public static string db_path = "";
        public static string dbID = "";
            
        public enum InventoryUnits
        {
            Stock,
            Packing,
            Loose,
            StockPacking,
            StockLoose,            
            PackingLoose,
            StockPackingLoose
        }
        public static InventoryUnits inventory_units = InventoryUnits.Stock;

        //define colors:
        public static Color darkBlue = System.Drawing.ColorTranslator.FromHtml("#293574"); //rgb(41, 53, 116)
        public static Color lightBlue = System.Drawing.ColorTranslator.FromHtml("#f2f4ff"); //rgb(242, 244, 255)
        public static Color magenta = System.Drawing.ColorTranslator.FromHtml("#741300");  //rgb(116, 19, 0)   

        //Set font:
        public static Font SetFont(char type = 'B',int size = 12, FontStyle fs = FontStyle.Regular)
        {
            FontFamily myfam = new FontFamily("Tahoma");
            Font myfont;             
            if (type == 'H') //H = headings
            {
                myfont = new Font(myfam, 14, FontStyle.Bold);
                return myfont;
            }
            else if (type == 'F') //B = body
            {
                myfont = new Font(myfam, 12, FontStyle.Regular);
                return myfont;
            }
            else
            {
                myfont = new Font(myfam, size, fs);
                return myfont;
            }
        }

        //Set the same Font for all the controls:
        public static void SetAllFonts(Control.ControlCollection controlss)
        {
            foreach (Control ctrl in controlss)
            {
                if (ctrl.Controls != null)
                {
                    SetAllFonts(ctrl.Controls);
                }
                FontFamily myfam = new FontFamily("Tahoma");
                ctrl.Font = new Font(myfam, ctrl.Font.Size-2, ctrl.Font.Style);
            }
        }

        //Set the style for each button in a form:
        public static void SetAllButtons(Control.ControlCollection controlss)
        {
            foreach (Control ctrl in controlss)
            {
                if (ctrl is Button)
                {
                    ctrl.ForeColor = Color.White;
                    ctrl.BackColor = darkBlue;
                    
                }

            }

        }

        //Populate Tree View:
        public static void PopulateTreeView(TreeView mytreeview,string type1, string type2)
        {
            /* Accounts = BalanceSheet: A,B
             * Accounts = IncomeStatement: A,I
             * Inventory = BalanceSheet: I,B
             */

            dataconnection dt_conn = new dataconnection();
            DataTable dt_count_lvl1 = new DataTable();
            DataTable dt_data_lvl1 = new DataTable();
            DataTable dt_count_lvl2 = new DataTable();
            DataTable dt_data_lvl2 = new DataTable();
            DataTable dt_count_lvl3 = new DataTable();
            DataTable dt_data_lvl3 = new DataTable();
            DataTable dt_count_lvl4 = new DataTable();
            DataTable dt_data_lvl4 = new DataTable();

            int level1 = 0;
            int level2 = 0;
            int level3 = 0;
            int level4 = 0;

            string updated_code;
            string temp;

            dt_count_lvl1 = dt_conn.SelectQuery("EXEC Count_Heads '%-000-000-000','" + type1 + "','" + type2 + "';");
            level1 = Convert.ToInt32(dt_count_lvl1.Rows[0][0].ToString()); //Total records of top level
            dt_data_lvl1 = dt_conn.SelectQuery("EXEC Heads_CodeTitle '%-000-000-000','" + type1 + "','" + type2 + "';");

            if (level1 > 0)
            {
                for (int i = 0; i < level1; i++)
                {
                    mytreeview.Nodes.Add(dt_data_lvl1.Rows[i][0].ToString().Trim() + "  " + dt_data_lvl1.Rows[i][1].ToString().Trim());
                    temp = dt_data_lvl1.Rows[i][0].ToString();
                    updated_code = temp.Substring(0, 3) + "-%-000-000";

                    dt_count_lvl2 = dt_conn.SelectQuery("EXEC Count_Heads '" + updated_code + "','" + type1 + "','" + type2 + "';");
                    level2 = Convert.ToInt32(dt_count_lvl2.Rows[0][0].ToString());
                    dt_data_lvl2 = dt_conn.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','" + type1 + "','" + type2 + "';");

                    if (level2 > 1)
                    {
                        for (int j = 1; j < level2; j++)
                        {
                            mytreeview.Nodes[i].Nodes.Add(dt_data_lvl2.Rows[j][0].ToString().Trim() + "  " + dt_data_lvl2.Rows[j][1].ToString().Trim());
                            temp = dt_data_lvl2.Rows[j][0].ToString();
                            updated_code = temp.Substring(0, 7) + "-%-000";

                            dt_count_lvl3 = dt_conn.SelectQuery("EXEC Count_Heads '" + updated_code + "','" + type1 + "','" + type2 + "';");
                            level3 = Convert.ToInt32(dt_count_lvl3.Rows[0][0].ToString());
                            dt_data_lvl3 = dt_conn.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','" + type1 + "','" + type2 + "';");


                            if (level3 > 1)
                            {
                                for (int k = 1; k < level3; k++)
                                {

                                    mytreeview.Nodes[i].Nodes[j - 1].Nodes.Add(dt_data_lvl3.Rows[k][0].ToString().Trim() + "  " + dt_data_lvl3.Rows[k][1].ToString().Trim());
                                    temp = dt_data_lvl3.Rows[k][0].ToString();
                                    updated_code = temp.Substring(0, 11) + "-%";

                                    dt_count_lvl4 = dt_conn.SelectQuery("EXEC Count_Heads '" + updated_code + "','" + type1 + "','" + type2 + "';");
                                    level4 = Convert.ToInt32(dt_count_lvl4.Rows[0][0].ToString());
                                    dt_data_lvl4 = dt_conn.SelectQuery("EXEC Heads_CodeTitle '" + updated_code + "','" + type1 + "','" + type2 + "';");

                                    if (level4 > 1)
                                    {
                                        for (int l = 1; l < level4; l++)
                                        {
                                            mytreeview.Nodes[i].Nodes[j - 1].Nodes[k - 1].Nodes.Add(dt_data_lvl4.Rows[l][0].ToString().Trim() + "  " + dt_data_lvl4.Rows[l][1].ToString().Trim());
                                        }
                                    }


                                }
                            }


                        }
                    }



                }

            }

        }

        //Add Hyphens to parent code:
        public static string RemoveHyphens(string code)
        {
            string new_code = "";
            if (code.Length == 15)
            {
                for (int i = 0; i < code.Length; i++)
                {
                    if (code[i] != '-')
                    {
                        new_code = new_code + code[i];
                    }
                }
                return new_code;
            }
            else
            {
                return code;
            }
        }

        //Remove Hyphens from parent code:
        public static string AddHyphens(string code)
        {
            string new_code = "";
            if (code.Length == 12)
            {
                for (int i = 0; i < code.Length; i++)
                {
                    if (i % 3 == 0 && i != 0)
                    {
                        new_code = new_code + "-" + code[i];

                    }
                    else
                    {
                        new_code = new_code + code[i];
                    }
                }
                return new_code;
            }
            else
            {
                return code;
            }
            
        }

        //Find Parent Head ID:
        public static int FindParentHeadID(string code, string type1)
        {
            dataconnection dtConn = new dataconnection();
            DataTable dtTable = new DataTable();
            dtTable = dtConn.SelectQuery("SELECT PARENTHEAD_ID FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '" + code + "' AND PARENTHEAD_TYPE = '" + type1 + "'");
            if (dtTable.Rows.Count == 1)
            {
                return Convert.ToInt32(dtTable.Rows[0][0].ToString());
            }
            else
            {
                return -1;
            }
        }

        //Default Style for all DataGridViews
        public static void StyleDGV(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = lightBlue;
            dgv.DefaultCellStyle.ForeColor = darkBlue;
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Regular);

            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = darkBlue;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 45;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = lightBlue;
            dgv.RowTemplate.Height = 40;        
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.White;//darkBlue;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersWidth = 20;
            
            //dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            

        }

        

    }
}
