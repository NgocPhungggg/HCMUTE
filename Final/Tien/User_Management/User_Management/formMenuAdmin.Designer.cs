namespace User_Management
{
    partial class formMenuAdmin
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
            this.button_Info = new System.Windows.Forms.Button();
            this.button_Privileges = new System.Windows.Forms.Button();
            this.button_Role = new System.Windows.Forms.Button();
            this.button_UserManagement = new System.Windows.Forms.Button();
            this.button_Profile = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_Audit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Info
            // 
            this.button_Info.Location = new System.Drawing.Point(347, 302);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(200, 40);
            this.button_Info.TabIndex = 1;
            this.button_Info.Text = "Information Users";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // button_Privileges
            // 
            this.button_Privileges.Location = new System.Drawing.Point(674, 539);
            this.button_Privileges.Name = "button_Privileges";
            this.button_Privileges.Size = new System.Drawing.Size(200, 40);
            this.button_Privileges.TabIndex = 2;
            this.button_Privileges.Text = "Privileges";
            this.button_Privileges.UseVisualStyleBackColor = true;
            this.button_Privileges.Click += new System.EventHandler(this.button_Privileges_Click);
            // 
            // button_Role
            // 
            this.button_Role.Location = new System.Drawing.Point(994, 539);
            this.button_Role.Name = "button_Role";
            this.button_Role.Size = new System.Drawing.Size(200, 40);
            this.button_Role.TabIndex = 3;
            this.button_Role.Text = "Role Privileges";
            this.button_Role.UseVisualStyleBackColor = true;
            this.button_Role.Click += new System.EventHandler(this.button_Role_Click);
            // 
            // button_UserManagement
            // 
            this.button_UserManagement.Location = new System.Drawing.Point(674, 302);
            this.button_UserManagement.Name = "button_UserManagement";
            this.button_UserManagement.Size = new System.Drawing.Size(200, 40);
            this.button_UserManagement.TabIndex = 4;
            this.button_UserManagement.Text = "Users Management";
            this.button_UserManagement.UseVisualStyleBackColor = true;
            this.button_UserManagement.Click += new System.EventHandler(this.button_UserManagement_Click);
            // 
            // button_Profile
            // 
            this.button_Profile.Location = new System.Drawing.Point(994, 302);
            this.button_Profile.Name = "button_Profile";
            this.button_Profile.Size = new System.Drawing.Size(200, 40);
            this.button_Profile.TabIndex = 5;
            this.button_Profile.Text = "Profile";
            this.button_Profile.UseVisualStyleBackColor = true;
            this.button_Profile.Click += new System.EventHandler(this.button_Profile_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.BackgroundImage = global::User_Management.Properties.Resources.button_Logout;
            this.button_Logout.Location = new System.Drawing.Point(1331, 678);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(120, 50);
            this.button_Logout.TabIndex = 6;
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_Audit
            // 
            this.button_Audit.Location = new System.Drawing.Point(347, 539);
            this.button_Audit.Name = "button_Audit";
            this.button_Audit.Size = new System.Drawing.Size(200, 40);
            this.button_Audit.TabIndex = 7;
            this.button_Audit.Text = "Audit";
            this.button_Audit.UseVisualStyleBackColor = true;
            this.button_Audit.Click += new System.EventHandler(this.button_Audit_Click);
            // 
            // formMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::User_Management.Properties.Resources.backgroundMenuAmin;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.button_Audit);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.button_Profile);
            this.Controls.Add(this.button_UserManagement);
            this.Controls.Add(this.button_Role);
            this.Controls.Add(this.button_Privileges);
            this.Controls.Add(this.button_Info);
            this.Name = "formMenuAdmin";
            this.Text = "formMenuAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Info;
        private System.Windows.Forms.Button button_Privileges;
        private System.Windows.Forms.Button button_Role;
        private System.Windows.Forms.Button button_UserManagement;
        private System.Windows.Forms.Button button_Profile;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_Audit;
    }
}