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
    public partial class Form_ListRooms : Form
    {
        public Form_ListRooms()
        {
            InitializeComponent();
        }
        public void KhoiTao()
        {
            Label_Status1.Text = "Còn trống";
            Label_Room1.Text = "P001";
            Label_Room1.Enabled = true;

            Label_Status2.Text = "Còn trống";
            Label_Room2.Text = "P002";
            Label_Room2.Enabled = true;

            Label_Status3.Text = "Còn trống";
            Label_Room3.Text = "P003";
            Label_Room3.Enabled = true;

            Label_Status4.Text = "Còn trống";
            Label_Room4.Text = "P004";
            Label_Room4.Enabled = true
                ;
            Label_Status5.Text = "Còn trống";
            Label_Room5.Text = "P101";
            Label_Room5.Enabled = true;

            Label_Status6.Text = "Còn trống";
            Label_Room6.Text = "P102";
            Label_Room6.Enabled = true;

            Label_Status7.Text = "Còn trống";
            Label_Room7.Text = "P103";
            Label_Room7.Enabled = true;

            Label_Status8.Text = "Còn trống";
            Label_Room8.Text = "P104";
            Label_Room8.Enabled = true;
        }
        Room room = new Room();
        TypeRoom typeroom = new TypeRoom();
        MyDatabase mydatabase = new MyDatabase();
        DataTable dtPhong = new DataTable();
        private void Form_ListRooms_Load(object sender, EventArgs e)
        {   
            dtPhong.Clear();
            SqlCommand command = new SqlCommand("SELECT * FROM Room", mydatabase.getConnection);
            dtPhong = room.GetRoom(command);
            DTP_NgayTim.Format = DateTimePickerFormat.Custom;
            DTP_NgayTim.CustomFormat = "dd-MM-yyyy";

            SqlCommand cm = new SqlCommand("Select * From TypeRoom");
            DataTable table = typeroom.GetTypeRoom(cm);
            ComboBox_TypeRoom.DataSource = table;
            ComboBox_TypeRoom.DisplayMember = "TypeRoomName";
            ComboBox_TypeRoom.ValueMember = "cost";
            ComboBox_TypeRoom.SelectedIndex = -1;
            KhoiTao();

            LoadData(dtPhong);
        }
        private void LoadData(DataTable dtPhong)
        {
            for (int i = 0; i < dtPhong.Rows.Count; i++)
            {
                string maPhong = dtPhong.Rows[i][0].ToString();
                string trangThaiPhong = dtPhong.Rows[i][2].ToString().Equals("False") ? "Còn trống" : "Đã đặt";

                if (maPhong == "P001")
                {
                    Label_Status1.Text = trangThaiPhong;
                    if (trangThaiPhong == "Đã đặt")
                        Label_Room1.Enabled = false;
                }
                else if (maPhong == "P002")
                {
                    Label_Status2.Text = trangThaiPhong;
                    if (trangThaiPhong == "Đã đặt")
                        Label_Room2.Enabled = false;
                }
                else if (maPhong == "P101")
                {
                    Label_Status3.Text = trangThaiPhong;
                    if (trangThaiPhong == "Đã đặt")
                        Label_Room3.Enabled = false;
                }
                else if (maPhong == "P102")
                {
                    Label_Status4.Text = trangThaiPhong;
                    if (trangThaiPhong == "Đã đặt")
                        Label_Room4.Enabled = false;
                }
                else if (maPhong == "P201")
                {
                    Label_Status5.Text = trangThaiPhong;
                    if (trangThaiPhong == "Đã đặt")
                        Label_Room5.Enabled = false;
                }
                else if (maPhong == "P202")
                {
                    Label_Status6.Text = trangThaiPhong;
                    if (trangThaiPhong == "Đã đặt")
                        Label_Room6.Enabled = false;
                }
                else if (maPhong == "P301")
                {
                    Label_Status7.Text = trangThaiPhong;
                    if (trangThaiPhong == "Đã đặt")
                        Label_Room7.Enabled = false;
                }
                else if (maPhong == "P302")
                {
                    Label_Status8.Text = trangThaiPhong;
                    if (trangThaiPhong == "Đã đặt")
                        Label_Room8.Enabled = false;
                }

            }
        }
        private void Label_Room1_Click(object sender, EventArgs e)
        {
            Form_ReservedRoom formTCTDP = new Form_ReservedRoom();
            formTCTDP.maPhong = Label_Room1.Text;
            formTCTDP.ShowDialog();
        }
        private void Label_Room2_Click(object sender, EventArgs e)
        {
            Form_ReservedRoom formTCTDP = new Form_ReservedRoom();
            formTCTDP.maPhong = Label_Room2.Text;
            formTCTDP.ShowDialog();
        }
        private void Label_Room3_Click(object sender, EventArgs e)
        {
            Form_ReservedRoom formTCTDP = new Form_ReservedRoom();
            formTCTDP.maPhong = Label_Room3.Text;
            formTCTDP.ShowDialog();
        }
        private void Label_Room4_Click(object sender, EventArgs e)
        {
            Form_ReservedRoom formTCTDP = new Form_ReservedRoom();
            formTCTDP.maPhong = Label_Room4.Text;
            formTCTDP.ShowDialog();
        }
        private void Label_Room5_Click(object sender, EventArgs e)
        {
            Form_ReservedRoom formTCTDP = new Form_ReservedRoom();
            formTCTDP.maPhong = Label_Room5.Text;
            formTCTDP.ShowDialog();
        }
        private void Label_Room6_Click(object sender, EventArgs e)
        {
            Form_ReservedRoom formTCTDP = new Form_ReservedRoom();
            formTCTDP.maPhong = Label_Room6.Text;
            formTCTDP.ShowDialog();
        }
        private void Label_Room7_Click(object sender, EventArgs e)
        {
            Form_ReservedRoom formTCTDP = new Form_ReservedRoom();
            formTCTDP.maPhong = Label_Room7.Text;
            formTCTDP.ShowDialog();
        }
        private void Label_Room8_Click(object sender, EventArgs e)
        {
            Form_ReservedRoom formTCTDP = new Form_ReservedRoom();
            formTCTDP.maPhong = Label_Room8.Text;
            formTCTDP.ShowDialog();
        }

        private void Button_Loc_Click(object sender, EventArgs e)
        {
            dtPhong = new DataTable();
            dtPhong.Clear();
            KhoiTao();
            DTP_NgayTim.Format = DateTimePickerFormat.Custom;
            DTP_NgayTim.CustomFormat = "yyyy-MM-dd";

            SqlCommand command = new SqlCommand("select RoomID, TypeRoomName, RoomStatus = 'true' " +
                                                "from Room " +
                                                "where RoomID in (Select RoomID " +
                                                                 "From Bill  " +
                                                                 "Where Convert(date,CheckIn) <= @day AND  @day <= DATEADD(day, ReservedDays, CheckIn))", mydatabase.getConnection);
            command.Parameters.Add("@day", SqlDbType.DateTime).Value = DTP_NgayTim.Value;
            dtPhong = room.GetRoom(command);
            LoadData(dtPhong);
        }
    }
}
