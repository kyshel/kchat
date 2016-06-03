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
using System.Data.SqlClient;

public partial class e5_e51 : System.Web.UI.Page
{
    SqlConnection myconn = new SqlConnection();
    SqlCommand mycmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        string mystr = ConfigurationManager.AppSettings["my_con_str"];        
        myconn.ConnectionString = mystr;
        myconn.Open();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        if (myconn.State == ConnectionState.Open)
            Label1.Text = "database connect success";
        else
            Label1.Text = "database connect fail";

        string sql;
        sql = "SELECT * FROM users";
        mycmd.CommandText = sql;
        mycmd.Connection = myconn;

        SqlDataReader myreader = mycmd.ExecuteReader();
        while(myreader.Read()){
            Label1.Text += myreader[0].ToString() + myreader[1].ToString() + myreader[2].ToString() + myreader[3].ToString();

        
        }
        
        myconn.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection myconn = new SqlConnection();
        SqlCommand mycmd = new SqlCommand();

        string sql = "SELECT * FROM users";
        string sname;

        mycmd.CommandText = sql;
        mycmd.Connection = myconn;

        string mystr = ConfigurationManager.AppSettings["my_con_str"];
        myconn.ConnectionString = mystr;
        myconn.Open();

        int i = 0;

        SqlDataReader myreader = mycmd.ExecuteReader();
        while (myreader.Read())
        {
            sname = myreader[0].ToString();
            Response.Write(sname);
            i++;
        }
        myconn.Close();
    }
}
