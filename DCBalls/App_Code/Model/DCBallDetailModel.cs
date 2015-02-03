using System;
namespace DoubleColor.Redballs.Model
{
    /// <summary>
    /// Summary description for DCBallDetailModel
    /// </summary>
    public class DCBallDetailModel : Model
    {
        public Guid DetailGuid { get; set; }

        public DateTime DateTime { get; set; }

        public Guid RecordGuid { get; set; }

        public Guid TenantGuid { get; set; }

        public string BallsNo { get; set; }

        public int Count { get; set; }
    }
}