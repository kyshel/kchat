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

public partial class e4_e41 : System.Web.UI.Page
{
    void Page_Load()
    {
        string[] lesson ={ "无线通信", "计算机通信网", "数据库原理与应用", "自习", "C++语言", "web开发基础", "自习", "自习", "实验", "实验" };
        for (int i = 0; i < 10; i++)
            Response.Write((i + 1) + "、" + lesson[i] + "<br>");
    } 



}
