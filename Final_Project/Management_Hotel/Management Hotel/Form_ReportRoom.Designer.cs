namespace Management_Hotel
{
    partial class Form_ReportRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.quantitynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.updbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tongtienlabel = new System.Windows.Forms.Label();
            this.txtTotal_money = new System.Windows.Forms.TextBox();
            this.txtbill_id = new System.Windows.Forms.TextBox();
            this.soluonglabel = new System.Windows.Forms.Label();
            this.Svcnamelabel = new System.Windows.Forms.Label();
            this.Hoadonlabel = new System.Windows.Forms.Label();
            this.dgvSuDungDichVu = new System.Windows.Forms.DataGridView();
            this.hotel_ManagementDataSet = new Management_Hotel.Hotel_ManagementDataSet();
            this.dgvHoaDonDatPhong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new Management_Hotel.Hotel_ManagementDataSetTableAdapters.BillTableAdapter();
            this.detailServicessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detail_ServicessTableAdapter = new Management_Hotel.Hotel_ManagementDataSetTableAdapters.Detail_ServicessTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuDungDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonDatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailServicessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quantitynumericUpDown
            // 
            this.quantitynumericUpDown.Location = new System.Drawing.Point(235, 309);
            this.quantitynumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.quantitynumericUpDown.Name = "quantitynumericUpDown";
            this.quantitynumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.quantitynumericUpDown.TabIndex = 122;
            this.quantitynumericUpDown.ValueChanged += new System.EventHandler(this.quantitynumericUpDown_ValueChanged);
            // 
            // comboBoxService
            // 
            this.comboBoxService.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(235, 269);
            this.comboBoxService.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(174, 25);
            this.comboBoxService.TabIndex = 121;
            // 
            // updbutton
            // 
            this.updbutton.BackColor = System.Drawing.Color.Linen;
            this.updbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.updbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updbutton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updbutton.ForeColor = System.Drawing.Color.Black;
            this.updbutton.Location = new System.Drawing.Point(437, 266);
            this.updbutton.Name = "updbutton";
            this.updbutton.Size = new System.Drawing.Size(93, 31);
            this.updbutton.TabIndex = 120;
            this.updbutton.Text = "Chỉnh sửa";
            this.updbutton.UseVisualStyleBackColor = false;
            this.updbutton.Click += new System.EventHandler(this.updbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(437, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 31);
            this.button1.TabIndex = 116;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Linen;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(437, 229);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 31);
            this.btnThem.TabIndex = 117;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(437, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 31);
            this.button3.TabIndex = 119;
            this.button3.Text = "Reload";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tongtienlabel
            // 
            this.tongtienlabel.AutoSize = true;
            this.tongtienlabel.BackColor = System.Drawing.Color.Transparent;
            this.tongtienlabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtienlabel.Location = new System.Drawing.Point(108, 335);
            this.tongtienlabel.Name = "tongtienlabel";
            this.tongtienlabel.Size = new System.Drawing.Size(97, 27);
            this.tongtienlabel.TabIndex = 106;
            this.tongtienlabel.Text = "Tổng tiền";
            // 
            // txtTotal_money
            // 
            this.txtTotal_money.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal_money.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal_money.Location = new System.Drawing.Point(235, 347);
            this.txtTotal_money.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal_money.Name = "txtTotal_money";
            this.txtTotal_money.Size = new System.Drawing.Size(174, 26);
            this.txtTotal_money.TabIndex = 110;
            // 
            // txtbill_id
            // 
            this.txtbill_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbill_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbill_id.Location = new System.Drawing.Point(235, 232);
            this.txtbill_id.Name = "txtbill_id";
            this.txtbill_id.Size = new System.Drawing.Size(174, 29);
            this.txtbill_id.TabIndex = 95;
            // 
            // soluonglabel
            // 
            this.soluonglabel.AutoSize = true;
            this.soluonglabel.BackColor = System.Drawing.Color.Transparent;
            this.soluonglabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluonglabel.Location = new System.Drawing.Point(108, 299);
            this.soluonglabel.Name = "soluonglabel";
            this.soluonglabel.Size = new System.Drawing.Size(89, 27);
            this.soluonglabel.TabIndex = 86;
            this.soluonglabel.Text = "Số lượng";
            // 
            // Svcnamelabel
            // 
            this.Svcnamelabel.AutoSize = true;
            this.Svcnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.Svcnamelabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Svcnamelabel.Location = new System.Drawing.Point(108, 265);
            this.Svcnamelabel.Name = "Svcnamelabel";
            this.Svcnamelabel.Size = new System.Drawing.Size(113, 27);
            this.Svcnamelabel.TabIndex = 87;
            this.Svcnamelabel.Text = "Tên dịch vụ";
            // 
            // Hoadonlabel
            // 
            this.Hoadonlabel.AutoSize = true;
            this.Hoadonlabel.BackColor = System.Drawing.Color.Transparent;
            this.Hoadonlabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hoadonlabel.Location = new System.Drawing.Point(107, 235);
            this.Hoadonlabel.Name = "Hoadonlabel";
            this.Hoadonlabel.Size = new System.Drawing.Size(120, 27);
            this.Hoadonlabel.TabIndex = 87;
            this.Hoadonlabel.Text = "Mã hóa đơn:";
            // 
            // dgvSuDungDichVu
            // 
            this.dgvSuDungDichVu.AllowUserToAddRows = false;
            this.dgvSuDungDichVu.AllowUserToDeleteRows = false;
            this.dgvSuDungDichVu.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuDungDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuDungDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuDungDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dgvSuDungDichVu.DataSource = this.detailServicessBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuDungDichVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuDungDichVu.Location = new System.Drawing.Point(659, 162);
            this.dgvSuDungDichVu.Name = "dgvSuDungDichVu";
            this.dgvSuDungDichVu.RowHeadersWidth = 51;
            this.dgvSuDungDichVu.Size = new System.Drawing.Size(559, 260);
            this.dgvSuDungDichVu.TabIndex = 113;
            this.dgvSuDungDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuDungDichVu_CellContentClick);
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvHoaDonDatPhong
            // 
            this.dgvHoaDonDatPhong.AllowUserToAddRows = false;
            this.dgvHoaDonDatPhong.AllowUserToDeleteRows = false;
            this.dgvHoaDonDatPhong.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonDatPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDonDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonDatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvHoaDonDatPhong.DataSource = this.billBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDonDatPhong.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHoaDonDatPhong.Location = new System.Drawing.Point(422, 448);
            this.dgvHoaDonDatPhong.Name = "dgvHoaDonDatPhong";
            this.dgvHoaDonDatPhong.RowHeadersWidth = 51;
            this.dgvHoaDonDatPhong.Size = new System.Drawing.Size(987, 283);
            this.dgvHoaDonDatPhong.TabIndex = 116;
            this.dgvHoaDonDatPhong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonDatPhong_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BillID";
            this.dataGridViewTextBoxColumn2.HeaderText = "BillID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RoomID";
            this.dataGridViewTextBoxColumn3.HeaderText = "RoomID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CheckIn";
            this.dataGridViewTextBoxColumn5.HeaderText = "CheckIn";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CheckOut";
            this.dataGridViewTextBoxColumn6.HeaderText = "CheckOut";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ReservedDays";
            this.dataGridViewTextBoxColumn7.HeaderText = "ReservedDays";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TotalMoney";
            this.dataGridViewTextBoxColumn8.HeaderText = "TotalMoney";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn9.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PayTime";
            this.dataGridViewTextBoxColumn10.HeaderText = "PayTime";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Payment";
            this.dataGridViewTextBoxColumn11.HeaderText = "Payment";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn12.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // detailServicessBindingSource
            // 
            this.detailServicessBindingSource.DataMember = "Detail_Servicess";
            this.detailServicessBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // detail_ServicessTableAdapter
            // 
            this.detail_ServicessTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BillID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BillID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ServiceName";
            this.dataGridViewTextBoxColumn13.HeaderText = "ServiceName";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn14.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn15.HeaderText = "Total";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 200;
            // 
            // Form_ReportRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.DetailService;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.quantitynumericUpDown);
            this.Controls.Add(this.dgvHoaDonDatPhong);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.tongtienlabel);
            this.Controls.Add(this.txtTotal_money);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtbill_id);
            this.Controls.Add(this.updbutton);
            this.Controls.Add(this.soluonglabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Svcnamelabel);
            this.Controls.Add(this.dgvSuDungDichVu);
            this.Controls.Add(this.Hoadonlabel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_ReportRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuDungDichVu";
            this.Load += new System.EventHandler(this.SuDungDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantitynumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuDungDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonDatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailServicessBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tongtienlabel;
        private System.Windows.Forms.TextBox txtTotal_money;
        private System.Windows.Forms.TextBox txtbill_id;
        private System.Windows.Forms.Label soluonglabel;
        private System.Windows.Forms.Label Svcnamelabel;
        private System.Windows.Forms.Label Hoadonlabel;
        private System.Windows.Forms.DataGridView dgvSuDungDichVu;
        private System.Windows.Forms.Button updbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.NumericUpDown quantitynumericUpDown;
        private System.Windows.Forms.DataGridView dgvHoaDonDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservedDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource billBindingSource;
        private Hotel_ManagementDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource detailServicessBindingSource;
        private Hotel_ManagementDataSetTableAdapters.Detail_ServicessTableAdapter detail_ServicessTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}