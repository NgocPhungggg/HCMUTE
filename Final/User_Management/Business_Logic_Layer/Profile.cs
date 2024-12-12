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

        public DataTable GetAllProfile()
        {
            string query = "SELECT * FROM ADMIN.USER_PROFILE_INFO";
            return dal.ExecuteQuery(query);
        }

        public bool CreateProfile(ref string err, 
                                    string profile_name, 
                                    int sessions_per_user, 
                                    double connect_time, 
                                    double idle_time)
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
                                    int sessions_per_user, 
                                    double connect_time, 
                                    double idle_time)
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
