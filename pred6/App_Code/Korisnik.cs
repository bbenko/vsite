using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Korisnik
/// </summary>
public class Korisnik
{
    public string KorisnickoIme;
    public string Lozinka;
    public string Email;
    
    public Korisnik(string korisnickoIme, string lozinka, string Email)
	{
        this.KorisnickoIme = korisnickoIme;
        this.Lozinka = lozinka;
        this.Email = Email;
	}


}