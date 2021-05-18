namespace Hisaab_Kitaab
{
    partial class Dialogue_Box_Account_Head
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
            this.labelHeading = new System.Windows.Forms.Label();
            this.dataGridViewAccountHead3 = new System.Windows.Forms.DataGridView();
            this.okbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountHead3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelHeading.Location = new System.Drawing.Point(240, 36);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(185, 29);
            this.labelHeading.TabIndex = 20;
            this.labelHeading.Text = "Account Head ";
            // 
            // dataGridViewAccountHead3
            // 
            this.dataGridViewAccountHead3.AllowUserToAddRows = false;
            this.dataGridViewAccountHead3.AllowUserToDeleteRows = false;
            this.dataGridViewAccountHead3.AllowUserToResizeRows = false;
            this.dataGridViewAccountHead3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAccountHead3.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccountHead3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccountHead3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccountHead3.Location = new System.Drawing.Point(15, 118);
            this.dataGridViewAccountHead3.Name = "dataGridViewAccountHead3";
            this.dataGridViewAccountHead3.RowTemplate.Height = 24;
            this.dataGridViewAccountHead3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccountHead3.Size = new System.Drawing.Size(629, 387);
            this.dataGridViewAccountHead3.TabIndex = 21;
            this.dataGridViewAccountHead3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccountHead3_CellContentClick);
            // 
            // okbutton
            // 
            this.okbutton.AutoSize = true;
            this.okbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.okbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okbutton.ForeColor = System.Drawing.Color.White;
            this.okbutton.Location = new System.Drawing.Point(270, 538);
            this.okbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(118, 53);
            this.okbutton.TabIndex = 22;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = false;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // Dialogue_Box_Account_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 642);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.dataGridViewAccountHead3);
            this.Controls.Add(this.labelHeading);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dialogue_Box_Account_Head";
            this.Text = "Dialogue_Box_Account_Head";
            this.Load += new System.EventHandler(this.Dialogue_Box_Account_Head_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountHead3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button okbutton;
        public System.Windows.Forms.DataGridView dataGridViewAccountHead3;
    }
}