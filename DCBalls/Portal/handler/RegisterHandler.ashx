<%@ WebHandler Language="C#" Class="DoubleColor.Redballs.Handler.RegisterHandler" %>

namespace DoubleColor.Redballs.Handler
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    using DoubleColor.Redballs.Repository;
    using System.Web.SessionState;

    public class RegisterHandler : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            var requestForm = context.Request.Form;
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {            
                {"Identity",  requestForm["accountName"]},
                {"TenantName",  requestForm["accountName"]},
                {"TenantPassword", requestForm["passWord"] }
            };

            try
            {
                if (string.Compare(requestForm["vercode"].ToString(), context.Session["CheckCode"].ToString()) != 0)
                {
                    throw new ArgumentDoubleBallException("验证码不匹配"); 
                }
                
                var accountRepository = new AccountRepository();
                accountRepository.Create(parameters);
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