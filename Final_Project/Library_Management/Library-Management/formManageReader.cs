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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management
{
    public partial class formManageReader : Form
    {
        Account account = new Account();
        Reader reader = new Reader();
        public formManageReader()
        {
            InitializeComponent();
        }
        private void formManageReader_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string userName = tbID.Text;
            string readerName = tbReaderName.Text;
            DateTime birthDate = pickerBirthDate.Value.Date;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string position = tbPosition.Text;

            string result = reader.InsertReader(userName,
                                     readerName,
                                     birthDate,
                                     phone,
                                     email,
                                     address,
                                     position);
            if (result == "")
            {
                MessageBox.Show($"Thêm người đọc thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show($"Lỗi không thể thêm người đọc\n{result}",
                 "Lỗi",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string userName = tbID.Text;
            string readerName = tbReaderName.Text;
            DateTime birthDate = pickerBirthDate.Value.Date;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string position = tbPosition.Text;

            string result = reader.UpdateReader(userName,
                                    readerName,
                                    birthDate,
                                    phone,
                                    email,
                                    address,
                                    position);

            if (result == "")
            {
                MessageBox.Show($"Thay đổi thông tin người đọc thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show($"Lỗi không thể thay đổi thông tin người đọc\n{result}",
                 "Lỗi",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string userName = tbID.Text;
            string result = reader.DeleteReader(userName);

            if (result == "")
            {
                MessageBox.Show($"Đã xóa người đọc thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show($"Lỗi không thể xóa người đọc\n{result}",
                 "Lỗi",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void dgvReaders_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvReaders.CurrentCell.RowIndex;
            tbID.Text = dgvReaders.Rows[r].Cells[0].Value.ToString();
            tbReaderName.Text = dgvReaders.Rows[r].Cells[1].Value.ToString();
            pickerBirthDate.Value = Convert.ToDateTime(dgvReaders.Rows[r].Cells[2].Value);
            tbPhone.Text = dgvReaders.Rows[r].Cells[3].Value.ToString();
            tbEmail.Text = dgvReaders.Rows[r].Cells[4].Value.ToString();
            tbAddress.Text = dgvReaders.Rows[r].Cells[5].Value.ToString();
            tbPosition.Text = dgvReaders.Rows[r].Cells[6].Value.ToString();

        }
        public bool LoadDataToGrid()
        {
            var info = reader.LoadInformation();

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

                dgvReaders.DataSource = table;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (Session.Role == "Admin")
            {
                formMenuAdmin formmenuadmin = new formMenuAdmin();    
                formmenuadmin.Show();
                this.Hide();
            }
            else if (Session.Role == "Staff")
            {
                formMenuStaff formmenustaff = new formMenuStaff();
                formmenustaff.Show();
                this.Hide();
            }

        }
    }
}
