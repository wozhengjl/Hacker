namespace DoubleColor.Redballs.Portal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using DoubleColor.Redballs.Repository;

    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.RequestType.ToUpper() == "POST")
            {
                var requestForm = Request.Form;
                Dictionary<string, string> parameters = new Dictionary<string, string>
                {            
                    {"Identity",  requestForm["accountName"]},
                    {"TenantName",  requestForm["accountName"]},
                    {"TenantPassword", requestForm["passWord"] }
                };

                try
                {
                    if (string.Compare(requestForm["vercode"].ToString(), Session["CheckCode"].ToString()) != 0)
                    {
                        throw new ArgumentDoubleBallException("验证码不匹配");
                    }

                    var accountRepository = new AccountRepository();
                    accountRepository.Create(parameters);


                    Session["IsAuthenticated"] = true;
                    Session["UName"] = requestForm["accountName"];
                    Response.Redirect("/Portal/Order.aspx");
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