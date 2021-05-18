namespace Hisaab_Kitaab
{
    partial class Choose_CLCA
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selected_Current_Assets = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CurrentAssests_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentAssets_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.checkBox_SelectAll = new System.Windows.Forms.CheckBox();
            this.label_SingleEntryBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected_Current_Assets,
            this.CurrentAssests_Code,
            this.CurrentAssets_Title});
            this.dataGridView1.Location = new System.Drawing.Point(25, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(751, 469);
            this.dataGridView1.TabIndex = 0;
            // 
            // Selected_Current_Assets
            // 
            this.Selected_Current_Assets.HeaderText = "Choose";
            this.Selected_Current_Assets.Name = "Selected_Current_Assets";
            // 
            // CurrentAssests_Code
            // 
            this.CurrentAssests_Code.DataPropertyName = "ACCHEAD_ID";
            this.CurrentAssests_Code.HeaderText = "Account Code";
            this.CurrentAssests_Code.Name = "CurrentAssests_Code";
            // 
            // CurrentAssets_Title
            // 
            this.CurrentAssets_Title.DataPropertyName = "ACCHEAD_NAME";
            this.CurrentAssets_Title.HeaderText = "Account Title";
            this.CurrentAssets_Title.Name = "CurrentAssets_Title";
            // 
            // Button_Ok
            // 
            this.Button_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.Button_Ok.FlatAppearance.BorderSize = 0;
            this.Button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Ok.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Ok.ForeColor = System.Drawing.Color.White;
            this.Button_Ok.Location = new System.Drawing.Point(336, 623);
            this.Button_Ok.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(151, 47);
            this.Button_Ok.TabIndex = 30;
            this.Button_Ok.Text = "OK";
            this.Button_Ok.UseVisualStyleBackColor = false;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // checkBox_SelectAll
            // 
            this.checkBox_SelectAll.AutoSize = true;
            this.checkBox_SelectAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SelectAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.checkBox_SelectAll.Location = new System.Drawing.Point(25, 93);
            this.checkBox_SelectAll.Name = "checkBox_SelectAll";
            this.checkBox_SelectAll.Size = new System.Drawing.Size(114, 28);
            this.checkBox_SelectAll.TabIndex = 31;
            this.checkBox_SelectAll.Text = "Select All";
            this.checkBox_SelectAll.UseVisualStyleBackColor = true;
            this.checkBox_SelectAll.CheckedChanged += new System.EventHandler(this.checkBox_SelectAll_CheckedChanged);
            this.checkBox_SelectAll.CheckStateChanged += new System.EventHandler(this.checkBox_SelectAll_CheckStateChanged);
            // 
            // label_SingleEntryBook
            // 
            this.label_SingleEntryBook.AutoSize = true;
            this.label_SingleEntryBook.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SingleEntryBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_SingleEntryBook.Location = new System.Drawing.Point(262, 30);
            this.label_SingleEntryBook.Name = "label_SingleEntryBook";
            this.label_SingleEntryBook.Size = new System.Drawing.Size(266, 29);
            this.label_SingleEntryBook.TabIndex = 36;
            this.label_SingleEntryBook.Text = "Select Current Assets";
            // 
            // Choose_CLCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.label_SingleEntryBook);
            this.Controls.Add(this.checkBox_SelectAll);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Choose_CLCA";
            this.Text = "Choose_CurrentAssets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected_Current_Assets;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentAssests_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentAssets_Title;
        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.CheckBox checkBox_SelectAll;
        private System.Windows.Forms.Label label_SingleEntryBook;
    }
}