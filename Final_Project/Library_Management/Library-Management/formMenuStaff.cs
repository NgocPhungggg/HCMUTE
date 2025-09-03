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
    public partial class formMenuStaff : Form
    {
        public formMenuStaff()
        {
            InitializeComponent();
        }
        
        private void buttonInfomation_Click(object sender, EventArgs e)
        {
            formInformation forminformation = new formInformation();
            if (forminformation.LoadDataToGrid() == true)
            {
                forminformation.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Không tìm thấy thông tin của {Session.Username}");
            }
        }
        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            formTransactions formtransactions = new formTransactions();
            formtransactions.Show();
            this.Hide();
        }

        private void buttonManageReader_Click(object sender, EventArgs e)
        {
            formManageReader formmanageReader = new formManageReader();
            formmanageReader.Show();
            this.Hide();
        }

        private void buttonManageBook_Click(object sender, EventArgs e)
        {
            formManageBook formmanagebook = new formManageBook();
            formmanagebook.Show();
            this.Hide();
        }

        private void buttonManageAuthor_Click(object sender, EventArgs e)
        {
            formManageAuthor formmanageauthor = new formManageAuthor();
            formmanageauthor.Show();
            this.Hide();
        }

        private void buttonManageCategory_Click(object sender, EventArgs e)
        {
            formManageCategory formmanagecategory = new formManageCategory();
            formmanagecategory.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            formLogin formlogin = new formLogin();
            formlogin.Show();
            this.Hide();
        }
        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            formStatistic formstatistic = new formStatistic();
            formstatistic.Show();
            this.Hide();
        }
        private void buttonLoan_Click(object sender, EventArgs e)
        {
            formLoans formloans = new formLoans();
            formloans.Show();
            this.Hide();
        }


    }
}
