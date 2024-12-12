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
    public partial class formUserManagement : Form
    {
        User user = new User();

        public formUserManagement()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            formMenuAdmin menuAdmin = new formMenuAdmin();
            menuAdmin.Show();
            this.Hide();
        }

        private void formUserManagement_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable_user = user.GetAllUser();
                dataGridViewUserInformation.DataSource = dataTable_user;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewUserInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewUserInformation.CurrentCell.RowIndex;
            string username = dataGridViewUserInformation.Rows[r].Cells[0].Value.ToString();

            DataTable dataTable_system = user.GetAllSystemPrivilege(username);
            dataGridViewSystemPrivilege.DataSource = dataTable_system;

            DataTable dataTable_object = user.GetAllObjectPrivilege(username);
            dataGridViewObjectPrivilege.DataSource = dataTable_object;

            dataGridViewSystemPrivilege.Refresh();
            dataGridViewObjectPrivilege.Refresh();
        }


    }
}
