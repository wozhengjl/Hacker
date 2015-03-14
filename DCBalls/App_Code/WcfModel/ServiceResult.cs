/// <summary>
/// Summary description for ServiceResult
/// </summary>
namespace DoubleColor.Redballs.ItemModel
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using DoubleColor.Redballs.Common;

    [DataContract]
    public class ServiceResult
    {
        [DataMember]
        public object Result { get; set; }

        [DataMember]
        public ServiceError Error { get; set; }
    }

    [DataContract(Name = "{0}Results")]
    public class ServiceResult<O> : ServiceResult, IEnumerable<O>
    {
        public ServiceResult()
        {
            this.Output = Array<O>.Empty;
        }

        /// <summary>
        /// Create a new instance of results object that contains one output object.
        /// </summary>
        public ServiceResult(O value)
            : this(new O[] { value })
        {
        }

        /// <summary>
        /// Create a new instance of results object that contains an array of output objects.
        /// </summary>
        public ServiceResult(O[] output)
        {
            this.Output = output;
        }

        [DataMember]
        public O[] Output { get; set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<O> GetEnumerator()
        {
            return ((IEnumerable<O>)(this.Output ?? Array<O>.Empty)).GetEnumerator();
        }
    }
}