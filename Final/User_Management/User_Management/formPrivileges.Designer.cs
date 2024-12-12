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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemPrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSTEMPRIVILEGESVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjectPrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBJECTPRIVILEGESVIEWBindingSource)).BeginInit();
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
            this.dataGridViewSystemPrivileges.Location = new System.Drawing.Point(249, 241);
            this.dataGridViewSystemPrivileges.Name = "dataGridViewSystemPrivileges";
            this.dataGridViewSystemPrivileges.Size = new System.Drawing.Size(445, 346);
            this.dataGridViewSystemPrivileges.TabIndex = 0;
            this.dataGridViewSystemPrivileges.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSystemPrivileges_CellContentClick);
            // 
            // uSERORROLEDataGridViewTextBoxColumn
            // 
            this.uSERORROLEDataGridViewTextBoxColumn.DataPropertyName = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn.HeaderText = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn.Name = "uSERORROLEDataGridViewTextBoxColumn";
            // 
            // pRIVILEGENAMEDataGridViewTextBoxColumn
            // 
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.DataPropertyName = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.HeaderText = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn.Name = "pRIVILEGENAMEDataGridViewTextBoxColumn";
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
            this.dataGridViewObjectPrivileges.Location = new System.Drawing.Point(766, 241);
            this.dataGridViewObjectPrivileges.Name = "dataGridViewObjectPrivileges";
            this.dataGridViewObjectPrivileges.Size = new System.Drawing.Size(544, 346);
            this.dataGridViewObjectPrivileges.TabIndex = 1;
            this.dataGridViewObjectPrivileges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewObjectPrivileges_CellContentClick);
            this.dataGridViewObjectPrivileges.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewObjectPrivileges_CellContentClick);
            // 
            // uSERORROLEDataGridViewTextBoxColumn1
            // 
            this.uSERORROLEDataGridViewTextBoxColumn1.DataPropertyName = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn1.HeaderText = "USER_OR_ROLE";
            this.uSERORROLEDataGridViewTextBoxColumn1.Name = "uSERORROLEDataGridViewTextBoxColumn1";
            // 
            // pRIVILEGENAMEDataGridViewTextBoxColumn1
            // 
            this.pRIVILEGENAMEDataGridViewTextBoxColumn1.DataPropertyName = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn1.HeaderText = "PRIVILEGE_NAME";
            this.pRIVILEGENAMEDataGridViewTextBoxColumn1.Name = "pRIVILEGENAMEDataGridViewTextBoxColumn1";
            // 
            // tABLEOWNERDataGridViewTextBoxColumn
            // 
            this.tABLEOWNERDataGridViewTextBoxColumn.DataPropertyName = "TABLE_OWNER";
            this.tABLEOWNERDataGridViewTextBoxColumn.HeaderText = "TABLE_OWNER";
            this.tABLEOWNERDataGridViewTextBoxColumn.Name = "tABLEOWNERDataGridViewTextBoxColumn";
            // 
            // aDMINOPTIONDataGridViewTextBoxColumn1
            // 
            this.aDMINOPTIONDataGridViewTextBoxColumn1.DataPropertyName = "ADMIN_OPTION";
            this.aDMINOPTIONDataGridViewTextBoxColumn1.HeaderText = "ADMIN_OPTION";
            this.aDMINOPTIONDataGridViewTextBoxColumn1.Name = "aDMINOPTIONDataGridViewTextBoxColumn1";
            // 
            // cREATEDDataGridViewTextBoxColumn1
            // 
            this.cREATEDDataGridViewTextBoxColumn1.DataPropertyName = "CREATED";
            this.cREATEDDataGridViewTextBoxColumn1.HeaderText = "CREATED";
            this.cREATEDDataGridViewTextBoxColumn1.Name = "cREATEDDataGridViewTextBoxColumn1";
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
            // formPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::User_Management.Properties.Resources.backgroundPrivileges;
            this.ClientSize = new System.Drawing.Size(1484, 761);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSystemPrivileges;
        private System.Windows.Forms.DataGridView dataGridViewObjectPrivileges;
        private DataSetOracle dataSetOracle;
        private System.Windows.Forms.BindingSource sYSTEMPRIVILEGESVIEWBindingSource;
        private DataSetOracleTableAdapters.SYSTEM_PRIVILEGES_VIEWTableAdapter sYSTEM_PRIVILEGES_VIEWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERORROLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVILEGENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINOPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oBJECTPRIVILEGESVIEWBindingSource;
        private DataSetOracleTableAdapters.OBJECT_PRIVILEGES_VIEWTableAdapter oBJECT_PRIVILEGES_VIEWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERORROLEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVILEGENAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tABLEOWNERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINOPTIONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button_Back;
    }
}