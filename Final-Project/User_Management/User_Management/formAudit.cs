using Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace User_Management
{
    public partial class formAudit : Form
    {

        Audit auditmgr = new Audit();
        DataTable dtAudit = new DataTable();


        public formAudit()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {

                dtAudit = new DataTable();
                dtAudit.Clear();
                dtAudit = auditmgr.GetAllAudit();

                dgvAudit.DataSource = dtAudit;
                dgvAudit.AutoResizeColumns();
            }
            //catch (SqlException)
            //{
            //   MessageBox.Show("Error: Unable to retrieve the contents of the USER_PROFILE_INFO table!");
            //}
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvAudit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvAudit.CurrentCell.RowIndex;
            usertextBox.Text = dgvAudit.Rows[r].Cells[0].Value.ToString();
            timetextBox.Text = dgvAudit.Rows[r].Cells[1].Value.ToString();
            ObjtextBox.Text = dgvAudit.Rows[r].Cells[2].Value.ToString();
            ActiontextBox.Text = dgvAudit.Rows[r].Cells[3].Value.ToString();
        }

        private void FormAudit_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            formMenuAdmin menuAdmin = new formMenuAdmin();
            menuAdmin.Show();
            this.Hide();
        }
    }
}
