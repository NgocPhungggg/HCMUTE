using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    public class ChangePW
    {
        MyDatabase mydatabase = new MyDatabase();
        public bool ChangePWEmployee(string ID, string Pass)
        {
            SqlCommand command = new SqlCommand("UPDATE Employees SET Password = @pw WHERE EmployeeID = @id ", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@pw", SqlDbType.NVarChar).Value = Pass;
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
        public bool ChangePWReader(string ID, string Pass)
        {
            SqlCommand command = new SqlCommand("UPDATE Readers SET Password = @pw WHERE ReaderID = @id ", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@pw", SqlDbType.NVarChar).Value = Pass;
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
    }
}
