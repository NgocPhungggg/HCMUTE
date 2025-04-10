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
    public partial class ForReader : Form
    {
        public ForReader()
        {
            InitializeComponent();
        }
        ChangePW changePassword = new ChangePW();
        Books books = new Books();
        Borrow borrow = new Borrow();
        public void LoadBookDataGridView(SqlCommand command)
        {
            BookDGV.ReadOnly = true;
            BookDGV.DataSource = books.GetBooks(command);
            BookDGV.AllowUserToAddRows = false;
        }
        public void LoadBorrowDataGridView(SqlCommand command)
        {
            BookIssueDGV.ReadOnly = true;
            BookIssueDGV.DataSource = borrow.GetBooks(command);
            BookIssueDGV.AllowUserToAddRows = false;
        }
        private void ForReader_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Books ");
            LoadBookDataGridView(command);

            MyDatabase database = new MyDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table_info = new DataTable();
            SqlCommand command_info = new SqlCommand("SELECT * FROM Readers WHERE ReaderID = @id", database.getConnection);
            command_info.Parameters.Add("@id", SqlDbType.NVarChar).Value = GlobalVariables.acc;
            adapter.SelectCommand = command_info;
            adapter.Fill(table_info);

            txtMaDG.Text = table_info.Rows[0][0].ToString();
            txtTenDG.Text = table_info.Rows[0][1].ToString();
            txtSDT.Text = table_info.Rows[0][2].ToString();
            txtCMND.Text = table_info.Rows[0][3].ToString();
            txtDiaChi.Text = table_info.Rows[0][4].ToString();

            SqlCommand command_borrow = new SqlCommand("SELECT * FROM BorrowBooks WHERE ReaderID = @id ");
            command_borrow.Parameters.Add("@id", SqlDbType.NVarChar).Value = GlobalVariables.acc;
            LoadBorrowDataGridView(command_borrow);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbFind.Text == "Mã sách")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE BookID = @id");
                command.Parameters.Add("@id", SqlDbType.Int).Value = txtFind.Text;
                LoadBookDataGridView(command);
            }
            else if (cbFind.Text == "Tên sách")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE Title = @title");
                command.Parameters.Add("@title", SqlDbType.NVarChar).Value = txtFind.Text;
                LoadBookDataGridView(command);
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE Author = @author");
                command.Parameters.Add("@author", SqlDbType.NVarChar).Value = txtFind.Text;
                LoadBookDataGridView(command);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.pass == txtCurrentPass.Text)
            {
                if (txtNewPass.Text == txtConfirm.Text)
                {
                    if (changePassword.ChangePWReader(GlobalVariables.acc, txtNewPass.Text))
                    {
                        MessageBox.Show("Password Changed", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Old Password", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
