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
    public partial class Form_Salary : Form
    {
        public Form_Salary()
        {
            InitializeComponent();
        }
        Attendance attendance = new Attendance();
        Schedule schedule = new Schedule();
        TypeRoom typeroom = new TypeRoom();
        private void LoadDataGridViewSchedule()
        {
            SqlCommand command = new SqlCommand("SELECT ID,StartSchedule,EndSchedule,DateWork FROM Attendance");
            DataGridView_Schedule.ReadOnly = true;
            DataGridView_Schedule.DataSource = attendance.GetAttendance(command);
            DataGridView_Schedule.AllowUserToAddRows = false;
        }
        private void Form_Salary_Load(object sender, EventArgs e)
        {

            DTP_Schedule.Format = DateTimePickerFormat.Custom;
            DTP_Schedule.CustomFormat = "yyyy-MM-dd";

            SqlCommand command1 = new SqlCommand("Select ID From Employee");
            DataTable table = typeroom.GetTypeRoom(command1);
            IDcomboBox.DataSource = table;
            IDcomboBox.DisplayMember = "id";
            LoadDataGridViewSchedule();
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            string ID = IDcomboBox.Text;
            TimeSpan StartSche = TimeSpan.Parse(TB_Start.Text);
            TimeSpan EndSche = TimeSpan.Parse(TB_End.Text);
            DateTime Date = DTP_Schedule.Value;

            if (schedule.insertSchedule(ID, Date, StartSche, EndSche))
            {
                MessageBox.Show("Thành công cập nhật lịch làm việc", "Cập nhật lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Thất bại cập nhật lịch làm việc", "Cập nhật lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            LoadDataGridViewSchedule();
        }
        private void Button_Edit_Click(object sender, EventArgs e)
        {
            string ID = IDcomboBox.Text;
            TimeSpan StartSche = TimeSpan.Parse(TB_Start.Text);
            TimeSpan EndSche = TimeSpan.Parse(TB_End.Text);
            DateTime Date = DTP_Schedule.Value;

            if (schedule.updateSchedule(ID, Date, StartSche, EndSche))
            {
                MessageBox.Show("Thành công cập nhật lịch làm việc", "Cập nhật lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Thất bại cập nhật lịch làm việc", "Cập nhật lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            LoadDataGridViewSchedule();
        }
    }
}
