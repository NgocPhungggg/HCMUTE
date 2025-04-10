namespace Management_Hotel
{
    partial class Form_ListReceptionists
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
            this.DataGridView_ListJanitors = new System.Windows.Forms.DataGridView();
            this.hotel_ManagementDataSet = new Management_Hotel.Hotel_ManagementDataSet();
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationTableAdapter = new Management_Hotel.Hotel_ManagementDataSetTableAdapters.InformationTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresssDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListJanitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_ListJanitors
            // 
            this.DataGridView_ListJanitors.AutoGenerateColumns = false;
            this.DataGridView_ListJanitors.BackgroundColor = System.Drawing.Color.Linen;
            this.DataGridView_ListJanitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ListJanitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addresssDataGridViewTextBoxColumn,
            this.picDataGridViewImageColumn});
            this.DataGridView_ListJanitors.DataSource = this.informationBindingSource;
            this.DataGridView_ListJanitors.Location = new System.Drawing.Point(210, 180);
            this.DataGridView_ListJanitors.Name = "DataGridView_ListJanitors";
            this.DataGridView_ListJanitors.Size = new System.Drawing.Size(1080, 500);
            this.DataGridView_ListJanitors.TabIndex = 3;
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationBindingSource
            // 
            this.informationBindingSource.DataMember = "Information";
            this.informationBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addresssDataGridViewTextBoxColumn
            // 
            this.addresssDataGridViewTextBoxColumn.DataPropertyName = "Addresss";
            this.addresssDataGridViewTextBoxColumn.HeaderText = "Addresss";
            this.addresssDataGridViewTextBoxColumn.Name = "addresssDataGridViewTextBoxColumn";
            this.addresssDataGridViewTextBoxColumn.Width = 200;
            // 
            // picDataGridViewImageColumn
            // 
            this.picDataGridViewImageColumn.DataPropertyName = "Pic";
            this.picDataGridViewImageColumn.HeaderText = "Pic";
            this.picDataGridViewImageColumn.Name = "picDataGridViewImageColumn";
            this.picDataGridViewImageColumn.Width = 133;
            // 
            // Form_ListReceptionists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.DataGridView_ListJanitors);
            this.Name = "Form_ListReceptionists";
            this.Text = "Danh sách các lễ tân";
            this.Load += new System.EventHandler(this.Form_ListReceptionists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListJanitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_ListJanitors;
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource informationBindingSource;
        private Hotel_ManagementDataSetTableAdapters.InformationTableAdapter informationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresssDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn picDataGridViewImageColumn;
    }
}