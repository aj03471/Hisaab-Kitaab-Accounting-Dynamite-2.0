namespace Hisaab_Kitaab
{
    partial class Ledger_Accounts
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
            this.dataGridView_AccHeads = new System.Windows.Forms.DataGridView();
            this.ACCHEAD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNTHEAD_TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccHeads)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_AccHeads
            // 
            this.dataGridView_AccHeads.AllowUserToAddRows = false;
            this.dataGridView_AccHeads.AllowUserToDeleteRows = false;
            this.dataGridView_AccHeads.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_AccHeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AccHeads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACCHEAD_ID,
            this.ACCOUNTHEAD_TITLE});
            this.dataGridView_AccHeads.Location = new System.Drawing.Point(34, 71);
            this.dataGridView_AccHeads.Name = "dataGridView_AccHeads";
            this.dataGridView_AccHeads.RowTemplate.Height = 24;
            this.dataGridView_AccHeads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AccHeads.Size = new System.Drawing.Size(599, 408);
            this.dataGridView_AccHeads.TabIndex = 0;
            this.dataGridView_AccHeads.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AccHeads_CellDoubleClick);
            // 
            // ACCHEAD_ID
            // 
            this.ACCHEAD_ID.DataPropertyName = "ACCHEAD_ID";
            this.ACCHEAD_ID.HeaderText = "Account Code";
            this.ACCHEAD_ID.Name = "ACCHEAD_ID";
            // 
            // ACCOUNTHEAD_TITLE
            // 
            this.ACCOUNTHEAD_TITLE.DataPropertyName = "ACCHEAD_NAME";
            this.ACCOUNTHEAD_TITLE.HeaderText = "Account Title";
            this.ACCOUNTHEAD_TITLE.Name = "ACCOUNTHEAD_TITLE";
            // 
            // Ledger_Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 588);
            this.Controls.Add(this.dataGridView_AccHeads);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Ledger_Accounts";
            this.Text = "Ledger_Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccHeads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_AccHeads;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCHEAD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNTHEAD_TITLE;
    }
}