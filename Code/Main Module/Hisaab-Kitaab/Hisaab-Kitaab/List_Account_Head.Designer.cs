namespace Hisaab_Kitaab
{
    partial class List_Account_Head
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
            this.components = new System.ComponentModel.Container();
            this.aCCOUNTHEADSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbconnection = new Hisaab_Kitaab.dbconnection();
            this.label_AccParentHead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SearchByParentHead = new System.Windows.Forms.ComboBox();
            this.search2 = new System.Windows.Forms.TextBox();
            this.aCCOUNT_HEADSTableAdapter = new Hisaab_Kitaab.dbconnectionTableAdapters.ACCOUNT_HEADSTableAdapter();
            this.aDS_2DataSet = new Hisaab_Kitaab.ADS_2DataSet();
            this.aCCOUNTHEADSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNT_HEADSTableAdapter1 = new Hisaab_Kitaab.ADS_2DataSetTableAdapters.ACCOUNT_HEADSTableAdapter();
            this.dataGridView_AccHead = new System.Windows.Forms.DataGridView();
            this.AccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCard = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Attributes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Depriciation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PictureChoice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aCCOUNTHEADSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Button_AccPrint = new System.Windows.Forms.Button();
            this.Button_AccAdd = new System.Windows.Forms.Button();
            this.Button_AccProperties = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTHEADSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbconnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDS_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTHEADSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTHEADSBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // aCCOUNTHEADSBindingSource
            // 
            this.aCCOUNTHEADSBindingSource.DataMember = "ACCOUNT_HEADS";
            this.aCCOUNTHEADSBindingSource.DataSource = this.dbconnection;
            // 
            // dbconnection
            // 
            this.dbconnection.DataSetName = "dbconnection";
            this.dbconnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_AccParentHead
            // 
            this.label_AccParentHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_AccParentHead.AutoSize = true;
            this.label_AccParentHead.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccParentHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label_AccParentHead.Location = new System.Drawing.Point(548, 46);
            this.label_AccParentHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AccParentHead.Name = "label_AccParentHead";
            this.label_AccParentHead.Size = new System.Drawing.Size(271, 29);
            this.label_AccParentHead.TabIndex = 29;
            this.label_AccParentHead.Text = "List of Account Heads";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(267, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Search by:";
            // 
            // comboBox_SearchByParentHead
            // 
            this.comboBox_SearchByParentHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_SearchByParentHead.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SearchByParentHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.comboBox_SearchByParentHead.FormattingEnabled = true;
            this.comboBox_SearchByParentHead.Items.AddRange(new object[] {
            "Parent Code",
            "Title"});
            this.comboBox_SearchByParentHead.Location = new System.Drawing.Point(383, 116);
            this.comboBox_SearchByParentHead.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_SearchByParentHead.Name = "comboBox_SearchByParentHead";
            this.comboBox_SearchByParentHead.Size = new System.Drawing.Size(151, 32);
            this.comboBox_SearchByParentHead.TabIndex = 27;
            // 
            // search2
            // 
            this.search2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search2.BackColor = System.Drawing.SystemColors.Window;
            this.search2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.search2.Location = new System.Drawing.Point(574, 116);
            this.search2.Margin = new System.Windows.Forms.Padding(4);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(482, 32);
            this.search2.TabIndex = 25;
            this.search2.Text = "Search";
            // 
            // aCCOUNT_HEADSTableAdapter
            // 
            this.aCCOUNT_HEADSTableAdapter.ClearBeforeFill = true;
            // 
            // aDS_2DataSet
            // 
            this.aDS_2DataSet.DataSetName = "ADS_2DataSet";
            this.aDS_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCCOUNTHEADSBindingSource1
            // 
            this.aCCOUNTHEADSBindingSource1.DataMember = "ACCOUNT_HEADS";
            this.aCCOUNTHEADSBindingSource1.DataSource = this.aDS_2DataSet;
            // 
            // aCCOUNT_HEADSTableAdapter1
            // 
            this.aCCOUNT_HEADSTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView_AccHead
            // 
            this.dataGridView_AccHead.AllowUserToAddRows = false;
            this.dataGridView_AccHead.AllowUserToDeleteRows = false;
            this.dataGridView_AccHead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_AccHead.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_AccHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_AccHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AccHead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountCode,
            this.ParentCode,
            this.ParentTitle,
            this.AccountTitle,
            this.AddressCard,
            this.Attributes,
            this.Depriciation,
            this.PictureChoice});
            this.dataGridView_AccHead.Location = new System.Drawing.Point(83, 179);
            this.dataGridView_AccHead.Name = "dataGridView_AccHead";
            this.dataGridView_AccHead.RowTemplate.Height = 24;
            this.dataGridView_AccHead.Size = new System.Drawing.Size(1174, 535);
            this.dataGridView_AccHead.TabIndex = 33;
            // 
            // AccountCode
            // 
            this.AccountCode.DataPropertyName = "Account Code";
            this.AccountCode.HeaderText = "Account Code";
            this.AccountCode.MinimumWidth = 50;
            this.AccountCode.Name = "AccountCode";
            this.AccountCode.Width = 90;
            // 
            // ParentCode
            // 
            this.ParentCode.DataPropertyName = "Parent Code";
            this.ParentCode.HeaderText = "Parent Code";
            this.ParentCode.MinimumWidth = 50;
            this.ParentCode.Name = "ParentCode";
            this.ParentCode.Width = 150;
            // 
            // ParentTitle
            // 
            this.ParentTitle.DataPropertyName = "Parent Title";
            this.ParentTitle.HeaderText = "Parent Title";
            this.ParentTitle.MinimumWidth = 50;
            this.ParentTitle.Name = "ParentTitle";
            this.ParentTitle.Visible = false;
            // 
            // AccountTitle
            // 
            this.AccountTitle.DataPropertyName = "Account Title";
            this.AccountTitle.HeaderText = "Account Title";
            this.AccountTitle.MinimumWidth = 50;
            this.AccountTitle.Name = "AccountTitle";
            this.AccountTitle.Width = 150;
            // 
            // AddressCard
            // 
            this.AddressCard.DataPropertyName = "Address";
            this.AddressCard.FalseValue = "0";
            this.AddressCard.HeaderText = "Address";
            this.AddressCard.IndeterminateValue = "0";
            this.AddressCard.MinimumWidth = 50;
            this.AddressCard.Name = "AddressCard";
            this.AddressCard.ReadOnly = true;
            this.AddressCard.TrueValue = "1";
            // 
            // Attributes
            // 
            this.Attributes.DataPropertyName = "Attributes";
            this.Attributes.FalseValue = "0";
            this.Attributes.HeaderText = "Attributes";
            this.Attributes.IndeterminateValue = "0";
            this.Attributes.MinimumWidth = 50;
            this.Attributes.Name = "Attributes";
            this.Attributes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Attributes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Attributes.TrueValue = "1";
            // 
            // Depriciation
            // 
            this.Depriciation.DataPropertyName = "Depriciation";
            this.Depriciation.FalseValue = "0";
            this.Depriciation.HeaderText = "Depriciation";
            this.Depriciation.IndeterminateValue = "0";
            this.Depriciation.MinimumWidth = 50;
            this.Depriciation.Name = "Depriciation";
            this.Depriciation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Depriciation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Depriciation.TrueValue = "1";
            this.Depriciation.Width = 102;
            // 
            // PictureChoice
            // 
            this.PictureChoice.DataPropertyName = "Depriciation Yearly Rate";
            this.PictureChoice.FalseValue = "0";
            this.PictureChoice.HeaderText = "Picture Choice";
            this.PictureChoice.IndeterminateValue = "0";
            this.PictureChoice.MinimumWidth = 50;
            this.PictureChoice.Name = "PictureChoice";
            this.PictureChoice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PictureChoice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PictureChoice.TrueValue = "1";
            // 
            // aCCOUNTHEADSBindingSource2
            // 
            this.aCCOUNTHEADSBindingSource2.DataMember = "ACCOUNT_HEADS";
            this.aCCOUNTHEADSBindingSource2.DataSource = this.aDS_2DataSet;
            // 
            // Button_AccPrint
            // 
            this.Button_AccPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_AccPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.Button_AccPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AccPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AccPrint.ForeColor = System.Drawing.Color.White;
            this.Button_AccPrint.Location = new System.Drawing.Point(708, 747);
            this.Button_AccPrint.Margin = new System.Windows.Forms.Padding(4);
            this.Button_AccPrint.Name = "Button_AccPrint";
            this.Button_AccPrint.Size = new System.Drawing.Size(171, 47);
            this.Button_AccPrint.TabIndex = 42;
            this.Button_AccPrint.Text = "Print List";
            this.Button_AccPrint.UseVisualStyleBackColor = false;
            this.Button_AccPrint.Click += new System.EventHandler(this.Button_AccPrint_Click_1);
            // 
            // Button_AccAdd
            // 
            this.Button_AccAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_AccAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.Button_AccAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AccAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AccAdd.ForeColor = System.Drawing.Color.White;
            this.Button_AccAdd.Location = new System.Drawing.Point(245, 747);
            this.Button_AccAdd.Margin = new System.Windows.Forms.Padding(4);
            this.Button_AccAdd.Name = "Button_AccAdd";
            this.Button_AccAdd.Size = new System.Drawing.Size(171, 47);
            this.Button_AccAdd.TabIndex = 40;
            this.Button_AccAdd.Text = "Add";
            this.Button_AccAdd.UseVisualStyleBackColor = false;
            this.Button_AccAdd.Click += new System.EventHandler(this.Button_AccAdd_Click_2);
            // 
            // Button_AccProperties
            // 
            this.Button_AccProperties.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_AccProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.Button_AccProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AccProperties.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AccProperties.ForeColor = System.Drawing.Color.White;
            this.Button_AccProperties.Location = new System.Drawing.Point(481, 747);
            this.Button_AccProperties.Margin = new System.Windows.Forms.Padding(4);
            this.Button_AccProperties.Name = "Button_AccProperties";
            this.Button_AccProperties.Size = new System.Drawing.Size(171, 47);
            this.Button_AccProperties.TabIndex = 41;
            this.Button_AccProperties.Text = "Properties";
            this.Button_AccProperties.UseVisualStyleBackColor = false;
            this.Button_AccProperties.Click += new System.EventHandler(this.Button_AccProperties_Click);
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::Hisaab_Kitaab.Properties.Resources.Search_3_01;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(1079, 116);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 32);
            this.button4.TabIndex = 26;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(943, 747);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(171, 47);
            this.buttonRemove.TabIndex = 43;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // List_Account_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1331, 844);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.Button_AccPrint);
            this.Controls.Add(this.Button_AccAdd);
            this.Controls.Add(this.Button_AccProperties);
            this.Controls.Add(this.dataGridView_AccHead);
            this.Controls.Add(this.label_AccParentHead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_SearchByParentHead);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.search2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "List_Account_Head";
            this.Text = "List_Account_Head";
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTHEADSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbconnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDS_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTHEADSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTHEADSBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_AccParentHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_SearchByParentHead;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox search2;
        private dbconnection dbconnection;
        private System.Windows.Forms.BindingSource aCCOUNTHEADSBindingSource;
        private dbconnectionTableAdapters.ACCOUNT_HEADSTableAdapter aCCOUNT_HEADSTableAdapter;
        private ADS_2DataSet aDS_2DataSet;
        private System.Windows.Forms.BindingSource aCCOUNTHEADSBindingSource1;
        private ADS_2DataSetTableAdapters.ACCOUNT_HEADSTableAdapter aCCOUNT_HEADSTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView_AccHead;
        private System.Windows.Forms.BindingSource aCCOUNTHEADSBindingSource2;
        private System.Windows.Forms.Button Button_AccPrint;
        private System.Windows.Forms.Button Button_AccAdd;
        private System.Windows.Forms.Button Button_AccProperties;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountTitle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AddressCard;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attributes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Depriciation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PictureChoice;
    }
}