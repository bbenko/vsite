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
        // po defaultu je boja pozadine bijela (u slučaju da nema cookiea)
        HrvBoja.Boja boja = HrvBoja.Boja.Bijela;

        //ako cookie postoji
        if (Request.Cookies["postavke"] != null && Request.Cookies["postavke"]["boja"] != null)
        {
            string strBoja = Request.Cookies["postavke"]["boja"]; // procitamo ga kao string
            boja = (HrvBoja.Boja)Enum.Parse(typeof(HrvBoja.Boja), strBoja); // pretvorimo u enum
        }

        //pozovemo funkciju za pretvaranje hrv. enum-u System.Drawing.Color i podesimo BackColor property labela
        lblPozdrav.BackColor = HrvBoja.Daj(boja);
    }
}