namespace Management_Hotel
{
    partial class Form_Events
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
            this.TextBox_Body = new System.Windows.Forms.TextBox();
            this.Label_Anoucement = new System.Windows.Forms.Label();
            this.Button_Send = new System.Windows.Forms.Button();
            this.TextBox_Tittle = new System.Windows.Forms.TextBox();
            this.Label_Tittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_Body
            // 
            this.TextBox_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBox_Body.Location = new System.Drawing.Point(474, 272);
            this.TextBox_Body.Multiline = true;
            this.TextBox_Body.Name = "TextBox_Body";
            this.TextBox_Body.Size = new System.Drawing.Size(550, 339);
            this.TextBox_Body.TabIndex = 0;
            // 
            // Label_Anoucement
            // 
            this.Label_Anoucement.AutoSize = true;
            this.Label_Anoucement.BackColor = System.Drawing.Color.Transparent;
            this.Label_Anoucement.Font = new System.Drawing.Font("Consolas", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Anoucement.ForeColor = System.Drawing.Color.Black;
            this.Label_Anoucement.Location = new System.Drawing.Point(676, 235);
            this.Label_Anoucement.Name = "Label_Anoucement";
            this.Label_Anoucement.Size = new System.Drawing.Size(143, 34);
            this.Label_Anoucement.TabIndex = 1;
            this.Label_Anoucement.Text = "Nội dung";
            // 
            // Button_Send
            // 
            this.Button_Send.BackColor = System.Drawing.Color.Linen;
            this.Button_Send.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Send.ForeColor = System.Drawing.Color.Black;
            this.Button_Send.Location = new System.Drawing.Point(596, 656);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(300, 40);
            this.Button_Send.TabIndex = 7;
            this.Button_Send.Text = "Gửi ";
            this.Button_Send.UseVisualStyleBackColor = false;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // TextBox_Tittle
            // 
            this.TextBox_Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBox_Tittle.Location = new System.Drawing.Point(474, 202);
            this.TextBox_Tittle.Multiline = true;
            this.TextBox_Tittle.Name = "TextBox_Tittle";
            this.TextBox_Tittle.Size = new System.Drawing.Size(550, 30);
            this.TextBox_Tittle.TabIndex = 8;
            // 
            // Label_Tittle
            // 
            this.Label_Tittle.AutoSize = true;
            this.Label_Tittle.BackColor = System.Drawing.Color.Transparent;
            this.Label_Tittle.Font = new System.Drawing.Font("Consolas", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Tittle.ForeColor = System.Drawing.Color.Black;
            this.Label_Tittle.Location = new System.Drawing.Point(676, 165);
            this.Label_Tittle.Name = "Label_Tittle";
            this.Label_Tittle.Size = new System.Drawing.Size(127, 34);
            this.Label_Tittle.TabIndex = 9;
            this.Label_Tittle.Text = "Tiêu đề";
            // 
            // Form_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Management_Hotel.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.Label_Tittle);
            this.Controls.Add(this.TextBox_Tittle);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.Label_Anoucement);
            this.Controls.Add(this.TextBox_Body);
            this.Name = "Form_Events";
            this.Text = "Form_Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Body;
        private System.Windows.Forms.Label Label_Anoucement;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.TextBox TextBox_Tittle;
        private System.Windows.Forms.Label Label_Tittle;
    }
}