using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel
{
    public class Attendance
    {
        MyDatabase mydatabase = new MyDatabase();
        public bool InsertAttendance(string ID,
                                     DateTime StartTime)
        {
            SqlCommand command = new SqlCommand("UPDATE Attendance " +
                                                "SET StartTime = @start " +
                                                "WHERE ID = @id AND DateWork = @date", mydatabase.getConnection);
            string TimeWork = StartTime.ToString("HH:mm:ss");
            TimeSpan Time = TimeSpan.Parse(TimeWork);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@start", SqlDbType.Time).Value = Time;
            command.Parameters.Add("@date", SqlDbType.Date).Value = StartTime.Date;
            mydatabase.openConnection();

            if ((command.ExecuteNonQuery()) == 1)
            {
                mydatabase.closeConnection();
                return true;
            }
            else
            {
                mydatabase.closeConnection();
                return false;
            }
        }
        public bool UpdateAttendance(string ID,
                                     DateTime StartTime)
        {
            SqlCommand command = new SqlCommand("UPDATE Attendance " +
                                                "SET EndTime = @end " +
                                                "WHERE ID = @id AND DateWork = @date ", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            string TimeWork = StartTime.ToString("HH:mm:ss");
            TimeSpan Time = TimeSpan.Parse(TimeWork);
            command.Parameters.Add("@end", SqlDbType.Time).Value = Time;
            command.Parameters.Add("@date", SqlDbType.Date).Value = StartTime.Date;
            mydatabase.openConnection();

            if ((command.ExecuteNonQuery()) == 1)
            {
                mydatabase.closeConnection();
                return true;
            }
            else
            {
                mydatabase.closeConnection();
                return false;
            }
        }
        public DataTable GetAttendance(SqlCommand command)
        {
            command.Connection = mydatabase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
