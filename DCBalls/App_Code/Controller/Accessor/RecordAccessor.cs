namespace DoubleColor.Redballs.Accessor
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;
    using DoubleColor.Redballs.Common;
    using DoubleColor.Redballs.Model;

    /// <summary>
    /// Summary description for RecordAccessor
    /// </summary>
    public class RecordAccessor : Accessor<RecordModel>
    {
        public override bool IsExistOrNot(string Identity, bool isExist)
        {
            string selectStr = string.Format("select {0} from {1} where {2}=\'{3}\';",
                    Constants.RecordConstants.RecordGuid, Constants.RecordConstants.RecordTable, Constants.RecordConstants.RecordGuid, Identity);

            DataTable dataTable = this.DBProviderInstance.Read(selectStr);

            return (dataTable.Rows.Count == 0) == isExist;
        }

        public override DataTable Read(string filter)
        {
            string selectStr = string.Format("select * from {0} where {1};",
                    Constants.RecordConstants.RecordTable, filter);

            DataTable dataTable = this.DBProviderInstance.Read(selectStr);

            return dataTable;
        }

        public override void Insert(DoubleColor.Redballs.Model.RecordModel model)
        {
            string instertStr = string.Format("insert into {0} ({1}, {2}, {3}, {4}, {5}, {6}) values (\'{7}\', \'{8}\', \'{9}\', \'{10}\', \'{11}\', \'{12}\')", Constants.RecordConstants.RecordTable,
               Constants.RecordConstants.RecordGuid, Constants.RecordConstants.TenantGuid, Constants.RecordConstants.DateTime, Constants.RecordConstants.Type, Constants.RecordConstants.Cost, Constants.RecordConstants.State,
               model.RecordGuid, model.TenantGuid, model.DateTime, model.Type, model.Cost, model.State);

            this.DBProviderInstance.Instert(instertStr);
        }
    }
}