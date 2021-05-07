using System;
using System.IO;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            string lokace1 = @"C:\Users\GAME PC\source\repos\23\Soubory\MujPrvniSoubor.txt";
            string lokace = @"C:\Users\GAME PC\source\repos\23\Soubory\";
            string nazevsouboru = "MujPrvniSoubor.txt";
            string[] radky = { "Prvni radek", "Druhy radek", "Treti radek" };
            using (StreamWriter outputfile = new StreamWriter(Path.Combine(lokace, nazevsouboru), true))
            {
                for (int i = 0; i < radky.Length; i++)
                {
                    outputfile.WriteLine(radky[i]);
                }
            }
            string[] radky2 = { "Prvni radek", "Druhy radek", "Treti radek" };
            using (StreamWriter outputfile = new StreamWriter(Path.Combine(lokace, nazevsouboru), true))
            {
                for (int i = 0; i < radky2.Length; i++)
                {
                    outputfile.WriteLine(radky2[i]);
                }
            }

        }
    }
}