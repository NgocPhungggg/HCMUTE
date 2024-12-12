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
    public partial class formPrivileges : Form
    {
        Privileges privileges = new Privileges();

        public formPrivileges()
        {
            InitializeComponent();
        }

        private void formPrivileges_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable_roleprivileges = privileges.GetSystemPrivilegesView();
                dataGridViewSystemPrivileges.DataSource = dataTable_roleprivileges;

                DataTable dataTable_userrole = privileges.GetObjectPrivilegesView();
                dataGridViewObjectPrivileges.DataSource = dataTable_userrole;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewSystemPrivileges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewSystemPrivileges.CurrentCell.RowIndex;
            string role_name = dataGridViewSystemPrivileges.Rows[r].Cells[0].Value.ToString();

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

            DataTable dataTable_system = privileges.GetOneSystemPrivileges(role_name);
            dataGridViewSystemPrivileges.DataSource = dataTable_system;

            DataTable dataTable_object = privileges.GetOneObjectPrivileges(role_name);
            dataGridViewObjectPrivileges.DataSource = dataTable_object;

            dataGridViewSystemPrivileges.Refresh();
            dataGridViewObjectPrivileges.Refresh();
        }
        private void button_Back_Click(object sender, EventArgs e)
        {
            formMenuAdmin menuAdmin = new formMenuAdmin();
            menuAdmin.Show();
            this.Hide();
        }
    }
}
