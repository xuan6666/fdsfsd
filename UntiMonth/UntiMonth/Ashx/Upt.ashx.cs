using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Model;
using Newtonsoft.Json;

namespace UntiMonth.Content
{
    /// <summary>
    /// Upt 的摘要说明
    /// </summary>
    public class Upt : IHttpHandler
    {
        LeaveBLL bll = new LeaveBLL();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string obj = context.Request["obj"];
            LeaveModel model = JsonConvert.DeserializeObject<LeaveModel>(obj);
            context.Response.Write(bll.UptLeave(model));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}