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

public partial class e2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string mystring1 = "hello world";
        string mystring2 = "hello" + "world";
        bool test = (mystring1 == mystring2);
        if (test == true)
        {
            Response.Write("ok");
        }
        else
        {
            Response.Write("sorry");
        }
        char mychar = mystring1[6];
        Response.Write("<br>");
        Response.Write(mychar);

    }
}
