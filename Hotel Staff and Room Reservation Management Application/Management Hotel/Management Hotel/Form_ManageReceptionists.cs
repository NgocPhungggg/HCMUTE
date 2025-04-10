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
    public partial class Form_ManageReceptionists : Form
    {
        public Form_ManageReceptionists()
        {
            InitializeComponent();
        }
        Receptionist receptionist = new Receptionist();
        public void LoadDataGridView()
        {
            this.informationTableAdapter.Fill(this.hotel_ManagementDataSet.Information);
            SqlCommand command = new SqlCommand("SELECT * FROM Employee E, Information I WHERE E.ID = I.ID AND Position = 'Receptionist'");
            DataGridView_ListReceptionist.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView_ListReceptionist.RowTemplate.Height = 80;
            DataGridView_ListReceptionist.DataSource = receptionist.GetReceptionist(command);
            picCol = (DataGridViewImageColumn)DataGridView_ListReceptionist.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView_ListReceptionist.AllowUserToAddRows = false;
        }
        private void Form_ManageReceptionists_Load(object sender, EventArgs e)
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
                MessageBox.Show("Lễ Tân phải trên 18 tuổi", "Invalid birth's Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CheckNULL() == false)
            {
                MessageBox.Show("FullName, Phone, Picturer must not be null, please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MemoryStream Pic = new MemoryStream();
                PictureBox_Pic.Image.Save(Pic, PictureBox_Pic.Image.RawFormat);
                if (receptionist.InsertReceptionist(ID, Fullname, Gender, BDate,
                                                    Mail, Phone, Addr, Pic))
                {
                    MessageBox.Show("New Receptionist Added", "Add Receptionist", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Error", "Add Receptionist", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("The receptionist's age must be between 18 and 100", "Invalid birth's Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CheckNULL() == false)
            {
                MessageBox.Show("FullName, Phone, Picturer must not be null, please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MemoryStream Pic = new MemoryStream();
                PictureBox_Pic.Image.Save(Pic, PictureBox_Pic.Image.RawFormat);
                if (receptionist.EditReceptionist(ID, Fullname, Gender, BDate,
                                                  Mail, Phone, Addr, Pic))
                {
                    MessageBox.Show("Receptionist Edited", "Edit Receptionist", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Receptionist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadDataGridView();
        }
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            string ID = TextBox_ID.Text;
            if (receptionist.DeleteReceptionist(ID))
            {
                MessageBox.Show("Janitor Receptionist", "Delete Receptionist", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Delete Receptionist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            LoadDataGridView();
        }
        private void DataGridView_ListReceptionist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_ID.Text = DataGridView_ListReceptionist.CurrentRow.Cells[0].Value.ToString();
            TextBox_FullName.Text = DataGridView_ListReceptionist.CurrentRow.Cells[1].Value.ToString();
            if (DataGridView_ListReceptionist.CurrentRow.Cells[2].Value.ToString() == "Female")
            {
                RadioButton_Female.Checked = true;
            }
            else
            {
                RadioButton_Male.Checked = true;
            }
            DatePicker_BirthDate.Value = (DateTime)DataGridView_ListReceptionist.CurrentRow.Cells[3].Value;
            TextBox_Mail.Text = DataGridView_ListReceptionist.CurrentRow.Cells[4].Value.ToString();
            TextBox_Phone.Text = DataGridView_ListReceptionist.CurrentRow.Cells[5].Value.ToString();
            TextBox_Address.Text = DataGridView_ListReceptionist.CurrentRow.Cells[6].Value.ToString();
            byte[] pic = (byte[])DataGridView_ListReceptionist.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBox_Pic.Image = Image.FromStream(picture);
        }


    }
}
