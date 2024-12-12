using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Data_Access_Layer
{
    public class DAL
    {
        private static string connectionString;
        OracleConnection conn = null;
        OracleCommand cmd = null;
        public static void SetConnectionString(string connectionString)
        {
            DAL.connectionString = connectionString;
        }

        public static string GetConnectionString()
        {
            return DAL.connectionString;
        }

        public bool CheckConnection(string connectionString)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open(); 
                    SetConnectionString(connectionString);
                    return true;
                }
            }
            catch (Exception)
            {
                return false; 
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            try
            {
                string currentConnectionString = GetConnectionString();
                if (string.IsNullOrEmpty(currentConnectionString))
                {
                    throw new InvalidOperationException("Connection string is not set. Please check the connection first.");
                }

                using (OracleConnection connection = new OracleConnection(currentConnectionString))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open(); // Mở kết nối
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable); // Đổ dữ liệu vào DataTable
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing query", ex);
            }
        }
        public DataTable ExecuteQueryDataTable(string query, CommandType commandType, string[] parameterNames, object[] parameterValues)
        {
            try
            {
                string currentConnectionString = GetConnectionString();
                if (string.IsNullOrEmpty(currentConnectionString))
                {
                    throw new InvalidOperationException("Connection string is not set. Please check the connection first.");
                }

                using (OracleConnection connection = new OracleConnection(currentConnectionString))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.CommandType = commandType;

                        if (parameterNames != null && parameterValues != null)
                        {
                            if (parameterNames.Length != parameterValues.Length)
                            {
                                throw new ArgumentException("Parameter names and values must have the same length.");
                            }

                            for (int i = 0; i < parameterNames.Length; i++)
                            {
                                command.Parameters.Add(new OracleParameter(parameterNames[i], parameterValues[i]));
                            }
                        }

                        connection.Open();
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable); // Đổ dữ liệu vào DataTable
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing query: {query}. Details: {ex.Message}", ex);
            }
        }
        public bool ExecuteNonQuery(string strSQL, CommandType ct, ref string error, string[] parameterNames, object[] parameterValues)
        {
            bool success = false; // Cờ để kiểm tra kết quả
            try
            {
                // Lấy chuỗi kết nối hiện tại
                string currentConnectionString = GetConnectionString();
                if (string.IsNullOrEmpty(currentConnectionString))
                {
                    throw new InvalidOperationException("Connection string is not set. Please check the connection first.");
                }

                // Tạo kết nối mới dựa trên currentConnectionString
                using (OracleConnection connection = new OracleConnection(currentConnectionString))
                {
                    connection.Open(); // Mở kết nối

                    // Tạo lệnh với kết nối vừa tạo
                    using (OracleCommand command = new OracleCommand(strSQL, connection))
                    {
                        command.CommandType = ct;

                        // Thêm các tham số vào lệnh
                        if (parameterNames != null && parameterValues != null)
                        {
                            if (parameterNames.Length != parameterValues.Length)
                            {
                                throw new ArgumentException("Parameter names and values must have the same length.");
                            }

                            for (int i = 0; i < parameterNames.Length; i++)
                            {
                                command.Parameters.Add(new OracleParameter(parameterNames[i], parameterValues[i]));
                            }
                        }

                        // Thực thi lệnh
                        command.ExecuteNonQuery();
                        success = true; // Đánh dấu thành công
                    }
                }
            }
            catch (OracleException ex)
            {
                error = ex.Message; // Ghi lại lỗi nếu xảy ra
            }
            return success;
        }

        //public bool ExecuteNonQuery(string strSQL, CommandType ct, ref string error, string[] parameterNames, object[] parameterValues)
        //{
        //    bool f = false;
        //    try
        //    {
        //        if (conn.State == ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //        conn.Open();
        //        cmd.Parameters.Clear();
        //        cmd.CommandType = ct;
        //        cmd.CommandText = strSQL;

        //        // Chuyển đổi dữ liệu thô thành OracleParameter[]
        //        if (parameterNames != null && parameterValues != null)
        //        {
        //            if (parameterNames.Length != parameterValues.Length)
        //            {
        //                throw new ArgumentException("Parameter names and values must have the same length.");
        //            }

        //            for (int i = 0; i < parameterNames.Length; i++)
        //            {
        //                cmd.Parameters.Add(new OracleParameter(parameterNames[i], parameterValues[i]));
        //            }
        //        }

        //        cmd.ExecuteNonQuery();
        //        f = true;
        //    }
        //    catch (OracleException ex)
        //    {
        //        error = ex.Message;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return f;
        //}
    }
}
