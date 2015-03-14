using System;
/// <summary>
/// Summary description for UserInfo
/// </summary>
using System.Security.Principal;
using System.Web.Script.Serialization;

public class UserInfo : IPrincipal
{
    public int GroupId { get; set; }
    public string UserName { get; set; }

    public override string ToString()
    {
       return string.Format("GroupId: {0}, UserName: {1}, IsAdmin: {2}",
            GroupId, UserName, IsInRole("Admin"));
    }

    #region IPrincipal Members

    [ScriptIgnore]
    public IIdentity Identity
    {
        get { throw new NotImplementedException(); }
    }

    public bool IsInRole(string role)
    {
        if (string.Compare(role, "Admin", true) == 0)
            return GroupId == 1;
        else
            return GroupId > 0;
    }

    #endregion
}