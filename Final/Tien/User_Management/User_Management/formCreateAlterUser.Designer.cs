namespace User_Management
{
    partial class formCreateAlterUser
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
            this.ckbxAccountStatus = new System.Windows.Forms.CheckBox();
            this.numericUpDownQuota = new System.Windows.Forms.NumericUpDown();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.cbxProfile = new System.Windows.Forms.ComboBox();
            this.cbxTemporaryTablespace = new System.Windows.Forms.ComboBox();
            this.cbxDefautTablespace = new System.Windows.Forms.ComboBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDefaultTablespace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblQuota = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuota)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbxAccountStatus
            // 
            this.ckbxAccountStatus.AutoSize = true;
            this.ckbxAccountStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxAccountStatus.Location = new System.Drawing.Point(763, 398);
            this.ckbxAccountStatus.Margin = new System.Windows.Forms.Padding(2);
            this.ckbxAccountStatus.Name = "ckbxAccountStatus";
            this.ckbxAccountStatus.Size = new System.Drawing.Size(15, 14);
            this.ckbxAccountStatus.TabIndex = 23;
            this.ckbxAccountStatus.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuota
            // 
            this.numericUpDownQuota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuota.Location = new System.Drawing.Point(516, 387);
            this.numericUpDownQuota.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownQuota.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.numericUpDownQuota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownQuota.Name = "numericUpDownQuota";
            this.numericUpDownQuota.Size = new System.Drawing.Size(128, 29);
            this.numericUpDownQuota.TabIndex = 22;
            this.numericUpDownQuota.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // cbxRole
            // 
            this.cbxRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(821, 449);
            this.cbxRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(248, 29);
            this.cbxRole.TabIndex = 21;
            // 
            // cbxProfile
            // 
            this.cbxProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Location = new System.Drawing.Point(479, 449);
            this.cbxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(248, 29);
            this.cbxProfile.TabIndex = 20;
            // 
            // cbxTemporaryTablespace
            // 
            this.cbxTemporaryTablespace.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTemporaryTablespace.FormattingEnabled = true;
            this.cbxTemporaryTablespace.Location = new System.Drawing.Point(596, 336);
            this.cbxTemporaryTablespace.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTemporaryTablespace.Name = "cbxTemporaryTablespace";
            this.cbxTemporaryTablespace.Size = new System.Drawing.Size(474, 29);
            this.cbxTemporaryTablespace.TabIndex = 19;
            // 
            // cbxDefautTablespace
            // 
            this.cbxDefautTablespace.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDefautTablespace.FormattingEnabled = true;
            this.cbxDefautTablespace.Location = new System.Drawing.Point(565, 293);
            this.cbxDefautTablespace.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDefautTablespace.Name = "cbxDefautTablespace";
            this.cbxDefautTablespace.Size = new System.Drawing.Size(504, 29);
            this.cbxDefautTablespace.TabIndex = 18;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(856, 253);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(214, 30);
            this.tbxPassword.TabIndex = 16;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(501, 253);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUsername.Multiline = true;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(214, 30);
            this.tbxUsername.TabIndex = 17;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(766, 260);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 21);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(409, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Temporary Tablespace:";
            // 
            // lblDefaultTablespace
            // 
            this.lblDefaultTablespace.AutoSize = true;
            this.lblDefaultTablespace.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultTablespace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultTablespace.ForeColor = System.Drawing.Color.Transparent;
            this.lblDefaultTablespace.Location = new System.Drawing.Point(409, 299);
            this.lblDefaultTablespace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDefaultTablespace.Name = "lblDefaultTablespace";
            this.lblDefaultTablespace.Size = new System.Drawing.Size(154, 21);
            this.lblDefaultTablespace.TabIndex = 13;
            this.lblDefaultTablespace.Text = "Defaut Tablespace:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(699, 392);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "LOCK:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.Transparent;
            this.lblRole.Location = new System.Drawing.Point(766, 455);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 21);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "Role:";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.Transparent;
            this.lblProfile.Location = new System.Drawing.Point(409, 455);
            this.lblProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(65, 21);
            this.lblProfile.TabIndex = 10;
            this.lblProfile.Text = "Profile:";
            // 
            // lblQuota
            // 
            this.lblQuota.AutoSize = true;
            this.lblQuota.BackColor = System.Drawing.Color.Transparent;
            this.lblQuota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuota.ForeColor = System.Drawing.Color.Transparent;
            this.lblQuota.Location = new System.Drawing.Point(409, 392);
            this.lblQuota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuota.Name = "lblQuota";
            this.lblQuota.Size = new System.Drawing.Size(102, 21);
            this.lblQuota.TabIndex = 9;
            this.lblQuota.Text = "Quota (MB):";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Transparent;
            this.lblUsername.Location = new System.Drawing.Point(409, 260);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 21);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Location = new System.Drawing.Point(823, 556);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(182, 41);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(479, 556);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 41);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formCreateAlterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::User_Management.Properties.Resources.backgroundNormal;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.ckbxAccountStatus);
            this.Controls.Add(this.numericUpDownQuota);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.cbxProfile);
            this.Controls.Add(this.cbxTemporaryTablespace);
            this.Controls.Add(this.cbxDefautTablespace);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDefaultTablespace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblQuota);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Name = "formCreateAlterUser";
            this.Text = "formCreateAlterUser";
            this.Load += new System.EventHandler(this.formCreateAlterUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbxAccountStatus;
        private System.Windows.Forms.NumericUpDown numericUpDownQuota;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.ComboBox cbxProfile;
        private System.Windows.Forms.ComboBox cbxTemporaryTablespace;
        private System.Windows.Forms.ComboBox cbxDefautTablespace;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDefaultTablespace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblQuota;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSave;
    }
}