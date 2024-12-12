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
    public partial class formRolePrivileges : Form
    {
        Privileges privileges = new Privileges();
        Role role = new Role();
        public formRolePrivileges()
        {
            InitializeComponent();
        }
        private void load ()
        {
            
            DataTable dataTable_roleprivileges = privileges.GetRolePrivilegsView();
            dataGridViewRolePrivileges.DataSource = dataTable_roleprivileges;

            DataTable dataTable_userrole = privileges.GetUserRoleAssignmentsView();
            dataGridViewUserRolePrivileges.DataSource = dataTable_userrole;
        }
        private void formRolePrivileges_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_AllUser.ALL_USER' table. You can move, or remove it, as needed.
            this.aLL_USERTableAdapter.Fill(this.dataSet_AllUser.ALL_USER);
            try
            {
                load();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewRolePrivileges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewRolePrivileges.CurrentCell.RowIndex;
            string role_name = dataGridViewRolePrivileges.Rows[r].Cells[0].Value.ToString();
            textBox_RoleName1.Text = role_name;
            textBox_RoleName2.Text = role_name;

            DataTable dataTable_system = privileges.GetOneRolePrivileges(role_name);
            dataGridViewRolePrivileges.DataSource = dataTable_system;

            DataTable dataTable_object = privileges.GetOneUserRolePrivileges(role_name);
            dataGridViewUserRolePrivileges.DataSource = dataTable_object;

            dataGridViewRolePrivileges.Refresh();
            dataGridViewUserRolePrivileges.Refresh();

        }
        private void dataGridViewUserRolePrivileges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewUserRolePrivileges.CurrentCell.RowIndex;
            string role_name = dataGridViewUserRolePrivileges.Rows[r].Cells[1].Value.ToString();
            string username = dataGridViewUserRolePrivileges.Rows[r].Cells[0].Value.ToString();
            textBox_RoleName1.Text = role_name;
            textBox_RoleName2.Text = role_name;
            textBoxUserName.Text = username;


            DataTable dataTable_system = privileges.GetOneRolePrivileges(role_name);
            dataGridViewRolePrivileges.DataSource = dataTable_system;

            DataTable dataTable_object = privileges.GetOnePrivileges(username);
            dataGridViewUserRolePrivileges.DataSource = dataTable_object;

            dataGridViewRolePrivileges.Refresh();
            dataGridViewUserRolePrivileges.Refresh();

        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewUser.CurrentCell.RowIndex;
            string username = dataGridViewUser.Rows[r].Cells[0].Value.ToString();
            textBoxUserName.Text = username;
        }
        private void button_Create_Click(object sender, EventArgs e)
        {
            string role_name = Check_Empty(textBox_RoleName1.Text.Trim());
            string password = Check_Empty(textBox_PassWord.Text.Trim());
            if (string.IsNullOrEmpty(role_name))
            {
                MessageBox.Show("Role name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string err = string.Empty;
                bool result = false;
                result = role.CreateRole(ref err, role_name, password);
                ShowMessage(result, err);
            }
            load();


        }

        private void button_Alter_Click(object sender, EventArgs e)
        {
            string role_name = Check_Empty(textBox_RoleName1.Text.Trim());
            string password = Check_Empty(textBox_PassWord.Text.Trim());
            if (string.IsNullOrEmpty(role_name))
            {
                MessageBox.Show("Role name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string err = string.Empty;
                bool result = false;
                result = role.AlterRole(ref err, role_name, password);
                ShowMessage(result, err);
            }
            load();

        }

        private void button_Drop_Click(object sender, EventArgs e)
        {
            string role_name = Check_Empty(textBox_RoleName1.Text.Trim());
            if (string.IsNullOrEmpty(role_name))
            {
                MessageBox.Show("Role name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string err = string.Empty;
                bool result = false;
                result = role.DropRole(ref err, role_name);
                ShowMessage(result, err);
            }
            load();

        }

        private void button_Grant_Click(object sender, EventArgs e)
        {
            string username = Check_Empty(textBoxUserName.Text.Trim());
            string rolename = Check_Empty(textBox_RoleName2.Text.Trim());
            bool option = false;
            if (radioButton.Checked == true)
            {
                option = true;
            }
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(rolename))
            {
                MessageBox.Show("Role name and user name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string err = string.Empty;
                bool result = false;
                result = privileges.GantRole_User(ref err, rolename, username, option);
                ShowMessage(result, err);
            }
            load();


        }

        private void button_Revoke_Click(object sender, EventArgs e)
        {
            string username = Check_Empty(textBoxUserName.Text.Trim());
            string rolename = Check_Empty(textBox_RoleName2.Text.Trim());
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(rolename))
            {
                MessageBox.Show("Role name and user name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string err = string.Empty;
                bool result = false;
                result = privileges.RevokeRole_User(ref err, rolename, username);
                ShowMessage(result, err);
            }
            load();

        }
        private void button_Back_Click(object sender, EventArgs e)
        {
            formMenuAdmin menuAdmin = new formMenuAdmin();
            menuAdmin.Show();
            this.Hide();
        }

        private string Check_Empty(string checkText)
        {
            return string.IsNullOrEmpty(checkText) ? null : checkText;
        }
        private void ShowMessage(bool result, string err)
        {
            if (result)
            {
                MessageBox.Show("Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Failed to create role. Error: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
