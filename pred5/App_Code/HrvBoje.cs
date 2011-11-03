using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

public enum Boje { Crna, Plava, Crvena, Zelena, Bijela }

/// <summary>
/// Summary description for Boje
/// </summary>
public class HrvBoje
{
    public Dictionary<Boje, Color> d = new Dictionary<Boje, Color>()
    {
	    {Boje.Crna, Color.Black},
	    {Boje.Plava, Color.Blue},
        {Boje.Crvena, Color.Red},
        {Boje.Zelena, Color.Green},
        {Boje.Bijela, Color.White}
	};

}