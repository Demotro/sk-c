using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list_ako_pole = new List<int>();
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                list_ako_pole.Add(rnd.Next(0, 100));
                Console.WriteLine("Do listu ako pole jsem pridal hodnotu" + list_ako_pole[i]);
            }

            for (int i = list_ako_pole.Count - 1; i >= 0; i--)
            {
                Console.WriteLine("Na pozici:" + i + " Je hodnota:" + list_ako_pole[i]);
            }

            //Kolik hodnot je >50 a kolik jich je<50 z listu ako_pole;
            //Zde deklaruji promenne, do kterych ulozim informace o poctu hodnot
            int vice = 0;
            int mene = 0;
            for (int i = 0; i < list_ako_pole.Count; i++)
            {
                if (list_ako_pole[i] <= 50) //pro hodnoty mensi rovno 50
                {
                    vice = vice + 1;
                }
                else { mene = mene + 1; }
            }
            Console.WriteLine("PRvku mensich nez 50 je:" + mene + " Prvku vetsich nez 50 je:" + vice);

            Console.ReadKey();

            /*
            int[] policko = { 10, 9, 5, 4, 8 };
            for (int i = 0; i < policko.Length; i++)
            {
                Console.WriteLine("Aktualni prvek na pozici:" + i + " Hodnota tohoto prvku je:" + policko[i]);
            }
            */

            /*
            int cas = 75;
            var rnd = new Random();
            int pocet = 0;
            int hodnota;
            int goly=0;
            while (pocet != cas)
            {
                pocet++;
                hodnota = rnd.Next(0, 100);
                if (hodnota <= 5)
                {
                    goly = goly + 1;
                    Console.WriteLine("Domaci davaji gol! Celkem jich uz dali:" + goly);
                }
                else if (hodnota == 56)
                {
                    Console.WriteLine("Faul");
                }
            }
            */

            //3, ctvrtina golu, 8

            /*
            //Prace s polem, jeho deklarace, urceni velikosti, naplneni. 
            //Deklarace aray do promenne pole
            int[] pole;
            //Instanci intu do promenne pole
            pole = new int[10]; // bude to novy integer o velikosti 10
            //Random fci.
            var rand = new Random();
            for (int i = 0; i < 10; i++)
            { //Fce Random
                pole[i] = rand.Next(0,10);
                Console.WriteLine("Jsem v poli na miste:"+i+ " a hodnota je:"+pole[i]);
            }
            //Na poli cislo 5 je hodnota
            Console.WriteLine(pole[5]);
            */
            //Vycet nejmensiho prvku z posloupnosti a pocet kolikrat se ukaze
            /*
            List<int> pole = new List<int>();
            pole.Add(9);
            pole.Add(4);
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
            pole.Add(4);
            int nejmensi_prom = 0;
            int pocet = 0;
            for (int i = 0; i < pole.Count; i++)
            {
                if (i == 0 || nejmensi_prom == 0) //Pocitame s tim, ze hodnota ostatnich prvku musi byt >0
                {
                    nejmensi_prom = pole[i];
                }
                if (nejmensi_prom > pole[i])
                {
                    nejmensi_prom = pole[i];
                }
            Console.WriteLine("Aktualne nejmensi prvek je: " + nejmensi_prom);
            }
            Console.WriteLine("Nejmensi prvek je: " + nejmensi_prom);
            Console.ReadKey();
            */
            /*
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