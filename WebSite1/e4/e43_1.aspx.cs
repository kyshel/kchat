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

public partial class e4_e43_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["uname"] = TextBox1.Text;
        Session["upass"] = TextBox2.Text;
        Response.Write("<a href='e43_2.aspx'>e43_2.aspx</a><br />");
        Response.Write("<a href='e43_3.aspx'>e43_3.aspx</a>");

    }
}
