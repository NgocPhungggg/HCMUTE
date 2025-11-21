namespace Management_Hotel
{
    partial class Form_ManageRooms
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
            this.Button__EditType = new System.Windows.Forms.Button();
            this.Button__DeleteType = new System.Windows.Forms.Button();
            this.Button_AddType = new System.Windows.Forms.Button();
            this.dongiaLabel = new System.Windows.Forms.Label();
            this.dongiatxt = new System.Windows.Forms.TextBox();
            this.tenloaiphongLabel = new System.Windows.Forms.Label();
            this.tenloaiphongtxt = new System.Windows.Forms.TextBox();
            this.TinhTrangcomboBox = new System.Windows.Forms.ComboBox();
            this.Label_TinhTrang = new System.Windows.Forms.Label();
            this.btnLocPhong = new System.Windows.Forms.Button();
            this.DataGridView_Rooms = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementDataSet = new Management_Hotel.Hotel_ManagementDataSet();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.Button_EditRoom = new System.Windows.Forms.Button();
            this.Button_DeleteRoom = new System.Windows.Forms.Button();
            this.Button_AddRoom = new System.Windows.Forms.Button();
            this.loaiPhongLabel = new System.Windows.Forms.Label();
            this.maphongLabel = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.DataGridView_TypeRoom = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeRoomTableAdapter = new Management_Hotel.Hotel_ManagementDataSetTableAdapters.TypeRoomTableAdapter();
            this.roomTableAdapter = new Management_Hotel.Hotel_ManagementDataSetTableAdapters.RoomTableAdapter();
            this.lblMaxUnit = new System.Windows.Forms.Label();
            this.btnLocLoaiPhong = new System.Windows.Forms.Button();
            this.lblMinUnit = new System.Windows.Forms.Label();
            this.lblFilterUnit = new System.Windows.Forms.Label();
            this.TextBox_MinUnit = new System.Windows.Forms.TextBox();
            this.TextBox_MaxUnit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TypeRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Button__EditType
            // 
            this.Button__EditType.BackColor = System.Drawing.Color.Linen;
            this.Button__EditType.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button__EditType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button__EditType.Location = new System.Drawing.Point(200, 605);
            this.Button__EditType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button__EditType.Name = "Button__EditType";
            this.Button__EditType.Size = new System.Drawing.Size(100, 35);
            this.Button__EditType.TabIndex = 81;
            this.Button__EditType.Text = "Sửa";
            this.Button__EditType.UseVisualStyleBackColor = false;
            this.Button__EditType.Click += new System.EventHandler(this.Button_EditType_Click);
            // 
            // Button__DeleteType
            // 
            this.Button__DeleteType.BackColor = System.Drawing.Color.Linen;
            this.Button__DeleteType.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button__DeleteType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button__DeleteType.Location = new System.Drawing.Point(305, 605);
            this.Button__DeleteType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button__DeleteType.Name = "Button__DeleteType";
            this.Button__DeleteType.Size = new System.Drawing.Size(100, 35);
            this.Button__DeleteType.TabIndex = 80;
            this.Button__DeleteType.Text = "Xóa";
            this.Button__DeleteType.UseVisualStyleBackColor = false;
            this.Button__DeleteType.Click += new System.EventHandler(this.Button_DeleteType_Click);
            // 
            // Button_AddType
            // 
            this.Button_AddType.BackColor = System.Drawing.Color.Linen;
            this.Button_AddType.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_AddType.Location = new System.Drawing.Point(95, 605);
            this.Button_AddType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_AddType.Name = "Button_AddType";
            this.Button_AddType.Size = new System.Drawing.Size(100, 35);
            this.Button_AddType.TabIndex = 79;
            this.Button_AddType.Text = "Thêm";
            this.Button_AddType.UseVisualStyleBackColor = false;
            this.Button_AddType.Click += new System.EventHandler(this.Button_AddType_Click);
            // 
            // dongiaLabel
            // 
            this.dongiaLabel.AutoSize = true;
            this.dongiaLabel.BackColor = System.Drawing.Color.Transparent;
            this.dongiaLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongiaLabel.Location = new System.Drawing.Point(95, 555);
            this.dongiaLabel.Name = "dongiaLabel";
            this.dongiaLabel.Size = new System.Drawing.Size(91, 29);
            this.dongiaLabel.TabIndex = 78;
            this.dongiaLabel.Text = "Đơn giá:";
            // 
            // dongiatxt
            // 
            this.dongiatxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dongiatxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongiatxt.Location = new System.Drawing.Point(250, 555);
            this.dongiatxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dongiatxt.Name = "dongiatxt";
            this.dongiatxt.Size = new System.Drawing.Size(150, 29);
            this.dongiatxt.TabIndex = 77;
            // 
            // tenloaiphongLabel
            // 
            this.tenloaiphongLabel.AutoSize = true;
            this.tenloaiphongLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenloaiphongLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenloaiphongLabel.Location = new System.Drawing.Point(95, 505);
            this.tenloaiphongLabel.Name = "tenloaiphongLabel";
            this.tenloaiphongLabel.Size = new System.Drawing.Size(122, 29);
            this.tenloaiphongLabel.TabIndex = 76;
            this.tenloaiphongLabel.Text = "Loại Phòng:";
            // 
            // tenloaiphongtxt
            // 
            this.tenloaiphongtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenloaiphongtxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenloaiphongtxt.Location = new System.Drawing.Point(250, 505);
            this.tenloaiphongtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tenloaiphongtxt.Name = "tenloaiphongtxt";
            this.tenloaiphongtxt.Size = new System.Drawing.Size(150, 29);
            this.tenloaiphongtxt.TabIndex = 75;
            // 
            // TinhTrangcomboBox
            // 
            this.TinhTrangcomboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhTrangcomboBox.FormattingEnabled = true;
            this.TinhTrangcomboBox.Items.AddRange(new object[] {
            "Còn trống",
            "Đã đặt"});
            this.TinhTrangcomboBox.Location = new System.Drawing.Point(950, 555);
            this.TinhTrangcomboBox.Name = "TinhTrangcomboBox";
            this.TinhTrangcomboBox.Size = new System.Drawing.Size(150, 29);
            this.TinhTrangcomboBox.TabIndex = 95;
            // 
            // Label_TinhTrang
            // 
            this.Label_TinhTrang.AutoSize = true;
            this.Label_TinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.Label_TinhTrang.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TinhTrang.Location = new System.Drawing.Point(795, 555);
            this.Label_TinhTrang.Name = "Label_TinhTrang";
            this.Label_TinhTrang.Size = new System.Drawing.Size(122, 29);
            this.Label_TinhTrang.TabIndex = 94;
            this.Label_TinhTrang.Text = "Tình trạng:";
            // 
            // btnLocPhong
            // 
            this.btnLocPhong.BackColor = System.Drawing.Color.Linen;
            this.btnLocPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocPhong.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocPhong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLocPhong.Location = new System.Drawing.Point(1005, 505);
            this.btnLocPhong.Name = "btnLocPhong";
            this.btnLocPhong.Size = new System.Drawing.Size(100, 35);
            this.btnLocPhong.TabIndex = 41;
            this.btnLocPhong.Text = "Lọc";
            this.btnLocPhong.UseVisualStyleBackColor = false;
            this.btnLocPhong.Click += new System.EventHandler(this.btnLocPhong_Click);
            // 
            // DataGridView_Rooms
            // 
            this.DataGridView_Rooms.AutoGenerateColumns = false;
            this.DataGridView_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.DataGridView_Rooms.DataSource = this.roomBindingSource;
            this.DataGridView_Rooms.Location = new System.Drawing.Point(1110, 290);
            this.DataGridView_Rooms.MultiSelect = false;
            this.DataGridView_Rooms.Name = "DataGridView_Rooms";
            this.DataGridView_Rooms.ReadOnly = true;
            this.DataGridView_Rooms.RowHeadersWidth = 51;
            this.DataGridView_Rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Rooms.Size = new System.Drawing.Size(300, 350);
            this.DataGridView_Rooms.TabIndex = 29;
            this.DataGridView_Rooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Rooms_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RoomID";
            this.dataGridViewTextBoxColumn3.HeaderText = "RoomID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TypeRoomName";
            this.dataGridViewTextBoxColumn4.HeaderText = "TypeRoomName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "RoomStatus";
            this.dataGridViewCheckBoxColumn1.HeaderText = "RoomStatus";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbRoomType
            // 
            this.cbRoomType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Deluxe",
            "Standard",
            "Connecting",
            "Suite"});
            this.cbRoomType.Location = new System.Drawing.Point(950, 455);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(150, 29);
            this.cbRoomType.TabIndex = 38;
            // 
            // Button_EditRoom
            // 
            this.Button_EditRoom.BackColor = System.Drawing.Color.Linen;
            this.Button_EditRoom.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_EditRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_EditRoom.Location = new System.Drawing.Point(900, 605);
            this.Button_EditRoom.Name = "Button_EditRoom";
            this.Button_EditRoom.Size = new System.Drawing.Size(100, 35);
            this.Button_EditRoom.TabIndex = 36;
            this.Button_EditRoom.Text = "Sửa";
            this.Button_EditRoom.UseVisualStyleBackColor = false;
            this.Button_EditRoom.Click += new System.EventHandler(this.Button_EditRoom_Click);
            // 
            // Button_DeleteRoom
            // 
            this.Button_DeleteRoom.BackColor = System.Drawing.Color.Linen;
            this.Button_DeleteRoom.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DeleteRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_DeleteRoom.Location = new System.Drawing.Point(1005, 605);
            this.Button_DeleteRoom.Name = "Button_DeleteRoom";
            this.Button_DeleteRoom.Size = new System.Drawing.Size(100, 35);
            this.Button_DeleteRoom.TabIndex = 35;
            this.Button_DeleteRoom.Text = "Xóa";
            this.Button_DeleteRoom.UseVisualStyleBackColor = false;
            this.Button_DeleteRoom.Click += new System.EventHandler(this.Button_DeleteRoom_Click);
            // 
            // Button_AddRoom
            // 
            this.Button_AddRoom.BackColor = System.Drawing.Color.Linen;
            this.Button_AddRoom.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_AddRoom.Location = new System.Drawing.Point(795, 605);
            this.Button_AddRoom.Name = "Button_AddRoom";
            this.Button_AddRoom.Size = new System.Drawing.Size(100, 35);
            this.Button_AddRoom.TabIndex = 34;
            this.Button_AddRoom.Text = "Thêm";
            this.Button_AddRoom.UseVisualStyleBackColor = false;
            this.Button_AddRoom.Click += new System.EventHandler(this.Button_AddRoom_Click);
            // 
            // loaiPhongLabel
            // 
            this.loaiPhongLabel.AutoSize = true;
            this.loaiPhongLabel.BackColor = System.Drawing.Color.Transparent;
            this.loaiPhongLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaiPhongLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loaiPhongLabel.Location = new System.Drawing.Point(795, 455);
            this.loaiPhongLabel.Name = "loaiPhongLabel";
            this.loaiPhongLabel.Size = new System.Drawing.Size(122, 29);
            this.loaiPhongLabel.TabIndex = 39;
            this.loaiPhongLabel.Text = "Loại Phòng:";
            // 
            // maphongLabel
            // 
            this.maphongLabel.AutoSize = true;
            this.maphongLabel.BackColor = System.Drawing.Color.Transparent;
            this.maphongLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maphongLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maphongLabel.Location = new System.Drawing.Point(795, 405);
            this.maphongLabel.Name = "maphongLabel";
            this.maphongLabel.Size = new System.Drawing.Size(111, 29);
            this.maphongLabel.TabIndex = 40;
            this.maphongLabel.Text = "Mã Phòng:";
            // 
            // txtRoomID
            // 
            this.txtRoomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomID.Location = new System.Drawing.Point(950, 405);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(150, 29);
            this.txtRoomID.TabIndex = 28;
            // 
            // DataGridView_TypeRoom
            // 
            this.DataGridView_TypeRoom.AutoGenerateColumns = false;
            this.DataGridView_TypeRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_TypeRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DataGridView_TypeRoom.DataSource = this.typeRoomBindingSource;
            this.DataGridView_TypeRoom.Location = new System.Drawing.Point(410, 290);
            this.DataGridView_TypeRoom.MultiSelect = false;
            this.DataGridView_TypeRoom.Name = "DataGridView_TypeRoom";
            this.DataGridView_TypeRoom.ReadOnly = true;
            this.DataGridView_TypeRoom.RowHeadersWidth = 51;
            this.DataGridView_TypeRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_TypeRoom.Size = new System.Drawing.Size(300, 350);
            this.DataGridView_TypeRoom.TabIndex = 96;
            this.DataGridView_TypeRoom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_TypeRoom_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TypeRoomName";
            this.dataGridViewTextBoxColumn1.HeaderText = "TypeRoomName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // typeRoomBindingSource
            // 
            this.typeRoomBindingSource.DataMember = "TypeRoom";
            this.typeRoomBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // typeRoomTableAdapter
            // 
            this.typeRoomTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // lblMaxUnit
            // 
            this.lblMaxUnit.AutoSize = true;
            this.lblMaxUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxUnit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxUnit.Location = new System.Drawing.Point(710, 700);
            this.lblMaxUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxUnit.Name = "lblMaxUnit";
            this.lblMaxUnit.Size = new System.Drawing.Size(52, 29);
            this.lblMaxUnit.TabIndex = 88;
            this.lblMaxUnit.Text = "Đến";
            // 
            // btnLocLoaiPhong
            // 
            this.btnLocLoaiPhong.BackColor = System.Drawing.Color.Linen;
            this.btnLocLoaiPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocLoaiPhong.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocLoaiPhong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLocLoaiPhong.Location = new System.Drawing.Point(950, 695);
            this.btnLocLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLocLoaiPhong.Name = "btnLocLoaiPhong";
            this.btnLocLoaiPhong.Size = new System.Drawing.Size(100, 35);
            this.btnLocLoaiPhong.TabIndex = 84;
            this.btnLocLoaiPhong.Text = "Lọc";
            this.btnLocLoaiPhong.UseVisualStyleBackColor = false;
            this.btnLocLoaiPhong.Click += new System.EventHandler(this.btnLocLoaiPhong_Click);
            // 
            // lblMinUnit
            // 
            this.lblMinUnit.AutoSize = true;
            this.lblMinUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblMinUnit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinUnit.Location = new System.Drawing.Point(490, 700);
            this.lblMinUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinUnit.Name = "lblMinUnit";
            this.lblMinUnit.Size = new System.Drawing.Size(41, 29);
            this.lblMinUnit.TabIndex = 87;
            this.lblMinUnit.Text = "Từ";
            // 
            // lblFilterUnit
            // 
            this.lblFilterUnit.AutoSize = true;
            this.lblFilterUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterUnit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterUnit.Location = new System.Drawing.Point(430, 700);
            this.lblFilterUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterUnit.Name = "lblFilterUnit";
            this.lblFilterUnit.Size = new System.Drawing.Size(54, 29);
            this.lblFilterUnit.TabIndex = 85;
            this.lblFilterUnit.Text = "Giá:";
            // 
            // TextBox_MinUnit
            // 
            this.TextBox_MinUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_MinUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MinUnit.Location = new System.Drawing.Point(550, 700);
            this.TextBox_MinUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBox_MinUnit.Name = "TextBox_MinUnit";
            this.TextBox_MinUnit.Size = new System.Drawing.Size(161, 29);
            this.TextBox_MinUnit.TabIndex = 86;
            // 
            // TextBox_MaxUnit
            // 
            this.TextBox_MaxUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_MaxUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MaxUnit.Location = new System.Drawing.Point(770, 700);
            this.TextBox_MaxUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBox_MaxUnit.Name = "TextBox_MaxUnit";
            this.TextBox_MaxUnit.Size = new System.Drawing.Size(161, 29);
            this.TextBox_MaxUnit.TabIndex = 89;
            // 
            // Form_ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.BackgroundManageRoom;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.TextBox_MaxUnit);
            this.Controls.Add(this.TextBox_MinUnit);
            this.Controls.Add(this.TinhTrangcomboBox);
            this.Controls.Add(this.lblFilterUnit);
            this.Controls.Add(this.Button__EditType);
            this.Controls.Add(this.lblMinUnit);
            this.Controls.Add(this.btnLocLoaiPhong);
            this.Controls.Add(this.lblMaxUnit);
            this.Controls.Add(this.Button__DeleteType);
            this.Controls.Add(this.Label_TinhTrang);
            this.Controls.Add(this.Button_AddType);
            this.Controls.Add(this.dongiaLabel);
            this.Controls.Add(this.btnLocPhong);
            this.Controls.Add(this.dongiatxt);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.tenloaiphongLabel);
            this.Controls.Add(this.tenloaiphongtxt);
            this.Controls.Add(this.loaiPhongLabel);
            this.Controls.Add(this.DataGridView_TypeRoom);
            this.Controls.Add(this.maphongLabel);
            this.Controls.Add(this.Button_AddRoom);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.Button_DeleteRoom);
            this.Controls.Add(this.Button_EditRoom);
            this.Controls.Add(this.DataGridView_Rooms);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_ManageRooms";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.Form_ManageRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TypeRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button__EditType;
        private System.Windows.Forms.Button Button__DeleteType;
        private System.Windows.Forms.Button Button_AddType;
        private System.Windows.Forms.Label dongiaLabel;
        private System.Windows.Forms.TextBox dongiatxt;
        private System.Windows.Forms.Label tenloaiphongLabel;
        private System.Windows.Forms.TextBox tenloaiphongtxt;
        private System.Windows.Forms.Button btnLocPhong;
        private System.Windows.Forms.DataGridView DataGridView_Rooms;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Button Button_EditRoom;
        private System.Windows.Forms.Button Button_DeleteRoom;
        private System.Windows.Forms.Button Button_AddRoom;
        private System.Windows.Forms.Label loaiPhongLabel;
        private System.Windows.Forms.Label maphongLabel;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.DataGridView DataGridView_TypeRoom;
        //private PROJECT_WIN_HOTELDataSet_TypeRoom_RoomTableAdapters.TypeRoomTableAdapter typeRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeRoomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        //private PROJECT_WIN_HOTELDataSet_TypeRoom_RoomTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.Label Label_TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeRoomNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn roomStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox TinhTrangcomboBox;
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource typeRoomBindingSource;
        private Hotel_ManagementDataSetTableAdapters.TypeRoomTableAdapter typeRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private Hotel_ManagementDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label lblMaxUnit;
        private System.Windows.Forms.Button btnLocLoaiPhong;
        private System.Windows.Forms.Label lblMinUnit;
        private System.Windows.Forms.Label lblFilterUnit;
        private System.Windows.Forms.TextBox TextBox_MinUnit;
        private System.Windows.Forms.TextBox TextBox_MaxUnit;
    }
}