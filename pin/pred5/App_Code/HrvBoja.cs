using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

/// <summary>
/// Pomoćna klasa za pretvaranje hrv. boja u System.Drawing.Color boje
/// </summary>
public class HrvBoja
{
    //popis hrv. boja
    public enum Boja { Crna, Plava, Crvena, Zelena, Bijela }

    //mapiranje na System.Drawing.Color boje
    //enum Boja je kluč
    //Color je value
    private static Dictionary<Boja, Color> d = new Dictionary<Boja, Color>()
    {
	    {Boja.Crna, Color.Black},
	    {Boja.Plava, Color.Blue},
        {Boja.Crvena, Color.Red},
        {Boja.Zelena, Color.Green},
        {Boja.Bijela, Color.White}
	};

    // metoda koja vraća Color boju za zadanu enum (hrv) boju
    public static Color Daj(Boja boja)
    {
        return d[boja];
    }
}