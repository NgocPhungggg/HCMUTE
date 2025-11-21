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
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Management_Hotel
{
    public partial class Form_ManagerJanitors : Form
    {
        public Form_ManagerJanitors()
        {
            InitializeComponent();
        }
        Janitor janitor = new Janitor();
        public void LoadDataGridView () 
        {
            this.informationTableAdapter.Fill(this.hotel_ManagementDataSet.Information);
            SqlCommand command = new SqlCommand("SELECT * FROM Employee E, Information I WHERE E.ID = I.ID AND Position = 'Janitor'");
            DataGridView_ListJanitors.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView_ListJanitors.RowTemplate.Height = 80;
            DataGridView_ListJanitors.DataSource = janitor.GetJanitor(command);
            picCol = (DataGridViewImageColumn)DataGridView_ListJanitors.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView_ListJanitors.AllowUserToAddRows = false;
        }
        private void Form_ManagerJanitors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.Information' table. You can move, or remove it, as needed.
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

            bool CheckYear ()
            {
                if (((this_year - born_year) > 18) || 
                    ((this_year - born_year) < 100))
                    return true;
                else
                    return false;
            }
            bool CheckNULL ()
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
                MessageBox.Show("The janitor's age must be between 18 and 100", "Invalid birth's Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CheckNULL() == false)
            {
                MessageBox.Show("FullName, Phone, Picturer must not be null, please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MemoryStream Pic = new MemoryStream();
                PictureBox_Pic.Image.Save(Pic, PictureBox_Pic.Image.RawFormat);
                if (janitor.InsertJanitor(ID, Fullname, Gender, BDate,
                                          Mail,Phone, Addr,Pic))
                {
                    MessageBox.Show("New Janitor Added", "Add Janitor", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Error", "Add Janitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            string ID = TextBox_ID.Text;
            if (janitor.DeleteJanitor(ID))
            {
                MessageBox.Show("Janitor Deleted", "Delete Janitor", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Delete Janitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            LoadDataGridView();
        }
        private void DataGridView_ListJanitors_DoubleClick(object sender, EventArgs e)
        {
            TextBox_ID.Text = DataGridView_ListJanitors.CurrentRow.Cells[0].Value.ToString();
            TextBox_FullName.Text = DataGridView_ListJanitors.CurrentRow.Cells[1].Value.ToString();
            if (DataGridView_ListJanitors.CurrentRow.Cells[2].Value.ToString() == "Female")
            {
                RadioButton_Female.Checked = true;
            }
            else
            {
                RadioButton_Male.Checked = true;
            }
            DatePicker_BirthDate.Value = (DateTime)DataGridView_ListJanitors.CurrentRow.Cells[3].Value;
            TextBox_Mail.Text = DataGridView_ListJanitors.CurrentRow.Cells[4].Value.ToString();
            TextBox_Phone.Text = DataGridView_ListJanitors.CurrentRow.Cells[5].Value.ToString();
            TextBox_Address.Text = DataGridView_ListJanitors.CurrentRow.Cells[6].Value.ToString();
            byte[] pic = (byte[])DataGridView_ListJanitors.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBox_Pic.Image = Image.FromStream(picture);
        }

    }
}
