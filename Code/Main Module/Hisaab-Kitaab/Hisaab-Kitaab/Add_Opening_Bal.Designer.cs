namespace Hisaab_Kitaab
{
    partial class Add_Opening_Bal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonCredit = new System.Windows.Forms.RadioButton();
            this.radioButtonDebit = new System.Windows.Forms.RadioButton();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAccCode = new System.Windows.Forms.Label();
            this.textBoxAccCode = new System.Windows.Forms.TextBox();
            this.labelAccHead = new System.Windows.Forms.Label();
            this.textBoxAccTitle = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Dep = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonCredit);
            this.panel1.Controls.Add(this.radioButtonDebit);
            this.panel1.Location = new System.Drawing.Point(461, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 84);
            this.panel1.TabIndex = 165;
            // 
            // radioButtonCredit
            // 
            this.radioButtonCredit.AutoSize = true;
            this.radioButtonCredit.Location = new System.Drawing.Point(21, 42);
            this.radioButtonCredit.Name = "radioButtonCredit";
            this.radioButtonCredit.Size = new System.Drawing.Size(84, 28);
            this.radioButtonCredit.TabIndex = 1;
            this.radioButtonCredit.TabStop = true;
            this.radioButtonCredit.Text = "Credit";
            this.radioButtonCredit.UseVisualStyleBackColor = true;
            // 
            // radioButtonDebit
            // 
            this.radioButtonDebit.AutoSize = true;
            this.radioButtonDebit.Location = new System.Drawing.Point(21, 8);
            this.radioButtonDebit.Name = "radioButtonDebit";
            this.radioButtonDebit.Size = new System.Drawing.Size(79, 28);
            this.radioButtonDebit.TabIndex = 0;
            this.radioButtonDebit.TabStop = true;
            this.radioButtonDebit.Text = "Debit";
            this.radioButtonDebit.UseVisualStyleBackColor = true;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.buttonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoose.ForeColor = System.Drawing.Color.White;
            this.buttonChoose.Location = new System.Drawing.Point(443, 98);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(142, 44);
            this.buttonChoose.TabIndex = 164;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = false;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 216);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 32);
            this.dateTimePicker1.TabIndex = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 162;
            this.label1.Text = "Date:";
            // 
            // labelAccCode
            // 
            this.labelAccCode.AutoSize = true;
            this.labelAccCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccCode.Location = new System.Drawing.Point(25, 108);
            this.labelAccCode.Name = "labelAccCode";
            this.labelAccCode.Size = new System.Drawing.Size(155, 24);
            this.labelAccCode.TabIndex = 161;
            this.labelAccCode.Text = "Account Code:";
            // 
            // textBoxAccCode
            // 
            this.textBoxAccCode.Location = new System.Drawing.Point(202, 105);
            this.textBoxAccCode.Name = "textBoxAccCode";
            this.textBoxAccCode.ReadOnly = true;
            this.textBoxAccCode.Size = new System.Drawing.Size(216, 32);
            this.textBoxAccCode.TabIndex = 160;
            // 
            // labelAccHead
            // 
            this.labelAccHead.AutoSize = true;
            this.labelAccHead.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccHead.Location = new System.Drawing.Point(31, 163);
            this.labelAccHead.Name = "labelAccHead";
            this.labelAccHead.Size = new System.Drawing.Size(149, 24);
            this.labelAccHead.TabIndex = 159;
            this.labelAccHead.Text = "Account Title:";
            // 
            // textBoxAccTitle
            // 
            this.textBoxAccTitle.Location = new System.Drawing.Point(202, 160);
            this.textBoxAccTitle.Name = "textBoxAccTitle";
            this.textBoxAccTitle.ReadOnly = true;
            this.textBoxAccTitle.Size = new System.Drawing.Size(383, 32);
            this.textBoxAccTitle.TabIndex = 158;
            // 
            // button_Save
            // 
            this.button_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(226, 337);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(192, 44);
            this.button_Save.TabIndex = 157;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label_Dep
            // 
            this.label_Dep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Dep.AutoSize = true;
            this.label_Dep.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Dep.Location = new System.Drawing.Point(137, 28);
            this.label_Dep.Name = "label_Dep";
            this.label_Dep.Size = new System.Drawing.Size(396, 29);
            this.label_Dep.TabIndex = 156;
            this.label_Dep.Text = "Account Head Opening Balances";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(84, 271);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(96, 24);
            this.labelAmount.TabIndex = 167;
            this.labelAmount.Text = "Amount:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(202, 268);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(236, 32);
            this.textBoxAmount.TabIndex = 166;
            // 
            // Add_Opening_Bal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAccCode);
            this.Controls.Add(this.textBoxAccCode);
            this.Controls.Add(this.labelAccHead);
            this.Controls.Add(this.textBoxAccTitle);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_Dep);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxAmount);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Add_Opening_Bal";
            this.Text = "Add_Opening_Bal";
            this.Load += new System.EventHandler(this.Add_Opening_Bal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonCredit;
        private System.Windows.Forms.RadioButton radioButtonDebit;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAccCode;
        private System.Windows.Forms.TextBox textBoxAccCode;
        private System.Windows.Forms.Label labelAccHead;
        private System.Windows.Forms.TextBox textBoxAccTitle;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_Dep;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
    }
}