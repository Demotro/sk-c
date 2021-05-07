using System;
using System.IO;

namespace H22
{
    class Program
    {
        static void Main(string[] args)
        {
            string jmeno = "Jiri";
            string prijmeni = "Sammer";
            string jmenoprijmeni = jmeno +" "+ prijmeni;
            //Spojovat / Contatenate
            string jmenoprijmeni2 = string.Concat(string.Concat(jmeno, " "), prijmeni);
            jmenoprijmeni2 = jmenoprijmeni2.Remove(4);
            //Console.WriteLine(jmenoprijmeni2);
            string workingDir = System.IO.Directory.GetCurrentDirectory();
            string workindDirRelative = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(workingDir);
            Console.WriteLine(workingDir.IndexOf("H22"));
            string control = "H22";
            workingDir = workingDir.Remove(workingDir.IndexOf(control) + control.Length + 1);
            /*
            for (int i = 0; i < workingDir.Length; i++)
            {
                if (workingDir[i] == 'H' && workingDir[i + 1] == '2' && workingDir[i + 2] == '1')
                {
                    Console.WriteLine("zde");
                    workingDir = workingDir.Remove(i + 4);
                    break;
                }
                //Console.WriteLine(workingDir[i]);
            }
            */
            Console.WriteLine(workingDir);
            /*
            foreach (char o in workingDir)
            {
                Console.WriteLine(o);
            }
            */
            /*
            //Nacteni cesty
            workingDir += @"Soubory\soubor.txt";
            //workingDir += "Soubory\\soubor.txt";
            Console.WriteLine(workingDir);
            string workingDirAbsolute = @"C:\Users\GAME PC\source\repos\H22\Soubory\soubor.txt";
            Console.WriteLine("Relativni cesta:{0}", workindDirRelative);
            Console.WriteLine("Absolutni cesla:{0}", workingDirAbsolute);

            using (StreamReader sr = new StreamReader(workindDirRelative))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            */
            string workingDirAbsolute = @"C:\Users\GAME PC\source\repos\H22\H22\Soubory\soubor.txt";
            string soubor = System.IO.File.ReadAllText(workingDirAbsolute);
            Console.WriteLine("\n\n Obsah souboru:{0}", soubor);

            string[] souborek = System.IO.File.ReadAllLines(workingDirAbsolute);


            Console.ReadKey();
        }
    }
}
