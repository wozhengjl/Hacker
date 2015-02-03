namespace DoubleColor.Redballs.Repository
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;
    using DoubleColor.Redballs.Accessor;
    using DoubleColor.Redballs.Model;
    using AccountTableConstants = DoubleColor.Redballs.Common.Constants.AccountConstants;

    /// <summary>
    /// Summary description for Repository
    /// </summary>
    public class AccountRepository : Repository<AccountModel>
    {
        public AccountRepository()
        {
            Accessor = new AccountAccessor();
        }

        protected override void Validate(Dictionary<string, string> parameters, bool exist)
        {
            string identy = parameters["Identity"];

            if (string.IsNullOrEmpty(identy))
            {
                throw new ArgumentException("Identity is null or empty");
            }

            if (Accessor.IsExistOrNot(identy, exist))
            {
                string errorMsg = "该用户名已经存在";
                if (exist)
                {
                    errorMsg = "该用户名不存在";
                }
                throw new IdentityExistDoubleBallException(errorMsg);
            }
        }

        public override void Create(Dictionary<string, string> parameters)
        {
            Validate(parameters, false);

            var factpry = new Factory<AccountModel>();
            var model = factpry.BuildModel(parameters);
            Accessor.Insert(model);
        }

        public override AccountModel Read(string identity)
        {
            if (identity == null)
            {
                throw new ArgumentException("UserName is null!");
            }

            var table = this.Accessor.Read(identity);
            
            if (table.Rows.Count < 1)
            {
                return null;
            }
            else if (table.Rows.Count > 1)
            {
                throw new IdentityExistDoubleBallException("more than 1 accounts exist!");
            }

            var row = table.Rows[0];
            return new AccountModel 
            { 
                TenantGuid = row[AccountTableConstants.TenantGuid].ToString(),
                TenantName = row[AccountTableConstants.TenantName].ToString(), 
                TenantPassword = row[AccountTableConstants.TenantPassword].ToString() 
            };
        }

        public override IList<AccountModel> ReadList(string filter)
        {
            throw new NotImplementedException();
        }
    }
}