namespace Hisaab_Kitaab
{
    partial class Supplier_Details
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
            this.dataGridView_Supplier_Details = new System.Windows.Forms.DataGridView();
            this.Account_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Supplier_Details = new System.Windows.Forms.Label();
            this.label_Suplier_Address = new System.Windows.Forms.Label();
            this.label_Supplier_Contact_Number = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Contact_Number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supplier_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Supplier_Details
            // 
            this.dataGridView_Supplier_Details.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Supplier_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Supplier_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account_Title,
            this.Account_Name});
            this.dataGridView_Supplier_Details.Location = new System.Drawing.Point(12, 52);
            this.dataGridView_Supplier_Details.Name = "dataGridView_Supplier_Details";
            this.dataGridView_Supplier_Details.Size = new System.Drawing.Size(494, 198);
            this.dataGridView_Supplier_Details.TabIndex = 0;
            this.dataGridView_Supplier_Details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Supplier_Details_CellContentClick);
            // 
            // Account_Title
            // 
            this.Account_Title.HeaderText = "Account Title";
            this.Account_Title.Name = "Account_Title";
            // 
            // Account_Name
            // 
            this.Account_Name.HeaderText = "Account Name";
            this.Account_Name.Name = "Account_Name";
            // 
            // label_Supplier_Details
            // 
            this.label_Supplier_Details.AutoSize = true;
            this.label_Supplier_Details.Location = new System.Drawing.Point(210, 13);
            this.label_Supplier_Details.Name = "label_Supplier_Details";
            this.label_Supplier_Details.Size = new System.Drawing.Size(119, 19);
            this.label_Supplier_Details.TabIndex = 1;
            this.label_Supplier_Details.Text = "Supplier Details";
            // 
            // label_Suplier_Address
            // 
            this.label_Suplier_Address.AutoSize = true;
            this.label_Suplier_Address.Location = new System.Drawing.Point(40, 268);
            this.label_Suplier_Address.Name = "label_Suplier_Address";
            this.label_Suplier_Address.Size = new System.Drawing.Size(120, 19);
            this.label_Suplier_Address.TabIndex = 2;
            this.label_Suplier_Address.Text = "Suplier Address";
            // 
            // label_Supplier_Contact_Number
            // 
            this.label_Supplier_Contact_Number.AutoSize = true;
            this.label_Supplier_Contact_Number.Location = new System.Drawing.Point(40, 326);
            this.label_Supplier_Contact_Number.Name = "label_Supplier_Contact_Number";
            this.label_Supplier_Contact_Number.Size = new System.Drawing.Size(124, 19);
            this.label_Supplier_Contact_Number.TabIndex = 3;
            this.label_Supplier_Contact_Number.Text = "Contact Number";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(186, 266);
            this.textBox_Address.Multiline = true;
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(267, 38);
            this.textBox_Address.TabIndex = 4;
            // 
            // textBox_Contact_Number
            // 
            this.textBox_Contact_Number.Location = new System.Drawing.Point(186, 323);
            this.textBox_Contact_Number.Name = "textBox_Contact_Number";
            this.textBox_Contact_Number.Size = new System.Drawing.Size(267, 27);
            this.textBox_Contact_Number.TabIndex = 5;
            // 
            // Supplier_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 371);
            this.Controls.Add(this.textBox_Contact_Number);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label_Supplier_Contact_Number);
            this.Controls.Add(this.label_Suplier_Address);
            this.Controls.Add(this.label_Supplier_Details);
            this.Controls.Add(this.dataGridView_Supplier_Details);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Supplier_Details";
            this.Text = "Supplier_Details";
            this.Load += new System.EventHandler(this.Supplier_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supplier_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Supplier_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Name;
        private System.Windows.Forms.Label label_Supplier_Details;
        private System.Windows.Forms.Label label_Suplier_Address;
        private System.Windows.Forms.Label label_Supplier_Contact_Number;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Contact_Number;
    }
}