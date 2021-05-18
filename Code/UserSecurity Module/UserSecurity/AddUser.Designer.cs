namespace UserSecurity
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserPhoto = new System.Windows.Forms.Label();
            this.labelCNIC = new System.Windows.Forms.Label();
            this.labelUserCNICPath = new System.Windows.Forms.Label();
            this.labelUserPosition = new System.Windows.Forms.Label();
            this.labelUserLocation = new System.Windows.Forms.Label();
            this.labelOpeningDate = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.labelUserData = new System.Windows.Forms.Label();
            this.textBoxUserPhotoPath = new System.Windows.Forms.TextBox();
            this.textBoxUserCNICPicturePath = new System.Windows.Forms.TextBox();
            this.textBoxUserPosition = new System.Windows.Forms.TextBox();
            this.textBoxUserLocation = new System.Windows.Forms.TextBox();
            this.textBoxUserAccountOpeningDateandTime = new System.Windows.Forms.TextBox();
            this.textBoxUserCNIC = new System.Windows.Forms.MaskedTextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.pictureBoxUserPhoto = new System.Windows.Forms.PictureBox();
            this.buttonUploadUserPhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCNICPhotoFront = new System.Windows.Forms.Label();
            this.buttonCNICPictureFront = new System.Windows.Forms.Button();
            this.pictureBoxCNICfront = new System.Windows.Forms.PictureBox();
            this.labelCNICPictureBack = new System.Windows.Forms.Label();
            this.buttonCNICPictureBack = new System.Windows.Forms.Button();
            this.pictureBoxCNICPictureBack = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.textBoxCNICPicturePathBack = new System.Windows.Forms.TextBox();
            this.labelUserCNICPathBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCNICfront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCNICPictureBack)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.BackColor = System.Drawing.Color.White;
            this.labelUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelUserID.Location = new System.Drawing.Point(71, 118);
            this.labelUserID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(76, 19);
            this.labelUserID.TabIndex = 0;
            this.labelUserID.Text = "User ID:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.White;
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelUserName.Location = new System.Drawing.Point(71, 155);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(102, 25);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name:";
            this.labelUserName.UseCompatibleTextRendering = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.White;
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelPassword.Location = new System.Drawing.Point(71, 201);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(92, 25);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            this.labelPassword.UseCompatibleTextRendering = true;
            // 
            // labelUserPhoto
            // 
            this.labelUserPhoto.AutoSize = true;
            this.labelUserPhoto.BackColor = System.Drawing.Color.White;
            this.labelUserPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelUserPhoto.Location = new System.Drawing.Point(69, 363);
            this.labelUserPhoto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUserPhoto.Name = "labelUserPhoto";
            this.labelUserPhoto.Size = new System.Drawing.Size(103, 25);
            this.labelUserPhoto.TabIndex = 3;
            this.labelUserPhoto.Text = "Photo Path:";
            this.labelUserPhoto.UseCompatibleTextRendering = true;
            this.labelUserPhoto.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCNIC
            // 
            this.labelCNIC.AutoSize = true;
            this.labelCNIC.BackColor = System.Drawing.Color.White;
            this.labelCNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelCNIC.Location = new System.Drawing.Point(71, 245);
            this.labelCNIC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCNIC.Name = "labelCNIC";
            this.labelCNIC.Size = new System.Drawing.Size(82, 25);
            this.labelCNIC.TabIndex = 4;
            this.labelCNIC.Text = "CNIC No:";
            this.labelCNIC.UseCompatibleTextRendering = true;
            // 
            // labelUserCNICPath
            // 
            this.labelUserCNICPath.AutoSize = true;
            this.labelUserCNICPath.BackColor = System.Drawing.Color.White;
            this.labelUserCNICPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelUserCNICPath.Location = new System.Drawing.Point(71, 293);
            this.labelUserCNICPath.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUserCNICPath.Name = "labelUserCNICPath";
            this.labelUserCNICPath.Size = new System.Drawing.Size(167, 25);
            this.labelUserCNICPath.TabIndex = 5;
            this.labelUserCNICPath.Text = "CNIC Picture Front:";
            this.labelUserCNICPath.UseCompatibleTextRendering = true;
            // 
            // labelUserPosition
            // 
            this.labelUserPosition.AutoSize = true;
            this.labelUserPosition.BackColor = System.Drawing.Color.White;
            this.labelUserPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelUserPosition.Location = new System.Drawing.Point(69, 410);
            this.labelUserPosition.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUserPosition.Name = "labelUserPosition";
            this.labelUserPosition.Size = new System.Drawing.Size(153, 25);
            this.labelUserPosition.TabIndex = 6;
            this.labelUserPosition.Text = "User Designation:";
            this.labelUserPosition.UseCompatibleTextRendering = true;
            // 
            // labelUserLocation
            // 
            this.labelUserLocation.AutoSize = true;
            this.labelUserLocation.BackColor = System.Drawing.Color.White;
            this.labelUserLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelUserLocation.Location = new System.Drawing.Point(71, 447);
            this.labelUserLocation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUserLocation.Name = "labelUserLocation";
            this.labelUserLocation.Size = new System.Drawing.Size(111, 25);
            this.labelUserLocation.TabIndex = 7;
            this.labelUserLocation.Text = "Department:";
            this.labelUserLocation.UseCompatibleTextRendering = true;
            // 
            // labelOpeningDate
            // 
            this.labelOpeningDate.AutoSize = true;
            this.labelOpeningDate.BackColor = System.Drawing.Color.White;
            this.labelOpeningDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelOpeningDate.Location = new System.Drawing.Point(71, 492);
            this.labelOpeningDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelOpeningDate.Name = "labelOpeningDate";
            this.labelOpeningDate.Size = new System.Drawing.Size(132, 25);
            this.labelOpeningDate.TabIndex = 8;
            this.labelOpeningDate.Text = "Date and Time:";
            this.labelOpeningDate.UseCompatibleTextRendering = true;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.BackColor = System.Drawing.Color.White;
            this.textBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBoxUserID.Location = new System.Drawing.Point(240, 118);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.ReadOnly = true;
            this.textBoxUserID.Size = new System.Drawing.Size(197, 27);
            this.textBoxUserID.TabIndex = 9;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.White;
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBoxUserName.Location = new System.Drawing.Point(240, 155);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(197, 27);
            this.textBoxUserName.TabIndex = 10;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.BackColor = System.Drawing.Color.White;
            this.textBoxUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBoxUserPassword.Location = new System.Drawing.Point(240, 199);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(197, 27);
            this.textBoxUserPassword.TabIndex = 11;
            // 
            // labelUserData
            // 
            this.labelUserData.AutoSize = true;
            this.labelUserData.BackColor = System.Drawing.Color.White;
            this.labelUserData.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelUserData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelUserData.Location = new System.Drawing.Point(393, 32);
            this.labelUserData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUserData.Name = "labelUserData";
            this.labelUserData.Size = new System.Drawing.Size(145, 23);
            this.labelUserData.TabIndex = 12;
            this.labelUserData.Text = "Add New User";
            // 
            // textBoxUserPhotoPath
            // 
            this.textBoxUserPhotoPath.BackColor = System.Drawing.Color.White;
            this.textBoxUserPhotoPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserPhotoPath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserPhotoPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBoxUserPhotoPath.Location = new System.Drawing.Point(240, 363);
            this.textBoxUserPhotoPath.Name = "textBoxUserPhotoPath";
            this.textBoxUserPhotoPath.ReadOnly = true;
            this.textBoxUserPhotoPath.Size = new System.Drawing.Size(396, 23);
            this.textBoxUserPhotoPath.TabIndex = 13;
            // 
            // textBoxUserCNICPicturePath
            // 
            this.textBoxUserCNICPicturePath.BackColor = System.Drawing.Color.White;
            this.textBoxUserCNICPicturePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserCNICPicturePath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserCNICPicturePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBoxUserCNICPicturePath.Location = new System.Drawing.Point(240, 295);
            this.textBoxUserCNICPicturePath.Name = "textBoxUserCNICPicturePath";
            this.textBoxUserCNICPicturePath.ReadOnly = true;
            this.textBoxUserCNICPicturePath.Size = new System.Drawing.Size(396, 23);
            this.textBoxUserCNICPicturePath.TabIndex = 15;
            // 
            // textBoxUserPosition
            // 
            this.textBoxUserPosition.BackColor = System.Drawing.Color.White;
            this.textBoxUserPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBoxUserPosition.Location = new System.Drawing.Point(240, 408);
            this.textBoxUserPosition.Name = "textBoxUserPosition";
            this.textBoxUserPosition.Size = new System.Drawing.Size(197, 27);
            this.textBoxUserPosition.TabIndex = 16;
            // 
            // textBoxUserLocation
            // 
            this.textBoxUserLocation.BackColor = System.Drawing.Color.White;
            this.textBoxUserLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBoxUserLocation.Location = new System.Drawing.Point(240, 447);
            this.textBoxUserLocation.Name = "textBoxUserLocation";
            this.textBoxUserLocation.Size = new System.Drawing.Size(197, 27);
            this.textBoxUserLocation.TabIndex = 17;
            // 
            // textBoxUserAccountOpeningDateandTime
            // 
            this.textBoxUserAccountOpeningDateandTime.BackColor = System.Drawing.Color.White;
            this.textBoxUserAccountOpeningDateandTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserAccountOpeningDateandTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserAccountOpeningDateandTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBoxUserAccountOpeningDateandTime.Location = new System.Drawing.Point(240, 492);
            this.textBoxUserAccountOpeningDateandTime.Name = "textBoxUserAccountOpeningDateandTime";
            this.textBoxUserAccountOpeningDateandTime.ReadOnly = true;
            this.textBoxUserAccountOpeningDateandTime.Size = new System.Drawing.Size(197, 27);
            this.textBoxUserAccountOpeningDateandTime.TabIndex = 18;
            // 
            // textBoxUserCNIC
            // 
            this.textBoxUserCNIC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserCNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBoxUserCNIC.Location = new System.Drawing.Point(240, 245);
            this.textBoxUserCNIC.Mask = "#####-#######-#";
            this.textBoxUserCNIC.Name = "textBoxUserCNIC";
            this.textBoxUserCNIC.Size = new System.Drawing.Size(197, 27);
            this.textBoxUserCNIC.TabIndex = 19;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.Location = new System.Drawing.Point(266, 585);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(97, 43);
            this.buttonCreate.TabIndex = 41;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // pictureBoxUserPhoto
            // 
            this.pictureBoxUserPhoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxUserPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserPhoto.Location = new System.Drawing.Point(453, 116);
            this.pictureBoxUserPhoto.Name = "pictureBoxUserPhoto";
            this.pictureBoxUserPhoto.Size = new System.Drawing.Size(173, 173);
            this.pictureBoxUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserPhoto.TabIndex = 42;
            this.pictureBoxUserPhoto.TabStop = false;
            this.pictureBoxUserPhoto.Tag = "User Photograph";
            // 
            // buttonUploadUserPhoto
            // 
            this.buttonUploadUserPhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUploadUserPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.buttonUploadUserPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadUserPhoto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadUserPhoto.ForeColor = System.Drawing.Color.White;
            this.buttonUploadUserPhoto.Location = new System.Drawing.Point(563, 92);
            this.buttonUploadUserPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUploadUserPhoto.Name = "buttonUploadUserPhoto";
            this.buttonUploadUserPhoto.Size = new System.Drawing.Size(63, 23);
            this.buttonUploadUserPhoto.TabIndex = 43;
            this.buttonUploadUserPhoto.Text = "Upload";
            this.buttonUploadUserPhoto.UseVisualStyleBackColor = false;
            this.buttonUploadUserPhoto.Click += new System.EventHandler(this.buttonUploadUserPhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(450, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "User Photograph";
            // 
            // labelCNICPhotoFront
            // 
            this.labelCNICPhotoFront.AutoSize = true;
            this.labelCNICPhotoFront.BackColor = System.Drawing.Color.White;
            this.labelCNICPhotoFront.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNICPhotoFront.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelCNICPhotoFront.Location = new System.Drawing.Point(639, 102);
            this.labelCNICPhotoFront.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCNICPhotoFront.Name = "labelCNICPhotoFront";
            this.labelCNICPhotoFront.Size = new System.Drawing.Size(122, 13);
            this.labelCNICPhotoFront.TabIndex = 45;
            this.labelCNICPhotoFront.Text = "User CNIC Picture Front";
            // 
            // buttonCNICPictureFront
            // 
            this.buttonCNICPictureFront.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCNICPictureFront.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.buttonCNICPictureFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCNICPictureFront.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCNICPictureFront.ForeColor = System.Drawing.Color.White;
            this.buttonCNICPictureFront.Location = new System.Drawing.Point(882, 95);
            this.buttonCNICPictureFront.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCNICPictureFront.Name = "buttonCNICPictureFront";
            this.buttonCNICPictureFront.Size = new System.Drawing.Size(63, 23);
            this.buttonCNICPictureFront.TabIndex = 46;
            this.buttonCNICPictureFront.Text = "Upload";
            this.buttonCNICPictureFront.UseVisualStyleBackColor = false;
            this.buttonCNICPictureFront.Click += new System.EventHandler(this.buttonCNICPictureFront_Click);
            // 
            // pictureBoxCNICfront
            // 
            this.pictureBoxCNICfront.BackColor = System.Drawing.Color.White;
            this.pictureBoxCNICfront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCNICfront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCNICfront.Location = new System.Drawing.Point(642, 118);
            this.pictureBoxCNICfront.Name = "pictureBoxCNICfront";
            this.pictureBoxCNICfront.Size = new System.Drawing.Size(303, 171);
            this.pictureBoxCNICfront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCNICfront.TabIndex = 47;
            this.pictureBoxCNICfront.TabStop = false;
            this.pictureBoxCNICfront.Tag = "User Photograph";
            // 
            // labelCNICPictureBack
            // 
            this.labelCNICPictureBack.AutoSize = true;
            this.labelCNICPictureBack.BackColor = System.Drawing.Color.White;
            this.labelCNICPictureBack.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNICPictureBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelCNICPictureBack.Location = new System.Drawing.Point(639, 299);
            this.labelCNICPictureBack.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCNICPictureBack.Name = "labelCNICPictureBack";
            this.labelCNICPictureBack.Size = new System.Drawing.Size(118, 13);
            this.labelCNICPictureBack.TabIndex = 48;
            this.labelCNICPictureBack.Text = "User CNIC Picture Back";
            // 
            // buttonCNICPictureBack
            // 
            this.buttonCNICPictureBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCNICPictureBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.buttonCNICPictureBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCNICPictureBack.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCNICPictureBack.ForeColor = System.Drawing.Color.White;
            this.buttonCNICPictureBack.Location = new System.Drawing.Point(882, 295);
            this.buttonCNICPictureBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCNICPictureBack.Name = "buttonCNICPictureBack";
            this.buttonCNICPictureBack.Size = new System.Drawing.Size(63, 23);
            this.buttonCNICPictureBack.TabIndex = 49;
            this.buttonCNICPictureBack.Text = "Upload";
            this.buttonCNICPictureBack.UseVisualStyleBackColor = false;
            this.buttonCNICPictureBack.Click += new System.EventHandler(this.buttonCNICPictureBack_Click);
            // 
            // pictureBoxCNICPictureBack
            // 
            this.pictureBoxCNICPictureBack.BackColor = System.Drawing.Color.White;
            this.pictureBoxCNICPictureBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCNICPictureBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCNICPictureBack.Location = new System.Drawing.Point(642, 315);
            this.pictureBoxCNICPictureBack.Name = "pictureBoxCNICPictureBack";
            this.pictureBoxCNICPictureBack.Size = new System.Drawing.Size(303, 171);
            this.pictureBoxCNICPictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCNICPictureBack.TabIndex = 50;
            this.pictureBoxCNICPictureBack.TabStop = false;
            this.pictureBoxCNICPictureBack.Tag = "User Photograph";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(441, 585);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(97, 43);
            this.buttonNext.TabIndex = 51;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.buttonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinish.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.ForeColor = System.Drawing.Color.White;
            this.buttonFinish.Location = new System.Drawing.Point(622, 585);
            this.buttonFinish.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(97, 43);
            this.buttonFinish.TabIndex = 52;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = false;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // textBoxCNICPicturePathBack
            // 
            this.textBoxCNICPicturePathBack.BackColor = System.Drawing.Color.White;
            this.textBoxCNICPicturePathBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCNICPicturePathBack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCNICPicturePathBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBoxCNICPicturePathBack.Location = new System.Drawing.Point(240, 328);
            this.textBoxCNICPicturePathBack.Name = "textBoxCNICPicturePathBack";
            this.textBoxCNICPicturePathBack.ReadOnly = true;
            this.textBoxCNICPicturePathBack.Size = new System.Drawing.Size(396, 23);
            this.textBoxCNICPicturePathBack.TabIndex = 53;
            // 
            // labelUserCNICPathBack
            // 
            this.labelUserCNICPathBack.AutoSize = true;
            this.labelUserCNICPathBack.BackColor = System.Drawing.Color.White;
            this.labelUserCNICPathBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelUserCNICPathBack.Location = new System.Drawing.Point(69, 328);
            this.labelUserCNICPathBack.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUserCNICPathBack.Name = "labelUserCNICPathBack";
            this.labelUserCNICPathBack.Size = new System.Drawing.Size(163, 25);
            this.labelUserCNICPathBack.TabIndex = 54;
            this.labelUserCNICPathBack.Text = "CNIC Picture Back:";
            this.labelUserCNICPathBack.UseCompatibleTextRendering = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 738);
            this.Controls.Add(this.labelUserCNICPathBack);
            this.Controls.Add(this.textBoxCNICPicturePathBack);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBoxCNICPictureBack);
            this.Controls.Add(this.buttonCNICPictureBack);
            this.Controls.Add(this.labelCNICPictureBack);
            this.Controls.Add(this.pictureBoxCNICfront);
            this.Controls.Add(this.buttonCNICPictureFront);
            this.Controls.Add(this.labelCNICPhotoFront);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUploadUserPhoto);
            this.Controls.Add(this.pictureBoxUserPhoto);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxUserCNIC);
            this.Controls.Add(this.textBoxUserAccountOpeningDateandTime);
            this.Controls.Add(this.textBoxUserLocation);
            this.Controls.Add(this.textBoxUserPosition);
            this.Controls.Add(this.textBoxUserCNICPicturePath);
            this.Controls.Add(this.textBoxUserPhotoPath);
            this.Controls.Add(this.labelUserData);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.labelOpeningDate);
            this.Controls.Add(this.labelUserLocation);
            this.Controls.Add(this.labelUserPosition);
            this.Controls.Add(this.labelUserCNICPath);
            this.Controls.Add(this.labelCNIC);
            this.Controls.Add(this.labelUserPhoto);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelUserID);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddUser";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "New User Data Entry";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormAddUserData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCNICfront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCNICPictureBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserPhoto;
        private System.Windows.Forms.Label labelCNIC;
        private System.Windows.Forms.Label labelUserCNICPath;
        private System.Windows.Forms.Label labelUserPosition;
        private System.Windows.Forms.Label labelUserLocation;
        private System.Windows.Forms.Label labelOpeningDate;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label labelUserData;
        private System.Windows.Forms.TextBox textBoxUserPhotoPath;
        private System.Windows.Forms.TextBox textBoxUserCNICPicturePath;
        private System.Windows.Forms.TextBox textBoxUserPosition;
        private System.Windows.Forms.TextBox textBoxUserLocation;
        private System.Windows.Forms.TextBox textBoxUserAccountOpeningDateandTime;
        private System.Windows.Forms.MaskedTextBox textBoxUserCNIC;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.PictureBox pictureBoxUserPhoto;
        private System.Windows.Forms.Button buttonUploadUserPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCNICPhotoFront;
        private System.Windows.Forms.Button buttonCNICPictureFront;
        private System.Windows.Forms.PictureBox pictureBoxCNICfront;
        private System.Windows.Forms.Label labelCNICPictureBack;
        private System.Windows.Forms.Button buttonCNICPictureBack;
        private System.Windows.Forms.PictureBox pictureBoxCNICPictureBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.TextBox textBoxCNICPicturePathBack;
        private System.Windows.Forms.Label labelUserCNICPathBack;
    }
}