using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class obrada : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblRezultat.Text = Request.QueryString["ime"].ToString() + "<br />" +
                            Server.HtmlEncode(Request.QueryString["prezime"].ToString()) + "<br />" +
                            Request.QueryString["lozinka"].ToString() + "<br />";
        if (Request.QueryString["redovni"] != null)
            lblRezultat.Text += Request.QueryString["redovni"].ToString() + "<br />";
        lblRezultat.Text += Request.QueryString["godina"].ToString() + "<br />" + 
                            Request.QueryString["spol"].ToString() + "<br />" + 
                            Request.QueryString["laptop"].ToString() + "<br />" + 
                            Request.QueryString["napomena"].ToString() + "<br />";
    }
}