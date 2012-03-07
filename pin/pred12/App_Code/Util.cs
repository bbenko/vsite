using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for Util
/// </summary>
public class Util
{
	public Util()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static string Echo(string s)
    {
        return s;
    }

    public static int LosaHashFunkcija(string s)
    {
        int suma = 0;
        foreach (Char c in s)
            suma += c;
        return suma;
    }

    public static int FNV_PIN(string s)
    {
        int hash = 123; // FNV_offset_basis
        const int FNV_prime = 13;

        foreach (Char c in s)
        {
            hash *= FNV_prime;
            hash ^= c;
        }
        return hash;
    }

    public static string SHA256(string input)
    {
        SHA256 sha256 = new SHA256Managed();

        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        byte[] hash = sha256.ComputeHash(inputBytes);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
            sb.Append(hash[i].ToString("X2"));
        return sb.ToString();
    }
}