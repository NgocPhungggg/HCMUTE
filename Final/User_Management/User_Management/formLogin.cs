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


namespace User_Management
{
    public partial class formLogin : Form
    {
        User user = new User();
        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text; 
            string password = textBoxPassword.Text; 

            string connectionString = $@"USER ID={username};PASSWORD={password};DATA SOURCE=localhost:1521/ORCLPDB";
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
