namespace Library_Management.Forms
{
    partial class ManageBorrowBooks
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResetFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.BookIssueDGV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ngaytra = new System.Windows.Forms.DateTimePicker();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.txtTienphat = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMuon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.library_ManagementDataSet = new Library_Management.Library_ManagementDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Library_Management.Library_ManagementDataSetTableAdapters.BooksTableAdapter();
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readersTableAdapter = new Library_Management.Library_ManagementDataSetTableAdapters.ReadersTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookIssueDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnResetFind);
            this.panel2.Controls.Add(this.txtFind);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.cbFind);
            this.panel2.Location = new System.Drawing.Point(250, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 57);
            this.panel2.TabIndex = 35;
            // 
            // btnResetFind
            // 
            this.btnResetFind.BackColor = System.Drawing.Color.White;
            this.btnResetFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFind.ForeColor = System.Drawing.Color.White;
            this.btnResetFind.Location = new System.Drawing.Point(409, 17);
            this.btnResetFind.Name = "btnResetFind";
            this.btnResetFind.Size = new System.Drawing.Size(19, 19);
            this.btnResetFind.TabIndex = 34;
            this.btnResetFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.Linen;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(139, 13);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(265, 23);
            this.txtFind.TabIndex = 17;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Tan;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(433, 13);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 26);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbFind
            // 
            this.cbFind.BackColor = System.Drawing.Color.Linen;
            this.cbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Items.AddRange(new object[] {
            "Mã phiếu mượn",
            "Mã độc giả"});
            this.cbFind.Location = new System.Drawing.Point(14, 12);
            this.cbFind.Margin = new System.Windows.Forms.Padding(2);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(121, 24);
            this.cbFind.TabIndex = 0;
            // 
            // BookIssueDGV
            // 
            this.BookIssueDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookIssueDGV.BackgroundColor = System.Drawing.Color.Bisque;
            this.BookIssueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookIssueDGV.Location = new System.Drawing.Point(118, 388);
            this.BookIssueDGV.Margin = new System.Windows.Forms.Padding(2);
            this.BookIssueDGV.Name = "BookIssueDGV";
            this.BookIssueDGV.RowHeadersVisible = false;
            this.BookIssueDGV.RowHeadersWidth = 51;
            this.BookIssueDGV.RowTemplate.Height = 24;
            this.BookIssueDGV.Size = new System.Drawing.Size(748, 216);
            this.BookIssueDGV.TabIndex = 36;
            this.BookIssueDGV.DoubleClick += new System.EventHandler(this.BookIssueDGV_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ngày mượn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ngaytra);
            this.panel1.Controls.Add(this.cbMaSach);
            this.panel1.Controls.Add(this.cbMaDG);
            this.panel1.Controls.Add(this.ngaymuon);
            this.panel1.Controls.Add(this.txtTienphat);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnTra);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaMuon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(118, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 119);
            this.panel1.TabIndex = 34;
            // 
            // ngaytra
            // 
            this.ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaytra.Location = new System.Drawing.Point(210, 83);
            this.ngaytra.Margin = new System.Windows.Forms.Padding(2);
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.Size = new System.Drawing.Size(128, 20);
            this.ngaytra.TabIndex = 32;
            // 
            // cbMaSach
            // 
            this.cbMaSach.BackColor = System.Drawing.Color.Linen;
            this.cbMaSach.DataSource = this.booksBindingSource;
            this.cbMaSach.DisplayMember = "BookID";
            this.cbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(210, 27);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(125, 24);
            this.cbMaSach.TabIndex = 31;
            this.cbMaSach.ValueMember = "BookID";
            // 
            // cbMaDG
            // 
            this.cbMaDG.BackColor = System.Drawing.Color.Linen;
            this.cbMaDG.DataSource = this.readersBindingSource;
            this.cbMaDG.DisplayMember = "ReaderID";
            this.cbMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(397, 27);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(125, 24);
            this.cbMaDG.TabIndex = 26;
            this.cbMaDG.ValueMember = "ReaderID";
            // 
            // ngaymuon
            // 
            this.ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaymuon.Location = new System.Drawing.Point(10, 83);
            this.ngaymuon.Margin = new System.Windows.Forms.Padding(2);
            this.ngaymuon.Name = "ngaymuon";
            this.ngaymuon.Size = new System.Drawing.Size(128, 20);
            this.ngaymuon.TabIndex = 25;
            // 
            // txtTienphat
            // 
            this.txtTienphat.BackColor = System.Drawing.Color.Linen;
            this.txtTienphat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienphat.Location = new System.Drawing.Point(397, 80);
            this.txtTienphat.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienphat.Name = "txtTienphat";
            this.txtTienphat.Size = new System.Drawing.Size(125, 23);
            this.txtTienphat.TabIndex = 24;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Tan;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(579, 73);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 30);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.Color.Tan;
            this.btnTra.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.ForeColor = System.Drawing.Color.White;
            this.btnTra.Location = new System.Drawing.Point(667, 48);
            this.btnTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(64, 30);
            this.btnTra.TabIndex = 17;
            this.btnTra.Text = "Trả";
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Tan;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(579, 23);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 30);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày trả";
            // 
            // txtMaMuon
            // 
            this.txtMaMuon.BackColor = System.Drawing.Color.Linen;
            this.txtMaMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMuon.Location = new System.Drawing.Point(11, 27);
            this.txtMaMuon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaMuon.Name = "txtMaMuon";
            this.txtMaMuon.Size = new System.Drawing.Size(128, 23);
            this.txtMaMuon.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiền phạt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã mượn sách";
            // 
            // library_ManagementDataSet
            // 
            this.library_ManagementDataSet.DataSetName = "Library_ManagementDataSet";
            this.library_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.library_ManagementDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "Readers";
            this.readersBindingSource.DataSource = this.library_ManagementDataSet;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // ManageBorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.BG_BorrowingBook;
            this.ClientSize = new System.Drawing.Size(984, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BookIssueDGV);
            this.Controls.Add(this.panel1);
            this.Name = "ManageBorrowBooks";
            this.Text = "ManageBorrowBooks";
            this.Load += new System.EventHandler(this.ManageBorrowBooks_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookIssueDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnResetFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.DataGridView BookIssueDGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.DateTimePicker ngaymuon;
        private System.Windows.Forms.TextBox txtTienphat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.DateTimePicker ngaytra;
        private Library_ManagementDataSet library_ManagementDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private Library_ManagementDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private Library_ManagementDataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
    }
}