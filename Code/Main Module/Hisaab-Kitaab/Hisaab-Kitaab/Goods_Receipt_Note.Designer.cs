namespace Hisaab_Kitaab
{
    partial class Good_Receipt_Note
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_PO_Number = new System.Windows.Forms.Label();
            this.label_Purchase = new System.Windows.Forms.Label();
            this.textBox_PONo = new System.Windows.Forms.TextBox();
            this.textBox_PurchaseNo = new System.Windows.Forms.TextBox();
            this.textBox_Prepared_By = new System.Windows.Forms.TextBox();
            this.label_Prepared_By = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_Goods_Receipt_Note = new System.Windows.Forms.DataGridView();
            this.Serial_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adS_2DataSet1 = new Hisaab_Kitaab.ADS_2DataSet();
            this.textbox_Store_Keeper = new System.Windows.Forms.TextBox();
            this.label_Store_Keeper = new System.Windows.Forms.Label();
            this.label_Total_Amount = new System.Windows.Forms.Label();
            this.textBox_Total_Amount = new System.Windows.Forms.TextBox();
            this.label_GRN = new System.Windows.Forms.Label();
            this.textBox_GRN = new System.Windows.Forms.TextBox();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.groupBox_Supplier = new System.Windows.Forms.GroupBox();
            this.groupBox_TermsCond = new System.Windows.Forms.GroupBox();
            this.textBox_TnC = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_AmountWords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Goods_Receipt_Note)).BeginInit();
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
            this.label_Purchase_Order.Location = new System.Drawing.Point(328, 20);
            this.label_Purchase_Order.Name = "label_Purchase_Order";
            this.label_Purchase_Order.Size = new System.Drawing.Size(210, 23);
            this.label_Purchase_Order.TabIndex = 0;
            this.label_Purchase_Order.Text = "Goods Receipts Note";
            this.label_Purchase_Order.Click += new System.EventHandler(this.label_Purchase_Bill_Approval_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1449, -1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 693);
            this.vScrollBar1.TabIndex = 1;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Date.Location = new System.Drawing.Point(540, 94);
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
            this.label_PO_Number.Location = new System.Drawing.Point(538, 127);
            this.label_PO_Number.Name = "label_PO_Number";
            this.label_PO_Number.Size = new System.Drawing.Size(50, 19);
            this.label_PO_Number.TabIndex = 3;
            this.label_PO_Number.Text = "PO #";
            // 
            // label_Purchase
            // 
            this.label_Purchase.AutoSize = true;
            this.label_Purchase.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_Purchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Purchase.Location = new System.Drawing.Point(487, 157);
            this.label_Purchase.Name = "label_Purchase";
            this.label_Purchase.Size = new System.Drawing.Size(101, 19);
            this.label_Purchase.TabIndex = 4;
            this.label_Purchase.Text = "Purchase #";
            // 
            // textBox_PONo
            // 
            this.textBox_PONo.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.textBox_PONo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_PONo.Location = new System.Drawing.Point(613, 126);
            this.textBox_PONo.Name = "textBox_PONo";
            this.textBox_PONo.Size = new System.Drawing.Size(257, 25);
            this.textBox_PONo.TabIndex = 6;
            // 
            // textBox_PurchaseNo
            // 
            this.textBox_PurchaseNo.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.textBox_PurchaseNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_PurchaseNo.Location = new System.Drawing.Point(613, 156);
            this.textBox_PurchaseNo.Name = "textBox_PurchaseNo";
            this.textBox_PurchaseNo.Size = new System.Drawing.Size(257, 25);
            this.textBox_PurchaseNo.TabIndex = 7;
            // 
            // textBox_Prepared_By
            // 
            this.textBox_Prepared_By.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.textBox_Prepared_By.Location = new System.Drawing.Point(378, 637);
            this.textBox_Prepared_By.Name = "textBox_Prepared_By";
            this.textBox_Prepared_By.Size = new System.Drawing.Size(232, 27);
            this.textBox_Prepared_By.TabIndex = 16;
            // 
            // label_Prepared_By
            // 
            this.label_Prepared_By.AutoSize = true;
            this.label_Prepared_By.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_Prepared_By.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Prepared_By.Location = new System.Drawing.Point(374, 667);
            this.label_Prepared_By.Name = "label_Prepared_By";
            this.label_Prepared_By.Size = new System.Drawing.Size(108, 19);
            this.label_Prepared_By.TabIndex = 17;
            this.label_Prepared_By.Text = "Prepared by";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.dateTimePicker_Date.CustomFormat = "    dd-MMMM-yyyy";
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.dateTimePicker_Date.Location = new System.Drawing.Point(613, 94);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(257, 25);
            this.dateTimePicker_Date.TabIndex = 18;
            // 
            // dataGridView_Goods_Receipt_Note
            // 
            this.dataGridView_Goods_Receipt_Note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Goods_Receipt_Note.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Goods_Receipt_Note.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Goods_Receipt_Note.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Goods_Receipt_Note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Goods_Receipt_Note.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial_Number,
            this.Item,
            this.Description,
            this.Quantity,
            this.Unit,
            this.Rate,
            this.Amount});
            this.dataGridView_Goods_Receipt_Note.EnableHeadersVisualStyles = false;
            this.dataGridView_Goods_Receipt_Note.GridColor = System.Drawing.Color.White;
            this.dataGridView_Goods_Receipt_Note.Location = new System.Drawing.Point(109, 231);
            this.dataGridView_Goods_Receipt_Note.Name = "dataGridView_Goods_Receipt_Note";
            this.dataGridView_Goods_Receipt_Note.Size = new System.Drawing.Size(1252, 144);
            this.dataGridView_Goods_Receipt_Note.TabIndex = 22;
            this.dataGridView_Goods_Receipt_Note.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Purchase_Bill_Approval_CellContentClick);
            // 
            // Serial_Number
            // 
            this.Serial_Number.HeaderText = "S.No";
            this.Serial_Number.Name = "Serial_Number";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity Received";
            this.Quantity.Name = "Quantity";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // adS_2DataSet1
            // 
            this.adS_2DataSet1.DataSetName = "ADS_2DataSet";
            this.adS_2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textbox_Store_Keeper
            // 
            this.textbox_Store_Keeper.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.textbox_Store_Keeper.Location = new System.Drawing.Point(642, 637);
            this.textbox_Store_Keeper.Name = "textbox_Store_Keeper";
            this.textbox_Store_Keeper.Size = new System.Drawing.Size(228, 27);
            this.textbox_Store_Keeper.TabIndex = 24;
            // 
            // label_Store_Keeper
            // 
            this.label_Store_Keeper.AutoSize = true;
            this.label_Store_Keeper.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_Store_Keeper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Store_Keeper.Location = new System.Drawing.Point(638, 667);
            this.label_Store_Keeper.Name = "label_Store_Keeper";
            this.label_Store_Keeper.Size = new System.Drawing.Size(116, 19);
            this.label_Store_Keeper.TabIndex = 25;
            this.label_Store_Keeper.Text = "Store Keeper";
            // 
            // label_Total_Amount
            // 
            this.label_Total_Amount.AutoSize = true;
            this.label_Total_Amount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_Total_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Total_Amount.Location = new System.Drawing.Point(601, 432);
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
            this.textBox_Total_Amount.Location = new System.Drawing.Point(734, 429);
            this.textBox_Total_Amount.Name = "textBox_Total_Amount";
            this.textBox_Total_Amount.Size = new System.Drawing.Size(136, 20);
            this.textBox_Total_Amount.TabIndex = 27;
            this.textBox_Total_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_GRN
            // 
            this.label_GRN.AutoSize = true;
            this.label_GRN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_GRN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_GRN.Location = new System.Drawing.Point(525, 190);
            this.label_GRN.Name = "label_GRN";
            this.label_GRN.Size = new System.Drawing.Size(63, 19);
            this.label_GRN.TabIndex = 28;
            this.label_GRN.Text = "GRN #";
            // 
            // textBox_GRN
            // 
            this.textBox_GRN.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.textBox_GRN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_GRN.Location = new System.Drawing.Point(613, 189);
            this.textBox_GRN.Name = "textBox_GRN";
            this.textBox_GRN.Size = new System.Drawing.Size(257, 25);
            this.textBox_GRN.TabIndex = 29;
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.BackColor = System.Drawing.Color.White;
            this.textBox_Supplier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_Supplier.Location = new System.Drawing.Point(10, 25);
            this.textBox_Supplier.Multiline = true;
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.ReadOnly = true;
            this.textBox_Supplier.Size = new System.Drawing.Size(278, 108);
            this.textBox_Supplier.TabIndex = 20;
            this.textBox_Supplier.TextChanged += new System.EventHandler(this.textBox_Supplier_TextChanged);
            // 
            // groupBox_Supplier
            // 
            this.groupBox_Supplier.Controls.Add(this.textBox_Supplier);
            this.groupBox_Supplier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.groupBox_Supplier.Location = new System.Drawing.Point(109, 66);
            this.groupBox_Supplier.Name = "groupBox_Supplier";
            this.groupBox_Supplier.Size = new System.Drawing.Size(294, 143);
            this.groupBox_Supplier.TabIndex = 46;
            this.groupBox_Supplier.TabStop = false;
            this.groupBox_Supplier.Text = "Supplier:";
            // 
            // groupBox_TermsCond
            // 
            this.groupBox_TermsCond.Controls.Add(this.textBox_TnC);
            this.groupBox_TermsCond.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TermsCond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.groupBox_TermsCond.Location = new System.Drawing.Point(109, 492);
            this.groupBox_TermsCond.Name = "groupBox_TermsCond";
            this.groupBox_TermsCond.Size = new System.Drawing.Size(761, 120);
            this.groupBox_TermsCond.TabIndex = 47;
            this.groupBox_TermsCond.TabStop = false;
            this.groupBox_TermsCond.Text = "Terms and Conditions";
            // 
            // textBox_TnC
            // 
            this.textBox_TnC.BackColor = System.Drawing.Color.White;
            this.textBox_TnC.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_TnC.Location = new System.Drawing.Point(6, 20);
            this.textBox_TnC.Multiline = true;
            this.textBox_TnC.Name = "textBox_TnC";
            this.textBox_TnC.ReadOnly = true;
            this.textBox_TnC.Size = new System.Drawing.Size(741, 94);
            this.textBox_TnC.TabIndex = 41;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(109, 637);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(151, 47);
            this.button_Save.TabIndex = 48;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_AmountWords
            // 
            this.textBox_AmountWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AmountWords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AmountWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.textBox_AmountWords.Location = new System.Drawing.Point(275, 429);
            this.textBox_AmountWords.Name = "textBox_AmountWords";
            this.textBox_AmountWords.Size = new System.Drawing.Size(263, 20);
            this.textBox_AmountWords.TabIndex = 53;
            this.textBox_AmountWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(111, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Amount in Words:";
            // 
            // Good_Receipt_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 716);
            this.Controls.Add(this.textBox_AmountWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.groupBox_TermsCond);
            this.Controls.Add(this.groupBox_Supplier);
            this.Controls.Add(this.textBox_GRN);
            this.Controls.Add(this.label_GRN);
            this.Controls.Add(this.textBox_Total_Amount);
            this.Controls.Add(this.label_Total_Amount);
            this.Controls.Add(this.label_Store_Keeper);
            this.Controls.Add(this.textbox_Store_Keeper);
            this.Controls.Add(this.dataGridView_Goods_Receipt_Note);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.label_Prepared_By);
            this.Controls.Add(this.textBox_Prepared_By);
            this.Controls.Add(this.textBox_PurchaseNo);
            this.Controls.Add(this.textBox_PONo);
            this.Controls.Add(this.label_Purchase);
            this.Controls.Add(this.label_PO_Number);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label_Purchase_Order);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Good_Receipt_Note";
            this.ShowIcon = false;
            this.Text = "Good_Receipt_Note";
            this.Load += new System.EventHandler(this.Purchase_Bill_Approval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Goods_Receipt_Note)).EndInit();
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
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_PO_Number;
        private System.Windows.Forms.Label label_Purchase;
        private System.Windows.Forms.TextBox textBox_PONo;
        private System.Windows.Forms.TextBox textBox_PurchaseNo;
        private System.Windows.Forms.TextBox textBox_Prepared_By;
        private System.Windows.Forms.Label label_Prepared_By;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.DataGridView dataGridView_Goods_Receipt_Note;
        private ADS_2DataSet adS_2DataSet1;
        private System.Windows.Forms.TextBox textbox_Store_Keeper;
        private System.Windows.Forms.Label label_Store_Keeper;
        private System.Windows.Forms.Label label_Total_Amount;
        private System.Windows.Forms.TextBox textBox_Total_Amount;
        private System.Windows.Forms.Label label_GRN;
        private System.Windows.Forms.TextBox textBox_GRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.GroupBox groupBox_Supplier;
        private System.Windows.Forms.GroupBox groupBox_TermsCond;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_TnC;
        private System.Windows.Forms.TextBox textBox_AmountWords;
        private System.Windows.Forms.Label label1;
    }
}