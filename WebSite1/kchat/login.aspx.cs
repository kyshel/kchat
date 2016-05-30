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

public partial class kchat_login : System.Web.UI.Page
{
    db mydb = new db();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_name"] != null)
        {
            Response.Redirect("chat.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string user_name = TextBox1.Text;
        string user_pass = TextBox2.Text;
        string sql = "SELECT user_name FROM users WHERE user_name='" + user_name 
            + "' AND user_password_hash='"+user_pass+"'";
        int i = mydb.Rownum(sql, ref user_name); // check
        if (i > 0)
        {
            Session["user_name"] = TextBox1.Text.Trim();
            Session["user_pass"] = TextBox2.Text.Trim();
            Server.Transfer("chat.aspx");
        }
        else {
            Response.Write("wrong password");
        }

        Response.Write(i + "<br>" + user_name);

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
