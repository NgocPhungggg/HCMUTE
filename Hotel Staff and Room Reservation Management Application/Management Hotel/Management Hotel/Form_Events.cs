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
    public partial class Form_Events : Form
    {
        public Form_Events()
        {
            InitializeComponent();
        }
        private void Button_Send_Click(object sender, EventArgs e)
        {
            MyDatabase database = new MyDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT Mail FROM Information WHERE ID NOT IN (SELECT ID FROM Employee)", database.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string email = table.Rows[i]["Mail"].ToString();
                Send_To_Email(email);
            }
            MessageBox.Show("Sự kiện đã gửi đến khách hàng của bạn", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        private void Send_To_Email(string Email)
        {
            var FromAdress = new MailAddress("phungcao.1811@gmail.com");// mail dung de gui
            var ToAddress = new MailAddress(Email); //mail cap OTP;
            const string frompass = "djbbszoqyofbzjvy";
            string subject = TextBox_Tittle.Text;
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
                Body = TextBox_Body.Text
            })
            {
                smtp.Send(message);
            }
        }
    }
}
