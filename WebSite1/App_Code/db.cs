using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for db
/// </summary>
public class db : System.Web.UI.Page
{
	public db()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    

    public int Rownum(string sql, ref string user_name) {
        

        SqlConnection myconn = new SqlConnection();
        SqlCommand mycmd = new SqlCommand();

        mycmd.CommandText = sql;
        mycmd.Connection = myconn;

        string mystr = ConfigurationManager.AppSettings["my_con_str"];
        myconn.ConnectionString = mystr;
        myconn.Open();

        int i = 0;

        SqlDataReader myreader = mycmd.ExecuteReader();
        while(myreader.Read()){
            user_name=myreader[0].ToString();
            i++;
        }
        myconn.Close();
        return i;
    }
}
