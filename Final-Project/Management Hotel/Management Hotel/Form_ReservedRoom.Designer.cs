namespace Management_Hotel
{
    partial class Form_ReservedRoom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCustomer_id = new System.Windows.Forms.TextBox();
            this.updbutton = new System.Windows.Forms.Button();
            this.txtEmployee_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbill_id = new System.Windows.Forms.TextBox();
            this.txtDate_check_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoom_id = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtReserved_day = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvHoaDonDatPhong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementDataSet = new Management_Hotel.Hotel_ManagementDataSet();
            this.billTableAdapter = new Management_Hotel.Hotel_ManagementDataSetTableAdapters.BillTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonDatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(110, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 65);
            this.label4.TabIndex = 106;
            this.label4.Text = "CHECK IN ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // txtCustomer_id
            // 
            this.txtCustomer_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer_id.Location = new System.Drawing.Point(689, 221);
            this.txtCustomer_id.Name = "txtCustomer_id";
            this.txtCustomer_id.Size = new System.Drawing.Size(244, 29);
            this.txtCustomer_id.TabIndex = 95;
            // 
            // updbutton
            // 
            this.updbutton.BackColor = System.Drawing.Color.Linen;
            this.updbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.updbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updbutton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updbutton.Location = new System.Drawing.Point(961, 189);
            this.updbutton.Name = "updbutton";
            this.updbutton.Size = new System.Drawing.Size(93, 31);
            this.updbutton.TabIndex = 115;
            this.updbutton.Text = "Chỉnh sửa";
            this.updbutton.UseVisualStyleBackColor = false;
            this.updbutton.Click += new System.EventHandler(this.updbutton_Click);
            // 
            // txtEmployee_id
            // 
            this.txtEmployee_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployee_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee_id.Location = new System.Drawing.Point(689, 324);
            this.txtEmployee_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployee_id.Name = "txtEmployee_id";
            this.txtEmployee_id.Size = new System.Drawing.Size(244, 26);
            this.txtEmployee_id.TabIndex = 109;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(480, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 27);
            this.label11.TabIndex = 107;
            this.label11.Text = "Mã Nhân Viên:";
            // 
            // txtbill_id
            // 
            this.txtbill_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbill_id.Enabled = false;
            this.txtbill_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbill_id.Location = new System.Drawing.Point(689, 151);
            this.txtbill_id.Name = "txtbill_id";
            this.txtbill_id.Size = new System.Drawing.Size(244, 29);
            this.txtbill_id.TabIndex = 95;
            // 
            // txtDate_check_in
            // 
            this.txtDate_check_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate_check_in.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate_check_in.Location = new System.Drawing.Point(689, 253);
            this.txtDate_check_in.Name = "txtDate_check_in";
            this.txtDate_check_in.Size = new System.Drawing.Size(244, 29);
            this.txtDate_check_in.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 86;
            this.label3.Text = "Mã khách hàng:";
            // 
            // txtRoom_id
            // 
            this.txtRoom_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoom_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom_id.Location = new System.Drawing.Point(689, 186);
            this.txtRoom_id.Name = "txtRoom_id";
            this.txtRoom_id.Size = new System.Drawing.Size(244, 29);
            this.txtRoom_id.TabIndex = 95;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Linen;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(961, 226);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 31);
            this.btnXoa.TabIndex = 99;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtReserved_day
            // 
            this.txtReserved_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReserved_day.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReserved_day.Location = new System.Drawing.Point(689, 288);
            this.txtReserved_day.Name = "txtReserved_day";
            this.txtReserved_day.Size = new System.Drawing.Size(244, 29);
            this.txtReserved_day.TabIndex = 95;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Linen;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Location = new System.Drawing.Point(961, 151);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 31);
            this.btnThem.TabIndex = 100;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(479, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 27);
            this.label9.TabIndex = 87;
            this.label9.Text = "Số ngày đặt phòng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(480, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 27);
            this.label8.TabIndex = 87;
            this.label8.Text = "Mã phòng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 27);
            this.label7.TabIndex = 87;
            this.label7.Text = "Ngày giờ nhận phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 155);
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
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn11});
            this.dgvHoaDonDatPhong.DataSource = this.billBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDonDatPhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDonDatPhong.Location = new System.Drawing.Point(412, 357);
            this.dgvHoaDonDatPhong.Name = "dgvHoaDonDatPhong";
            this.dgvHoaDonDatPhong.RowHeadersWidth = 51;
            this.dgvHoaDonDatPhong.Size = new System.Drawing.Size(743, 384);
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ReservedDays";
            this.dataGridViewTextBoxColumn6.HeaderText = "ReservedDays";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // Form_ReservedRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.BackgroundRoom;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.txtCustomer_id);
            this.Controls.Add(this.updbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmployee_id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvHoaDonDatPhong);
            this.Controls.Add(this.txtbill_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDate_check_in);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRoom_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtReserved_day);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_ReservedRoom";
            this.Text = "CheckInDatPhong";
            this.Load += new System.EventHandler(this.Form_ReservedRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonDatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button updbutton;
        private System.Windows.Forms.TextBox txtEmployee_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbill_id;
        private System.Windows.Forms.TextBox txtCustomer_id;
        private System.Windows.Forms.TextBox txtDate_check_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoom_id;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtReserved_day;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
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
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource billBindingSource;
        private Hotel_ManagementDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}