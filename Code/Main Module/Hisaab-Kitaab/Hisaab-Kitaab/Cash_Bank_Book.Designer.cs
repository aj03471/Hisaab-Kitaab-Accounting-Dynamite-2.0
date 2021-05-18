namespace Hisaab_Kitaab
{
    partial class Cash_Bank_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cash_Bank_Book));
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTaxAccount = new System.Windows.Forms.Label();
            this.labelAccountHead = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewOtherBooks = new System.Windows.Forms.DataGridView();
            this.voucherNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountHeadID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtherBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelDate.Location = new System.Drawing.Point(43, 161);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(64, 24);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Date:";
            // 
            // labelTaxAccount
            // 
            this.labelTaxAccount.AutoSize = true;
            this.labelTaxAccount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelTaxAccount.Location = new System.Drawing.Point(598, 111);
            this.labelTaxAccount.Name = "labelTaxAccount";
            this.labelTaxAccount.Size = new System.Drawing.Size(141, 24);
            this.labelTaxAccount.TabIndex = 12;
            this.labelTaxAccount.Text = "Tax Account:";
            // 
            // labelAccountHead
            // 
            this.labelAccountHead.AutoSize = true;
            this.labelAccountHead.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelAccountHead.Location = new System.Drawing.Point(13, 111);
            this.labelAccountHead.Name = "labelAccountHead";
            this.labelAccountHead.Size = new System.Drawing.Size(99, 24);
            this.labelAccountHead.TabIndex = 11;
            this.labelAccountHead.Text = "Account:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(775, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(220, 31);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 31);
            this.comboBox1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dataGridViewOtherBooks
            // 
            this.dataGridViewOtherBooks.AllowUserToResizeRows = false;
            this.dataGridViewOtherBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOtherBooks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOtherBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewOtherBooks.ColumnHeadersHeight = 45;
            this.dataGridViewOtherBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voucherNumber,
            this.AccountHeadID,
            this.Particulars,
            this.Debit,
            this.Credit});
            this.dataGridViewOtherBooks.EnableHeadersVisualStyles = false;
            this.dataGridViewOtherBooks.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewOtherBooks.Location = new System.Drawing.Point(16, 212);
            this.dataGridViewOtherBooks.Name = "dataGridViewOtherBooks";
            this.dataGridViewOtherBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewOtherBooks.RowHeadersWidth = 30;
            this.dataGridViewOtherBooks.RowTemplate.Height = 30;
            this.dataGridViewOtherBooks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOtherBooks.Size = new System.Drawing.Size(979, 509);
            this.dataGridViewOtherBooks.TabIndex = 14;
            // 
            // voucherNumber
            // 
            this.voucherNumber.HeaderText = "Voucher #";
            this.voucherNumber.Name = "voucherNumber";
            // 
            // AccountHeadID
            // 
            this.AccountHeadID.HeaderText = "Account Number";
            this.AccountHeadID.Name = "AccountHeadID";
            // 
            // Particulars
            // 
            this.Particulars.HeaderText = "Particulars";
            this.Particulars.Name = "Particulars";
            // 
            // Debit
            // 
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(406, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Single Entry Book";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(844, 739);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(151, 47);
            this.button_Add.TabIndex = 35;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            // 
            // Cash_Bank_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 961);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOtherBooks);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTaxAccount);
            this.Controls.Add(this.labelAccountHead);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cash_Bank_Book";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtherBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTaxAccount;
        private System.Windows.Forms.Label labelAccountHead;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewOtherBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn AccountHeadID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Add;
    }
}