namespace DoubleColor.Redballs.Accessor
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Summary description for Accessor
    /// </summary>
    public abstract class Accessor<T>
    {
        public abstract bool IsExistOrNot(string Identity, bool isExist);

        public abstract void Create(T model);

        public abstract DataTable Read(string Identity);
    }
}