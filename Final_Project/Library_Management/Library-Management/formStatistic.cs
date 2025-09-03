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

namespace Library_Management
{
    public partial class formStatistic : Form
    {
        Category category = new Category();
        Author Author = new Author();
        TransactionService transaction = new TransactionService();
        LoanService loan = new LoanService();

        public formStatistic()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuStaff formmenustaff = new formMenuStaff();
            formmenustaff.Show();
            this.Hide();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            var result = category.GetBookCountPerCategory(); 

            DataTable dt = new DataTable();
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Số sách");

            foreach (var doc in result)
            {
                string author = doc["_id"].AsString;
                int total = doc["totalBooks"].AsInt32;
                dt.Rows.Add(author, total);
            }

            dgvStatistic.DataSource = dt;
        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            var result = Author.GetBookCountPerAuthor();

            DataTable dt = new DataTable();
            dt.Columns.Add("Tác giả");
            dt.Columns.Add("Số sách");

            foreach (var doc in result)
            {
                string author = doc["_id"].AsString;
                int total = doc["totalBooks"].AsInt32;
                dt.Rows.Add(author, total);
            }

            dgvStatistic.DataSource = dt;
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            var result = transaction.GetTransactionCountPerYear(); // gọi từ BLL

            DataTable dt = new DataTable();
            dt.Columns.Add("Năm");
            dt.Columns.Add("Số giao dịch");

            foreach (var doc in result)
            {
                int year = doc["_id"].ToInt32();
                int total = doc["totalTransactions"].AsInt32;
                dt.Rows.Add(year, total);
            }

            dgvStatistic.DataSource = dt;
        }
        private void buttonStatus_Click(object sender, EventArgs e)
        {
            var result = loan.GetLoanCountByStatus();

            DataTable dt = new DataTable();
            dt.Columns.Add("Trạng thái");
            dt.Columns.Add("Số lượng");

            foreach (var doc in result)
            {
                string status = doc["_id"].AsString;
                int total = doc["total"].AsInt32;
                dt.Rows.Add(status, total);
            }

            dgvStatistic.DataSource = dt;
        }
        private void buttonRevenue_Click(object sender, EventArgs e)
        {
            var result = transaction.GetTotalPaymentPerYear();

            DataTable dt = new DataTable();
            dt.Columns.Add("Năm");
            dt.Columns.Add("Tổng thanh toán");

            foreach (var doc in result)
            {
                int year = doc["_id"].ToInt32();
                double total = doc["totalPaid"].ToDouble();
                dt.Rows.Add(year, total);
            }

            dgvStatistic.DataSource = dt;
        }

    }
}
