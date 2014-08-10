<%@ WebHandler Language="C#" Class="DoubleColor.Redballs.Handler.LogonHandler" %>

namespace DoubleColor.Redballs.Handler
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    using DoubleColor.Redballs.Repository;
    using System.Web.SessionState;

    public class LogonHandler : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            var requestForm = context.Request.Form;
           
            try
            {
                var accountRepository = new AccountRepository();
                var account = accountRepository.Read(requestForm["accountName"]);
                if (account == null)
                {
                    throw new AuthenticationDoubleBallException("用户名不存在"); 
                }
                if (string.Equals(requestForm["passWord"], account.TenantPassword))
                {
                    context.Session["IsAuthenticated"] = true;
                    context.Response.Redirect("..\\Order.html");
                }
                else
                {
                    throw new AuthenticationDoubleBallException("用户名或密码不匹配"); 
                }
            }
            catch (Exception e)
            {
                context.Response.ContentType = "text/plain";

                if (e is DoubleBallException)
                {
                    context.Response.Write(e.Message);
                }
                else
                {
                    context.Response.Write("服务器处理异常"); 
                }
            }
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