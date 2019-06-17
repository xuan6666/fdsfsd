using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class TypeDAL
    {
        public int AddType(TypeModel model)
        {
            string sql = string.Format("insert into QjType values('{0}','{1}')", model.qjTypeName, model.qjTypeSay);
            return DBhelper.ExecuteNonQuery(sql);
        }
        public DataTable ShowType()
        {
            string sql = "select * from QjType";
            return DBhelper.GetTable(sql);
        }

    }
}
