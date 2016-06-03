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

public partial class bank : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Visible = false;
        Label4.Visible = false;
        Button2.Visible = false;
        Button3.Visible = false;
        Button4.Visible = false;
        Button5.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label4.Visible = true;
        Label4.Text = "This is deposit page ";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Label4.Visible = true;
        Label4.Text = "This is fetch page ";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string username="aaa";
        string password = "123";
        
        string i_u=TextBox1.Text;
        string i_p=TextBox2.Text;
        if (i_u == username && i_p == password)
        {
            Label3.Text = "User " + i_u + " has logged";
            Label3.Visible = true;
            
            Button2.Visible = true;
            Button3.Visible = true;
            Button4.Visible = true;
            Button5.Visible = true;

            Label1.Visible = false;
            Label2.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            Button1.Visible = false;

        }
        else {
            Label3.Visible = true;
            Label3.Text = "username does not match password";
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Label3.Visible = false;
        Label4.Visible = false;
        Button2.Visible = false;
        Button3.Visible = false;
        Button4.Visible = false;
        Button5.Visible = false;

        Label1.Visible = true;
        Label2.Visible = true;
        TextBox1.Visible = true;
        TextBox2.Visible = true;
        Button1.Visible = true;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Label4.Visible = true;
        string money = "2000";
        Label4.Text = "Money is " + money;
    }
}
