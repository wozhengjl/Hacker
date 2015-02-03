namespace DoubleColor.Redballs.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using DoubleColor.Redballs.Accessor;
    using DoubleColor.Redballs.Common;
    using DoubleColor.Redballs.Model;

    /// <summary>
    /// Summary description for RecordRepositoty
    /// </summary>
    public class RecordRepositoty : Repository<RecordModel> 
    {
        public RecordRepositoty()
        {
            Accessor = new RecordAccessor();
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
                string errorMsg = "记录已经存在";
                if (exist)
                {
                    errorMsg = "该记录不存在";
                }
                throw new IdentityExistDoubleBallException(errorMsg);
            }
        }

        public override void Create(Dictionary<string, string> parameters)
        {
            Validate(parameters, false);

            var factory = new Factory<RecordModel>();
            var model = factory.BuildModel(parameters);
            Accessor.Insert(model);
        }

        public override RecordModel Read(string identity)
        {
            throw new NotImplementedException();
        }

        public override IList<RecordModel> ReadList(string filter)
        {
            if (filter == null)
            {
                throw new ArgumentException("filter is null!");
            }

            var table = this.Accessor.Read(filter);

            IList<RecordModel> records = new List<RecordModel>();
            for (int i = 0; i < table.Rows.Count; i++ )
            {
                records.Add(new RecordModel
                {
                    RecordGuid = Guid.Parse(table.Rows[i][Constants.RecordConstants.RecordGuid].ToString()),
                    TenantGuid = Guid.Parse(table.Rows[i][Constants.RecordConstants.TenantGuid].ToString()),
                    DateTime = DateTime.Parse(table.Rows[i][Constants.RecordConstants.DateTime].ToString()),
                    Type = int.Parse(table.Rows[i][Constants.RecordConstants.Type].ToString()),
                    Cost = int.Parse(table.Rows[i][Constants.RecordConstants.Cost].ToString()),
                    State = table.Rows[i][Constants.RecordConstants.State].ToString(),
                });
            }

            return records;
        }
    }
}