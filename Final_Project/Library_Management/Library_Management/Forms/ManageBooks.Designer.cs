namespace Library.Show
{
    partial class ManageBooks
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
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTamLy = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbCongnghe = new System.Windows.Forms.Label();
            this.lbNongnghiep = new System.Windows.Forms.Label();
            this.lbYhoc = new System.Windows.Forms.Label();
            this.lbLichsu = new System.Windows.Forms.Label();
            this.lbNhac = new System.Windows.Forms.Label();
            this.lbLaw = new System.Windows.Forms.Label();
            this.lbNgonNgu = new System.Windows.Forms.Label();
            this.lbArt = new System.Windows.Forms.Label();
            this.lbComic = new System.Windows.Forms.Label();
            this.lblSGK = new System.Windows.Forms.Label();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_ManagementDataSet = new Library_Management.Library_ManagementDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.booksTableAdapter = new Library_Management.Library_ManagementDataSetTableAdapters.BooksTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_ManagementDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.Linen;
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(371, 80);
            this.txtSL.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(166, 23);
            this.txtSL.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(368, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Số lượng";
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.BackColor = System.Drawing.Color.Linen;
            this.cbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Items.AddRange(new object[] {
            "Sách giáo khoa",
            "Tâm lý",
            "Truyện tranh",
            "Văn học - Nghệ thuật",
            "Công nghệ",
            "Ngôn ngữ",
            "Luật pháp",
            "Âm nhạc",
            "Y học",
            "Lịch sử",
            "Nông nghiệp"});
            this.cbTheLoai.Location = new System.Drawing.Point(199, 26);
            this.cbTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(128, 24);
            this.cbTheLoai.TabIndex = 21;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Tan;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(665, 74);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 30);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Tan;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(665, 29);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 30);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Tan;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(568, 28);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 30);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTamLy
            // 
            this.lblTamLy.AutoSize = true;
            this.lblTamLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTamLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamLy.Location = new System.Drawing.Point(13, 54);
            this.lblTamLy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTamLy.Name = "lblTamLy";
            this.lblTamLy.Size = new System.Drawing.Size(43, 15);
            this.lblTamLy.TabIndex = 1;
            this.lblTamLy.Text = "Tâm lý";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lbCongnghe);
            this.panel4.Controls.Add(this.lbNongnghiep);
            this.panel4.Controls.Add(this.lbYhoc);
            this.panel4.Controls.Add(this.lbLichsu);
            this.panel4.Controls.Add(this.lbNhac);
            this.panel4.Controls.Add(this.lbLaw);
            this.panel4.Controls.Add(this.lbNgonNgu);
            this.panel4.Controls.Add(this.lbArt);
            this.panel4.Controls.Add(this.lbComic);
            this.panel4.Controls.Add(this.lblTamLy);
            this.panel4.Controls.Add(this.lblSGK);
            this.panel4.Location = new System.Drawing.Point(107, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 215);
            this.panel4.TabIndex = 38;
            // 
            // lbCongnghe
            // 
            this.lbCongnghe.AutoSize = true;
            this.lbCongnghe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCongnghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCongnghe.Location = new System.Drawing.Point(13, 26);
            this.lbCongnghe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCongnghe.Name = "lbCongnghe";
            this.lbCongnghe.Size = new System.Drawing.Size(67, 15);
            this.lbCongnghe.TabIndex = 10;
            this.lbCongnghe.Text = "Công nghệ";
            // 
            // lbNongnghiep
            // 
            this.lbNongnghiep.AutoSize = true;
            this.lbNongnghiep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNongnghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNongnghiep.Location = new System.Drawing.Point(115, 54);
            this.lbNongnghiep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNongnghiep.Name = "lbNongnghiep";
            this.lbNongnghiep.Size = new System.Drawing.Size(78, 15);
            this.lbNongnghiep.TabIndex = 9;
            this.lbNongnghiep.Text = "Nông nghiệp";
            // 
            // lbYhoc
            // 
            this.lbYhoc.AutoSize = true;
            this.lbYhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbYhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYhoc.Location = new System.Drawing.Point(115, 80);
            this.lbYhoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbYhoc.Name = "lbYhoc";
            this.lbYhoc.Size = new System.Drawing.Size(37, 15);
            this.lbYhoc.TabIndex = 8;
            this.lbYhoc.Text = "Y học";
            // 
            // lbLichsu
            // 
            this.lbLichsu.AutoSize = true;
            this.lbLichsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLichsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLichsu.Location = new System.Drawing.Point(115, 108);
            this.lbLichsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLichsu.Name = "lbLichsu";
            this.lbLichsu.Size = new System.Drawing.Size(46, 15);
            this.lbLichsu.TabIndex = 7;
            this.lbLichsu.Text = "Lịch sử";
            // 
            // lbNhac
            // 
            this.lbNhac.AutoSize = true;
            this.lbNhac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhac.Location = new System.Drawing.Point(13, 166);
            this.lbNhac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNhac.Name = "lbNhac";
            this.lbNhac.Size = new System.Drawing.Size(55, 15);
            this.lbNhac.TabIndex = 6;
            this.lbNhac.Text = "Âm nhạc";
            // 
            // lbLaw
            // 
            this.lbLaw.AutoSize = true;
            this.lbLaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLaw.Location = new System.Drawing.Point(13, 137);
            this.lbLaw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLaw.Name = "lbLaw";
            this.lbLaw.Size = new System.Drawing.Size(62, 15);
            this.lbLaw.TabIndex = 5;
            this.lbLaw.Text = "Luật pháp";
            // 
            // lbNgonNgu
            // 
            this.lbNgonNgu.AutoSize = true;
            this.lbNgonNgu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgonNgu.Location = new System.Drawing.Point(12, 108);
            this.lbNgonNgu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgonNgu.Name = "lbNgonNgu";
            this.lbNgonNgu.Size = new System.Drawing.Size(61, 15);
            this.lbNgonNgu.TabIndex = 4;
            this.lbNgonNgu.Text = "Ngôn ngữ";
            // 
            // lbArt
            // 
            this.lbArt.AutoSize = true;
            this.lbArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArt.Location = new System.Drawing.Point(115, 137);
            this.lbArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbArt.Name = "lbArt";
            this.lbArt.Size = new System.Drawing.Size(121, 15);
            this.lbArt.TabIndex = 3;
            this.lbArt.Text = "Văn học - Nghệ thuật";
            // 
            // lbComic
            // 
            this.lbComic.AutoSize = true;
            this.lbComic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbComic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComic.Location = new System.Drawing.Point(12, 80);
            this.lbComic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComic.Name = "lbComic";
            this.lbComic.Size = new System.Drawing.Size(75, 15);
            this.lbComic.TabIndex = 2;
            this.lbComic.Text = "Truyện tranh";
            // 
            // lblSGK
            // 
            this.lblSGK.AutoSize = true;
            this.lblSGK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSGK.Location = new System.Drawing.Point(115, 26);
            this.lblSGK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSGK.Name = "lblSGK";
            this.lblSGK.Size = new System.Drawing.Size(92, 15);
            this.lblSGK.TabIndex = 0;
            this.lblSGK.Text = "Sách giáo khoa";
            // 
            // txtTenTG
            // 
            this.txtTenTG.BackColor = System.Drawing.Color.Linen;
            this.txtTenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Location = new System.Drawing.Point(371, 27);
            this.txtTenTG.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(166, 23);
            this.txtTenTG.TabIndex = 14;
            // 
            // BookDGV
            // 
            this.BookDGV.AutoGenerateColumns = false;
            this.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDGV.BackgroundColor = System.Drawing.Color.Bisque;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publicationYearDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.BookDGV.DataSource = this.booksBindingSource;
            this.BookDGV.Location = new System.Drawing.Point(344, 394);
            this.BookDGV.Margin = new System.Windows.Forms.Padding(2);
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.RowHeadersVisible = false;
            this.BookDGV.RowHeadersWidth = 51;
            this.BookDGV.RowTemplate.Height = 24;
            this.BookDGV.Size = new System.Drawing.Size(529, 216);
            this.BookDGV.TabIndex = 36;
            this.BookDGV.DoubleClick += new System.EventHandler(this.BookDGV_DoubleClick);
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // publicationYearDataGridViewTextBoxColumn
            // 
            this.publicationYearDataGridViewTextBoxColumn.DataPropertyName = "PublicationYear";
            this.publicationYearDataGridViewTextBoxColumn.HeaderText = "PublicationYear";
            this.publicationYearDataGridViewTextBoxColumn.Name = "publicationYearDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.library_ManagementDataSet;
            // 
            // library_ManagementDataSet
            // 
            this.library_ManagementDataSet.DataSetName = "Library_ManagementDataSet";
            this.library_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtFind);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.cbFind);
            this.panel2.Location = new System.Drawing.Point(241, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 54);
            this.panel2.TabIndex = 34;
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.Linen;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(140, 14);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(261, 23);
            this.txtFind.TabIndex = 17;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Tan;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(420, 14);
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
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Tên tác giả"});
            this.cbFind.Location = new System.Drawing.Point(10, 14);
            this.cbFind.Margin = new System.Windows.Forms.Padding(2);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(121, 21);
            this.cbFind.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbTheLoai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtTenTG);
            this.panel1.Controls.Add(this.txtNamXB);
            this.panel1.Controls.Add(this.txtTenSach);
            this.panel1.Controls.Add(this.txtMaSach);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(124, 198);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 120);
            this.panel1.TabIndex = 33;
            // 
            // txtNamXB
            // 
            this.txtNamXB.BackColor = System.Drawing.Color.Linen;
            this.txtNamXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXB.Location = new System.Drawing.Point(199, 80);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(128, 23);
            this.txtNamXB.TabIndex = 13;
            // 
            // txtTenSach
            // 
            this.txtTenSach.BackColor = System.Drawing.Color.Linen;
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(10, 80);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(167, 23);
            this.txtTenSach.TabIndex = 11;
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.Color.Linen;
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(10, 27);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(167, 23);
            this.txtMaSach.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Năm xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã sách";
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.BG_BookManagement;
            this.ClientSize = new System.Drawing.Size(984, 627);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BookDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageBooks";
            this.Text = "ManageBooks";
            this.Load += new System.EventHandler(this.ManageBooks_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_ManagementDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTamLy;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbCongnghe;
        private System.Windows.Forms.Label lbNongnghiep;
        private System.Windows.Forms.Label lbYhoc;
        private System.Windows.Forms.Label lbLichsu;
        private System.Windows.Forms.Label lbNhac;
        private System.Windows.Forms.Label lbLaw;
        private System.Windows.Forms.Label lbNgonNgu;
        private System.Windows.Forms.Label lbArt;
        private System.Windows.Forms.Label lbComic;
        private System.Windows.Forms.Label lblSGK;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.DataGridView BookDGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private Library_Management.Library_ManagementDataSet library_ManagementDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private Library_Management.Library_ManagementDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}