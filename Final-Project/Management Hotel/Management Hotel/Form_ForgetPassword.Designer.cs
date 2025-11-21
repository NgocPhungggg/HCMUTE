namespace Management_Hotel
{
    partial class Form_ForgetPassword
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
            this.Button_Confirm = new System.Windows.Forms.Button();
            this.TextBox_OTP = new System.Windows.Forms.TextBox();
            this.Label_UserID = new System.Windows.Forms.Label();
            this.Button_FindEmail = new System.Windows.Forms.Button();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.BackColor = System.Drawing.Color.Linen;
            this.Button_Confirm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Confirm.Location = new System.Drawing.Point(814, 570);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(149, 30);
            this.Button_Confirm.TabIndex = 27;
            this.Button_Confirm.Text = "Confirm OTP";
            this.Button_Confirm.UseVisualStyleBackColor = false;
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // TextBox_OTP
            // 
            this.TextBox_OTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBox_OTP.Location = new System.Drawing.Point(536, 570);
            this.TextBox_OTP.Multiline = true;
            this.TextBox_OTP.Name = "TextBox_OTP";
            this.TextBox_OTP.Size = new System.Drawing.Size(272, 30);
            this.TextBox_OTP.TabIndex = 26;
            // 
            // Label_UserID
            // 
            this.Label_UserID.AutoSize = true;
            this.Label_UserID.BackColor = System.Drawing.Color.Linen;
            this.Label_UserID.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UserID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_UserID.Location = new System.Drawing.Point(545, 478);
            this.Label_UserID.Name = "Label_UserID";
            this.Label_UserID.Size = new System.Drawing.Size(229, 29);
            this.Label_UserID.TabIndex = 25;
            this.Label_UserID.Text = "Label_YourUserName";
            // 
            // Button_FindEmail
            // 
            this.Button_FindEmail.BackColor = System.Drawing.Color.Linen;
            this.Button_FindEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FindEmail.Location = new System.Drawing.Point(672, 434);
            this.Button_FindEmail.Name = "Button_FindEmail";
            this.Button_FindEmail.Size = new System.Drawing.Size(149, 30);
            this.Button_FindEmail.TabIndex = 24;
            this.Button_FindEmail.Text = "Find Email";
            this.Button_FindEmail.UseVisualStyleBackColor = false;
            this.Button_FindEmail.Click += new System.EventHandler(this.Button_FindEmail_Click);
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBox_Email.Location = new System.Drawing.Point(536, 398);
            this.TextBox_Email.Multiline = true;
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(427, 30);
            this.TextBox_Email.TabIndex = 23;
            // 
            // Button_Send
            // 
            this.Button_Send.BackColor = System.Drawing.Color.Linen;
            this.Button_Send.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Send.Location = new System.Drawing.Point(672, 529);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(149, 30);
            this.Button_Send.TabIndex = 22;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = false;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Form_ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.LoginBackground;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.TextBox_OTP);
            this.Controls.Add(this.Label_UserID);
            this.Controls.Add(this.Button_FindEmail);
            this.Controls.Add(this.TextBox_Email);
            this.Controls.Add(this.Button_Send);
            this.Name = "Form_ForgetPassword";
            this.Text = "Form_ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Confirm;
        private System.Windows.Forms.TextBox TextBox_OTP;
        private System.Windows.Forms.Label Label_UserID;
        private System.Windows.Forms.Button Button_FindEmail;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.Button Button_Send;
    }
}