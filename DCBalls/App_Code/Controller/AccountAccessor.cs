namespace DoubleColor.Redballs.Accessor
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;
    using DoubleColor.Redballs.Model;
    using DoubleColor.Redballs.Provider;
    using AccountTableConstants = DoubleColor.Redballs.Repository.Constants.AccountTableConstants;

    /// <summary>
    /// Summary description for AccountAxxessor
    /// </summary>
    public class AccountAccessor : Accessor<AccountModel>
    {
        private DataBaseProvider dbProvider;

        private DataBaseProvider DBProviderInstance {
            get {
                if (dbProvider == null) {
                    this.dbProvider = new SQLProvider();
                }
                return this.dbProvider;
            }
        }

        public override bool IsExistOrNot(string Identity, bool isExist)
        {
            string selectStr = string.Format("select {0} from {1} where {2}=\'{3}\';",
                    AccountTableConstants.TenantName, AccountTableConstants.AccountTable, AccountTableConstants.TenantName, Identity);

            DataTable dataTable = this.DBProviderInstance.Read(selectStr);

            return (dataTable.Rows.Count == 0) == isExist;
        }

        public override void Create(AccountModel model)
        {
            string instertStr = string.Format("insert into {0} ({1}, {2}) values (\'{3}\', \'{4}\')", AccountTableConstants.AccountTable,
                AccountTableConstants.TenantName, AccountTableConstants.TenantPassword, model.TenantName, model.TenantPassword);

            this.DBProviderInstance.Instert(instertStr);
        }

        public override DataTable Read(string Identity)
        {
            string selectStr = string.Format("select * from {0} where {1}=\'{2}\';",
                    AccountTableConstants.AccountTable, AccountTableConstants.TenantName, Identity);

            DataTable dataTable = this.DBProviderInstance.Read(selectStr);

            return dataTable;
        }
    }
}