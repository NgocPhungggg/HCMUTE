using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel
{
    public partial class Form_ForgetPassword : Form
    {
        public Form_ForgetPassword()
        {
            InitializeComponent();
        }
        int OTP;
        string Password;
        private void Button_FindEmail_Click(object sender, EventArgs e)
        {
            MyDatabase database = new MyDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT Username, PW " +
                                                "FROM Information I, Account A " +
                                                "WHERE I.ID = A.Username AND Mail = @mail", database.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = TextBox_Email.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Label_UserID.Text = "Your user ID: " + table.Rows[0]["Username"].ToString();
            }
            else
            {
                Label_UserID.Text = "Email does not exist or is incorrect";
            }
            Password = table.Rows[0]["PW"].ToString();
        }
        private void Button_Send_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            OTP = random.Next(100000, 999999);
            string body = "Please, Don't share this content to anyone, or you'll lose your account \nYour OTP code is: " + OTP.ToString();
            Send_To_Email(body);
            MessageBox.Show("OTP has sent to your Email");
        }
        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            if (int.Parse(TextBox_OTP.Text) == OTP)
            {
                string body = "Please, Don't share this content to anyone, or you'll lose your account \nYour password is: " + Password;
                Send_To_Email(body);
                MessageBox.Show("Your password has sent to your Email");
            }
            else
            {
                MessageBox.Show("OTP is incorrect");
            }
        }
        private void Send_To_Email(string body)
        {
            var FromAdress = new MailAddress("phungcao.1811@gmail.com");// mail dung de gui
            var ToAddress = new MailAddress(TextBox_Email.Text); //mail cap OTP;
            const string frompass = "djbbszoqyofbzjvy";
            const string subject = "OPT CODE";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(FromAdress.Address, frompass),
                Timeout = 200000
            };

            using (var message = new MailMessage(FromAdress, ToAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }


    }
}
