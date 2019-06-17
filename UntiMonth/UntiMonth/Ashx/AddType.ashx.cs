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
    /// AddType 的摘要说明
    /// </summary>
    public class AddType : IHttpHandler
    {
        TypeBLL bll = new TypeBLL();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string obj = context.Request["obj"];
            TypeModel model = JsonConvert.DeserializeObject<TypeModel>(obj);
            context.Response.Write(bll.AddType(model));
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