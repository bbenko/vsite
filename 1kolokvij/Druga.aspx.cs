using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Druga : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Color boja;
            if (Request.Form["boja"] != null)
                txtBoja.Text = Request.Form["txtBoja"];
            else
                txtBoja.Text = "Nema boje";
            if (txtBoja.Text == "plava")
                boja = Color.Blue;
            else
                boja = Color.Red;

            if (Request.Form["otvori"] != null && Request.Form["otvori"].ToString() == "da")
                txtStatus.Text = "Otvoreno";
            else
                txtStatus.Text = "Zatvoreno";
            if (Session["X"] != null)
                txtX.Text = Session["X"].ToString();
            else
                txtX.Text = "Nema X";
            txtBoja.BackColor = boja;
            txtStatus.BackColor = boja;
            txtX.ForeColor = boja;
        }

    }
}