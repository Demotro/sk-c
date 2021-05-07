using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kalkulacka - While, dokud se nenapise 0 - vypisete vysledek
            Po vypoctu napisete vysledek a zeptate se, co se ma delat. Zaroven napisete cislo.
            Muzete provadet operace nad aktualnim vysledkem.
            */
            Print("Vitej v nasi kalkulacce. Zadej prvni cislo");
            double a = Double.Parse(Console.ReadLine());
            Print("Zadej druhe cislo");
            double b = Double.Parse(Console.ReadLine());
            Print("Jakou operaci s cisly chces provest?");
            string operace = Console.ReadLine();
            double vysledek = 0;
            while (true)
            {
                vysledek = Vypocet(a, b, operace);
                Print(vysledek.ToString());
                Print("Jestli nechces pokracovat dal, stiskni 0. Pokud chces pokracovat dal stiskni enter");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
                Print("S jakzm cislem chces vuci vysledku pracovat");
                a = vysledek;
                b = Double.Parse(Console.ReadLine());
                Print("Jakou operaci s cisly chces provest?");
                operace = Console.ReadLine();
            }

            Print("Jsme na konci, posledni vysledek byl: " + vysledek);

            Console.ReadKey();
        }

        //Funkce pro nasobeni, deleni a odecitani
        static double Soucet(double cislo1, double cislo2)
        {
            return cislo1 + cislo2;
        }
        static double Odecet(double cislo1, double cislo2)
        {
            return cislo1 - cislo2;
        }
        static double Deleni(double cislo1, double cislo2)
        {
            return cislo1 / cislo2;
        }
        static double Nasobeni(double cislo1, double cislo2)
        {
            return cislo1 * cislo2;
        }

        static void Print(string retezec)
        {
            Console.WriteLine(retezec);
        }

        static double Vypocet(double a, double b, string operace)
        {
            double vysledek = 0;
            if (operace == "*")
            {
                vysledek = Nasobeni(a, b);
            }
            else if (operace == "/")
            {
                vysledek = Deleni(a, b);
            }
            else if (operace == "-")
            {
                vysledek = Odecet(a, b);
            }
            else if (operace == "+")
            {
                vysledek = Soucet(a, b);
            }
            else
            {
                Print("Nevim co po me chces");
            }

            return vysledek;
        }

    }
}
