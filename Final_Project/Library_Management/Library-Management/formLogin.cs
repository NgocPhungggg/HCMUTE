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
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core.Configuration;


namespace Library_Management
{
    public partial class formLogin : Form
    {
        Account account = new Account();
        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassWord.Text;
            try
            {
                string[] result = account.CheckLogin(username, password); 
                if (result != null)
                {
                    string role = result[0];
                    string status = result[1];

                    if (status != "Active")
                    {
                        MessageBox.Show("⚠️ Tài khoản của bạn đang bị khóa hoặc tạm ngưng!");
                        return;
                    }
                    else
                    {
                        if (role == "Admin")
                        {
                            formMenuAdmin formmenuadmin = new formMenuAdmin();
                            formmenuadmin.Show();
                            this.Hide();
                        }
                        else if (role == "Staff")
                        {
                            formMenuStaff formmenustaff = new formMenuStaff();                        
                            formmenustaff.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("Không có quyền truy cập");
                        Session.Username = username;
                        Session.Role = role;
                    }
                }
                else
                {
                    MessageBox.Show("❌ Sai tài khoản hoặc mật khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Lỗi kết nối MongoDB: " + ex.Message, "Lỗi hệ thống");
            }
        }
    }
}
