namespace DoubleColor.Redballs.Portal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Script.Serialization;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using DoubleColor.Redballs.Common;
    using DoubleColor.Redballs.ItemModel;
    using DoubleColor.Redballs.Repository;

    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.RequestType.ToUpper() == "POST")
            {
                if (HttpContext.Current.User != null)
                {
                    try
                    {
                        var orderData = Request.Form["orderdata"];

                        var JSSerializer = new JavaScriptSerializer();
                        OrderItem requestOrder = JSSerializer.Deserialize<OrderItem>(orderData);

                        int cost = 0;
                        foreach (var item in requestOrder.Data)
                        {
                            cost += item.Count * 2;
                        }

                        Dictionary<string, string> param = new Dictionary<string, string>();
                        var currentAccount = SessionContext.Instance.CurrentAccount;
                        var identity = Guid.NewGuid().ToString();
                        param[Constants.Identity] = identity;
                        param[Constants.RecordConstants.RecordGuid] = identity;
                        param[Constants.RecordConstants.TenantGuid] = currentAccount.TenantGuid;
                        param[Constants.RecordConstants.DateTime] = DateTime.UtcNow.ToString();
                        param[Constants.RecordConstants.Type] = requestOrder.Type.ToString();
                        param[Constants.RecordConstants.Cost] = cost.ToString();
                        param[Constants.RecordConstants.State] = "1";

                        var recordRepository = new RecordRepositoty();
                        recordRepository.Create(param);

                        var DCDetailReporsitory = new DCBallDetailRepositoty();
                        requestOrder.Data.Perform(item => {
                            Dictionary<string, string> detailParam = new Dictionary<string, string>();
                            var detailidentity = Guid.NewGuid().ToString();
                            detailParam[Constants.Identity] = detailidentity;
                            detailParam[Constants.DCBallDetailConstants.DetailGuid] = detailidentity;
                            detailParam[Constants.DCBallDetailConstants.RecordGuid] = identity;
                            detailParam[Constants.DCBallDetailConstants.TenantGuid] = currentAccount.TenantGuid;
                            detailParam[Constants.DCBallDetailConstants.DateTime] = DateTime.UtcNow.ToString();
                            detailParam[Constants.DCBallDetailConstants.BallsNo] = item.OrderData;
                            detailParam[Constants.DCBallDetailConstants.Count] = item.Count.ToString();

                            DCDetailReporsitory.Create(detailParam);
                        });
                    }
                    catch (IdentityExistDoubleBallException)
                    {
 
                    }
                }
            }
        }
    }
}