using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] policko = { 10, 5, 0, 1, 4 };
            string[] strpolicko = { "pondeli", "utery", "streda", "ctvrtek", "patek" };
            strpolicko[0] = "nedele";
            //Console.WriteLine(policko[0]);
            //Console.WriteLine(strpolicko[0]);
            //Console.WriteLine(strpolicko.Length);
            int hodnota = 10;
            int[] policko2 = new int[hodnota];
            policko2[0] = 10;
            policko2[9] = 5;
            policko2[5] = 3;
            //Console.WriteLine(policko2[7]+"a k tomu:"+policko2[4]);

            //Prictete 10ku pouze k hodnotam, ktere nejsou 0, jsou ruzne od nuly;
            for (int i = 0; i < policko2.Length; i++)
            {
                if (policko2[i] != 0)
                {
                    policko2[i] += 10; // policko2[i] = policko2[i] + 5;
                    Console.WriteLine("Prvek byl nenulovy  po pricteni 10ky:" + policko2[i]);
                }
                else
                {
                    Console.WriteLine("Hodnota:" + policko2[i]);
                }
            }
            //Random fce - nahodile, nahodily, nahodny
            // int[] policko2 = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < policko2.Length; i++)
            {
                policko2[i] = rnd.Next(0, 50);
                Console.WriteLine(policko2[i]);
                /* if (policko2[i] >= 25)
                 {
                     policko2[i] = 0;
                 }
                 if(policko2[i] < 25)
                 {
                     policko2[i] = 1;
                 }
                 Console.WriteLine(policko2[i]);*/
            }

            Console.WriteLine("");

            for (int i = 0; i < policko2.Length; i++)
            {
                if (policko2[i] >= 25)
                {
                    policko2[i] = 0;
                    Console.Write("vetsi");
                }

                else if (policko2[i] < 25)
                {
                    policko2[i] = 1;
                    Console.Write("mensi");
                }
                Console.WriteLine(policko2[i]);
            }

            //Novy nebo puvodni for cyklus vsechna cisla vetsi rovno nez 25 prepsali na 0
            //vsechna cisla mensi nez 25 prepsali na 1

            //Po zadani hodnoty uzivatelem vytvorte pole o velikosti ktere uzivatel zadal a pomoci for cyklu jej naplnte nahodnymi hodnotami a hodnoty ktere jsou vetsi mensi nez.





            //while


            /*
            // Pole Staticke
            int[] pole = { 5, 7, 1, 6, 8, 9 };
            Console.WriteLine(pole[5]);
            pole[5] += 6;
            Console.WriteLine(pole[5]);
            int[] pole2;
            //Rnd velikost
            Random rnd = new Random();
            pole2 = new int[rnd.Next(0, 500)];
            Console.WriteLine(pole2.Length);
            */
            Console.ReadKey();

        }
    }
}