using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel
{
    public partial class Form_ChangePassword : Form
    {
        public Form_ChangePassword()
        {
            InitializeComponent();
        }
        Account account = new Account();
        string ID;
        public void GetMyID(string id)
        {
            ID = id;
        }
        private void Form_ChangePassword_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();

            tooltip.IsBalloon = true;
            tooltip.AutoPopDelay = 5000;    // xuất hiện trong 5s
            tooltip.InitialDelay = 500;     // 1s sau xuất hiện 
            tooltip.ReshowDelay = 500;    // mở lại sau 1s

            tooltip.ToolTipIcon = ToolTipIcon.Error;
            tooltip.ToolTipTitle = "Change Password";
            
            tooltip.SetToolTip(this.TextBox_NewPassword2, "Password must is as same as above");
        }
        private void Button_Change_Click(object sender, EventArgs e)
        {
            MyDatabase database = new MyDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Account WHERE Username = @user", database.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = ID;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows[0]["PW"].ToString() == TextBox_OldPassword.Text)
            {
                if (TextBox_NewPassword.Text == TextBox_NewPassword2.Text)
                {
                    if (account.ChangePassword(ID, TextBox_NewPassword.Text))
                    {
                        MessageBox.Show("Password changed", "Change password", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                        MessageBox.Show("Error", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Two new password do not match", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Old password is incorrect", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
