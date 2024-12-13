using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace User_Management
{
    public partial class formProfiles : Form
    {
        Profile profilemgr = null;
        DataTable dtProfile = null;
        DataTable dtInfoProfile = null;
        DataTable dtListProfile = null;

        bool Them = false;


        public formProfiles()
        {
            InitializeComponent();
            profilemgr = new Profile();
        }

        void LoadData()
        {
            try
            {

                dtListProfile = new DataTable();
                dtListProfile.Clear();
                dtListProfile = profilemgr.GetAllProfile();

                dgvListProfile.DataSource = dtListProfile;
                dgvListProfile.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Error: Unable to retrieve the contents of the USER_PROFILE_INFO table!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = dgvListProfile.CurrentCell.RowIndex;

            string profile = dgvListProfile.Rows[r].Cells[0].Value.ToString();


            dtInfoProfile = new DataTable();
            dtInfoProfile.Clear();
            dtInfoProfile = profilemgr.GetInfoProfile(profile);

            dgvInfoProfile.DataSource = dtInfoProfile;
            dgvInfoProfile.AutoResizeColumns();

            dtProfile = new DataTable();
            dtProfile.Clear();
            dtProfile = profilemgr.GetUserProfile(profile);

            dgvUserProfile.DataSource = dtProfile;
            dgvUserProfile.AutoResizeColumns();


            dgvUserProfile.Refresh();
            dgvUserProfile.Refresh();
        }


        private void button_Back_Click(object sender, EventArgs e)
        {
            formMenuAdmin menuAdmin = new formMenuAdmin();
            menuAdmin.Show();
            this.Hide();
        }

        private void formProfiles_Load(object sender, EventArgs e)
        {
            LoadData();

        }


        private void Addbutton_Click(object sender, EventArgs e)
        {
            Them = true;

            txtprofile.Text = "";
            SestextBox.Text = "";
            ContextBox.Text = "";
            IdletextBox.Text = "";

            SesDefaultradioButton.Checked = true;
            ConDefaultradioButton.Checked = true;
            IdleDefaultradioButton.Checked = true;
            saveButton.Enabled = true;
            huyButton.Enabled = true;

            removeButton.Enabled = false;
            editButton.Enabled = false;
            addButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                string err = "";
                string profile_name = txtprofile.Text;
                string sessions_per_user = "";
                string connect_time = "";
                string idle_time = "";

                if (SesDefaultradioButton.Checked)
                {
                    sessions_per_user = "DEFAULT";
                }
                else
                    if (SesUnlimitradioButton.Checked)
                {
                    sessions_per_user = "UNLIMITED";
                }
                else
                    sessions_per_user = SestextBox.Text;



                if (ConDefaultradioButton.Checked)
                {
                    connect_time = "DEFAULT";
                }
                else
                    if (ConUnlimitradioButton.Checked)
                {
                    connect_time = "UNLIMITED";
                }
                else
                    connect_time = ContextBox.Text;


                if (IdleDefaultradioButton.Checked)
                {
                    idle_time = "DEFAULT";
                }
                else
                    if (IdleUnlimitradioButton.Checked)
                {
                    idle_time = "UNLIMITED";
                }
                else
                    idle_time = IdletextBox.Text;


                bool f = profilemgr.CreateProfile(ref err, profile_name, sessions_per_user, connect_time, idle_time);
                if (f)
                {
                    LoadData();
                    MessageBox.Show("Thêm Profile thành công");
                }
                else
                {
                    MessageBox.Show("Thêm Profile không thành công\n" + "Lỗi:" + err);
                }
            }
            else
            {
                string err = "";
                string profile_name = txtprofile.Text;
                string sessions_per_user = "";
                string connect_time = "";
                string idle_time = "";

                if (SesDefaultradioButton.Checked)
                {
                    sessions_per_user = "DEFAULT";
                }
                else
                    if (SesUnlimitradioButton.Checked)
                {
                    sessions_per_user = "UNLIMITED";
                }
                else
                    sessions_per_user = SestextBox.Text;



                if (ConDefaultradioButton.Checked)
                {
                    connect_time = "DEFAULT";
                }
                else
                    if (ConUnlimitradioButton.Checked)
                {
                    connect_time = "UNLIMITED";
                }
                else
                    connect_time = ContextBox.Text;


                if (IdleDefaultradioButton.Checked)
                {
                    idle_time = "DEFAULT";
                }
                else
                    if (IdleUnlimitradioButton.Checked)
                {
                    idle_time = "UNLIMITED";
                }
                else
                    idle_time = IdletextBox.Text;


                bool f = profilemgr.UpdateProfile(ref err, profile_name, sessions_per_user, connect_time, idle_time);
                if (f)
                {
                    LoadData();
                    MessageBox.Show("Thay đổi Profile thành công");
                }
                else
                {
                    MessageBox.Show("Thay đổi Profile không thành công\n" + "Lỗi:" + err);
                }
            }
        }

        private void SesDefaultradioButton_CheckedChanged(object sender, EventArgs e)
        {
            SestextBox.Clear();
        }

        private void SesUnlimitradioButton_CheckedChanged(object sender, EventArgs e)
        {
            SestextBox.Clear();
        }

        private void SestextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SestextBox.Text))
            {
                // Vô hiệu hóa các radio buttons
                SesDefaultradioButton.Checked = false;
                SesUnlimitradioButton.Checked = false;
            }
        }

        private void ContextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ContextBox.Text))
            {
                // Vô hiệu hóa các radio buttons
                ConDefaultradioButton.Checked = false;
                ConUnlimitradioButton.Checked = false;
            }
        }

        private void IdletextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdletextBox.Text))
            {
                // Vô hiệu hóa các radio buttons
                IdleDefaultradioButton.Checked = false;
                IdleUnlimitradioButton.Checked = false;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Them = false;

            Them = false;

            string session_per_user = "";
            string connect_time = "";
            string idle_time = "";
            // Duyệt qua từng hàng trong DataGridView
            foreach (DataGridViewRow row in dgvInfoProfile.Rows)
            {
                // Lấy giá trị của cột RESOURCENAME
                string resourceName = row.Cells["RESOURCE_NAME"].Value?.ToString();

                // Kiểm tra giá trị của RESOURCENAME và gán giá trị tương ứng cho TextBox
                if (resourceName == "SESSIONS_PER_USER")
                {
                    session_per_user = row.Cells["LIMIT"].Value?.ToString();
                }
                else if (resourceName == "CONNECT_TIME")
                {
                    connect_time = row.Cells["LIMIT"].Value?.ToString();
                }
                else if (resourceName == "IDLE_TIME")
                {
                    idle_time = row.Cells["LIMIT"].Value?.ToString();
                }
            }



            if (session_per_user == "DEFAULT")
            {
                SesDefaultradioButton.Checked = true;
            }
            else
                if (session_per_user == "UNLIMITED")
            {
                SesUnlimitradioButton.Checked = true;
            }
            else
            {
                SestextBox.Text = session_per_user;
            }

            if (connect_time == "DEFAULT")
            {
                ConDefaultradioButton.Checked = true;
            }
            else
               if (connect_time == "UNLIMITED")
            {
                ConUnlimitradioButton.Checked = true;
            }
            else
            {
                ContextBox.Text = connect_time;
            }

            if (idle_time == "DEFAULT")
            {
                IdleDefaultradioButton.Checked = true;
            }
            else
               if (idle_time == "UNLIMITED")
            {
                IdleUnlimitradioButton.Checked = true;
            }
            else
            {
                IdletextBox.Text = idle_time;
            }

          
            saveButton.Enabled = true;
            huyButton.Enabled = true;

            removeButton.Enabled = false;
            editButton.Enabled = false; 
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int r = dgvListProfile.CurrentCell.RowIndex;
            string strProfile_id = dgvListProfile.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            string err = "";

            if (traloi == DialogResult.OK)
            {
                bool f = profilemgr.DeleteProfile(ref err, strProfile_id);
                if (f)
                {
                    LoadData();
                    MessageBox.Show("Đã xóa Profile thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi: " + err);

                }
            }
            else
            {
                MessageBox.Show("Không thực hiện xóa Profile!");
            }
        }

        private void Reloadbutton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            txtprofile.Text = "";
            SestextBox.Text = "";
            ContextBox.Text = "";
            IdletextBox.Text = "";


            saveButton.Enabled = false;
            huyButton.Enabled = false;

            removeButton.Enabled = true;
            editButton.Enabled = true;
            addButton.Enabled = true;
        }

        private void dgvInfoProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvListProfile.CurrentCell.RowIndex;
            txtprofile.Text = dgvListProfile.Rows[r].Cells[0].Value.ToString();


        }

        private void ConDefaultradioButton_CheckedChanged(object sender, EventArgs e)
        {
            ContextBox.Clear();
        }

        private void ConUnlimitradioButton_CheckedChanged(object sender, EventArgs e)
        {
            ContextBox.Clear();
        }

        private void IdleDefaultradioButton_CheckedChanged(object sender, EventArgs e)
        {
            IdletextBox.Clear();
        }

        private void IdleUnlimitradioButton_CheckedChanged(object sender, EventArgs e)
        {
            IdletextBox.Clear();
        }
    }
}
