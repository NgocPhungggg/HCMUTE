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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Management
{
    public partial class formInformation : Form
    {
        Account account = new Account();
        public formInformation()
        {
            InitializeComponent();
        }

        private void formInformation_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
        public bool LoadDataToGrid()
        {
            var info = account.LoadInformation();

            if (info != null && info.Count > 0)
            {
                labelStaffName.Text = info[0]["staffName"].AsString;
                labelPhone.Text = info[0]["phone"].AsString;
                labelEmail.Text = info[0]["email"].AsString;
                labelAddress.Text = info[0]["address"].AsString;
                labelPosition.Text = info[0]["position"].AsString;
                labelHireDate.Text = info[0]["hiredate"].ToLocalTime().ToShortDateString();
                labelUserName2.Text = Session.Username;
                return true;
            }
            else
                return false;
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text == tbConfirmPassword.Text)
            {
                string result = account.UpdateAccount(Session.Username, tbNewPassword.Text);
                if (result == "")
                {
                    MessageBox.Show($"Thay đổi mật khẩu thành công");
                    LoadDataToGrid();
                }
                else
                {
                    MessageBox.Show($"Lỗi không thể thay đổi mật khẩu\n{result}",
                     "Lỗi",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Mật khẩu không khớp, cần kiểm tra lại");
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
