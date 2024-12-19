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
    public partial class formCreateAlterUser : Form
    {
        Profile profilemgr = null;
        User usermgr = null;
        Role rolemgr = null;
        DataTable dtProfile = null;
        DataTable dtDefautTablespaceUser = null;
        DataTable dtTemporaryTablespaceUser = null;
        DataTable dtRole = null;
        bool createUser = false;

        public string Username
        {
            set { tbxUsername.Text = value; }
        }

        public bool ReadOnly
        {
            set { tbxUsername.ReadOnly = value; }
        }

        public bool Add
        {
            set { createUser = value; }
        }

        public string Default_Tablespace
        {
            set { cbxDefautTablespace.Text = value; }
        }

        public string Temporary_Tablespace
        {
            set { cbxTemporaryTablespace.Text = value; }
        }

        public string Profile
        {
            set { cbxProfile.Text = value; }
        }

        public string Role
        {
            set { cbxRole.Text = value; }
        }

        public int Quota
        {
            set { numericUpDownQuota.Value = value; }
        }

        public bool Status
        {
            set { ckbxAccountStatus.Checked = value; }
        }

        public formCreateAlterUser()
        {
            InitializeComponent();
            profilemgr = new Profile();
            usermgr = new User();
            rolemgr = new Role();
        }


        void LoadData()
        {
            dtProfile = new DataTable();
            dtDefautTablespaceUser = new DataTable();
            dtTemporaryTablespaceUser = new DataTable();
            dtRole = new DataTable();

            dtProfile = profilemgr.GetAllProfile();
            dtDefautTablespaceUser = usermgr.GetAllDefaultTablespace();
            dtTemporaryTablespaceUser = usermgr.GetAllTemporaryTablespace();
            dtRole = rolemgr.GetAllRole();

            if (dtProfile.Rows.Count > 0)
            {
                foreach (DataRow row in dtProfile.Rows)
                {
                    cbxProfile.Items.Add(row["PROFILE"].ToString());
                }
            }

            if (dtDefautTablespaceUser.Rows.Count > 0)
            {
                foreach (DataRow row in dtDefautTablespaceUser.Rows)
                {
                    cbxDefautTablespace.Items.Add(row["TABLESPACE_NAME"].ToString());
                }
            }

            if (dtTemporaryTablespaceUser.Rows.Count > 0)
            {
                foreach (DataRow row in dtTemporaryTablespaceUser.Rows)
                {
                    cbxTemporaryTablespace.Items.Add(row["TABLESPACE_NAME"].ToString());
                }
            }

            if (dtRole.Rows.Count > 0)
            {
                foreach (DataRow row in dtRole.Rows)
                {
                    cbxRole.Items.Add(row["ROLE"].ToString());
                }
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            formUserManagement frm_usermanagement = new formUserManagement();
            frm_usermanagement.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (createUser == true)
            {
                string err = "";
                string error = "";
                string accountStatus = "UNLOCK";
                if (ckbxAccountStatus.Checked)
                {
                    accountStatus = "LOCK";
                }

                bool f = usermgr.CreateUser(ref err, tbxUsername.Text?.ToString() ?? null, tbxPassword.Text?.ToString() ?? null,
                    cbxDefautTablespace.SelectedItem?.ToString() ?? null, cbxTemporaryTablespace.SelectedItem?.ToString() ?? null,
                    (numericUpDownQuota.Value != -1) ? numericUpDownQuota.Value.ToString() + "M" : null, accountStatus,
                    cbxProfile.SelectedItem?.ToString() ?? null, cbxRole.SelectedItem?.ToString() ?? null);
                bool i = usermgr.InsertIntoUserTable(ref error, tbxUsername.Text?.ToString().ToUpper() ?? null, tbxPassword.Text?.ToString() ?? null);

                if (f)
                {
                    MessageBox.Show("Create user successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error:" + err);
                }


            }
            else
            {
                string err = "";
                string error = "";
                string accountStatus = "UNLOCK";
                if (ckbxAccountStatus.Checked)
                {
                    accountStatus = "LOCK";
                }

                bool f = usermgr.UpdateUser(ref err, tbxUsername.Text?.ToString() ?? null, tbxPassword.Text?.ToString() ?? null,
                    cbxDefautTablespace.SelectedItem?.ToString() ?? null, cbxTemporaryTablespace.SelectedItem?.ToString() ?? null,
                    (numericUpDownQuota.Value != -1) ? numericUpDownQuota.Value.ToString() + "M" : null, accountStatus,
                    cbxProfile.SelectedItem?.ToString() ?? null, cbxRole.SelectedItem?.ToString() ?? null);
                bool i = usermgr.UpdateUserTable(ref error, tbxUsername.Text?.ToString() ?? null, tbxPassword.Text?.ToString() ?? null);

                if (f)
                {
                    MessageBox.Show("Update user account successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error:" + err);
                }

            }

            formUserManagement frm_usermanagement = new formUserManagement();
            frm_usermanagement.Show();
            this.Close();
        }

        private void formCreateAlterUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
