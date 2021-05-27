using System;
using System.IO;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            string lokaceAdr = @"C:\Users\GAME PC\source\repos\24\Output\";
            string nazevsouboru = "vystupni.txt";

            using (StreamWriter output = new StreamWriter(Path.Combine(lokaceAdr, nazevsouboru)))
            {
                //for cyklus s 10 hodnoty v souboru
                for (int i = 0; i < 10; i++)
                {
                    if (i == 9)
                    {
                        output.Write(i + 1);
                    }
                    else
                    {
                        output.WriteLine(i + 1);
                    }
                }
            }
            /*
            using (StreamWriter output = new StreamWriter(Path.Combine(lokaceAdr, nazevsouboru)))
            {
                string radek;
                while (true)
                {
                    Console.WriteLine("Muzes psat jak o zivot, dokud nenapises STOP");
                    radek = Console.ReadLine();
                    if (radek == "STOP")
                    {
                        break;
                    }
                    output.WriteLine(radek);    
                }
            }
            */
            Random rnd = new Random();
            string str = "soubor";
            for (int i = 0; i < 5; i++)
            {
                int treshold = rnd.Next(0, 100);
                string outputfile = str + (i + 1).ToString() + ".txt";
                using (StreamWriter output = new StreamWriter(Path.Combine(lokaceAdr, outputfile)))
                {
                    for (int j = 0; j < treshold; j++)
                    {
                        output.WriteLine(rnd.Next(0,10));
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                string outputfile = str + (i + 1).ToString() + ".txt";
                using (StreamReader output = new StreamReader(Path.Combine(lokaceAdr, outputfile)))
                {
                    string radek;
                    Console.WriteLine("Vtej v:" + (str + (i + 1)));
                    while ((radek = output.ReadLine()) != null)
                    {
                        Console.WriteLine(radek);
                    }
                }
            }
        }
    }
}