namespace Hisaab_Kitaab
{
    partial class List_Store_Issue_Slips
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_INV_SPECIFICATION = new System.Windows.Forms.RichTextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewStoreSlips = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoreSlips)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(717, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "STORE ISSUE SLIPS";
            // 
            // richTextBox_INV_SPECIFICATION
            // 
            this.richTextBox_INV_SPECIFICATION.Enabled = false;
            this.richTextBox_INV_SPECIFICATION.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_INV_SPECIFICATION.Location = new System.Drawing.Point(22, 950);
            this.richTextBox_INV_SPECIFICATION.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox_INV_SPECIFICATION.Name = "richTextBox_INV_SPECIFICATION";
            this.richTextBox_INV_SPECIFICATION.Size = new System.Drawing.Size(1627, 234);
            this.richTextBox_INV_SPECIFICATION.TabIndex = 87;
            this.richTextBox_INV_SPECIFICATION.Text = "";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox5.Location = new System.Drawing.Point(1117, 876);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(477, 46);
            this.textBox5.TabIndex = 86;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox4.Location = new System.Drawing.Point(283, 876);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(477, 46);
            this.textBox4.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(37, 879);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 39);
            this.label7.TabIndex = 84;
            this.label7.Text = "Prepared By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(808, 883);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 39);
            this.label6.TabIndex = 83;
            this.label6.Text = "Store Keeper:";
            // 
            // dataGridViewStoreSlips
            // 
            this.dataGridViewStoreSlips.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStoreSlips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStoreSlips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.ItemHead,
            this.ItemDescription,
            this.Unit,
            this.QuantityIssued,
            this.Cost});
            this.dataGridViewStoreSlips.EnableHeadersVisualStyles = false;
            this.dataGridViewStoreSlips.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStoreSlips.Location = new System.Drawing.Point(22, 328);
            this.dataGridViewStoreSlips.Name = "dataGridViewStoreSlips";
            this.dataGridViewStoreSlips.RowTemplate.Height = 33;
            this.dataGridViewStoreSlips.Size = new System.Drawing.Size(1627, 517);
            this.dataGridViewStoreSlips.TabIndex = 82;
            this.dataGridViewStoreSlips.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStoreSlips_CellClick);
            this.dataGridViewStoreSlips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStoreSlips_CellContentClick);
            this.dataGridViewStoreSlips.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStoreSlips_CellDoubleClick);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox3.Location = new System.Drawing.Point(1117, 265);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(477, 46);
            this.textBox3.TabIndex = 81;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox2.Location = new System.Drawing.Point(1117, 156);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(477, 46);
            this.textBox2.TabIndex = 80;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox1.Location = new System.Drawing.Point(283, 260);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 46);
            this.textBox1.TabIndex = 79;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(37, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 39);
            this.label5.TabIndex = 77;
            this.label5.Text = "Store Slip No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(797, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 39);
            this.label4.TabIndex = 76;
            this.label4.Text = "Store Requistion No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(797, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 39);
            this.label3.TabIndex = 75;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(37, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 39);
            this.label2.TabIndex = 74;
            this.label2.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMMM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(283, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(477, 46);
            this.dateTimePicker1.TabIndex = 88;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "Serial #";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Width = 250;
            // 
            // ItemHead
            // 
            this.ItemHead.HeaderText = "Item Head";
            this.ItemHead.Name = "ItemHead";
            this.ItemHead.Width = 250;
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Width = 270;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.Width = 270;
            // 
            // QuantityIssued
            // 
            this.QuantityIssued.HeaderText = "Quantity Issued";
            this.QuantityIssued.Name = "QuantityIssued";
            this.QuantityIssued.Width = 270;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.Width = 270;
            // 
            // buttonsave
            // 
            this.buttonsave.Font = new System.Drawing.Font("Cambria", 12F);
            this.buttonsave.Location = new System.Drawing.Point(724, 1206);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(161, 58);
            this.buttonsave.TabIndex = 92;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // List_Store_Issue_Slips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1675, 1329);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.richTextBox_INV_SPECIFICATION);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewStoreSlips);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "List_Store_Issue_Slips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Store_Issue_Slips";
            this.Load += new System.EventHandler(this.List_Store_Issue_Slips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoreSlips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox richTextBox_INV_SPECIFICATION;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewStoreSlips;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityIssued;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Button buttonsave;
    }
}