using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class Role
    {
        DAL dal = new DAL();
        public bool CreateRole(ref string err,
                                    string role_name,
                                    string password)
        {
            return dal.ExecuteNonQuery(
                "Manage_Role",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_role_name", "p_password"}, 
                new object[] { "CREATE", role_name, password }                
            );
        }
        public bool CreateRoleNoPassWord(ref string err,
                                         string role_name)
        {
            return dal.ExecuteNonQuery(
                "Manage_Role",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_role_name"},
                new object[] { "CREATE", role_name}
            );
        }

        public bool DropRole(ref string err,
                             string role_name)
        {
            return dal.ExecuteNonQuery(
                "Manage_Role",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_role_name"},
                new object[] { "DROP", role_name}
            );
        }
        public bool AlterRole(ref string err,
                            string role_name,
                            string password)
        {
            return dal.ExecuteNonQuery(
                "Manage_Role",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_role_name", "p_password" },
                new object[] { "ALTER", role_name, password }
            );
        }
    }
}
