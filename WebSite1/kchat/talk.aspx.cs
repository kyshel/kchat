using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class kchat_talk : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String a = Convert.ToString(Application["show"]);
        Response.Write(a);
        Response.AppendHeader("Refresh", "1");
    }
}
