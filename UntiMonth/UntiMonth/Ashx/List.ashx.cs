using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using System.Data;
using Newtonsoft.Json;

namespace UntiMonth.Content
{
    /// <summary>
    /// List 的摘要说明
    /// </summary>
    public class List : IHttpHandler
    {
        LeaveBLL bll = new LeaveBLL();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string id = context.Request["id"];
            DataTable dt = bll.ShowLeave(id);
            context.Response.Write(JsonConvert.SerializeObject(dt));
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