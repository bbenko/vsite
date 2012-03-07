using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Korisnici : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            List<Korisnik> korisnici = Clanstvo.DajKorisnike();
            foreach (Korisnik k in korisnici)
                lblKorisnici.Items.Add(k.KorisnickoIme + " " + k.Email);

        }    
    }
    protected void btnProvjeri_Click(object sender, EventArgs e)
    {
        if (Clanstvo.ProvjeriKorisnika(txtKorisnickoIme.Text, txtLozinka.Text))
            lblLozinka.Text = "Lozinka OK";
        else
            lblLozinka.Text = "Lozinka pogrešna";
    }
}