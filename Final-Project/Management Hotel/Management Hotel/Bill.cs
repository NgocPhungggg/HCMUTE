using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel
{
    public class Bill
    {
        MyDatabase mydatabase = new MyDatabase();

        public bool InserBill(int BillID, string RoomID, string CustomerID, DateTime CheckIn, DateTime? CheckOut, int ReservedDays, int? TotalMoney, float? Discount, DateTime? PayTime, string Payment, string EmployeeID)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Bill (BillID, RoomID, CustomerID, CheckIn, CheckOut, ReservedDays, TotalMoney, Discount, PayTime, Payment, EmployeeID) VALUES (@BillID,@RoomID,@CustomerID,@CheckIn,@CheckOut,@ReservedDays,@TotalMoney,@Discount,@PayTime,@Payment,@EmployeeID)", mydatabase.getConnection);

            command.Parameters.Add("@BillID", SqlDbType.Int).Value = BillID;
            command.Parameters.Add("@RoomID", SqlDbType.VarChar).Value = RoomID;
            command.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = CustomerID;
            command.Parameters.Add("@CheckIn", SqlDbType.DateTime).Value = CheckIn;
            command.Parameters.Add("@CheckOut", SqlDbType.DateTime).Value = CheckOut != null && CheckOut != DateTime.MinValue ? CheckOut : (object)DBNull.Value;
            command.Parameters.Add("@ReservedDays", SqlDbType.Int).Value = ReservedDays;
            command.Parameters.Add("@TotalMoney", SqlDbType.Money).Value = TotalMoney != null && TotalMoney != 0 ? TotalMoney : (object)DBNull.Value;
            command.Parameters.Add("@Discount", SqlDbType.Float).Value = Discount != null ? Discount : (object)DBNull.Value;
            command.Parameters.Add("@PayTime", SqlDbType.DateTime).Value = PayTime != null && PayTime != DateTime.MinValue ? PayTime : (object)DBNull.Value;
            command.Parameters.Add("@Payment", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(Payment) ? (object)DBNull.Value : Payment;
            command.Parameters.Add("@EmployeeID", SqlDbType.VarChar).Value = EmployeeID;

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
        public bool UpdateBill(int BillID, string RoomID, string CustomerID, DateTime CheckIn, DateTime? CheckOut, int ReservedDays, int? TotalMoney, float? Discount, DateTime? PayTime, string Payment, string EmployeeID)
        {
            SqlCommand command = new SqlCommand("UPDATE Bill SET RoomID=@RoomID, " +
                                                                "CustomerID=@CustomerID, " +
                                                                "CheckIn=@CheckIn, " +
                                                                "CheckOut=@CheckOut, " +
                                                                "ReservedDays=@ReservedDays, " +
                                                                "TotalMoney=@TotalMoney, " +
                                                                "Discount=@Discount, " +
                                                                "PayTime=@PayTime, " +
                                                                "Payment=@Payment, " +
                                                                "EmployeeID=@EmployeeID " +
                                                "WHERE BillID=@BillID", mydatabase.getConnection);

            command.Parameters.Add("@BillID", SqlDbType.Int).Value = BillID;
            command.Parameters.Add("@RoomID", SqlDbType.VarChar).Value = RoomID;
            command.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = CustomerID;
            command.Parameters.Add("@CheckIn", SqlDbType.DateTime).Value = CheckIn;
            command.Parameters.Add("@CheckOut", SqlDbType.DateTime).Value = CheckOut != null && CheckOut != DateTime.MinValue ? CheckOut : (object)DBNull.Value;
            command.Parameters.Add("@ReservedDays", SqlDbType.Int).Value = ReservedDays;
            command.Parameters.Add("@TotalMoney", SqlDbType.Money).Value = TotalMoney != null && TotalMoney != 0 ? TotalMoney : (object)DBNull.Value;
            command.Parameters.Add("@Discount", SqlDbType.Float).Value = Discount != null ? Discount : (object)DBNull.Value;
            command.Parameters.Add("@PayTime", SqlDbType.DateTime).Value = PayTime != null && PayTime != DateTime.MinValue ? PayTime : (object)DBNull.Value;
            command.Parameters.Add("@Payment", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(Payment) ? (object)DBNull.Value : Payment;
            command.Parameters.Add("@EmployeeID", SqlDbType.VarChar).Value = EmployeeID;

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
        public bool InsertBillCheckin(int BillID, string RoomID, string CustomerID, DateTime CheckIn, int ReservedDays, string EmployeeID)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Bill (BillID, RoomID, CustomerID, CheckIn, ReservedDays, Discount, EmployeeID) VALUES (@BillID,@RoomID,@CustomerID,@CheckIn,@ReservedDays,@Discount,@EmployeeID)", mydatabase.getConnection);

            command.Parameters.Add("@BillID", SqlDbType.Int).Value = BillID;
            command.Parameters.Add("@RoomID", SqlDbType.VarChar).Value = RoomID;
            command.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = CustomerID;
            command.Parameters.Add("@CheckIn", SqlDbType.DateTime).Value = CheckIn;
            command.Parameters.Add("@ReservedDays", SqlDbType.Int).Value = ReservedDays;
            command.Parameters.Add("@Discount", SqlDbType.Float).Value = 0.0;
            command.Parameters.Add("@EmployeeID", SqlDbType.VarChar).Value = EmployeeID;

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
        public bool UpdateBillCheckin(int BillID, string RoomID, string CustomerID, DateTime CheckIn, int ReservedDays, string EmployeeID)
        {
            SqlCommand command = new SqlCommand("UPDATE Bill SET RoomID=@RoomID, CustomerID=@CustomerID, CheckIn=@CheckIn, ReservedDays=@ReservedDays,  EmployeeID=@EmployeeID WHERE BillID=@BillID", mydatabase.getConnection);

            command.Parameters.Add("@BillID", SqlDbType.Int).Value = BillID;
            command.Parameters.Add("@RoomID", SqlDbType.VarChar).Value = RoomID;
            command.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = CustomerID;
            command.Parameters.Add("@CheckIn", SqlDbType.DateTime).Value = CheckIn;
            command.Parameters.Add("@ReservedDays", SqlDbType.Int).Value = ReservedDays;
            command.Parameters.Add("@EmployeeID", SqlDbType.VarChar).Value = EmployeeID;

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
        public bool InsertBillCheckout(DateTime CheckOut, int TotalMoney, float Discount, DateTime PayTime, string Payment)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Bill (CheckOut, TotalMoney, Discount, PayTime, Payment) VALUES (@BillID,@RoomID,@CustomerID,@CheckOut,@TotalMoney,@Discount,@PayTime,@Payment,@EmployeeID)", mydatabase.getConnection);

            command.Parameters.Add("@CheckOut", SqlDbType.DateTime).Value = CheckOut;
            command.Parameters.Add("@TotalMoney", SqlDbType.Money).Value = TotalMoney;
            command.Parameters.Add("@Discount", SqlDbType.Float).Value = Discount;
            command.Parameters.Add("@PayTime", SqlDbType.DateTime).Value = PayTime;
            command.Parameters.Add("@Payment", SqlDbType.NVarChar).Value = Payment;


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
        public bool UpdateBillCheckout(int BillID, DateTime CheckOut, int TotalMoney, float Discount, DateTime PayTime, string Payment)
        {
            SqlCommand command = new SqlCommand("UPDATE Bill SET  CheckOut=@CheckOut,  TotalMoney=@TotalMoney, Discount=@Discount, PayTime=@PayTime, Payment=@Payment WHERE BillID=@BillID", mydatabase.getConnection);

            command.Parameters.Add("@BillID", SqlDbType.Int).Value = BillID;
            command.Parameters.Add("@CheckOut", SqlDbType.DateTime).Value = CheckOut;
            command.Parameters.Add("@TotalMoney", SqlDbType.Money).Value = TotalMoney;
            command.Parameters.Add("@Discount", SqlDbType.Float).Value = Discount;
            command.Parameters.Add("@PayTime", SqlDbType.DateTime).Value = PayTime;
            command.Parameters.Add("@Payment", SqlDbType.NVarChar).Value = Payment;

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
        public bool DeleteBill(int BillID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Bill WHERE BillID=@BillID", mydatabase.getConnection);
            command.Parameters.Add("@BillID", SqlDbType.Int).Value = BillID;

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
        public DataTable GetBill(SqlCommand command)
        {
            command.Connection = mydatabase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
