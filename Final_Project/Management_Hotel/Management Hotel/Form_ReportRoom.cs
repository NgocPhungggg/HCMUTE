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
    public partial class Form_ReportRoom : Form
    {
        public Form_ReportRoom()
        {
            InitializeComponent();
        }
        MyDatabase mydb = new MyDatabase();

        DetailService detailService = new DetailService();

        private void SuDungDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.hotel_ManagementDataSet.Bill);
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.Servicess' table. You can move, or remove it, as needed.
            this.detail_ServicessTableAdapter.Fill(this.hotel_ManagementDataSet.Detail_Servicess);
            dgvHoaDonDatPhong.Columns["dataGridViewTextBoxColumn9"].DefaultCellStyle.Format = "N2";

            SqlCommand command = new SqlCommand("select ServiceName from Servicess ", mydb.getConnection);
            DataTable table = detailService.GetDetailService(command);
            comboBoxService.DataSource = table;
            comboBoxService.DisplayMember = "ServiceName";
        }

        bool verif()
        {
            if ((txtbill_id.Text.Trim() == "") || (comboBoxService.Text.Trim() == "")
               )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int BillID = int.Parse(txtbill_id.Text);
            string SvcName = comboBoxService.Text;
            int quatity = Convert.ToInt32(quantitynumericUpDown.Value);
            int tongtien = int.Parse(txtTotal_money.Text);
            try
            {
                if (verif())
                {

                    if (detailService.InsertDetailService(BillID, SvcName, quatity, tongtien))
                    {
                        MessageBox.Show("Thêm sử dụng dịch vụ thành công", "Thêm sử dụng dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sử dụng dịch vụ thất bại", "Thêm sử dụng dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống", "Thêm sử dụng dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex, "Notify", MessageBoxButtons.OK);
                //MessageBox.Show("hi"ex)
            }
        }

        private void updbutton_Click(object sender, EventArgs e)
        {
            int BillID = int.Parse(txtbill_id.Text);
            string SvcName = comboBoxService.Text;
            int quatity = Convert.ToInt32(quantitynumericUpDown.Value);
            int tongtien = int.Parse(txtTotal_money.Text);
            try
            {
                if (verif())
                {

                    if (detailService.UpdateDetailService(BillID, SvcName, quatity, tongtien))
                    {
                        MessageBox.Show("Cập nhật sử dụng dịch vụ thành công", "Thêm sử dụng dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sử dụng dịch vụ thất bại", "Thêm sử dụng dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống", "Thêm sử dụng dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex, "Notify", MessageBoxButtons.OK);
                //MessageBox.Show("hi"ex)
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtbill_id.Text);
                if (MessageBox.Show("Bạn có chắc muốn xóa không", "Xóa sử dụng dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (detailService.DeleteDetailService(id))
                    {
                        MessageBox.Show("Xóa hóa đơn thành công", "Xóa sử dụng dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        txtbill_id.Text = "";
                        comboBoxService.Text = "";
                        quantitynumericUpDown.Value = 0;
                        txtTotal_money.Text = "";
                        ;
                    }
                    else
                    {
                        MessageBox.Show("Xóa sử dụng dịch vụ không thành công", "Xóa sự dụng dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng ID", "Xóa sử dụng dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        int tinhTongTienDV(string svcname)
        {
            int totalCost = 0;
            int sl = Convert.ToInt32(quantitynumericUpDown.Value);
            SqlCommand command = new SqlCommand("SELECT Cost FROM Servicess WHERE ServiceName = @ServiceName", mydb.getConnection);
            command.Parameters.AddWithValue("@ServiceName", svcname);
            mydb.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int cost = reader.GetInt32(0);
                totalCost = cost * sl;
            }

            reader.Close();
            return totalCost;
        }

        private void quantitynumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            string svcname = comboBoxService.Text;
            int totalsv = tinhTongTienDV(svcname);
            txtTotal_money.Text = totalsv.ToString();
        }

        private void dgvSuDungDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbill_id.Text = dgvSuDungDichVu.CurrentRow.Cells[0].Value.ToString();
            comboBoxService.Text = dgvSuDungDichVu.CurrentRow.Cells[1].Value.ToString();
            quantitynumericUpDown.Value = Convert.ToInt32(dgvSuDungDichVu.CurrentRow.Cells[2].Value);
            txtTotal_money.Text = dgvSuDungDichVu.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvHoaDonDatPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbill_id.Text = dgvHoaDonDatPhong.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
