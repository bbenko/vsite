using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Stavak
/// </summary>
public class Stavak
{
    private int _id;
    private string _naziv;
    private decimal _cijena;
    private int _kolicina; //float ili double

	public Stavak()
	{
        _id = 0;
        _naziv = "";
        _cijena = 0;
        _kolicina = 0;
	}

    public Stavak(int id, string naziv, decimal cijena, int kolicina)
    {
        _id = id;
        _naziv = naziv;
        _cijena = cijena;
        _kolicina = kolicina;    
    }

    public int Id
    {
        get {return _id;}
        set {_id = value;}
    }

    public string Naziv
    {
        get { return _naziv; }
        set { _naziv = value; }
    }
    public decimal Cijena
    {
        get { return _cijena; }
        set { _cijena = value; }
    }
    public int Kolicina
    {
        get { return _kolicina; }
        set { _kolicina = value; }
    }

    public decimal Ukupno
    {
        get
        {
            return _cijena * _kolicina;
        }
    }

    override public string ToString()
    {
        return _id.ToString() + " " + _naziv + " " + _cijena.ToString() + " " + _kolicina.ToString() + " " + Ukupno.ToString();

    }


}
