namespace Library_Management
{
    partial class formLoans
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLoanId = new System.Windows.Forms.TextBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboBook = new System.Windows.Forms.ComboBox();
            this.cboReader = new System.Windows.Forms.ComboBox();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(315, 570);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(191, 570);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 30);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(376, 536);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 30);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(252, 536);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(127, 536);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtLoanId
            // 
            this.txtLoanId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanId.Location = new System.Drawing.Point(221, 485);
            this.txtLoanId.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.ReadOnly = true;
            this.txtLoanId.Size = new System.Drawing.Size(200, 26);
            this.txtLoanId.TabIndex = 20;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBorrowDate.Location = new System.Drawing.Point(221, 344);
            this.dtpBorrowDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(200, 26);
            this.dtpBorrowDate.TabIndex = 19;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Location = new System.Drawing.Point(221, 379);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDueDate.TabIndex = 18;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnDate.Location = new System.Drawing.Point(221, 411);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.ShowCheckBox = true;
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 26);
            this.dtpReturnDate.TabIndex = 17;
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(221, 450);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(200, 27);
            this.cboStatus.TabIndex = 16;
            // 
            // cboBook
            // 
            this.cboBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBook.FormattingEnabled = true;
            this.cboBook.Location = new System.Drawing.Point(221, 310);
            this.cboBook.Margin = new System.Windows.Forms.Padding(2);
            this.cboBook.Name = "cboBook";
            this.cboBook.Size = new System.Drawing.Size(200, 27);
            this.cboBook.TabIndex = 15;
            // 
            // cboReader
            // 
            this.cboReader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReader.FormattingEnabled = true;
            this.cboReader.Location = new System.Drawing.Point(221, 273);
            this.cboReader.Margin = new System.Windows.Forms.Padding(2);
            this.cboReader.Name = "cboReader";
            this.cboReader.Size = new System.Drawing.Size(200, 27);
            this.cboReader.TabIndex = 14;
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(616, 206);
            this.dgvLoans.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.RowHeadersWidth = 62;
            this.dgvLoans.RowTemplate.Height = 28;
            this.dgvLoans.Size = new System.Drawing.Size(503, 452);
            this.dgvLoans.TabIndex = 13;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(1052, 719);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 30);
            this.buttonBack.TabIndex = 100;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // formLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.backgroundLoan;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLoanId);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboBook);
            this.Controls.Add(this.cboReader);
            this.Controls.Add(this.dgvLoans);
            this.Name = "formLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLoans";
            this.Click += new System.EventHandler(this.btnEdit_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLoanId;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboBook;
        private System.Windows.Forms.ComboBox cboReader;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.Button buttonBack;
    }
}