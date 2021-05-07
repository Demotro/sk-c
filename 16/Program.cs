using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            // (5-10) * 5
            //double dilcivysledek = Odecet(5, 10);
            //double vysledek = Nasobeni(dilcivysledek, 5);
            //double vysledek = Nasobeni(Odecet(5,10), 5);
            sipka(10);
            //Trojuhelnik(-25);
            // ( ( 6 - 10 ) * 5 ) - ( ( 10 + 9 ) - 6 )
            //vysledek = Odecet(Nasobeni(Odecet(6, 10), 5), Odecet(Soucet(10, 9), 6));

            // Printni(vysledek.ToString());

            //Prace s for cyklem
            /*
              
            funkce(int pocet);
            
                *
                **
                ***
                ****
                *****
                ******
                ******* - maximalni pocet hvezdicek
                ******
                *****
                ****
                ***
                **
                *
              
            i++
            i--
            Console.Write(*)
            */

            Console.ReadKey();
        }

        static void Trojuhelnik(int vstup)
        {
            for (int i = 0; i < vstup; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = vstup - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        static void Printni(string str)
        {
            Console.WriteLine(str);
        }

        //Soucet, Odecet, Deleni, Nasobeni - s navratovou hodnotou (typ double).

        static double Soucet(double a, double b)
        {
            return a + b;
        }

        static double Odecet(double a, double b)
        {
            return a - b;
        }
        static double Deleni(double a, double b)
        {
            return a / b;
        }
        static double Nasobeni(double a, double b)
        {
            return a * b;
        }


        static void sipka(int pocet)
        {
            for (int i = 1; i < pocet + 2; i++)
            {

                for (int tmp = 0; tmp < i; tmp++)
                {
                    Console.Write("*");




                }
                Console.WriteLine("");
            }
            int tmp2 = pocet;
            for (int i = 0; i < pocet + 1; i++)
            {

                for (int tmp = tmp2; tmp > 0; tmp--)
                {
                    Console.Write("*");




                }
                Console.WriteLine("");
                tmp2--;
            }
        }
    }
}
