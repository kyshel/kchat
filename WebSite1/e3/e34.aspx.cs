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

public partial class e3_e34 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile) {
            try
            {
                FileUpload1.PostedFile.SaveAs("e:\\jack_save\\" + FileUpload1.FileName);
                Label1.Text = "File upload success!";
            }
            catch {
                Label1.Text = "File upload fail!";
            }
        }
    }
}
