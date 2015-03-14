namespace DoubleColor.Redballs.Portal
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
    using DoubleColor.Redballs.Common;
    using DoubleColor.Redballs.Repository;

    public partial class NavigationBar : System.Web.UI.MasterPage
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.FilePath.IndexOf("Logout.aspx") != -1
                || Request.FilePath.IndexOf("Logon.aspx") != -1
                || Request.FilePath.IndexOf("Register.aspx") != -1)
            {
                HiddenUserName.Value = "";
            }
            else
            {
                var user = HttpContext.Current.User;
                HiddenUserName.Value = user != null ? user.Identity.Name : "";
            }
        }
    }
}