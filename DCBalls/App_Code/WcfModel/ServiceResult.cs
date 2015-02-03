/// <summary>
/// Summary description for ServiceResult
/// </summary>
namespace DoubleColor.Redballs.ItemModel
{
    using System.Runtime.Serialization;

    [DataContract]
    [KnownType(typeof(ServiceError))]
    public class ServiceResult
    {
        [DataMember]
        public object Result { get; set; }

        [DataMember]
        public ServiceError Error { get; set; }
    }
}