namespace Hisaab_Kitaab
{
    partial class ListInventoryAttributesChoose
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
            this.tab_BalSheet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView_BSAccHead = new System.Windows.Forms.TreeView();
            this.Button_Add = new System.Windows.Forms.Button();
            this.tab_BalSheet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_InvParentHead
            // 
            this.label_InvParentHead.AutoSize = true;
            this.label_InvParentHead.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InvParentHead.Location = new System.Drawing.Point(209, 26);
            this.label_InvParentHead.Name = "label_InvParentHead";
            this.label_InvParentHead.Size = new System.Drawing.Size(184, 22);
            this.label_InvParentHead.TabIndex = 36;
            this.label_InvParentHead.Text = "List of Parent Heads";
            // 
            // tab_BalSheet
            // 
            this.tab_BalSheet.Controls.Add(this.tabPage1);
            this.tab_BalSheet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_BalSheet.Location = new System.Drawing.Point(23, 73);
            this.tab_BalSheet.Name = "tab_BalSheet";
            this.tab_BalSheet.SelectedIndex = 0;
            this.tab_BalSheet.Size = new System.Drawing.Size(563, 437);
            this.tab_BalSheet.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView_BSAccHead);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Balance Sheet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView_BSAccHead
            // 
            this.treeView_BSAccHead.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_BSAccHead.Location = new System.Drawing.Point(6, 6);
            this.treeView_BSAccHead.Name = "treeView_BSAccHead";
            this.treeView_BSAccHead.Size = new System.Drawing.Size(543, 393);
            this.treeView_BSAccHead.TabIndex = 0;
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.SystemColors.Window;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Add.Location = new System.Drawing.Point(224, 530);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(128, 38);
            this.Button_Add.TabIndex = 34;
            this.Button_Add.Text = "OK";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // ListInventoryAttributesChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 595);
            this.Controls.Add(this.label_InvParentHead);
            this.Controls.Add(this.tab_BalSheet);
            this.Controls.Add(this.Button_Add);
            this.Name = "ListInventoryAttributesChoose";
            this.Text = "List Inventory Attributes - Choose";
            this.Load += new System.EventHandler(this.ListInventoryAttributesChoose_Load);
            this.tab_BalSheet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InvParentHead;
        private System.Windows.Forms.TabControl tab_BalSheet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView_BSAccHead;
        private System.Windows.Forms.Button Button_Add;
    }
}