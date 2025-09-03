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
    public partial class formMenuAdmin : Form
    {
        
        public formMenuAdmin()
        {
            InitializeComponent();
        }

        private void buttonManageStaff_Click(object sender, EventArgs e)
        {
            formManageStaff formmanageStaff = new formManageStaff();
            formmanageStaff.Show();
            this.Hide();
        }
        private void buttonManageReader_Click(object sender, EventArgs e)
        {
            formManageReader formmanageReader = new formManageReader();
            formmanageReader.Show();
            this.Hide();
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            formTransactions formtransactions = new formTransactions();
            formtransactions.Show();
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
    }
}
