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

public partial class e3_e35_3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(RequiredFieldValidator1.IsValid 
            && RequiredFieldValidator2.IsValid
            && RegularExpressionValidator1.IsValid
            && RegularExpressionValidator2.IsValid
            && RegularExpressionValidator3.IsValid){
                Label1.Text = "Name:"+TextBox1.Text+"<br>";
                Label1.Text += "Password:" + TextBox2.Text + "<br>";
                Label1.Text += "Birth:" + TextBox3.Text + "<br>";
                Label1.Text += "Phone:" + TextBox4.Text + "<br>";
                Label1.Text += "E-mail:" + TextBox5.Text + "<br>";
        }else{
            Label1.Text = "Input error!";
        }
    }
}
