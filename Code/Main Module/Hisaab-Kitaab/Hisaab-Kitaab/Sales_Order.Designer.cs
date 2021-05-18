namespace Hisaab_Kitaab
{
    partial class Sales_Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_Delivery_Terms = new System.Windows.Forms.TextBox();
            this.textBox_Commission = new System.Windows.Forms.TextBox();
            this.label_Delivery = new System.Windows.Forms.Label();
            this.label_Commission = new System.Windows.Forms.Label();
            this.textBox_Terms_And_Conditions = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox_Agent = new System.Windows.Forms.TextBox();
            this.label_Dispatched_By = new System.Windows.Forms.Label();
            this.label_Delivery_Note_Number = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.dataGridView_Credit_Node_Sales_Return = new System.Windows.Forms.DataGridView();
            this.Serial_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Head = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Customer = new System.Windows.Forms.Label();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.label_Sales_Order = new System.Windows.Forms.Label();
            this.textBox_Equity = new System.Windows.Forms.TextBox();
            this.label_Equity = new System.Windows.Forms.Label();
            this.textBox_Terms = new System.Windows.Forms.TextBox();
            this.label_Terms = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Credit_Node_Sales_Return)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Delivery_Terms
            // 
            this.textBox_Delivery_Terms.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Delivery_Terms.Location = new System.Drawing.Point(640, 265);
            this.textBox_Delivery_Terms.Name = "textBox_Delivery_Terms";
            this.textBox_Delivery_Terms.Size = new System.Drawing.Size(267, 28);
            this.textBox_Delivery_Terms.TabIndex = 68;
            this.textBox_Delivery_Terms.Text = "By Buyer";
            this.textBox_Delivery_Terms.TextChanged += new System.EventHandler(this.textBox_Delivery_Terms_TextChanged);
            // 
            // textBox_Commission
            // 
            this.textBox_Commission.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Commission.Location = new System.Drawing.Point(669, 231);
            this.textBox_Commission.Name = "textBox_Commission";
            this.textBox_Commission.Size = new System.Drawing.Size(238, 28);
            this.textBox_Commission.TabIndex = 67;
            this.textBox_Commission.TextChanged += new System.EventHandler(this.textBox_Commission_TextChanged);
            // 
            // label_Delivery
            // 
            this.label_Delivery.AutoSize = true;
            this.label_Delivery.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delivery.Location = new System.Drawing.Point(558, 265);
            this.label_Delivery.Name = "label_Delivery";
            this.label_Delivery.Size = new System.Drawing.Size(76, 21);
            this.label_Delivery.TabIndex = 66;
            this.label_Delivery.Text = "Delivery:";
            this.label_Delivery.Click += new System.EventHandler(this.label_Delivery_Click);
            // 
            // label_Commission
            // 
            this.label_Commission.AutoSize = true;
            this.label_Commission.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Commission.Location = new System.Drawing.Point(558, 231);
            this.label_Commission.Name = "label_Commission";
            this.label_Commission.Size = new System.Drawing.Size(105, 21);
            this.label_Commission.TabIndex = 65;
            this.label_Commission.Text = "Commission:";
            this.label_Commission.Click += new System.EventHandler(this.label_Commission_Click);
            // 
            // textBox_Terms_And_Conditions
            // 
            this.textBox_Terms_And_Conditions.Location = new System.Drawing.Point(16, 44);
            this.textBox_Terms_And_Conditions.Multiline = true;
            this.textBox_Terms_And_Conditions.Name = "textBox_Terms_And_Conditions";
            this.textBox_Terms_And_Conditions.Size = new System.Drawing.Size(858, 92);
            this.textBox_Terms_And_Conditions.TabIndex = 64;
            this.textBox_Terms_And_Conditions.TextChanged += new System.EventHandler(this.textBox_Terms_And_Conditions_TextChanged);
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Date.Location = new System.Drawing.Point(640, 96);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(267, 27);
            this.dateTimePicker_Date.TabIndex = 63;
            this.dateTimePicker_Date.ValueChanged += new System.EventHandler(this.dateTimePicker_Date_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(640, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 28);
            this.textBox3.TabIndex = 62;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_Agent
            // 
            this.textBox_Agent.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Agent.Location = new System.Drawing.Point(640, 129);
            this.textBox_Agent.Name = "textBox_Agent";
            this.textBox_Agent.Size = new System.Drawing.Size(267, 28);
            this.textBox_Agent.TabIndex = 61;
            this.textBox_Agent.TextChanged += new System.EventHandler(this.textBox_Agent_TextChanged);
            // 
            // label_Dispatched_By
            // 
            this.label_Dispatched_By.AutoSize = true;
            this.label_Dispatched_By.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dispatched_By.Location = new System.Drawing.Point(560, 197);
            this.label_Dispatched_By.Name = "label_Dispatched_By";
            this.label_Dispatched_By.Size = new System.Drawing.Size(60, 21);
            this.label_Dispatched_By.TabIndex = 60;
            this.label_Dispatched_By.Text = "Agent:";
            this.label_Dispatched_By.Click += new System.EventHandler(this.label_Dispatched_By_Click);
            // 
            // label_Delivery_Note_Number
            // 
            this.label_Delivery_Note_Number.AutoSize = true;
            this.label_Delivery_Note_Number.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delivery_Note_Number.Location = new System.Drawing.Point(564, 129);
            this.label_Delivery_Note_Number.Name = "label_Delivery_Note_Number";
            this.label_Delivery_Note_Number.Size = new System.Drawing.Size(75, 21);
            this.label_Delivery_Note_Number.TabIndex = 59;
            this.label_Delivery_Note_Number.Text = "Order #:";
            this.label_Delivery_Note_Number.Click += new System.EventHandler(this.label_Delivery_Note_Number_Click);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(564, 96);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(52, 21);
            this.label_Date.TabIndex = 58;
            this.label_Date.Text = "Date:";
            this.label_Date.Click += new System.EventHandler(this.label_Date_Click);
            // 
            // dataGridView_Credit_Node_Sales_Return
            // 
            this.dataGridView_Credit_Node_Sales_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Credit_Node_Sales_Return.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_Credit_Node_Sales_Return.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView_Credit_Node_Sales_Return.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Credit_Node_Sales_Return.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Credit_Node_Sales_Return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Credit_Node_Sales_Return.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial_Number,
            this.Item_Head,
            this.Quantity,
            this.Unit,
            this.Delivery_Date});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Credit_Node_Sales_Return.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Credit_Node_Sales_Return.GridColor = System.Drawing.Color.White;
            this.dataGridView_Credit_Node_Sales_Return.Location = new System.Drawing.Point(12, 350);
            this.dataGridView_Credit_Node_Sales_Return.Name = "dataGridView_Credit_Node_Sales_Return";
            this.dataGridView_Credit_Node_Sales_Return.Size = new System.Drawing.Size(895, 291);
            this.dataGridView_Credit_Node_Sales_Return.TabIndex = 57;
            this.dataGridView_Credit_Node_Sales_Return.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Credit_Node_Sales_Return_CellContentClick);
            // 
            // Serial_Number
            // 
            this.Serial_Number.HeaderText = "S. No";
            this.Serial_Number.Name = "Serial_Number";
            this.Serial_Number.Width = 84;
            // 
            // Item_Head
            // 
            this.Item_Head.HeaderText = "Item Head";
            this.Item_Head.Name = "Item_Head";
            this.Item_Head.Width = 134;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 126;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.Width = 81;
            // 
            // Delivery_Date
            // 
            this.Delivery_Date.HeaderText = "Delivery Date";
            this.Delivery_Date.Name = "Delivery_Date";
            this.Delivery_Date.Width = 161;
            // 
            // label_Customer
            // 
            this.label_Customer.AutoSize = true;
            this.label_Customer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Customer.Location = new System.Drawing.Point(12, 75);
            this.label_Customer.Name = "label_Customer";
            this.label_Customer.Size = new System.Drawing.Size(106, 24);
            this.label_Customer.TabIndex = 56;
            this.label_Customer.Text = "Customer";
            this.label_Customer.Click += new System.EventHandler(this.label_Customer_Click);
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.BackColor = System.Drawing.Color.White;
            this.textBox_Supplier.Enabled = false;
            this.textBox_Supplier.Location = new System.Drawing.Point(12, 107);
            this.textBox_Supplier.Multiline = true;
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.Size = new System.Drawing.Size(270, 217);
            this.textBox_Supplier.TabIndex = 55;
            this.textBox_Supplier.TextChanged += new System.EventHandler(this.textBox_Supplier_TextChanged);
            // 
            // label_Sales_Order
            // 
            this.label_Sales_Order.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Sales_Order.AutoSize = true;
            this.label_Sales_Order.Location = new System.Drawing.Point(343, 25);
            this.label_Sales_Order.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Sales_Order.Name = "label_Sales_Order";
            this.label_Sales_Order.Size = new System.Drawing.Size(149, 29);
            this.label_Sales_Order.TabIndex = 54;
            this.label_Sales_Order.Text = "Sales Order";
            this.label_Sales_Order.Click += new System.EventHandler(this.label_Sales_Order_Click);
            // 
            // textBox_Equity
            // 
            this.textBox_Equity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Equity.Location = new System.Drawing.Point(640, 163);
            this.textBox_Equity.Name = "textBox_Equity";
            this.textBox_Equity.Size = new System.Drawing.Size(267, 28);
            this.textBox_Equity.TabIndex = 70;
            this.textBox_Equity.TextChanged += new System.EventHandler(this.textBox_Equity_TextChanged);
            // 
            // label_Equity
            // 
            this.label_Equity.AutoSize = true;
            this.label_Equity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Equity.Location = new System.Drawing.Point(560, 163);
            this.label_Equity.Name = "label_Equity";
            this.label_Equity.Size = new System.Drawing.Size(79, 21);
            this.label_Equity.TabIndex = 69;
            this.label_Equity.Text = "Equiry #:";
            this.label_Equity.Click += new System.EventHandler(this.label_Equity_Click);
            // 
            // textBox_Terms
            // 
            this.textBox_Terms.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Terms.Location = new System.Drawing.Point(640, 299);
            this.textBox_Terms.Name = "textBox_Terms";
            this.textBox_Terms.Size = new System.Drawing.Size(267, 28);
            this.textBox_Terms.TabIndex = 72;
            this.textBox_Terms.Text = "By Us";
            this.textBox_Terms.TextChanged += new System.EventHandler(this.textBox_Terms_TextChanged);
            // 
            // label_Terms
            // 
            this.label_Terms.AutoSize = true;
            this.label_Terms.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Terms.Location = new System.Drawing.Point(560, 299);
            this.label_Terms.Name = "label_Terms";
            this.label_Terms.Size = new System.Drawing.Size(63, 21);
            this.label_Terms.TabIndex = 71;
            this.label_Terms.Text = "Terms:";
            this.label_Terms.Click += new System.EventHandler(this.label_Terms_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Terms_And_Conditions);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 660);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 164);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terms and Conditions:";
            // 
            // Sales_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 836);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Terms);
            this.Controls.Add(this.label_Terms);
            this.Controls.Add(this.textBox_Equity);
            this.Controls.Add(this.label_Equity);
            this.Controls.Add(this.textBox_Delivery_Terms);
            this.Controls.Add(this.textBox_Commission);
            this.Controls.Add(this.label_Delivery);
            this.Controls.Add(this.label_Commission);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox_Agent);
            this.Controls.Add(this.label_Dispatched_By);
            this.Controls.Add(this.label_Delivery_Note_Number);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.dataGridView_Credit_Node_Sales_Return);
            this.Controls.Add(this.label_Customer);
            this.Controls.Add(this.textBox_Supplier);
            this.Controls.Add(this.label_Sales_Order);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Sales_Order";
            this.Text = "Sales_Order";
            this.Load += new System.EventHandler(this.Sales_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Credit_Node_Sales_Return)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Delivery_Terms;
        private System.Windows.Forms.TextBox textBox_Commission;
        private System.Windows.Forms.Label label_Delivery;
        private System.Windows.Forms.Label label_Commission;
        private System.Windows.Forms.TextBox textBox_Terms_And_Conditions;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox_Agent;
        private System.Windows.Forms.Label label_Dispatched_By;
        private System.Windows.Forms.Label label_Delivery_Note_Number;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.DataGridView dataGridView_Credit_Node_Sales_Return;
        private System.Windows.Forms.Label label_Customer;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.Label label_Sales_Order;
        private System.Windows.Forms.TextBox textBox_Equity;
        private System.Windows.Forms.Label label_Equity;
        private System.Windows.Forms.TextBox textBox_Terms;
        private System.Windows.Forms.Label label_Terms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Head;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_Date;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}