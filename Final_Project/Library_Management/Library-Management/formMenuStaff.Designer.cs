namespace Library_Management
{
    partial class formMenuStaff
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
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.buttonManageAuthor = new System.Windows.Forms.Button();
            this.buttonManageBook = new System.Windows.Forms.Button();
            this.buttonInfomation = new System.Windows.Forms.Button();
            this.buttonManageCategory = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonLoan = new System.Windows.Forms.Button();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageReader
            // 
            this.buttonManageReader.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonManageReader.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageReader.ForeColor = System.Drawing.Color.White;
            this.buttonManageReader.Location = new System.Drawing.Point(620, 288);
            this.buttonManageReader.Name = "buttonManageReader";
            this.buttonManageReader.Size = new System.Drawing.Size(200, 50);
            this.buttonManageReader.TabIndex = 9;
            this.buttonManageReader.Text = "Manage Reader";
            this.buttonManageReader.UseVisualStyleBackColor = false;
            this.buttonManageReader.Click += new System.EventHandler(this.buttonManageReader_Click);
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonTransaction.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransaction.ForeColor = System.Drawing.Color.White;
            this.buttonTransaction.Location = new System.Drawing.Point(509, 484);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Size = new System.Drawing.Size(200, 50);
            this.buttonTransaction.TabIndex = 8;
            this.buttonTransaction.Text = "Transaction";
            this.buttonTransaction.UseVisualStyleBackColor = false;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // buttonManageAuthor
            // 
            this.buttonManageAuthor.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonManageAuthor.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageAuthor.ForeColor = System.Drawing.Color.White;
            this.buttonManageAuthor.Location = new System.Drawing.Point(730, 386);
            this.buttonManageAuthor.Name = "buttonManageAuthor";
            this.buttonManageAuthor.Size = new System.Drawing.Size(200, 50);
            this.buttonManageAuthor.TabIndex = 7;
            this.buttonManageAuthor.Text = "Manage Authors";
            this.buttonManageAuthor.UseVisualStyleBackColor = false;
            this.buttonManageAuthor.Click += new System.EventHandler(this.buttonManageAuthor_Click);
            // 
            // buttonManageBook
            // 
            this.buttonManageBook.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonManageBook.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageBook.ForeColor = System.Drawing.Color.White;
            this.buttonManageBook.Location = new System.Drawing.Point(509, 386);
            this.buttonManageBook.Name = "buttonManageBook";
            this.buttonManageBook.Size = new System.Drawing.Size(200, 50);
            this.buttonManageBook.TabIndex = 6;
            this.buttonManageBook.Text = "Manage Books";
            this.buttonManageBook.UseVisualStyleBackColor = false;
            this.buttonManageBook.Click += new System.EventHandler(this.buttonManageBook_Click);
            // 
            // buttonInfomation
            // 
            this.buttonInfomation.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonInfomation.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfomation.ForeColor = System.Drawing.Color.White;
            this.buttonInfomation.Location = new System.Drawing.Point(399, 288);
            this.buttonInfomation.Name = "buttonInfomation";
            this.buttonInfomation.Size = new System.Drawing.Size(200, 50);
            this.buttonInfomation.TabIndex = 5;
            this.buttonInfomation.Text = "Infomation";
            this.buttonInfomation.UseVisualStyleBackColor = false;
            this.buttonInfomation.Click += new System.EventHandler(this.buttonInfomation_Click);
            // 
            // buttonManageCategory
            // 
            this.buttonManageCategory.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonManageCategory.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageCategory.ForeColor = System.Drawing.Color.White;
            this.buttonManageCategory.Location = new System.Drawing.Point(288, 386);
            this.buttonManageCategory.Name = "buttonManageCategory";
            this.buttonManageCategory.Size = new System.Drawing.Size(200, 50);
            this.buttonManageCategory.TabIndex = 10;
            this.buttonManageCategory.Text = "Manage Category";
            this.buttonManageCategory.UseVisualStyleBackColor = false;
            this.buttonManageCategory.Click += new System.EventHandler(this.buttonManageCategory_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonLogOut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(1032, 719);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(150, 30);
            this.buttonLogOut.TabIndex = 18;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonLoan
            // 
            this.buttonLoan.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonLoan.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoan.ForeColor = System.Drawing.Color.White;
            this.buttonLoan.Location = new System.Drawing.Point(288, 484);
            this.buttonLoan.Name = "buttonLoan";
            this.buttonLoan.Size = new System.Drawing.Size(200, 50);
            this.buttonLoan.TabIndex = 19;
            this.buttonLoan.Text = "Loan";
            this.buttonLoan.UseVisualStyleBackColor = false;
            this.buttonLoan.Click += new System.EventHandler(this.buttonLoan_Click);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonStatistic.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistic.ForeColor = System.Drawing.Color.White;
            this.buttonStatistic.Location = new System.Drawing.Point(730, 484);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(200, 50);
            this.buttonStatistic.TabIndex = 20;
            this.buttonStatistic.Text = "Statistic";
            this.buttonStatistic.UseVisualStyleBackColor = false;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            // 
            // formMenuStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.backgroundMenuStaff;
            this.ClientSize = new System.Drawing.Size(1194, 761);
            this.Controls.Add(this.buttonStatistic);
            this.Controls.Add(this.buttonLoan);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonManageCategory);
            this.Controls.Add(this.buttonManageReader);
            this.Controls.Add(this.buttonTransaction);
            this.Controls.Add(this.buttonManageAuthor);
            this.Controls.Add(this.buttonManageBook);
            this.Controls.Add(this.buttonInfomation);
            this.Name = "formMenuStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageReader;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Button buttonManageAuthor;
        private System.Windows.Forms.Button buttonManageBook;
        private System.Windows.Forms.Button buttonInfomation;
        private System.Windows.Forms.Button buttonManageCategory;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonLoan;
        private System.Windows.Forms.Button buttonStatistic;
    }
}