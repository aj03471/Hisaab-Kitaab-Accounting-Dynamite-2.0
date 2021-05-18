using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hisaab_Kitaab
{
    public partial class List_Account_Head_Add_Address : Form
    {      
        dataconnection dt_conn = new dataconnection();
        DataTable dt_table = new DataTable();
        bool buttonDisabled = true;
        int AccHead = -1;
        string address = "";
        string destinationPath = "";
        string dir = "";
        string filePath = "";
        string a1 = "";
        string a2 = "";
        string a3 = "";
        string line1 = "";
        string line2 = "";
        string line3 = "";
        string line4 = "";
        string line5 = "";
        string OnLoadQueryCheck = "";
        string OnSaveQueryCheck = "";
        string image = "";



        public List_Account_Head_Add_Address(int accHeadID)
        {
            InitializeComponent();
            AccHead = accHeadID;
            HelperClass.SetAllButtons(this.Controls);
            buttonDisabled = true;
            textBoxAddress.MaxLength = 150;
            Console.WriteLine(Convert.ToString(12f / 3f));
            Console.WriteLine(Convert.ToString(13f / 3f));

            string line01 = "SELECT PH.PARENTHEAD_CODE, PH.PARENTHEAD_TITLE, AH.ACCHEAD_NAME, AH.ADDCARD_CHOICE, AC.* ";//0,1,2,3,...
            string line02 = "FROM ACCOUNT_HEADS AS AH INNER JOIN PARENT_HEADS AS PH ";//4,5,6,7,8
            string line03 = "ON AH.ACCPARENTHEAD_ID = PH.PARENTHEAD_ID INNER JOIN ADDRESS_CARD AS AC ON AH.ACCHEAD_ID = AC.ACCHEAD_ID ";//9,10,11 
            string line04 = "WHERE AH.ACCHEAD_ID = " + accHeadID.ToString();
            string query = line01 + line02 + line03 + line04;
            dt_table = dt_conn.SelectQuery(query);      
            if (dt_table.Rows.Count == 1)
            {
                textBoxParentHead.Text = dt_table.Rows[0][0].ToString().Trim() + " " + dt_table.Rows[0][1].ToString().Trim();
                textBoxAccountTitle.Text = dt_table.Rows[0][2].ToString().Trim();
                textBoxAddress.Text = dt_table.Rows[0][6].ToString().Trim() + " " + dt_table.Rows[0][7].ToString().Trim() + " " + dt_table.Rows[0][8].ToString().Trim();
                comboBoxCity.Text = dt_table.Rows[0][9].ToString().Trim();
                comboBoxCountry.Text = dt_table.Rows[0][10].ToString().Trim();
                textBoxPhone1.Text = dt_table.Rows[0][11].ToString().Trim();
                textBoxPhone2.Text = dt_table.Rows[0][12].ToString().Trim();
                textBoxEmailAddress.Text = dt_table.Rows[0][13].ToString().Trim();
                textBoxAmount.Text = dt_table.Rows[0][14].ToString().Trim();
                textBoxDays.Text = dt_table.Rows[0][15].ToString().Trim();
                pictureBox1.ImageLocation = dt_table.Rows[0][16].ToString().Trim();
            }
            else
            {
                string line5 = "SELECT PH.PARENTHEAD_CODE, PH.PARENTHEAD_TITLE, AH.ACCHEAD_NAME ";
                string line6 = "FROM ACCOUNT_HEADS AS AH INNER JOIN PARENT_HEADS AS PH ON AH.ACCPARENTHEAD_ID = PH.PARENTHEAD_ID ";
                string line7 = "WHERE AH.ACCHEAD_ID = " + accHeadID.ToString();
                string queryelse = line5 + line6 + line7;
                dt_table = dt_conn.SelectQuery(queryelse);
                if (dt_table.Rows.Count == 1)
                {
                    textBoxParentHead.Text = dt_table.Rows[0][0].ToString().Trim() + " " + dt_table.Rows[0][1].ToString().Trim();
                    textBoxAccountTitle.Text = dt_table.Rows[0][2].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("Error while loading data from database");
                    this.DialogResult = DialogResult.Cancel;
                }
            }                  
                                 
        }

        //Save button k click pe agar yeh saray empty hongay toh hum update query karengay warna insert query
        private string CheckQueryType()
        {
            if(String.IsNullOrEmpty(textBoxAddress.Text) && String.IsNullOrEmpty(textBoxAmount.Text) && String.IsNullOrEmpty(textBoxDays.Text) && String.IsNullOrEmpty(textBoxEmailAddress.Text) && String.IsNullOrEmpty(textBoxPhone1.Text) && String.IsNullOrEmpty(textBoxPhone2.Text) && String.IsNullOrEmpty(comboBoxCity.Text) && String.IsNullOrEmpty(comboBoxCountry.Text) && String.IsNullOrEmpty(pictureBox1.ImageLocation))
            {
                return "empty";
            }
            else
            {
                return "full";
            }

        }
        private void button_ParentHeadChoose_Click(object sender, EventArgs e)
        {
            if (buttonDisabled == false)
            {
                Choose_Account_Parent_Head form_choose = new Choose_Account_Parent_Head();
                form_choose.ShowDialog();
                textBoxParentHead.Text = form_choose.selected_head;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonModify.Text == "Modify")
            {
                buttonModify.Text = "Save";
                buttonDisabled = false;// true;
                textBoxAddress.ReadOnly = false;
                textBoxDays.ReadOnly = false;
                textBoxAmount.ReadOnly = false;
                textBoxPhone1.ReadOnly = false;
                textBoxPhone2.ReadOnly = false;
                textBoxEmailAddress.ReadOnly = false;
                textBoxAccountTitle.ReadOnly = false;
                comboBoxCity.Enabled = true;
                comboBoxCountry.Enabled = true;
                OnLoadQueryCheck = CheckQueryType();


            }
            else if(buttonModify.Text == "Save")
            {

                buttonModify.Text = "Modify";
                buttonDisabled = true;//false
                textBoxAddress.ReadOnly = true;
                textBoxDays.ReadOnly = true;
                textBoxAmount.ReadOnly = true;
                textBoxPhone1.ReadOnly = true;
                textBoxPhone2.ReadOnly = true;
                textBoxEmailAddress.ReadOnly = true;
                textBoxAccountTitle.ReadOnly = true;
                comboBoxCity.Enabled = false;
                comboBoxCountry.Enabled = false;
                OnSaveQueryCheck = CheckQueryType();
                //update record.

                //MessageBox.Show("Selected Item: " + comboBoxCity.SelectedItem.ToString());
                MessageBox.Show("Text: "+comboBoxCity.Text);
                //length of address cannot be more than 150.
                if (String.IsNullOrWhiteSpace(textBoxAddress.Text) == false)
                {
                    Single len1 = textBoxAddress.Text.Length;
                    Single len = Convert.ToSingle(len1 / 50f);
                    if (len == 0|| len == 1 || len == 2 || len == 3)
                    {
                        Console.WriteLine("Lenght: " + len);
                        //string[] len2 = Convert.ToString(len).Split('.');
                        int x = Convert.ToInt32(len);
                        //Single y = Convert.ToSingle("0." + len2[1]);
                        
                        for (int i = 0; i < x; i++)
                        {
                            address = address + textBoxAddress.Text.Substring(i * 50, 50);
                        }
                        //address = address + textBoxAddress.Text.Substring(x * 50, (x * 50) + Convert.ToInt32(y * 50));
                        MessageBox.Show(address+" "+address.Length.ToString());

                    }
                    else
                    {
                        Console.WriteLine("Lenght: " + len);
                        string[] len2 = Convert.ToString(len).Split('.');
                        int x = Convert.ToInt32(len2[0]);
                        //Single y = Convert.ToSingle("0." + len2[1]);
                        
                        for (int i = 0; i < x; i++)
                        {
                            address = address + textBoxAddress.Text.Substring(i * 50, 50);
                        }
                        address = address + textBoxAddress.Text.Substring(x * 50);
                        MessageBox.Show(address + " " + address.Length.ToString());
                    }
                    MessageBox.Show("Hello: " + (5 / 2).ToString());

                    int y = address.Length;
                    MessageBox.Show("Address again: " + address);
                    if (y / 50 == 0)
                    {
                        a1 = address.Substring(0);
                        MessageBox.Show("Address a1: " + a1);
                    }
                    else if (y / 50 == 1)
                    {
                        a1 = address.Substring(0, 50);
                        a2 = address.Substring(50);
                        MessageBox.Show("Address a1,a2: " + a1+a2);
                    }
                    else if (y / 50 == 2 || y / 50 == 3)
                    {
                        a1 = address.Substring(0, 50);
                        a2 = address.Substring(50, 50);
                        a3 = address.Substring(100);
                        MessageBox.Show("Address a1+a2+a3: " + a1+a2+a3);

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Length of Address");
                        return;
                    }
                    MessageBox.Show("(oper) Address: " + a1 + a2 + a3);
                }
                
                
                try
                {

                    MessageBox.Show("Img loc: "+pictureBox1.ImageLocation);
                    
                    //to avoid entry of null data
                    if(String.IsNullOrEmpty(comboBoxCountry.Text) == true)
                    {
                        comboBoxCountry.Text = "";
                    }
                    if (String.IsNullOrEmpty(comboBoxCity.Text) == true)
                    {
                        comboBoxCity.Text = "";
                    }
                    if (String.IsNullOrEmpty(textBoxEmailAddress.Text) == true)
                    {
                        textBoxEmailAddress.Text = "";
                    }
                    if (String.IsNullOrEmpty(textBoxPhone1.Text) == true)
                    {
                        textBoxPhone1.Text = "";
                    }
                    if (String.IsNullOrEmpty(textBoxPhone2.Text) == true)
                    {
                        textBoxPhone2.Text = "";
                    }
                    if (String.IsNullOrEmpty(textBoxDays.Text) == true)
                    {
                        textBoxDays.Text = "NULL";
                    }
                    if (String.IsNullOrEmpty(textBoxAmount.Text) == true)
                    {
                        textBoxAmount.Text = "NULL";
                    }
                    if (String.IsNullOrEmpty(pictureBox1.ImageLocation) == true)
                    {
                        pictureBox1.ImageLocation = "";
                        image = "0";
                    }
                    else
                    {
                        image = "1";
                        
                    }
                    MessageBox.Show("Address: " + a1 + a2 + a3);
                    if (OnLoadQueryCheck == "empty" && OnSaveQueryCheck == "full") 
                    {
                        if (image == "1")
                        {
                            if (Directory.Exists(dir) == false)
                            {
                                Directory.CreateDirectory(dir);
                            }
                            if (String.IsNullOrEmpty(destinationPath) == false)
                            {
                                File.Copy(filePath, destinationPath, true);
                            }
                            
                        }
                        //insert query
                        dt_table = dt_conn.SelectQuery("SELECT MAX(ACC_ADDR_ID) FROM ADDRESS_CARD");
                        //MessageBox.Show(CheckQueryType());
                        line1 = "INSERT INTO ADDRESS_CARD VALUES( " + (Convert.ToInt32(dt_table.Rows[0][0].ToString())+1).ToString() + ", " + AccHead.ToString();
                        line2 = ", '" + a1 + "', '" + a2 + "', '" + a3 + "', '";
                        line3 = comboBoxCity.Text + "', '" + comboBoxCountry.Text + "', '" + textBoxPhone1.Text + "', '" + textBoxPhone2.Text + "', '"+  textBoxEmailAddress.Text;
                        line4 = "', " + textBoxAmount.Text + ",  " + textBoxDays.Text + ", '" + destinationPath + "'); ";
                        
                        string query = line1 + line2 + line3 + line4;
                        //MessageBox.Show(query);
                        MessageBox.Show("Insert Query: " + query);
                        dt_conn.InsertQuery(query);

                        string l1 = "UPDATE ACCOUNT_HEADS ";                        
                        string l2 = "SET ACCHEAD_NAME ='"+textBoxAccountTitle.Text + "' , ACCPARENTHEAD_ID = (SELECT PARENTHEAD_ID FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '"+textBoxParentHead.Text.Trim().Substring(0,15)+"' and PARENTHEAD_TYPE = 'A')";
                        string l3 = ", ADDCARD_CHOICE = '1', PICTURE_CHOICE = '"+image+"'";
                        string l4 = " WHERE ACCHEAD_ID = " + AccHead.ToString() + ";";
                        string query1 = l1 + l2 + l3+l4;
                        dt_conn.InsertQuery(query1);


                        MessageBox.Show("Database Updated Successfully!");
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (OnLoadQueryCheck == "empty" && OnSaveQueryCheck == "empty")
                    {
                        //buss kuch nahi in the address card table
                        MessageBox.Show(CheckQueryType());
                        string l1 = "UPDATE ACCOUNT_HEADS ";
                        string l2 = "SET ACCHEAD_NAME ='" + textBoxAccountTitle.Text + "' , ACCPARENTHEAD_ID = (SELECT PARENTHEAD_ID FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '" + textBoxParentHead.Text.Trim().Substring(0, 15) + "' and PARENTHEAD_TYPE = 'A')";
                        string l3 = " WHERE ACCHEAD_ID = " + AccHead.ToString() + ";";
                        string query1 = l1 + l2 + l3;
                        dt_conn.InsertQuery(query1);
                        MessageBox.Show("Database Updated Successfully!");
                        this.DialogResult = DialogResult.OK;

                    }
                    else if (OnLoadQueryCheck == "full")
                    {
                        //update query
                        if (image == "1") 
                        {
                            if (destinationPath != "" && dir != "")
                            {
                                if (Directory.Exists(dir) == false)
                                {
                                    Directory.CreateDirectory(dir);
                                }


                                File.Copy(filePath, destinationPath, true);
                            }
                            else
                            {
                                destinationPath = pictureBox1.ImageLocation;
                            }
                                                      

                        }
                        MessageBox.Show("Update Query");
                        line1 = "UPDATE ADDRESS_CARD ";
                        line2 = "SET ADDRESS_LINE1 = '" + a1 + "', ADDRESS_LINE2 = '" + a2 + "', ADDRESS_LINE3 = '" + a3 + "', ";
                        line3 = "COUNTRY = '" + comboBoxCountry.Text + "', CITY = '" + comboBoxCity.Text + "', EMAIL = '" + textBoxEmailAddress.Text + "', PHONE1 = '" + textBoxPhone1.Text + "', PHONE2 = '" + textBoxPhone2.Text + "', ";
                        line4 = "CR_LIMIT_DAYS = " + textBoxDays.Text + ", CR_LIMIT_AMOUNT = " + textBoxAmount.Text + ", PIC_PATH = '" + destinationPath + "' ";
                        line5 = "WHERE ACCHEAD_ID = " + AccHead.ToString() + "; ";
                        string query = line1 + line2 + line3 + line4 + line5;
                        MessageBox.Show("Query: " + query);
                        dt_conn.InsertQuery(query);

                        string l1 = "UPDATE ACCOUNT_HEADS ";
                        string l2 = "SET ACCHEAD_NAME ='" + textBoxAccountTitle.Text + "' , ACCPARENTHEAD_ID = (SELECT PARENTHEAD_ID FROM PARENT_HEADS WHERE PARENTHEAD_CODE = '" + textBoxParentHead.Text.Trim().Substring(0, 15) + "' and PARENTHEAD_TYPE = 'A')";
                        string l3 = ", ADDCARD_CHOICE = '1', PICTURE_CHOICE = '" + image + "'";
                        string l4 = " WHERE ACCHEAD_ID = " + AccHead.ToString() + ";";
                        string query1 = l1 + l2 + l3 + l4;
                        dt_conn.InsertQuery(query1);

                        MessageBox.Show("Database Updated Successfully!");
                        this.DialogResult = DialogResult.OK;
                    }





                    //MessageBox.Show(len2[0] + ", " + len2[1]);
                    //string y = 
                    //int len = textBoxAddress.Text.Length;


                    this.DialogResult = DialogResult.OK;


                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                    this.DialogResult = DialogResult.Cancel;
                }
                

            }
        }

        private void List_Account_Head_Add_Address_Load(object sender, EventArgs e)
        {

        }

        private void button_ParentHeadChoose_EnabledChanged(object sender, EventArgs e)
        {
            button_ParentHeadChoose.ForeColor = Color.White;
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (comboBoxCity.SelectedItem.ToString().Trim() == "Other...")
            {
                //MessageBox.Show("If condition");
                comboBoxCity.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void button_UploadPic_Click(object sender, EventArgs e)
        {
            if (buttonDisabled == false)
            {
                OpenFileDialog ofd = new OpenFileDialog();


                //ofd.InitialDirectory = "c:\\";
                ofd.Filter = "picture files |*.jpg; *.png; *.jpeg|All files (*.*)|*.*";
                ofd.FilterIndex = 0;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    try
                    {
                        string extension = "";
                        filePath = ofd.FileName;
                        pictureBox1.ImageLocation = filePath;
                        for (int i = 0; i < filePath.Length; i++)
                        {
                            if (filePath[i] == '.')
                            {
                                extension = filePath.Substring(i);

                            }
                        }

                        dt_table = dt_conn.SelectQuery_Users("SELECT DB_PHOTORECORD_PATH FROM DBProperties WHERE DB_ID = 1");// + HelperClass.dbID);
                        dir = dt_table.Rows[0][0].ToString() + "\\Account Head\\Address Card\\";
                        string fn = AccHead.ToString("0000000") + "-" + textBoxAccountTitle.Text + extension;//   "0000001 -AccountTitle";
                                                                                                             //MessageBox.Show(dest + "\\" + fn + " ~ "+215.ToString("0000000"));
                        destinationPath = dir + fn;



                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message);
                    }

                    //Directory.Exists()
                    //pictureBox1.Show();
                    //pictureBox1.Image.Save("D:\\Experiment.jpg");
                    //textBoxUserPhotoPath.Text = filePath;

                }

            }

        }
    }
}
