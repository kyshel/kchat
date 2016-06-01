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
        string user_sex;
        string reg_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        if (RadioButton1.Checked == true)
        {
            user_sex = "男";
            sql = "INSERT INTO users(user_name,user_password,user_sex,user_reg_time) VALUES ('"
            + user_name + "','" + user_pass + "','" + user_sex + "','"+reg_time+"')";
            mydb.RunNonQuery(sql);

            Server.Transfer("reg_ok.aspx");
        }
        else if (RadioButton2.Checked == true)
        {
            user_sex = "女";
            sql = "INSERT INTO users(user_name,user_password,user_sex,user_reg_time) VALUES ('"
            + user_name + "','" + user_pass + "','" + user_sex + "','" + reg_time + "')";
            mydb.RunNonQuery(sql);
            Server.Transfer("reg_ok.aspx");
        }
        else {
            Response.Write("请选择性别！");
        }
        

    }
}
