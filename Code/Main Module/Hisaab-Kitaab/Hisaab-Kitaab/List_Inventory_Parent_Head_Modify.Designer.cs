namespace Hisaab_Kitaab
{
    partial class List_Inventory_Parent_Head_Modify
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
            this.button_Modify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Parent_Head_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Parent_Head_Code = new System.Windows.Forms.TextBox();
            this.label_AccParentHead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Modify
            // 
            this.button_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Modify.BackColor = System.Drawing.Color.White;
            this.button_Modify.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modify.Location = new System.Drawing.Point(403, 280);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(100, 35);
            this.button_Modify.TabIndex = 36;
            this.button_Modify.Text = "Modify";
            this.button_Modify.UseVisualStyleBackColor = false;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Parent Head Title";
            // 
            // textBox_Parent_Head_Title
            // 
            this.textBox_Parent_Head_Title.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Parent_Head_Title.Location = new System.Drawing.Point(251, 196);
            this.textBox_Parent_Head_Title.Name = "textBox_Parent_Head_Title";
            this.textBox_Parent_Head_Title.Size = new System.Drawing.Size(252, 26);
            this.textBox_Parent_Head_Title.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Parent Head Code";
            // 
            // textBox_Parent_Head_Code
            // 
            this.textBox_Parent_Head_Code.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Parent_Head_Code.Location = new System.Drawing.Point(251, 111);
            this.textBox_Parent_Head_Code.Name = "textBox_Parent_Head_Code";
            this.textBox_Parent_Head_Code.Size = new System.Drawing.Size(252, 26);
            this.textBox_Parent_Head_Code.TabIndex = 32;
            // 
            // label_AccParentHead
            // 
            this.label_AccParentHead.AutoSize = true;
            this.label_AccParentHead.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccParentHead.Location = new System.Drawing.Point(144, 33);
            this.label_AccParentHead.Name = "label_AccParentHead";
            this.label_AccParentHead.Size = new System.Drawing.Size(274, 22);
            this.label_AccParentHead.TabIndex = 31;
            this.label_AccParentHead.Text = " Modify Inventory Parent Head";
            // 
            // List_Inventory_Parent_Head_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 340);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Parent_Head_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Parent_Head_Code);
            this.Controls.Add(this.label_AccParentHead);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "List_Inventory_Parent_Head_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Inventory_Parent_Head_Modify";
            this.Load += new System.EventHandler(this.List_Inventory_Parent_Head_Modify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_AccParentHead;
        public System.Windows.Forms.TextBox textBox_Parent_Head_Title;
        public System.Windows.Forms.TextBox textBox_Parent_Head_Code;
    }
}