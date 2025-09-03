namespace Library_Management
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
            this.buttonManageReader = new System.Windows.Forms.Button();
            this.buttonManageStaff = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageReader
            // 
            this.buttonManageReader.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonManageReader.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageReader.ForeColor = System.Drawing.Color.White;
            this.buttonManageReader.Location = new System.Drawing.Point(496, 441);
            this.buttonManageReader.Name = "buttonManageReader";
            this.buttonManageReader.Size = new System.Drawing.Size(200, 50);
            this.buttonManageReader.TabIndex = 15;
            this.buttonManageReader.Text = "Manage Reader";
            this.buttonManageReader.UseVisualStyleBackColor = false;
            this.buttonManageReader.Click += new System.EventHandler(this.buttonManageReader_Click);
            // 
            // buttonManageStaff
            // 
            this.buttonManageStaff.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonManageStaff.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageStaff.ForeColor = System.Drawing.Color.White;
            this.buttonManageStaff.Location = new System.Drawing.Point(496, 331);
            this.buttonManageStaff.Name = "buttonManageStaff";
            this.buttonManageStaff.Size = new System.Drawing.Size(200, 50);
            this.buttonManageStaff.TabIndex = 11;
            this.buttonManageStaff.Text = "Manage Staff";
            this.buttonManageStaff.UseVisualStyleBackColor = false;
            this.buttonManageStaff.Click += new System.EventHandler(this.buttonManageStaff_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonLogOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(1022, 719);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(150, 30);
            this.buttonLogOut.TabIndex = 17;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // formMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.backgroundMenuAdmin;
            this.ClientSize = new System.Drawing.Size(1180, 757);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonManageReader);
            this.Controls.Add(this.buttonManageStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "formMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMenuAdmin";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonManageReader;
        private System.Windows.Forms.Button buttonManageStaff;
        private System.Windows.Forms.Button buttonLogOut;
    }
}