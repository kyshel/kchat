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

public partial class catch_demo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int a,b,c;
        string mystr = "";
        try{
            a = int.Parse(TextBox1.Text);
            b = 2;
            c = a / b;
            mystr = "测试通过";
        }
        catch(Exception ex){
            mystr = "数据格式错误，程序可能出现了异常"+ex.Message;
        }
        finally{
            Label3.Text = mystr;
        }
    }
}
