namespace DoubleColor.Redballs.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Web;

    /// <summary>
    /// Summary description for RecordModel
    /// </summary>
    [DataContract]
    public class RecordModel : Model
    {
        [DataMember]
        public Guid RecordGuid { get; set; }

        [DataMember]
        public Guid TenantGuid { get; set; }

        [DataMember]
        public DateTime DateTime { get; set; }

        [DataMember]
        public int Type { get; set; }

        [DataMember]
        public int Cost { get; set; }

        [DataMember]
        public string State { get; set; }
    }
}