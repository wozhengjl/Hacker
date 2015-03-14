namespace DoubleColor.Redballs.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Web;
    using DoubleColor.Redballs.ItemModel;

    /// <summary>
    /// Summary description for IDCBService
    /// </summary>
    [ServiceContract(Namespace = "", Name = "DCBService")]
    [ServiceKnownType("GetKnownTypes", typeof(DCBService))]
    public interface IDCBService
    {
        [OperationContract]
        [WebGet]
        VerifyCodeItem GetVerifyCode();

        [OperationContract]
        [WebGet]
        Boolean CheckIfUserNameExist(string userName);

        [OperationContract]
        [WebInvoke(Method = "POST")]
        ServiceResult GetRecords(int startDate, int endDate, int state);

        [OperationContract]
        [WebInvoke(Method = "POST")]
        ServiceResult AuthenticateUser(string userName, string passWord);
    }
}