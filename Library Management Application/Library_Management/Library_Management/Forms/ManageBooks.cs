using Library_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Library.Show
{
    public partial class ManageBooks : Form
    {
        public ManageBooks()
        {
            InitializeComponent();
        }
        Books books = new Books();

        public void LoadDataGridView(SqlCommand command)
        {
            BookDGV.ReadOnly = true;
            BookDGV.DataSource = books.GetBooks(command);
            BookDGV.AllowUserToAddRows = false;
        }
        private void ManageBooks_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Books ");
            LoadDataGridView(command);
        }
        private void BookDGV_DoubleClick(object sender, EventArgs e)
        {
            txtMaSach.Text = BookDGV.CurrentRow.Cells[0].Value.ToString();
            txtTenSach.Text = BookDGV.CurrentRow.Cells[1].Value.ToString();
            txtTenTG.Text = BookDGV.CurrentRow.Cells[2].Value.ToString();
            txtNamXB.Text = BookDGV.CurrentRow.Cells[3].Value.ToString();
            cbTheLoai.Text = BookDGV.CurrentRow.Cells[4].Value.ToString();
            txtSL.Text = BookDGV.CurrentRow.Cells[5].Value.ToString();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbFind.Text == "Mã sách")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE BookID = @id");
                command.Parameters.Add("@id", SqlDbType.Int).Value = txtFind.Text;
                LoadDataGridView(command);
            }
            else if (cbFind.Text == "Tên sách")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE Title = @title");
                command.Parameters.Add("@title", SqlDbType.NVarChar).Value = txtFind.Text;
                LoadDataGridView(command);
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE Author = @author");
                command.Parameters.Add("@author", SqlDbType.NVarChar).Value = txtFind.Text;
                LoadDataGridView(command);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtMaSach.Text);
            string Title = txtTenSach.Text;
            string Author = txtMaSach.Text;
            int Year = int.Parse(txtNamXB.Text);
            string Genre = cbTheLoai.Text;
            int Quantity = int.Parse(txtSL.Text);
            if (books.InsertBooks(ID, Title, Author, Year, Genre, Quantity))
            { 
                MessageBox.Show("New Book Added", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Books ");
            LoadDataGridView(command);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtMaSach.Text);
            string Title = txtTenSach.Text;
            string Author = txtTenTG.Text;
            int Year = int.Parse(txtNamXB.Text);
            string Genre = cbTheLoai.Text;
            int Quantity = int.Parse(txtSL.Text);
            if (books.UpdateBooks(ID, Title, Author, Year, Genre, Quantity))
            {
                MessageBox.Show("New Book Edit", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Books ");
            LoadDataGridView(command);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtMaSach.Text);
            if (books.DeleteBooks(ID))
            {
                MessageBox.Show("New Book Deleted", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Books ");
            LoadDataGridView(command);
        }
    }
}
