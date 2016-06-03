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

    
    // rows count
    /*
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
    */

    public int Rownum(string sql)
    {
        SqlConnection myconn = new SqlConnection();
        SqlCommand mycmd = new SqlCommand();

        mycmd.CommandText = sql;
        mycmd.Connection = myconn;

        string mystr = ConfigurationManager.AppSettings["my_con_str"];
        myconn.ConnectionString = mystr;
        myconn.Open();

        int i = 0;

        SqlDataReader myreader = mycmd.ExecuteReader();
        while (myreader.Read())
        {        
            i++;
        }
        myconn.Close();
        return i;
    }


    //as book
    public Boolean RunNonQuery(string sql) {
        SqlConnection myconn = new SqlConnection();
        SqlCommand mycmd = new SqlCommand();

        mycmd.CommandText = sql;
        mycmd.Connection = myconn;

        string mystr = ConfigurationManager.AppSettings["my_con_str"];
        myconn.ConnectionString = mystr;
        myconn.Open();

        try
        {
            mycmd.ExecuteNonQuery();
            myconn.Close();

        }
        catch {
            myconn.Close();
            return false;
        }
        return true;
    }

    //only return one line, string type
    public string sql_one(string sql)
    {
        SqlConnection myconn = new SqlConnection();
        SqlCommand mycmd = new SqlCommand();

        mycmd.CommandText = sql;
        mycmd.Connection = myconn;

        string mystr = ConfigurationManager.AppSettings["my_con_str"];
        myconn.ConnectionString = mystr;
        myconn.Open();

        string i;

        SqlDataReader myreader = mycmd.ExecuteReader();
        i = myreader[0].ToString();

        myconn.Close();
        return i;
    }

    public DataSet run_sql(string sql,string tname)
    {

        SqlConnection myconn = new SqlConnection();

        string mystr;
        mystr = ConfigurationManager.AppSettings["my_con_str"];
        myconn.ConnectionString = mystr;
        myconn.Open();

        SqlDataAdapter myda = new SqlDataAdapter(sql,myconn);
        DataSet myds = new DataSet();
        myda.Fill(myds, tname);
        myconn.Close();

        return myds;

    }
}
