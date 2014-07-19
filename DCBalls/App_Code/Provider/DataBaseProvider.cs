namespace DoubleColor.Redballs.Provider
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Summary description for DataBaseProvider
    /// </summary>
    public abstract class DataBaseProvider
    {
        protected virtual string ConnectionString { get; set; }

        public abstract DataTable Read(string selectStr);

        public abstract void Instert(string insertStr);
    }
}