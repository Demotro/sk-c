using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[20];
            var rand = new Random();
            for (int i = 0; i < pole.Count(); i++)
            {
                pole[i] = rand.Next(1, 999);
                // Console.WriteLine("Hodnota na pozici {0} je rovna={1}", i, pole[i]); //Kontrolni vypis z pole
                Console.Write(" {0} ", pole[i]);
            }
            int kontrola = 1;
            int tmp;
            int pocetkroku = 0;
            while (kontrola != 0)
            {
                pocetkroku += 1;
                kontrola = 0;

                for (int i = 0; i < pole.Count() - 1; i++)
                {
                    if (pole[i] < pole[i + 1])
                    {
                        tmp = pole[i + 1];
                        pole[i + 1] = pole[i];
                        pole[i] = tmp;
                        kontrola = kontrola + 1;
                    }
                }
            }

            Console.WriteLine("\nMame serazeno za pocet kroku:{0}", pocetkroku);
            for (int i = 0; i < pole.Count(); i++)
            {
                Console.Write(" {0} ", pole[i]);
            }


            Console.ReadKey();



            //Eukliduv algoritmus
            /* var control = 1;
             while (control != 0)
             {
                 long a;
                 long b;
                 long tmp;
                 Console.WriteLine("Napis nam prvni promennou:");
                 a = Int64.Parse(Console.ReadLine());
                 Console.WriteLine("Napis nam druhou promennou:");
                 b = Int64.Parse(Console.ReadLine());
                 if (a > b)
                 {
                 }
                 else
                 {
                     tmp = a;
                     a = b;
                     b = tmp;
                 }
                 while (b != 0)
                 {
                     Console.Write("{0}  /  {1} =",a,b);
                     tmp = a % b;
                     a = b;
                     Console.Write(" {0}*CeloCisNasobek + {1}\n", b, tmp);
                     b = tmp;
                 }
                 Console.WriteLine("\nNejvetsi spolecny delitel je:{0}\n", a);
                 control = Int32.Parse(Console.ReadLine());
             }
             Console.WriteLine("Program konci");
             Console.ReadKey();
                 */
            /*
            //Binarni prohledavani
            List<int> list_cisel = new List<int>();
            list_cisel.Add(16);
            list_cisel.Add(15);
            list_cisel.Add(14);
            list_cisel.Add(13);
            list_cisel.Add(12);
            list_cisel.Add(11);
            list_cisel.Add(10);
            list_cisel.Add(9);
            list_cisel.Add(8);
            list_cisel.Add(7);
            list_cisel.Add(6);
            list_cisel.Add(5);
            list_cisel.Add(4);
            int hledane_cislo = 10;
            int adresa = -1;
            int pivot = list_cisel.Count / 2;
            // Console.WriteLine("Pivot je:"+pivot); Abychom zkontrolovali jake cislo nam to hodi - Hazi to prave to cele cislo (typicke pro Integer)
            if (list_cisel[pivot] == hledane_cislo)
            {
                adresa = pivot;               
            }
            else
            {
                //Pokud je vetsi, pak pri serazenem (Od nejvys po nejmensi) jdeme doprava / tzn k vetsim prvkum
                if (list_cisel[pivot] > hledane_cislo)
                {
                    for (int i = pivot; i < list_cisel.Count; i++)
                    {
                        if (list_cisel[i] == hledane_cislo)
                        {
                            adresa = i;
                            break;
                        }
                    }
                }
                //Pivot je mensi nez hledane cislo
                else {
                    for (int i = pivot; i > -1; i--)
                    {
                        if (list_cisel[i] == hledane_cislo)
                        {
                            adresa = i;
                            break;
                        }
                    }
                }
            }
            if (adresa >= 0)
            {
                if (adresa == pivot)
                {
                    Console.WriteLine("Hledany prvek cislo:" + hledane_cislo + " Se nachazi na pozici:" + adresa + ". Zaroven je pivotem.");
                }
                else { 
                Console.WriteLine("Hledany prvek cislo:" + hledane_cislo + " Se nachazi na pozici:" + adresa);
                }
            }
            else { Console.WriteLine("Prvek nikde neni, bohuzel"); }
            Console.ReadLine();
            */
            //Linearni prohledavani 
            /*
            List<int> list_cisel = new List<int>();
            list_cisel.Add(9); 
            list_cisel.Add(10);
            list_cisel.Add(3);
            list_cisel.Add(5);
            list_cisel.Add(8);
            list_cisel.Add(6);
            list_cisel.Add(12);
            list_cisel.Add(21);
            list_cisel.Add(4);
            list_cisel.Add(1); 
            list_cisel.Add(0);
            list_cisel.Add(7);
            int hledane_cislo = 25;
            int adresa=-1;
            for (int i = 0; i < list_cisel.Count; i++)
            {
                if (list_cisel[i] == hledane_cislo)
                {
                    adresa = i;
                    break;
                }
            }
            if (adresa >= 0)
            {
                Console.WriteLine("Nalezeny prvek o hodnote:" + hledane_cislo + " Se nachazi na pozici cislo:" + adresa);
            }
            else {
                Console.WriteLine("Hledany prvek v listu neexistuje.");
            }
            Console.ReadLine();
            */
        }
    }
}

