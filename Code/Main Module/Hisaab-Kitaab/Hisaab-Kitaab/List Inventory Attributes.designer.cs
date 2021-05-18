namespace Hisaab_Kitaab
{
    partial class List_Inventory_Attributes
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button_Choose = new System.Windows.Forms.Button();
            this.dataGridView_InvAttributes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InvAttributes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(309, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Select Parent Head:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(539, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 32);
            this.textBox1.TabIndex = 35;
            // 
            // Button_Choose
            // 
            this.Button_Choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.Button_Choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Choose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Choose.ForeColor = System.Drawing.Color.White;
            this.Button_Choose.Location = new System.Drawing.Point(945, 81);
            this.Button_Choose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Choose.Name = "Button_Choose";
            this.Button_Choose.Size = new System.Drawing.Size(123, 41);
            this.Button_Choose.TabIndex = 38;
            this.Button_Choose.Text = "Choose";
            this.Button_Choose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Choose.UseVisualStyleBackColor = false;
            this.Button_Choose.Click += new System.EventHandler(this.Button_Choose_Click);
            // 
            // dataGridView_InvAttributes
            // 
            this.dataGridView_InvAttributes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_InvAttributes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_InvAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_InvAttributes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_InvAttributes.Location = new System.Drawing.Point(32, 159);
            this.dataGridView_InvAttributes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_InvAttributes.Name = "dataGridView_InvAttributes";
            this.dataGridView_InvAttributes.RowTemplate.Height = 33;
            this.dataGridView_InvAttributes.Size = new System.Drawing.Size(1244, 486);
            this.dataGridView_InvAttributes.TabIndex = 28;
            this.dataGridView_InvAttributes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_InvAttributes_CellContentClick);
            // 
            // List_Inventory_Attributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 783);
            this.Controls.Add(this.dataGridView_InvAttributes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Button_Choose);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "List_Inventory_Attributes";
            this.Text = "List Inventory Attributes";
            this.Load += new System.EventHandler(this.ListInventoryAttributes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InvAttributes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button_Choose;
        public System.Windows.Forms.DataGridView dataGridView_InvAttributes;
    }
}