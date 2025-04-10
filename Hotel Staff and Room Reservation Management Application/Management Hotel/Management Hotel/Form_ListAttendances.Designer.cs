namespace Management_Hotel
{
    partial class Form_ListAttendances
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementDataSet = new Management_Hotel.Hotel_ManagementDataSet();
            this.attendanceTableAdapter = new Management_Hotel.Hotel_ManagementDataSetTableAdapters.AttendanceTableAdapter();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.Button_Select = new System.Windows.Forms.Button();
            this.DateTimePicker_Salary = new System.Windows.Forms.DateTimePicker();
            this.DataGridView_Salary = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListJanitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Salary)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_ListJanitors
            // 
            this.DataGridView_ListJanitors.AutoGenerateColumns = false;
            this.DataGridView_ListJanitors.BackgroundColor = System.Drawing.Color.Linen;
            this.DataGridView_ListJanitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ListJanitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.dateWorkDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.DataGridView_ListJanitors.DataSource = this.attendanceBindingSource;
            this.DataGridView_ListJanitors.Location = new System.Drawing.Point(127, 206);
            this.DataGridView_ListJanitors.Name = "DataGridView_ListJanitors";
            this.DataGridView_ListJanitors.Size = new System.Drawing.Size(643, 496);
            this.DataGridView_ListJanitors.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // dateWorkDataGridViewTextBoxColumn
            // 
            this.dateWorkDataGridViewTextBoxColumn.DataPropertyName = "DateWork";
            this.dateWorkDataGridViewTextBoxColumn.HeaderText = "DateWork";
            this.dateWorkDataGridViewTextBoxColumn.Name = "dateWorkDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StartSchedule";
            this.Column1.HeaderText = "StartSchedule";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EndSchedule";
            this.Column2.HeaderText = "EndSchedule";
            this.Column2.Name = "Column2";
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(411, 160);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayKetThuc.TabIndex = 3;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(127, 160);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayBatDau.TabIndex = 4;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(670, 157);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(100, 30);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Check";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // Button_Select
            // 
            this.Button_Select.Location = new System.Drawing.Point(1233, 166);
            this.Button_Select.Name = "Button_Select";
            this.Button_Select.Size = new System.Drawing.Size(75, 23);
            this.Button_Select.TabIndex = 8;
            this.Button_Select.Text = "Lọc";
            this.Button_Select.UseVisualStyleBackColor = true;
            this.Button_Select.Click += new System.EventHandler(this.Button_Select_Click);
            // 
            // DateTimePicker_Salary
            // 
            this.DateTimePicker_Salary.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_Salary.Location = new System.Drawing.Point(967, 169);
            this.DateTimePicker_Salary.Name = "DateTimePicker_Salary";
            this.DateTimePicker_Salary.Size = new System.Drawing.Size(242, 20);
            this.DateTimePicker_Salary.TabIndex = 7;
            // 
            // DataGridView_Salary
            // 
            this.DataGridView_Salary.BackgroundColor = System.Drawing.Color.Linen;
            this.DataGridView_Salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Salary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn1,
            this.Column3,
            this.Salary});
            this.DataGridView_Salary.GridColor = System.Drawing.Color.Linen;
            this.DataGridView_Salary.Location = new System.Drawing.Point(921, 206);
            this.DataGridView_Salary.Name = "DataGridView_Salary";
            this.DataGridView_Salary.Size = new System.Drawing.Size(445, 496);
            this.DataGridView_Salary.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã nhân viên";
            this.ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên nhân viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Position";
            this.Column3.HeaderText = "Vị trí ";
            this.Column3.Name = "Column3";
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Tiền lương";
            this.Salary.Name = "Salary";
            // 
            // Form_ListAttendances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.Button_Select);
            this.Controls.Add(this.DateTimePicker_Salary);
            this.Controls.Add(this.DataGridView_Salary);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.DataGridView_ListJanitors);
            this.Name = "Form_ListAttendances";
            this.Text = "Form_ListAttendances";
            this.Load += new System.EventHandler(this.Form_ListAttendances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListJanitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Salary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_ListJanitors;
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private Hotel_ManagementDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button Button_Select;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Salary;
        private System.Windows.Forms.DataGridView DataGridView_Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}