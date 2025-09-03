namespace Library_Management
{
    partial class formStatistic
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonYear = new System.Windows.Forms.Button();
            this.buttonAuthor = new System.Windows.Forms.Button();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.buttonRevenue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(1062, 719);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 30);
            this.buttonBack.TabIndex = 103;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonYear
            // 
            this.buttonYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYear.Location = new System.Drawing.Point(550, 227);
            this.buttonYear.Name = "buttonYear";
            this.buttonYear.Size = new System.Drawing.Size(120, 30);
            this.buttonYear.TabIndex = 107;
            this.buttonYear.Text = "Year";
            this.buttonYear.UseVisualStyleBackColor = true;
            this.buttonYear.Click += new System.EventHandler(this.buttonYear_Click);
            // 
            // buttonAuthor
            // 
            this.buttonAuthor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAuthor.Location = new System.Drawing.Point(424, 227);
            this.buttonAuthor.Name = "buttonAuthor";
            this.buttonAuthor.Size = new System.Drawing.Size(120, 30);
            this.buttonAuthor.TabIndex = 106;
            this.buttonAuthor.Text = "Author";
            this.buttonAuthor.UseVisualStyleBackColor = true;
            this.buttonAuthor.Click += new System.EventHandler(this.buttonAuthor_Click);
            // 
            // buttonCategory
            // 
            this.buttonCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategory.Location = new System.Drawing.Point(297, 227);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(120, 30);
            this.buttonCategory.TabIndex = 105;
            this.buttonCategory.Text = "Category";
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatus.Location = new System.Drawing.Point(676, 227);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(120, 30);
            this.buttonStatus.TabIndex = 108;
            this.buttonStatus.Text = "Status Book";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Location = new System.Drawing.Point(424, 280);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.Size = new System.Drawing.Size(372, 326);
            this.dgvStatistic.TabIndex = 109;
            // 
            // buttonRevenue
            // 
            this.buttonRevenue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevenue.Location = new System.Drawing.Point(804, 227);
            this.buttonRevenue.Name = "buttonRevenue";
            this.buttonRevenue.Size = new System.Drawing.Size(120, 30);
            this.buttonRevenue.TabIndex = 110;
            this.buttonRevenue.Text = "Revenue";
            this.buttonRevenue.UseVisualStyleBackColor = true;
            this.buttonRevenue.Click += new System.EventHandler(this.buttonRevenue_Click);
            // 
            // formStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.backgroundStatistic;
            this.ClientSize = new System.Drawing.Size(1194, 761);
            this.Controls.Add(this.buttonRevenue);
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.buttonYear);
            this.Controls.Add(this.buttonAuthor);
            this.Controls.Add(this.buttonCategory);
            this.Controls.Add(this.buttonBack);
            this.Name = "formStatistic";
            this.Text = "formStatistic";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonYear;
        private System.Windows.Forms.Button buttonAuthor;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.Button buttonRevenue;
    }
}