namespace Library_Management.Forms
{
    partial class Login
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
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.Color.PapayaWhip;
            this.TextBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBox_Username.Location = new System.Drawing.Point(349, 308);
            this.TextBox_Username.Multiline = true;
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(300, 40);
            this.TextBox_Username.TabIndex = 3;
            this.TextBox_Username.Text = "Username";
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.PapayaWhip;
            this.TextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBox_Password.Location = new System.Drawing.Point(349, 354);
            this.TextBox_Password.Multiline = true;
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '.';
            this.TextBox_Password.Size = new System.Drawing.Size(300, 40);
            this.TextBox_Password.TabIndex = 4;
            this.TextBox_Password.Text = "Password";
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.Wheat;
            this.Button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_Login.Location = new System.Drawing.Point(349, 400);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(300, 40);
            this.Button_Login.TabIndex = 5;
            this.Button_Login.Text = "Sign In";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.BG_Login;
            this.ClientSize = new System.Drawing.Size(984, 626);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_Username);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Button Button_Login;
    }
}