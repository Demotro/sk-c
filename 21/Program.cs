using System;
using System.IO;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            string jmeno = "Tomas";
            string prijmeni = "Krajca";
            string jmenoprijmeni = jmeno + " " + prijmeni;
            //Spojovat / Contatenate
            string jmenoprijmeni2 = string.Concat(string.Concat(jmeno, " "), prijmeni);
            jmenoprijmeni2 = jmenoprijmeni2.Remove(3);
            //Console.WriteLine(jmenoprijmeni2);
            string workingDir = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(workingDir);
            // Odstranit vse po H21, 
            Console.WriteLine(workingDir.IndexOf("H21")); // vraci 28
            string control = "H21";
            workingDir = workingDir.Remove(workingDir.IndexOf(control) + control.Length + 1);
            /*
            for (int i = 0; i < workingDir.Length-2; i++)
            {
                if (workingDir[i] == 'H' && workingDir[i+1]=='2' && workingDir[i+2]=='1')
                {
                    Console.WriteLine("zde");
                    workingDir=workingDir.Remove(i + 4);
                    break;
                }
                //Console.WriteLine(workingDir[i]);
            }*/
            Console.WriteLine(workingDir);
            /*foreach (char o in workingDir)
            {
                Console.WriteLine(o);
            }*/
            // Nacteni cesty soubor.txt
            workingDir += @"Soubory\soubor.txt";
            //workingDir += "Soubory\\soubor.txt";
            Console.WriteLine(workingDir);
            string workingDirAbsolute = @"C:\Users\krajc\source\repos\H21\Soubory\soubor.txt";
            string workindDirRelative = "../../../Soubory/soubor.txt";
            Console.WriteLine("Relativni cesta:{0}", workindDirRelative);
            Console.WriteLine("Absolutni cesta:{0}", workingDirAbsolute);

            using (StreamReader sr = new StreamReader(workindDirRelative))
            {
                string line;
                while ((line = sr.ReadLine()) != null) //EOF E0F
                {
                    Console.WriteLine(line);
                }
            }
            // Druhy zpusob
            string soubor = System.IO.File.ReadAllText(workingDirAbsolute);
            Console.WriteLine("\n\nObsah souboru:{0}", soubor);
            // Treti zpusob
            string[] souborek = System.IO.File.ReadAllLines(workingDirAbsolute);
            Console.WriteLine("\n\nObsah pole:");
            foreach (string line in souborek)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}