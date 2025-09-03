using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace Library_Management
{
    public partial class formManageBook : Form
    {
        Book book = new Book();
        Author author = new Author();
        Category category = new Category();

        public formManageBook()
        {
            InitializeComponent();
        }

        private void formManageBook_Load(object sender, EventArgs e)
        {
            // Load dữ liệu Author và Category
            LoadAuthorsToComboBox();
            LoadCategoriesToComboBox();

            // Load danh sách sách vào bảng
            LoadBooksToGrid();

            //    // Kiểm tra dữ liệu để không cho tạo mới Author/Category nếu đã có
            //    btnCreateAuthor.Visible = false;   // Ẩn nút tạo mới Author nếu có (hoặc disable)
            //    btnCreateCategory.Visible = false; // Ẩn nút tạo mới Category nếu có (hoặc disable)
        }
        private void btnOpenAuthor_Click(object sender, EventArgs e)
        {
            formManageAuthor authorForm = new formManageAuthor();
            authorForm.OnDataChanged += LoadAuthorsToComboBox;
            authorForm.Show();
        }

        private void btnOpenCategory_Click(object sender, EventArgs e)
        {
            formManageAuthor authorForm = new formManageAuthor();
            authorForm.OnDataChanged += LoadCategoriesToComboBox;
            authorForm.Show();
        }

        private void LoadAuthorsToComboBox()
        {
            cbAuthor.Items.Clear();
            var authors = new Author().LoadInformation();
            foreach (var author in authors)
            {
                cbAuthor.Items.Add(author["authorName"].ToString());
            }
        }

        private void LoadCategoriesToComboBox()
        {
            cbCategory.Items.Clear();
            var categories = new Category().LoadInformation();
            foreach (var category in categories)
            {
                cbCategory.Items.Add(category["categoryName"].ToString());
            }
        }

        private void LoadBooksToGrid()
        {
            var list = book.LoadInformation();
            if (list != null && list.Count > 0)
            {
                DataTable table = new DataTable();
                foreach (var key in list[0].Names)
                {
                    table.Columns.Add(key);
                }

                foreach (var doc in list)
                {
                    var row = table.NewRow();
                    foreach (var key in doc.Names)
                    {
                        row[key] = doc[key].ToString();
                    }
                    table.Rows.Add(row);
                }

                dgvBooks.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (book.InsertBook(
                txtBookId.Text,
                txtTitle.Text,
                cbAuthor.Text,
                pickerPublishedYear.Value,
                cbCategory.Text))
            {
                MessageBox.Show("Thêm sách thành công!");
                LoadBooksToGrid();
            }
            else
            {
                MessageBox.Show("Không thể thêm sách!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (book.UpdateBook(
                txtBookId.Text,
                txtTitle.Text,
                cbAuthor.Text,
                pickerPublishedYear.Value,
                cbCategory.Text))
            {
                MessageBox.Show("Cập nhật sách thành công!");
                LoadBooksToGrid();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật sách!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (book.DeleteBook(txtBookId.Text))
            {
                MessageBox.Show("Xóa sách thành công!");
                LoadBooksToGrid();
            }
            else
            {
                MessageBox.Show("Không thể xóa sách!");
            }
        }

        private void dgvBooks_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvBooks.CurrentCell.RowIndex;

            txtBookId.Text = dgvBooks.Rows[row].Cells[0].Value.ToString();
            txtTitle.Text = dgvBooks.Rows[row].Cells[1].Value.ToString();
            cbAuthor.Text = dgvBooks.Rows[row].Cells[2].Value.ToString();
            pickerPublishedYear.Value = Convert.ToDateTime(dgvBooks.Rows[row].Cells[3].Value);
            cbCategory.Text = dgvBooks.Rows[row].Cells[4].Value.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuStaff formmenustaff = new formMenuStaff();
            formmenustaff.Show();
            this.Hide();
        }
    }
}
