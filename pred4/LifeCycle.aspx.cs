using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LifeCycle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtDogadaji.Text = txtDogadaji.Text + "Stranica se učitala.\n";
    }
    protected void btnPosalji_Click(object sender, EventArgs e)
    {
        txtDogadaji.Text = txtDogadaji.Text + "Klik na gumbić\n";
    }
    protected void ddlIzbor_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtDogadaji.Text += "Promjena izbora\n";
    }
}