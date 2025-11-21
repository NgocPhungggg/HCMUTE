using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel
{
    public class Schedule
    {
        MyDatabase mydb = new MyDatabase();

        public bool insertSchedule(string ID, DateTime DateWork, TimeSpan StartSchedule, TimeSpan EndSchedule)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Attendance (ID, DateWork, StartSchedule, EndSchedule) VALUES (@ID, @DateWork, @StartSchedule, @EndSchedule)", mydb.getConnection);

            command.Parameters.Add("@ID",SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@DateWork", SqlDbType.Date).Value = DateWork.Date;
            command.Parameters.Add("@StartSchedule", SqlDbType.Time).Value = StartSchedule;
            command.Parameters.Add("@EndSchedule", SqlDbType.Time).Value = EndSchedule;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateSchedule(string ID, DateTime DateWork, TimeSpan StartSchedule, TimeSpan EndSchedule)
        {
            SqlCommand command = new SqlCommand("UPDATE Attendance SET StartSchedule = @StartSchedule, EndSchedule = @EndSchedule WHERE ID = @ID AND DateWork = @DateWork", mydb.getConnection);

            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@DateWork", SqlDbType.Date).Value = DateWork.Date;
            command.Parameters.Add("@StartSchedule", SqlDbType.Time).Value = StartSchedule;
            command.Parameters.Add("@EndSchedule", SqlDbType.Time).Value = EndSchedule;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
