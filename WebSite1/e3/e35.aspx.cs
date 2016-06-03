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

public partial class e3_e35 : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        float a, b=6.49F, c;
        if (RadioButton1.Checked == true)
        {
            a = float.Parse(TextBox1.Text);
            c = a / b;
            TextBox2.Text = Convert.ToString(c) + "$";
        }
        else if (RadioButton2.Checked == true)
        {
            a = float.Parse(TextBox1.Text);
            c = a * b;
            TextBox2.Text = Convert.ToString(c) + "¥";
        }
        else {
            TextBox2.Text = "Please choose conver type!";
        }
            
    }
}
