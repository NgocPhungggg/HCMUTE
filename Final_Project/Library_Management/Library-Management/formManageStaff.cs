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
    public partial class formManageStaff : Form
    {
        Account account = new Account();
        Staff staff = new Staff();
        public formManageStaff()
        {
            InitializeComponent();
        }
        private void formManageStaff_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string userName = tbID.Text;
            string staffName = tbStaffName.Text;
            DateTime birthDate = pickerBirthDate.Value.Date;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string position = tbPosition.Text;
            DateTime hireDate = pickerHireDate.Value.Date;
            string role = "Staff";
            string status;
            if (radioButtonActive.Checked == true)
                status = "Active";
            else
                status = "Inactive";

            string result_account = account.InsertAccount(userName,
                                                          role,
                                                          status);

            string result_staff = staff.InsertStaff(userName,
                                                    staffName,
                                                    birthDate,
                                                    phone,
                                                    email,
                                                    address,
                                                    position,
                                                    hireDate);
            if ((result_staff == "") &&
                (result_account == ""))
            {
                MessageBox.Show($"Thêm thủ thư thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show($"Lỗi không thể thêm thủ thư:\n{result_account}\n{result_staff}",
                                 "Lỗi",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string userName = tbID.Text;
            string staffName = tbStaffName.Text;
            DateTime birthDate = pickerBirthDate.Value.Date;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string position = tbPosition.Text;
            DateTime hireDate = pickerHireDate.Value.Date;
            string status;
            if (radioButtonActive.Checked == true)
                status = "Active";
            else
                status = "Inactive";

            string result_account = account.UpdateStatus(userName,
                                                         status);

            string result_staff = staff.UpdateStaff(userName,
                                                    staffName,
                                                    birthDate,
                                                    phone,
                                                    email,
                                                    address,
                                                    position,
                                                    hireDate);

            if ((result_staff == "") ||
                (result_account == ""))
            {
                MessageBox.Show($"Thay đổi thông tin thủ thư thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show($"Lỗi không thể thay đổi thông tin thủ thư:\n{result_account}\n{result_staff}",
                                 "Lỗi",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string userName = tbID.Text;
            string result_account = staff.DeleteStaff(userName);
            string result_staff = account.DeleteAccount(userName);

            if ((result_staff == "") &&
                (result_account == ""))
            {
                MessageBox.Show($"Đã xóa thủ thư thành công");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show($"Lỗi không thể xóa thủ thư:\n{result_staff}\n{result_account}",
                                 "Lỗi",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            string keyword = tbFind.Text;
            var result = staff.Search(keyword); // Gọi hàm Search từ BLL

            if (result != null && result.Count > 0)
            {
                DataTable table = new DataTable();
                var allKeys = new HashSet<string>();

                foreach (var doc in result)
                    foreach (var key in doc.Names)
                        allKeys.Add(key);

                foreach (var key in allKeys)
                    table.Columns.Add(key);

                foreach (var doc in result)
                {
                    var row = table.NewRow();
                    foreach (var key in allKeys)
                        row[key] = doc.Contains(key) ? doc[key].ToString() : "";
                    table.Rows.Add(row);
                }

                dgvStaffs.DataSource = table;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvStaffs.DataSource = null;
            }
        }
        private void dgvStaffs_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvStaffs.CurrentCell.RowIndex;
            tbID.Text = dgvStaffs.Rows[r].Cells[0].Value.ToString();
            tbStaffName.Text = dgvStaffs.Rows[r].Cells[1].Value.ToString();
            pickerHireDate.Value = Convert.ToDateTime(dgvStaffs.Rows[r].Cells[2].Value);
            tbPhone.Text = dgvStaffs.Rows[r].Cells[3].Value.ToString();
            tbEmail.Text = dgvStaffs.Rows[r].Cells[4].Value.ToString();
            tbAddress.Text = dgvStaffs.Rows[r].Cells[5].Value.ToString();
            tbPosition.Text = dgvStaffs.Rows[r].Cells[6].Value.ToString();
            pickerBirthDate.Value = Convert.ToDateTime(dgvStaffs.Rows[r].Cells[7].Value);
            if (account.CheckStatus(tbID.Text) == "Active")
            {
                radioButtonActive.Checked = true;
            }
            else
            {
                radioButtonInactive.Checked = true;
            }

        }
        public bool LoadDataToGrid()
        {
            var info = staff.LoadInformation();

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

                dgvStaffs.DataSource = table;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuAdmin formmenuadmin = new formMenuAdmin();
            formmenuadmin.Show();
            this.Hide();
        }
    }
}
