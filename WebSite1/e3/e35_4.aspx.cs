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

public partial class e3_e35_4 : System.Web.UI.Page
{
    static int num = 0,score = 0;

    public void welcome() {
        if (num == 0)
        {
            Label1.Text = "Welcome to online test system!";
            Button1.Text = "Start Test";
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        welcome();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        num++;
        switch (num)
        {
            case 1:
                Label1.Text = "1.1+1=";
                switch(RadioButton1.Checked){
                    case true:
                        score=score+20;
                        break;
                    default:
                        break;
                }
                Button1.Text = "Next";
                break;
            case 2:
                Label1.Text = "2.2+2=,score is "+score;
                Button1.Text = "Next";
                break;
            case 3:
                Label1.Text = "3.3+3=";
                Button1.Text = "Next";
                break;
            case 4:
                Label1.Text = "4.4+4=";
                Button1.Text = "Next";
                break;
            case 5:
                Label1.Text = "5.5+5=";
                Button1.Text = "Next";
                break;
            case 6:
                Label1.Text = "Your score is "+ score;
                Button1.Text = "Start Again";
                break;
            case 7:
                num = 0;
                score = 0;
                welcome();
                break;
            default:
                num = 0;
                break;
        }
        
    }
}
