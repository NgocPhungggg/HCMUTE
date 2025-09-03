namespace Library_Management
{
    partial class formManageStaff
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
            this.pickerHireDate = new System.Windows.Forms.DateTimePicker();
            this.labelHireDate = new System.Windows.Forms.Label();
            this.pickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelStaffName = new System.Windows.Forms.Label();
            this.dgvStaffs = new System.Windows.Forms.DataGridView();
            this.labelStatus = new System.Windows.Forms.Label();
            this.radioButtonActive = new System.Windows.Forms.RadioButton();
            this.radioButtonInactive = new System.Windows.Forms.RadioButton();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).BeginInit();
            this.SuspendLayout();
            // 
            // pickerHireDate
            // 
            this.pickerHireDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerHireDate.Location = new System.Drawing.Point(282, 551);
            this.pickerHireDate.Name = "pickerHireDate";
            this.pickerHireDate.Size = new System.Drawing.Size(200, 26);
            this.pickerHireDate.TabIndex = 66;
            // 
            // labelHireDate
            // 
            this.labelHireDate.AutoSize = true;
            this.labelHireDate.BackColor = System.Drawing.Color.Transparent;
            this.labelHireDate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHireDate.Location = new System.Drawing.Point(150, 551);
            this.labelHireDate.Name = "labelHireDate";
            this.labelHireDate.Size = new System.Drawing.Size(88, 22);
            this.labelHireDate.TabIndex = 65;
            this.labelHireDate.Text = "Hire Date";
            // 
            // pickerBirthDate
            // 
            this.pickerBirthDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerBirthDate.Location = new System.Drawing.Point(282, 351);
            this.pickerBirthDate.Name = "pickerBirthDate";
            this.pickerBirthDate.Size = new System.Drawing.Size(200, 26);
            this.pickerBirthDate.TabIndex = 64;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(282, 271);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(200, 25);
            this.tbID.TabIndex = 63;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(150, 271);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(30, 22);
            this.labelID.TabIndex = 62;
            this.labelID.Text = "ID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(382, 628);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 30);
            this.buttonDelete.TabIndex = 61;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(256, 628);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(120, 30);
            this.buttonUpdate.TabIndex = 60;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(129, 628);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(120, 30);
            this.buttonCreate.TabIndex = 59;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthDate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.Location = new System.Drawing.Point(150, 351);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(87, 22);
            this.labelBirthDate.TabIndex = 58;
            this.labelBirthDate.Text = "BirthDate";
            // 
            // tbPosition
            // 
            this.tbPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(282, 511);
            this.tbPosition.Multiline = true;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(200, 25);
            this.tbPosition.TabIndex = 57;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(282, 471);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(200, 25);
            this.tbAddress.TabIndex = 56;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(282, 431);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 25);
            this.tbEmail.TabIndex = 55;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(282, 391);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(200, 25);
            this.tbPhone.TabIndex = 54;
            // 
            // tbStaffName
            // 
            this.tbStaffName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffName.Location = new System.Drawing.Point(282, 307);
            this.tbStaffName.Multiline = true;
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(200, 25);
            this.tbStaffName.TabIndex = 53;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelPosition.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(150, 511);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(75, 22);
            this.labelPosition.TabIndex = 52;
            this.labelPosition.Text = "Position";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(150, 471);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(76, 22);
            this.labelAddress.TabIndex = 51;
            this.labelAddress.Text = "Address";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(150, 431);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 22);
            this.labelEmail.TabIndex = 50;
            this.labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(150, 391);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(58, 22);
            this.labelPhone.TabIndex = 49;
            this.labelPhone.Text = "Phone";
            // 
            // labelStaffName
            // 
            this.labelStaffName.AutoSize = true;
            this.labelStaffName.BackColor = System.Drawing.Color.Transparent;
            this.labelStaffName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffName.Location = new System.Drawing.Point(150, 311);
            this.labelStaffName.Name = "labelStaffName";
            this.labelStaffName.Size = new System.Drawing.Size(93, 22);
            this.labelStaffName.TabIndex = 48;
            this.labelStaffName.Text = "Full Name";
            // 
            // dgvStaffs
            // 
            this.dgvStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffs.Location = new System.Drawing.Point(597, 261);
            this.dgvStaffs.Name = "dgvStaffs";
            this.dgvStaffs.Size = new System.Drawing.Size(537, 428);
            this.dgvStaffs.TabIndex = 47;
            this.dgvStaffs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffs_DoubleClick);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(151, 587);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 22);
            this.labelStatus.TabIndex = 68;
            this.labelStatus.Text = "Status";
            // 
            // radioButtonActive
            // 
            this.radioButtonActive.AutoSize = true;
            this.radioButtonActive.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonActive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonActive.Location = new System.Drawing.Point(282, 594);
            this.radioButtonActive.Name = "radioButtonActive";
            this.radioButtonActive.Size = new System.Drawing.Size(66, 23);
            this.radioButtonActive.TabIndex = 69;
            this.radioButtonActive.TabStop = true;
            this.radioButtonActive.Text = "Active";
            this.radioButtonActive.UseVisualStyleBackColor = false;
            // 
            // radioButtonInactive
            // 
            this.radioButtonInactive.AutoSize = true;
            this.radioButtonInactive.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonInactive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInactive.Location = new System.Drawing.Point(366, 594);
            this.radioButtonInactive.Name = "radioButtonInactive";
            this.radioButtonInactive.Size = new System.Drawing.Size(74, 23);
            this.radioButtonInactive.TabIndex = 70;
            this.radioButtonInactive.TabStop = true;
            this.radioButtonInactive.Text = "Inactive";
            this.radioButtonInactive.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(1062, 719);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 30);
            this.buttonBack.TabIndex = 102;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // tbFind
            // 
            this.tbFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFind.Location = new System.Drawing.Point(597, 209);
            this.tbFind.Multiline = true;
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(411, 25);
            this.tbFind.TabIndex = 103;
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(1014, 209);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(120, 30);
            this.buttonFind.TabIndex = 104;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // formManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.backgroundStaff;
            this.ClientSize = new System.Drawing.Size(1194, 761);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.radioButtonInactive);
            this.Controls.Add(this.radioButtonActive);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.pickerHireDate);
            this.Controls.Add(this.labelHireDate);
            this.Controls.Add(this.pickerBirthDate);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbStaffName);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelStaffName);
            this.Controls.Add(this.dgvStaffs);
            this.Name = "formManageStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formManageStaff";
            this.Load += new System.EventHandler(this.formManageStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker pickerHireDate;
        private System.Windows.Forms.Label labelHireDate;
        private System.Windows.Forms.DateTimePicker pickerBirthDate;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelStaffName;
        private System.Windows.Forms.DataGridView dgvStaffs;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.RadioButton radioButtonActive;
        private System.Windows.Forms.RadioButton radioButtonInactive;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button buttonFind;
    }
}