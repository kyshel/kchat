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

public partial class kchat_register : System.Web.UI.Page
{
    db mydb = new db();
    string sql;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string user_name = TextBox1.Text;
        string user_pass = TextBox2.Text;
        string user_sex="";
        string user_online = "0";
        string reg_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        if (RadioButton1.Checked == true)
        {
            user_sex = "男";
            
            string sql_reged = "SELECT * FROM users WHERE user_name='" + user_name + "'";
            int reged = mydb.Rownum(sql_reged);
            if (reged > 0)
            {
                Response.Write("user name:'" + user_name + "' has exists,please try another user_name");
            }
            else
            {
                sql = "INSERT INTO users(user_name,user_password,user_sex,user_reg_time,user_online) VALUES ('"
                + user_name + "','" + user_pass + "','" + user_sex + "','" + reg_time + "','" + user_online + "')";
                mydb.RunNonQuery(sql);
                Server.Transfer("reg_ok.aspx");
            }
            
        }
        else if (RadioButton2.Checked == true)
        {
            user_sex = "女";

            string sql_reged = "SELECT * FROM users WHERE user_name='" + user_name + "'";
            int reged = mydb.Rownum(sql_reged);
            if (reged > 0)
            {
                Response.Write("user name:'" + user_name + "' has exists,please try another user_name");
            }
            else
            {
                sql = "INSERT INTO users(user_name,user_password,user_sex,user_reg_time,user_online) VALUES ('"
                + user_name + "','" + user_pass + "','" + user_sex + "','" + reg_time + "','" + user_online + "')";
                mydb.RunNonQuery(sql);
                Server.Transfer("reg_ok.aspx");
            }
            
        }
        else {
            Response.Write("请选择性别！");
        }

        

    }
}
