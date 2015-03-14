using System;
/// <summary>
/// Summary description for FormsPrincipal
/// </summary>
using System.Security.Principal;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;

public class FormsPrincipal<TUserData> : IPrincipal
    where TUserData : class, new() 
{
    private IIdentity m_identity;
    private TUserData m_userData;

    public FormsPrincipal(FormsAuthenticationTicket ticket, TUserData userData)
    {
        if (ticket == null)
        {
            throw new ArgumentNullException("ticket");
        }
        if (userData == null)
        {
            throw new ArgumentNullException("userData");
        }

        m_identity = new FormsIdentity(ticket);
        m_userData = userData;
    }

    public TUserData UserData
    {
        get { return m_userData; }
    }

    public IIdentity Identity
    {
        get { return m_identity; }
    }

    public bool IsInRole(string role)
    {
        IPrincipal principal = m_userData as IPrincipal;
        if (principal == null)
        {
            throw new NotImplementedException("principal");
        }
        else
        {
            return principal.IsInRole(role);
        }
    }

    public static void SignIn(string loginName, TUserData userData, int expiration)
    {
        if (string.IsNullOrEmpty(loginName))
            throw new ArgumentNullException("loginName");
        if (userData == null)
            throw new ArgumentNullException("userData");

        string data = null;
        if (userData != null)
            data = (new JavaScriptSerializer()).Serialize(userData);

        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
            1, loginName, DateTime.Now, DateTime.Now.AddDays(1), true, data);
        string cookieValue = FormsAuthentication.Encrypt(ticket);

        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, cookieValue);
        cookie.HttpOnly = true;
        cookie.Secure = FormsAuthentication.RequireSSL;
        cookie.Domain = FormsAuthentication.CookieDomain;
        cookie.Path = FormsAuthentication.FormsCookiePath;
        if (expiration > 0)
            cookie.Expires = DateTime.Now.AddMinutes(expiration);

        HttpContext context = HttpContext.Current;
        if (context == null)
            throw new InvalidOperationException();

        context.Response.Cookies.Remove(cookie.Name);
        context.Response.Cookies.Add(cookie);
    }

    public static void SignOff()
    {
        HttpContext context = HttpContext.Current;
        if (context == null)
            throw new InvalidOperationException();

        if (context.Response.Cookies[FormsAuthentication.FormsCookieName] != null)
            context.Response.Cookies[FormsAuthentication.FormsCookieName].Expires = DateTime.Now.AddDays(-1);
        
        context.User = null;
    }

    public static void TrySetUserInfo(HttpContext context)
    {
        if (context == null)
            throw new ArgumentNullException("context");

        // 1. 读登录Cookie
        HttpCookie cookie = context.Request.Cookies[FormsAuthentication.FormsCookieName];
        if (cookie == null || string.IsNullOrEmpty(cookie.Value))
            return;

        try
        {
            TUserData userData = null;
            // 2. 解密Cookie值，获取FormsAuthenticationTicket对象
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);

            if (ticket != null && string.IsNullOrEmpty(ticket.UserData) == false)
                // 3. 还原用户数据
                userData = (new JavaScriptSerializer()).Deserialize<TUserData>(ticket.UserData);

            if (ticket != null && userData != null)
                // 4. 构造我们的MyFormsPrincipal实例，重新给context.User赋值。
                context.User = new FormsPrincipal<TUserData>(ticket, userData);
        }
        catch { /* 有异常也不要抛出，防止攻击者试探。 */ }
    }
}