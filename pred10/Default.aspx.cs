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
        SqlCeConnection conn = new SqlCeConnection(connString); // SqlConnection
        conn.Open();
        SqlCeCommand command = new SqlCeCommand("SELECT * FROM student WHERE pbr=@pbr", conn); // ... WHERE pbr=" + pbr.ToString() NE - SQL Injection
        command.Parameters.AddWithValue("pbr", 100200); // ovako rjestiti i labose sa usernmom i passwordom

        SqlCeDataReader dr = command.ExecuteReader();

        // za labose: dr.HasRows
        // HasRows ne radi na Sql Compact :(
        // workaround:
        // bool hasRow = dr.Read();
        // if (hasRow) {
        //   napravi nesto
        // }

        txtStudenti.Text = "";
        
        while (dr.Read())
        {
            txtStudenti.Text += dr[0] + " " +  dr["ime"] + " " + dr["prezime"] + " "+ dr["pbr"] + "\n";
        }

        dr.Close();
        command = new SqlCeCommand("SELECT COUNT(*) FROM student", conn);
        int broj = (int)command.ExecuteScalar();
        txtStudenti.Text += broj.ToString();
        conn.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCeConnection conn = new SqlCeConnection(connString);
        conn.Open();
        SqlCeCommand command = new SqlCeCommand("INSERT INTO student(ime, prezime, pbr) VALUES (@ime, @prezime, @pbr)", conn);
        command.Parameters.AddWithValue("ime", txtIme.Text);
        command.Parameters.AddWithValue("prezime", txtPrezime.Text);
        command.Parameters.AddWithValue("pbr", txtPbr.Text);

        command.ExecuteNonQuery();
        conn.Close();
    }
}