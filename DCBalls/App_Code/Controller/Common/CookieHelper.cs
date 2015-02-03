namespace DoubleColor.Redballs.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Summary description for CookieHelper
    /// </summary>
    public class CookieHelper
    {
        public static HttpCookie GetCookie(string cookieName)
        {
            HttpRequest request = HttpContext.Current.Request;
            
            if (request != null)
            {
                return request.Cookies[cookieName];
            }

            return null;
        }

        public static void AddCookie(HttpCookie cookie)
        {
            HttpResponse response = HttpContext.Current.Response;

            if (response != null)
            {
                cookie.HttpOnly = true;
                cookie.Path = "/";
                //cookie.Domain = "test.com"
                response.AppendCookie(cookie);
            }
        }

        public static void SetCookie(string cookieName, string key, string value)
        {
            SetCookie(cookieName, key, value, null);
        }

        public static void SetCookie(string cookieName, string key, string value, DateTime? expires)
        {
            HttpResponse response = HttpContext.Current.Response;
            if (response != null)
            {
                HttpCookie cookie = response.Cookies[cookieName];

                if (cookie != null)
                {
                    if (!string.IsNullOrEmpty(key) && cookie.HasKeys)
                    {
                        cookie.Values.Set(key, value);
                    }
                    else if (!string.IsNullOrEmpty(value))
                    {
                        cookie.Value = value;
                    }
                }

                if (expires != null)
                {
                    cookie.Expires = expires.Value;
                }

                response.SetCookie(cookie);
            }
        }

        public static void SetUpCookies(string userName, string password)
        {
            HttpCookie Cookie = CookieHelper.GetCookie("UserInfo");

            if (Cookie == null)
            {
                Cookie = new HttpCookie("UserInfo");
                Cookie.Values.Add("uName", userName);
                Cookie.Values.Add("uPwd", password);

                Cookie.Expires = DateTime.Now.AddDays(30);
                CookieHelper.AddCookie(Cookie);
            }

            else if (!Cookie.Values["uName"].Equals(userName) || !Cookie.Values["uPwd"].Equals(password))
            {
                CookieHelper.SetCookie("UserInfo", "uName", userName);
                CookieHelper.SetCookie("UserInfo", "uPwd", password);
            }
        }
    }
}