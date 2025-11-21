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
    public partial class ManageBorrowBooks : Form
    {
        public ManageBorrowBooks()
        {
            InitializeComponent();
        }
        Borrow borrow = new Borrow();
        public void LoadDataGridView(SqlCommand command)
        {
            BookIssueDGV.ReadOnly = true;
            BookIssueDGV.DataSource = borrow.GetBooks(command);
            BookIssueDGV.AllowUserToAddRows = false;
        }
        private void ManageBorrowBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_ManagementDataSet.Readers' table. You can move, or remove it, as needed.
            this.readersTableAdapter.Fill(this.library_ManagementDataSet.Readers);
            // TODO: This line of code loads data into the 'library_ManagementDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.library_ManagementDataSet.Books);
            SqlCommand command = new SqlCommand("SELECT * FROM BorrowBooks ");
            LoadDataGridView(command);
        }
        private void BookIssueDGV_DoubleClick(object sender, EventArgs e)
        {
            txtMaMuon.Text = BookIssueDGV.CurrentRow.Cells[0].Value.ToString();
            cbMaDG.Text = BookIssueDGV.CurrentRow.Cells[1].Value.ToString();
            cbMaSach.Text = BookIssueDGV.CurrentRow.Cells[2].Value.ToString();
            ngaymuon.Text = BookIssueDGV.CurrentRow.Cells[3].Value.ToString();
            ngaytra.Text = BookIssueDGV.CurrentRow.Cells[4].Value.ToString();
            txtTienphat.Text = BookIssueDGV.CurrentRow.Cells[5].Value.ToString();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbFind.Text == "Mã phiếu mượn")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Readers WHERE BorrowID = @id");
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtFind.Text;
                LoadDataGridView(command);
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM BorrowBooks WHERE ReaderID = @id");
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = txtFind.Text;
                LoadDataGridView(command);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string BorrowID = txtMaMuon.Text;
            string ReaderID = cbMaDG.Text;
            int BookID = int.Parse(cbMaSach.Text);
            DateTime DateBorrow = ngaymuon.Value;

            if (borrow.InsertBorrow(BorrowID, ReaderID, BookID, DateBorrow))
            {
                MessageBox.Show("New Borrowing Book Added", "Add Borrowing Book", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Add Borrowing Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM BorrowBooks ");
            LoadDataGridView(command);
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            string BorrowID = txtMaMuon.Text;
            DateTime ReturnBorrow = ngaytra.Value;
            int namtre = ngaytra.Value.Year - ngaymuon.Value.Year;
            int thangtre = ngaytra.Value.Month - ngaymuon.Value.Month;
            int Fee = 0;
            if (namtre > 0 || thangtre > 6 )
                Fee = (namtre * 12 + thangtre) * 20000;

            if (borrow.CompletteBorrow(BorrowID, ReturnBorrow, Fee))
            {
                MessageBox.Show("New Borrowing Book Returned", "Return Borrowing Book", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Return Borrowing Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM BorrowBooks ");
            LoadDataGridView(command);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string BorrowID = txtMaMuon.Text;
            string ReaderID = cbMaDG.Text;
            int BookID = int.Parse(cbMaSach.Text);
            DateTime DateBorrow = ngaymuon.Value;
            DateTime ReturnBorrow = ngaytra.Value;
            int namtre = ngaytra.Value.Year - ngaymuon.Value.Year;
            int thangtre = ngaytra.Value.Month - ngaymuon.Value.Month;
            int Fee = 0;
            if (namtre > 0 || thangtre > 6)
                Fee = (namtre * 12 + thangtre)*20000;

            if (borrow.UpdateBorrow(BorrowID, ReaderID, BookID, DateBorrow, ReturnBorrow, Fee))
            {
                MessageBox.Show("New Borrowing Book Edited", "Edit Borrowing Book", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Edit Borrowing Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM BorrowBooks ");
            LoadDataGridView(command);
        }
    }
}
