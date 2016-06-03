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

public partial class e3_e35_2 : System.Web.UI.Page
{
    float a, b,c;
    public void calc(char operate)
    {
        a = float.Parse(TextBox1.Text);
        b = float.Parse(TextBox2.Text);
        switch (operate)
        {
            case '+':
                c = a + b;
                Label1.Text = a +"+"+ b + "=";
                break;
            case '-':
                c = a - b;
                Label1.Text = a + "-" + b + "=";
                break;
            case '*':
                c = a * b;
                Label1.Text = a + "*" + b + "=";
                break;
            case '/':
                c = a / b;
                Label1.Text = a + "/" + b + "=";
                break;
            default:
                break;
        }
        Label1.Text += Convert.ToString(c);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        calc('+');       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        calc('-');
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        calc('*');
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        calc('/');
    }
}
