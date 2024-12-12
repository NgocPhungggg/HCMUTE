namespace User_Management
{
    partial class formProfiles
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
            this.button_Back = new System.Windows.Forms.Button();
            this.dataGridViewProfile = new System.Windows.Forms.DataGridView();
            this.dataSetOracle = new User_Management.DataSetOracle();
            this.uSERPROFILEINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSER_PROFILE_INFOTableAdapter = new User_Management.DataSetOracleTableAdapters.USER_PROFILE_INFOTableAdapter();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFILEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESOURCENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIMITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERPROFILEINFOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.BackgroundImage = global::User_Management.Properties.Resources.button_Back;
            this.button_Back.Location = new System.Drawing.Point(1227, 676);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(120, 50);
            this.button_Back.TabIndex = 8;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // dataGridViewProfile
            // 
            this.dataGridViewProfile.AutoGenerateColumns = false;
            this.dataGridViewProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.pROFILEDataGridViewTextBoxColumn,
            this.rESOURCENAMEDataGridViewTextBoxColumn,
            this.lIMITDataGridViewTextBoxColumn});
            this.dataGridViewProfile.DataSource = this.uSERPROFILEINFOBindingSource;
            this.dataGridViewProfile.Location = new System.Drawing.Point(531, 247);
            this.dataGridViewProfile.Name = "dataGridViewProfile";
            this.dataGridViewProfile.Size = new System.Drawing.Size(446, 371);
            this.dataGridViewProfile.TabIndex = 9;
            // 
            // dataSetOracle
            // 
            this.dataSetOracle.DataSetName = "DataSetOracle";
            this.dataSetOracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERPROFILEINFOBindingSource
            // 
            this.uSERPROFILEINFOBindingSource.DataMember = "USER_PROFILE_INFO";
            this.uSERPROFILEINFOBindingSource.DataSource = this.dataSetOracle;
            // 
            // uSER_PROFILE_INFOTableAdapter
            // 
            this.uSER_PROFILE_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // pROFILEDataGridViewTextBoxColumn
            // 
            this.pROFILEDataGridViewTextBoxColumn.DataPropertyName = "PROFILE";
            this.pROFILEDataGridViewTextBoxColumn.HeaderText = "PROFILE";
            this.pROFILEDataGridViewTextBoxColumn.Name = "pROFILEDataGridViewTextBoxColumn";
            // 
            // rESOURCENAMEDataGridViewTextBoxColumn
            // 
            this.rESOURCENAMEDataGridViewTextBoxColumn.DataPropertyName = "RESOURCE_NAME";
            this.rESOURCENAMEDataGridViewTextBoxColumn.HeaderText = "RESOURCE_NAME";
            this.rESOURCENAMEDataGridViewTextBoxColumn.Name = "rESOURCENAMEDataGridViewTextBoxColumn";
            // 
            // lIMITDataGridViewTextBoxColumn
            // 
            this.lIMITDataGridViewTextBoxColumn.DataPropertyName = "LIMIT";
            this.lIMITDataGridViewTextBoxColumn.HeaderText = "LIMIT";
            this.lIMITDataGridViewTextBoxColumn.Name = "lIMITDataGridViewTextBoxColumn";
            // 
            // formProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::User_Management.Properties.Resources.backgroundProfiles;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.dataGridViewProfile);
            this.Controls.Add(this.button_Back);
            this.Name = "formProfiles";
            this.Text = "formProfiles";
            this.Load += new System.EventHandler(this.formProfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOracle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERPROFILEINFOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridView dataGridViewProfile;
        private DataSetOracle dataSetOracle;
        private System.Windows.Forms.BindingSource uSERPROFILEINFOBindingSource;
        private DataSetOracleTableAdapters.USER_PROFILE_INFOTableAdapter uSER_PROFILE_INFOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROFILEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESOURCENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIMITDataGridViewTextBoxColumn;
    }
}