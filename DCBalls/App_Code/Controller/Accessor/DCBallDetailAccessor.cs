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
    /// Summary description for DCBallDetailAccessor
    /// </summary>
    public class DCBallDetailAccessor : Accessor<DCBallDetailModel>
    {
        public override bool IsExistOrNot(string Identity, bool isExist)
        {
            string selectStr = string.Format("select {0} from {1} where {2}=\'{3}\';",
                    Constants.DCBallDetailConstants.DetailGuid, Constants.DCBallDetailConstants.DCBallDetailTable, Constants.DCBallDetailConstants.DetailGuid, Identity);

            DataTable dataTable = this.DBProviderInstance.Read(selectStr);

            return (dataTable.Rows.Count == 0) == isExist;
        }

        public override DataTable Read(string Identity)
        {
            throw new NotImplementedException();
        }

        public override void Insert(DCBallDetailModel model)
        {
            string instertStr = string.Format("insert into {0} ({1}, {2}, {3}, {4}, {5}, {6}) values (\'{7}\', \'{8}\', \'{9}\', \'{10}\', \'{11}\', \'{12}\')", Constants.DCBallDetailConstants.DCBallDetailTable,
               Constants.DCBallDetailConstants.DetailGuid, Constants.DCBallDetailConstants.RecordGuid, Constants.DCBallDetailConstants.DateTime, Constants.DCBallDetailConstants.TenantGuid, Constants.DCBallDetailConstants.BallsNo, Constants.DCBallDetailConstants.Count,
               model.DetailGuid, model.RecordGuid, model.DateTime, model.TenantGuid, model.BallsNo, model.Count);

            this.DBProviderInstance.Instert(instertStr);
        }
    }
}