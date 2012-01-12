using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hashevi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //lblRezultat.Text = Util.LosaHashFunkcija("BB").ToString();
        //lblRezultat.Text = Util.FNV_PIN("DA").ToString();
        //lblRezultat.Text = Util.SHA256("DA");

        string lozinka = "lozinka";
        Random r = new Random(System.DateTime.Now.Millisecond);

        string salt = r.Next().ToString(); // salt se generira za svakog usera i pise se u bazu u isti redak sa hashiranim passwordom

        string hashiranaLozinka = Util.SHA256(lozinka);
        string hashiranaISlanaLozinka = Util.SHA256(salt + hashiranaLozinka); //ovo se sprema u bazu


    }
}