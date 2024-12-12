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

        public formRolePrivileges()
        {
            InitializeComponent();
        }

        private void formRolePrivileges_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable_roleprivileges = privileges.GetRolePrivilegsView();
                dataGridViewRolePrivileges.DataSource = dataTable_roleprivileges;

                DataTable dataTable_userrole = privileges.GetUserRoleAssignmentsView();
                dataGridViewUserRolePrivileges.DataSource = dataTable_userrole;

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

            DataTable dataTable_system = privileges.GetOneRolePrivileges(role_name);
            dataGridViewRolePrivileges.DataSource = dataTable_system;

            DataTable dataTable_object = privileges.GetOnePrivileges(username);
            dataGridViewUserRolePrivileges.DataSource = dataTable_object;

            dataGridViewRolePrivileges.Refresh();
            dataGridViewUserRolePrivileges.Refresh();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            formMenuAdmin menuAdmin = new formMenuAdmin();
            menuAdmin.Show();
            this.Hide();
        }

    }
}
