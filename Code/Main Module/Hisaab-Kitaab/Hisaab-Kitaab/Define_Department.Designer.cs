namespace Hisaab_Kitaab
{
    partial class Define_Department
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Dep = new System.Windows.Forms.DataGridView();
            this.button_SaveDep = new System.Windows.Forms.Button();
            this.button_CancelDep = new System.Windows.Forms.Button();
            this.label_Dep = new System.Windows.Forms.Label();
            this.textBox_DepID = new System.Windows.Forms.TextBox();
            this.textBox_DepName = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_DepName = new System.Windows.Forms.Label();
            this.button_AddDep = new System.Windows.Forms.Button();
            this.panel_Dep = new System.Windows.Forms.Panel();
            this.button_EditDep = new System.Windows.Forms.Button();
            this.button_DeleteDep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dep)).BeginInit();
            this.panel_Dep.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Dep
            // 
            this.dataGridView_Dep.AllowUserToAddRows = false;
            this.dataGridView_Dep.AllowUserToDeleteRows = false;
            this.dataGridView_Dep.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Dep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Dep.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Dep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Dep.EnableHeadersVisualStyles = false;
            this.dataGridView_Dep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dataGridView_Dep.Location = new System.Drawing.Point(23, 89);
            this.dataGridView_Dep.Name = "dataGridView_Dep";
            this.dataGridView_Dep.RowHeadersVisible = false;
            this.dataGridView_Dep.RowTemplate.Height = 24;
            this.dataGridView_Dep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Dep.Size = new System.Drawing.Size(356, 339);
            this.dataGridView_Dep.TabIndex = 0;
            // 
            // button_SaveDep
            // 
            this.button_SaveDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_SaveDep.Enabled = false;
            this.button_SaveDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveDep.ForeColor = System.Drawing.Color.White;
            this.button_SaveDep.Location = new System.Drawing.Point(579, 264);
            this.button_SaveDep.Name = "button_SaveDep";
            this.button_SaveDep.Size = new System.Drawing.Size(104, 46);
            this.button_SaveDep.TabIndex = 2;
            this.button_SaveDep.Text = "Save";
            this.button_SaveDep.UseVisualStyleBackColor = false;
            this.button_SaveDep.Visible = false;
            this.button_SaveDep.Click += new System.EventHandler(this.button_SaveDep_Click);
            // 
            // button_CancelDep
            // 
            this.button_CancelDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_CancelDep.Enabled = false;
            this.button_CancelDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CancelDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CancelDep.ForeColor = System.Drawing.Color.White;
            this.button_CancelDep.Location = new System.Drawing.Point(411, 264);
            this.button_CancelDep.Name = "button_CancelDep";
            this.button_CancelDep.Size = new System.Drawing.Size(104, 46);
            this.button_CancelDep.TabIndex = 3;
            this.button_CancelDep.Text = "Cancel";
            this.button_CancelDep.UseVisualStyleBackColor = false;
            this.button_CancelDep.Visible = false;
            this.button_CancelDep.Click += new System.EventHandler(this.button_CancelDep_Click);
            // 
            // label_Dep
            // 
            this.label_Dep.AutoSize = true;
            this.label_Dep.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_Dep.Location = new System.Drawing.Point(102, 26);
            this.label_Dep.Name = "label_Dep";
            this.label_Dep.Size = new System.Drawing.Size(168, 29);
            this.label_Dep.TabIndex = 4;
            this.label_Dep.Text = "Departments";
            // 
            // textBox_DepID
            // 
            this.textBox_DepID.Enabled = false;
            this.textBox_DepID.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DepID.Location = new System.Drawing.Point(53, 12);
            this.textBox_DepID.Name = "textBox_DepID";
            this.textBox_DepID.Size = new System.Drawing.Size(100, 29);
            this.textBox_DepID.TabIndex = 0;
            // 
            // textBox_DepName
            // 
            this.textBox_DepName.Enabled = false;
            this.textBox_DepName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DepName.Location = new System.Drawing.Point(9, 83);
            this.textBox_DepName.Name = "textBox_DepName";
            this.textBox_DepName.Size = new System.Drawing.Size(256, 29);
            this.textBox_DepName.TabIndex = 1;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_ID.Location = new System.Drawing.Point(5, 12);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(42, 24);
            this.label_ID.TabIndex = 6;
            this.label_ID.Text = "ID:";
            // 
            // label_DepName
            // 
            this.label_DepName.AutoSize = true;
            this.label_DepName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DepName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_DepName.Location = new System.Drawing.Point(5, 56);
            this.label_DepName.Name = "label_DepName";
            this.label_DepName.Size = new System.Drawing.Size(127, 24);
            this.label_DepName.TabIndex = 7;
            this.label_DepName.Text = "Dep Name: ";
            // 
            // button_AddDep
            // 
            this.button_AddDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_AddDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddDep.ForeColor = System.Drawing.Color.White;
            this.button_AddDep.Location = new System.Drawing.Point(389, 382);
            this.button_AddDep.Name = "button_AddDep";
            this.button_AddDep.Size = new System.Drawing.Size(103, 46);
            this.button_AddDep.TabIndex = 1;
            this.button_AddDep.Text = "Add";
            this.button_AddDep.UseVisualStyleBackColor = false;
            this.button_AddDep.Click += new System.EventHandler(this.button_AddDep_Click);
            // 
            // panel_Dep
            // 
            this.panel_Dep.Controls.Add(this.label_DepName);
            this.panel_Dep.Controls.Add(this.textBox_DepID);
            this.panel_Dep.Controls.Add(this.textBox_DepName);
            this.panel_Dep.Controls.Add(this.label_ID);
            this.panel_Dep.Location = new System.Drawing.Point(411, 129);
            this.panel_Dep.Name = "panel_Dep";
            this.panel_Dep.Size = new System.Drawing.Size(272, 129);
            this.panel_Dep.TabIndex = 6;
            // 
            // button_EditDep
            // 
            this.button_EditDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_EditDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EditDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EditDep.ForeColor = System.Drawing.Color.White;
            this.button_EditDep.Location = new System.Drawing.Point(607, 382);
            this.button_EditDep.Name = "button_EditDep";
            this.button_EditDep.Size = new System.Drawing.Size(103, 46);
            this.button_EditDep.TabIndex = 7;
            this.button_EditDep.Text = "Edit";
            this.button_EditDep.UseVisualStyleBackColor = false;
            this.button_EditDep.Click += new System.EventHandler(this.button_EditDep_Click);
            // 
            // button_DeleteDep
            // 
            this.button_DeleteDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.button_DeleteDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteDep.ForeColor = System.Drawing.Color.White;
            this.button_DeleteDep.Location = new System.Drawing.Point(498, 382);
            this.button_DeleteDep.Name = "button_DeleteDep";
            this.button_DeleteDep.Size = new System.Drawing.Size(103, 46);
            this.button_DeleteDep.TabIndex = 8;
            this.button_DeleteDep.Text = "Delete";
            this.button_DeleteDep.UseVisualStyleBackColor = false;
            // 
            // Define_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 480);
            this.Controls.Add(this.button_DeleteDep);
            this.Controls.Add(this.button_EditDep);
            this.Controls.Add(this.panel_Dep);
            this.Controls.Add(this.label_Dep);
            this.Controls.Add(this.button_SaveDep);
            this.Controls.Add(this.button_AddDep);
            this.Controls.Add(this.dataGridView_Dep);
            this.Controls.Add(this.button_CancelDep);
            this.Name = "Define_Department";
            this.Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dep)).EndInit();
            this.panel_Dep.ResumeLayout(false);
            this.panel_Dep.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Dep;
        private System.Windows.Forms.Button button_SaveDep;
        private System.Windows.Forms.Button button_CancelDep;
        private System.Windows.Forms.Label label_Dep;
        private System.Windows.Forms.Label label_DepName;
        private System.Windows.Forms.TextBox textBox_DepName;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_DepID;
        private System.Windows.Forms.Button button_AddDep;
        private System.Windows.Forms.Panel panel_Dep;
        private System.Windows.Forms.Button button_EditDep;
        private System.Windows.Forms.Button button_DeleteDep;
    }
}