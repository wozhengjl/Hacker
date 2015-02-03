namespace DoubleColor.Redballs.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using DoubleColor.Redballs.Model;
    using DoubleColor.Redballs.Repository;

    /// <summary>
    /// Summary description for SessionContext
    /// </summary>
    public class SessionContext
    {
        private AccountModel m_CurrentAccount;

        private static SessionContext m_SessionContext;

        public AccountModel CurrentAccount
        {
            get
            {
                if (m_CurrentAccount == null)
                {
                    var accountRepository = new AccountRepository();
                    var userName = HttpContext.Current.Session["UName"].ToString();
                    var account = accountRepository.Read(userName);
                    if (account == null)
                    {
                        throw new AuthenticationDoubleBallException("用户名不存在");
                    }

                    m_CurrentAccount = account;
                }

                return m_CurrentAccount;
            }
        }

        public static SessionContext Instance
        {
            get
            {
                if (m_SessionContext == null)
                {
                    m_SessionContext = new SessionContext();
                }

                return m_SessionContext;
            }
        }
    }
}