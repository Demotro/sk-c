using System;
using System.IO;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            string lokace = @"C:\Users\GAME PC\source\repos\25\Files\";
            /*
            using (StreamWriter sw = new StreamWriter
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(i + 1);
                }
            }

            using (StreamReader sr = new StreamReader(Path.Combine(lokace, "soubor1.txt")))
            {
                string radek;
                while ((radek = sr.ReadLine()) != null)
                {
                    Console.WriteLine(radek);
                }
            }

            using (StreamWriter sw = new StreamWriter(Path.Combine(lokace, "soubor1.txt"), true))
            {
                for (int i = 10; i < 20; i++)
                {
                    sw.WriteLine(i + 1);
                }
            }

            string data = "";
            for (int i = 10; i < 20; i++)
            {
                data += (i + 1) + "\n";
            }

            using (StreamWriter sw = new StreamWriter(Path.Combine(lokace, "soubor1.txt"), false))
            {
                sw.WriteLine(data);
            }
            */

            string data = "";
            for (int i = 0; i < 10; i++)
            {
                data += (i + 1) + "\n";
            }
            //zapis(Path.Combine(lokace, "soubor1.txt"), data);
            SouborJob(Path.Combine(lokace, "soubor1.txt"), "w", data);
            data = "";
            for (int i = 10; i < 20; i++)
            {
                data += (i + 1) + "\n";
            }
            SouborJob(Path.Combine(lokace, "soubor1.txt"), "a", data);
            //zapis(Path.Combine(lokace, "soubor1.txt"), data, true);
            string str = SouborJob(Path.Combine(lokace, "soubor1.txt"), "r");
            Console.WriteLine(str);
        }
        static void zapis(string lokace, string data, bool pridej = false)
        {
            using (StreamWriter sw = new StreamWriter(lokace, pridej))
            {
                sw.WriteLine(data);
            }
        }

        static string SouborJob(string lokace, string delej, string data = "")
        {
            //Cteni
            if (delej == "r")
            {
                string output = "";
                using (StreamReader sr = new StreamReader(lokace))
                {
                    string radek;
                    while ((radek = sr.ReadLine()) != null)
                    {
                        output += radek;
                        Console.WriteLine(radek);
                    }
                }
                return output;
            }
            //Zapis
            else if (delej == "w")
            {
                using (StreamWriter sw = new StreamWriter(lokace))
                {
                    sw.WriteLine(data);
                }
            }
            //Append
            else if (delej == "a")
            {
                using (StreamWriter sw = new StreamWriter(lokace, true))
                {
                    sw.WriteLine(data);
                }
            }
            return "";
        }
    }
}
