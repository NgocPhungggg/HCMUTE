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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRolePrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEPRIVILEGESVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserRolePrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERROLEASSIGNMENTSVIEWBindingSource)).BeginInit();
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
            this.dataGridViewRolePrivileges.Location = new System.Drawing.Point(297, 269);
            this.dataGridViewRolePrivileges.Name = "dataGridViewRolePrivileges";
            this.dataGridViewRolePrivileges.Size = new System.Drawing.Size(344, 359);
            this.dataGridViewRolePrivileges.TabIndex = 0;
            this.dataGridViewRolePrivileges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRolePrivileges_CellContentClick);
            this.dataGridViewRolePrivileges.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRolePrivileges_CellContentClick);
            // 
            // rOLENAMEDataGridViewTextBoxColumn
            // 
            this.rOLENAMEDataGridViewTextBoxColumn.DataPropertyName = "ROLE_NAME";
            this.rOLENAMEDataGridViewTextBoxColumn.HeaderText = "ROLE_NAME";
            this.rOLENAMEDataGridViewTextBoxColumn.Name = "rOLENAMEDataGridViewTextBoxColumn";
            // 
            // pRIVILEGENAMEDataGridViewTextBoxColumn
            // 
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.DataPropertyName = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.HeaderText = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.Name = "pRIVILEGENAMEDataGridViewTextBoxColumn";
            // 
            // pRIVILEGETYPEDataGridViewTextBoxColumn
            // 
            this.pRIVILEGETYPEDataGridViewTextBoxColumn.DataPropertyName = "PRIVILEGE_TYPE";
            this.pRIVILEGETYPEDataGridViewTextBoxColumn.HeaderText = "PRIVILEGE_TYPE";
            this.pRIVILEGETYPEDataGridViewTextBoxColumn.Name = "pRIVILEGETYPEDataGridViewTextBoxColumn";
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
            this.dataGridViewUserRolePrivileges.Location = new System.Drawing.Point(843, 269);
            this.dataGridViewUserRolePrivileges.Name = "dataGridViewUserRolePrivileges";
            this.dataGridViewUserRolePrivileges.Size = new System.Drawing.Size(446, 359);
            this.dataGridViewUserRolePrivileges.TabIndex = 1;
            this.dataGridViewUserRolePrivileges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserRolePrivileges_CellContentClick);
            this.dataGridViewUserRolePrivileges.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserRolePrivileges_CellContentClick);
            // 
            // uSERORROLEDataGridViewTextBoxColumn
            // 
            this.uSERORROLEDataGridViewTextBoxColumn.DataPropertyName = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn.HeaderText = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn.Name = "uSERORROLEDataGridViewTextBoxColumn";
            // 
            // rOLENAMEDataGridViewTextBoxColumn1
            // 
            this.rOLENAMEDataGridViewTextBoxColumn1.DataPropertyName = "ROLE_NAME";
            this.rOLENAMEDataGridViewTextBoxColumn1.HeaderText = "ROLE_NAME";
            this.rOLENAMEDataGridViewTextBoxColumn1.Name = "rOLENAMEDataGridViewTextBoxColumn1";
            // 
            // aDMINOPTIONDataGridViewTextBoxColumn
            // 
            this.aDMINOPTIONDataGridViewTextBoxColumn.DataPropertyName = "ADMIN_OPTION";
            this.aDMINOPTIONDataGridViewTextBoxColumn.HeaderText = "ADMIN_OPTION";
            this.aDMINOPTIONDataGridViewTextBoxColumn.Name = "aDMINOPTIONDataGridViewTextBoxColumn";
            // 
            // cREATEDDataGridViewTextBoxColumn
            // 
            this.cREATEDDataGridViewTextBoxColumn.DataPropertyName = "CREATED";
            this.cREATEDDataGridViewTextBoxColumn.HeaderText = "CREATED";
            this.cREATEDDataGridViewTextBoxColumn.Name = "cREATEDDataGridViewTextBoxColumn";
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
            // formRolePrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::User_Management.Properties.Resources.backgroundRolePrivileges;
            this.ClientSize = new System.Drawing.Size(1484, 761);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRolePrivileges;
        private System.Windows.Forms.DataGridView dataGridViewUserRolePrivileges;
        private DataSetOracle dataSetOracle;
        private System.Windows.Forms.BindingSource rOLEPRIVILEGESVIEWBindingSource;
        private DataSetOracleTableAdapters.ROLE_PRIVILEGES_VIEWTableAdapter rOLE_PRIVILEGES_VIEWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVILEGENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVILEGETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uSERROLEASSIGNMENTSVIEWBindingSource;
        private DataSetOracleTableAdapters.USER_ROLE_ASSIGNMENTS_VIEWTableAdapter uSER_ROLE_ASSIGNMENTS_VIEWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERORROLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLENAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINOPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Back;
    }
}