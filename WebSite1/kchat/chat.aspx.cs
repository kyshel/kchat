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
    db mydb = new db();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["logout"]=="true"){
            string sql2 = "UPDATE users SET user_online='0' WHERE user_name = '" + Session["user_name"].ToString() + "'";
            mydb.RunNonQuery(sql2);
            Session.Clear();
        }

        //********************user info ************/
        if (Session["user_name"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            Label3.Text = "user_name:" + Session["user_name"].ToString();
            Label3.Text += "<br>user_pass:" + Session["user_pass"].ToString();
        }

        //refresh new message
        //Response.AppendHeader("Refresh", "10");

        // *********************time count*************************/
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
                
        // appliation verify online
        // Label4.Text = "<br> online counter:" + Application["counter"].ToString()

        /************** user statistic **************************/
        // db verify online
        string sql_online = "SELECT * FROM users WHERE user_online= '1'";
        int online_num = mydb.Rownum(sql_online);
        Label4.Text = "<br> db counter: " + online_num;
        // statistic every person
        DataSet myds = new DataSet();
        myds = mydb.run_sql(sql_online, "on_users");
        for(int t = 0; t < online_num; t++){
            DataRow mydr = myds.Tables["on_users"].Rows[t];
            Label4.Text += "<br>"+mydr["user_name"].ToString();
        }

        /*************** show talk ********************/
        if (Application["show"] != null)
            Label1.Text = Convert.ToString(Application["show"]);

    }



    /******************* send talk *******************/
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = Session["user_name"].ToString();
        string time = DateTime.Now.ToString();
        string ip = Request.UserHostAddress;
        string[] ip_array = ip.Split('.');
        string ip_mask = ip_array[0] + "." + ip_array[1] + "." + ip_array[2] + "*";
        if (TextBox1.Text != "")
        {
            // filter words 
            string mes = TextBox1.Text;
            string[] sPattern ={
            "苹果",
            "甜瓜",
            "菠萝",
            "牛奶"
            };
            foreach (string s in sPattern)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(mes, s, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    Response.Redirect("kickout.aspx");
                }

            }
            //normal proccess
            Application.Lock();
            Application["show"] = Application["show"]+time + " " + ip_mask + " " + name + ": " + TextBox1.Text + "<br>";
            Application.UnLock();
            TextBox1.Text = "";
            Label1.Text = Convert.ToString(Application["show"]);
        }

    }
    /***************** emplty application *************************/
    protected void Button2_Click(object sender, EventArgs e)
    {
        Application["show"] = "";
        Label1.Text = Convert.ToString(Application["show"]);
    }
    /***********logout*************************/
    protected void Button3_Click(object sender, EventArgs e)
    {
        Server.Transfer("chat.aspx?logout=true");
    }
    /*************admin door***************/
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin/index.aspx");
    }

    /*****************file upload************************/
    protected void Button5_Click(object sender, EventArgs e)
    {
        if(FileUpload1.HasFile){
            try {
                FileUpload1.PostedFile.SaveAs("D:\\e5\\_jack\\WebSite1\\kchat\\f\\"+FileUpload1.FileName);
                Label5.Text="file upload ok";
                string a = "<a href='f/" + FileUpload1.FileName + "'>" + FileUpload1.FileName + "</a>";

                // build Application stucture
                string name = Session["user_name"].ToString();
                string time = DateTime.Now.ToString();
                string ip = Request.UserHostAddress;
                string[] ip_array = ip.Split('.');
                string ip_mask = ip_array[0] + "." + ip_array[1] + "." + ip_array[2] + "*";

                Application.Lock();
                Application["show"] = Application["show"] + time + " " + ip_mask + " " + name 
                    +" uploaded a file:" + a + "<br>";
                Application.UnLock();

            }
            catch(Exception ex){
                Label5.Text = "File upload fail";
            }
        }
    }

}
