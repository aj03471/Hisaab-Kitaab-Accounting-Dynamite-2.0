namespace Hisaab_Kitaab
{
    partial class ParentTitlePrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentTitlePrintForm));
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.companyname = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.parentstart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.image3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.parentend = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.image3)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(830, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 37);
            this.label15.TabIndex = 75;
            this.label15.Text = "Logo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1051, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 56);
            this.button1.TabIndex = 77;
            this.button1.Text = "UPLOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 37);
            this.label2.TabIndex = 79;
            this.label2.Text = "Company Name";
            // 
            // companyname
            // 
            this.companyname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.companyname.Location = new System.Drawing.Point(277, 184);
            this.companyname.Name = "companyname";
            this.companyname.Size = new System.Drawing.Size(487, 45);
            this.companyname.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(535, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(423, 43);
            this.label17.TabIndex = 80;
            this.label17.Text = "Parent Title Print Form ";
            // 
            // parentstart
            // 
            this.parentstart.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.parentstart.Location = new System.Drawing.Point(277, 281);
            this.parentstart.Name = "parentstart";
            this.parentstart.Size = new System.Drawing.Size(487, 45);
            this.parentstart.TabIndex = 81;
            this.parentstart.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 82;
            this.label1.Text = "Start Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // image3
            // 
            this.image3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image3.Location = new System.Drawing.Point(960, 184);
            this.image3.Margin = new System.Windows.Forms.Padding(6);
            this.image3.Name = "image3";
            this.image3.Size = new System.Drawing.Size(342, 292);
            this.image3.TabIndex = 76;
            this.image3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(707, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 65);
            this.button2.TabIndex = 83;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(64, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 37);
            this.label3.TabIndex = 85;
            this.label3.Text = "End Code";
            // 
            // parentend
            // 
            this.parentend.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.parentend.Location = new System.Drawing.Point(277, 382);
            this.parentend.Name = "parentend";
            this.parentend.Size = new System.Drawing.Size(487, 45);
            this.parentend.TabIndex = 84;
            // 
            // ParentTitlePrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1494, 664);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.parentend);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parentstart);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.image3);
            this.Controls.Add(this.label15);
            this.Name = "ParentTitlePrintForm";
            this.Text = "ParantTitlePrintForm";
            this.Load += new System.EventHandler(this.ParentTitlePrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companyname;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox parentstart;
        public System.Windows.Forms.TextBox parentend;
    }
}