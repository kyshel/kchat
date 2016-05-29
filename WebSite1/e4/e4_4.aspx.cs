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

public partial class e4_e4_4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["user"] == null)
        {
            Response.Redirect("e4_4_2.aspx");
        }
        else
        {
            Label3.Text = "uname:" + Request.Cookies["user"]["uname"];
            Label3.Text += "<br>usex:" + Request.Cookies["user"]["usex"];
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
            Label2.Text = Request.Cookies["user"]["uname"]+"，你好，你是第" + Number + "次光临本聊天室";
        }

        //if (Page.IsPostBack != true)
        //{
        //    int Number;

        //    if (Request.Cookies["user"]["unum"] == "0")
        //    {
        //        Number = 1;
        //        Response.Cookies["user"]["unum"] = Convert.ToString(Number);
        //        //Response.Cookies["Number"].Expires = DateTime.Now.AddYears(1);
        //    }
        //    else
        //    {
        //        Number = Convert.ToInt32(Request.Cookies["user"]["unum"]) + 1;
        //        Response.Cookies["user"]["unum"] = Convert.ToString(Number);
        //    }
        //    Label2.Text = "你是第" + Number + "次访问本站！谢谢";
        //}



        


        if (Application["show"] != null)
            Label1.Text = Convert.ToString(Application["show"]);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = Request.Cookies["user"]["uname"];
        string time = DateTime.Now.ToString();
        string ip = Request.UserHostAddress;
        string[] ip_array = ip.Split('.');
        string ip_mask = ip_array[0] +"."+ ip_array[1]+"." + ip_array[2]+"*";
        if (TextBox1.Text != "")
        {
            Application.Lock();
            Application["show"] = Application["show"] + "<br>" +time+" "+ip_mask+" "+name+": "+ TextBox1.Text;
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
