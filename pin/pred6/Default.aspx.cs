using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
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
    }
    protected void btnSpremi_Click(object sender, EventArgs e)
    {
        Session["ime"] = txtIme.Text;
        lblIme.Text = Session["ime"].ToString();
    }
    protected void btnOdjava_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}