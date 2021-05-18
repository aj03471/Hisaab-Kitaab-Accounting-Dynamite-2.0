namespace Hisaab_Kitaab
{
    partial class ListAccountHead_Tree
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView_BSAccHead = new System.Windows.Forms.TreeView();
            this.button_execStoredProd = new System.Windows.Forms.Button();
            this.treeView_IncAccHead = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(50, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 384);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView_BSAccHead);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Balance Sheet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView_IncAccHead);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(427, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Income Statement";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView_BSAccHead
            // 
            this.treeView_BSAccHead.Location = new System.Drawing.Point(6, 6);
            this.treeView_BSAccHead.Name = "treeView_BSAccHead";
            this.treeView_BSAccHead.Size = new System.Drawing.Size(418, 346);
            this.treeView_BSAccHead.TabIndex = 0;
            // 
            // button_execStoredProd
            // 
            this.button_execStoredProd.Location = new System.Drawing.Point(491, 45);
            this.button_execStoredProd.Name = "button_execStoredProd";
            this.button_execStoredProd.Size = new System.Drawing.Size(75, 23);
            this.button_execStoredProd.TabIndex = 2;
            this.button_execStoredProd.Text = "button1";
            this.button_execStoredProd.UseVisualStyleBackColor = true;
            this.button_execStoredProd.Click += new System.EventHandler(this.button_execStoredProd_Click);
            // 
            // treeView_IncAccHead
            // 
            this.treeView_IncAccHead.Location = new System.Drawing.Point(4, 6);
            this.treeView_IncAccHead.Name = "treeView_IncAccHead";
            this.treeView_IncAccHead.Size = new System.Drawing.Size(418, 346);
            this.treeView_IncAccHead.TabIndex = 1;
            this.treeView_IncAccHead.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Inc_AfterSelect);
            // 
            // ListAccountHead_Tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_execStoredProd);
            this.Controls.Add(this.tabControl1);
            this.Name = "ListAccountHead_Tree";
            this.Text = "ListAccountHead_Tree";
            this.Load += new System.EventHandler(this.ListAccountHead_Tree_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView_BSAccHead;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_execStoredProd;
        private System.Windows.Forms.TreeView treeView_IncAccHead;
    }
}