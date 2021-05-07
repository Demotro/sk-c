using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            //2d pole pro int
            int[,] pole = new int[6, 5];
            //int[,,] pole2 = new int[6, 5, 5];
            double[,] poledoublu = new double[5, 5];
            string[,] polestringu = new string[10, 10];

            // Vytvorte pole stringu o velikosti, kterou zada uzivatel - pro radky, pro sloupce
            // Naplnte kazdy sloupec hodnotou "Ahoj" for cyklem
            // Pak vypiste cele pole
            /*
            Console.WriteLine("Zadej pocet radku stringu");
            int radky = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet sloupecku stringu");
            int sloupce = Int32.Parse(Console.ReadLine());
            string[,] stringpole = new string[radky, sloupce];
            for (int i = 0; i < stringpole.GetLength(0); i++)
            {
                for (int j = 0; j < stringpole.GetLength(1); j++)
                {
                    stringpole[i, j] = "Ahoj";
                }
            }
            for (int i = 0; i < stringpole.GetLength(0); i++)
            {
                for (int j = 0; j < stringpole.GetLength(1); j++)
                {
                    Console.Write(" {0} ", stringpole[i, j]);
                    //Console.Write(stringpole[i, j]);
                    //Console.Write(" " + stringpole[i, j] + " ");
                }
                //Console.WriteLine("");
                Console.Write("\n");
            }
            */


            // Vytvorte pole stringu o velikosti, kterou zada uzivatel - pro radky, pro sloupce
            // Whilem naplnte vsechny mista v poli prostrednictvim vstupu z konzole
            // doporucuji velikost 2x2
            /*
            Console.WriteLine("Zadej pocet radku stringu");
            int radky1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet sloupecku stringu");
            int sloupce1 = Int32.Parse(Console.ReadLine());
            string[,] stringpole1 = new string[radky1, sloupce1];
            int celkx = stringpole1.GetLength(0);
            int celky = stringpole1.GetLength(1);
            int pozicex = 0;
            int pozicey = 0;
            while (celkx>pozicex)
            {               
                Console.WriteLine("Napis hodnotu do pole");
                stringpole1[pozicex, pozicey] = Console.ReadLine();
                if (pozicey < celky-1)
                {
                    pozicey++;
                }
                else {
                    pozicex++;
                    pozicey = 0;
                }
            
            }
            for (int i = 0; i < celkx; i++)
            {
                for (int j = 0; j < celky; j++)
                {
                    Console.Write(" {0} ", stringpole1[i, j]);
                    //Console.Write(stringpole[i, j]);
                    //Console.Write(" " + stringpole[i, j] + " ");
                }
                //Console.WriteLine("");
                Console.Write("\n");
            }
            */
            // A pole bude pro inty a naplnte jej intama
            /*
            Console.WriteLine("Zadej pocet radku stringu");
            int radky2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet sloupecku stringu");
            int sloupce2 = Int32.Parse(Console.ReadLine());
            string[,] stringpole2 = new string[radky2, sloupce2];
            for (int i = 0; i < stringpole2.GetLength(0); i++)
            {
                for (int j = 0; j < sloupce2; j++)
                {
                    Console.WriteLine("Napis stringovou hodnotu na pozici - radek:{0} a sloupec:{1}", i+1, j+1);
                    stringpole2[i, j] = Console.ReadLine();               
                }            
            }
            for (int i = 0; i < radky2; i++)
            {
                for (int j = 0; j < stringpole2.GetLength(1); j++)
                {
                    Console.Write(" {0} ", stringpole2[i, j]);
                }
                Console.Write("\n");
            }*/
            /*
            Console.WriteLine("Zadej pocet radku int 2D pole");
            int radky2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet sloupecku int 2D pole");
            int sloupce2 = Int32.Parse(Console.ReadLine());
            int[,] stringpole2 = new int[radky2, sloupce2];
            for (int i = 0; i < stringpole2.GetLength(0); i++)
            {
                for (int j = 0; j < sloupce2; j++)
                {
                    Console.WriteLine("Napis intovou hodnotu na pozici - radek:{0} a sloupec:{1}", i + 1, j + 1);
                    stringpole2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < radky2; i++)
            {
                for (int j = 0; j < stringpole2.GetLength(1); j++)
                {
                    Console.Write(" {0} ", stringpole2[i, j]);
                }
                Console.Write("\n");
            }*/

            // Vytvorte pole intu o velikosti, kterou zada uzivatel - pro radky, pro sloupce
            // Naplnte kazdy lichy radek nahodnymi hodnotami (6:9)
            // Naplnte kazdy sudy radek nahodnymi hodnotami (0:5)
            Console.WriteLine("Zadej pocet radku int 2D pole");
            int radky2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet sloupecku int 2D pole");
            int sloupce2 = Int32.Parse(Console.ReadLine());
            int[,] intpole2 = new int[radky2, sloupce2];
            Random rnd = new Random();
            for (int i = 0; i < radky2; i++)
            {
                for (int j = 0; j < sloupce2; j++)
                {
                    if (i % 2 == 0)
                    {
                        intpole2[i, j] = rnd.Next(0, 5);
                    }
                    else
                    {
                        intpole2[i, j] = rnd.Next(6, 9);
                    }
                }
            }

            for (int i = 0; i < radky2; i++)
            {
                for (int j = 0; j < sloupce2; j++)
                {
                    Console.Write(" {0} ", intpole2[i, j]);
                }
                Console.Write("\n");
            }


            Console.ReadKey();
        }
    }
}
