using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class LeaveDAL
    {
        public int AddLeave(LeaveModel model)
        {
            string sql = string.Format("insert into AllLeave values('{0}','{1}',{2},'{3}',{4})",
                model.lName,model.lPeople,model.lNum,model.lYuanYin,model.lTypeid);
            return DBhelper.ExecuteNonQuery(sql);
        }
        public DataTable ShowLeave(string id)
        {
            string sql = "select * from AllLeave join QjType on AllLeave.lTypeid=QjType.qjTypeid where 1=1";
            if(id!="")
            {
                sql += "and id=" + id; ;
            }
            return DBhelper.GetTable(sql);
        }
        public int DelLeave(string id)
        {
            string sql = "delete from AllLeave where id in (" + id+")";
            return DBhelper.ExecuteNonQuery(sql);
        }
        public int UptLeave(LeaveModel model)
        {
            string sql = string.Format("update  AllLeave set lName='{0}',lPeople='{1}',lNum={2},lYuanYin='{3}',lTypeid={4} where id={5}", model.lName, model.lPeople, model.lNum, model.lYuanYin, model.lTypeid,model.id);
            return DBhelper.ExecuteNonQuery(sql);
        }
    }
}
