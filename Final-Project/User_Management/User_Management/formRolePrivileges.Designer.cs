namespace User_Management
{
    partial class formRolePrivileges
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
            this.dataGridViewRolePrivileges = new System.Windows.Forms.DataGridView();
            this.rOLENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVILEGENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVILEGETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLEPRIVILEGESVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOracle = new User_Management.DataSetOracle();
            this.dataGridViewUserRolePrivileges = new System.Windows.Forms.DataGridView();
            this.uSERORROLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLENAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINOPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERROLEASSIGNMENTSVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOLE_PRIVILEGES_VIEWTableAdapter = new User_Management.DataSetOracleTableAdapters.ROLE_PRIVILEGES_VIEWTableAdapter();
            this.uSER_ROLE_ASSIGNMENTS_VIEWTableAdapter = new User_Management.DataSetOracleTableAdapters.USER_ROLE_ASSIGNMENTS_VIEWTableAdapter();
            this.button_Back = new System.Windows.Forms.Button();
            this.textBox_RoleName1 = new System.Windows.Forms.TextBox();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Revoke = new System.Windows.Forms.Button();
            this.button_Grant = new System.Windows.Forms.Button();
            this.button_Drop = new System.Windows.Forms.Button();
            this.button_Alter = new System.Windows.Forms.Button();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLLUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_AllUser = new User_Management.DataSet_AllUser();
            this.aLL_USERTableAdapter = new User_Management.DataSet_AllUserTableAdapters.ALL_USERTableAdapter();
            this.textBox_RoleName2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRolePrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEPRIVILEGESVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserRolePrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERROLEASSIGNMENTSVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_AllUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRolePrivileges
            // 
            this.dataGridViewRolePrivileges.AutoGenerateColumns = false;
            this.dataGridViewRolePrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRolePrivileges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rOLENAMEDataGridViewTextBoxColumn,
            this.pRIVILEGENAMEDataGridViewTextBoxColumn,
            this.pRIVILEGETYPEDataGridViewTextBoxColumn});
            this.dataGridViewRolePrivileges.DataSource = this.rOLEPRIVILEGESVIEWBindingSource;
            this.dataGridViewRolePrivileges.Location = new System.Drawing.Point(548, 269);
            this.dataGridViewRolePrivileges.Name = "dataGridViewRolePrivileges";
            this.dataGridViewRolePrivileges.RowHeadersVisible = false;
            this.dataGridViewRolePrivileges.Size = new System.Drawing.Size(370, 359);
            this.dataGridViewRolePrivileges.TabIndex = 0;
            this.dataGridViewRolePrivileges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRolePrivileges_CellContentClick);
            this.dataGridViewRolePrivileges.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRolePrivileges_CellContentClick);
            // 
            // rOLENAMEDataGridViewTextBoxColumn
            // 
            this.rOLENAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.rOLENAMEDataGridViewTextBoxColumn.DataPropertyName = "ROLE_NAME";
            this.rOLENAMEDataGridViewTextBoxColumn.HeaderText = "ROLE_NAME";
            this.rOLENAMEDataGridViewTextBoxColumn.Name = "rOLENAMEDataGridViewTextBoxColumn";
            this.rOLENAMEDataGridViewTextBoxColumn.Width = 98;
            // 
            // pRIVILEGENAMEDataGridViewTextBoxColumn
            // 
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.DataPropertyName = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.HeaderText = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.Name = "pRIVILEGENAMEDataGridViewTextBoxColumn";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRIVILEGETYPEDataGridViewTextBoxColumn
            // 
            this.pRIVILEGETYPEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pRIVILEGETYPEDataGridViewTextBoxColumn.DataPropertyName = "PRIVILEGE_TYPE";
            this.pRIVILEGETYPEDataGridViewTextBoxColumn.HeaderText = "PRIVILEGE_TYPE";
            this.pRIVILEGETYPEDataGridViewTextBoxColumn.Name = "pRIVILEGETYPEDataGridViewTextBoxColumn";
            this.pRIVILEGETYPEDataGridViewTextBoxColumn.Width = 122;
            // 
            // rOLEPRIVILEGESVIEWBindingSource
            // 
            this.rOLEPRIVILEGESVIEWBindingSource.DataMember = "ROLE_PRIVILEGES_VIEW";
            this.rOLEPRIVILEGESVIEWBindingSource.DataSource = this.dataSetOracle;
            // 
            // dataSetOracle
            // 
            this.dataSetOracle.DataSetName = "DataSetOracle";
            this.dataSetOracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewUserRolePrivileges
            // 
            this.dataGridViewUserRolePrivileges.AutoGenerateColumns = false;
            this.dataGridViewUserRolePrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserRolePrivileges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERORROLEDataGridViewTextBoxColumn,
            this.rOLENAMEDataGridViewTextBoxColumn1,
            this.aDMINOPTIONDataGridViewTextBoxColumn,
            this.cREATEDDataGridViewTextBoxColumn});
            this.dataGridViewUserRolePrivileges.DataSource = this.uSERROLEASSIGNMENTSVIEWBindingSource;
            this.dataGridViewUserRolePrivileges.Location = new System.Drawing.Point(934, 269);
            this.dataGridViewUserRolePrivileges.Name = "dataGridViewUserRolePrivileges";
            this.dataGridViewUserRolePrivileges.RowHeadersVisible = false;
            this.dataGridViewUserRolePrivileges.Size = new System.Drawing.Size(421, 359);
            this.dataGridViewUserRolePrivileges.TabIndex = 1;
            this.dataGridViewUserRolePrivileges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserRolePrivileges_CellContentClick);
            this.dataGridViewUserRolePrivileges.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserRolePrivileges_CellContentClick);
            // 
            // uSERORROLEDataGridViewTextBoxColumn
            // 
            this.uSERORROLEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.uSERORROLEDataGridViewTextBoxColumn.DataPropertyName = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn.HeaderText = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn.Name = "uSERORROLEDataGridViewTextBoxColumn";
            this.uSERORROLEDataGridViewTextBoxColumn.Width = 119;
            // 
            // rOLENAMEDataGridViewTextBoxColumn1
            // 
            this.rOLENAMEDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.rOLENAMEDataGridViewTextBoxColumn1.DataPropertyName = "ROLE_NAME";
            this.rOLENAMEDataGridViewTextBoxColumn1.HeaderText = "ROLE_NAME";
            this.rOLENAMEDataGridViewTextBoxColumn1.Name = "rOLENAMEDataGridViewTextBoxColumn1";
            this.rOLENAMEDataGridViewTextBoxColumn1.Width = 98;
            // 
            // aDMINOPTIONDataGridViewTextBoxColumn
            // 
            this.aDMINOPTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aDMINOPTIONDataGridViewTextBoxColumn.DataPropertyName = "ADMIN_OPTION";
            this.aDMINOPTIONDataGridViewTextBoxColumn.HeaderText = "ADMIN_OPTION";
            this.aDMINOPTIONDataGridViewTextBoxColumn.Name = "aDMINOPTIONDataGridViewTextBoxColumn";
            this.aDMINOPTIONDataGridViewTextBoxColumn.Width = 114;
            // 
            // cREATEDDataGridViewTextBoxColumn
            // 
            this.cREATEDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cREATEDDataGridViewTextBoxColumn.DataPropertyName = "CREATED";
            this.cREATEDDataGridViewTextBoxColumn.HeaderText = "CREATED";
            this.cREATEDDataGridViewTextBoxColumn.Name = "cREATEDDataGridViewTextBoxColumn";
            this.cREATEDDataGridViewTextBoxColumn.Width = 83;
            // 
            // uSERROLEASSIGNMENTSVIEWBindingSource
            // 
            this.uSERROLEASSIGNMENTSVIEWBindingSource.DataMember = "USER_ROLE_ASSIGNMENTS_VIEW";
            this.uSERROLEASSIGNMENTSVIEWBindingSource.DataSource = this.dataSetOracle;
            // 
            // rOLE_PRIVILEGES_VIEWTableAdapter
            // 
            this.rOLE_PRIVILEGES_VIEWTableAdapter.ClearBeforeFill = true;
            // 
            // uSER_ROLE_ASSIGNMENTS_VIEWTableAdapter
            // 
            this.uSER_ROLE_ASSIGNMENTS_VIEWTableAdapter.ClearBeforeFill = true;
            // 
            // button_Back
            // 
            this.button_Back.BackgroundImage = global::User_Management.Properties.Resources.button_Back;
            this.button_Back.Location = new System.Drawing.Point(1235, 677);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(120, 50);
            this.button_Back.TabIndex = 8;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // textBox_RoleName1
            // 
            this.textBox_RoleName1.Location = new System.Drawing.Point(371, 277);
            this.textBox_RoleName1.Multiline = true;
            this.textBox_RoleName1.Name = "textBox_RoleName1";
            this.textBox_RoleName1.Size = new System.Drawing.Size(150, 30);
            this.textBox_RoleName1.TabIndex = 9;
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(371, 326);
            this.textBox_PassWord.Multiline = true;
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Size = new System.Drawing.Size(150, 30);
            this.textBox_PassWord.TabIndex = 10;
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(111, 271);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(100, 30);
            this.button_Create.TabIndex = 11;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Revoke
            // 
            this.button_Revoke.Location = new System.Drawing.Point(111, 471);
            this.button_Revoke.Name = "button_Revoke";
            this.button_Revoke.Size = new System.Drawing.Size(100, 30);
            this.button_Revoke.TabIndex = 12;
            this.button_Revoke.Text = "Revoke";
            this.button_Revoke.UseVisualStyleBackColor = true;
            this.button_Revoke.Click += new System.EventHandler(this.button_Revoke_Click);
            // 
            // button_Grant
            // 
            this.button_Grant.Location = new System.Drawing.Point(111, 435);
            this.button_Grant.Name = "button_Grant";
            this.button_Grant.Size = new System.Drawing.Size(100, 30);
            this.button_Grant.TabIndex = 13;
            this.button_Grant.Text = "Grant";
            this.button_Grant.UseVisualStyleBackColor = true;
            this.button_Grant.Click += new System.EventHandler(this.button_Grant_Click);
            // 
            // button_Drop
            // 
            this.button_Drop.Location = new System.Drawing.Point(111, 343);
            this.button_Drop.Name = "button_Drop";
            this.button_Drop.Size = new System.Drawing.Size(100, 30);
            this.button_Drop.TabIndex = 14;
            this.button_Drop.Text = "Drop";
            this.button_Drop.UseVisualStyleBackColor = true;
            this.button_Drop.Click += new System.EventHandler(this.button_Drop_Click);
            // 
            // button_Alter
            // 
            this.button_Alter.Location = new System.Drawing.Point(111, 307);
            this.button_Alter.Name = "button_Alter";
            this.button_Alter.Size = new System.Drawing.Size(100, 30);
            this.button_Alter.TabIndex = 15;
            this.button_Alter.Text = "Alter";
            this.button_Alter.UseVisualStyleBackColor = true;
            this.button_Alter.Click += new System.EventHandler(this.button_Alter_Click);
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.BackColor = System.Drawing.Color.Transparent;
            this.radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton.Location = new System.Drawing.Point(240, 553);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(122, 17);
            this.radioButton.TabIndex = 16;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "GRANT TO OTHER";
            this.radioButton.UseVisualStyleBackColor = false;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(240, 435);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(150, 30);
            this.textBoxUserName.TabIndex = 17;
            this.textBoxUserName.Text = " ";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AutoGenerateColumns = false;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERNAMEDataGridViewTextBoxColumn});
            this.dataGridViewUser.DataSource = this.aLLUSERBindingSource;
            this.dataGridViewUser.Location = new System.Drawing.Point(416, 411);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersVisible = false;
            this.dataGridViewUser.Size = new System.Drawing.Size(105, 217);
            this.dataGridViewUser.TabIndex = 18;
            this.dataGridViewUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // aLLUSERBindingSource
            // 
            this.aLLUSERBindingSource.DataMember = "ALL_USER";
            this.aLLUSERBindingSource.DataSource = this.dataSet_AllUser;
            // 
            // dataSet_AllUser
            // 
            this.dataSet_AllUser.DataSetName = "DataSet_AllUser";
            this.dataSet_AllUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLL_USERTableAdapter
            // 
            this.aLL_USERTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_RoleName2
            // 
            this.textBox_RoleName2.Location = new System.Drawing.Point(240, 505);
            this.textBox_RoleName2.Multiline = true;
            this.textBox_RoleName2.Name = "textBox_RoleName2";
            this.textBox_RoleName2.Size = new System.Drawing.Size(150, 30);
            this.textBox_RoleName2.TabIndex = 19;
            this.textBox_RoleName2.Text = " ";
            // 
            // formRolePrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::User_Management.Properties.Resources.backgroundRolePrivileges;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.textBox_RoleName2);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.button_Alter);
            this.Controls.Add(this.button_Drop);
            this.Controls.Add(this.button_Grant);
            this.Controls.Add(this.button_Revoke);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.textBox_RoleName1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.dataGridViewUserRolePrivileges);
            this.Controls.Add(this.dataGridViewRolePrivileges);
            this.Name = "formRolePrivileges";
            this.Text = "formRolePrivileges";
            this.Load += new System.EventHandler(this.formRolePrivileges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRolePrivileges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEPRIVILEGESVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserRolePrivileges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERROLEASSIGNMENTSVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_AllUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRolePrivileges;
        private System.Windows.Forms.DataGridView dataGridViewUserRolePrivileges;
        private DataSetOracle dataSetOracle;
        private System.Windows.Forms.BindingSource rOLEPRIVILEGESVIEWBindingSource;
        private DataSetOracleTableAdapters.ROLE_PRIVILEGES_VIEWTableAdapter rOLE_PRIVILEGES_VIEWTableAdapter;
        private System.Windows.Forms.BindingSource uSERROLEASSIGNMENTSVIEWBindingSource;
        private DataSetOracleTableAdapters.USER_ROLE_ASSIGNMENTS_VIEWTableAdapter uSER_ROLE_ASSIGNMENTS_VIEWTableAdapter;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.TextBox textBox_RoleName1;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Revoke;
        private System.Windows.Forms.Button button_Grant;
        private System.Windows.Forms.Button button_Drop;
        private System.Windows.Forms.Button button_Alter;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVILEGENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVILEGETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERORROLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLENAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINOPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private DataSet_AllUser dataSet_AllUser;
        private System.Windows.Forms.BindingSource aLLUSERBindingSource;
        private DataSet_AllUserTableAdapters.ALL_USERTableAdapter aLL_USERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_RoleName2;
    }
}