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
    public partial class formManageAuthor : Form
    {
        Author author = new Author();

        public event Action OnDataChanged;

        public formManageAuthor()
        {
            InitializeComponent();
        }

        private void formManageAuthor_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string authorId = txtID.Text;
            string authorName = txtAuthorName.Text;
            DateTime dateOfBirth = pickerDob.Value.Date;
            string nationality = txtNationality.Text;
            string description = txtDescription.Text;

            if (author.InsertAuthor(authorId, authorName, dateOfBirth, nationality, description))
            {
                MessageBox.Show("Thêm tác giả thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể thêm tác giả");
            }
            // Gọi event báo thay đổi dữ liệu
            OnDataChanged?.Invoke();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string authorId = txtID.Text;
            string authorName = txtAuthorName.Text;
            DateTime dateOfBirth = pickerDob.Value.Date;
            string nationality = txtNationality.Text;
            string description = txtDescription.Text;

            if (author.UpdateAuthor(authorId, authorName, dateOfBirth, nationality, description))
            {
                MessageBox.Show("Cập nhật tác giả thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể cập nhật tác giả");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string authorId = txtID.Text;

            if (author.DeleteAuthor(authorId))
            {
                MessageBox.Show("Xóa tác giả thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể xóa tác giả");
            }
        }

        private void dgvAuthors_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvAuthors.CurrentCell.RowIndex;
            txtID.Text = dgvAuthors.Rows[r].Cells[0].Value.ToString();
            txtAuthorName.Text = dgvAuthors.Rows[r].Cells[1].Value.ToString();
            pickerDob.Value = Convert.ToDateTime(dgvAuthors.Rows[r].Cells[2].Value);
            txtNationality.Text = dgvAuthors.Rows[r].Cells[3].Value.ToString();
            txtDescription.Text = dgvAuthors.Rows[r].Cells[4].Value.ToString();
        }

        public bool LoadDataToGrid()
        {
            var info = author.LoadInformation();

            if (info != null && info.Count > 0)
            {
                DataTable table = new DataTable();
                foreach (var key in info[0].Names)
                {
                    table.Columns.Add(key);
                }

                foreach (var doc in info)
                {
                    var row = table.NewRow();
                    foreach (var key in doc.Names)
                    {
                        row[key] = doc[key].ToString();
                    }
                    table.Rows.Add(row);
                }

                dgvAuthors.DataSource = table;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuStaff formmenustaff = new formMenuStaff();
            formmenustaff.Show();
            this.Hide();
        }
    }
}
