namespace Hisaab_Kitaab
{
    partial class List_Inventory_Head_Properties_CChoose
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
            this.label_InvParentHead = new System.Windows.Forms.Label();
            this.Button_Add = new System.Windows.Forms.Button();
            this.CdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_InvParentHead
            // 
            this.label_InvParentHead.AutoSize = true;
            this.label_InvParentHead.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InvParentHead.Location = new System.Drawing.Point(417, 51);
            this.label_InvParentHead.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_InvParentHead.Name = "label_InvParentHead";
            this.label_InvParentHead.Size = new System.Drawing.Size(365, 44);
            this.label_InvParentHead.TabIndex = 39;
            this.label_InvParentHead.Text = "List of Parent Heads";
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.SystemColors.Window;
            this.Button_Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Add.Location = new System.Drawing.Point(447, 1020);
            this.Button_Add.Margin = new System.Windows.Forms.Padding(6);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(256, 73);
            this.Button_Add.TabIndex = 37;
            this.Button_Add.Text = "OK";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // CdataGridView1
            // 
            this.CdataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.CdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CdataGridView1.Location = new System.Drawing.Point(68, 144);
            this.CdataGridView1.Name = "CdataGridView1";
            this.CdataGridView1.RowTemplate.Height = 33;
            this.CdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CdataGridView1.Size = new System.Drawing.Size(1067, 835);
            this.CdataGridView1.TabIndex = 40;
            this.CdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // List_Inventory_Head_Properties_CChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 1144);
            this.Controls.Add(this.CdataGridView1);
            this.Controls.Add(this.label_InvParentHead);
            this.Controls.Add(this.Button_Add);
            this.Name = "List_Inventory_Head_Properties_CChoose";
            this.Text = "List_Inventory_Head_Properties_CChoose";
            this.Load += new System.EventHandler(this.List_Inventory_Head_Properties_CChoose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InvParentHead;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.DataGridView CdataGridView1;
    }
}