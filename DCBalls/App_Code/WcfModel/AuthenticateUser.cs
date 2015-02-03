namespace DoubleColor.Redballs.ItemModel
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Summary description for AuthenticateUser
    /// </summary>
    [DataContract]
    public class AuthenticateUser
    {
        [DataMember]
        public bool IsAuthenticate { get; set; }

        [DataMember]
        public string UserName { get; set; }
    }
}