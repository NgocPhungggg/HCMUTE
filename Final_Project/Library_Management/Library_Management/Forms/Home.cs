using Library.Show;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button_docgia_Click(object sender, EventArgs e)
        {
            ManageReaders readers = new ManageReaders();
            readers.Show();
        }

        private void button_sach_Click(object sender, EventArgs e)
        {
            ManageBooks books = new ManageBooks();
            books.Show();
        }

        private void button_muon_Click(object sender, EventArgs e)
        {
            ManageBorrowBooks borrowbooks = new ManageBorrowBooks();
            borrowbooks.Show();
        }

        private void button_thongke_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.Show();
        }

        private void button_nhanvien_Click(object sender, EventArgs e)
        {
            ManageEmployees employees = new ManageEmployees();
            employees.Show();
        }

        private void button_doimk_Click(object sender, EventArgs e)
        {
            ChangePassword password = new ChangePassword();
            password.Show();
        }

        private void button_signout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
