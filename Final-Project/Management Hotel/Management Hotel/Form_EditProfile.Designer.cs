namespace Management_Hotel
{
    partial class Form_EditProfile
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
            this.Button_UploadPic = new System.Windows.Forms.Button();
            this.Label_Pic = new System.Windows.Forms.Label();
            this.PictureBox_Pic = new System.Windows.Forms.PictureBox();
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
            this.Label_ID = new System.Windows.Forms.Label();
            this.Label_MyID = new System.Windows.Forms.Label();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Label_MyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_UploadPic
            // 
            this.Button_UploadPic.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UploadPic.Location = new System.Drawing.Point(678, 632);
            this.Button_UploadPic.Name = "Button_UploadPic";
            this.Button_UploadPic.Size = new System.Drawing.Size(250, 30);
            this.Button_UploadPic.TabIndex = 65;
            this.Button_UploadPic.Text = "Upload Picture";
            this.Button_UploadPic.UseVisualStyleBackColor = true;
            this.Button_UploadPic.Click += new System.EventHandler(this.Button_UploadPic_Click);
            // 
            // Label_Pic
            // 
            this.Label_Pic.AutoSize = true;
            this.Label_Pic.BackColor = System.Drawing.Color.Transparent;
            this.Label_Pic.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Pic.ForeColor = System.Drawing.Color.Black;
            this.Label_Pic.Location = new System.Drawing.Point(578, 472);
            this.Label_Pic.Name = "Label_Pic";
            this.Label_Pic.Size = new System.Drawing.Size(64, 23);
            this.Label_Pic.TabIndex = 64;
            this.Label_Pic.Text = "Picture";
            // 
            // PictureBox_Pic
            // 
            this.PictureBox_Pic.BackColor = System.Drawing.Color.Linen;
            this.PictureBox_Pic.Location = new System.Drawing.Point(678, 472);
            this.PictureBox_Pic.Name = "PictureBox_Pic";
            this.PictureBox_Pic.Size = new System.Drawing.Size(250, 150);
            this.PictureBox_Pic.TabIndex = 63;
            this.PictureBox_Pic.TabStop = false;
            // 
            // TextBox_Address
            // 
            this.TextBox_Address.BackColor = System.Drawing.Color.Linen;
            this.TextBox_Address.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox_Address.Location = new System.Drawing.Point(678, 402);
            this.TextBox_Address.Multiline = true;
            this.TextBox_Address.Name = "TextBox_Address";
            this.TextBox_Address.Size = new System.Drawing.Size(250, 60);
            this.TextBox_Address.TabIndex = 62;
            // 
            // Label_Address
            // 
            this.Label_Address.AutoSize = true;
            this.Label_Address.BackColor = System.Drawing.Color.Transparent;
            this.Label_Address.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Address.ForeColor = System.Drawing.Color.Black;
            this.Label_Address.Location = new System.Drawing.Point(578, 402);
            this.Label_Address.Name = "Label_Address";
            this.Label_Address.Size = new System.Drawing.Size(73, 23);
            this.Label_Address.TabIndex = 61;
            this.Label_Address.Text = "Address";
            // 
            // Label_BirthDate
            // 
            this.Label_BirthDate.AutoSize = true;
            this.Label_BirthDate.BackColor = System.Drawing.Color.Transparent;
            this.Label_BirthDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BirthDate.ForeColor = System.Drawing.Color.Black;
            this.Label_BirthDate.Location = new System.Drawing.Point(578, 282);
            this.Label_BirthDate.Name = "Label_BirthDate";
            this.Label_BirthDate.Size = new System.Drawing.Size(94, 23);
            this.Label_BirthDate.TabIndex = 60;
            this.Label_BirthDate.Text = "Birth Date";
            // 
            // DatePicker_BirthDate
            // 
            this.DatePicker_BirthDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DatePicker_BirthDate.CalendarMonthBackground = System.Drawing.Color.Goldenrod;
            this.DatePicker_BirthDate.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.DatePicker_BirthDate.Location = new System.Drawing.Point(678, 282);
            this.DatePicker_BirthDate.Name = "DatePicker_BirthDate";
            this.DatePicker_BirthDate.Size = new System.Drawing.Size(251, 20);
            this.DatePicker_BirthDate.TabIndex = 59;
            this.DatePicker_BirthDate.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // RadioButton_Female
            // 
            this.RadioButton_Female.AutoSize = true;
            this.RadioButton_Female.BackColor = System.Drawing.Color.Linen;
            this.RadioButton_Female.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_Female.ForeColor = System.Drawing.Color.Black;
            this.RadioButton_Female.Location = new System.Drawing.Point(797, 242);
            this.RadioButton_Female.Name = "RadioButton_Female";
            this.RadioButton_Female.Size = new System.Drawing.Size(81, 27);
            this.RadioButton_Female.TabIndex = 58;
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
            this.RadioButton_Male.Location = new System.Drawing.Point(725, 242);
            this.RadioButton_Male.Name = "RadioButton_Male";
            this.RadioButton_Male.Size = new System.Drawing.Size(64, 27);
            this.RadioButton_Male.TabIndex = 57;
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
            this.Label_Gender.Location = new System.Drawing.Point(578, 242);
            this.Label_Gender.Name = "Label_Gender";
            this.Label_Gender.Size = new System.Drawing.Size(64, 23);
            this.Label_Gender.TabIndex = 56;
            this.Label_Gender.Text = "Gender";
            // 
            // Label_Phone
            // 
            this.Label_Phone.AutoSize = true;
            this.Label_Phone.BackColor = System.Drawing.Color.Transparent;
            this.Label_Phone.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Phone.ForeColor = System.Drawing.Color.Black;
            this.Label_Phone.Location = new System.Drawing.Point(578, 362);
            this.Label_Phone.Name = "Label_Phone";
            this.Label_Phone.Size = new System.Drawing.Size(53, 23);
            this.Label_Phone.TabIndex = 55;
            this.Label_Phone.Text = "Phone";
            // 
            // TextBox_Phone
            // 
            this.TextBox_Phone.BackColor = System.Drawing.Color.Linen;
            this.TextBox_Phone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox_Phone.Location = new System.Drawing.Point(678, 362);
            this.TextBox_Phone.Multiline = true;
            this.TextBox_Phone.Name = "TextBox_Phone";
            this.TextBox_Phone.Size = new System.Drawing.Size(250, 30);
            this.TextBox_Phone.TabIndex = 54;
            // 
            // Label_Mail
            // 
            this.Label_Mail.AutoSize = true;
            this.Label_Mail.BackColor = System.Drawing.Color.Transparent;
            this.Label_Mail.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mail.ForeColor = System.Drawing.Color.Black;
            this.Label_Mail.Location = new System.Drawing.Point(578, 322);
            this.Label_Mail.Name = "Label_Mail";
            this.Label_Mail.Size = new System.Drawing.Size(41, 23);
            this.Label_Mail.TabIndex = 53;
            this.Label_Mail.Text = "Mail";
            // 
            // TextBox_Mail
            // 
            this.TextBox_Mail.BackColor = System.Drawing.Color.Linen;
            this.TextBox_Mail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox_Mail.Location = new System.Drawing.Point(678, 322);
            this.TextBox_Mail.Multiline = true;
            this.TextBox_Mail.Name = "TextBox_Mail";
            this.TextBox_Mail.Size = new System.Drawing.Size(250, 30);
            this.TextBox_Mail.TabIndex = 52;
            // 
            // Label_FullName
            // 
            this.Label_FullName.AutoSize = true;
            this.Label_FullName.BackColor = System.Drawing.Color.Transparent;
            this.Label_FullName.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FullName.ForeColor = System.Drawing.Color.Black;
            this.Label_FullName.Location = new System.Drawing.Point(578, 202);
            this.Label_FullName.Name = "Label_FullName";
            this.Label_FullName.Size = new System.Drawing.Size(86, 23);
            this.Label_FullName.TabIndex = 51;
            this.Label_FullName.Text = "Full Name";
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.BackColor = System.Drawing.Color.Transparent;
            this.Label_ID.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ID.ForeColor = System.Drawing.Color.Black;
            this.Label_ID.Location = new System.Drawing.Point(578, 162);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(31, 23);
            this.Label_ID.TabIndex = 49;
            this.Label_ID.Text = "ID";
            // 
            // Label_MyID
            // 
            this.Label_MyID.AutoSize = true;
            this.Label_MyID.BackColor = System.Drawing.Color.Transparent;
            this.Label_MyID.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MyID.ForeColor = System.Drawing.Color.Black;
            this.Label_MyID.Location = new System.Drawing.Point(678, 162);
            this.Label_MyID.Name = "Label_MyID";
            this.Label_MyID.Size = new System.Drawing.Size(61, 23);
            this.Label_MyID.TabIndex = 66;
            this.Label_MyID.Text = "My ID";
            // 
            // Button_Edit
            // 
            this.Button_Edit.BackColor = System.Drawing.Color.Tan;
            this.Button_Edit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Edit.Location = new System.Drawing.Point(582, 678);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(346, 35);
            this.Button_Edit.TabIndex = 67;
            this.Button_Edit.Text = "Edit My Information";
            this.Button_Edit.UseVisualStyleBackColor = false;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Label_MyName
            // 
            this.Label_MyName.AutoSize = true;
            this.Label_MyName.BackColor = System.Drawing.Color.Transparent;
            this.Label_MyName.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MyName.ForeColor = System.Drawing.Color.Black;
            this.Label_MyName.Location = new System.Drawing.Point(678, 202);
            this.Label_MyName.Name = "Label_MyName";
            this.Label_MyName.Size = new System.Drawing.Size(83, 23);
            this.Label_MyName.TabIndex = 68;
            this.Label_MyName.Text = "My Name";
            // 
            // Form_EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.Label_MyName);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Label_MyID);
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
            this.Controls.Add(this.Label_ID);
            this.Name = "Form_EditProfile";
            this.Text = "Form_EditProfile";
            this.Load += new System.EventHandler(this.Form_EditProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_UploadPic;
        private System.Windows.Forms.Label Label_Pic;
        private System.Windows.Forms.PictureBox PictureBox_Pic;
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
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Label Label_MyID;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Label Label_MyName;
    }
}