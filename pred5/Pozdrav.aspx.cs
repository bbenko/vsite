using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Pozdrav : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Boje boja = Boje.Bijela;
        if (Request.Cookies["postavke"] != null && Request.Cookies["postavke"]["boja"] != null)
        {
            string strBoja = Request.Cookies["postavke"]["boja"];
            boja = (Boje)Enum.Parse(typeof(Boje), strBoja);
        }
        HrvBoje hb = new HrvBoje();

        lblPozdrav.BackColor = hb.d[boja];
    }
}