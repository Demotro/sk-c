using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            /*string str1;
            string str2;
            str1 = "Dneska je venku";
            str2 = "opravdu hodne snehu.";
            string str3 = str1 +" "+ str2;
            //Console.WriteLine("{0}",str3);
            //Console.WriteLine(str1 + " " + str2);
            //Console.WriteLine(str3);
            //Console.WriteLine("{0} {1}", str1, str2);
            */

            /*
            string str1 = "5";
            string str2 = "10";
            Console.WriteLine(str1 + str2);
            Console.ReadKey();
            */
            /*
            string str1 = "Napiste delku strany A";
            string str2 = "Napiste delku strany B";
            string str3 = "Obvod obdelniku je roven:{0}";
            Console.WriteLine("Vitejte v programu pro vypocet obvodu obdelniku");
            double a,b,vysledek;
            string check;
            List<double> vysledky = new List<double>();
            while (true)
            {
                Console.WriteLine(str1);
                a = Double.Parse(Console.ReadLine());
                Console.WriteLine(str2);
                b = Double.Parse(Console.ReadLine());
                vysledek = 2 * (a + b);
                vysledky.Add(vysledek);
                Console.WriteLine(str3,vysledek);
                Console.WriteLine("Pokud chces skoncit, zadej stop");
                check = Console.ReadLine();
                if (check == "stop")
                {
                    break;
                }
            }
            for (int i = 0; i < vysledky.Count; i++)
            {
                if (vysledky[i] > 100)
                {
                    Console.WriteLine("Pravdepodobne spatne zadane hodnoty, vysledek byl:{0}", vysledky[i]);
                }
                else
                {
                    Console.WriteLine("Vysledek cislo: {0}. byl hodnoty: {1}", i + 1, vysledky[i]);
                }
            }
            */
            /*
            Program pro statisticky vypocet z hodnot srdecniho tepu.
            Program nacita hodnoty tepu v jednotkach bpm
            My chceme kazdych deset hodnot zprumerovat a na zaklade vysledku dat pacientovi lek (pole)
            Pokud je tep mensi nez 60, tak mu dame lek cislo1 a vypiseme to 
            Pokud je tep vetsi nez 100, tak mu dame lek cislo2 a vypiseme to 
            Pokud je tep mezi (60;100), tak je to OK a chceme dalsi hodnoty mereni
            Na konci po zadani "stop" vypiseme vsechny merene hodnoty a pocty danych leku, ktere jsme pacientovi aplikovali.
             */
            Console.WriteLine("Vitejte v programu pro statisticke vypocty z srdecniho tepu");
            string check;
            int pocet = 0;
            int[] pole = new int[10];
            List<int> prumery = new List<int>();
            int lek1 = 0;
            int lek2 = 0;
            int prumer = 0;
            while (true)
            {
                Console.WriteLine("Zadejte hodnotu tepu");
                pole[pocet] = Int32.Parse(Console.ReadLine());
                pocet++;
                if (pocet == 11)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        prumer += pole[i];
                    }
                    prumer = prumer / 10;
                    prumery.Add(prumer);
                    if (prumer < 60)
                    {
                        Console.WriteLine("Nizky tep, hodnota je{0}, davame lek cislo 1", prumer);
                        lek1++;
                    }
                    else if (prumer > 100)
                    {
                        Console.WriteLine("Vysoky tep, hodnota je{0}, davame lek cislo 2", prumer);
                        lek2++;
                    }
                    else
                    {
                        Console.WriteLine("Hodnota tepu je{0}", prumer);
                    }
                    pocet = 0;
                    prumer = 0;

                    Console.WriteLine("Pokud chces skoncit, zadej stop");
                    check = Console.ReadLine();
                    if (check == "stop")
                    {
                        break;
                    }
                }
                //Cast pro ukonceni                
            }
            for (int i = 0; i < prumery.Count; i++)
            {
                Console.WriteLine("{0}. prumer byl hodnoty:{1}", i + 1, prumery[i]);
            }
            Console.WriteLine("Pacientovi byl lek1 podan:{0}x, Lek2 mu byl podan:{1}x", lek1, lek2);


            Console.ReadKey();



        }
    }
}
