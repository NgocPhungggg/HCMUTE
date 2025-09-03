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
    public partial class formManageCategory : Form
    {
        Category category = new Category();

        public event Action OnDataChanged;

        public formManageCategory()
        {
            InitializeComponent();
        }

        private void formManageCategory_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string id = txtCategoryId.Text;
            string name = txtCategoryName.Text;
            string desc = txtDescription.Text;

            if (category.InsertCategory(id, name, desc))
            {
                MessageBox.Show("Thêm thể loại thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm thể loại");
            }
            // Gọi event báo thay đổi dữ liệu
            OnDataChanged?.Invoke();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtCategoryId.Text;
            string name = txtCategoryName.Text;
            string desc = txtDescription.Text;

            if (category.UpdateCategory(id, name, desc))
            {
                MessageBox.Show("Cập nhật thể loại thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật thể loại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtCategoryId.Text;

            if (category.DeleteCategory(id))
            {
                MessageBox.Show("Xóa thể loại thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show("Lỗi khi xóa thể loại");
            }
        }

        private void dgvCategories_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCategories.CurrentCell.RowIndex;
            txtCategoryId.Text = dgvCategories.Rows[r].Cells[0].Value.ToString();
            txtCategoryName.Text = dgvCategories.Rows[r].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[r].Cells[2].Value.ToString();

            txtCategoryId.ReadOnly = true;
        }

        public void ClearFields()
        {
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
            txtDescription.Text = "";
            txtCategoryId.ReadOnly = false;
        }

        public void LoadDataToGrid()
        {
            var info = category.LoadInformation();

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

                dgvCategories.DataSource = table;
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
