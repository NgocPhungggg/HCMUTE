namespace User_Management
{
    partial class formUserManagement
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
            this.dataGridViewUserInformation = new System.Windows.Forms.DataGridView();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCKDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEFAULTTABLESPACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPORARYTABLESPACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUOTAMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFILEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRANTEDROLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLECANBEGRANTEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERACCOUNTINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOracle = new User_Management.DataSetOracle();
            this.button_Back = new System.Windows.Forms.Button();
            this.uSER_ACCOUNT_INFOTableAdapter = new User_Management.DataSetOracleTableAdapters.USER_ACCOUNT_INFOTableAdapter();
            this.dataGridViewSystemPrivilege = new System.Windows.Forms.DataGridView();
            this.uSERNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVILEGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTGRANTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRANTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERPRIVILEGESINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewObjectPrivilege = new System.Windows.Forms.DataGridView();
            this.uSERNAMEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oWNERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tABLENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVILEGEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANGRANTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRANTTYPEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSEROBJECTPRIVILEGESINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSER_PRIVILEGES_INFOTableAdapter = new User_Management.DataSetOracleTableAdapters.USER_PRIVILEGES_INFOTableAdapter();
            this.uSER_OBJECT_PRIVILEGES_INFOTableAdapter = new User_Management.DataSetOracleTableAdapters.USER_OBJECT_PRIVILEGES_INFOTableAdapter();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnAlterUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERACCOUNTINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemPrivilege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERPRIVILEGESINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjectPrivilege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSEROBJECTPRIVILEGESINFOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUserInformation
            // 
            this.dataGridViewUserInformation.AutoGenerateColumns = false;
            this.dataGridViewUserInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.aCCOUNTSTATUSDataGridViewTextBoxColumn,
            this.lOCKDATEDataGridViewTextBoxColumn,
            this.cREATEDDATEDataGridViewTextBoxColumn,
            this.dEFAULTTABLESPACEDataGridViewTextBoxColumn,
            this.tEMPORARYTABLESPACEDataGridViewTextBoxColumn,
            this.qUOTAMBDataGridViewTextBoxColumn,
            this.pROFILEDataGridViewTextBoxColumn,
            this.gRANTEDROLEDataGridViewTextBoxColumn,
            this.rOLECANBEGRANTEDDataGridViewTextBoxColumn});
            this.dataGridViewUserInformation.DataSource = this.uSERACCOUNTINFOBindingSource;
            this.dataGridViewUserInformation.Location = new System.Drawing.Point(134, 114);
            this.dataGridViewUserInformation.Name = "dataGridViewUserInformation";
            this.dataGridViewUserInformation.RowHeadersVisible = false;
            this.dataGridViewUserInformation.Size = new System.Drawing.Size(1231, 310);
            this.dataGridViewUserInformation.TabIndex = 0;
            this.dataGridViewUserInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserInformation_CellContentClick);
            this.dataGridViewUserInformation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserInformation_CellContentClick);
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            this.uSERNAMEDataGridViewTextBoxColumn.Width = 93;
            // 
            // aCCOUNTSTATUSDataGridViewTextBoxColumn
            // 
            this.aCCOUNTSTATUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aCCOUNTSTATUSDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_STATUS";
            this.aCCOUNTSTATUSDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_STATUS";
            this.aCCOUNTSTATUSDataGridViewTextBoxColumn.Name = "aCCOUNTSTATUSDataGridViewTextBoxColumn";
            this.aCCOUNTSTATUSDataGridViewTextBoxColumn.Width = 133;
            // 
            // lOCKDATEDataGridViewTextBoxColumn
            // 
            this.lOCKDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.lOCKDATEDataGridViewTextBoxColumn.DataPropertyName = "LOCK_DATE";
            this.lOCKDATEDataGridViewTextBoxColumn.HeaderText = "LOCK_DATE";
            this.lOCKDATEDataGridViewTextBoxColumn.Name = "lOCKDATEDataGridViewTextBoxColumn";
            this.lOCKDATEDataGridViewTextBoxColumn.Width = 95;
            // 
            // cREATEDDATEDataGridViewTextBoxColumn
            // 
            this.cREATEDDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cREATEDDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATED_DATE";
            this.cREATEDDATEDataGridViewTextBoxColumn.HeaderText = "CREATED_DATE";
            this.cREATEDDATEDataGridViewTextBoxColumn.Name = "cREATEDDATEDataGridViewTextBoxColumn";
            this.cREATEDDATEDataGridViewTextBoxColumn.Width = 118;
            // 
            // dEFAULTTABLESPACEDataGridViewTextBoxColumn
            // 
            this.dEFAULTTABLESPACEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dEFAULTTABLESPACEDataGridViewTextBoxColumn.DataPropertyName = "DEFAULT_TABLESPACE";
            this.dEFAULTTABLESPACEDataGridViewTextBoxColumn.HeaderText = "DEFAULT_TABLESPACE";
            this.dEFAULTTABLESPACEDataGridViewTextBoxColumn.Name = "dEFAULTTABLESPACEDataGridViewTextBoxColumn";
            this.dEFAULTTABLESPACEDataGridViewTextBoxColumn.Width = 156;
            // 
            // tEMPORARYTABLESPACEDataGridViewTextBoxColumn
            // 
            this.tEMPORARYTABLESPACEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tEMPORARYTABLESPACEDataGridViewTextBoxColumn.DataPropertyName = "TEMPORARY_TABLESPACE";
            this.tEMPORARYTABLESPACEDataGridViewTextBoxColumn.HeaderText = "TEMPORARY_TABLESPACE";
            this.tEMPORARYTABLESPACEDataGridViewTextBoxColumn.Name = "tEMPORARYTABLESPACEDataGridViewTextBoxColumn";
            this.tEMPORARYTABLESPACEDataGridViewTextBoxColumn.Width = 175;
            // 
            // qUOTAMBDataGridViewTextBoxColumn
            // 
            this.qUOTAMBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qUOTAMBDataGridViewTextBoxColumn.DataPropertyName = "QUOTA_MB";
            this.qUOTAMBDataGridViewTextBoxColumn.HeaderText = "QUOTA_MB";
            this.qUOTAMBDataGridViewTextBoxColumn.Name = "qUOTAMBDataGridViewTextBoxColumn";
            this.qUOTAMBDataGridViewTextBoxColumn.Width = 92;
            // 
            // pROFILEDataGridViewTextBoxColumn
            // 
            this.pROFILEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pROFILEDataGridViewTextBoxColumn.DataPropertyName = "PROFILE";
            this.pROFILEDataGridViewTextBoxColumn.HeaderText = "PROFILE";
            this.pROFILEDataGridViewTextBoxColumn.Name = "pROFILEDataGridViewTextBoxColumn";
            this.pROFILEDataGridViewTextBoxColumn.Width = 77;
            // 
            // gRANTEDROLEDataGridViewTextBoxColumn
            // 
            this.gRANTEDROLEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gRANTEDROLEDataGridViewTextBoxColumn.DataPropertyName = "GRANTED_ROLE";
            this.gRANTEDROLEDataGridViewTextBoxColumn.HeaderText = "GRANTED_ROLE";
            this.gRANTEDROLEDataGridViewTextBoxColumn.Name = "gRANTEDROLEDataGridViewTextBoxColumn";
            this.gRANTEDROLEDataGridViewTextBoxColumn.Width = 120;
            // 
            // rOLECANBEGRANTEDDataGridViewTextBoxColumn
            // 
            this.rOLECANBEGRANTEDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.rOLECANBEGRANTEDDataGridViewTextBoxColumn.DataPropertyName = "ROLE_CAN_BE_GRANTED";
            this.rOLECANBEGRANTEDDataGridViewTextBoxColumn.HeaderText = "ROLE_CAN_BE_GRANTED";
            this.rOLECANBEGRANTEDDataGridViewTextBoxColumn.Name = "rOLECANBEGRANTEDDataGridViewTextBoxColumn";
            this.rOLECANBEGRANTEDDataGridViewTextBoxColumn.Width = 168;
            // 
            // uSERACCOUNTINFOBindingSource
            // 
            this.uSERACCOUNTINFOBindingSource.DataMember = "USER_ACCOUNT_INFO";
            this.uSERACCOUNTINFOBindingSource.DataSource = this.dataSetOracle;
            // 
            // dataSetOracle
            // 
            this.dataSetOracle.DataSetName = "DataSetOracle";
            this.dataSetOracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_Back
            // 
            this.button_Back.BackgroundImage = global::User_Management.Properties.Resources.button_Back;
            this.button_Back.Location = new System.Drawing.Point(1232, 699);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(120, 50);
            this.button_Back.TabIndex = 9;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // uSER_ACCOUNT_INFOTableAdapter
            // 
            this.uSER_ACCOUNT_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewSystemPrivilege
            // 
            this.dataGridViewSystemPrivilege.AutoGenerateColumns = false;
            this.dataGridViewSystemPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSystemPrivilege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERNAMEDataGridViewTextBoxColumn1,
            this.pRIVILEGEDataGridViewTextBoxColumn,
            this.cANTGRANTDataGridViewTextBoxColumn,
            this.gRANTTYPEDataGridViewTextBoxColumn});
            this.dataGridViewSystemPrivilege.DataSource = this.uSERPRIVILEGESINFOBindingSource;
            this.dataGridViewSystemPrivilege.Location = new System.Drawing.Point(134, 430);
            this.dataGridViewSystemPrivilege.Name = "dataGridViewSystemPrivilege";
            this.dataGridViewSystemPrivilege.RowHeadersVisible = false;
            this.dataGridViewSystemPrivilege.Size = new System.Drawing.Size(410, 240);
            this.dataGridViewSystemPrivilege.TabIndex = 10;
            // 
            // uSERNAMEDataGridViewTextBoxColumn1
            // 
            this.uSERNAMEDataGridViewTextBoxColumn1.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn1.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn1.Name = "uSERNAMEDataGridViewTextBoxColumn1";
            // 
            // pRIVILEGEDataGridViewTextBoxColumn
            // 
            this.pRIVILEGEDataGridViewTextBoxColumn.DataPropertyName = "PRIVILEGE";
            this.pRIVILEGEDataGridViewTextBoxColumn.HeaderText = "PRIVILEGE";
            this.pRIVILEGEDataGridViewTextBoxColumn.Name = "pRIVILEGEDataGridViewTextBoxColumn";
            // 
            // cANTGRANTDataGridViewTextBoxColumn
            // 
            this.cANTGRANTDataGridViewTextBoxColumn.DataPropertyName = "CANT_GRANT";
            this.cANTGRANTDataGridViewTextBoxColumn.HeaderText = "CANT_GRANT";
            this.cANTGRANTDataGridViewTextBoxColumn.Name = "cANTGRANTDataGridViewTextBoxColumn";
            // 
            // gRANTTYPEDataGridViewTextBoxColumn
            // 
            this.gRANTTYPEDataGridViewTextBoxColumn.DataPropertyName = "GRANT_TYPE";
            this.gRANTTYPEDataGridViewTextBoxColumn.HeaderText = "GRANT_TYPE";
            this.gRANTTYPEDataGridViewTextBoxColumn.Name = "gRANTTYPEDataGridViewTextBoxColumn";
            // 
            // uSERPRIVILEGESINFOBindingSource
            // 
            this.uSERPRIVILEGESINFOBindingSource.DataMember = "USER_PRIVILEGES_INFO";
            this.uSERPRIVILEGESINFOBindingSource.DataSource = this.dataSetOracle;
            // 
            // dataGridViewObjectPrivilege
            // 
            this.dataGridViewObjectPrivilege.AutoGenerateColumns = false;
            this.dataGridViewObjectPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjectPrivilege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERNAMEDataGridViewTextBoxColumn2,
            this.oWNERDataGridViewTextBoxColumn,
            this.tABLENAMEDataGridViewTextBoxColumn,
            this.pRIVILEGEDataGridViewTextBoxColumn1,
            this.cANGRANTDataGridViewTextBoxColumn,
            this.gRANTTYPEDataGridViewTextBoxColumn1});
            this.dataGridViewObjectPrivilege.DataSource = this.uSEROBJECTPRIVILEGESINFOBindingSource;
            this.dataGridViewObjectPrivilege.Location = new System.Drawing.Point(550, 430);
            this.dataGridViewObjectPrivilege.Name = "dataGridViewObjectPrivilege";
            this.dataGridViewObjectPrivilege.RowHeadersVisible = false;
            this.dataGridViewObjectPrivilege.Size = new System.Drawing.Size(604, 240);
            this.dataGridViewObjectPrivilege.TabIndex = 11;
            // 
            // uSERNAMEDataGridViewTextBoxColumn2
            // 
            this.uSERNAMEDataGridViewTextBoxColumn2.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn2.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn2.Name = "uSERNAMEDataGridViewTextBoxColumn2";
            // 
            // oWNERDataGridViewTextBoxColumn
            // 
            this.oWNERDataGridViewTextBoxColumn.DataPropertyName = "OWNER";
            this.oWNERDataGridViewTextBoxColumn.HeaderText = "OWNER";
            this.oWNERDataGridViewTextBoxColumn.Name = "oWNERDataGridViewTextBoxColumn";
            // 
            // tABLENAMEDataGridViewTextBoxColumn
            // 
            this.tABLENAMEDataGridViewTextBoxColumn.DataPropertyName = "TABLE_NAME";
            this.tABLENAMEDataGridViewTextBoxColumn.HeaderText = "TABLE_NAME";
            this.tABLENAMEDataGridViewTextBoxColumn.Name = "tABLENAMEDataGridViewTextBoxColumn";
            // 
            // pRIVILEGEDataGridViewTextBoxColumn1
            // 
            this.pRIVILEGEDataGridViewTextBoxColumn1.DataPropertyName = "PRIVILEGE";
            this.pRIVILEGEDataGridViewTextBoxColumn1.HeaderText = "PRIVILEGE";
            this.pRIVILEGEDataGridViewTextBoxColumn1.Name = "pRIVILEGEDataGridViewTextBoxColumn1";
            // 
            // cANGRANTDataGridViewTextBoxColumn
            // 
            this.cANGRANTDataGridViewTextBoxColumn.DataPropertyName = "CAN_GRANT";
            this.cANGRANTDataGridViewTextBoxColumn.HeaderText = "CAN_GRANT";
            this.cANGRANTDataGridViewTextBoxColumn.Name = "cANGRANTDataGridViewTextBoxColumn";
            // 
            // gRANTTYPEDataGridViewTextBoxColumn1
            // 
            this.gRANTTYPEDataGridViewTextBoxColumn1.DataPropertyName = "GRANT_TYPE";
            this.gRANTTYPEDataGridViewTextBoxColumn1.HeaderText = "GRANT_TYPE";
            this.gRANTTYPEDataGridViewTextBoxColumn1.Name = "gRANTTYPEDataGridViewTextBoxColumn1";
            // 
            // uSEROBJECTPRIVILEGESINFOBindingSource
            // 
            this.uSEROBJECTPRIVILEGESINFOBindingSource.DataMember = "USER_OBJECT_PRIVILEGES_INFO";
            this.uSEROBJECTPRIVILEGESINFOBindingSource.DataSource = this.dataSetOracle;
            // 
            // uSER_PRIVILEGES_INFOTableAdapter
            // 
            this.uSER_PRIVILEGES_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // uSER_OBJECT_PRIVILEGES_INFOTableAdapter
            // 
            this.uSER_OBJECT_PRIVILEGES_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(1165, 439);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(200, 40);
            this.btnCreateUser.TabIndex = 12;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnAlterUser
            // 
            this.btnAlterUser.Location = new System.Drawing.Point(1165, 501);
            this.btnAlterUser.Name = "btnAlterUser";
            this.btnAlterUser.Size = new System.Drawing.Size(200, 40);
            this.btnAlterUser.TabIndex = 13;
            this.btnAlterUser.Text = "Alter User";
            this.btnAlterUser.UseVisualStyleBackColor = true;
            this.btnAlterUser.Click += new System.EventHandler(this.btnAlterUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(1165, 563);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteUser.TabIndex = 14;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // formUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::User_Management.Properties.Resources.backgroundUserManagement;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAlterUser);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.dataGridViewObjectPrivilege);
            this.Controls.Add(this.dataGridViewSystemPrivilege);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.dataGridViewUserInformation);
            this.Name = "formUserManagement";
            this.Text = "formUserManagement";
            this.Load += new System.EventHandler(this.formUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERACCOUNTINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemPrivilege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERPRIVILEGESINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjectPrivilege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSEROBJECTPRIVILEGESINFOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserInformation;
        private System.Windows.Forms.Button button_Back;
        private DataSetOracle dataSetOracle;
        private System.Windows.Forms.BindingSource uSERACCOUNTINFOBindingSource;
        private DataSetOracleTableAdapters.USER_ACCOUNT_INFOTableAdapter uSER_ACCOUNT_INFOTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewSystemPrivilege;
        private System.Windows.Forms.DataGridView dataGridViewObjectPrivilege;
        private System.Windows.Forms.BindingSource uSERPRIVILEGESINFOBindingSource;
        private DataSetOracleTableAdapters.USER_PRIVILEGES_INFOTableAdapter uSER_PRIVILEGES_INFOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVILEGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTGRANTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRANTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uSEROBJECTPRIVILEGESINFOBindingSource;
        private DataSetOracleTableAdapters.USER_OBJECT_PRIVILEGES_INFOTableAdapter uSER_OBJECT_PRIVILEGES_INFOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oWNERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tABLENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVILEGEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANGRANTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRANTTYPEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCKDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEFAULTTABLESPACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPORARYTABLESPACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUOTAMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROFILEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRANTEDROLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLECANBEGRANTEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnAlterUser;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}