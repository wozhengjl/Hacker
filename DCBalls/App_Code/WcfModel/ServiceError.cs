/// <summary>
/// Summary description for ServiceError
/// </summary>

namespace DoubleColor.Redballs.ItemModel
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ServiceError
    {
        public ServiceError(string exception, string message)
        {
            ExceptionType = exception;
            Message = message;
        }

        [DataMember]
        public string ExceptionType { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}