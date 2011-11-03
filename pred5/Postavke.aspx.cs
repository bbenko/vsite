using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Postavke : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach(string b in Enum.GetNames(typeof(Boje)))
            ddlBoje.Items.Add(b);
    }
    protected void btnSpremi_Click(object sender, EventArgs e)
    {
        Response.Cookies["postavke"]["boja"] = ddlBoje.SelectedValue;
    }
}