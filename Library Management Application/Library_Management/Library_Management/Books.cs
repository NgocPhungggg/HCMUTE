using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    public class Books
    {
        MyDatabase mydatabase = new MyDatabase();
        public bool InsertBooks(int ID,
                                  string Title,
                                  string Author,
                                  int Year,
                                  string Genre,
                                  int Quantity)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Books " +
                                                "VALUES (@id,@title,@author,@year,@genre,@quantity) ", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@title", SqlDbType.NVarChar).Value = Title;
            command.Parameters.Add("@author", SqlDbType.NVarChar).Value = Author;
            command.Parameters.Add("@year", SqlDbType.Int).Value = Year;
            command.Parameters.Add("@genre", SqlDbType.NVarChar).Value = Genre;
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = Quantity;
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
        public bool UpdateBooks(int ID, 
                                string Title,
                                string Author,
                                  int Year,
                                  string Genre,
                                  int Quantity)
        {
            SqlCommand command = new SqlCommand("UPDATE Books " +
                                                "SET Title = @title, " +
                                                    "Author = @author, " +
                                                    "PublicationYear = @year, " +
                                                    "Genre = @genre, " +
                                                    "Quantity = @quantity "+
                                                "WHERE BookID = @id ", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@title", SqlDbType.NVarChar).Value = Title;
            command.Parameters.Add("@author", SqlDbType.NVarChar).Value = Author;
            command.Parameters.Add("@year", SqlDbType.Int).Value = Year;
            command.Parameters.Add("@genre", SqlDbType.NVarChar).Value = Genre;
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = Quantity;
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
        public bool DeleteBooks(int ID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Books WHERE BookID = @id", mydatabase.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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
