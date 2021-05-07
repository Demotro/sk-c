using System;
using System.IO;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Streamwriter
            string lokace1 = @"C:\Users\krajc\source\repos\H23\Soubory\MujPrvniSoubor.txt";
            string lokace = @"C:\Users\krajc\source\repos\H23\Soubory\";
            string nazevsouboru = "MujPrvniSoubor.txt";
            string[] radky = { "Prvni radek", "Druhy radek", "Treti radek" };
            using (StreamWriter outputfile = new StreamWriter(Path.Combine(lokace, nazevsouboru)))
            {
                for (int i = 0; i < radky.Length; i++)
                {
                    outputfile.WriteLine(radky[i]);
                }
            }
            string[] radky2 = { "Prvni1 radek", "Druhy1 radek", "Treti1 radek" };
            //True only for append - true pouze pro pridani jiz existujicimu
            using (StreamWriter outputfile = new StreamWriter(Path.Combine(lokace, nazevsouboru), true))
            {

                for (int i = 0; i < radky2.Length; i++)
                {
                    outputfile.WriteLine(radky2[i]);
                }

            }
            //Zapiste jako samostatny radek vas veskery vystup z konzole. Pokud bude prazdny string nebo 0, pak to ukoncete
            string radek = "";
            using (StreamWriter outputfile = new StreamWriter(Path.Combine(lokace, nazevsouboru), true))
            {
                while (true)
                {
                    Console.WriteLine("Zapisuj radek a potvrd Enter. Pokud chces skoncit, zadej 0 a potvrd enter");
                    radek = Console.ReadLine();
                    if (radek == "0")
                    {
                        break;
                    }
                    outputfile.WriteLine(radek);
                }
            }
        }
    }
}