using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Management_Hotel
{
    public class Receptionist
    {
        MyDatabase mydatabase = new MyDatabase();
        public bool InsertReceptionist(string ID,
                          string Fullname,
                          string Gender,
                          DateTime BirthDate,
                          string Mail,
                          string Phone,
                          string Address,
                          MemoryStream Pic)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Information " +
                                                "VALUES (@id,@fn,@gender,@bdate,@mail,@phone,@address,@pic) ", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = Fullname;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = BirthDate;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = Mail;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = Pic.ToArray();
            mydatabase.openConnection();
            command.ExecuteNonQuery();

            command = new SqlCommand("INSERT INTO Employee " +
                                    "VALUES (@id,@pos,@salary) ", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@pos", SqlDbType.VarChar).Value = "Receptionist";
            command.Parameters.Add("@salary", SqlDbType.VarChar).Value = 60000;
            mydatabase.openConnection();
            command.ExecuteNonQuery();

            command = new SqlCommand("INSERT INTO Account " +
                                    "VALUES (@user,@pw) ", mydatabase.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = ID;
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
        public bool EditReceptionist(string ID,
                                string Fullname,
                                string Gender,
                                DateTime BirthDate,
                                string Mail,
                                string Phone,
                                string Address,
                                MemoryStream Pic)
        {
            SqlCommand command = new SqlCommand("UPDATE Information " +
                                                "SET FullName = @fn, " +
                                                    "Gender = @gender, " +
                                                    "BirthDate = @bdate, " +
                                                    "Mail = @mail, " +
                                                    "Phone = @phone, " +
                                                    "Addresss = @address, " +
                                                    "Pic = @pic " +
                                                "WHERE ID = @id ", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = Fullname;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = BirthDate;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = Mail;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = Pic.ToArray();
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
        public bool DeleteReceptionist(string ID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Information WHERE ID = @id", mydatabase.getConnection);
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
        public DataTable GetReceptionist(SqlCommand command)
        {
            command.Connection = mydatabase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
