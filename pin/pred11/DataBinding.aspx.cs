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

public partial class DataBinding : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String connString = ConfigurationManager.ConnectionStrings["faksConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();

        SqlCommand naredba = new SqlCommand("SELECT * FROM student", conn);

        SqlDataAdapter da = new SqlDataAdapter(naredba);

        DataSet ds = new DataSet();
        da.Fill(ds, "student");

        conn.Close();

        DataTable dt = ds.Tables["student"];

        gvStudenti.DataSource = dt;

        gvStudenti.DataBind();
    
    }
}
