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

public partial class kchat_chat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string user_name;
        if (Session["user_name"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            Label3.Text = "user_name:" + Session["user_name"].ToString();
            Label3.Text += "<br>user_pass:" + Session["user_pass"].ToString();
        }

        if (Page.IsPostBack != true)
        {
            int Number;
            if (Request.Cookies["Number"] == null)
            {
                Number = 1;
                Response.Cookies["Number"].Value = Convert.ToString(Number);
                Response.Cookies["Number"].Expires = DateTime.Now.AddYears(1);
            }
            else
            {
                Number = Convert.ToInt32(Request.Cookies["Number"].Value) + 1;
                Response.Cookies["Number"].Value = Convert.ToString(Number);
            }
            Label2.Text = Session["user_name"] + "，你好，你是第" + Number + "次光临本聊天室";
        }

        if (Application["show"] != null)
            Label1.Text = Convert.ToString(Application["show"]);

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = Session["user_name"].ToString();
        string time = DateTime.Now.ToString();
        string ip = Request.UserHostAddress;
        string[] ip_array = ip.Split('.');
        string ip_mask = ip_array[0] + "." + ip_array[1] + "." + ip_array[2] + "*";
        if (TextBox1.Text != "")
        {
            Application.Lock();
            Application["show"] = Application["show"] + "<br>" + time + " " + ip_mask + " " + name + ": " + TextBox1.Text;
            Application.UnLock();
            TextBox1.Text = "";
            Label1.Text = Convert.ToString(Application["show"]);

        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Application["show"] = "";
        Label1.Text = Convert.ToString(Application["show"]);
    }
}
