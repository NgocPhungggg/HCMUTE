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
    public class Audit
    {
        DAL db = new DAL();

        public Audit()
        {
            db = new DAL();
        }

        public DataTable GetAllAudit()
        {
            string query = "select username, timestamp, obj_name, action_name from dba_audit_trail where obj_name in ('INFO', 'USERS')";
            return db.ExecuteQuery(query);
        }
    }
}
