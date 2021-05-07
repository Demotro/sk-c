using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Na zaklade vstupni informace o poctu, vypiste dany pocet hvezdicek, hvezdicka je definovana takto: ",  *  ,"
            /* Console.WriteLine("Vazeny uzivateli, nakreslim ti hvezdicek, kolik budes chtit!! Kolik si jich prejes?");
             int pocet = Int32.Parse(Console.ReadLine());
             for (int i = 0; i < pocet; i++)
             {
                 Console.Write("\n,  *  ,");
             }
             Console.ReadKey();
            */
            //Na zaklade vstupni informace o poctu, vypiste dany pocet hvezdicek, jeji poradi a hvezdicka je definovana jako string takto: ",  *  ,"
            /*while (true)
            {
                Console.WriteLine("\nVazeny uzivateli, nakreslim ti hvezdicek, kolik budes chtit!! Kolik si jich prejes?");
                int pocet = Int32.Parse(Console.ReadLine());
                string hvezdicka = "h*v*e*z*d*i*c*k*a*";
                for (int i = 0; i < pocet; i++)
                {
                    Console.WriteLine("Na {0}. miste je:{1}", i + 1, hvezdicka);
                }             
            }*/
            //Vypis nam 25 hvezdicek pomoci jednoho for cyklu
            /*for (int i=0;i<25;i++)
            {
                Console.WriteLine("*");            
            }
            Console.ReadKey();
            */
            //Vypis nam 25 hvezdicek pomoci dvou for cyklu
            int pozice = 0;
            int pocet = 0;
            for (int i = 0; i < 5; i++)
            {
                //pozice++;
                for (int j = 0; j < 5; j++)
                {
                    pozice++;
                    /*
                    //Podminka pro nulty prvni i druhy forcyklus
                    if (i == 0 && j == 0)
                    {
                        pozice = 1;
                    }
                    //Podminka pro nulty prvni forcyklus
                    else if (i == 0 && j != 0)
                    {
                        pozice = j + 1;
                    }
                    //Podminka, pro j prvni iteraci 
                    else if (i != 0 && j == 0)
                    {
                        pozice = (5 * i) + 1 ;
                    }
                    //Pocitej dal, kdyz <i> je nenulove a <j> take nenulove
                    else 
                    {
                        pozice = (5 * i) + 1 + j;
                    }*/
                    if (pozice % 2 != 0)
                    {
                        pocet++;
                        Console.WriteLine("Jedna se o lichy pocet:{0} -:> * ", pocet);
                    }
                    else if (pozice % 2 == 0)
                    {
                        pocet++;
                        Console.WriteLine("Jedna se o sudy pocet:{0} -:> * ", pocet);
                    }
                    /// pozice++;
                }
                //pozice++;
            }
            Console.ReadKey();

        }
    }
}