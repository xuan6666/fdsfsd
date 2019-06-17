using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;

namespace UntiMonth.Ashx
{
    /// <summary>
    /// Del 的摘要说明
    /// </summary>
    public class Del : IHttpHandler
    {
        LeaveBLL bll = new LeaveBLL();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string id = context.Request["id"];
            int n = bll.DelLeave(id);
            context.Response.Write(n);
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