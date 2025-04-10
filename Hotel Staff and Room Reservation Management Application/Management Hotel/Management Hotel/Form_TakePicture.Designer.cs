namespace Management_Hotel
{
    partial class Form_TakePicture
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
            this.PictureBox_Pic = new System.Windows.Forms.PictureBox();
            this.ComboBox_Device = new System.Windows.Forms.ComboBox();
            this.Button_OpenCamera = new System.Windows.Forms.Button();
            this.Button_TakePic = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_Pic
            // 
            this.PictureBox_Pic.Location = new System.Drawing.Point(439, 199);
            this.PictureBox_Pic.Name = "PictureBox_Pic";
            this.PictureBox_Pic.Size = new System.Drawing.Size(602, 332);
            this.PictureBox_Pic.TabIndex = 0;
            this.PictureBox_Pic.TabStop = false;
            // 
            // ComboBox_Device
            // 
            this.ComboBox_Device.FormattingEnabled = true;
            this.ComboBox_Device.Location = new System.Drawing.Point(439, 552);
            this.ComboBox_Device.Name = "ComboBox_Device";
            this.ComboBox_Device.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Device.TabIndex = 1;
            // 
            // Button_OpenCamera
            // 
            this.Button_OpenCamera.Location = new System.Drawing.Point(439, 596);
            this.Button_OpenCamera.Name = "Button_OpenCamera";
            this.Button_OpenCamera.Size = new System.Drawing.Size(140, 23);
            this.Button_OpenCamera.TabIndex = 2;
            this.Button_OpenCamera.Text = "Bắt đầu";
            this.Button_OpenCamera.UseVisualStyleBackColor = true;
            this.Button_OpenCamera.Click += new System.EventHandler(this.Button_OpenCamera_Click);
            // 
            // Button_TakePic
            // 
            this.Button_TakePic.Location = new System.Drawing.Point(901, 596);
            this.Button_TakePic.Name = "Button_TakePic";
            this.Button_TakePic.Size = new System.Drawing.Size(140, 23);
            this.Button_TakePic.TabIndex = 3;
            this.Button_TakePic.Text = "Lưu";
            this.Button_TakePic.UseVisualStyleBackColor = true;
            this.Button_TakePic.Click += new System.EventHandler(this.Button_TakePic_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Location = new System.Drawing.Point(667, 596);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(140, 23);
            this.Button_Close.TabIndex = 4;
            this.Button_Close.Text = "Chụp";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "image name |*.jpg";
            // 
            // Form_TakePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_TakePic);
            this.Controls.Add(this.Button_OpenCamera);
            this.Controls.Add(this.ComboBox_Device);
            this.Controls.Add(this.PictureBox_Pic);
            this.Name = "Form_TakePicture";
            this.Text = "Form_TakePicture";
            this.Load += new System.EventHandler(this.Form_TakePicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Pic;
        private System.Windows.Forms.ComboBox ComboBox_Device;
        private System.Windows.Forms.Button Button_OpenCamera;
        private System.Windows.Forms.Button Button_TakePic;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}