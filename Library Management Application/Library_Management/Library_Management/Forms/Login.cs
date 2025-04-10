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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Management.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            MyDatabase database = new MyDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table_employees = new DataTable();
            SqlCommand command_employees = new SqlCommand("SELECT * FROM Employees WHERE Username = @user AND Password = @pw", database.getConnection);
            command_employees.Parameters.Add("@user", SqlDbType.VarChar).Value = TextBox_Username.Text;
            command_employees.Parameters.Add("@pw", SqlDbType.VarChar).Value = TextBox_Password.Text;
            adapter.SelectCommand = command_employees;
            adapter.Fill(table_employees);

            DataTable table_readers = new DataTable();
            SqlCommand command_readers = new SqlCommand("SELECT * FROM Readers WHERE Username = @user AND Password = @pw", database.getConnection);
            command_readers.Parameters.Add("@user", SqlDbType.VarChar).Value = TextBox_Username.Text;
            command_readers.Parameters.Add("@pw", SqlDbType.VarChar).Value = TextBox_Password.Text;
            adapter.SelectCommand = command_readers;
            adapter.Fill(table_readers);

            if (table_employees.Rows.Count > 0)
            {
                GlobalVariables.acc = TextBox_Username.Text;
                GlobalVariables.pass = TextBox_Password.Text;
                Home adminhone = new Home();
                adminhone.Show();
            }
            else if (table_readers.Rows.Count > 0)
            {
                GlobalVariables.acc = TextBox_Username.Text;
                GlobalVariables.pass = TextBox_Password.Text;
                ForReader readerhome = new ForReader();
                readerhome.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBox_Username.Text = "";
                TextBox_Username.Text = "";
            }
        }
    }
}
