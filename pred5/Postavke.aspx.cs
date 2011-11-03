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
        ddlBoje.Items.Clear(); // brise sve iteme iz liste

        //dodaju se imena boja iz enuma u ddlBoje
        //dodaju se kao stringovi, što znači da je vrijednost itema string (jednaka display valueu)
        foreach(string b in Enum.GetNames(typeof(HrvBoja.Boja)))
            ddlBoje.Items.Add(b);

        //ovdje bi trebalo pročitati cookie i, ako postoji selektira boju iz cookia
        //to mozete za vjezbu sami :)
    }
    protected void btnSpremi_Click(object sender, EventArgs e)
    {
        //uzima se vrijednost (string) selektiranog iz liste i sprema se u cookie
        Response.Cookies["postavke"]["boja"] = ddlBoje.SelectedValue;
        Response.Cookies["postavke"].Expires = DateTime.Now.AddDays(1);
    }
}