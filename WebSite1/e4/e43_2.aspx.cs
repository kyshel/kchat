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

public partial class e4_e43_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string mystr;
        mystr = "name is:" + Session["uname"].ToString() + "<br> pass is:" + Session["upass"].ToString();
        Response.Write("This is e43_2.aspx<br>");
        Response.Write(mystr);
    }
}
