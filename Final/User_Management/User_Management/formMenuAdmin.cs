using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Management
{
    public partial class formMenuAdmin : Form
    {
        public formMenuAdmin()
        {
            InitializeComponent();
        }

        private void button_Info_Click(object sender, EventArgs e)
        {
            formInfo info = new formInfo();
            info.Show();
            this.Hide();
        }

        private void button_Privileges_Click(object sender, EventArgs e)
        {
            formPrivileges privileges = new formPrivileges();
            privileges.Show();
            this.Hide();
        }

        private void button_Role_Click(object sender, EventArgs e)
        {
            formRolePrivileges role = new formRolePrivileges();
            role.Show();
            this.Hide();
        }

        private void button_UserManagement_Click(object sender, EventArgs e)
        {
            formUserManagement user = new formUserManagement();
            user.Show();
            this.Hide();
        }

        private void button_Profile_Click(object sender, EventArgs e)
        {
            formProfiles profile = new formProfiles();
            profile.Show();
            this.Hide();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }
    }
}
