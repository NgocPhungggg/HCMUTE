namespace Management_Hotel
{
    partial class Form_Bill
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
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPay_time = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.discounttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployee_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal_money = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbill_id = new System.Windows.Forms.TextBox();
            this.txtCustomer_id = new System.Windows.Forms.TextBox();
            this.txtDate_checkout = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoom_id = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvHoaDonDatPhong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementDataSet = new Management_Hotel.Hotel_ManagementDataSet();
            this.billTableAdapter = new Management_Hotel.Hotel_ManagementDataSetTableAdapters.BillTableAdapter();
            this.btnXoa = new System.Windows.Forms.Button();
            this.Button_FindID = new System.Windows.Forms.Button();
            this.Button_Discount = new System.Windows.Forms.Button();
            this.Button_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonDatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.BackColor = System.Drawing.Color.Linen;
            this.comboBoxPayment.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Items.AddRange(new object[] {
            "Chuyen khoan",
            "Tien mat"});
            this.comboBoxPayment.Location = new System.Drawing.Point(807, 365);
            this.comboBoxPayment.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(168, 25);
            this.comboBoxPayment.TabIndex = 115;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(517, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(272, 27);
            this.label13.TabIndex = 113;
            this.label13.Text = "Ngày giờ thanh toán hóa đơn:";
            // 
            // txtPay_time
            // 
            this.txtPay_time.BackColor = System.Drawing.Color.Linen;
            this.txtPay_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPay_time.Enabled = false;
            this.txtPay_time.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPay_time.Location = new System.Drawing.Point(807, 333);
            this.txtPay_time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPay_time.Multiline = true;
            this.txtPay_time.Name = "txtPay_time";
            this.txtPay_time.Size = new System.Drawing.Size(168, 29);
            this.txtPay_time.TabIndex = 114;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(517, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 27);
            this.label12.TabIndex = 111;
            this.label12.Text = "Giảm giá:";
            // 
            // discounttextBox
            // 
            this.discounttextBox.BackColor = System.Drawing.Color.Linen;
            this.discounttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discounttextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discounttextBox.Location = new System.Drawing.Point(807, 273);
            this.discounttextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.discounttextBox.Multiline = true;
            this.discounttextBox.Name = "discounttextBox";
            this.discounttextBox.Size = new System.Drawing.Size(168, 29);
            this.discounttextBox.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 27);
            this.label1.TabIndex = 105;
            this.label1.Text = "Phương thức thanh toán:";
            // 
            // txtEmployee_id
            // 
            this.txtEmployee_id.BackColor = System.Drawing.Color.Linen;
            this.txtEmployee_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployee_id.Enabled = false;
            this.txtEmployee_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee_id.Location = new System.Drawing.Point(807, 393);
            this.txtEmployee_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployee_id.Multiline = true;
            this.txtEmployee_id.Name = "txtEmployee_id";
            this.txtEmployee_id.Size = new System.Drawing.Size(168, 29);
            this.txtEmployee_id.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 27);
            this.label5.TabIndex = 106;
            this.label5.Text = "Tổng giá tiền hóa đơn:";
            // 
            // txtTotal_money
            // 
            this.txtTotal_money.BackColor = System.Drawing.Color.Linen;
            this.txtTotal_money.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal_money.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal_money.Location = new System.Drawing.Point(807, 303);
            this.txtTotal_money.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal_money.Multiline = true;
            this.txtTotal_money.Name = "txtTotal_money";
            this.txtTotal_money.Size = new System.Drawing.Size(168, 29);
            this.txtTotal_money.TabIndex = 110;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(517, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 27);
            this.label11.TabIndex = 107;
            this.label11.Text = "Mã Nhân Viên:";
            // 
            // txtbill_id
            // 
            this.txtbill_id.BackColor = System.Drawing.Color.Linen;
            this.txtbill_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbill_id.Enabled = false;
            this.txtbill_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbill_id.Location = new System.Drawing.Point(807, 153);
            this.txtbill_id.Name = "txtbill_id";
            this.txtbill_id.Size = new System.Drawing.Size(168, 29);
            this.txtbill_id.TabIndex = 95;
            // 
            // txtCustomer_id
            // 
            this.txtCustomer_id.BackColor = System.Drawing.Color.Linen;
            this.txtCustomer_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer_id.Enabled = false;
            this.txtCustomer_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer_id.Location = new System.Drawing.Point(807, 213);
            this.txtCustomer_id.Name = "txtCustomer_id";
            this.txtCustomer_id.Size = new System.Drawing.Size(168, 29);
            this.txtCustomer_id.TabIndex = 95;
            // 
            // txtDate_checkout
            // 
            this.txtDate_checkout.BackColor = System.Drawing.Color.Linen;
            this.txtDate_checkout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate_checkout.Enabled = false;
            this.txtDate_checkout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate_checkout.Location = new System.Drawing.Point(807, 243);
            this.txtDate_checkout.Name = "txtDate_checkout";
            this.txtDate_checkout.Size = new System.Drawing.Size(168, 29);
            this.txtDate_checkout.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 86;
            this.label3.Text = "Mã khách hàng:";
            // 
            // txtRoom_id
            // 
            this.txtRoom_id.BackColor = System.Drawing.Color.Linen;
            this.txtRoom_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoom_id.Enabled = false;
            this.txtRoom_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom_id.Location = new System.Drawing.Point(807, 183);
            this.txtRoom_id.Name = "txtRoom_id";
            this.txtRoom_id.Size = new System.Drawing.Size(168, 29);
            this.txtRoom_id.TabIndex = 95;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Linen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(1004, 189);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 31);
            this.btnLuu.TabIndex = 103;
            this.btnLuu.Text = "Cập nhật";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(517, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 27);
            this.label10.TabIndex = 87;
            this.label10.Text = "Ngày giờ trả phòng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(517, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 27);
            this.label8.TabIndex = 87;
            this.label8.Text = "Mã phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 27);
            this.label6.TabIndex = 87;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // dgvHoaDonDatPhong
            // 
            this.dgvHoaDonDatPhong.AllowUserToAddRows = false;
            this.dgvHoaDonDatPhong.AllowUserToDeleteRows = false;
            this.dgvHoaDonDatPhong.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonDatPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDonDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonDatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvHoaDonDatPhong.DataSource = this.billBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDonDatPhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDonDatPhong.Location = new System.Drawing.Point(172, 441);
            this.dgvHoaDonDatPhong.Name = "dgvHoaDonDatPhong";
            this.dgvHoaDonDatPhong.RowHeadersWidth = 51;
            this.dgvHoaDonDatPhong.Size = new System.Drawing.Size(1153, 308);
            this.dgvHoaDonDatPhong.TabIndex = 110;
            this.dgvHoaDonDatPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonDatPhong_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BillID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BillID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RoomID";
            this.dataGridViewTextBoxColumn2.HeaderText = "RoomID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn3.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CheckIn";
            this.dataGridViewTextBoxColumn4.HeaderText = "CheckIn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CheckOut";
            this.dataGridViewTextBoxColumn5.HeaderText = "CheckOut";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ReservedDays";
            this.dataGridViewTextBoxColumn6.HeaderText = "ReservedDays";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TotalMoney";
            this.dataGridViewTextBoxColumn7.HeaderText = "TotalMoney";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn8.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PayTime";
            this.dataGridViewTextBoxColumn9.HeaderText = "PayTime";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Payment";
            this.dataGridViewTextBoxColumn10.HeaderText = "Payment";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn11.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Linen;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(1004, 225);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 31);
            this.btnXoa.TabIndex = 99;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Button_FindID
            // 
            this.Button_FindID.BackColor = System.Drawing.Color.Linen;
            this.Button_FindID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_FindID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.Button_FindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FindID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_FindID.ForeColor = System.Drawing.Color.Black;
            this.Button_FindID.Location = new System.Drawing.Point(1004, 154);
            this.Button_FindID.Name = "Button_FindID";
            this.Button_FindID.Size = new System.Drawing.Size(93, 31);
            this.Button_FindID.TabIndex = 116;
            this.Button_FindID.Text = "Tìm";
            this.Button_FindID.UseVisualStyleBackColor = false;
            this.Button_FindID.Click += new System.EventHandler(this.Button_FindID_Click);
            // 
            // Button_Discount
            // 
            this.Button_Discount.BackgroundImage = global::Management_Hotel.Properties.Resources.Discount;
            this.Button_Discount.Location = new System.Drawing.Point(981, 264);
            this.Button_Discount.Name = "Button_Discount";
            this.Button_Discount.Size = new System.Drawing.Size(50, 50);
            this.Button_Discount.TabIndex = 117;
            this.Button_Discount.UseVisualStyleBackColor = true;
            this.Button_Discount.Click += new System.EventHandler(this.Button_Discount_Click);
            // 
            // Button_Print
            // 
            this.Button_Print.BackColor = System.Drawing.Color.Linen;
            this.Button_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.Button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Print.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_Print.ForeColor = System.Drawing.Color.Black;
            this.Button_Print.Location = new System.Drawing.Point(1004, 320);
            this.Button_Print.Name = "Button_Print";
            this.Button_Print.Size = new System.Drawing.Size(93, 31);
            this.Button_Print.TabIndex = 118;
            this.Button_Print.Text = "In";
            this.Button_Print.UseVisualStyleBackColor = false;
            this.Button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // Form_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.BackgroundRoom;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.Button_Print);
            this.Controls.Add(this.Button_Discount);
            this.Controls.Add(this.Button_FindID);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPay_time);
            this.Controls.Add(this.dgvHoaDonDatPhong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbill_id);
            this.Controls.Add(this.discounttextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmployee_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotal_money);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtRoom_id);
            this.Controls.Add(this.txtCustomer_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate_checkout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Bill";
            this.Text = "CheckoutPhong";
            this.Load += new System.EventHandler(this.Form_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonDatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPay_time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox discounttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployee_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal_money;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbill_id;
        private System.Windows.Forms.TextBox txtCustomer_id;
        private System.Windows.Forms.TextBox txtDate_checkout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoom_id;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvHoaDonDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource billBindingSource;
        private Hotel_ManagementDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button Button_FindID;
        private System.Windows.Forms.Button Button_Discount;
        private System.Windows.Forms.Button Button_Print;
    }
}