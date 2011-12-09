using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Korisnik
/// </summary>
public static class Clanstvo
{
    private static List<Korisnik> korisnici = new List<Korisnik>() {
        new Korisnik("Ivo", "ivo123", "drivo@remetinec.hr"),
        new Korisnik("Jaca", "jaca321", "jaca@ravnice.hr"),
        new Korisnik("Šeks", "šeks321", "sheks@birtija.hr")
    };

    public static bool ProvjeriKorisnika(string korisnickoIme, string lozinka)
    {
        foreach (Korisnik k in korisnici)
        {
            if (korisnickoIme.Equals(k.KorisnickoIme) && lozinka.Equals(k.Lozinka))
                return true;
        }
        return false;
    }

    public static List<Korisnik> DajKorisnike()
    {
        return korisnici;
    }
}