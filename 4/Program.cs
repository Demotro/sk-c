using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
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
                else
                {
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
                else
                {
                    Console.WriteLine("Hledany prvek cislo:" + hledane_cislo + " Se nachazi na pozici:" + adresa);
                }
            }
            else { Console.WriteLine("Prvek nikde neni, bohuzel"); }


            Console.ReadLine();

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
