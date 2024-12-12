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
    public partial class formProfiles : Form
    {
        Profile profile = new Profile();
        public formProfiles()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            formMenuAdmin menuAdmin = new formMenuAdmin();
            menuAdmin.Show();
            this.Hide();
        }

        private void formProfiles_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable datatable_profile = profile.GetAllProfile();
                dataGridViewProfile.DataSource = datatable_profile;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}
