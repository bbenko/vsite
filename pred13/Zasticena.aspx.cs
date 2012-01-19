using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using faksModel;

public partial class Zasticena : System.Web.UI.Page
{
    private faksEntities faksContext;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["korisnickoIme"] != null)
        {
            string ime = Session["korisnickoIme"].ToString();
            lblDobrodosli.Text = "Dobrodošao " + ime;
            
            faksContext = new faksEntities();
            var studenti = from s in faksContext.student where s.ime == ime select s;
            foreach (var s in studenti)
                lblIspis.Text += s.ime + " " + s.prezime + " " + s.mjesto.naziv; 
        }
        else
            Response.Redirect("Default.aspx");
    }
    protected void btnOdjava_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}