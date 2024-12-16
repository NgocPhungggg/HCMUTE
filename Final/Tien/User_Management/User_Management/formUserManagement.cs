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
        User usermgr = new User();
        bool create = false;

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
                DataTable dataTable_user = usermgr.GetAllUser();
                dataGridViewUserInformation.DataSource = dataTable_user;
                btnCreateUser.Enabled = true;
                btnAlterUser.Enabled = true;
                btnDeleteUser.Enabled = true;
                button_Back.Enabled = true;
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

            DataTable dataTable_system = usermgr.GetAllSystemPrivilege(username);
            dataGridViewSystemPrivilege.DataSource = dataTable_system;

            DataTable dataTable_object = usermgr.GetAllObjectPrivilege(username);
            dataGridViewObjectPrivilege.DataSource = dataTable_object;

            dataGridViewSystemPrivilege.Refresh();
            dataGridViewObjectPrivilege.Refresh();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            formCreateAlterUser frm = new formCreateAlterUser();
            frm.Add = true;
            frm.Show();
            this.Hide();

        }

        private void btnAlterUser_Click(object sender, EventArgs e)
        {
            int r = dataGridViewUserInformation.CurrentCell.RowIndex;

            string username = dataGridViewUserInformation.Rows[r].Cells[0].Value.ToString();
            formCreateAlterUser frm = new formCreateAlterUser();
            frm.Username = username;
            frm.ReadOnly = true;
            frm.Default_Tablespace = dataGridViewUserInformation.Rows[r].Cells[4].Value.ToString();
            frm.Temporary_Tablespace = dataGridViewUserInformation.Rows[r].Cells[5].Value.ToString();

            frm.Quota = dataGridViewUserInformation.Rows[r].Cells[6].Value == null || dataGridViewUserInformation.Rows[r].Cells[6].Value == DBNull.Value
                        ? -1
                        : Convert.ToInt32(dataGridViewUserInformation.Rows[r].Cells[6].Value);

            frm.Status = (dataGridViewUserInformation.Rows[r].Cells[1].Value.ToString().Equals("LOCKED") ? true : false);
            frm.Profile = dataGridViewUserInformation.Rows[r].Cells[7].Value.ToString();
            frm.Role = dataGridViewUserInformation.Rows[r].Cells[8].Value.ToString();

            frm.Show();
            this.Hide();

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int r = dataGridViewUserInformation.CurrentCell.RowIndex;

            string username = dataGridViewUserInformation.Rows[r].Cells[0].Value.ToString();

            DialogResult answer;
            answer = MessageBox.Show("Do you really want to delete user " + username + " ?", "Answer?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            string err = "";
            string error = "";

            if (answer == DialogResult.OK)
            {
                bool f = usermgr.DeleteUser(ref err, username);
                if (f)
                {
                    MessageBox.Show("Delete user successfully!");

                    formUserManagement frm_usermanagement = new formUserManagement();
                    frm_usermanagement.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: " + err);

                }
            }
            else
            {
                MessageBox.Show("Do not perform user deletion!");
            }

            bool i = usermgr.DeleteFromUserTable(ref error, username);
        }

    }
}
