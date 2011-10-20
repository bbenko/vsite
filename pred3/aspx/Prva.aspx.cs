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

    }
    protected void btnPosalji_Click(object sender, EventArgs e)
    {
        //txtPoruka.Text = "Pozdrav svijete!";
        txtPoruka.Text = ddlKartice.SelectedItem.Text;

    }
    protected void ddlKartice_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtPoruka.Text = ddlKartice.SelectedItem.Text;
    }
}