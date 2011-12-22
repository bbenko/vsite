using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

/// <summary>
/// Summary description for Kosarica
/// </summary>
public class Kosarica
{
    private List<Stavak> stavke;
	public Kosarica()
	{
        stavke = new List<Stavak>();
	}
    public void Dodaj(Stavak stavak)
    {
        Dodaj(stavak.Id, stavak.Naziv, stavak.Cijena);
    }
    public void Dodaj(int id, string naziv, decimal cijena)
    {
        foreach (Stavak s in stavke)
            if (s.Id == id)
            {
                s.Kolicina++;
                return;
            }
        Stavak st = new Stavak(id, naziv, cijena, 1);
        stavke.Add(st);
    }

    public void Brisi(int index)
    {
        stavke.RemoveAt(index);
    }

    public void Promijeni(int index, int novaKolicina)
    {
        Stavak s = stavke[index];
        s.Kolicina = novaKolicina;
    }

    public List<Stavak> DajKosaricu
    {
        get { return stavke; }
    }

    public decimal UkupnoUKosarici
    {
        get
        {
            decimal suma = 0;
            foreach (Stavak s in stavke)
                suma += s.Ukupno;
            return suma;
        }
    
    }

}
