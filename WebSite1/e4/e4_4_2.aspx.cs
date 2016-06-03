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

public partial class e4_e4_4_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {  
        HttpCookie cookie = new HttpCookie("user");
        cookie.Values["uname"] = TextBox1.Text;
        cookie.Values["usex"] = TextBox2.Text;
        //cookie.Values["unum"] = "0";
        cookie.Expires = DateTime.Now.AddDays(5);
        Response.Cookies.Add(cookie);
        

        //httpcookie cookie2 = new httpcookie("number");
        //cookie2.value = "0";
        //cookie2.expires = datetime.now.adddays(3);
        //response.cookies.add(cookie2);

        Response.Redirect("e4_4.aspx");

    }
}
