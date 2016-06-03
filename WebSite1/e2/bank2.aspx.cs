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

public partial class e2_bank2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int num = int.Parse(TextBox1.Text);
        switch (num)
        {
            case 1:
                Label1.Text = "password verify"; 
                break;
            case 2:
                Label1.Text = "deposit"; 
                break;
            case 3:
                Label1.Text = "withdraw";
                break;
            case 4:
                Label1.Text = "balance";
                break;
            case 5:
                Label1.Text = "exit";
                break;
            default:
                Label1.Text = "Wrong number,<br>please input a number between 1-5"; 
                break;
        }
    }
}
