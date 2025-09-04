using System;
using System.Collections.Generic;
using System.ComponentModel;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;
using System.Security.Cryptography;

namespace User_Management
{
    public partial class formLogin : Form
    {
        User user = new User();
        string strConnectionString = "DATA SOURCE=localhost:1521/ORCLPDB;USER ID=SYS;PASSWORD=CaoThiNgocPhung1811@;DBA Privilege=SYSDBA";
        bool f = false;
        string err = "";

        public formLogin()
        {
            f = user.CheckLogin(strConnectionString);
            InitializeComponent();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.ToUpper();
            string password = textBoxPassword.Text;
            string connectionString = $@"USER ID={username};PASSWORD={password};DATA SOURCE=localhost:1521/ORCLPDB";

            if (username == "ADMIN")
            {
                
                if (user.CheckLogin(connectionString))
                {
                    formMenuAdmin menuAdmin = new formMenuAdmin();
                    menuAdmin.Show();
                    this.Hide();
                }
            }
            else
            {
                try
                {
                    int count = user.findUser(ref err, username, password);
                    if (count > 0)
                    {
                        if (user.CheckLogin(connectionString))
                        {
                            formMenuAdmin menuAdmin = new formMenuAdmin();
                            menuAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Connection Fail", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
