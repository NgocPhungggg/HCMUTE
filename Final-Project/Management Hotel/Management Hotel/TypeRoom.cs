using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel
{
    public class TypeRoom
    {
        MyDatabase mydatabase = new MyDatabase();
        public bool InsertTypeRoom(string name, int cost)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TypeRoom(TypeRoomName, Cost) VALUES (@typeRoomName,@cost)", mydatabase.getConnection);

            command.Parameters.Add("@typeRoomName", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@cost", SqlDbType.Int).Value = cost;

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
        public bool UpdateTypeRoom(string name, int cost)
        {
            SqlCommand command = new SqlCommand("UPDATE TypeRoom SET Cost = @cost WHERE TypeRoomName = @typeRoomName", mydatabase.getConnection);
            command.Parameters.Add("@typeRoomName", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@cost", SqlDbType.Int).Value = cost;

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
        public bool DeleteTypeRoom(string name)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TypeRoom WHERE TypeRoomName = @typeRoomName", mydatabase.getConnection);
            command.Parameters.Add("@typeRoomName", SqlDbType.VarChar).Value = name;

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
        public DataTable GetTypeRoom(SqlCommand command)
        {
            command.Connection = mydatabase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
