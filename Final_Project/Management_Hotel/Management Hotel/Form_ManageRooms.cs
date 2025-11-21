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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Management_Hotel
{
    public partial class Form_ManageRooms : Form
    {
        public Form_ManageRooms()
        {
            InitializeComponent();
        }
        TypeRoom typeroom = new TypeRoom();
        Room room = new Room();
        Check check = new Check();

        public void LoadDataGridView()
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.TypeRoom' table. You can move, or remove it, as needed.
            this.typeRoomTableAdapter.Fill(this.hotel_ManagementDataSet.TypeRoom);
            DataGridView_TypeRoom.ReadOnly = true;
            SqlCommand command = new SqlCommand("SELECT* FROM TypeRoom");
            DataGridView_TypeRoom.DataSource = typeroom.GetTypeRoom(command);

            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotel_ManagementDataSet.Room);
            DataGridView_Rooms.ReadOnly = true;
            SqlCommand com = new SqlCommand("SELECT * FROM Room");
            DataGridView_Rooms.DataSource = room.GetRoom(com);

        }
        private void Form_ManageRooms_Load(object sender, EventArgs e)
        {
            TextBox_MinUnit.Text = "0";
            TextBox_MaxUnit.Text = "1999000";
            LoadDataGridView();
        }
        //Loại phòng
        bool verif()
        {
            if ((tenloaiphongtxt.Text.Trim() == "") || (dongiatxt.Text.Trim() == "")
               )
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void Button_AddType_Click(object sender, EventArgs e)
        {
            TypeRoom typeroom = new TypeRoom();
            string name = tenloaiphongtxt.Text;
            int cost = int.Parse(dongiatxt.Text);

            if (!check.check(name))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng tên");
                return;
            }

            if (!check.checkmoney(cost.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng tiền tệ");
                return;
            }
            try
            {
                if (verif())
                {

                    if (typeroom.InsertTypeRoom(name, cost))
                    {
                        MessageBox.Show("Thêm loại phòng thành công", "Thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("Select * From TypeRoom");
                        DataGridView_TypeRoom.DataSource = typeroom.GetTypeRoom(command);
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại phòng thất bại", "Thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống", "Thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex, "Notify", MessageBoxButtons.OK);
                //MessageBox.Show("hi"ex)
            }

        }
        private void Button_EditType_Click(object sender, EventArgs e)
        {
            TypeRoom typeroom = new TypeRoom();
            string name = tenloaiphongtxt.Text;
            int cost = int.Parse(dongiatxt.Text);

            if (!check.check(name))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng tên");
                return;
            }

            if (!check.checkmoney(cost.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng tiền tệ");
                return;
            }
            try
            {
                if (verif())
                {

                    if (typeroom.UpdateTypeRoom(name, cost))
                    {
                        MessageBox.Show("Cập nhật loại phòng thành công", "Cập nhật loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("Select * From TypeRoom");
                        DataGridView_TypeRoom.DataSource = typeroom.GetTypeRoom(command);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật loại phòng thất bại", "Cập nhật loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống", "Cập nhật loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex, "Notify", MessageBoxButtons.OK);
            }
        }        
        private void Button_DeleteType_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tenloaiphongtxt.Text;
                if (MessageBox.Show("Bạn có chắc muốn xóa không", "Xóa loại phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (typeroom.DeleteTypeRoom(name))
                    {
                        MessageBox.Show("Xóa loại phòng thành công", "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("Select * From TypeRoom");
                        DataGridView_TypeRoom.DataSource = typeroom.GetTypeRoom(command);
                        tenloaiphongtxt.Text = "";
                        dongiatxt.Text = "";

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
        private void DataGridView_TypeRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tenloaiphongtxt.Text = DataGridView_TypeRoom.CurrentRow.Cells[0].Value.ToString();
            dongiatxt.Text = DataGridView_TypeRoom.CurrentRow.Cells[1].Value.ToString();
        }
        //Phòng
        bool verifroom()
        {
            if ((txtRoomID.Text.Trim() == "") || (cbRoomType.Text.Trim() == "") || (TinhTrangcomboBox.Text.Trim() == "")
               )
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void Button_AddRoom_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            string roomid = txtRoomID.Text;
            string typename = cbRoomType.Text.Trim();
            bool status = false;
            if (TinhTrangcomboBox.Text == "Đã đặt")
            {
                status = true;
            }

            if (!check.checkroomid(roomid))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng phòng");
                return;
            }

            try
            {
                if (verifroom())
                {
                    if (room.InsertRoom(roomid, typename, status))
                    {
                        MessageBox.Show("Thêm phòng thành công", "Thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("Select * From Room");
                        DataGridView_Rooms.DataSource = room.GetRoom(command);
                    }
                    else
                    {
                        MessageBox.Show("Thêm phòng thất bại", "Thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống", "Thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex, "Notify", MessageBoxButtons.OK);
                //MessageBox.Show("hi"ex)
            }
        }
        private void Button_EditRoom_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            string roomid = txtRoomID.Text;
            string typename = cbRoomType.Text.Trim();
            bool status = false;
            if (TinhTrangcomboBox.Text == "Đã đặt")
            {
                status = true;
            }

            if (!check.checkroomid(roomid))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng phòng");
                return;
            }

            try
            {
                if (verifroom())
                {
                    if (room.UpdateRoom(roomid, typename, status))
                    {
                        MessageBox.Show("Cập nhật phòng thành công", "Cập nhật phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("Select * From Room");
                        DataGridView_Rooms.DataSource = room.GetRoom(command);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phòng thất bại", "Cập nhật phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống", "Cập nhật phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex, "Notify", MessageBoxButtons.OK);
            }
        }
        private void Button_DeleteRoom_Click(object sender, EventArgs e)
        {
            try
            {
                string roomid = txtRoomID.Text;
                if (MessageBox.Show("Bạn có chắc muốn xóa không", "Xóa  phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (room.DeleteRoom(roomid))
                    {
                        MessageBox.Show("Xóa phòng thành công", "Xóa phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("Select * From Room");
                        DataGridView_Rooms.DataSource = room.GetRoom(command);
                        txtRoomID.Text = "";
                        cbRoomType.Text = "";
                        TinhTrangcomboBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại phòng không thành công", "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng ID phòng", "Xóa phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridView_Rooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            txtRoomID.Text = DataGridView_Rooms.CurrentRow.Cells[0].Value.ToString();
            cbRoomType.Text = DataGridView_Rooms.CurrentRow.Cells[1].Value.ToString();
            string status = DataGridView_Rooms.CurrentRow.Cells[2].Value.ToString();
            if (status == "True")
            {
                TinhTrangcomboBox.Text = "Đã đặt";
            }
            else
            {
                TinhTrangcomboBox.Text = "Còn trống";
            }
            Show();

        }
        //Tìm kiếm phòng theo giá tiền
        private void btnLocPhong_Click(object sender, EventArgs e)
        {
            string key = cbRoomType.Text;
            SqlCommand com = new SqlCommand("SELECT * FROM Room WHERE TypeRoomName like '%" + key + "%'");
            DataTable tb = room.GetRoom(com);
            DataGridView_Rooms.DataSource = tb;
        }
        private void btnLocLoaiPhong_Click(object sender, EventArgs e)
        {

            int min = int.Parse(TextBox_MinUnit.Text);
            int max = int.Parse(TextBox_MaxUnit.Text);
            SqlCommand com = new SqlCommand("SELECT* FROM TYPEROOM WHERE cost >=" + min + "AND cost <=" + max);
            DataTable tb = typeroom.GetTypeRoom(com);
            DataGridView_TypeRoom.DataSource = tb;
        }
    }
}
