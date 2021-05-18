namespace Hisaab_Kitaab
{
    partial class List_Account_Head_Opening_Balances
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
            this.label_Dep = new System.Windows.Forms.Label();
            this.dataGridView_OpeningBal = new System.Windows.Forms.DataGridView();
            this.button_Add = new System.Windows.Forms.Button();
            this.ACCHEAD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNTHEAD_TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OpeningBal)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Dep
            // 
            this.label_Dep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Dep.AutoSize = true;
            this.label_Dep.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Dep.Location = new System.Drawing.Point(199, 25);
            this.label_Dep.Name = "label_Dep";
            this.label_Dep.Size = new System.Drawing.Size(396, 29);
            this.label_Dep.TabIndex = 117;
            this.label_Dep.Text = "Account Head Opening Balances";
            // 
            // dataGridView_OpeningBal
            // 
            this.dataGridView_OpeningBal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_OpeningBal.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_OpeningBal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OpeningBal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACCHEAD_ID,
            this.ACCOUNTHEAD_TITLE,
            this.Debit,
            this.Credit});
            this.dataGridView_OpeningBal.Location = new System.Drawing.Point(46, 88);
            this.dataGridView_OpeningBal.Name = "dataGridView_OpeningBal";
            this.dataGridView_OpeningBal.RowTemplate.Height = 24;
            this.dataGridView_OpeningBal.Size = new System.Drawing.Size(659, 503);
            this.dataGridView_OpeningBal.TabIndex = 118;
            // 
            // button_Add
            // 
            this.button_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(270, 610);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(192, 44);
            this.button_Add.TabIndex = 119;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // ACCHEAD_ID
            // 
            this.ACCHEAD_ID.DataPropertyName = "Account Code";
            this.ACCHEAD_ID.HeaderText = "Account Code";
            this.ACCHEAD_ID.Name = "ACCHEAD_ID";
            // 
            // ACCOUNTHEAD_TITLE
            // 
            this.ACCOUNTHEAD_TITLE.DataPropertyName = "Account Title";
            this.ACCOUNTHEAD_TITLE.DividerWidth = 1;
            this.ACCOUNTHEAD_TITLE.HeaderText = "Account Title";
            this.ACCOUNTHEAD_TITLE.Name = "ACCOUNTHEAD_TITLE";
            // 
            // Debit
            // 
            this.Debit.DataPropertyName = "Debit";
            this.Debit.DividerWidth = 1;
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            // 
            // List_Account_Head_Opening_Balances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 693);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_OpeningBal);
            this.Controls.Add(this.label_Dep);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.Name = "List_Account_Head_Opening_Balances";
            this.Text = "List_Account_Head_Opening_Balances";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OpeningBal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Dep;
        private System.Windows.Forms.DataGridView dataGridView_OpeningBal;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCHEAD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNTHEAD_TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
    }
}