namespace Hisaab_Kitaab
{
    partial class Choose_Inventory_Head
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
            this.labelHeading = new System.Windows.Forms.Label();
            this.dataGridViewChooseInvHead = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChooseInvHead)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.labelHeading.Location = new System.Drawing.Point(171, 29);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(294, 29);
            this.labelHeading.TabIndex = 3;
            this.labelHeading.Text = "Choose Inventory Head";
            // 
            // dataGridViewChooseInvHead
            // 
            this.dataGridViewChooseInvHead.AllowUserToAddRows = false;
            this.dataGridViewChooseInvHead.AllowUserToDeleteRows = false;
            this.dataGridViewChooseInvHead.AllowUserToResizeRows = false;
            this.dataGridViewChooseInvHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChooseInvHead.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChooseInvHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChooseInvHead.Location = new System.Drawing.Point(29, 84);
            this.dataGridViewChooseInvHead.Name = "dataGridViewChooseInvHead";
            this.dataGridViewChooseInvHead.RowTemplate.Height = 24;
            this.dataGridViewChooseInvHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChooseInvHead.Size = new System.Drawing.Size(545, 387);
            this.dataGridViewChooseInvHead.TabIndex = 4;
            this.dataGridViewChooseInvHead.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccountHead_CellContentClick);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(211, 492);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(144, 50);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Choose_Inventory_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 554);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewChooseInvHead);
            this.Controls.Add(this.labelHeading);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Choose_Inventory_Head";
            this.Text = "Choose_Inventory_Head";
            this.Load += new System.EventHandler(this.Choose_Inventory_Head_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChooseInvHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.DataGridView dataGridViewChooseInvHead;
    }
}