using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H21
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            Random rnd = new Random();
            int[,] pole2U = new int[5, 5];
            for (int i = 0; i < pole2U.GetLength(0); i++)
            {
                for (int j = 0; j < pole2U.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        pole2U[i, j] = rnd.Next(5, 9);
                    }
                    else
                        pole2U[i, j] = rnd.Next(0, 4);
                    Console.Write(" " + pole2U[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************");

            Console.WriteLine("Jak velke chces mit pole - napis hodnotu dimenze");
            int value4U = Int32.Parse(Console.ReadLine());
            int[,] pole4U = new int[value4U, value4U / 2];
            for (int i = 0; i < pole4U.GetLength(0); i++)
            {
                for (int j = 0; j < pole4U.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                    {
                        pole4U[i, j] = rnd.Next(0, 9);
                    }
                    else
                    {
                        pole4U[i, j] = rnd.Next(0, 5);
                    }
                    //Console.Write(" " + pole4U[i, j] + " ");
                    Console.Write(" {0} ", pole4U[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************");
            /*
            int[] poleI1A = new int[] { 5, 4, 3, 5, 4, 6 };
            int[] poleI1B = new int[] { 2, 3, 5, 4, 1, 7 };
            int[] poleI1C = new int[] { 2, 3, 6, 4, 8, 9 };
            int[,] poleU12D = new int[,] { poleI1A, poleI1B, poleI1C };
            */
            int[,] poleU12D = { { 5, 4, 3, 5, 4, 6 }, { 2, 3, 5, 4, 1, 7 }, { 2, 3, 6, 4, 8, 9 } };
            int prumer = 0;
            for (int i = 0; i < poleU12D.GetLength(0); i++)
            {
                for (int j = 0; j < poleU12D.GetLength(1); j++)
                {
                    Console.Write(" " + poleU12D[i, j] + " ");
                    prumer += poleU12D[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Soucet je:{0}", prumer);
            prumer = prumer / poleU12D.Length;
            Console.WriteLine("Prumer je:{0}", prumer);
            Console.WriteLine("***************");

            string[,] poleU3 = { { "maly", "modry", "opel" }, { "velky", "cerveny", "bmw" }, { "obrovska", "oranzova", "skoda" }, { "stredni", "zluta", "audi" } };
            for (int i = 0; i < poleU3.GetLength(0); i++)
            {
                Console.WriteLine("Auto znacky:" + poleU3[i, 2] + " je velikostne {0} a jeho barva je: {1}", poleU3[i, 0], poleU3[i, 1]);
            }
            Console.WriteLine("***************");

            int[,] poleU5 = {  }
            
            Console.ReadKey();
        }
    }
}
