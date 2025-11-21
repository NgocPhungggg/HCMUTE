namespace Library_Management.Forms
{
    partial class ChangePassword
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
            this.Button_Change = new System.Windows.Forms.Button();
            this.Label_NewPassword2 = new System.Windows.Forms.Label();
            this.TextBox_NewPassword2 = new System.Windows.Forms.TextBox();
            this.Label_NewPassword = new System.Windows.Forms.Label();
            this.TextBox_NewPassword = new System.Windows.Forms.TextBox();
            this.Label_OldPassword = new System.Windows.Forms.Label();
            this.TextBox_OldPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Change
            // 
            this.Button_Change.BackColor = System.Drawing.Color.Tan;
            this.Button_Change.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Change.Location = new System.Drawing.Point(335, 447);
            this.Button_Change.Name = "Button_Change";
            this.Button_Change.Size = new System.Drawing.Size(346, 40);
            this.Button_Change.TabIndex = 70;
            this.Button_Change.Text = "Đổi mật khẩu";
            this.Button_Change.UseVisualStyleBackColor = false;
            this.Button_Change.Click += new System.EventHandler(this.Button_Change_Click);
            // 
            // Label_NewPassword2
            // 
            this.Label_NewPassword2.AutoSize = true;
            this.Label_NewPassword2.BackColor = System.Drawing.Color.Transparent;
            this.Label_NewPassword2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NewPassword2.ForeColor = System.Drawing.Color.Black;
            this.Label_NewPassword2.Location = new System.Drawing.Point(288, 404);
            this.Label_NewPassword2.Name = "Label_NewPassword2";
            this.Label_NewPassword2.Size = new System.Drawing.Size(189, 23);
            this.Label_NewPassword2.TabIndex = 69;
            this.Label_NewPassword2.Text = "Nhập lại mật khẩu mới";
            // 
            // TextBox_NewPassword2
            // 
            this.TextBox_NewPassword2.BackColor = System.Drawing.Color.Linen;
            this.TextBox_NewPassword2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox_NewPassword2.Location = new System.Drawing.Point(483, 397);
            this.TextBox_NewPassword2.Multiline = true;
            this.TextBox_NewPassword2.Name = "TextBox_NewPassword2";
            this.TextBox_NewPassword2.PasswordChar = '*';
            this.TextBox_NewPassword2.Size = new System.Drawing.Size(223, 30);
            this.TextBox_NewPassword2.TabIndex = 68;
            // 
            // Label_NewPassword
            // 
            this.Label_NewPassword.AutoSize = true;
            this.Label_NewPassword.BackColor = System.Drawing.Color.Transparent;
            this.Label_NewPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NewPassword.ForeColor = System.Drawing.Color.Black;
            this.Label_NewPassword.Location = new System.Drawing.Point(356, 357);
            this.Label_NewPassword.Name = "Label_NewPassword";
            this.Label_NewPassword.Size = new System.Drawing.Size(118, 23);
            this.Label_NewPassword.TabIndex = 67;
            this.Label_NewPassword.Text = "Mật khẩu mới";
            // 
            // TextBox_NewPassword
            // 
            this.TextBox_NewPassword.BackColor = System.Drawing.Color.Linen;
            this.TextBox_NewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox_NewPassword.Location = new System.Drawing.Point(483, 357);
            this.TextBox_NewPassword.Multiline = true;
            this.TextBox_NewPassword.Name = "TextBox_NewPassword";
            this.TextBox_NewPassword.PasswordChar = '*';
            this.TextBox_NewPassword.Size = new System.Drawing.Size(223, 30);
            this.TextBox_NewPassword.TabIndex = 66;
            // 
            // Label_OldPassword
            // 
            this.Label_OldPassword.AutoSize = true;
            this.Label_OldPassword.BackColor = System.Drawing.Color.Transparent;
            this.Label_OldPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OldPassword.ForeColor = System.Drawing.Color.Black;
            this.Label_OldPassword.Location = new System.Drawing.Point(356, 317);
            this.Label_OldPassword.Name = "Label_OldPassword";
            this.Label_OldPassword.Size = new System.Drawing.Size(108, 23);
            this.Label_OldPassword.TabIndex = 65;
            this.Label_OldPassword.Text = "Mật khẩu cũ";
            // 
            // TextBox_OldPassword
            // 
            this.TextBox_OldPassword.BackColor = System.Drawing.Color.Linen;
            this.TextBox_OldPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox_OldPassword.Location = new System.Drawing.Point(483, 317);
            this.TextBox_OldPassword.Multiline = true;
            this.TextBox_OldPassword.Name = "TextBox_OldPassword";
            this.TextBox_OldPassword.PasswordChar = '*';
            this.TextBox_OldPassword.Size = new System.Drawing.Size(223, 30);
            this.TextBox_OldPassword.TabIndex = 64;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.BG_ChangePW;
            this.ClientSize = new System.Drawing.Size(999, 661);
            this.Controls.Add(this.Button_Change);
            this.Controls.Add(this.Label_NewPassword2);
            this.Controls.Add(this.TextBox_NewPassword2);
            this.Controls.Add(this.Label_NewPassword);
            this.Controls.Add(this.TextBox_NewPassword);
            this.Controls.Add(this.Label_OldPassword);
            this.Controls.Add(this.TextBox_OldPassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Change;
        private System.Windows.Forms.Label Label_NewPassword2;
        private System.Windows.Forms.TextBox TextBox_NewPassword2;
        private System.Windows.Forms.Label Label_NewPassword;
        private System.Windows.Forms.TextBox TextBox_NewPassword;
        private System.Windows.Forms.Label Label_OldPassword;
        private System.Windows.Forms.TextBox TextBox_OldPassword;
    }
}