namespace DoubleColor.Redballs.Portal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["IsAuthenticated"] = false;
            Session["UName"] = "";
            Response.Redirect("/Portal/Logon.aspx");
        }
    }
}