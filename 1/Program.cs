using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {   //Vycet nejmensiho prvku z posloupnosti a pocet kolikrat se ukaze
            /*
            List<int> pole = new List<int>();
            pole.Add(9);
            pole.Add(2);
            pole.Add(3);
            pole.Add(8);
            pole.Add(2);
            pole.Add(7);
            pole.Add(6);
            pole.Add(2);
            pole.Add(7);
            pole.Add(8);
            pole.Add(2);
            pole.Add(4);
            pole.Add(2);
            pole.Add(5);
            pole.Add(1);
            int nejmensi_prom = 0;
            int pocet = 0;
            for (int i = 0; i < pole.Count; i++)
            {
                if (i == 0)
                {
                    nejmensi_prom = pole[i];
                }
                if (nejmensi_prom > pole[i])
                {
                    nejmensi_prom = pole[i];
                    pocet = 1;
                }
                else if (nejmensi_prom == pole[i])
                {
                    pocet++;
                }                
            }
            Console.WriteLine("Nejmensi prvek je: "+ nejmensi_prom + " , vyskytuje se zde:"+pocet);
            Console.ReadKey();
            */
            //--------------------------------Blok If, else if, else
            //int cislo=4;
            //int cislo2 = 3;
            /* if (cislo >= 0 && cislo < 3)
              {
                  Console.WriteLine("Cislo je vetsi nez 0 a mensi nez 3 a je rovno hodnote: " + cislo);
              }
              else if (cislo == 3)
              {
                  Console.WriteLine("Cislo je rovno trem jsme ve druhe casti: " + cislo);
              }
              else if (cislo == 4)
              {
                  Console.WriteLine("Cislo je rovno ctyrem pro kontrolu cislo je: " + cislo);
              }
              else
              {
                  Console.WriteLine("Cislo nevzhovuje zadne podmince a je rovno hodnote: " + cislo);
              }*/
            //---------------------------BLOK for cyklus
            /*Console.WriteLine("Zahajuji vycet prvku");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Prave jsme na prvku cislo:" + i);
            }
            Console.WriteLine("Dosazen maximalni pocet opakovani");*/
            //---------------------------BLOK while cyklus.
            /*bool tlacitko = true;
            int pocet=0;
            while (tlacitko==true)
            {
                pocet++;
                Console.WriteLine("Aktualne jsme na poctu: " + pocet);
                if (pocet == 15)
                {
                    tlacitko = false;
                }
            
            }
            Console.WriteLine("Jsme venku");*/
            //---------------------------- BLOK do while cyklus
            /*int pocet = 0;
            do
            {
                pocet++;
                Console.WriteLine("Aktualne jsme na poctu: " + pocet);
            } 
            while (pocet >1000);
            Console.WriteLine("Jsme venku");*/
            Console.ReadKey(); //Pockej na stisk klavesy / chceme se podivat co tam je;



        }
    }
}