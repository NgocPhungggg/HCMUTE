using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace User_Management
{
    public partial class formPrivileges : Form
    {
        Privileges privileges = new Privileges();
        Role role = new Role();
        public formPrivileges()
        {
            InitializeComponent();
        }
        private void load()
        {

            DataTable dataTable_roleprivileges = privileges.GetSystemPrivilegesView();
            dataGridViewSystemPrivileges.DataSource = dataTable_roleprivileges;

            DataTable dataTable_userrole = privileges.GetObjectPrivilegesView();
            dataGridViewObjectPrivileges.DataSource = dataTable_userrole;

            DataTable dataTable_DistinctAllRoles = role.GetDistinctRoleName();
            dataGridViewAllRole.DataSource = dataTable_DistinctAllRoles;
            listBox_SystenPrivilegesLoad();
        }
        private void formPrivileges_Load(object sender, EventArgs e)
        {
            this.aLL_USERTableAdapter.Fill(this.dataSet_AllUser.ALL_USER);
            try
            {
                DataTable dataTable_roleprivileges = privileges.GetSystemPrivilegesView();
                dataGridViewSystemPrivileges.DataSource = dataTable_roleprivileges;

                DataTable dataTable_userrole = privileges.GetObjectPrivilegesView();
                dataGridViewObjectPrivileges.DataSource = dataTable_userrole;

                DataTable dataTable_DistinctAllRoles = role.GetDistinctRoleName();
                dataGridViewAllRole.DataSource = dataTable_DistinctAllRoles;
                listBox_SystenPrivilegesLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listBox_SystenPrivilegesLoad()
        {
            List<string> systemPrivileges = new List<string>
            {
                "CREATE PROFILE",
                "ALTER PROFILE",
                "DROP PROFILE",
                "CREATE ROLE",
                "ALTER ANY ROLE",
                "DROP ANY ROLE",
                "GRANT ANY ROLE",
                "CREATE SESSION",
                "CREATE ANY TABLE",
                "ALTER ANY TABLE",
                "DROP ANY TABLE",
                "SELECT ANY TABLE",
                "DELETE ANY TABLE",
                "INSERT ANY TABLE",
                "UPDATE ANY TABLE",
                "CREATE TABLE",
                "CREATE USER",
                "ALTER USER",
                "DROP USER"
            };
            listBox_SystenPrivileges.Items.Clear();
            listBox_SystenPrivileges.Items.AddRange(systemPrivileges.ToArray());

            DataTable dataTable = privileges.GetAllObject();
            listBox_ObjectPrivileges.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                string objectName = row["OBJECT_NAME"].ToString(); // Lấy giá trị cột OBJECT_NAME
                listBox_ObjectPrivileges.Items.Add(objectName);   // Thêm vào ListBox
            }

        }
        private void dataGridViewSystemPrivileges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewSystemPrivileges.CurrentCell.RowIndex;
            string role_name = dataGridViewSystemPrivileges.Rows[r].Cells[0].Value.ToString();
            string system_privileges = dataGridViewSystemPrivileges.Rows[r].Cells[1].Value.ToString();
            textBox_RoleUser.Text = role_name;
            textBox_System.Text = system_privileges;

            DataTable dataTable_system = privileges.GetOneSystemPrivileges(role_name);
            dataGridViewSystemPrivileges.DataSource = dataTable_system;

            DataTable dataTable_object = privileges.GetOneObjectPrivileges(role_name);
            dataGridViewObjectPrivileges.DataSource = dataTable_object;

            dataGridViewSystemPrivileges.Refresh();
            dataGridViewObjectPrivileges.Refresh();
        }
        private void dataGridViewObjectPrivileges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewObjectPrivileges.CurrentCell.RowIndex;
            string role_name = dataGridViewObjectPrivileges.Rows[r].Cells[0].Value.ToString();
            string object_privileges = dataGridViewSystemPrivileges.Rows[r].Cells[1].Value.ToString();
            textBox_RoleUser.Text = role_name;
            textBox_Object.Text = object_privileges;

            DataTable dataTable_system = privileges.GetOneSystemPrivileges(role_name);
            dataGridViewSystemPrivileges.DataSource = dataTable_system;

            DataTable dataTable_object = privileges.GetOneObjectPrivileges(role_name);
            dataGridViewObjectPrivileges.DataSource = dataTable_object;

            dataGridViewSystemPrivileges.Refresh();
            dataGridViewObjectPrivileges.Refresh(); 
        }
        private void dataGridViewAllRole_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewAllRole.CurrentCell.RowIndex;
            string username = dataGridViewAllRole.Rows[r].Cells[0].Value.ToString();
            textBox_RoleUser.Text = username;
        }

        private void dataGridViewUsers_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewUser.CurrentCell.RowIndex;
            string username = dataGridViewUser.Rows[r].Cells[0].Value.ToString();
            textBox_RoleUser.Text = username;
        }
        private void listBox_SystenPrivileges_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_SystenPrivileges.SelectedIndex != -1)
            {
                string selectedPrivilege = listBox_SystenPrivileges.SelectedItem.ToString();
                textBox_System.Text = selectedPrivilege;
            }
        }

        private void listBox_ObjectPrivileges_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_ObjectPrivileges.SelectedIndex != -1)
            {
                string selectedPrivilege = listBox_ObjectPrivileges.SelectedItem.ToString();
                textBox_Object.Text = selectedPrivilege;
                if (selectedPrivilege == "INFO")
                {
                    DataTable dataTable = privileges.GetAllColumsOfINFO();
                    listBox_Info_Col.Items.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string objectName = row["COLUMN_NAME"].ToString();
                        listBox_Info_Col.Items.Add(objectName);
                    }
                }
            }
            
        }
        private void listBox_Info_Col_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Info_Col.SelectedIndex != -1)
            {
                string selectedPrivilege = listBox_Info_Col.SelectedItem.ToString();
                textBox_Col.Text = selectedPrivilege;
            }
        }
        private void button_GrantSystem_Click(object sender, EventArgs e)
        {
            string role_user = Check_Empty(textBox_RoleUser.Text.Trim());
            string system_privileges = Check_Empty(textBox_System.Text.Trim());
            bool option = false;
            if (radioButton.Checked == true)
            {
                option = true;
            }
            if (string.IsNullOrEmpty(role_user) || string.IsNullOrEmpty(system_privileges))
            {
                MessageBox.Show("Role name or user name or system privileges cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string err = string.Empty;
                bool result = false;
                result = privileges.GantPrivileges_System(ref err, system_privileges, role_user, option);
                ShowMessage(result, err);
            }
            load();
        }

        private void button_RevokeSystem_Click(object sender, EventArgs e)
        {
            string role_user = Check_Empty(textBox_RoleUser.Text.Trim());
            string system_privileges = Check_Empty(textBox_System.Text.Trim());
            
            if (string.IsNullOrEmpty(role_user) || string.IsNullOrEmpty(system_privileges))
            {
                MessageBox.Show("Role name or user name or system privileges cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string err = string.Empty;
                bool result = false;
                result = privileges.RevokePrivileges_System(ref err, system_privileges, role_user);
                ShowMessage(result, err);
            }
            load();

        }

        private void button_GrantObject_Click(object sender, EventArgs e)
        {
            string role_user = Check_Empty(textBox_RoleUser.Text.Trim());
            string object_name = Check_Empty(textBox_Object.Text.Trim());
            string column_name = Check_Empty(textBox_Col.Text.Trim());
            bool option = false;
            if (radioButton.Checked == true)
            {
                option = true;
            }

            List<string> privilegesArray = new List<string>();
            if (checkBox_Select.Checked)
            {
                privilegesArray.Add("SELECT");
            }
            if (checkBox_Insert.Checked)
            {
                privilegesArray.Add("INSERT");
            }
            if (checkBox_Update.Checked)
            {
                privilegesArray.Add("UPDATE");
            }
            if (checkBox_Delete.Checked)
            {
                privilegesArray.Add("DELETE");
            }
            if (privilegesArray.Count == 0)
            {
                MessageBox.Show("Please select at least one privilege.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (string.IsNullOrEmpty(role_user) || string.IsNullOrEmpty(object_name))
            {
                MessageBox.Show("Role name or user name or object privileges cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (string privilege in privilegesArray)
                {
                    string err = string.Empty;
                    bool result = privileges.GantPrivileges_Object(ref err, privilege, role_user, object_name, column_name, option);
                    ShowMessage(result, err);
                    if (!result)
                    {
                        break;
                    }
                }
            }
            load();
        }

        private void button_ObjectRevoke_Click(object sender, EventArgs e)
        {
            string role_user = Check_Empty(textBox_RoleUser.Text.Trim());
            string object_name = Check_Empty(textBox_Object.Text.Trim());
            string column_name = Check_Empty(textBox_Col.Text.Trim());

            List<string> privilegesArray = new List<string>();
            if (checkBox_Select.Checked)
            {
                privilegesArray.Add("SELECT");
            }
            if (checkBox_Insert.Checked)
            {
                privilegesArray.Add("INSERT");
            }
            if (checkBox_Update.Checked)
            {
                privilegesArray.Add("UPDATE");
            }
            if (checkBox_Delete.Checked)
            {
                privilegesArray.Add("DELETE");
            }
            if (privilegesArray.Count == 0)
            {
                MessageBox.Show("Please select at least one privilege.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(role_user) || string.IsNullOrEmpty(object_name))
            {
                MessageBox.Show("Role name or user name or object privileges cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (string privilege in privilegesArray)
                {
                    string err = string.Empty;
                    bool result = privileges.RevokePrivileges_Object(ref err, privilege, role_user, object_name, column_name);
                    ShowMessage(result, err);
                    if (!result)
                    {
                        break;
                    }
                }
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
