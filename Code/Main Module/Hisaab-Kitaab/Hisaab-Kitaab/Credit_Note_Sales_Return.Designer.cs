namespace Hisaab_Kitaab
{
    partial class Credit_Note_Sales_Return
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
            this.label_Credit_Note_Sales_Return = new System.Windows.Forms.Label();
            this.dataGridView_Credit_Node_Sales_Return = new System.Windows.Forms.DataGridView();
            this.Serial_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Accepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Supplier = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Dispatched_By = new System.Windows.Forms.Label();
            this.label_Credit_Note_Number = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.textBox_Terms_And_Conditions = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label_Agent = new System.Windows.Forms.Label();
            this.label_Delivery_Days = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label_Commission = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Credit_Node_Sales_Return)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Credit_Note_Sales_Return
            // 
            this.label_Credit_Note_Sales_Return.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Credit_Note_Sales_Return.AutoSize = true;
            this.label_Credit_Note_Sales_Return.Location = new System.Drawing.Point(541, 45);
            this.label_Credit_Note_Sales_Return.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Credit_Note_Sales_Return.Name = "label_Credit_Note_Sales_Return";
            this.label_Credit_Note_Sales_Return.Size = new System.Drawing.Size(149, 46);
            this.label_Credit_Note_Sales_Return.TabIndex = 1;
            this.label_Credit_Note_Sales_Return.Text = "Credit Note\r\n(Sales Return)\r\n";
            this.label_Credit_Note_Sales_Return.Click += new System.EventHandler(this.label_Purchase_Bill_Approval_Click);
            // 
            // dataGridView_Credit_Node_Sales_Return
            // 
            this.dataGridView_Credit_Node_Sales_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Credit_Node_Sales_Return.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_Credit_Node_Sales_Return.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView_Credit_Node_Sales_Return.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Credit_Node_Sales_Return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Credit_Node_Sales_Return.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial_Number,
            this.GRN,
            this.Item,
            this.Description,
            this.Quantity_Accepted,
            this.Rate,
            this.Amount});
            this.dataGridView_Credit_Node_Sales_Return.GridColor = System.Drawing.Color.White;
            this.dataGridView_Credit_Node_Sales_Return.Location = new System.Drawing.Point(137, 376);
            this.dataGridView_Credit_Node_Sales_Return.Name = "dataGridView_Credit_Node_Sales_Return";
            this.dataGridView_Credit_Node_Sales_Return.Size = new System.Drawing.Size(1096, 250);
            this.dataGridView_Credit_Node_Sales_Return.TabIndex = 25;
            this.dataGridView_Credit_Node_Sales_Return.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Credit_Node_Sales_Return_CellContentClick);
            // 
            // Serial_Number
            // 
            this.Serial_Number.HeaderText = "S.No";
            this.Serial_Number.Name = "Serial_Number";
            this.Serial_Number.Width = 80;
            // 
            // GRN
            // 
            this.GRN.HeaderText = "GRN";
            this.GRN.Name = "GRN";
            this.GRN.Width = 78;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Width = 81;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 144;
            // 
            // Quantity_Accepted
            // 
            this.Quantity_Accepted.HeaderText = "Quantity Accepted";
            this.Quantity_Accepted.Name = "Quantity_Accepted";
            this.Quantity_Accepted.Width = 192;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.Width = 79;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 110;
            // 
            // label_Supplier
            // 
            this.label_Supplier.AutoSize = true;
            this.label_Supplier.Location = new System.Drawing.Point(142, 135);
            this.label_Supplier.Name = "label_Supplier";
            this.label_Supplier.Size = new System.Drawing.Size(89, 23);
            this.label_Supplier.TabIndex = 24;
            this.label_Supplier.Text = "Supplier";
            this.label_Supplier.Click += new System.EventHandler(this.label_Supplier_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(999, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 23);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(999, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(234, 30);
            this.textBox3.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(999, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 30);
            this.textBox2.TabIndex = 29;
            // 
            // label_Dispatched_By
            // 
            this.label_Dispatched_By.AutoSize = true;
            this.label_Dispatched_By.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dispatched_By.Location = new System.Drawing.Point(833, 198);
            this.label_Dispatched_By.Name = "label_Dispatched_By";
            this.label_Dispatched_By.Size = new System.Drawing.Size(108, 19);
            this.label_Dispatched_By.TabIndex = 28;
            this.label_Dispatched_By.Text = "Dispatched By";
            // 
            // label_Credit_Note_Number
            // 
            this.label_Credit_Note_Number.AutoSize = true;
            this.label_Credit_Note_Number.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Credit_Note_Number.Location = new System.Drawing.Point(833, 155);
            this.label_Credit_Note_Number.Name = "label_Credit_Note_Number";
            this.label_Credit_Note_Number.Size = new System.Drawing.Size(106, 19);
            this.label_Credit_Note_Number.TabIndex = 27;
            this.label_Credit_Note_Number.Text = "Credit Note #";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(833, 116);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(41, 19);
            this.label_Date.TabIndex = 26;
            this.label_Date.Text = "Date";
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.BackColor = System.Drawing.Color.White;
            this.textBox_Supplier.Enabled = false;
            this.textBox_Supplier.Location = new System.Drawing.Point(137, 149);
            this.textBox_Supplier.Multiline = true;
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.Size = new System.Drawing.Size(170, 128);
            this.textBox_Supplier.TabIndex = 23;
            // 
            // textBox_Terms_And_Conditions
            // 
            this.textBox_Terms_And_Conditions.Location = new System.Drawing.Point(137, 662);
            this.textBox_Terms_And_Conditions.Multiline = true;
            this.textBox_Terms_And_Conditions.Name = "textBox_Terms_And_Conditions";
            this.textBox_Terms_And_Conditions.Size = new System.Drawing.Size(1093, 65);
            this.textBox_Terms_And_Conditions.TabIndex = 32;
            this.textBox_Terms_And_Conditions.Text = "Terms and Conditions";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(999, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 30);
            this.textBox1.TabIndex = 36;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(999, 235);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(234, 30);
            this.textBox5.TabIndex = 35;
            // 
            // label_Agent
            // 
            this.label_Agent.AutoSize = true;
            this.label_Agent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Agent.Location = new System.Drawing.Point(833, 283);
            this.label_Agent.Name = "label_Agent";
            this.label_Agent.Size = new System.Drawing.Size(51, 19);
            this.label_Agent.TabIndex = 34;
            this.label_Agent.Text = "Agent";
            // 
            // label_Delivery_Days
            // 
            this.label_Delivery_Days.AutoSize = true;
            this.label_Delivery_Days.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delivery_Days.Location = new System.Drawing.Point(833, 241);
            this.label_Delivery_Days.Name = "label_Delivery_Days";
            this.label_Delivery_Days.Size = new System.Drawing.Size(105, 19);
            this.label_Delivery_Days.TabIndex = 33;
            this.label_Delivery_Days.Text = "Delivery Days";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(998, 318);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(234, 30);
            this.textBox6.TabIndex = 38;
            // 
            // label_Commission
            // 
            this.label_Commission.AutoSize = true;
            this.label_Commission.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Commission.Location = new System.Drawing.Point(832, 324);
            this.label_Commission.Name = "label_Commission";
            this.label_Commission.Size = new System.Drawing.Size(96, 19);
            this.label_Commission.TabIndex = 37;
            this.label_Commission.Text = "Commission";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 318);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Credit_Note_Sales_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label_Commission);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label_Agent);
            this.Controls.Add(this.label_Delivery_Days);
            this.Controls.Add(this.textBox_Terms_And_Conditions);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_Dispatched_By);
            this.Controls.Add(this.label_Credit_Note_Number);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.dataGridView_Credit_Node_Sales_Return);
            this.Controls.Add(this.label_Supplier);
            this.Controls.Add(this.textBox_Supplier);
            this.Controls.Add(this.label_Credit_Note_Sales_Return);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Credit_Note_Sales_Return";
            this.Text = "Credit_Note_Sales_Return";
            this.Load += new System.EventHandler(this.Credit_Note_Sales_Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Credit_Node_Sales_Return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Credit_Note_Sales_Return;
        private System.Windows.Forms.DataGridView dataGridView_Credit_Node_Sales_Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Accepted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label label_Supplier;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_Dispatched_By;
        private System.Windows.Forms.Label label_Credit_Note_Number;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.TextBox textBox_Terms_And_Conditions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label_Agent;
        private System.Windows.Forms.Label label_Delivery_Days;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label_Commission;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}