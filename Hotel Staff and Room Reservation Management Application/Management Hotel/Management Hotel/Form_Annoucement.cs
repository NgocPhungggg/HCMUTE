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
    public partial class Form_Annoucement : Form
    {
        public Form_Annoucement()
        {
            InitializeComponent();
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            if ((CheckBox_Receptionist.Checked == true) || (CheckBox_Janitor.Checked == true))
            {
                    MyDatabase database = new MyDatabase();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                if (CheckBox_Receptionist.Checked == true && (CheckBox_Janitor.Checked == true))
                {
                    SqlCommand command = new SqlCommand("SELECT Mail FROM Information I, Employee E WHERE I.ID = E.ID", database.getConnection);
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                }
                else if (CheckBox_Receptionist.Checked == true)
                {
                    SqlCommand command = new SqlCommand("SELECT Mail FROM Information I, Employee E WHERE I.ID = E.ID AND Position = 'Receptionist'", database.getConnection);
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                }
                else if (CheckBox_Janitor.Checked == true)
                {
                    SqlCommand command = new SqlCommand("SELECT Mail FROM Information I, Employee E WHERE I.ID = E.ID AND Position = 'Janitor'", database.getConnection);
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string email = table.Rows[i]["Mail"].ToString();
                    Send_To_Email(email);
                }
                MessageBox.Show("Thông báo đã gửi đến các nhân viên", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Chọn nhân viên muốn gửi", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
