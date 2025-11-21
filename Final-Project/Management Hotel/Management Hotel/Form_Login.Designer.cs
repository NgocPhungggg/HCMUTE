namespace Management_Hotel
{
    partial class Form_Login
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
            this.Button_Login = new System.Windows.Forms.Button();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.RadioButton_Manager = new System.Windows.Forms.RadioButton();
            this.RadioButton_Receptionist = new System.Windows.Forms.RadioButton();
            this.RadioButton_Janitor = new System.Windows.Forms.RadioButton();
            this.Label_ForgetPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.Wheat;
            this.Button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_Login.Location = new System.Drawing.Point(598, 538);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(300, 40);
            this.Button_Login.TabIndex = 0;
            this.Button_Login.Text = "Sign In";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.PapayaWhip;
            this.TextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBox_Password.Location = new System.Drawing.Point(598, 464);
            this.TextBox_Password.Multiline = true;
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '.';
            this.TextBox_Password.Size = new System.Drawing.Size(300, 40);
            this.TextBox_Password.TabIndex = 1;
            this.TextBox_Password.Text = "Password";
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.Color.PapayaWhip;
            this.TextBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBox_Username.Location = new System.Drawing.Point(598, 418);
            this.TextBox_Username.Multiline = true;
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(300, 40);
            this.TextBox_Username.TabIndex = 2;
            this.TextBox_Username.Text = "Username";
            this.TextBox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Username_KeyPress);
            // 
            // RadioButton_Manager
            // 
            this.RadioButton_Manager.AutoSize = true;
            this.RadioButton_Manager.BackColor = System.Drawing.Color.Transparent;
            this.RadioButton_Manager.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_Manager.Location = new System.Drawing.Point(579, 382);
            this.RadioButton_Manager.Name = "RadioButton_Manager";
            this.RadioButton_Manager.Size = new System.Drawing.Size(106, 30);
            this.RadioButton_Manager.TabIndex = 3;
            this.RadioButton_Manager.TabStop = true;
            this.RadioButton_Manager.Text = "Manager";
            this.RadioButton_Manager.UseVisualStyleBackColor = false;
            // 
            // RadioButton_Receptionist
            // 
            this.RadioButton_Receptionist.AutoSize = true;
            this.RadioButton_Receptionist.BackColor = System.Drawing.Color.Transparent;
            this.RadioButton_Receptionist.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_Receptionist.Location = new System.Drawing.Point(686, 382);
            this.RadioButton_Receptionist.Name = "RadioButton_Receptionist";
            this.RadioButton_Receptionist.Size = new System.Drawing.Size(135, 30);
            this.RadioButton_Receptionist.TabIndex = 4;
            this.RadioButton_Receptionist.TabStop = true;
            this.RadioButton_Receptionist.Text = "Receptionist";
            this.RadioButton_Receptionist.UseVisualStyleBackColor = false;
            // 
            // RadioButton_Janitor
            // 
            this.RadioButton_Janitor.AutoSize = true;
            this.RadioButton_Janitor.BackColor = System.Drawing.Color.Transparent;
            this.RadioButton_Janitor.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_Janitor.Location = new System.Drawing.Point(823, 382);
            this.RadioButton_Janitor.Name = "RadioButton_Janitor";
            this.RadioButton_Janitor.Size = new System.Drawing.Size(94, 30);
            this.RadioButton_Janitor.TabIndex = 5;
            this.RadioButton_Janitor.TabStop = true;
            this.RadioButton_Janitor.Text = "Janitor";
            this.RadioButton_Janitor.UseVisualStyleBackColor = false;
            // 
            // Label_ForgetPassword
            // 
            this.Label_ForgetPassword.AutoSize = true;
            this.Label_ForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.Label_ForgetPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ForgetPassword.Location = new System.Drawing.Point(682, 507);
            this.Label_ForgetPassword.Name = "Label_ForgetPassword";
            this.Label_ForgetPassword.Size = new System.Drawing.Size(155, 23);
            this.Label_ForgetPassword.TabIndex = 6;
            this.Label_ForgetPassword.Text = "Forget Password ?";
            this.Label_ForgetPassword.Click += new System.EventHandler(this.Label_ForgetPassword_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.LoginBackground;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.Label_ForgetPassword);
            this.Controls.Add(this.RadioButton_Janitor);
            this.Controls.Add(this.RadioButton_Receptionist);
            this.Controls.Add(this.RadioButton_Manager);
            this.Controls.Add(this.TextBox_Username);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.Button_Login);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.RadioButton RadioButton_Manager;
        private System.Windows.Forms.RadioButton RadioButton_Receptionist;
        private System.Windows.Forms.RadioButton RadioButton_Janitor;
        private System.Windows.Forms.Label Label_ForgetPassword;
    }
}