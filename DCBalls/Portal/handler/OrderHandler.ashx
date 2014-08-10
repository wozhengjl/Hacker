<%@ WebHandler Language="C#" Class="DoubleColor.Redballs.Handler.OrderHandler" %>

namespace DoubleColor.Redballs.Handler
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    using DoubleColor.Redballs.Repository;
    using System.Web.SessionState;

    public class OrderHandler : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            var requestForm = context.Request.Form;
            
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