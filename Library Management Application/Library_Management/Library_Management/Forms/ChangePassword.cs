using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Forms
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        ChangePW changePassword = new ChangePW();
        private void Button_Change_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.pass == TextBox_OldPassword.Text)
            {
                if (TextBox_NewPassword.Text == TextBox_NewPassword2.Text)
                {
                    if (changePassword.ChangePWEmployee(GlobalVariables.acc, TextBox_NewPassword.Text))
                    {
                        MessageBox.Show("Password Changed", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Old Password", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
