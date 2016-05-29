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
using System.Data.SqlClient;

public partial class kchat_admin : System.Web.UI.Page
{
    db mydb = new db();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string user_name = "jack";
        string sql = "SELECT user_name FROM users WHERE user_name='"+user_name+"'";
        


        int i= mydb.Rownum(sql, ref user_name);

        Response.Write(i + "<br>" + user_name);
    }

    

}
