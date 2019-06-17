using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class TypeBLL
    {
        TypeDAL dal = new TypeDAL();
        public int AddType(TypeModel model)
        {
            return dal.AddType(model);
        }
        public DataTable ShowType()
        {
            return dal.ShowType();
        }
    }
}
