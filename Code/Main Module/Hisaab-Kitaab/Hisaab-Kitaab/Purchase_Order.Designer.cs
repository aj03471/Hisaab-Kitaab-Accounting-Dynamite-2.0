namespace Hisaab_Kitaab
{
    partial class Purchase_Order
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
            this.label_Purchase_Order = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_PO_Number = new System.Windows.Forms.Label();
            this.label_Delivered_By = new System.Windows.Forms.Label();
            this.textBox_PO_Number = new System.Windows.Forms.TextBox();
            this.textBox_Delivered_BY = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_Purchase_Order = new System.Windows.Forms.DataGridView();
            this.adS_2DataSet1 = new Hisaab_Kitaab.ADS_2DataSet();
            this.textbox_Purchase_Ordered_By = new System.Windows.Forms.TextBox();
            this.label1_Purchase_Ordered_By = new System.Windows.Forms.Label();
            this.label_Total_Amount = new System.Windows.Forms.Label();
            this.textBox_Total_Amount = new System.Windows.Forms.TextBox();
            this.groupBox_Supplier = new System.Windows.Forms.GroupBox();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.groupBox_TermsCond = new System.Windows.Forms.GroupBox();
            this.textBox_TnC = new System.Windows.Forms.TextBox();
            this.textBox_Approved_By = new System.Windows.Forms.TextBox();
            this.label_Approved_By = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_AmountWords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Serial_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Purchase_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adS_2DataSet1)).BeginInit();
            this.groupBox_Supplier.SuspendLayout();
            this.groupBox_TermsCond.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Purchase_Order
            // 
            this.label_Purchase_Order.AutoSize = true;
            this.label_Purchase_Order.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label_Purchase_Order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Purchase_Order.Location = new System.Drawing.Point(381, 18);
            this.label_Purchase_Order.Name = "label_Purchase_Order";
            this.label_Purchase_Order.Size = new System.Drawing.Size(156, 23);
            this.label_Purchase_Order.TabIndex = 0;
            this.label_Purchase_Order.Text = "Purchase Order";
            this.label_Purchase_Order.Click += new System.EventHandler(this.label_Purchase_Bill_Approval_Click);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Date.Location = new System.Drawing.Point(548, 106);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(48, 19);
            this.label_Date.TabIndex = 2;
            this.label_Date.Text = "Date";
            // 
            // label_PO_Number
            // 
            this.label_PO_Number.AutoSize = true;
            this.label_PO_Number.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_PO_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_PO_Number.Location = new System.Drawing.Point(546, 159);
            this.label_PO_Number.Name = "label_PO_Number";
            this.label_PO_Number.Size = new System.Drawing.Size(50, 19);
            this.label_PO_Number.TabIndex = 3;
            this.label_PO_Number.Text = "PO #";
            // 
            // label_Delivered_By
            // 
            this.label_Delivered_By.AutoSize = true;
            this.label_Delivered_By.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_Delivered_By.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Delivered_By.Location = new System.Drawing.Point(484, 216);
            this.label_Delivered_By.Name = "label_Delivered_By";
            this.label_Delivered_By.Size = new System.Drawing.Size(112, 19);
            this.label_Delivered_By.TabIndex = 4;
            this.label_Delivered_By.Text = "Delivered By";
            // 
            // textBox_PO_Number
            // 
            this.textBox_PO_Number.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.textBox_PO_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_PO_Number.Location = new System.Drawing.Point(625, 160);
            this.textBox_PO_Number.Name = "textBox_PO_Number";
            this.textBox_PO_Number.Size = new System.Drawing.Size(234, 25);
            this.textBox_PO_Number.TabIndex = 6;
            // 
            // textBox_Delivered_BY
            // 
            this.textBox_Delivered_BY.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.textBox_Delivered_BY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_Delivered_BY.Location = new System.Drawing.Point(625, 216);
            this.textBox_Delivered_BY.Name = "textBox_Delivered_BY";
            this.textBox_Delivered_BY.Size = new System.Drawing.Size(234, 25);
            this.textBox_Delivered_BY.TabIndex = 7;
            this.textBox_Delivered_BY.TextChanged += new System.EventHandler(this.textBox_Delivered_BY_TextChanged);
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.dateTimePicker_Date.CustomFormat = "    dd-MMMM-yyyy";
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.dateTimePicker_Date.Location = new System.Drawing.Point(625, 102);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(234, 25);
            this.dateTimePicker_Date.TabIndex = 18;
            // 
            // dataGridView_Purchase_Order
            // 
            this.dataGridView_Purchase_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Purchase_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Purchase_Order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Purchase_Order.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Purchase_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Purchase_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial_Number,
            this.Item,
            this.Description,
            this.Quantity,
            this.Unit,
            this.Rate,
            this.Amount});
            this.dataGridView_Purchase_Order.EnableHeadersVisualStyles = false;
            this.dataGridView_Purchase_Order.GridColor = System.Drawing.Color.White;
            this.dataGridView_Purchase_Order.Location = new System.Drawing.Point(99, 285);
            this.dataGridView_Purchase_Order.Name = "dataGridView_Purchase_Order";
            this.dataGridView_Purchase_Order.Size = new System.Drawing.Size(760, 167);
            this.dataGridView_Purchase_Order.TabIndex = 22;
            this.dataGridView_Purchase_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Purchase_Bill_Approval_CellContentClick);
            // 
            // adS_2DataSet1
            // 
            this.adS_2DataSet1.DataSetName = "ADS_2DataSet";
            this.adS_2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textbox_Purchase_Ordered_By
            // 
            this.textbox_Purchase_Ordered_By.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.textbox_Purchase_Ordered_By.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textbox_Purchase_Ordered_By.Location = new System.Drawing.Point(625, 667);
            this.textbox_Purchase_Ordered_By.Name = "textbox_Purchase_Ordered_By";
            this.textbox_Purchase_Ordered_By.Size = new System.Drawing.Size(234, 27);
            this.textbox_Purchase_Ordered_By.TabIndex = 24;
            // 
            // label1_Purchase_Ordered_By
            // 
            this.label1_Purchase_Ordered_By.AutoSize = true;
            this.label1_Purchase_Ordered_By.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1_Purchase_Ordered_By.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label1_Purchase_Ordered_By.Location = new System.Drawing.Point(621, 697);
            this.label1_Purchase_Ordered_By.Name = "label1_Purchase_Ordered_By";
            this.label1_Purchase_Ordered_By.Size = new System.Drawing.Size(100, 19);
            this.label1_Purchase_Ordered_By.TabIndex = 25;
            this.label1_Purchase_Ordered_By.Text = "Ordered By";
            this.label1_Purchase_Ordered_By.Click += new System.EventHandler(this.label1_Purchase_Ordered_By_Click);
            // 
            // label_Total_Amount
            // 
            this.label_Total_Amount.AutoSize = true;
            this.label_Total_Amount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_Total_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Total_Amount.Location = new System.Drawing.Point(579, 470);
            this.label_Total_Amount.Name = "label_Total_Amount";
            this.label_Total_Amount.Size = new System.Drawing.Size(127, 19);
            this.label_Total_Amount.TabIndex = 26;
            this.label_Total_Amount.Text = "Total Amount:";
            this.label_Total_Amount.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Total_Amount
            // 
            this.textBox_Total_Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Total_Amount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Total_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_Total_Amount.Location = new System.Drawing.Point(712, 470);
            this.textBox_Total_Amount.Name = "textBox_Total_Amount";
            this.textBox_Total_Amount.Size = new System.Drawing.Size(147, 20);
            this.textBox_Total_Amount.TabIndex = 27;
            this.textBox_Total_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox_Supplier
            // 
            this.groupBox_Supplier.Controls.Add(this.textBox_Supplier);
            this.groupBox_Supplier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.groupBox_Supplier.Location = new System.Drawing.Point(99, 77);
            this.groupBox_Supplier.Name = "groupBox_Supplier";
            this.groupBox_Supplier.Size = new System.Drawing.Size(313, 186);
            this.groupBox_Supplier.TabIndex = 46;
            this.groupBox_Supplier.TabStop = false;
            this.groupBox_Supplier.Text = "Supplier Account Head :";
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.BackColor = System.Drawing.Color.White;
            this.textBox_Supplier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_Supplier.Location = new System.Drawing.Point(9, 26);
            this.textBox_Supplier.Multiline = true;
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.ReadOnly = true;
            this.textBox_Supplier.Size = new System.Drawing.Size(291, 150);
            this.textBox_Supplier.TabIndex = 40;
            // 
            // groupBox_TermsCond
            // 
            this.groupBox_TermsCond.Controls.Add(this.textBox_TnC);
            this.groupBox_TermsCond.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TermsCond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.groupBox_TermsCond.Location = new System.Drawing.Point(99, 522);
            this.groupBox_TermsCond.Name = "groupBox_TermsCond";
            this.groupBox_TermsCond.Size = new System.Drawing.Size(760, 120);
            this.groupBox_TermsCond.TabIndex = 47;
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
            this.textBox_TnC.Size = new System.Drawing.Size(745, 94);
            this.textBox_TnC.TabIndex = 41;
            // 
            // textBox_Approved_By
            // 
            this.textBox_Approved_By.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Approved_By.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Approved_By.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_Approved_By.Location = new System.Drawing.Point(366, 666);
            this.textBox_Approved_By.Name = "textBox_Approved_By";
            this.textBox_Approved_By.Size = new System.Drawing.Size(234, 27);
            this.textBox_Approved_By.TabIndex = 36;
            // 
            // label_Approved_By
            // 
            this.label_Approved_By.AutoSize = true;
            this.label_Approved_By.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Approved_By.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Approved_By.Location = new System.Drawing.Point(362, 697);
            this.label_Approved_By.Name = "label_Approved_By";
            this.label_Approved_By.Size = new System.Drawing.Size(111, 19);
            this.label_Approved_By.TabIndex = 48;
            this.label_Approved_By.Text = "Approved by";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(99, 667);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(151, 47);
            this.button_Save.TabIndex = 49;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_AmountWords
            // 
            this.textBox_AmountWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AmountWords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AmountWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_AmountWords.Location = new System.Drawing.Point(265, 470);
            this.textBox_AmountWords.Name = "textBox_AmountWords";
            this.textBox_AmountWords.Size = new System.Drawing.Size(246, 20);
            this.textBox_AmountWords.TabIndex = 51;
            this.textBox_AmountWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(104, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Amount in Words:";
            // 
            // Serial_Number
            // 
            this.Serial_Number.FillWeight = 94.06944F;
            this.Serial_Number.HeaderText = "S.No";
            this.Serial_Number.Name = "Serial_Number";
            // 
            // Item
            // 
            this.Item.FillWeight = 104.7524F;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Description
            // 
            this.Description.FillWeight = 100.2744F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 97.52337F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // Rate
            // 
            this.Rate.FillWeight = 102.1089F;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // Amount
            // 
            this.Amount.FillWeight = 99.58159F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Purchase_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 749);
            this.Controls.Add(this.textBox_AmountWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_Approved_By);
            this.Controls.Add(this.textBox_Approved_By);
            this.Controls.Add(this.groupBox_TermsCond);
            this.Controls.Add(this.groupBox_Supplier);
            this.Controls.Add(this.textBox_Total_Amount);
            this.Controls.Add(this.label_Total_Amount);
            this.Controls.Add(this.label1_Purchase_Ordered_By);
            this.Controls.Add(this.textbox_Purchase_Ordered_By);
            this.Controls.Add(this.dataGridView_Purchase_Order);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.textBox_Delivered_BY);
            this.Controls.Add(this.textBox_PO_Number);
            this.Controls.Add(this.label_Delivered_By);
            this.Controls.Add(this.label_PO_Number);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Purchase_Order);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Purchase_Order";
            this.ShowIcon = false;
            this.Text = "Purchase_Order";
            this.Load += new System.EventHandler(this.Purchase_Bill_Approval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Purchase_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adS_2DataSet1)).EndInit();
            this.groupBox_Supplier.ResumeLayout(false);
            this.groupBox_Supplier.PerformLayout();
            this.groupBox_TermsCond.ResumeLayout(false);
            this.groupBox_TermsCond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Purchase_Order;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_PO_Number;
        private System.Windows.Forms.Label label_Delivered_By;
        private System.Windows.Forms.TextBox textBox_PO_Number;
        private System.Windows.Forms.TextBox textBox_Delivered_BY;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.DataGridView dataGridView_Purchase_Order;
        private ADS_2DataSet adS_2DataSet1;
        private System.Windows.Forms.TextBox textbox_Purchase_Ordered_By;
        private System.Windows.Forms.Label label1_Purchase_Ordered_By;
        private System.Windows.Forms.Label label_Total_Amount;
        private System.Windows.Forms.TextBox textBox_Total_Amount;
        private System.Windows.Forms.GroupBox groupBox_Supplier;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.GroupBox groupBox_TermsCond;
        private System.Windows.Forms.TextBox textBox_Approved_By;
        private System.Windows.Forms.Label label_Approved_By;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_TnC;
        private System.Windows.Forms.TextBox textBox_AmountWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}