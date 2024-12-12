namespace User_Management
{
    partial class formPrivileges
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
            this.dataGridViewSystemPrivileges = new System.Windows.Forms.DataGridView();
            this.uSERORROLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVILEGENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINOPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYSTEMPRIVILEGESVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOracle = new User_Management.DataSetOracle();
            this.dataGridViewObjectPrivileges = new System.Windows.Forms.DataGridView();
            this.uSERORROLEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVILEGENAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tABLEOWNERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINOPTIONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBJECTPRIVILEGESVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSTEM_PRIVILEGES_VIEWTableAdapter = new User_Management.DataSetOracleTableAdapters.SYSTEM_PRIVILEGES_VIEWTableAdapter();
            this.oBJECT_PRIVILEGES_VIEWTableAdapter = new User_Management.DataSetOracleTableAdapters.OBJECT_PRIVILEGES_VIEWTableAdapter();
            this.button_Back = new System.Windows.Forms.Button();
            this.dataSet_AllUser = new User_Management.DataSet_AllUser();
            this.aLLUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLL_USERTableAdapter = new User_Management.DataSet_AllUserTableAdapters.ALL_USERTableAdapter();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAllRole = new System.Windows.Forms.DataGridView();
            this.rOLENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLEPRIVILEGESVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOLE_PRIVILEGES_VIEWTableAdapter = new User_Management.DataSetOracleTableAdapters.ROLE_PRIVILEGES_VIEWTableAdapter();
            this.listBox_SystenPrivileges = new System.Windows.Forms.ListBox();
            this.listBox_ObjectPrivileges = new System.Windows.Forms.ListBox();
            this.textBox_RoleUser = new System.Windows.Forms.TextBox();
            this.textBox_System = new System.Windows.Forms.TextBox();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.textBox_Object = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button_GrantSystem = new System.Windows.Forms.Button();
            this.button_RevokeSystem = new System.Windows.Forms.Button();
            this.button_GrantObject = new System.Windows.Forms.Button();
            this.button_ObjectRevoke = new System.Windows.Forms.Button();
            this.checkBox_Select = new System.Windows.Forms.CheckBox();
            this.checkBox_Insert = new System.Windows.Forms.CheckBox();
            this.checkBox_Delete = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemPrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSTEMPRIVILEGESVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjectPrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBJECTPRIVILEGESVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_AllUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEPRIVILEGESVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSystemPrivileges
            // 
            this.dataGridViewSystemPrivileges.AutoGenerateColumns = false;
            this.dataGridViewSystemPrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSystemPrivileges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERORROLEDataGridViewTextBoxColumn,
            this.pRIVILEGENAMEDataGridViewTextBoxColumn,
            this.aDMINOPTIONDataGridViewTextBoxColumn,
            this.cREATEDDataGridViewTextBoxColumn});
            this.dataGridViewSystemPrivileges.DataSource = this.sYSTEMPRIVILEGESVIEWBindingSource;
            this.dataGridViewSystemPrivileges.Location = new System.Drawing.Point(197, 239);
            this.dataGridViewSystemPrivileges.Name = "dataGridViewSystemPrivileges";
            this.dataGridViewSystemPrivileges.RowHeadersVisible = false;
            this.dataGridViewSystemPrivileges.Size = new System.Drawing.Size(562, 200);
            this.dataGridViewSystemPrivileges.TabIndex = 0;
            this.dataGridViewSystemPrivileges.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSystemPrivileges_CellContentClick);
            // 
            // uSERORROLEDataGridViewTextBoxColumn
            // 
            this.uSERORROLEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.uSERORROLEDataGridViewTextBoxColumn.DataPropertyName = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn.HeaderText = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn.Name = "uSERORROLEDataGridViewTextBoxColumn";
            this.uSERORROLEDataGridViewTextBoxColumn.Width = 119;
            // 
            // pRIVILEGENAMEDataGridViewTextBoxColumn
            // 
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.DataPropertyName = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.HeaderText = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.Name = "pRIVILEGENAMEDataGridViewTextBoxColumn";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.Width = 125;
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
            // sYSTEMPRIVILEGESVIEWBindingSource
            // 
            this.sYSTEMPRIVILEGESVIEWBindingSource.DataMember = "SYSTEM_PRIVILEGES_VIEW";
            this.sYSTEMPRIVILEGESVIEWBindingSource.DataSource = this.dataSetOracle;
            // 
            // dataSetOracle
            // 
            this.dataSetOracle.DataSetName = "DataSetOracle";
            this.dataSetOracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewObjectPrivileges
            // 
            this.dataGridViewObjectPrivileges.AutoGenerateColumns = false;
            this.dataGridViewObjectPrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjectPrivileges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERORROLEDataGridViewTextBoxColumn1,
            this.pRIVILEGENAMEDataGridViewTextBoxColumn1,
            this.tABLEOWNERDataGridViewTextBoxColumn,
            this.aDMINOPTIONDataGridViewTextBoxColumn1,
            this.cREATEDDataGridViewTextBoxColumn1});
            this.dataGridViewObjectPrivileges.DataSource = this.oBJECTPRIVILEGESVIEWBindingSource;
            this.dataGridViewObjectPrivileges.Location = new System.Drawing.Point(197, 445);
            this.dataGridViewObjectPrivileges.Name = "dataGridViewObjectPrivileges";
            this.dataGridViewObjectPrivileges.RowHeadersVisible = false;
            this.dataGridViewObjectPrivileges.Size = new System.Drawing.Size(562, 200);
            this.dataGridViewObjectPrivileges.TabIndex = 1;
            this.dataGridViewObjectPrivileges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewObjectPrivileges_CellContentClick);
            this.dataGridViewObjectPrivileges.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewObjectPrivileges_CellContentClick);
            // 
            // uSERORROLEDataGridViewTextBoxColumn1
            // 
            this.uSERORROLEDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.uSERORROLEDataGridViewTextBoxColumn1.DataPropertyName = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn1.HeaderText = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn1.Name = "uSERORROLEDataGridViewTextBoxColumn1";
            this.uSERORROLEDataGridViewTextBoxColumn1.Width = 119;
            // 
            // pRIVILEGENAMEDataGridViewTextBoxColumn1
            // 
            this.pRIVILEGENAMEDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pRIVILEGENAMEDataGridViewTextBoxColumn1.DataPropertyName = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn1.HeaderText = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn1.Name = "pRIVILEGENAMEDataGridViewTextBoxColumn1";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tABLEOWNERDataGridViewTextBoxColumn
            // 
            this.tABLEOWNERDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tABLEOWNERDataGridViewTextBoxColumn.DataPropertyName = "TABLE_OWNER";
            this.tABLEOWNERDataGridViewTextBoxColumn.HeaderText = "TABLE_OWNER";
            this.tABLEOWNERDataGridViewTextBoxColumn.Name = "tABLEOWNERDataGridViewTextBoxColumn";
            this.tABLEOWNERDataGridViewTextBoxColumn.Width = 114;
            // 
            // aDMINOPTIONDataGridViewTextBoxColumn1
            // 
            this.aDMINOPTIONDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aDMINOPTIONDataGridViewTextBoxColumn1.DataPropertyName = "ADMIN_OPTION";
            this.aDMINOPTIONDataGridViewTextBoxColumn1.HeaderText = "ADMIN_OPTION";
            this.aDMINOPTIONDataGridViewTextBoxColumn1.Name = "aDMINOPTIONDataGridViewTextBoxColumn1";
            this.aDMINOPTIONDataGridViewTextBoxColumn1.Width = 114;
            // 
            // cREATEDDataGridViewTextBoxColumn1
            // 
            this.cREATEDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cREATEDDataGridViewTextBoxColumn1.DataPropertyName = "CREATED";
            this.cREATEDDataGridViewTextBoxColumn1.HeaderText = "CREATED";
            this.cREATEDDataGridViewTextBoxColumn1.Name = "cREATEDDataGridViewTextBoxColumn1";
            this.cREATEDDataGridViewTextBoxColumn1.Width = 83;
            // 
            // oBJECTPRIVILEGESVIEWBindingSource
            // 
            this.oBJECTPRIVILEGESVIEWBindingSource.DataMember = "OBJECT_PRIVILEGES_VIEW";
            this.oBJECTPRIVILEGESVIEWBindingSource.DataSource = this.dataSetOracle;
            // 
            // sYSTEM_PRIVILEGES_VIEWTableAdapter
            // 
            this.sYSTEM_PRIVILEGES_VIEWTableAdapter.ClearBeforeFill = true;
            // 
            // oBJECT_PRIVILEGES_VIEWTableAdapter
            // 
            this.oBJECT_PRIVILEGES_VIEWTableAdapter.ClearBeforeFill = true;
            // 
            // button_Back
            // 
            this.button_Back.BackgroundImage = global::User_Management.Properties.Resources.button_Back;
            this.button_Back.Location = new System.Drawing.Point(1231, 676);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(120, 50);
            this.button_Back.TabIndex = 7;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // dataSet_AllUser
            // 
            this.dataSet_AllUser.DataSetName = "DataSet_AllUser";
            this.dataSet_AllUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLLUSERBindingSource
            // 
            this.aLLUSERBindingSource.DataMember = "ALL_USER";
            this.aLLUSERBindingSource.DataSource = this.dataSet_AllUser;
            // 
            // aLL_USERTableAdapter
            // 
            this.aLL_USERTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AutoGenerateColumns = false;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.ColumnHeadersVisible = false;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERNAMEDataGridViewTextBoxColumn});
            this.dataGridViewUser.DataSource = this.aLLUSERBindingSource;
            this.dataGridViewUser.Location = new System.Drawing.Point(938, 262);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersVisible = false;
            this.dataGridViewUser.Size = new System.Drawing.Size(125, 203);
            this.dataGridViewUser.TabIndex = 19;
            this.dataGridViewUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_DoubleClick);
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // dataGridViewAllRole
            // 
            this.dataGridViewAllRole.AutoGenerateColumns = false;
            this.dataGridViewAllRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllRole.ColumnHeadersVisible = false;
            this.dataGridViewAllRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rOLENAMEDataGridViewTextBoxColumn});
            this.dataGridViewAllRole.DataSource = this.rOLEPRIVILEGESVIEWBindingSource;
            this.dataGridViewAllRole.Location = new System.Drawing.Point(798, 262);
            this.dataGridViewAllRole.Name = "dataGridViewAllRole";
            this.dataGridViewAllRole.RowHeadersVisible = false;
            this.dataGridViewAllRole.Size = new System.Drawing.Size(125, 203);
            this.dataGridViewAllRole.TabIndex = 20;
            this.dataGridViewAllRole.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllRole_DoubleClick);
            // 
            // rOLENAMEDataGridViewTextBoxColumn
            // 
            this.rOLENAMEDataGridViewTextBoxColumn.DataPropertyName = "ROLE_NAME";
            this.rOLENAMEDataGridViewTextBoxColumn.HeaderText = "ROLE_NAME";
            this.rOLENAMEDataGridViewTextBoxColumn.Name = "rOLENAMEDataGridViewTextBoxColumn";
            // 
            // rOLEPRIVILEGESVIEWBindingSource
            // 
            this.rOLEPRIVILEGESVIEWBindingSource.DataMember = "ROLE_PRIVILEGES_VIEW";
            this.rOLEPRIVILEGESVIEWBindingSource.DataSource = this.dataSetOracle;
            // 
            // rOLE_PRIVILEGES_VIEWTableAdapter
            // 
            this.rOLE_PRIVILEGES_VIEWTableAdapter.ClearBeforeFill = true;
            // 
            // listBox_SystenPrivileges
            // 
            this.listBox_SystenPrivileges.FormattingEnabled = true;
            this.listBox_SystenPrivileges.Location = new System.Drawing.Point(798, 502);
            this.listBox_SystenPrivileges.Name = "listBox_SystenPrivileges";
            this.listBox_SystenPrivileges.Size = new System.Drawing.Size(125, 147);
            this.listBox_SystenPrivileges.TabIndex = 21;
            this.listBox_SystenPrivileges.SelectedIndexChanged += new System.EventHandler(this.listBox_SystenPrivileges_SelectedIndexChanged);
            // 
            // listBox_ObjectPrivileges
            // 
            this.listBox_ObjectPrivileges.FormattingEnabled = true;
            this.listBox_ObjectPrivileges.Location = new System.Drawing.Point(938, 502);
            this.listBox_ObjectPrivileges.Name = "listBox_ObjectPrivileges";
            this.listBox_ObjectPrivileges.Size = new System.Drawing.Size(125, 147);
            this.listBox_ObjectPrivileges.TabIndex = 22;
            this.listBox_ObjectPrivileges.SelectedIndexChanged += new System.EventHandler(this.listBox_ObjectPrivileges_SelectedIndexChanged);
            // 
            // textBox_RoleUser
            // 
            this.textBox_RoleUser.Location = new System.Drawing.Point(1101, 273);
            this.textBox_RoleUser.Multiline = true;
            this.textBox_RoleUser.Name = "textBox_RoleUser";
            this.textBox_RoleUser.Size = new System.Drawing.Size(200, 30);
            this.textBox_RoleUser.TabIndex = 23;
            // 
            // textBox_System
            // 
            this.textBox_System.Location = new System.Drawing.Point(1103, 353);
            this.textBox_System.Multiline = true;
            this.textBox_System.Name = "textBox_System";
            this.textBox_System.Size = new System.Drawing.Size(200, 30);
            this.textBox_System.TabIndex = 25;
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.BackColor = System.Drawing.Color.Transparent;
            this.radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton.Location = new System.Drawing.Point(1103, 389);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(122, 17);
            this.radioButton.TabIndex = 26;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "GRANT TO OTHER";
            this.radioButton.UseVisualStyleBackColor = false;
            // 
            // textBox_Object
            // 
            this.textBox_Object.Location = new System.Drawing.Point(1103, 502);
            this.textBox_Object.Multiline = true;
            this.textBox_Object.Name = "textBox_Object";
            this.textBox_Object.Size = new System.Drawing.Size(200, 30);
            this.textBox_Object.TabIndex = 27;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(1102, 559);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "GRANT TO OTHER";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // button_GrantSystem
            // 
            this.button_GrantSystem.Location = new System.Drawing.Point(1103, 412);
            this.button_GrantSystem.Name = "button_GrantSystem";
            this.button_GrantSystem.Size = new System.Drawing.Size(100, 30);
            this.button_GrantSystem.TabIndex = 30;
            this.button_GrantSystem.Text = "Grant";
            this.button_GrantSystem.UseVisualStyleBackColor = true;
            this.button_GrantSystem.Click += new System.EventHandler(this.button_GrantSystem_Click);
            // 
            // button_RevokeSystem
            // 
            this.button_RevokeSystem.Location = new System.Drawing.Point(1203, 412);
            this.button_RevokeSystem.Name = "button_RevokeSystem";
            this.button_RevokeSystem.Size = new System.Drawing.Size(100, 30);
            this.button_RevokeSystem.TabIndex = 29;
            this.button_RevokeSystem.Text = "Revoke";
            this.button_RevokeSystem.UseVisualStyleBackColor = true;
            this.button_RevokeSystem.Click += new System.EventHandler(this.button_RevokeSystem_Click);
            // 
            // button_GrantObject
            // 
            this.button_GrantObject.Location = new System.Drawing.Point(1102, 583);
            this.button_GrantObject.Name = "button_GrantObject";
            this.button_GrantObject.Size = new System.Drawing.Size(100, 30);
            this.button_GrantObject.TabIndex = 32;
            this.button_GrantObject.Text = "Grant";
            this.button_GrantObject.UseVisualStyleBackColor = true;
            this.button_GrantObject.Click += new System.EventHandler(this.button_GrantObject_Click);
            // 
            // button_ObjectRevoke
            // 
            this.button_ObjectRevoke.Location = new System.Drawing.Point(1202, 583);
            this.button_ObjectRevoke.Name = "button_ObjectRevoke";
            this.button_ObjectRevoke.Size = new System.Drawing.Size(100, 30);
            this.button_ObjectRevoke.TabIndex = 31;
            this.button_ObjectRevoke.Text = "Revoke";
            this.button_ObjectRevoke.UseVisualStyleBackColor = true;
            this.button_ObjectRevoke.Click += new System.EventHandler(this.button_ObjectRevoke_Click);
            // 
            // checkBox_Select
            // 
            this.checkBox_Select.AutoSize = true;
            this.checkBox_Select.Location = new System.Drawing.Point(1103, 536);
            this.checkBox_Select.Name = "checkBox_Select";
            this.checkBox_Select.Size = new System.Drawing.Size(56, 17);
            this.checkBox_Select.TabIndex = 36;
            this.checkBox_Select.Text = "Select";
            this.checkBox_Select.UseVisualStyleBackColor = true;
            // 
            // checkBox_Insert
            // 
            this.checkBox_Insert.AutoSize = true;
            this.checkBox_Insert.Location = new System.Drawing.Point(1173, 536);
            this.checkBox_Insert.Name = "checkBox_Insert";
            this.checkBox_Insert.Size = new System.Drawing.Size(52, 17);
            this.checkBox_Insert.TabIndex = 37;
            this.checkBox_Insert.Text = "Insert";
            this.checkBox_Insert.UseVisualStyleBackColor = true;
            // 
            // checkBox_Delete
            // 
            this.checkBox_Delete.AutoSize = true;
            this.checkBox_Delete.Location = new System.Drawing.Point(1245, 536);
            this.checkBox_Delete.Name = "checkBox_Delete";
            this.checkBox_Delete.Size = new System.Drawing.Size(57, 17);
            this.checkBox_Delete.TabIndex = 38;
            this.checkBox_Delete.Text = "Delete";
            this.checkBox_Delete.UseVisualStyleBackColor = true;
            // 
            // formPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::User_Management.Properties.Resources.backgroundPrivileges;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.checkBox_Delete);
            this.Controls.Add(this.checkBox_Insert);
            this.Controls.Add(this.checkBox_Select);
            this.Controls.Add(this.button_GrantObject);
            this.Controls.Add(this.button_ObjectRevoke);
            this.Controls.Add(this.button_GrantSystem);
            this.Controls.Add(this.button_RevokeSystem);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox_Object);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.textBox_System);
            this.Controls.Add(this.textBox_RoleUser);
            this.Controls.Add(this.listBox_ObjectPrivileges);
            this.Controls.Add(this.listBox_SystenPrivileges);
            this.Controls.Add(this.dataGridViewAllRole);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.dataGridViewObjectPrivileges);
            this.Controls.Add(this.dataGridViewSystemPrivileges);
            this.Name = "formPrivileges";
            this.Text = "formPrivileges";
            this.Load += new System.EventHandler(this.formPrivileges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemPrivileges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSTEMPRIVILEGESVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjectPrivileges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBJECTPRIVILEGESVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_AllUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEPRIVILEGESVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSystemPrivileges;
        private System.Windows.Forms.DataGridView dataGridViewObjectPrivileges;
        private DataSetOracle dataSetOracle;
        private System.Windows.Forms.BindingSource sYSTEMPRIVILEGESVIEWBindingSource;
        private DataSetOracleTableAdapters.SYSTEM_PRIVILEGES_VIEWTableAdapter sYSTEM_PRIVILEGES_VIEWTableAdapter;
        private System.Windows.Forms.BindingSource oBJECTPRIVILEGESVIEWBindingSource;
        private DataSetOracleTableAdapters.OBJECT_PRIVILEGES_VIEWTableAdapter oBJECT_PRIVILEGES_VIEWTableAdapter;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERORROLEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVILEGENAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tABLEOWNERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINOPTIONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERORROLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVILEGENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINOPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDDataGridViewTextBoxColumn;
        private DataSet_AllUser dataSet_AllUser;
        private System.Windows.Forms.BindingSource aLLUSERBindingSource;
        private DataSet_AllUserTableAdapters.ALL_USERTableAdapter aLL_USERTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewAllRole;
        private System.Windows.Forms.BindingSource rOLEPRIVILEGESVIEWBindingSource;
        private DataSetOracleTableAdapters.ROLE_PRIVILEGES_VIEWTableAdapter rOLE_PRIVILEGES_VIEWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox_SystenPrivileges;
        private System.Windows.Forms.ListBox listBox_ObjectPrivileges;
        private System.Windows.Forms.TextBox textBox_RoleUser;
        private System.Windows.Forms.TextBox textBox_System;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.TextBox textBox_Object;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button_GrantSystem;
        private System.Windows.Forms.Button button_RevokeSystem;
        private System.Windows.Forms.Button button_GrantObject;
        private System.Windows.Forms.Button button_ObjectRevoke;
        private System.Windows.Forms.CheckBox checkBox_Select;
        private System.Windows.Forms.CheckBox checkBox_Insert;
        private System.Windows.Forms.CheckBox checkBox_Delete;
    }
}