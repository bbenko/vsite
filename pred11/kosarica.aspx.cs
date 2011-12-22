using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class kosarica : System.Web.UI.Page
{
    private Kosarica _kosarica;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["kosarica"] == null)
        {
            _kosarica = new Kosarica();
            Session["kosarica"] = _kosarica;
        }
        else
        {
            _kosarica = (Kosarica) Session["kosarica"];
        }
        if (!Page.IsPostBack)
            Povezi();

        // način kako programski dodati JS u Page Load
        //ClientScript.RegisterClientScriptBlock(this.GetType(), "poruka", "alert('poruka')", true);


    }
    protected void btnSok_Click(object sender, EventArgs e)
    {
        _kosarica.Dodaj(1, "Sok", 10);
        Session["kosarica"] = _kosarica;
        Response.Redirect("kosarica.aspx");
    }


    protected void btnPivo_Click(object sender, EventArgs e)
    {
        //u realnoj situaciji, korisnik bi kliknuo na artikl sa tim id-em, 
        //a cijenu treba procitati iz baze
        _kosarica.Dodaj(2, "Pivo", 5);
        Session["kosarica"] = _kosarica;
        Response.Redirect("kosarica.aspx");
    }

    private void Povezi()
    {
        gvKosarica.DataSource = _kosarica.DajKosaricu;
        gvKosarica.DataBind();
    
    }
    protected void gvKosarica_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        _kosarica.Brisi(e.RowIndex);
        Session["kosarica"] = _kosarica;
        Povezi();
        
    }
    protected void gvKosarica_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvKosarica.EditIndex = e.NewEditIndex;
        Povezi();
    }
    protected void gvKosarica_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        e.Cancel = true;
        gvKosarica.EditIndex = -1;
        Povezi();
    }
    protected void gvKosarica_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        DataControlFieldCell celija = (DataControlFieldCell)gvKosarica.Rows[e.RowIndex].Controls[3];
        TextBox t = (TextBox)celija.Controls[0];
        try
        {
            int kol = int.Parse(t.Text);
            if (kol > 0)
                _kosarica.Promijeni(e.RowIndex, kol);
            else
                e.Cancel = true;
        }
        catch
        {
            e.Cancel = true;
        }
        gvKosarica.EditIndex = -1;
        Povezi();
    }
}
