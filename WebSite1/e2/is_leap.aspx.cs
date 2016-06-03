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

public partial class is_leap : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        int year,a,b,c;
        year = int.Parse(TextBox1.Text);
        a = year % 4;
        b = year % 100;
        c = year % 400;
        if(a == 0 && b !=0){
            Label2.Text = "is leap";
        }
        else if (c == 0 ){
            Label2.Text = "is leap";
        }else{
            Label2.Text = "is not leap";
        }
    }
}
