namespace DoubleColor.Redballs.Common
{
    /// <summary>
    /// Summary description for Constants
    /// </summary>
    public static class Constants
    {
        public const string Identity = "Identity";

        public static class SessionConstants
        {
            public const string IsAuthenticated = "IsAuthenticated";

            public const string UName = "UName";
        }

        public static class RecordConstants
        {
            public const string RecordTable = "Record";

            public const string RecordGuid = "RecordGuid";

            public const string TenantGuid = "TenantGuid";

            public const string DateTime = "DateTime";

            public const string Type = "Type";

            public const string Cost = "Cost";

            public const string State = "State";
        }

        public static class DCBallDetailConstants
        {
            public const string DCBallDetailTable = "DCBallDetail";

            public const string DetailGuid = "DetailGuid";

            public const string RecordGuid = "RecordGuid";

            public const string DateTime = "DateTime";

            public const string TenantGuid = "TenantGuid";

            public const string BallsNo = "BallsNo";

            public const string Count = "Count";
        }

        public static class AccountConstants
        {
            public const string TenantGuid = "TenantGuid";

            public const string TenantName = "TenantName";

            public const string TenantPassword = "TenantPassword";

            public const string AccountTable = "Account";
        }
    }
}