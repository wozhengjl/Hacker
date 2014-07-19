namespace DoubleColor.Redballs.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using DoubleColor.Redballs.Repository;

    /// <summary>
    /// Summary description for AccountModel
    /// </summary>
    public class AccountModel : Model
    {
        private Guid tenantGuid;

        private string tenantName;

        private string tenantPasswrod;

        public string TenantGuid { get; set; }

        public string TenantName
        { 
            get
            {
               return this.tenantName; 
            }

            set
            {
               if(string.IsNullOrEmpty(value))
               {
                   throw new ArgumentDoubleBallException("用户名为空");
               }

               this.tenantName = value;
            } 
        }

        public string TenantPassword 
        {
            get
            {
                return this.tenantPasswrod;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentDoubleBallException("密码为空");
                }

                if (value.Length < 6 || value.Length > 20)
                {
                    throw new ArgumentDoubleBallException("密码长度只能在6-20位之间");
                }

                this.tenantPasswrod = value;
            }
        }
    }
}