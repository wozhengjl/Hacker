namespace DoubleColor.Redballs.ItemModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Web;

    [DataContract]
    /// <summary>
    /// Summary description for OrderItem
    /// </summary>
    public class BallItem
    {
        [DataMember]
        public string OrderData { get; set; }

        [DataMember]
        public int Count { get; set; }
    }

    [DataContract]
    public class OrderItem
    {
        [DataMember]
        public int Type { get; set; }

        public BallItem[] Data { get; set; }
    }
}