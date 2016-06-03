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

public partial class str_joint : System.Web.UI.Page
{
    int length;
    string[] myStr;   

    public void Page_Load(object sender, EventArgs e)
    {
        length = 3;
        myStr = new string[length];
        myStr[0] = "I ";
        myStr[1] = "am ";
        myStr[2] = "jack";
        Response.Write("Elements in Array:<br>");
        for (int i = 0; i < length; i++)
        {            
            Response.Write("myStr["+i+"]:"+myStr[i]+"<br>");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string joint = "";

        myClass myClass1=new myClass();
        joint = myClass1.str_join(myStr, length, joint);
        Response.Write("<br>After joint:<br>");
        Response.Write(joint);
    }
}

public class myClass
{
    public string str_join(string[] Array, int num, string joint)
    {
        for (int i = 0; i < num; i++)
        {
            joint = joint + Array[i];
        }
        return joint;
    }  
};