using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;

namespace Business_Logic_Layer
{
    public class User
    {
        DAL dal = new DAL();
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Chuyển byte sang hex string
                }
                return builder.ToString();
            }
        }

        public bool CheckLogin(string connectionString)
        {
            if (dal.CheckConnection(connectionString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int findUser(ref string err, string username, string password)
        {
            string query = "SELECT COUNT(*) FROM ADMIN.USERS WHERE USERNAME = :username AND PASSWORD = :hashed_password";
            return dal.ExecuteScalar(query, CommandType.Text, ref err,
                    new string[] { "username", "hashed_password" },
                    new object[] { username, HashPassword(password) });
        }


        public DataTable GetInfoUsers()
        {
            string query = "SELECT * FROM admin.Info";
            return dal.ExecuteQuery(query);
        }

        public DataTable GetAllUser()
        {
            string query = "SELECT * FROM ADMIN.USER_ACCOUNT_INFO";
            return dal.ExecuteQuery(query);
        }

        public DataTable GetAllDefaultTablespace()
        {
            return dal.ExecuteQuery("SELECT * FROM ADMIN.DEFAULT_TABLESPACES");
        }

        public DataTable GetAllTemporaryTablespace()
        {
            return dal.ExecuteQuery("SELECT * FROM ADMIN.TEMPORARY_TABLESPACES");
        }


        public DataTable GetAllSystemPrivilege(string username)
        {
            string query = "SELECT * FROM ADMIN.USER_PRIVILEGES_INFO WHERE USERNAME = :username";

            return dal.ExecuteQueryDataTable(query, CommandType.Text,
                new string[] { "username" },
                new object[] { username });
        }

        public DataTable GetAllObjectPrivilege(string username)
        {
            string query = "SELECT * FROM ADMIN.USER_OBJECT_PRIVILEGES_INFO WHERE USERNAME = :username";

            return dal.ExecuteQueryDataTable(query, CommandType.Text,
                new string[] { "username" },
                new object[] { username });
        }

        public bool CreateUser(ref string err, string username, string password, string default_tablespace, string temporary_tablespace, string quota, string account_status, string profile, string role)
        {
            return dal.ExecuteNonQuery("ManageUser", CommandType.StoredProcedure, ref err,
                new string[] { "p_action", "p_username", "p_password", "p_default_tablespace", "p_temporary_tablespace", "p_quota", "p_account_status", "p_profile", "p_role" },
                new object[] { "CREATE", username, password, default_tablespace, temporary_tablespace, quota, account_status, profile, role });
        }

        public bool DeleteUser(ref string err, string username)
        {
            return dal.ExecuteNonQuery("ManageUser", CommandType.StoredProcedure, ref err,
                new string[] { "p_action", "p_username" },
                new object[] { "DROP", username });
        }

        public bool UpdateUser(ref string err, string username, string password, string default_tablespace, string temporary_tablespace, string quota, string account_status, string profile, string role)
        {
            return dal.ExecuteNonQuery("ManageUser", CommandType.StoredProcedure, ref err,
                new string[] { "p_action", "p_username", "p_password", "p_default_tablespace", "p_temporary_tablespace", "p_quota", "p_account_status", "p_profile", "p_role" },
                new object[] { "ALTER", username, password, default_tablespace, temporary_tablespace, quota, account_status, profile, role });
        }

        public bool InsertIntoUserTable(ref string err, string username, string hashedPassword)
        {
            string query = "INSERT INTO ADMIN.USERS (username, password) VALUES(:username, :hashed_password)"; ;
            return dal.ExecuteNonQuery(query, CommandType.Text, ref err,
                new string[] { "username", "hashed_password" },
                new object[] { username, HashPassword(hashedPassword) });
        }

        public bool UpdateUserTable(ref string err, string username, string password)
        {
            string query = "UPDATE ADMIN.USERS SET PASSWORD = :hashed_password WHERE USERNAME = :username"; ;
            return dal.ExecuteNonQuery(query, CommandType.Text, ref err,
                new string[] { "username", "hashed_password" },
                new object[] { username, HashPassword(password) });
        }

        public bool DeleteFromUserTable(ref string err, string username)
        {
            string query = "DELETE FROM ADMIN.USERS WHERE USERNAME = :username"; ;
            return dal.ExecuteNonQuery(query, CommandType.Text, ref err,
                new string[] { "username" },
                new object[] { username });
        }

    }
}
