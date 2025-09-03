namespace Library_Management
{
    partial class formManageReader
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
            this.dgvReaders = new System.Windows.Forms.DataGridView();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelReaderName = new System.Windows.Forms.Label();
            this.tbReaderName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.pickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReaders
            // 
            this.dgvReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaders.Location = new System.Drawing.Point(618, 207);
            this.dgvReaders.Name = "dgvReaders";
            this.dgvReaders.Size = new System.Drawing.Size(514, 455);
            this.dgvReaders.TabIndex = 0;
            this.dgvReaders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReaders_DoubleClick);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelPosition.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPosition.Location = new System.Drawing.Point(123, 520);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(75, 22);
            this.labelPosition.TabIndex = 11;
            this.labelPosition.Text = "Position";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAddress.Location = new System.Drawing.Point(123, 480);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(76, 22);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "Address";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEmail.Location = new System.Drawing.Point(123, 440);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 22);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPhone.Location = new System.Drawing.Point(123, 400);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(58, 22);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Phone";
            // 
            // labelReaderName
            // 
            this.labelReaderName.AutoSize = true;
            this.labelReaderName.BackColor = System.Drawing.Color.Transparent;
            this.labelReaderName.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelReaderName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelReaderName.Location = new System.Drawing.Point(123, 320);
            this.labelReaderName.Name = "labelReaderName";
            this.labelReaderName.Size = new System.Drawing.Size(93, 22);
            this.labelReaderName.TabIndex = 7;
            this.labelReaderName.Text = "Full Name";
            // 
            // tbReaderName
            // 
            this.tbReaderName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReaderName.Location = new System.Drawing.Point(255, 316);
            this.tbReaderName.Multiline = true;
            this.tbReaderName.Name = "tbReaderName";
            this.tbReaderName.Size = new System.Drawing.Size(200, 25);
            this.tbReaderName.TabIndex = 13;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(255, 400);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(200, 25);
            this.tbPhone.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(255, 440);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 25);
            this.tbEmail.TabIndex = 15;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(255, 480);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(200, 25);
            this.tbAddress.TabIndex = 16;
            // 
            // tbPosition
            // 
            this.tbPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(255, 520);
            this.tbPosition.Multiline = true;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(200, 25);
            this.tbPosition.TabIndex = 17;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthDate.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelBirthDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelBirthDate.Location = new System.Drawing.Point(123, 360);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(87, 22);
            this.labelBirthDate.TabIndex = 19;
            this.labelBirthDate.Text = "BirthDate";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(112, 562);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(120, 30);
            this.buttonCreate.TabIndex = 21;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(239, 562);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(120, 30);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(365, 562);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 30);
            this.buttonDelete.TabIndex = 23;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelID.Location = new System.Drawing.Point(123, 280);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(30, 22);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(255, 280);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(200, 25);
            this.tbID.TabIndex = 25;
            // 
            // pickerBirthDate
            // 
            this.pickerBirthDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerBirthDate.Location = new System.Drawing.Point(255, 360);
            this.pickerBirthDate.Name = "pickerBirthDate";
            this.pickerBirthDate.Size = new System.Drawing.Size(200, 26);
            this.pickerBirthDate.TabIndex = 26;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(1062, 719);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 30);
            this.buttonBack.TabIndex = 73;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // formManageReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.backgroundReaders;
            this.ClientSize = new System.Drawing.Size(1194, 761);
            this.Controls.Add(this.buttonBack);
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
            this.Controls.Add(this.tbReaderName);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelReaderName);
            this.Controls.Add(this.dgvReaders);
            this.Name = "formManageReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formManageReader";
            this.Load += new System.EventHandler(this.formManageReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReaders;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelReaderName;
        private System.Windows.Forms.TextBox tbReaderName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DateTimePicker pickerBirthDate;
        private System.Windows.Forms.Button buttonBack;
    }
}