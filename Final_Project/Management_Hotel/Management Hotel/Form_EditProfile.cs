using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel
{
    public partial class Form_EditProfile : Form
    {
        public Form_EditProfile()
        {
            InitializeComponent();
        }
        Janitor janitor = new Janitor();
        string ID;
        public void GetMyID(string id)
        {
            ID = id;
        }
        public void LoadDataGridView()
        {
            MyDatabase database = new MyDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Information WHERE ID = @id", database.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            Label_MyID.Text = table.Rows[0]["ID"].ToString();
            Label_MyName.Text = table.Rows[0]["FullName"].ToString();

            if(table.Rows[0]["Gender"].ToString() == "Female")
            {
                RadioButton_Female.Checked = true;
            }
            else if (table.Rows[0]["Gender"].ToString() == "Male")
            {
                
                RadioButton_Male.Checked = true;
            }

            DatePicker_BirthDate.Value = (DateTime)table.Rows[0]["BirthDate"];
            TextBox_Mail.Text = table.Rows[0]["Mail"].ToString();
            TextBox_Phone.Text = table.Rows[0]["Phone"].ToString();
            TextBox_Address.Text = table.Rows[0]["Addresss"].ToString();
            byte[] pic = (byte[])table.Rows[0]["Pic"];
            MemoryStream picture = new MemoryStream(pic);
            PictureBox_Pic.Image = Image.FromStream(picture);
        }
        private void Form_EditProfile_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void Button_UploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBox_Pic.Image = Image.FromFile(opf.FileName);
            }
        }
        private void Button_Edit_Click(object sender, EventArgs e)
        {
            string Fullname = Label_FullName.Text;
            string Gender = "X";
            if (RadioButton_Male.Checked)
            {
                Gender = "Male";
            }
            else if (RadioButton_Female.Checked)
            {
                Gender = "Female";
            }
            DateTime BDate = DatePicker_BirthDate.Value;
            int born_year = DatePicker_BirthDate.Value.Year;
            int this_year = DateTime.Now.Year;
            string Mail = TextBox_Mail.Text;
            string Phone = TextBox_Phone.Text;
            string Addr = TextBox_Address.Text;

            bool CheckYear()
            {
                if (((this_year - born_year) > 18) ||
                    ((this_year - born_year) < 100))
                    return true;
                else
                    return false;
            }
            bool CheckNULL()
            {
                if ((TextBox_Phone.Text.Trim() == "") ||
                    (PictureBox_Pic.Image == null))
                    return false;
                else
                    return true;
            }
            if (CheckYear() == false)
            {
                MessageBox.Show("The student's age must be between 18 and 100", "Invalid birth's Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CheckNULL() == false)
            {
                MessageBox.Show("FullName, Phone, Picturer must not be null, please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MemoryStream Pic = new MemoryStream();
                PictureBox_Pic.Image.Save(Pic, PictureBox_Pic.Image.RawFormat);
                if (janitor.EditJanitor(ID, Fullname, Gender, BDate,
                                          Mail, Phone, Addr, Pic))
                {
                    MessageBox.Show("Janitor Edited", "Edit Janitor", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Janitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadDataGridView();
        }
    }
}
