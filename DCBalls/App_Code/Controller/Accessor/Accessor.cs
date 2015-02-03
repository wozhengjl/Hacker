namespace DoubleColor.Redballs.Accessor
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;
using DoubleColor.Redballs.Provider;

    /// <summary>
    /// Summary description for Accessor
    /// </summary>
    public abstract class Accessor<T>
    {
        private DataBaseProvider dbProvider;

        public abstract bool IsExistOrNot(string Identity, bool isExist);

        public abstract void Insert(T model);

        public abstract DataTable Read(string Identity);

        protected DataBaseProvider DBProviderInstance
        {
            get
            {
                if (dbProvider == null)
                {
                    this.dbProvider = new SQLProvider();
                }
                return this.dbProvider;
            }
        }
    }
}