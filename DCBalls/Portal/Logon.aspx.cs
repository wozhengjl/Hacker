﻿namespace DoubleColor.Redballs.Portal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using DoubleColor.Redballs.Common;
    using DoubleColor.Redballs.Repository;

    public partial class Logon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.RequestType.ToUpper() == "POST")
            {
                var requestForm = Request.Form;

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
                        UserInfo userinfo = new UserInfo();
                        userinfo.UserName = requestForm["accountName"];
                        userinfo.GroupId = 2;

                        // 登录状态100分钟内有效
                        FormsPrincipal<UserInfo>.SignIn(requestForm["accountName"].ToString(), userinfo, 100);

                        Response.Redirect("/Portal/Order.aspx");
                    }
                    else
                    {
                        throw new AuthenticationDoubleBallException("用户名或密码不匹配");
                    }
                }
                catch (Exception exception)
                {
                    Response.ContentType = "text/plain";

                    if (exception is DoubleBallException)
                    {
                        Response.Write(exception.Message);
                    }
                    else
                    {
                        Response.Write("服务器处理异常");
                    }
                }
            }
        }
    }
}