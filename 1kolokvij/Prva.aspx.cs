using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Prva : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtStatus.Text = "1";
        txtBoja.Text = "crvena";
        if (Page.IsPostBack)
            Session["X"] = 1;
        else
            Session["X"] = 2;
        Response.Redirect("Druga.aspx?otvori=da");
    }
}