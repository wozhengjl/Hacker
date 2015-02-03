namespace DoubleColor.Redballs.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using DoubleColor.Redballs.Accessor;
    using DoubleColor.Redballs.Model;

    /// <summary>
    /// Summary description for RecordRepositoty
    /// </summary>
    public class DCBallDetailRepositoty : Repository<DCBallDetailModel> 
    {
        public DCBallDetailRepositoty()
        {
            Accessor = new DCBallDetailAccessor();
        }

        protected override void Validate(Dictionary<string, string> parameters, bool exist)
        {
            string identy = parameters["Identity"];

            if (string.IsNullOrEmpty(identy))
            {
                throw new ArgumentException("Identity is null or empty");
            }

            if (Accessor.IsExistOrNot(identy, exist))
            {
                string errorMsg = "记录已经存在";
                if (exist)
                {
                    errorMsg = "该记录不存在";
                }
                throw new IdentityExistDoubleBallException(errorMsg);
            }
        }

        public override void Create(Dictionary<string, string> parameters)
        {
            Validate(parameters, false);

            var factory = new Factory<DCBallDetailModel>();
            var model = factory.BuildModel(parameters);
            Accessor.Insert(model);
        }

        public override DCBallDetailModel Read(string identity)
        {
            throw new NotImplementedException();
        }

        public override IList<DCBallDetailModel> ReadList(string filter)
        {
            throw new NotImplementedException();
        }
    }
}