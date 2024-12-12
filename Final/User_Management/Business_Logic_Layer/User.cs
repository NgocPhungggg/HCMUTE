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

namespace Business_Logic_Layer
{
    public class User
    {
        DAL dal = new DAL();

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

    }
}
