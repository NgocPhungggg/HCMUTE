namespace Management_Hotel
{
    partial class Form_ManageReceptionists
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
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_UploadPic = new System.Windows.Forms.Button();
            this.Label_Pic = new System.Windows.Forms.Label();
            this.TextBox_Address = new System.Windows.Forms.TextBox();
            this.Label_Address = new System.Windows.Forms.Label();
            this.Label_BirthDate = new System.Windows.Forms.Label();
            this.DatePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.RadioButton_Female = new System.Windows.Forms.RadioButton();
            this.RadioButton_Male = new System.Windows.Forms.RadioButton();
            this.Label_Gender = new System.Windows.Forms.Label();
            this.Label_Phone = new System.Windows.Forms.Label();
            this.TextBox_Phone = new System.Windows.Forms.TextBox();
            this.Label_Mail = new System.Windows.Forms.Label();
            this.TextBox_Mail = new System.Windows.Forms.TextBox();
            this.Label_FullName = new System.Windows.Forms.Label();
            this.TextBox_FullName = new System.Windows.Forms.TextBox();
            this.Label_ID = new System.Windows.Forms.Label();
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.DataGridView_ListReceptionist = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresssDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementDataSet = new Management_Hotel.Hotel_ManagementDataSet();
            this.informationTableAdapter = new Management_Hotel.Hotel_ManagementDataSetTableAdapters.InformationTableAdapter();
            this.Button_TakePic = new System.Windows.Forms.Button();
            this.PictureBox_Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListReceptionist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.Tan;
            this.Button_Delete.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.Location = new System.Drawing.Point(1263, 682);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(100, 35);
            this.Button_Delete.TabIndex = 72;
            this.Button_Delete.Text = "Xóa";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Edit
            // 
            this.Button_Edit.BackColor = System.Drawing.Color.Tan;
            this.Button_Edit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Edit.Location = new System.Drawing.Point(1138, 682);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(100, 35);
            this.Button_Edit.TabIndex = 71;
            this.Button_Edit.Text = "Sửa";
            this.Button_Edit.UseVisualStyleBackColor = false;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.Tan;
            this.Button_Add.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(1013, 682);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(100, 35);
            this.Button_Add.TabIndex = 70;
            this.Button_Add.Text = "Thêm";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_UploadPic
            // 
            this.Button_UploadPic.BackColor = System.Drawing.Color.Linen;
            this.Button_UploadPic.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UploadPic.Location = new System.Drawing.Point(1160, 636);
            this.Button_UploadPic.Name = "Button_UploadPic";
            this.Button_UploadPic.Size = new System.Drawing.Size(200, 30);
            this.Button_UploadPic.TabIndex = 69;
            this.Button_UploadPic.Text = "Upload Picture";
            this.Button_UploadPic.UseVisualStyleBackColor = false;
            this.Button_UploadPic.Click += new System.EventHandler(this.Button_UploadPic_Click);
            // 
            // Label_Pic
            // 
            this.Label_Pic.AutoSize = true;
            this.Label_Pic.BackColor = System.Drawing.Color.Transparent;
            this.Label_Pic.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Pic.ForeColor = System.Drawing.Color.Black;
            this.Label_Pic.Location = new System.Drawing.Point(1013, 476);
            this.Label_Pic.Name = "Label_Pic";
            this.Label_Pic.Size = new System.Drawing.Size(64, 23);
            this.Label_Pic.TabIndex = 68;
            this.Label_Pic.Text = "Picture";
            // 
            // TextBox_Address
            // 
            this.TextBox_Address.BackColor = System.Drawing.Color.Linen;
            this.TextBox_Address.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox_Address.Location = new System.Drawing.Point(1113, 406);
            this.TextBox_Address.Multiline = true;
            this.TextBox_Address.Name = "TextBox_Address";
            this.TextBox_Address.Size = new System.Drawing.Size(250, 60);
            this.TextBox_Address.TabIndex = 66;
            // 
            // Label_Address
            // 
            this.Label_Address.AutoSize = true;
            this.Label_Address.BackColor = System.Drawing.Color.Transparent;
            this.Label_Address.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Address.ForeColor = System.Drawing.Color.Black;
            this.Label_Address.Location = new System.Drawing.Point(1013, 406);
            this.Label_Address.Name = "Label_Address";
            this.Label_Address.Size = new System.Drawing.Size(73, 23);
            this.Label_Address.TabIndex = 65;
            this.Label_Address.Text = "Address";
            // 
            // Label_BirthDate
            // 
            this.Label_BirthDate.AutoSize = true;
            this.Label_BirthDate.BackColor = System.Drawing.Color.Transparent;
            this.Label_BirthDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BirthDate.ForeColor = System.Drawing.Color.Black;
            this.Label_BirthDate.Location = new System.Drawing.Point(1013, 286);
            this.Label_BirthDate.Name = "Label_BirthDate";
            this.Label_BirthDate.Size = new System.Drawing.Size(94, 23);
            this.Label_BirthDate.TabIndex = 64;
            this.Label_BirthDate.Text = "Birth Date";
            // 
            // DatePicker_BirthDate
            // 
            this.DatePicker_BirthDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DatePicker_BirthDate.CalendarMonthBackground = System.Drawing.Color.Goldenrod;
            this.DatePicker_BirthDate.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.DatePicker_BirthDate.Location = new System.Drawing.Point(1113, 286);
            this.DatePicker_BirthDate.Name = "DatePicker_BirthDate";
            this.DatePicker_BirthDate.Size = new System.Drawing.Size(251, 20);
            this.DatePicker_BirthDate.TabIndex = 63;
            this.DatePicker_BirthDate.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // RadioButton_Female
            // 
            this.RadioButton_Female.AutoSize = true;
            this.RadioButton_Female.BackColor = System.Drawing.Color.Linen;
            this.RadioButton_Female.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_Female.ForeColor = System.Drawing.Color.Black;
            this.RadioButton_Female.Location = new System.Drawing.Point(1232, 246);
            this.RadioButton_Female.Name = "RadioButton_Female";
            this.RadioButton_Female.Size = new System.Drawing.Size(81, 27);
            this.RadioButton_Female.TabIndex = 62;
            this.RadioButton_Female.TabStop = true;
            this.RadioButton_Female.Text = "Female";
            this.RadioButton_Female.UseVisualStyleBackColor = false;
            // 
            // RadioButton_Male
            // 
            this.RadioButton_Male.AutoSize = true;
            this.RadioButton_Male.BackColor = System.Drawing.Color.Linen;
            this.RadioButton_Male.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_Male.ForeColor = System.Drawing.Color.Black;
            this.RadioButton_Male.Location = new System.Drawing.Point(1160, 246);
            this.RadioButton_Male.Name = "RadioButton_Male";
            this.RadioButton_Male.Size = new System.Drawing.Size(64, 27);
            this.RadioButton_Male.TabIndex = 61;
            this.RadioButton_Male.TabStop = true;
            this.RadioButton_Male.Text = "Male";
            this.RadioButton_Male.UseVisualStyleBackColor = false;
            // 
            // Label_Gender
            // 
            this.Label_Gender.AutoSize = true;
            this.Label_Gender.BackColor = System.Drawing.Color.Transparent;
            this.Label_Gender.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Gender.ForeColor = System.Drawing.Color.Black;
            this.Label_Gender.Location = new System.Drawing.Point(1013, 246);
            this.Label_Gender.Name = "Label_Gender";
            this.Label_Gender.Size = new System.Drawing.Size(64, 23);
            this.Label_Gender.TabIndex = 60;
            this.Label_Gender.Text = "Gender";
            // 
            // Label_Phone
            // 
            this.Label_Phone.AutoSize = true;
            this.Label_Phone.BackColor = System.Drawing.Color.Transparent;
            this.Label_Phone.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Phone.ForeColor = System.Drawing.Color.Black;
            this.Label_Phone.Location = new System.Drawing.Point(1013, 366);
            this.Label_Phone.Name = "Label_Phone";
            this.Label_Phone.Size = new System.Drawing.Size(53, 23);
            this.Label_Phone.TabIndex = 59;
            this.Label_Phone.Text = "Phone";
            // 
            // TextBox_Phone
            // 
            this.TextBox_Phone.BackColor = System.Drawing.Color.Linen;
            this.TextBox_Phone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox_Phone.Location = new System.Drawing.Point(1113, 366);
            this.TextBox_Phone.Multiline = true;
            this.TextBox_Phone.Name = "TextBox_Phone";
            this.TextBox_Phone.Size = new System.Drawing.Size(250, 30);
            this.TextBox_Phone.TabIndex = 58;
            // 
            // Label_Mail
            // 
            this.Label_Mail.AutoSize = true;
            this.Label_Mail.BackColor = System.Drawing.Color.Transparent;
            this.Label_Mail.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mail.ForeColor = System.Drawing.Color.Black;
            this.Label_Mail.Location = new System.Drawing.Point(1013, 326);
            this.Label_Mail.Name = "Label_Mail";
            this.Label_Mail.Size = new System.Drawing.Size(41, 23);
            this.Label_Mail.TabIndex = 57;
            this.Label_Mail.Text = "Mail";
            // 
            // TextBox_Mail
            // 
            this.TextBox_Mail.BackColor = System.Drawing.Color.Linen;
            this.TextBox_Mail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox_Mail.Location = new System.Drawing.Point(1113, 326);
            this.TextBox_Mail.Multiline = true;
            this.TextBox_Mail.Name = "TextBox_Mail";
            this.TextBox_Mail.Size = new System.Drawing.Size(250, 30);
            this.TextBox_Mail.TabIndex = 56;
            // 
            // Label_FullName
            // 
            this.Label_FullName.AutoSize = true;
            this.Label_FullName.BackColor = System.Drawing.Color.Transparent;
            this.Label_FullName.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FullName.ForeColor = System.Drawing.Color.Black;
            this.Label_FullName.Location = new System.Drawing.Point(1013, 206);
            this.Label_FullName.Name = "Label_FullName";
            this.Label_FullName.Size = new System.Drawing.Size(86, 23);
            this.Label_FullName.TabIndex = 55;
            this.Label_FullName.Text = "Full Name";
            // 
            // TextBox_FullName
            // 
            this.TextBox_FullName.BackColor = System.Drawing.Color.Linen;
            this.TextBox_FullName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox_FullName.Location = new System.Drawing.Point(1113, 206);
            this.TextBox_FullName.Multiline = true;
            this.TextBox_FullName.Name = "TextBox_FullName";
            this.TextBox_FullName.Size = new System.Drawing.Size(250, 30);
            this.TextBox_FullName.TabIndex = 54;
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.BackColor = System.Drawing.Color.Transparent;
            this.Label_ID.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ID.ForeColor = System.Drawing.Color.Black;
            this.Label_ID.Location = new System.Drawing.Point(1013, 166);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(31, 23);
            this.Label_ID.TabIndex = 53;
            this.Label_ID.Text = "ID";
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.BackColor = System.Drawing.Color.Linen;
            this.TextBox_ID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox_ID.Location = new System.Drawing.Point(1113, 166);
            this.TextBox_ID.Multiline = true;
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(250, 30);
            this.TextBox_ID.TabIndex = 52;
            // 
            // DataGridView_ListReceptionist
            // 
            this.DataGridView_ListReceptionist.AutoGenerateColumns = false;
            this.DataGridView_ListReceptionist.BackgroundColor = System.Drawing.Color.Tan;
            this.DataGridView_ListReceptionist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ListReceptionist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addresssDataGridViewTextBoxColumn,
            this.picDataGridViewImageColumn});
            this.DataGridView_ListReceptionist.DataSource = this.informationBindingSource;
            this.DataGridView_ListReceptionist.Location = new System.Drawing.Point(111, 166);
            this.DataGridView_ListReceptionist.Name = "DataGridView_ListReceptionist";
            this.DataGridView_ListReceptionist.Size = new System.Drawing.Size(896, 551);
            this.DataGridView_ListReceptionist.TabIndex = 51;
            this.DataGridView_ListReceptionist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ListReceptionist_CellDoubleClick);
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
            // 
            // picDataGridViewImageColumn
            // 
            this.picDataGridViewImageColumn.DataPropertyName = "Pic";
            this.picDataGridViewImageColumn.HeaderText = "Pic";
            this.picDataGridViewImageColumn.Name = "picDataGridViewImageColumn";
            // 
            // informationBindingSource
            // 
            this.informationBindingSource.DataMember = "Information";
            this.informationBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // Button_TakePic
            // 
            this.Button_TakePic.BackColor = System.Drawing.Color.Linen;
            this.Button_TakePic.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_TakePic.Location = new System.Drawing.Point(1013, 636);
            this.Button_TakePic.Name = "Button_TakePic";
            this.Button_TakePic.Size = new System.Drawing.Size(140, 30);
            this.Button_TakePic.TabIndex = 73;
            this.Button_TakePic.Text = "Chụp ảnh";
            this.Button_TakePic.UseVisualStyleBackColor = false;
            this.Button_TakePic.Click += new System.EventHandler(this.Button_TakePic_Click);
            // 
            // PictureBox_Pic
            // 
            this.PictureBox_Pic.BackColor = System.Drawing.Color.Linen;
            this.PictureBox_Pic.Location = new System.Drawing.Point(1113, 476);
            this.PictureBox_Pic.Name = "PictureBox_Pic";
            this.PictureBox_Pic.Size = new System.Drawing.Size(250, 150);
            this.PictureBox_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Pic.TabIndex = 67;
            this.PictureBox_Pic.TabStop = false;
            // 
            // Form_ManageReceptionists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.Button_TakePic);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_UploadPic);
            this.Controls.Add(this.Label_Pic);
            this.Controls.Add(this.PictureBox_Pic);
            this.Controls.Add(this.TextBox_Address);
            this.Controls.Add(this.Label_Address);
            this.Controls.Add(this.Label_BirthDate);
            this.Controls.Add(this.DatePicker_BirthDate);
            this.Controls.Add(this.RadioButton_Female);
            this.Controls.Add(this.RadioButton_Male);
            this.Controls.Add(this.Label_Gender);
            this.Controls.Add(this.Label_Phone);
            this.Controls.Add(this.TextBox_Phone);
            this.Controls.Add(this.Label_Mail);
            this.Controls.Add(this.TextBox_Mail);
            this.Controls.Add(this.Label_FullName);
            this.Controls.Add(this.TextBox_FullName);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.DataGridView_ListReceptionist);
            this.Name = "Form_ManageReceptionists";
            this.Text = "Quản lý lễ tân";
            this.Load += new System.EventHandler(this.Form_ManageReceptionists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListReceptionist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_UploadPic;
        private System.Windows.Forms.Label Label_Pic;
        private System.Windows.Forms.TextBox TextBox_Address;
        private System.Windows.Forms.Label Label_Address;
        private System.Windows.Forms.Label Label_BirthDate;
        private System.Windows.Forms.DateTimePicker DatePicker_BirthDate;
        private System.Windows.Forms.RadioButton RadioButton_Female;
        private System.Windows.Forms.RadioButton RadioButton_Male;
        private System.Windows.Forms.Label Label_Gender;
        private System.Windows.Forms.Label Label_Phone;
        private System.Windows.Forms.TextBox TextBox_Phone;
        private System.Windows.Forms.Label Label_Mail;
        private System.Windows.Forms.TextBox TextBox_Mail;
        private System.Windows.Forms.Label Label_FullName;
        private System.Windows.Forms.TextBox TextBox_FullName;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.DataGridView DataGridView_ListReceptionist;
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
        private System.Windows.Forms.Button Button_TakePic;
        private System.Windows.Forms.PictureBox PictureBox_Pic;
    }
}