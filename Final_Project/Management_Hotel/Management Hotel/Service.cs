using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel
{
    public class Service
    {
        MyDatabase mydatabase = new MyDatabase();
        public bool InsertService(string svname, int cost)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Servicess VALUES (@serviceName, @cost)", mydatabase.getConnection);

            command.Parameters.Add("@serviceName", SqlDbType.VarChar).Value = svname;
            command.Parameters.Add("@cost", SqlDbType.Money).Value = cost;

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

        public bool UpdateService(string svname, int cost)
        {
            SqlCommand command = new SqlCommand("UPDATE Servicess  SET Cost = @cost WHERE ServiceName = @serviceName", mydatabase.getConnection);
            command.Parameters.Add("@serviceName", SqlDbType.VarChar).Value = svname;
            command.Parameters.Add("@cost", SqlDbType.Money).Value = cost;

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

        public bool DeleteService(string name)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Servicess WHERE ServiceName = @serviceName", mydatabase.getConnection);

            command.Parameters.Add("@serviceName", SqlDbType.VarChar).Value = name;

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
        public DataTable getService(SqlCommand command)
        {
            command.Connection = mydatabase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
