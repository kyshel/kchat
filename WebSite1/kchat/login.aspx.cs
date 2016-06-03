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
            + "' AND user_password='"+user_pass+"'";
        int i = mydb.Rownum(sql); // check
        if (i > 0)
        {
            string sql2 = "UPDATE users SET user_online='1' WHERE user_name = '"+user_name+"'";
            mydb.RunNonQuery(sql2);
            Session["user_name"] = TextBox1.Text.Trim();
            Session["user_pass"] = TextBox2.Text.Trim();
            Response.Redirect("chat.aspx");
        }
        else {
            Response.Write("wrong password");
        }

<<<<<<< HEAD
        
=======
        Response.Write(i + "<br>" + user_name);
>>>>>>> ae312f6bb2b6cba83d4a0a750ef6c91be45042c9

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
