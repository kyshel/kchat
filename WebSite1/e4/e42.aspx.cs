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

public partial class e4_e42 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("Your ip is" + Request.UserHostAddress + "<br>");
        Label1 .Text=Request.UserHostAddress ;
        int a = Label1.Text.IndexOf("192.168");

        if (a == -1)
        {
            Response.Write("You are illegal guest!");
            
        }
        else {
            Response.Write("Welcome to my site~ ");
        }
    }
}
