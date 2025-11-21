using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    public class Employees
    {
        MyDatabase mydatabase = new MyDatabase();
        public bool InsertEmployees(string ID,
                                  string Name,
                                  string Phone,
                                  string IDCard,
                                  string Address)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Employees " +
                                                "VALUES (@id,@n,@phone,@idcard,@address,@id,@pw) ", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@n", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@idcard", SqlDbType.VarChar).Value = IDCard;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = "123";
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
        public bool UpdateEmployees(string ID,
                                  string Name,
                                  string Phone,
                                  string IDCard,
                                  string Address)
        {
            SqlCommand command = new SqlCommand("UPDATE Employees " +
                                                "SET EmployeeName = @n, " +
                                                    "Phone = @phone, " +
                                                    "IDCard = @idcard, " +
                                                    "Address = @address " +
                                                "WHERE EmployeeID = @id ", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@n", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@idcard", SqlDbType.VarChar).Value = IDCard;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = Address;
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
        public bool DeleteEmployees(string ID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = @id", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
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
        public DataTable GetBooks(SqlCommand command)
        {
            command.Connection = mydatabase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
