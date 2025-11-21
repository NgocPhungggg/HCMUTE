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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            MyDatabase database = new MyDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table_books1 = new DataTable();
            SqlCommand command_books1 = new SqlCommand("SELECT SUM(Quantity) FROM Books", database.getConnection);
            adapter.SelectCommand = command_books1;
            adapter.Fill(table_books1);
            lblTotalBook.Text = table_books1.Rows[0][0].ToString();

            DataTable table_books2 = new DataTable();
            SqlCommand command_books2 = new SqlCommand("SELECT * FROM BorrowBooks WHERE TienPhat > 0", database.getConnection);
            adapter.SelectCommand = command_books2;
            adapter.Fill(table_books2);
            lblSachQuaHan.Text = table_books2.Rows.Count.ToString();


            DataTable table_readers = new DataTable();
            SqlCommand commande_readers = new SqlCommand("SELECT * FROM Readers", database.getConnection);
            adapter.SelectCommand = commande_readers;
            adapter.Fill(table_readers);
            lblTotalReader.Text = table_readers.Rows.Count.ToString();

            DataTable table_readers1 = new DataTable();
            SqlCommand commande_readers1 = new SqlCommand("SELECT * FROM BorrowBooks", database.getConnection);
            adapter.SelectCommand = commande_readers1;
            adapter.Fill(table_readers1);
            lblTotalBorrow.Text = table_readers1.Rows.Count.ToString();

            DataTable table_readers2 = new DataTable();
            SqlCommand commande_readers2 = new SqlCommand("SELECT * FROM BorrowBooks", database.getConnection);
            adapter.SelectCommand = commande_readers2;
            adapter.Fill(table_readers2);
            lblTotalBrBook.Text = table_readers2.Rows.Count.ToString();

        }
    }
}
