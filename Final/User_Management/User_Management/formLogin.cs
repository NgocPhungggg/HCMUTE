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
        string strConnectionString = "DATA SOURCE=localhost:1521/ORCLPDB;USER ID=SYS;PASSWORD=1234;DBA Privilege=SYSDBA";
        OracleConnection conn = null;
        OracleCommand cmd = null;

        public formLogin()
        {
            conn = new OracleConnection(strConnectionString);
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
                    builder.Append(b.ToString("x2")); // Chuyển byte sang hex string
                }
                return builder.ToString();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text; 
            string password = textBoxPassword.Text;
            string hashedPassword = HashPassword(password);
            string query = "SELECT COUNT(*) FROM ADMIN.USERS WHERE USERNAME = :username AND PASSWORD = :hashed_password";
            string connectionString = $@"USER ID={username};PASSWORD={password};DATA SOURCE=localhost:1521/ORCLPDB";

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("username", username));
                cmd.Parameters.Add(new OracleParameter("hashed_password", hashedPassword));

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                if (count > 0)
                {
                    if (user.CheckLogin(connectionString))
                    {
                        if (username == "ADMIN" || username == "admin")
                        {
                            formMenuAdmin menuAdmin = new formMenuAdmin();
                            menuAdmin.Show();
                            this.Hide();

                        }
                        else
                        {
                            formMenuAdmin menuUser = new formMenuAdmin();
                            menuUser.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }


            try
            {
                if (user.CheckLogin(connectionString))
                {
                    if (username == "ADMIN" || username == "admin")
                    {
                        formMenuAdmin menuAdmin = new formMenuAdmin();
                        menuAdmin.Show();
                        this.Hide();

                    }
                    else
                    {
                        formMenuAdmin menuUser = new formMenuAdmin();
                        menuUser.Show();
                        this.Hide();
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
