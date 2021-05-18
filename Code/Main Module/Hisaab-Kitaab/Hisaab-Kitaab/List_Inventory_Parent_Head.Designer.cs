namespace Hisaab_Kitaab
{
    partial class List_Inventory_Parent_Head
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
            this.labelCode = new System.Windows.Forms.Label();
            this.comboBox_SearchByAccHead = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAccHead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPropertiesAccHead = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_AccHead = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_AccParentHead = new System.Windows.Forms.Label();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Modify = new System.Windows.Forms.Button();
            this.comboBox_SearchByParentHead = new System.Windows.Forms.ComboBox();
            this.Button_Print = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.inventorysearch = new System.Windows.Forms.TextBox();
            this.tab_BalSheet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView_BSInvHead = new System.Windows.Forms.TreeView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccHead)).BeginInit();
            this.panel1.SuspendLayout();
            this.tab_BalSheet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(256, 36);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(116, 22);
            this.labelCode.TabIndex = 22;
            this.labelCode.Text = "Parent Code";
            this.labelCode.Click += new System.EventHandler(this.labelCode_Click);
            // 
            // comboBox_SearchByAccHead
            // 
            this.comboBox_SearchByAccHead.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SearchByAccHead.FormattingEnabled = true;
            this.comboBox_SearchByAccHead.Items.AddRange(new object[] {
            "Account Code",
            "Title"});
            this.comboBox_SearchByAccHead.Location = new System.Drawing.Point(115, 72);
            this.comboBox_SearchByAccHead.Name = "comboBox_SearchByAccHead";
            this.comboBox_SearchByAccHead.Size = new System.Drawing.Size(114, 23);
            this.comboBox_SearchByAccHead.TabIndex = 18;
            this.comboBox_SearchByAccHead.SelectedIndexChanged += new System.EventHandler(this.comboBox_SearchByAccHead_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::Hisaab_Kitaab.Properties.Resources.Search_3_01;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(553, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(260, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Search";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelAccHead
            // 
            this.labelAccHead.AutoSize = true;
            this.labelAccHead.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccHead.Location = new System.Drawing.Point(120, 5);
            this.labelAccHead.Name = "labelAccHead";
            this.labelAccHead.Size = new System.Drawing.Size(390, 22);
            this.labelAccHead.TabIndex = 15;
            this.labelAccHead.Text = "List of their Corresponding Inventory Heads";
            this.labelAccHead.Click += new System.EventHandler(this.labelAccHead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search by:";
            // 
            // buttonPropertiesAccHead
            // 
            this.buttonPropertiesAccHead.BackColor = System.Drawing.SystemColors.Window;
            this.buttonPropertiesAccHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPropertiesAccHead.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPropertiesAccHead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPropertiesAccHead.Location = new System.Drawing.Point(260, 572);
            this.buttonPropertiesAccHead.Name = "buttonPropertiesAccHead";
            this.buttonPropertiesAccHead.Size = new System.Drawing.Size(128, 38);
            this.buttonPropertiesAccHead.TabIndex = 21;
            this.buttonPropertiesAccHead.Text = "Properties";
            this.buttonPropertiesAccHead.UseVisualStyleBackColor = false;
            this.buttonPropertiesAccHead.Click += new System.EventHandler(this.buttonPropertiesAccHead_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelCode);
            this.panel2.Controls.Add(this.buttonPropertiesAccHead);
            this.panel2.Controls.Add(this.dataGridView_AccHead);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox_SearchByAccHead);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.labelAccHead);
            this.panel2.Location = new System.Drawing.Point(627, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 733);
            this.panel2.TabIndex = 18;
            // 
            // dataGridView_AccHead
            // 
            this.dataGridView_AccHead.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_AccHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AccHead.Location = new System.Drawing.Point(32, 143);
            this.dataGridView_AccHead.Name = "dataGridView_AccHead";
            this.dataGridView_AccHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AccHead.Size = new System.Drawing.Size(547, 399);
            this.dataGridView_AccHead.TabIndex = 20;
            this.dataGridView_AccHead.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AccHead_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Search by:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_AccParentHead);
            this.panel1.Controls.Add(this.Button_Add);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Button_Modify);
            this.panel1.Controls.Add(this.comboBox_SearchByParentHead);
            this.panel1.Controls.Add(this.Button_Print);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.inventorysearch);
            this.panel1.Controls.Add(this.tab_BalSheet);
            this.panel1.Location = new System.Drawing.Point(4, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 733);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_AccParentHead
            // 
            this.label_AccParentHead.AutoSize = true;
            this.label_AccParentHead.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccParentHead.ForeColor = System.Drawing.Color.Black;
            this.label_AccParentHead.Location = new System.Drawing.Point(188, 15);
            this.label_AccParentHead.Name = "label_AccParentHead";
            this.label_AccParentHead.Size = new System.Drawing.Size(272, 22);
            this.label_AccParentHead.TabIndex = 24;
            this.label_AccParentHead.Text = "List of Inventory Parent Heads";
            this.label_AccParentHead.Click += new System.EventHandler(this.label_AccParentHead_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.SystemColors.Window;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Add.Location = new System.Drawing.Point(21, 572);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(128, 38);
            this.Button_Add.TabIndex = 16;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Modify
            // 
            this.Button_Modify.BackColor = System.Drawing.SystemColors.Window;
            this.Button_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Modify.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Modify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Modify.Location = new System.Drawing.Point(245, 572);
            this.Button_Modify.Name = "Button_Modify";
            this.Button_Modify.Size = new System.Drawing.Size(128, 38);
            this.Button_Modify.TabIndex = 17;
            this.Button_Modify.Text = "Modify";
            this.Button_Modify.UseVisualStyleBackColor = false;
            this.Button_Modify.Click += new System.EventHandler(this.Button_Modify_Click);
            // 
            // comboBox_SearchByParentHead
            // 
            this.comboBox_SearchByParentHead.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SearchByParentHead.FormattingEnabled = true;
            this.comboBox_SearchByParentHead.Items.AddRange(new object[] {
            "Parent Code",
            "Title"});
            this.comboBox_SearchByParentHead.Location = new System.Drawing.Point(110, 71);
            this.comboBox_SearchByParentHead.Name = "comboBox_SearchByParentHead";
            this.comboBox_SearchByParentHead.Size = new System.Drawing.Size(114, 23);
            this.comboBox_SearchByParentHead.TabIndex = 21;
            // 
            // Button_Print
            // 
            this.Button_Print.BackColor = System.Drawing.SystemColors.Window;
            this.Button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Print.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Print.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Print.Location = new System.Drawing.Point(456, 572);
            this.Button_Print.Name = "Button_Print";
            this.Button_Print.Size = new System.Drawing.Size(128, 38);
            this.Button_Print.TabIndex = 18;
            this.Button_Print.Text = "Print List";
            this.Button_Print.UseVisualStyleBackColor = true;
            this.Button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::Hisaab_Kitaab.Properties.Resources.Search_3_01;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(548, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 26);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // inventorysearch
            // 
            this.inventorysearch.BackColor = System.Drawing.SystemColors.Window;
            this.inventorysearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorysearch.Location = new System.Drawing.Point(255, 70);
            this.inventorysearch.Name = "inventorysearch";
            this.inventorysearch.Size = new System.Drawing.Size(277, 26);
            this.inventorysearch.TabIndex = 19;
            this.inventorysearch.Text = "Search";
            this.inventorysearch.TextChanged += new System.EventHandler(this.inventorysearch_TextChanged);
            // 
            // tab_BalSheet
            // 
            this.tab_BalSheet.Controls.Add(this.tabPage1);
            this.tab_BalSheet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_BalSheet.Location = new System.Drawing.Point(21, 115);
            this.tab_BalSheet.Name = "tab_BalSheet";
            this.tab_BalSheet.SelectedIndex = 0;
            this.tab_BalSheet.Size = new System.Drawing.Size(563, 437);
            this.tab_BalSheet.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView_BSInvHead);
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
            // treeView_BSInvHead
            // 
            this.treeView_BSInvHead.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_BSInvHead.Location = new System.Drawing.Point(6, 6);
            this.treeView_BSInvHead.Name = "treeView_BSInvHead";
            this.treeView_BSInvHead.Size = new System.Drawing.Size(543, 393);
            this.treeView_BSInvHead.TabIndex = 0;
            this.treeView_BSInvHead.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_BSInvHead_AfterSelect);
            // 
            // List_Inventory_Parent_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "List_Inventory_Parent_Head";
            this.Text = "List_Inventory_Parent_Head";
            this.Load += new System.EventHandler(this.List_Inventory_Parent_Head_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccHead)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_BalSheet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.ComboBox comboBox_SearchByAccHead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAccHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPropertiesAccHead;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_AccHead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_AccParentHead;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Modify;
        private System.Windows.Forms.ComboBox comboBox_SearchByParentHead;
        private System.Windows.Forms.Button Button_Print;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox inventorysearch;
        private System.Windows.Forms.TabControl tab_BalSheet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView_BSInvHead;
    }
}