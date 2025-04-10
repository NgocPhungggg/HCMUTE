using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    public class Borrow
    {
        MyDatabase mydatabase = new MyDatabase();
        public bool InsertBorrow(string IDBorrow,
                                  string IDReader,
                                  int IDBook,
                                  DateTime BorrowDate)
        {
            SqlCommand command = new SqlCommand("INSERT INTO BorrowBooks (BorrowID,ReaderID,BookID,BorrowDate,TienPhat) " +
                                                "VALUES (@idborrow,@idreader,@idbook,@dateborrow,@fee) ", mydatabase.getConnection);
            command.Parameters.Add("@idborrow", SqlDbType.NVarChar).Value = IDBorrow;
            command.Parameters.Add("@idreader", SqlDbType.NVarChar).Value = IDReader;
            command.Parameters.Add("@idbook", SqlDbType.Int).Value = IDBook;
            command.Parameters.Add("@dateborrow", SqlDbType.Date).Value = BorrowDate.Date;
            command.Parameters.Add("@fee", SqlDbType.Int).Value = 0;
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
        public bool UpdateBorrow(string IDBorrow,
                                  string IDReader,
                                  int IDBook,
                                  DateTime BorrowDate,
                                  DateTime ReturnDate,
                                  int Fee)
        {
            SqlCommand command = new SqlCommand("UPDATE BorrowBooks " +
                                                "SET ReaderID = @idreader, " +
                                                    "BookID = @idbook, " +
                                                    "BorrowDate = @dateborrow, " +
                                                    "ReturnDate = @datereturn, " +
                                                    "TienPhat = @Fee " +
                                                "WHERE BorrowID = @idborrow ", mydatabase.getConnection);
            command.Parameters.Add("@idborrow", SqlDbType.NVarChar).Value = IDBorrow;
            command.Parameters.Add("@idreader", SqlDbType.NVarChar).Value = IDReader;
            command.Parameters.Add("@idbook", SqlDbType.Int).Value = IDBook;
            command.Parameters.Add("@dateborrow", SqlDbType.Date).Value = BorrowDate.Date;
            command.Parameters.Add("@datereturn", SqlDbType.Date).Value = ReturnDate.Date;
            command.Parameters.Add("@fee", SqlDbType.Int).Value = Fee;
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
        public bool CompletteBorrow(string IDBorrow,DateTime ReturnDate,int Fee)
        {
            SqlCommand command = new SqlCommand("UPDATE BorrowBooks " +
                                                "SET ReturnDate = @datereturn, " +
                                                    "TienPhat = @Fee " +
                                                "WHERE BorrowID = @idborrow ", mydatabase.getConnection);
            command.Parameters.Add("@idborrow", SqlDbType.NVarChar).Value = IDBorrow;
            command.Parameters.Add("@datereturn", SqlDbType.Date).Value = ReturnDate.Date;
            command.Parameters.Add("@fee", SqlDbType.Int).Value = Fee;
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
