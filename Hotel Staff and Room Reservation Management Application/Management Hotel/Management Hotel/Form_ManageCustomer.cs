using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel
{
    public partial class Form_ManageCustomer : Form
    {
        public Form_ManageCustomer()
        {
            InitializeComponent();
        }
        Customer customer = new Customer(); 
        public void LoadDataGridView()
        {
            this.informationTableAdapter.Fill(this.hotel_ManagementDataSet.Information);
            SqlCommand command = new SqlCommand("SELECT * FROM Information WHERE ID NOT IN (SELECT ID FROM Employee)");
            DataGridView_ListCustomers.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView_ListCustomers.RowTemplate.Height = 80;
            DataGridView_ListCustomers.DataSource = customer.GetCustomer(command);
            picCol = (DataGridViewImageColumn)DataGridView_ListCustomers.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView_ListCustomers.AllowUserToAddRows = false;
        }
        private void Form_ManageCustomer_Load(object sender, EventArgs e)
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
        private void Button_TakePic_Click(object sender, EventArgs e)
        {
            Form_TakePicture takepic = new Form_TakePicture();
            takepic.ShowDialog();
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            string ID = TextBox_ID.Text;
            string Fullname = TextBox_FullName.Text;
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
                if ((TextBox_FullName.Text.Trim() == "") ||
                    (TextBox_Phone.Text.Trim() == "") ||
                    (PictureBox_Pic.Image == null))
                    return false;
                else
                    return true;

            }
            if (CheckYear() == false)
            {
                MessageBox.Show("The Customer's age must be between 18 and 100", "Invalid birth's Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CheckNULL() == false)
            {
                MessageBox.Show("FullName, Phone, Picturer must not be null, please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MemoryStream Pic = new MemoryStream();
                PictureBox_Pic.Image.Save(Pic, PictureBox_Pic.Image.RawFormat);
                if(customer.InsertCustomer(ID, Fullname, Gender, BDate,
                                           Mail, Phone, Addr, Pic))
                {
                    MessageBox.Show("New Customer Added", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Error", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return false;
                }
            }
            LoadDataGridView();
        }
        private void Button_Edit_Click(object sender, EventArgs e)
        {
            string ID = TextBox_ID.Text;
            string Fullname = TextBox_FullName.Text;
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
                if ((TextBox_FullName.Text.Trim() == "") ||
                    (TextBox_Phone.Text.Trim() == "") ||
                    (PictureBox_Pic.Image == null))
                    return false;
                else
                    return true;
            }
            if (CheckYear() == false)
            {
                MessageBox.Show("The Customer's age must be between 18 and 100", "Invalid birth's Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CheckNULL() == false)
            {
                MessageBox.Show("FullName, Phone, Picturer must not be null, please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MemoryStream Pic = new MemoryStream();
                PictureBox_Pic.Image.Save(Pic, PictureBox_Pic.Image.RawFormat);
                if (customer.EditCustomer(ID, Fullname, Gender, BDate,
                                          Mail, Phone, Addr, Pic))
                {
                    MessageBox.Show("Customer Edited", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadDataGridView();
        }
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            string ID = TextBox_ID.Text;
            if (customer.DeleteCustomer(ID))
            {
                MessageBox.Show("Janitor Customer", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            LoadDataGridView();
        }
        private void DataGridView_ListCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_ID.Text = DataGridView_ListCustomers.CurrentRow.Cells[0].Value.ToString();
            TextBox_FullName.Text = DataGridView_ListCustomers.CurrentRow.Cells[1].Value.ToString();
            if (DataGridView_ListCustomers.CurrentRow.Cells[2].Value.ToString() == "Female")
            {
                RadioButton_Female.Checked = true;
            }
            else
            {
                RadioButton_Male.Checked = true;
            }
            DatePicker_BirthDate.Value = (DateTime)DataGridView_ListCustomers.CurrentRow.Cells[3].Value;
            TextBox_Mail.Text = DataGridView_ListCustomers.CurrentRow.Cells[4].Value.ToString();
            TextBox_Phone.Text = DataGridView_ListCustomers.CurrentRow.Cells[5].Value.ToString();
            TextBox_Address.Text = DataGridView_ListCustomers.CurrentRow.Cells[6].Value.ToString();
            byte[] pic = (byte[])DataGridView_ListCustomers.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBox_Pic.Image = Image.FromStream(picture);
        }


    }
}
