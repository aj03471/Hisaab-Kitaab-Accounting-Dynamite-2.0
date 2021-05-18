namespace UserSecurity
{
    partial class ListUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUsers));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_Userrecord = new System.Windows.Forms.DataGridView();
            this.RightsButton = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label_Logintime = new System.Windows.Forms.Label();
            this.label_Loginuser = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Userrecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.logToolStripMenuItem,
            this.databasesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // listUsersToolStripMenuItem
            // 
            this.listUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.listUsersToolStripMenuItem.Name = "listUsersToolStripMenuItem";
            this.listUsersToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.listUsersToolStripMenuItem.Text = "List Users";
            this.listUsersToolStripMenuItem.Click += new System.EventHandler(this.listUsersToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // databasesToolStripMenuItem
            // 
            this.databasesToolStripMenuItem.Name = "databasesToolStripMenuItem";
            this.databasesToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.databasesToolStripMenuItem.Text = "Databases";
            this.databasesToolStripMenuItem.Click += new System.EventHandler(this.databasesToolStripMenuItem_Click);
            // 
            // dataGridView_Userrecord
            // 
            this.dataGridView_Userrecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Userrecord.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Userrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Userrecord.EnableHeadersVisualStyles = false;
            this.dataGridView_Userrecord.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Userrecord.Location = new System.Drawing.Point(94, 94);
            this.dataGridView_Userrecord.Name = "dataGridView_Userrecord";
            this.dataGridView_Userrecord.Size = new System.Drawing.Size(839, 576);
            this.dataGridView_Userrecord.TabIndex = 3;
            this.dataGridView_Userrecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // RightsButton
            // 
            this.RightsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RightsButton.BackColor = System.Drawing.SystemColors.Window;
            this.RightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightsButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.RightsButton.Location = new System.Drawing.Point(653, 685);
            this.RightsButton.Name = "RightsButton";
            this.RightsButton.Size = new System.Drawing.Size(118, 40);
            this.RightsButton.TabIndex = 5;
            this.RightsButton.Text = "Rights";
            this.RightsButton.UseVisualStyleBackColor = false;
            this.RightsButton.Click += new System.EventHandler(this.RightsButton_Click_1);
            // 
            // button_Print
            // 
            this.button_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Print.BackColor = System.Drawing.SystemColors.Window;
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button_Print.Location = new System.Drawing.Point(813, 685);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(118, 40);
            this.button_Print.TabIndex = 6;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.SystemColors.Window;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button_Back.Location = new System.Drawing.Point(12, 36);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(83, 28);
            this.button_Back.TabIndex = 7;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // label_Logintime
            // 
            this.label_Logintime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Logintime.AutoSize = true;
            this.label_Logintime.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label_Logintime.Location = new System.Drawing.Point(849, 65);
            this.label_Logintime.Name = "label_Logintime";
            this.label_Logintime.Size = new System.Drawing.Size(52, 14);
            this.label_Logintime.TabIndex = 35;
            this.label_Logintime.Text = "1:18 am";
            // 
            // label_Loginuser
            // 
            this.label_Loginuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Loginuser.AutoSize = true;
            this.label_Loginuser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_Loginuser.Location = new System.Drawing.Point(900, 33);
            this.label_Loginuser.Name = "label_Loginuser";
            this.label_Loginuser.Size = new System.Drawing.Size(103, 19);
            this.label_Loginuser.TabIndex = 34;
            this.label_Loginuser.Text = "Hasan Haider";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::UserSecurity.Properties.Resources.profile_icon_png_black;
            this.pictureBox5.Location = new System.Drawing.Point(852, 27);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // ListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1029, 749);
            this.Controls.Add(this.label_Logintime);
            this.Controls.Add(this.label_Loginuser);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.RightsButton);
            this.Controls.Add(this.dataGridView_Userrecord);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ListUsers";
            this.Text = "ListUsers";
            this.Load += new System.EventHandler(this.ListUsers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Userrecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_Userrecord;
        private System.Windows.Forms.Button RightsButton;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label_Logintime;
        private System.Windows.Forms.Label label_Loginuser;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
    }
}