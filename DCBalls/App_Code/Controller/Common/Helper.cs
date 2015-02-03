using System;
using System.Web;
using DoubleColor.Redballs.Repository;
namespace DoubleColor.Redballs.Common
{
    /// <summary>
    /// Summary description for Helper
    /// </summary>
    public class Helper
    {
        public static void AuthenticateUser()
        {
            if(Convert.ToBoolean(HttpContext.Current.Session["IsAuthenticated"]))
            {
                return;
            }

            HttpCookie Cookie = CookieHelper.GetCookie("UserInfo");
            if (Cookie != null)
            {
                string userName = Cookie.Values["uName"];
                string password = Cookie.Values["uPwd"];

                var accountRepository = new AccountRepository();
                var account = accountRepository.Read(userName);

                if (account != null && string.Equals(account.TenantPassword, password))
                {
                    HttpContext.Current.Session[Constants.SessionConstants.IsAuthenticated] = true;
                    HttpContext.Current.Session[Constants.SessionConstants.UName] = userName;
                }
                else 
                {
                    throw new AuthenticationDoubleBallException("认证失败！"); 
                }
            }
            else
            {
                throw new AuthenticationDoubleBallException("认证失败！"); 
            }
        }
    }
}