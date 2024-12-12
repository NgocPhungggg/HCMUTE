using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class Privileges
    {
        DAL dal = new DAL();


        public DataTable GetRolePrivilegsView()
        {
            string query = "SELECT * FROM ADMIN.ROLE_PRIVILEGES_VIEW";
            return dal.ExecuteQuery(query);
        }

        public DataTable GetUserRoleAssignmentsView()
        {
            string query = "SELECT * FROM ADMIN.USER_ROLE_ASSIGNMENTS_VIEW";
            return dal.ExecuteQuery(query);
        }
        public DataTable GetSystemPrivilegesView()
        {
            string query = "SELECT * FROM ADMIN.SYSTEM_PRIVILEGES_VIEW";
            return dal.ExecuteQuery(query);
        }

        public DataTable GetObjectPrivilegesView()
        {
            string query = "SELECT * FROM ADMIN.OBJECT_PRIVILEGES_VIEW";
            DAL dal = new DAL();
            return dal.ExecuteQuery(query);
        }
        public DataTable GetOneRolePrivileges(string role_name)
        {
            string query = "SELECT * FROM ADMIN.ROLE_PRIVILEGES_VIEW WHERE role_name = :role_name";

            return dal.ExecuteQueryDataTable(query, CommandType.Text,
                new string[] { "role_name" },
                new object[] { role_name });
        }
        public DataTable GetOneUserRolePrivileges(string role_name)
        {
            string query = "SELECT * FROM ADMIN.USER_ROLE_ASSIGNMENTS_VIEW WHERE role_name = :role_name";

            return dal.ExecuteQueryDataTable(query, CommandType.Text,
                new string[] { "role_name" },
                new object[] { role_name });
        }
        public DataTable GetOnePrivileges(string username)
        {
            string query = "SELECT * FROM ADMIN.USER_ROLE_ASSIGNMENTS_VIEW WHERE user_or_role = :username";

            return dal.ExecuteQueryDataTable(query, CommandType.Text,
                new string[] { "username" },
                new object[] { username });
        }
        public DataTable GetOneSystemPrivileges(string username)
        {
            string query = "SELECT * FROM ADMIN.SYSTEM_PRIVILEGES_VIEW WHERE user_or_role = :username";

            return dal.ExecuteQueryDataTable(query, CommandType.Text,
                new string[] { "username" },
                new object[] { username });
        }
        public DataTable GetOneObjectPrivileges(string username)
        {
            string query = "SELECT * FROM ADMIN.OBJECT_PRIVILEGES_VIEW WHERE user_or_role = :username";

            return dal.ExecuteQueryDataTable(query, CommandType.Text,
                new string[] { "username" },
                new object[] { username });
        }
        public bool GantManageSystemPrivileges_User(ref string err,
                                                    string privilege,
                                                    string grantee)
        {
            return dal.ExecuteNonQuery(
                "Manage_System_Privileges",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_privilege", "p_grantee", "p_is_role", "p_with_options"},
                new object[] { "GRANT", privilege, grantee, "TRUE"}
            );
        }
        public bool RevokeManageSystemPrivileges_User(ref string err,
                                                    string privilege,
                                                    string grantee)
        {
            return dal.ExecuteNonQuery(
                "Manage_System_Privileges",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_privilege", "p_grantee", "p_is_role", "p_with_options" },
                new object[] { "REVOKE", privilege, grantee, "FALSE" }
            );
        }
        public bool GantManageSystemPrivileges_Role(ref string err,
                                                    string privilege,
                                                    string grantee)
        {
            return dal.ExecuteNonQuery(
                "Manage_System_Privileges",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_privilege", "p_grantee", "p_is_role", "p_with_options" },
                new object[] { "GRANT", privilege, grantee, "TRUE" }
            );
        }
        public bool RevokeManageSystemPrivileges_Role(ref string err,
                                                    string privilege,
                                                    string grantee)
        {
            return dal.ExecuteNonQuery(
                "Manage_System_Privileges",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_privilege", "p_grantee", "p_is_role", "p_with_options" },
                new object[] { "REVOKE", privilege, grantee, "FALSE" }
            );
        }
        public bool GantRole_User(ref string err,
                                      string role_name,
                                      string user_name)
        {
            return dal.ExecuteNonQuery(
                "Manage_Roles",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_role_name", "p_user_name", "p_with_option"},
                new object[] { "GRANT", role_name, user_name, "TRUE" }
            );
        }
        public bool RevokeRole_User(ref string err,
                              string role_name,
                              string user_name)
        {
            return dal.ExecuteNonQuery(
                "Manage_Roles",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_role_name", "p_user_name"},
                new object[] { "REVOKE", role_name, user_name }
            );
        }
        public bool GantObject_Privilegesr(ref string err,
                                                string privilege,
                                                string grantee,
                                                string object_name)
        {
            return dal.ExecuteNonQuery(
                "Manage_Roles",
                CommandType.StoredProcedure,
                ref err,
                new string[] { "p_action", "p_privilege", "p_grantee", "p_object_name", "p_with_option" },
                new object[] { "GRANT", privilege, grantee, object_name, "TRUE" }
            );
        }

    }
}
