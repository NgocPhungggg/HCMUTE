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

namespace Management_Hotel
{
    public partial class Form_Service : Form
    {
        Service service = new Service();
        Check check = new Check();
        public Form_Service()
        {
            InitializeComponent();
        }
        bool verif()
        {
            if ((DichVutxt.Text.Trim() == "") || (Giatxt.Text.Trim() == "")
               )
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void Form_Service_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.Servicess' table. You can move, or remove it, as needed.
            this.servicessTableAdapter.Fill(this.hotel_ManagementDataSet.Servicess);
            // TODO: This line of code loads data into the 'pROJECT_WIN_HOTELDataSetAll.Services' table. You can move, or remove it, as needed.
            /*this.servicesTableAdapter.Fill(this.pROJECT_WIN_HOTELDataSetAll.Services);
            SqlCommand command = new SqlCommand("Select * From Services");
            ServiceDGV.DataSource = service.getService(command);
            txtMinUnit.Text = "0";
            txtMaxUnit.Text = "1999000";*/
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            string name = DichVutxt.Text;
            int cost = int.Parse(Giatxt.Text);

            if (!check.checkmoney(cost.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng tiền tệ");
                return;
            }
            try
            {
                if (verif())
                {

                    if (service.InsertService(name, cost))
                    {
                        MessageBox.Show("Thêm dịch vụ thành công", "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("Select * From Services");
                        ServiceDGV.DataSource = service.getService(command);
                    }
                    else
                    {
                        MessageBox.Show("Thêm dịch vụ thất bại", "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống", "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex, "Notify", MessageBoxButtons.OK);
                //MessageBox.Show("hi"ex)
            }
        }
        private void Button_Edit_Click(object sender, EventArgs e)
        {

            Service service = new Service();
            string name = DichVutxt.Text;
            int cost = int.Parse(Giatxt.Text);

            if (!check.checkmoney(cost.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng tiền tệ");
                return;
            }
            try
            {
                if (verif())
                {

                    if (service.UpdateService(name, cost))
                    {
                        MessageBox.Show("Sửa dịch vụ thành công", "Sửa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("Select * From Services");
                        ServiceDGV.DataSource = service.getService(command);
                    }
                    else
                    {
                        MessageBox.Show("Sửa dịch vụ thất bại", "Sửa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống", "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex, "Notify", MessageBoxButtons.OK);
                //MessageBox.Show("hi"ex)
            }
        }
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string name = DichVutxt.Text;
                if (MessageBox.Show("Bạn có chắc muốn xóa không", "Xóa dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    if (service.DeleteService(name))
                    {
                        MessageBox.Show("Xóa dịch vụ thành công", "Xóa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("Select * From Services");
                        ServiceDGV.DataSource = service.getService(command);
                        DichVutxt.Text = "";
                        Giatxt.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Xóa loại phòng không thành công", "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng loại phòng", "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ServiceDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DichVutxt.Text = ServiceDGV.CurrentRow.Cells[0].Value.ToString();
            Giatxt.Text = ServiceDGV.CurrentRow.Cells[1].Value.ToString();
        }
        private void Button_SelectService_Click(object sender, EventArgs e)
        {
            int min = int.Parse(TextBox_MinUnit.Text);
            int max = int.Parse(TextBox_MaxUnit.Text);
            SqlCommand com = new SqlCommand("SELECT* FROM Services WHERE cost >=" + min + "AND cost <=" + max);
            DataTable tb = service.getService(com);
            ServiceDGV.DataSource = tb;
        }
    }
}

