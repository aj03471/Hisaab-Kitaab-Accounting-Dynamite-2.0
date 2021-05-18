namespace Hisaab_Kitaab
{
    partial class Purchase_Bill_Approval
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Purchase_Bill_Approval = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Debit_Note_Number = new System.Windows.Forms.Label();
            this.label_Dispatched_By = new System.Windows.Forms.Label();
            this.textBox_PBillNo = new System.Windows.Forms.TextBox();
            this.textBox_Approved_By = new System.Windows.Forms.TextBox();
            this.label_Approved_By = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Accepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_Purchase_Bill_Approval = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adS_2DataSet1 = new Hisaab_Kitaab.ADS_2DataSet();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_TermsCond = new System.Windows.Forms.GroupBox();
            this.textBox_TnC = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.groupBox_Supplier = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Due = new System.Windows.Forms.DateTimePicker();
            this.label_Total_Amount = new System.Windows.Forms.Label();
            this.textBox_Total_Amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_AmountWords = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Purchase_Bill_Approval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adS_2DataSet1)).BeginInit();
            this.groupBox_TermsCond.SuspendLayout();
            this.groupBox_Supplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Purchase_Bill_Approval
            // 
            this.label_Purchase_Bill_Approval.AutoSize = true;
            this.label_Purchase_Bill_Approval.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Purchase_Bill_Approval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Purchase_Bill_Approval.Location = new System.Drawing.Point(279, 18);
            this.label_Purchase_Bill_Approval.Name = "label_Purchase_Bill_Approval";
            this.label_Purchase_Bill_Approval.Size = new System.Drawing.Size(224, 23);
            this.label_Purchase_Bill_Approval.TabIndex = 25;
            this.label_Purchase_Bill_Approval.Text = "Purchase Bill Approval";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Date.Location = new System.Drawing.Point(413, 97);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(54, 19);
            this.label_Date.TabIndex = 27;
            this.label_Date.Text = "Date:";
            // 
            // label_Debit_Note_Number
            // 
            this.label_Debit_Note_Number.AutoSize = true;
            this.label_Debit_Note_Number.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Debit_Note_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Debit_Note_Number.Location = new System.Drawing.Point(329, 134);
            this.label_Debit_Note_Number.Name = "label_Debit_Note_Number";
            this.label_Debit_Note_Number.Size = new System.Drawing.Size(138, 19);
            this.label_Debit_Note_Number.TabIndex = 28;
            this.label_Debit_Note_Number.Text = "Purchase Bill #:";
            // 
            // label_Dispatched_By
            // 
            this.label_Dispatched_By.AutoSize = true;
            this.label_Dispatched_By.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dispatched_By.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Dispatched_By.Location = new System.Drawing.Point(376, 174);
            this.label_Dispatched_By.Name = "label_Dispatched_By";
            this.label_Dispatched_By.Size = new System.Drawing.Size(91, 19);
            this.label_Dispatched_By.TabIndex = 29;
            this.label_Dispatched_By.Text = "Due Date:";
            // 
            // textBox_PBillNo
            // 
            this.textBox_PBillNo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PBillNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_PBillNo.Location = new System.Drawing.Point(488, 133);
            this.textBox_PBillNo.Name = "textBox_PBillNo";
            this.textBox_PBillNo.Size = new System.Drawing.Size(234, 25);
            this.textBox_PBillNo.TabIndex = 30;
            // 
            // textBox_Approved_By
            // 
            this.textBox_Approved_By.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Approved_By.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Approved_By.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_Approved_By.Location = new System.Drawing.Point(488, 675);
            this.textBox_Approved_By.Name = "textBox_Approved_By";
            this.textBox_Approved_By.Size = new System.Drawing.Size(234, 27);
            this.textBox_Approved_By.TabIndex = 35;
            // 
            // label_Approved_By
            // 
            this.label_Approved_By.AutoSize = true;
            this.label_Approved_By.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Approved_By.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Approved_By.Location = new System.Drawing.Point(484, 705);
            this.label_Approved_By.Name = "label_Approved_By";
            this.label_Approved_By.Size = new System.Drawing.Size(111, 19);
            this.label_Approved_By.TabIndex = 36;
            this.label_Approved_By.Text = "Approved by";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Date.CustomFormat = "    dd-MMMM-yyyy";
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(488, 93);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(234, 25);
            this.dateTimePicker_Date.TabIndex = 37;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // Quantity_Accepted
            // 
            this.Quantity_Accepted.HeaderText = "Quantity Accepted";
            this.Quantity_Accepted.Name = "Quantity_Accepted";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item Code";
            this.Item.Name = "Item";
            // 
            // GRN
            // 
            this.GRN.HeaderText = "GRN #";
            this.GRN.Name = "GRN";
            // 
            // Serial_Number
            // 
            this.Serial_Number.HeaderText = "S.No";
            this.Serial_Number.Name = "Serial_Number";
            // 
            // dataGridView_Purchase_Bill_Approval
            // 
            this.dataGridView_Purchase_Bill_Approval.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Purchase_Bill_Approval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Purchase_Bill_Approval.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Purchase_Bill_Approval.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Purchase_Bill_Approval.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Purchase_Bill_Approval.ColumnHeadersHeight = 41;
            this.dataGridView_Purchase_Bill_Approval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial_Number,
            this.GRN,
            this.Item,
            this.Description,
            this.Quantity_Accepted,
            this.Rate,
            this.Column1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Purchase_Bill_Approval.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Purchase_Bill_Approval.EnableHeadersVisualStyles = false;
            this.dataGridView_Purchase_Bill_Approval.GridColor = System.Drawing.Color.White;
            this.dataGridView_Purchase_Bill_Approval.Location = new System.Drawing.Point(26, 230);
            this.dataGridView_Purchase_Bill_Approval.Name = "dataGridView_Purchase_Bill_Approval";
            this.dataGridView_Purchase_Bill_Approval.Size = new System.Drawing.Size(696, 249);
            this.dataGridView_Purchase_Bill_Approval.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Amount";
            this.Column1.Name = "Column1";
            // 
            // adS_2DataSet1
            // 
            this.adS_2DataSet1.DataSetName = "ADS_2DataSet";
            this.adS_2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 118;
            // 
            // groupBox_TermsCond
            // 
            this.groupBox_TermsCond.Controls.Add(this.textBox_TnC);
            this.groupBox_TermsCond.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TermsCond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.groupBox_TermsCond.Location = new System.Drawing.Point(26, 531);
            this.groupBox_TermsCond.Name = "groupBox_TermsCond";
            this.groupBox_TermsCond.Size = new System.Drawing.Size(696, 122);
            this.groupBox_TermsCond.TabIndex = 43;
            this.groupBox_TermsCond.TabStop = false;
            this.groupBox_TermsCond.Text = "Terms and Conditions";
            // 
            // textBox_TnC
            // 
            this.textBox_TnC.BackColor = System.Drawing.Color.White;
            this.textBox_TnC.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_TnC.Location = new System.Drawing.Point(9, 20);
            this.textBox_TnC.Multiline = true;
            this.textBox_TnC.Name = "textBox_TnC";
            this.textBox_TnC.ReadOnly = true;
            this.textBox_TnC.Size = new System.Drawing.Size(681, 96);
            this.textBox_TnC.TabIndex = 40;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(35, 675);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(151, 47);
            this.button_Save.TabIndex = 44;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.BackColor = System.Drawing.Color.White;
            this.textBox_Supplier.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_Supplier.Location = new System.Drawing.Point(6, 22);
            this.textBox_Supplier.Multiline = true;
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.ReadOnly = true;
            this.textBox_Supplier.Size = new System.Drawing.Size(256, 119);
            this.textBox_Supplier.TabIndex = 39;
            // 
            // groupBox_Supplier
            // 
            this.groupBox_Supplier.Controls.Add(this.textBox_Supplier);
            this.groupBox_Supplier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.groupBox_Supplier.Location = new System.Drawing.Point(26, 63);
            this.groupBox_Supplier.Name = "groupBox_Supplier";
            this.groupBox_Supplier.Size = new System.Drawing.Size(271, 151);
            this.groupBox_Supplier.TabIndex = 45;
            this.groupBox_Supplier.TabStop = false;
            this.groupBox_Supplier.Text = "Supplier:";
            // 
            // dateTimePicker_Due
            // 
            this.dateTimePicker_Due.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Due.CustomFormat = "    dd-MMMM-yyyy";
            this.dateTimePicker_Due.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Due.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Due.Location = new System.Drawing.Point(488, 170);
            this.dateTimePicker_Due.Name = "dateTimePicker_Due";
            this.dateTimePicker_Due.Size = new System.Drawing.Size(234, 25);
            this.dateTimePicker_Due.TabIndex = 46;
            // 
            // label_Total_Amount
            // 
            this.label_Total_Amount.AutoSize = true;
            this.label_Total_Amount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_Total_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Total_Amount.Location = new System.Drawing.Point(450, 494);
            this.label_Total_Amount.Name = "label_Total_Amount";
            this.label_Total_Amount.Size = new System.Drawing.Size(127, 19);
            this.label_Total_Amount.TabIndex = 41;
            this.label_Total_Amount.Text = "Total Amount:";
            // 
            // textBox_Total_Amount
            // 
            this.textBox_Total_Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Total_Amount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Total_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_Total_Amount.Location = new System.Drawing.Point(583, 493);
            this.textBox_Total_Amount.Name = "textBox_Total_Amount";
            this.textBox_Total_Amount.Size = new System.Drawing.Size(139, 20);
            this.textBox_Total_Amount.TabIndex = 41;
            this.textBox_Total_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(28, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Amount in Words:";
            // 
            // textBox_AmountWords
            // 
            this.textBox_AmountWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AmountWords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AmountWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_AmountWords.Location = new System.Drawing.Point(183, 493);
            this.textBox_AmountWords.Name = "textBox_AmountWords";
            this.textBox_AmountWords.Size = new System.Drawing.Size(216, 20);
            this.textBox_AmountWords.TabIndex = 48;
            this.textBox_AmountWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Purchase_Bill_Approval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 749);
            this.Controls.Add(this.textBox_AmountWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Total_Amount);
            this.Controls.Add(this.label_Total_Amount);
            this.Controls.Add(this.dateTimePicker_Due);
            this.Controls.Add(this.groupBox_Supplier);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.groupBox_TermsCond);
            this.Controls.Add(this.dataGridView_Purchase_Bill_Approval);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.label_Approved_By);
            this.Controls.Add(this.textBox_Approved_By);
            this.Controls.Add(this.textBox_PBillNo);
            this.Controls.Add(this.label_Dispatched_By);
            this.Controls.Add(this.label_Debit_Note_Number);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Purchase_Bill_Approval);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Purchase_Bill_Approval";
            this.ShowIcon = false;
            this.Text = "Purchase_Bill_Approval";
            this.Load += new System.EventHandler(this.Purchase_Bill_Approval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Purchase_Bill_Approval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adS_2DataSet1)).EndInit();
            this.groupBox_TermsCond.ResumeLayout(false);
            this.groupBox_TermsCond.PerformLayout();
            this.groupBox_Supplier.ResumeLayout(false);
            this.groupBox_Supplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Purchase_Bill_Approval;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Debit_Note_Number;
        private System.Windows.Forms.Label label_Dispatched_By;
        private System.Windows.Forms.TextBox textBox_PBillNo;
        private System.Windows.Forms.TextBox textBox_Approved_By;
        private System.Windows.Forms.Label label_Approved_By;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Accepted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_Number;
        private System.Windows.Forms.DataGridView dataGridView_Purchase_Bill_Approval;
        private ADS_2DataSet adS_2DataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.GroupBox groupBox_TermsCond;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.GroupBox groupBox_Supplier;
        private System.Windows.Forms.TextBox textBox_TnC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Due;
        private System.Windows.Forms.Label label_Total_Amount;
        private System.Windows.Forms.TextBox textBox_Total_Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AmountWords;
    }
}