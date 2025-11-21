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
    public partial class Form_ReservedRoom : Form
    {
        public Form_ReservedRoom()
        {
            InitializeComponent();
        }
        Bill bill = new Bill();
        MyDatabase mydb = new MyDatabase();
        private void Form_ReservedRoom_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        public string maPhong { get; set; }
        bool Them = true;
        void LoadData()
        {
            // TODO: This line of code loads data into the 'pROJECT_WIN_HOTELDataSetAll.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.hotel_ManagementDataSet.Bill);
            SqlCommand command = new SqlCommand("SELECT * FROM Bill");
            dgvHoaDonDatPhong.DataSource = bill.GetBill(command);
            txtRoom_id.Text = maPhong;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now.ToUniversalTime(); // Chuyển đổi sang múi giờ UTC
            DateTime epochTime = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan timeSpan = currentTime - epochTime;
            int BillID = (int)timeSpan.TotalSeconds;

            string CustomerID = txtCustomer_id.Text;
            DateTime date_check_in = Convert.ToDateTime(txtDate_check_in.Text);
            int ReservedDays = int.Parse(txtReserved_day.Text);
            string EmployeeID = txtEmployee_id.Text;
            maPhong = txtRoom_id.Text;
            try
            {


                if (!bill.InsertBillCheckin(BillID, maPhong, CustomerID, date_check_in, ReservedDays, EmployeeID))
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thêm Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex, "Notify", MessageBoxButtons.OK);
                //MessageBox.Show("hi"ex)
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtbill_id.Text);
                if (MessageBox.Show("Bạn có chắc muốn xóa không", "Xóa hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bill.DeleteBill(id))
                    {
                        MessageBox.Show("Xóa hóa đơn thành công", "Xóa hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        txtbill_id.Text = "";
                        txtRoom_id.Text = "";
                        txtCustomer_id.Text = "";
                        txtDate_check_in.Text = "";
                        txtReserved_day.Text = "";
                        txtEmployee_id.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa hóa đơn không thành công", "Xóa hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng ID", "Xóa hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updbutton_Click(object sender, EventArgs e)
        {
            maPhong = txtRoom_id.Text;
            int BillID = int.Parse(txtbill_id.Text);
            string CustomerID = txtCustomer_id.Text;
            DateTime date_check_in = Convert.ToDateTime(txtDate_check_in.Text);
            int ReservedDays = int.Parse(txtReserved_day.Text);
            string EmployeeID = txtEmployee_id.Text;
            try
            {


                if (!bill.UpdateBillCheckin(BillID, maPhong, CustomerID, date_check_in, ReservedDays, EmployeeID))
                {
                    MessageBox.Show("Cập nhật hóa đơn thành công", "Cập nhật Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật hóa đơn thất bại", "Cập nhật hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex, "Notify", MessageBoxButtons.OK);
            }
        }
        private void dgvHoaDonDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbill_id.Text = dgvHoaDonDatPhong.CurrentRow.Cells[0].Value.ToString();
            txtRoom_id.Text = dgvHoaDonDatPhong.CurrentRow.Cells[1].Value.ToString();
            txtCustomer_id.Text = dgvHoaDonDatPhong.CurrentRow.Cells[2].Value.ToString();
            txtDate_check_in.Text = dgvHoaDonDatPhong.CurrentRow.Cells[3].Value.ToString();
            txtReserved_day.Text = dgvHoaDonDatPhong.CurrentRow.Cells[4].Value.ToString();
            txtEmployee_id.Text = dgvHoaDonDatPhong.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
