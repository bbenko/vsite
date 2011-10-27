using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IsPostback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
            lblPostback.Text = "Dogodio se postback.";
        else
            lblPostback.Text = "Stranica se učitala prvi puta.";
    }
}