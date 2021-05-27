using System;
using System.IO;
using System.Text.RegularExpressions;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            string cesta = @"C:\Users\GAME PC\source\repos\TEST\Cteni\soubor.txt";
            string radek;
            string zalomeni = "";
            using (StreamReader sr = new StreamReader(cesta))
            {
                while ((radek = sr.ReadLine()) != null)
                {
                    if (radek.Contains("pak"))
                    {
                        radek = Regex.Replace(radek, "pak", "kocka");
                        zalomeni += radek + "\n";
                        Console.WriteLine();
                        Console.WriteLine(radek);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
