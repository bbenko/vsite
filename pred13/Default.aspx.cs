using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlServerCe;

public partial class _Default : System.Web.UI.Page
{
    string connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["FaksConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {                                                                                           
    }
    protected void Login_Click(object sender, EventArgs e)
    {
        SqlCeConnection conn = new SqlCeConnection(connString); // SqlConnection
        conn.Open();
        
        //podlozno SQL injection napadu
        //SqlCeCommand command = new SqlCeCommand("SELECT * FROM student WHERE ime = '" +
        //                                            txtKorisnickoIme.Text + "' AND lozinka = '" +
        //                                            txtLozinka.Text + "'", conn);

        SqlCeCommand command = new SqlCeCommand("SELECT * FROM student WHERE ime = @ime AND lozinka = @lozinka", conn);
        command.Parameters.AddWithValue("ime", txtKorisnickoIme.Text);
        command.Parameters.AddWithValue("lozinka", txtLozinka.Text);

        SqlCeDataReader dr = command.ExecuteReader();
        if (dr.Read())
        {
            Session["korisnickoIme"] = dr["ime"].ToString();
            dr.Close();
            conn.Close();
            Response.Redirect("Zasticena.aspx");
        }
        dr.Close();
        conn.Close();
    }
}