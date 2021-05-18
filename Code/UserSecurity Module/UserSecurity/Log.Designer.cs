namespace UserSecurity
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button_Print = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridView_Login = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogintoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Logs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_Log = new System.Windows.Forms.DataGridView();
            this.comboBox_SelectUser = new System.Windows.Forms.ComboBox();
            this.label_SelectUser = new System.Windows.Forms.Label();
            this.Button_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Login)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl_Logs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Log)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Print
            // 
            this.button_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Print.BackColor = System.Drawing.SystemColors.Window;
            this.button_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button_Print.Location = new System.Drawing.Point(735, 689);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(146, 48);
            this.button_Print.TabIndex = 4;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
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
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(806, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "1:18 am";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(872, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 37;
            this.label1.Text = "Hasan Haider";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::UserSecurity.Properties.Resources.profile_icon_png_black;
            this.pictureBox5.Location = new System.Drawing.Point(809, 39);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // dataGridView_Login
            // 
            this.dataGridView_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Login.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Login.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Login.Location = new System.Drawing.Point(1, 3);
            this.dataGridView_Login.Name = "dataGridView_Login";
            this.dataGridView_Login.Size = new System.Drawing.Size(830, 554);
            this.dataGridView_Login.TabIndex = 40;
            this.dataGridView_Login.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Login_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usertoolStripMenuItem,
            this.userLogintoolStripMenuItem,
            this.databasesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 25);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usertoolStripMenuItem
            // 
            this.usertoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listUsersToolStripMenuItem});
            this.usertoolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.usertoolStripMenuItem.Name = "usertoolStripMenuItem";
            this.usertoolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.usertoolStripMenuItem.Text = "Users";
            this.usertoolStripMenuItem.Click += new System.EventHandler(this.usertoolStripMenuItem_Click);
            // 
            // listUsersToolStripMenuItem
            // 
            this.listUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.listUsersToolStripMenuItem.Name = "listUsersToolStripMenuItem";
            this.listUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listUsersToolStripMenuItem.Text = "List Users";
            this.listUsersToolStripMenuItem.Click += new System.EventHandler(this.listUsersToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // userLogintoolStripMenuItem
            // 
            this.userLogintoolStripMenuItem.Name = "userLogintoolStripMenuItem";
            this.userLogintoolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.userLogintoolStripMenuItem.Text = "Log";
            this.userLogintoolStripMenuItem.Click += new System.EventHandler(this.userLoginToolStripMenuItem_Click);
            // 
            // databasesToolStripMenuItem
            // 
            this.databasesToolStripMenuItem.Name = "databasesToolStripMenuItem";
            this.databasesToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.databasesToolStripMenuItem.Text = "Databases";
            this.databasesToolStripMenuItem.Click += new System.EventHandler(this.databasesToolStripMenuItem_Click);
            // 
            // tabControl_Logs
            // 
            this.tabControl_Logs.Controls.Add(this.tabPage1);
            this.tabControl_Logs.Controls.Add(this.tabPage2);
            this.tabControl_Logs.Location = new System.Drawing.Point(51, 90);
            this.tabControl_Logs.Name = "tabControl_Logs";
            this.tabControl_Logs.SelectedIndex = 0;
            this.tabControl_Logs.Size = new System.Drawing.Size(839, 580);
            this.tabControl_Logs.TabIndex = 42;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_Login);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_Log);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Log
            // 
            this.dataGridView_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Log.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Log.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Log.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Log.Name = "dataGridView_Log";
            this.dataGridView_Log.Size = new System.Drawing.Size(831, 558);
            this.dataGridView_Log.TabIndex = 49;
            // 
            // comboBox_SelectUser
            // 
            this.comboBox_SelectUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBox_SelectUser.FormattingEnabled = true;
            this.comboBox_SelectUser.Location = new System.Drawing.Point(158, 47);
            this.comboBox_SelectUser.Name = "comboBox_SelectUser";
            this.comboBox_SelectUser.Size = new System.Drawing.Size(179, 27);
            this.comboBox_SelectUser.TabIndex = 57;
            // 
            // label_SelectUser
            // 
            this.label_SelectUser.AutoSize = true;
            this.label_SelectUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectUser.Location = new System.Drawing.Point(51, 50);
            this.label_SelectUser.Name = "label_SelectUser";
            this.label_SelectUser.Size = new System.Drawing.Size(107, 19);
            this.label_SelectUser.TabIndex = 58;
            this.label_SelectUser.Text = "Select User:";
            // 
            // Button_Search
            // 
            this.Button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Search.FlatAppearance.BorderSize = 0;
            this.Button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Search.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Search.Location = new System.Drawing.Point(383, 47);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(114, 30);
            this.Button_Search.TabIndex = 59;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1029, 749);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.label_SelectUser);
            this.Controls.Add(this.comboBox_SelectUser);
            this.Controls.Add(this.tabControl_Logs);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button_Print);
            this.Name = "Log";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Login)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl_Logs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridView_Login;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usertoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLogintoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_Logs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_Log;
        private System.Windows.Forms.ComboBox comboBox_SelectUser;
        private System.Windows.Forms.Label label_SelectUser;
        private System.Windows.Forms.Button Button_Search;
    }
}