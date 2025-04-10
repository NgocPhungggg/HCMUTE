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
using static Management_Hotel.Global;

namespace Management_Hotel
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();

            tooltip.IsBalloon = true;
            tooltip.AutoPopDelay = 5000;    // xuất hiện trong 5s
            tooltip.InitialDelay = 500;     // 1s sau xuất hiện 
            tooltip.ReshowDelay = 500;    // mở lại sau 1s

            tooltip.ToolTipIcon = ToolTipIcon.Error;
            tooltip.ToolTipTitle = "Login";

            tooltip.SetToolTip(this.TextBox_Username, "Username is not blank or not A->Z");
        }       
        private void TextBox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void Label_ForgetPassword_Click(object sender, EventArgs e)
        {
            Form_ForgetPassword forgetpassword = new Form_ForgetPassword();
            forgetpassword.ShowDialog();
        }
        private void Button_Login_Click(object sender, EventArgs e)
        {
            MyDatabase database = new MyDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Account A, Employee E " +
                                            "WHERE A.Username = E.ID AND Username = @user AND PW = @pw", database.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = TextBox_Username.Text;
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = TextBox_Password.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Position = "NULL";
            if (table.Rows.Count > 0)
                Position = table.Rows[0]["Position"].ToString();

            if (RadioButton_Manager.Checked == true &&
                TextBox_Username.Text == "123456" &&
                TextBox_Password.Text == "123456")
            {
                GlobalVariables.acc = "123456";
                Form_MenuManager manager = new Form_MenuManager();
                manager.Show(this);
            }
            else if (RadioButton_Receptionist.Checked == true && Position == "Receptionist")
            {
                Form_MenuReceptionist receptionist = new Form_MenuReceptionist();
                GlobalVariables.acc = TextBox_Username.Text.Trim();
                receptionist.GetReceptionistID(TextBox_Username.Text);
                receptionist.Show(this);
            }
            else if (RadioButton_Janitor.Checked == true && Position == "Janitor")
            {
                Form_MenuJanitor janitor = new Form_MenuJanitor();
                GlobalVariables.acc = TextBox_Username.Text.Trim();
                janitor.GetJanitorID(TextBox_Username.Text);
                janitor.Show(this);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
