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
    using DoubleColor.Redballs.Common;
    using DoubleColor.Redballs.Handler;
    using DoubleColor.Redballs.ItemModel;
    using DoubleColor.Redballs.Model;
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
        [WebInvoke(Method = "POST")]
        [ServiceKnownType(typeof(ServiceResult))]
        [ServiceKnownType(typeof(RecordModel))]
        public ServiceResult GetRecords(int startDate, int endDate, int state)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var currentAccount = SessionContext.Instance.CurrentAccount;

                StringBuilder filter = new StringBuilder();
                filter.Append(string.Format("TenantGuid = {0}", currentAccount.TenantGuid));
                if (startDate != -1)
                {
                    filter.Append(string.Format("DateTime > {0}", DateTime.UtcNow.Date.AddDays(-1 * startDate)));
                }

                filter.Append(string.Format(" and DateTime <= {0}", DateTime.UtcNow.Date.AddDays(-1 * endDate)));

                var recordRepository = new RecordRepositoty();
                IList<RecordModel> records = recordRepository.ReadList(filter.ToString());
                result.Result = records;
            }
            catch (Exception ex)
            {
                result.Error = new ServiceError(ex.GetType().ToString(), ex.Message);
            }

            return result;
        }

        [OperationContract]
        [WebInvoke(Method = "POST")]
        [ServiceKnownType(typeof(ServiceResult))]
        [ServiceKnownType(typeof(AuthenticateUser))]
        public ServiceResult AuthenticateUser(string userName, string passWord)
        {
            ServiceResult result = new ServiceResult();
            AuthenticateUser user = new AuthenticateUser();
            result.Result = user;
            try
            {
                var accountRepository = new AccountRepository();
                var account = accountRepository.Read(userName);
                if (account == null)
                {
                    throw new AuthenticationDoubleBallException("用户名不存在");
                }
                if (string.Equals(passWord, account.TenantPassword))
                {
                    HttpContext.Current.Session["IsAuthenticated"] = true;
                    HttpContext.Current.Session["UName"] = userName;
                    CookieHelper.SetUpCookies(userName, passWord);
                    user.IsAuthenticate = true;
                    user.UserName = userName;
                    result.Result = user;
                }
                else
                {
                    throw new AuthenticationDoubleBallException("用户名和密码不匹配");
                }
            }
            catch (Exception ex)
            {
                user.IsAuthenticate = false;
                result.Error = new ServiceError(ex.GetType().ToString(), ex.Message);
            }

            return result;
        }
    }
}
