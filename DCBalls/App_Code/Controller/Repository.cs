namespace DoubleColor.Redballs.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using DoubleColor.Redballs.Model;

    /// <summary>
    /// Summary description for Repository
    /// </summary>
    public abstract class Repository<T>
    {
        protected abstract void Validate(Dictionary<string, string> parameters, bool exist);

        public abstract void Create(Dictionary<string, string> parameters);

        public abstract T Read(string identity);
    }
}