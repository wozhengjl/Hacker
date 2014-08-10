namespace DoubleColor.Redballs.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.ServiceModel.Web;
    using System.Text;
    using System.Web;
    using DoubleColor.Redballs.Handler;
    using DoubleColor.Redballs.ItemModel;
    using DoubleColor.Redballs.Repository;

    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DCBService
    {
        [OperationContract]
        [WebGet]
        public VerifyCodeItem GetVerifyCode()
        {
            var vrfyCodeHandler = new VerifyCodeHandler();
            var base64Img = vrfyCodeHandler.GetVerifyCodeImage(HttpContext.Current);
            return new VerifyCodeItem
            {
                Base64Image = base64Img,
                VerifyCode = HttpContext.Current.Session["CheckCode"].ToString(),
            };
        }

        [OperationContract]
        [WebGet]
        public Boolean CheckIfUserNameExist(string userName)
        {
            var accountRepository = new AccountRepository();
            var model = accountRepository.Read(userName);
            return model != null;
        }

        [OperationContract]
        //[WebGet]
        [WebInvoke(Method = "POST")]
        public void PostOrder(int ordertype, IList<OrderItem> orderdata)
        {

        }
    }
}
