using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel
{
    public class Room
    {
        MyDatabase mydatabase = new MyDatabase();
        public bool InsertRoom(string roomid, string typeroomname, bool roomstatus)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Room (RoomID, TypeRoomName, RoomStatus) VALUES (@roomID, @typeRoomName, @roomStatus)", mydatabase.getConnection);

            command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = roomid;
            command.Parameters.Add("@typeRoomName", SqlDbType.VarChar).Value = typeroomname;
            command.Parameters.Add("@roomStatus", SqlDbType.Bit).Value = roomstatus;

            mydatabase.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
        public bool UpdateRoom(string roomid, string typeroomname, bool roomstatus)
        {
            SqlCommand command = new SqlCommand("UPDATE Room SET TypeRoomName = @typeRoomName, RoomStatus = @roomStatus WHERE RoomID = @roomID", mydatabase.getConnection);
            command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = roomid;
            command.Parameters.Add("@typeRoomName", SqlDbType.VarChar).Value = typeroomname;
            command.Parameters.Add("@roomStatus", SqlDbType.Bit).Value = roomstatus;

            mydatabase.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
        public bool DeleteRoom(string roomid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Room WHERE RoomID = @roomID", mydatabase.getConnection);

            command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = roomid;

            mydatabase.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
        public DataTable GetRoom(SqlCommand command)
        {
            command.Connection = mydatabase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
