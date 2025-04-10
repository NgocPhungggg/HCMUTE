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
using static System.Windows.Forms.AxHost;

namespace Management_Hotel
{
    public partial class Form_MenuJanitor : Form
    {
        public Form_MenuJanitor()
        {
            InitializeComponent();
        }
        Attendance attendance = new Attendance();
        Janitor janitor = new Janitor();
        string ID;
        public void GetJanitorID(string id)
        {
            ID = id;
        }
        private void Form_MenuJanitor_Load(object sender, EventArgs e)
        {
            MyDatabase database = new MyDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Information WHERE ID = @id", database.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            Label_EmployeeName.Text = table.Rows[0]["FullName"].ToString();
        }
        //ACCOUNT
        private void Label_EditProfile_Click(object sender, EventArgs e)
        {
            Form_EditProfile editprofile = new Form_EditProfile();
            editprofile.GetMyID(ID);
            editprofile.ShowDialog();
        }
        private void Label_ChangePW_Click(object sender, EventArgs e)
        {
            Form_ChangePassword changepassword = new Form_ChangePassword();
            changepassword.GetMyID(ID);
            changepassword.ShowDialog();
        }
        //LAO CÔNG
        private void Button_ListJanitor_Click(object sender, EventArgs e)
        {
            Form_ListJanitors listjanitors = new Form_ListJanitors();   
            listjanitors.ShowDialog();
        }
        //LỄ TÂN 
        private void Button_ListReceptionist_Click(object sender, EventArgs e)
        {
            Form_ListReceptionists listreceptionist = new Form_ListReceptionists();   
            listreceptionist.ShowDialog();
        }
        //ĐIỂM DANH
        private void Button_ListAttendance_Click(object sender, EventArgs e)
        {
            Form_ListAttendances listattendances= new Form_ListAttendances();
            listattendances.ShowDialog();
        }
        private void Button_Start_Click(object sender, EventArgs e)
        {

            DateTime datework = DateTime.Now;

            MyDatabase database = new MyDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Attendance " +
                                                "WHERE ID = @id AND DateWork = @date", database.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@date", SqlDbType.Date).Value = datework.Date;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            int check()
            {
                if ((datework.TimeOfDay <= TimeSpan.Parse(table.Rows[0]["StartSchedule"].ToString())) && table.Rows.Count > 0)
                {
                    return 1;
                }
                else if ((datework.TimeOfDay > TimeSpan.Parse(table.Rows[0]["StartSchedule"].ToString())) && table.Rows.Count > 0)
                {

                    return 2;
                }
                else
                {
                    return 0;
                }
            }

            if (attendance.InsertAttendance(ID, datework) && check() == 1)
            {
                MessageBox.Show("New Attendance Added", "Add Attendance", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (attendance.InsertAttendance(ID, datework.AddHours(2)) && check() == 2)
            {
                MessageBox.Show("New Attendance Added", "Add Attendance", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Add Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Button_End_Click(object sender, EventArgs e)
        {
            DateTime datework = DateTime.Now;
            if (attendance.UpdateAttendance(ID, datework))
            {
                MessageBox.Show("New Attendance Added", "Add Attendance", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error", "Add Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //ROOM
        private void Button_ListRoom_Click(object sender, EventArgs e)
        {
            Form_ListRooms listrooms = new Form_ListRooms();
            listrooms.ShowDialog();
        }
        private void Button_CheckOut_Click(object sender, EventArgs e)
        {

        }
    }
}
