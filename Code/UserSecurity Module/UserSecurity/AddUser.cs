using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserSecurity
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddUserData_Load(object sender, EventArgs e)
        {

            textBoxUserAccountOpeningDateandTime.Text = DateTime.Now.ToString();
            
          
        }

        private void buttonUploadUserPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            var filePath = string.Empty;

            //ofd.InitialDirectory = "c:\\";
            ofd.Filter = "picture files |(*.jpg)|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
                {
                //Get the path of specified file
                filePath = ofd.FileName;
                pictureBoxUserPhoto.ImageLocation = filePath;
                textBoxUserPhotoPath.Text = filePath;
                pictureBoxUserPhoto.Show();
            }
            

        }

        private void buttonCNICPictureFront_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdF = new OpenFileDialog();

            var filePath = string.Empty;

            //ofd.InitialDirectory = "c:\\";
            ofdF.Filter = "picture files |(*.jpg)|All files (*.*)|*.*";
            ofdF.FilterIndex = 2;
            ofdF.RestoreDirectory = true;

            if (ofdF.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = ofdF.FileName;
                pictureBoxCNICfront.ImageLocation = filePath;
                textBoxUserCNICPicturePath.Text = filePath;
                pictureBoxCNICfront.Show();
            }


        }

        private void buttonCNICPictureBack_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdB = new OpenFileDialog();

            var filePath = string.Empty;

            //ofd.InitialDirectory = "c:\\";
            ofdB.Filter = "picture files |(*.jpg)|All files (*.*)|*.*";
            ofdB.FilterIndex = 2;
            ofdB.RestoreDirectory = true;

            if (ofdB.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = ofdB.FileName;
                pictureBoxCNICPictureBack.ImageLocation = filePath;
                textBoxCNICPicturePathBack.Text = filePath;
                pictureBoxCNICPictureBack.Show();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New User Created");
            this.Close();

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {

        }
    }
}
