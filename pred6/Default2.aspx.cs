using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ime"] != null)
            lblIme.Text = Session["ime"].ToString();
        else
            lblIme.Text = "Session prazan.";
        Application.Lock();
        Application["brojUcitavanja"] = ((int)Application["brojUcitavanja"]) + 1;
        Application.UnLock();
        lblBrojUcitavanja.Text = Application["brojUcitavanja"].ToString();
        lblBrojKorisnika.Text = Application["brojKorisnika"].ToString();
    }
}