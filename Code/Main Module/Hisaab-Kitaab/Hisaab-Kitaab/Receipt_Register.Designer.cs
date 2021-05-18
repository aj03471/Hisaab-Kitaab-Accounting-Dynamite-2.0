namespace Hisaab_Kitaab
{
    partial class Receipt_Register
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt_Register));
            this.dataGridViewOtherBooks = new System.Windows.Forms.DataGridView();
            this.textBox_AccountTitle = new System.Windows.Forms.TextBox();
            this.textBox_AccCode = new System.Windows.Forms.TextBox();
            this.button_Details = new System.Windows.Forms.Button();
            this.labelHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountHeadID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtherBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOtherBooks
            // 
            this.dataGridViewOtherBooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dataGridViewOtherBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOtherBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOtherBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOtherBooks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOtherBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOtherBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOtherBooks.ColumnHeadersHeight = 45;
            this.dataGridViewOtherBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.TransactionNumber,
            this.voucherNumber,
            this.AccountHeadID,
            this.Particulars,
            this.Debit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOtherBooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOtherBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewOtherBooks.EnableHeadersVisualStyles = false;
            this.dataGridViewOtherBooks.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewOtherBooks.Location = new System.Drawing.Point(23, 212);
            this.dataGridViewOtherBooks.Name = "dataGridViewOtherBooks";
            this.dataGridViewOtherBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewOtherBooks.RowHeadersVisible = false;
            this.dataGridViewOtherBooks.RowHeadersWidth = 30;
            this.dataGridViewOtherBooks.RowTemplate.Height = 41;
            this.dataGridViewOtherBooks.RowTemplate.ReadOnly = true;
            this.dataGridViewOtherBooks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOtherBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOtherBooks.Size = new System.Drawing.Size(1049, 509);
            this.dataGridViewOtherBooks.TabIndex = 10;
            // 
            // textBox_AccountTitle
            // 
            this.textBox_AccountTitle.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AccountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_AccountTitle.Location = new System.Drawing.Point(383, 156);
            this.textBox_AccountTitle.Name = "textBox_AccountTitle";
            this.textBox_AccountTitle.ReadOnly = true;
            this.textBox_AccountTitle.Size = new System.Drawing.Size(526, 29);
            this.textBox_AccountTitle.TabIndex = 11;
            // 
            // textBox_AccCode
            // 
            this.textBox_AccCode.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AccCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_AccCode.Location = new System.Drawing.Point(383, 112);
            this.textBox_AccCode.Name = "textBox_AccCode";
            this.textBox_AccCode.ReadOnly = true;
            this.textBox_AccCode.Size = new System.Drawing.Size(526, 29);
            this.textBox_AccCode.TabIndex = 0;
            // 
            // button_Details
            // 
            this.button_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Details.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Details.ForeColor = System.Drawing.Color.White;
            this.button_Details.Location = new System.Drawing.Point(940, 750);
            this.button_Details.Name = "button_Details";
            this.button_Details.Size = new System.Drawing.Size(132, 40);
            this.button_Details.TabIndex = 14;
            this.button_Details.Text = "Details";
            this.button_Details.UseVisualStyleBackColor = false;
            // 
            // labelHeading
            // 
            this.labelHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelHeading.Location = new System.Drawing.Point(471, 27);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(209, 29);
            this.labelHeading.TabIndex = 13;
            this.labelHeading.Text = "Receipt Register";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(151, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Account Code:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(151, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Account Title:";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // TransactionNumber
            // 
            this.TransactionNumber.HeaderText = "Trans. #";
            this.TransactionNumber.Name = "TransactionNumber";
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
            this.AccountHeadID.ReadOnly = true;
            this.AccountHeadID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountHeadID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Particulars
            // 
            this.Particulars.HeaderText = "Particulars";
            this.Particulars.Name = "Particulars";
            // 
            // Debit
            // 
            this.Debit.HeaderText = "Amount";
            this.Debit.Name = "Debit";
            // 
            // Receipt_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 823);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_AccountTitle);
            this.Controls.Add(this.dataGridViewOtherBooks);
            this.Controls.Add(this.textBox_AccCode);
            this.Controls.Add(this.button_Details);
            this.Controls.Add(this.labelHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipt_Register";
            this.Text = "Receipt_Register";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtherBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOtherBooks;
        private System.Windows.Forms.TextBox textBox_AccountTitle;
        private System.Windows.Forms.TextBox textBox_AccCode;
        private System.Windows.Forms.Button button_Details;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountHeadID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
    }
}