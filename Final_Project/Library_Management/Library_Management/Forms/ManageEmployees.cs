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
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
        }
        Employees employees = new Employees();  
        public void LoadDataGridView(SqlCommand command)
        {
            EmployeeDGV.ReadOnly = true;
            EmployeeDGV.DataSource = employees.GetBooks(command);
            EmployeeDGV.AllowUserToAddRows = false;
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Employees ");
            LoadDataGridView(command);
        }

        private void EmployeeDGV_DoubleClick(object sender, EventArgs e)
        {
            txtMaNV.Text = EmployeeDGV.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = EmployeeDGV.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = EmployeeDGV.CurrentRow.Cells[2].Value.ToString();
            txtCMND.Text = EmployeeDGV.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = EmployeeDGV.CurrentRow.Cells[4].Value.ToString();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbFind.Text == "Mã nhân viên")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Employees WHERE EmployeeID = @id");
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtFind.Text;
                LoadDataGridView(command);
            }
            else 
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Employees WHERE EmployeeName = @name");
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtFind.Text;
                LoadDataGridView(command);
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.acc == "admin")
            {
                string ID = txtMaNV.Text;
                string Name = txtTenNV.Text;
                string Phone = txtSDT.Text;
                string IDCard = txtCMND.Text;
                string Address = txtDiaChi.Text;
                if (employees.InsertEmployees(ID, Name, Phone, IDCard, Address))
                {
                    MessageBox.Show("New Employee Added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Error", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SqlCommand command = new SqlCommand("SELECT * FROM Employees ");
                LoadDataGridView(command);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.acc == "admin")
            {
                string ID = txtMaNV.Text;
                string Name = txtTenNV.Text;
                string Phone = txtSDT.Text;
                string IDCard = txtCMND.Text;
                string Address = txtDiaChi.Text;
                if (employees.UpdateEmployees(ID, Name, Phone, IDCard, Address))
                {
                    MessageBox.Show("New Employee Edited", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SqlCommand command = new SqlCommand("SELECT * FROM Employees ");
                LoadDataGridView(command);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.acc == "admin")
            {
                string ID = txtMaNV.Text;

                if (employees.DeleteEmployees(ID))
                {
                    MessageBox.Show("New Employee Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Error", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SqlCommand command = new SqlCommand("SELECT * FROM Employees ");
                LoadDataGridView(command);
            }
        }
    }
}
