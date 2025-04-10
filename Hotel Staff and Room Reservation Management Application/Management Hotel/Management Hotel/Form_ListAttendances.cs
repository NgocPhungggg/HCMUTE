using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Management_Hotel.Global;

namespace Management_Hotel
{
    public partial class Form_ListAttendances : Form
    {
        public Form_ListAttendances()
        {
            InitializeComponent();
        }
        Receptionist receptionist = new Receptionist();
        Room room = new Room();
        MyDatabase mydb = new MyDatabase();
        Attendance attendance = new Attendance();
        private void LoadDataGridView ()
        {
            this.attendanceTableAdapter.Fill(this.hotel_ManagementDataSet.Attendance);
            SqlCommand command = new SqlCommand("SELECT * FROM Attendance A");
            DataGridView_ListJanitors.ReadOnly = true;
            DataGridView_ListJanitors.DataSource = receptionist.GetReceptionist(command);
            DataGridView_ListJanitors.AllowUserToAddRows = false;
        }
        private void LoadDataGridViewSalary(SqlCommand SQLcommand)
        {
            DataGridView_Salary.ReadOnly = true;
            DataGridView_Salary.DataSource = attendance.GetAttendance(SQLcommand);
            DataGridView_Salary.AllowUserToAddRows = false;
        }
        private void Form_ListAttendances_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.acc == "123456")
            {
                LoadDataGridView();
                DateTimePicker_Salary.Format = DateTimePickerFormat.Custom;
                DateTimePicker_Salary.CustomFormat = "yyyy-MM";
                DateTime now = DateTime.Now;
                SqlCommand commandsalary = new SqlCommand("SELECT A.ID, FullName, Position, SUM(DATEDIFF(Hour, StartTime, EndTime)*Salary) AS Salary " +
                                                    "FROM Employee E, Attendance A, Information I " +
                                                    "WHERE A.ID = E.ID AND  A.ID = I.ID AND MONTH(DateWork) = @month AND YEAR (DateWork) = @year " +
                                                    "GROUP BY A.ID,FullName, Position");
                commandsalary.Parameters.Add("@month", SqlDbType.Int).Value = now.Month;
                commandsalary.Parameters.Add("@year", SqlDbType.Int).Value = now.Year;
                LoadDataGridViewSalary(commandsalary);
            }
            else
            {
                string id = GlobalVariables.acc;
                SqlCommand command = new SqlCommand("SELECT * FROM Attendance WHERE ID = @id ", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                DataTable table = room.GetRoom(command);
                DataGridView_ListJanitors.DataSource = table;

                DateTimePicker_Salary.Format = DateTimePickerFormat.Custom;
                DateTimePicker_Salary.CustomFormat = "yyyy-MM";
                DateTime now = DateTime.Now;
                SqlCommand commandsalary = new SqlCommand("SELECT A.ID, FullName, Position, SUM(DATEDIFF(Hour, StartTime, EndTime)*Salary) AS Salary " +
                                                    "FROM Employee E, Attendance A, Information I " +
                                                    "WHERE A.ID = E.ID AND A.ID = I.ID AND A.ID = @id AND MONTH(DateWork) = @month AND YEAR (DateWork) = @year " +
                                                    "GROUP BY A.ID,FullName, Position");
                commandsalary.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                commandsalary.Parameters.Add("@month", SqlDbType.Int).Value = now.Month;
                commandsalary.Parameters.Add("@year", SqlDbType.Int).Value = now.Year;
                LoadDataGridViewSalary(commandsalary);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.CustomFormat = "yyyy-MM-dd";
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = "yyyy-MM-dd";
            if (GlobalVariables.acc == "123456")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Attendance WHERE DateWork >= '" + dtpNgayBatDau.Text + "' AND DateWork <= '" + dtpNgayKetThuc.Text + "'", mydb.getConnection);
                DataTable table = room.GetRoom(command);
                DataGridView_ListJanitors.DataSource = table;
            }
            else
            {
                string id = GlobalVariables.acc;
                SqlCommand command = new SqlCommand("SELECT * FROM Attendance WHERE ID = @id AND DateWork >= '" + dtpNgayBatDau.Text + "' AND DateWork <= '" + dtpNgayKetThuc.Text + "'", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                DataTable table = room.GetRoom(command);
                DataGridView_ListJanitors.DataSource = table;
            }
        }

        private void Button_Select_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.acc == "123456")
            {
                SqlCommand command = new SqlCommand("SELECT A.ID, FullName, Position, SUM(DATEDIFF(Hour, StartTime, EndTime)*Salary) AS Salary " +
                                    "FROM Employee E, Attendance A, Information I " +
                                    "WHERE A.ID = E.ID AND A.ID = I.ID AND MONTH(DateWork) = @month AND YEAR (DateWork) = @year " +
                                    "GROUP BY A.ID,FullName, Position");
                command.Parameters.Add("@month", SqlDbType.Int).Value = DateTimePicker_Salary.Value.Month;
                command.Parameters.Add("@year", SqlDbType.Int).Value = DateTimePicker_Salary.Value.Year;
                LoadDataGridViewSalary(command);
            }
            else
            {
                string id = GlobalVariables.acc;
                SqlCommand commandsalary = new SqlCommand("SELECT A.ID, FullName, Position, SUM(DATEDIFF(Hour, StartTime, EndTime)*Salary) AS Salary " +
                                    "FROM Employee E, Attendance A, Information I " +
                                    "WHERE A.ID = E.ID AND A.ID = I.ID AND A.ID = @id AND MONTH(DateWork) = @month AND YEAR (DateWork) = @year " +
                                    "GROUP BY A.ID,FullName, Position");
                commandsalary.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                commandsalary.Parameters.Add("@month", SqlDbType.Int).Value = DateTimePicker_Salary.Value.Month;
                commandsalary.Parameters.Add("@year", SqlDbType.Int).Value = DateTimePicker_Salary.Value.Year;
                LoadDataGridViewSalary(commandsalary);
            }
        }
    }
}
