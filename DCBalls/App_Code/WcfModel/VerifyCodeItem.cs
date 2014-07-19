namespace DoubleColor.Redballs.ItemModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Web;

    [DataContract]
    /// <summary>
    /// Summary description for VerifyCodeItem
    /// </summary>
    public class VerifyCodeItem
    {
        [DataMember]
        public string Base64Image { get; set; }

        [DataMember]
        public string VerifyCode { get; set; }
    }
}