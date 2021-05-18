namespace Hisaab_Kitaab
{
    partial class Dialogue_Box_Parent_Head
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
            this.tab_BalSheet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ParenHeadTree = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView_IncAccHead = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.labelHeading = new System.Windows.Forms.Label();
            this.tab_BalSheet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_BalSheet
            // 
            this.tab_BalSheet.Controls.Add(this.tabPage1);
            this.tab_BalSheet.Controls.Add(this.tabPage2);
            this.tab_BalSheet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_BalSheet.Location = new System.Drawing.Point(34, 181);
            this.tab_BalSheet.Margin = new System.Windows.Forms.Padding(6);
            this.tab_BalSheet.Name = "tab_BalSheet";
            this.tab_BalSheet.SelectedIndex = 0;
            this.tab_BalSheet.Size = new System.Drawing.Size(1126, 841);
            this.tab_BalSheet.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ParenHeadTree);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Location = new System.Drawing.Point(8, 51);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1110, 782);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Balance Sheet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ParenHeadTree
            // 
            this.ParenHeadTree.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParenHeadTree.Location = new System.Drawing.Point(12, 11);
            this.ParenHeadTree.Margin = new System.Windows.Forms.Padding(6);
            this.ParenHeadTree.Name = "ParenHeadTree";
            this.ParenHeadTree.Size = new System.Drawing.Size(1082, 752);
            this.ParenHeadTree.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView_IncAccHead);
            this.tabPage2.Location = new System.Drawing.Point(8, 51);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1110, 782);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Income Statement";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView_IncAccHead
            // 
            this.treeView_IncAccHead.Location = new System.Drawing.Point(12, 11);
            this.treeView_IncAccHead.Margin = new System.Windows.Forms.Padding(6);
            this.treeView_IncAccHead.Name = "treeView_IncAccHead";
            this.treeView_IncAccHead.Size = new System.Drawing.Size(1082, 752);
            this.treeView_IncAccHead.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.button1.Location = new System.Drawing.Point(529, 1031);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 57);
            this.button1.TabIndex = 25;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHeading
            // 
            this.labelHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelHeading.Location = new System.Drawing.Point(471, 73);
            this.labelHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(242, 44);
            this.labelHeading.TabIndex = 26;
            this.labelHeading.Text = "Parent Head ";
            // 
            // Dialogue_Box_Parent_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 1118);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tab_BalSheet);
            this.Name = "Dialogue_Box_Parent_Head";
            this.Text = "Dialogue_Box_Parent_Head";
            this.Load += new System.EventHandler(this.Dialogue_Box_Parent_Head_Load);
            this.tab_BalSheet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_BalSheet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeView_IncAccHead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHeading;
        public System.Windows.Forms.TreeView ParenHeadTree;
    }
}