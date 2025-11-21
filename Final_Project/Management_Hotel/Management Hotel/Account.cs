using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel
{
    public class Account
    {
        MyDatabase mydatabase = new MyDatabase();
        public bool ChangePassword(string ID, string Pass)
        {
            SqlCommand command = new SqlCommand("UPDATE Account " +
                                                "SET PW = @pass " +
                                                "WHERE Username = @id", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = Pass;
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
        public DataTable GetAccount(SqlCommand command)
        {
            command.Connection = mydatabase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
