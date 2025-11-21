using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel
{
    public class DetailService
    {
        MyDatabase mydb = new MyDatabase();
        public bool InsertDetailService(int BillID, string ServiceName, int Quantity, int total)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Detail_Servicess (BillID, ServiceName, Quantity, total) VALUES (@BillID, @ServiceName, @Quantity, @total)", mydb.getConnection);

            command.Parameters.AddWithValue("@BillID", BillID);
            command.Parameters.AddWithValue("@ServiceName", ServiceName);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@total", total);

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool UpdateDetailService(int BillID, string ServiceName, int Quantity, int total)
        {
            SqlCommand command = new SqlCommand("UPDATE Detail_Servicess SET  ServiceName = @ServiceName, Quantity = @Quantity, total = @total WHERE BillID = @BillID", mydb.getConnection);

            command.Parameters.AddWithValue("@BillID", BillID);
            command.Parameters.AddWithValue("@ServiceName", ServiceName);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@total", total);

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool DeleteDetailService(int BillID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Detail_Servicess WHERE BillID = @BillID", mydb.getConnection);

            command.Parameters.AddWithValue("@BillID", BillID);

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable GetDetailService(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
