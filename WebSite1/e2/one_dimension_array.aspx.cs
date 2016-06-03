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

public partial class one_dimension_array : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int[] Array = new int[11];            //声明并初始化数组
        for (int i = 0; i < 11; i++)
        {
            Array[i] = i;
            Response.Write(Array[i]);
        }

    }
}
