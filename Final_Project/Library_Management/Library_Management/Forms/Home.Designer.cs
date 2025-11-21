namespace Library_Management.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.button_docgia = new System.Windows.Forms.Button();
            this.button_sach = new System.Windows.Forms.Button();
            this.button_thongke = new System.Windows.Forms.Button();
            this.button_nhanvien = new System.Windows.Forms.Button();
            this.button_doimk = new System.Windows.Forms.Button();
            this.button_muon = new System.Windows.Forms.Button();
            this.button_signout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_docgia
            // 
            this.button_docgia.BackgroundImage = global::Library_Management.Properties.Resources.Button_Docgia;
            this.button_docgia.Location = new System.Drawing.Point(138, 160);
            this.button_docgia.Name = "button_docgia";
            this.button_docgia.Size = new System.Drawing.Size(298, 110);
            this.button_docgia.TabIndex = 0;
            this.button_docgia.UseVisualStyleBackColor = true;
            this.button_docgia.Click += new System.EventHandler(this.button_docgia_Click);
            // 
            // button_sach
            // 
            this.button_sach.BackgroundImage = global::Library_Management.Properties.Resources.Button_Sach;
            this.button_sach.Location = new System.Drawing.Point(138, 279);
            this.button_sach.Name = "button_sach";
            this.button_sach.Size = new System.Drawing.Size(298, 110);
            this.button_sach.TabIndex = 1;
            this.button_sach.UseVisualStyleBackColor = true;
            this.button_sach.Click += new System.EventHandler(this.button_sach_Click);
            // 
            // button_thongke
            // 
            this.button_thongke.BackgroundImage = global::Library_Management.Properties.Resources.Button_Thongke;
            this.button_thongke.Location = new System.Drawing.Point(566, 160);
            this.button_thongke.Name = "button_thongke";
            this.button_thongke.Size = new System.Drawing.Size(298, 110);
            this.button_thongke.TabIndex = 2;
            this.button_thongke.UseVisualStyleBackColor = true;
            this.button_thongke.Click += new System.EventHandler(this.button_thongke_Click);
            // 
            // button_nhanvien
            // 
            this.button_nhanvien.BackgroundImage = global::Library_Management.Properties.Resources.Button_NhanVien;
            this.button_nhanvien.Location = new System.Drawing.Point(566, 279);
            this.button_nhanvien.Name = "button_nhanvien";
            this.button_nhanvien.Size = new System.Drawing.Size(298, 110);
            this.button_nhanvien.TabIndex = 3;
            this.button_nhanvien.UseVisualStyleBackColor = true;
            this.button_nhanvien.Click += new System.EventHandler(this.button_nhanvien_Click);
            // 
            // button_doimk
            // 
            this.button_doimk.BackgroundImage = global::Library_Management.Properties.Resources.Button_DoiMK;
            this.button_doimk.Location = new System.Drawing.Point(566, 397);
            this.button_doimk.Name = "button_doimk";
            this.button_doimk.Size = new System.Drawing.Size(298, 110);
            this.button_doimk.TabIndex = 4;
            this.button_doimk.UseVisualStyleBackColor = true;
            this.button_doimk.Click += new System.EventHandler(this.button_doimk_Click);
            // 
            // button_muon
            // 
            this.button_muon.BackgroundImage = global::Library_Management.Properties.Resources.Button_Muon;
            this.button_muon.Location = new System.Drawing.Point(138, 397);
            this.button_muon.Name = "button_muon";
            this.button_muon.Size = new System.Drawing.Size(298, 110);
            this.button_muon.TabIndex = 5;
            this.button_muon.UseVisualStyleBackColor = true;
            this.button_muon.Click += new System.EventHandler(this.button_muon_Click);
            // 
            // button_signout
            // 
            this.button_signout.BackColor = System.Drawing.Color.Transparent;
            this.button_signout.BackgroundImage = global::Library_Management.Properties.Resources.Button_Dangxuat;
            this.button_signout.Location = new System.Drawing.Point(853, 535);
            this.button_signout.Name = "button_signout";
            this.button_signout.Size = new System.Drawing.Size(119, 114);
            this.button_signout.TabIndex = 6;
            this.button_signout.UseVisualStyleBackColor = false;
            this.button_signout.Click += new System.EventHandler(this.button_signout_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button_signout);
            this.Controls.Add(this.button_muon);
            this.Controls.Add(this.button_doimk);
            this.Controls.Add(this.button_nhanvien);
            this.Controls.Add(this.button_thongke);
            this.Controls.Add(this.button_sach);
            this.Controls.Add(this.button_docgia);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_docgia;
        private System.Windows.Forms.Button button_sach;
        private System.Windows.Forms.Button button_thongke;
        private System.Windows.Forms.Button button_nhanvien;
        private System.Windows.Forms.Button button_doimk;
        private System.Windows.Forms.Button button_muon;
        private System.Windows.Forms.Button button_signout;
    }
}