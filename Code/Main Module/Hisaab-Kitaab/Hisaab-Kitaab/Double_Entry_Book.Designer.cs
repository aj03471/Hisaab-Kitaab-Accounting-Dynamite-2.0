namespace Hisaab_Kitaab
{
    partial class Double_Entry_Book
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
            this.label_SingleEntryBook = new System.Windows.Forms.Label();
            this.dataGridView_DoubleEntryBook = new System.Windows.Forms.DataGridView();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DoubleEntryBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SingleEntryBook
            // 
            this.label_SingleEntryBook.AutoSize = true;
            this.label_SingleEntryBook.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SingleEntryBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_SingleEntryBook.Location = new System.Drawing.Point(368, 16);
            this.label_SingleEntryBook.Name = "label_SingleEntryBook";
            this.label_SingleEntryBook.Size = new System.Drawing.Size(328, 29);
            this.label_SingleEntryBook.TabIndex = 41;
            this.label_SingleEntryBook.Text = "List of Double Entry Books";
            // 
            // dataGridView_DoubleEntryBook
            // 
            this.dataGridView_DoubleEntryBook.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DoubleEntryBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_DoubleEntryBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DoubleEntryBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_DoubleEntryBook.Location = new System.Drawing.Point(40, 88);
            this.dataGridView_DoubleEntryBook.Name = "dataGridView_DoubleEntryBook";
            this.dataGridView_DoubleEntryBook.RowTemplate.Height = 24;
            this.dataGridView_DoubleEntryBook.Size = new System.Drawing.Size(941, 504);
            this.dataGridView_DoubleEntryBook.TabIndex = 40;
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_Print.FlatAppearance.BorderSize = 0;
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.ForeColor = System.Drawing.Color.White;
            this.button_Print.Location = new System.Drawing.Point(719, 635);
            this.button_Print.Margin = new System.Windows.Forms.Padding(4);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(151, 47);
            this.button_Print.TabIndex = 39;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = false;
            // 
            // button_Remove
            // 
            this.button_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_Remove.FlatAppearance.BorderSize = 0;
            this.button_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.ForeColor = System.Drawing.Color.White;
            this.button_Remove.Location = new System.Drawing.Point(513, 635);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(151, 47);
            this.button_Remove.TabIndex = 38;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = false;
            // 
            // button_Modify
            // 
            this.button_Modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_Modify.FlatAppearance.BorderSize = 0;
            this.button_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modify.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modify.ForeColor = System.Drawing.Color.White;
            this.button_Modify.Location = new System.Drawing.Point(310, 635);
            this.button_Modify.Margin = new System.Windows.Forms.Padding(4);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(151, 47);
            this.button_Modify.TabIndex = 37;
            this.button_Modify.Text = "Modify";
            this.button_Modify.UseVisualStyleBackColor = false;
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(113, 635);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(151, 47);
            this.button_Add.TabIndex = 36;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            // 
            // Double_Entry_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 729);
            this.Controls.Add(this.label_SingleEntryBook);
            this.Controls.Add(this.dataGridView_DoubleEntryBook);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.button_Add);
            this.Name = "Double_Entry_Book";
            this.Text = "Double_Entry_Book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DoubleEntryBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SingleEntryBook;
        private System.Windows.Forms.DataGridView dataGridView_DoubleEntryBook;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Add;
    }
}