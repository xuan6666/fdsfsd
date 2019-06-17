using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using System.Data;
using Newtonsoft.Json;

namespace UntiMonth.Ashx
{
    /// <summary>
    /// XiaLa 的摘要说明
    /// </summary>
    public class XiaLa : IHttpHandler
    {
        TypeBLL bll = new TypeBLL();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            DataTable dt = bll.ShowType();
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