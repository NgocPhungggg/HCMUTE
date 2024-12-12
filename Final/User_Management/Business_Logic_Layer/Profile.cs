using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class Profile
    {
        DAL dal = null;

        public Profile()
        {
            dal = new DAL();
        }

        public DataTable GetUserProfile()
        {
            string query = "SELECT * FROM ADMIN.LIST_PROFILE WHERE USERNAME IS NOT NULL";
            return dal.ExecuteQuery(query);
        }

        public DataTable GetUserProfile(string profile)
        {
            string query = "SELECT * FROM ADMIN.LIST_PROFILE WHERE PROFILE = :profile";
            return dal.ExecuteQueryDataTable(query, CommandType.Text,
                new string[] { "profile" },
                new object[] { profile });

        }

        public DataTable GetAllProfile()
        {
            string query = "SELECT DISTINCT PROFILE FROM ADMIN.LIST_PROFILE";
            return dal.ExecuteQuery(query);
        }

        public DataTable GetInfoProfile()
        {
            string query = "SELECT * FROM ADMIN.PROFILE_INFO";
            return dal.ExecuteQuery(query);
        }


        public DataTable GetInfoProfile(string profile)
        {
            string query = "SELECT * FROM ADMIN.PROFILE_INFO WHERE PROFILE = :profile";
            return dal.ExecuteQueryDataTable(query, CommandType.Text,
                new string[] { "profile" },
                new object[] { profile });
        }


        public bool CreateProfile(ref string err, 
                                    string profile_name, 
                                    string sessions_per_user,
                                    string connect_time,
                                    string idle_time)
        {
            return dal.ExecuteNonQuery(
                "ManageProfile",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_profile_name", "p_sessions_per_user", "p_connect_time", "p_idle_time" },
                new object[] { "CREATE", profile_name, sessions_per_user, connect_time, idle_time }
            );
        }
        public bool DeleteProfile(ref string err, 
                                    string profile_name)
        {
            return dal.ExecuteNonQuery(
                "ManageProfile",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_profile_name" },  // Tên tham số
                new object[] { "DROP", profile_name }           // Giá trị tham số
            );
        }
        public bool UpdateProfile(ref string err, 
                                    string profile_name,
                                    string sessions_per_user,
                                    string connect_time,
                                    string idle_time)
        {
            return dal.ExecuteNonQuery(
                "ManageProfile",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_profile_name", "p_sessions_per_user", "p_connect_time", "p_idle_time" }, // Tên tham số
                new object[] { "ALTER", profile_name, sessions_per_user, connect_time, idle_time }                    // Giá trị tham số
            );
        }


    }

}
