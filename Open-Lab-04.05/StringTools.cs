using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string koniec = "";
            for (int i = 0; i <orig.Length ; i++)
            {
                for (int u = 0; u < n; u++)
                {
                    koniec = koniec + orig[i];
                }
            }
            return koniec;
        }   
    }
}
