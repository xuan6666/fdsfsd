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
    public class LeaveBLL
    {
        LeaveDAL dal = new LeaveDAL();
        public int AddLeave(LeaveModel model)
        {
            return dal.AddLeave(model);
        }
        public DataTable ShowLeave(string id)
        {
            return dal.ShowLeave(id);
        }
        public int DelLeave(string id)
        {
            return dal.DelLeave(id);
        }
        public int UptLeave(LeaveModel model)
        {
            return dal.UptLeave(model);
        }
    }
}
