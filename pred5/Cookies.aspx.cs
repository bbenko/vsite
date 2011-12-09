using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cookies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["korisnickeInformacije"] != null 
            && Request.Cookies["korisnickeInformacije"]["korisnickoIme"] != null)
            lblCookie.Text = Request.Cookies["korisnickeInformacije"]["korisnickoIme"];
        else
            lblCookie.Text = "Nema cookiea";

    }
    protected void btnNapraviCookie_Click(object sender, EventArgs e)
    {
        Response.Cookies["korisnickeInformacije"]["korisnickoIme"] = "Mirko"; 
        Response.Cookies["korisnickeInformacije"]["zadnjiPosjet"] = DateTime.Now.ToString();
        Response.Cookies["korisnickeInformacije"].Expires = DateTime.Now.AddMinutes(10);

    }
}