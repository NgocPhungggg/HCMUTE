using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Forms
{
    public partial class ManageReaders : Form
    {
        public ManageReaders()
        {
            InitializeComponent();
        }
        Readers readers = new Readers();
        public void LoadDataGridView(SqlCommand command)
        {
            ReaderDGV.ReadOnly = true;
            ReaderDGV.DataSource = readers.GetReaders(command);
            ReaderDGV.AllowUserToAddRows = false;
        }
        private void ManageReaders_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Readers ");
            LoadDataGridView(command);
        }
        private void ReaderDGV_DoubleClick(object sender, EventArgs e)
        {
            txtMaDG.Text = ReaderDGV.CurrentRow.Cells[0].Value.ToString();
            txtTenDG.Text = ReaderDGV.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = ReaderDGV.CurrentRow.Cells[2].Value.ToString();
            txtCMND.Text = ReaderDGV.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = ReaderDGV.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbFind.Text == "Mã độc giả")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Readers WHERE ReaderID = @id");
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtFind.Text;
                LoadDataGridView(command);
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Readers WHERE ReaderName = @name");
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtFind.Text;
                LoadDataGridView(command);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ID = txtMaDG.Text;
            string Name = txtTenDG.Text;
            string Phone = txtSDT.Text;
            string IDCard = txtCMND.Text;
            string Address = txtDiaChi.Text;
            if (readers.InsertReaders(ID, Name, Phone, IDCard, Address))
            {
                MessageBox.Show("New Reader Added", "Add Reader", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Add Reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Readers ");
            LoadDataGridView(command);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ID = txtMaDG.Text;
            string Name = txtTenDG.Text;
            string Phone = txtSDT.Text;
            string IDCard = txtCMND.Text;
            string Address = txtDiaChi.Text;
            if (readers.UpdateReaders(ID, Name, Phone, IDCard, Address))
            {
                MessageBox.Show("New Reader Edited", "Edit Reader", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Edit Reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Readers ");
            LoadDataGridView(command);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ID = txtMaDG.Text;

            if (readers.DeleteReaders(ID))
            {
                MessageBox.Show("New Reader Deleted", "Delete Reader", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Delete Reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Readers ");
            LoadDataGridView(command);
        }
    }
}
