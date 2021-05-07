using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarace 1D pole
            /*
            int[] pole = new int[5];
             */
            //Deklarace 2D pole
            int[,] pole2D = new int[10, 10];
            Console.WriteLine(pole2D.Length); // Celk pocet prvku
            Console.WriteLine(pole2D.GetLength(0)); // Nulta dimenze pro pocet radku
            Console.WriteLine(pole2D.GetLength(1)); // Prvni dimenze pro pocet sloupcu
            Random rnd = new Random();
            for (int i = 0; i < pole2D.GetLength(0); i++)
            {
                for (int j = 0; j < pole2D.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        pole2D[i, j] = 1;
                    }
                    else
                    {
                        pole2D[i, j] = rnd.Next(10, 20);
                    }
                }
            }

            pole2D[0, 2] = 0;
            pole2D[2, 6] = 0;

            for (int i = 0; i < pole2D.GetLength(0); i++)
            {
                for (int j = 0; j < pole2D.GetLength(1); j++)
                {
                    if (pole2D[i, j] < 10)
                    {
                        Console.Write(" " + pole2D[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(" " + pole2D[i, j] + " ");
                    }
                }
                Console.WriteLine("");
            }


            /*
            int[,] pole2d = new int[5, 5];
            Console.WriteLine(pole2d.Length);
            //Console.ReadKey();
            for (int i = 0; i < pole2d.GetLength(0); i++)
            {
                for (int j = 0; j < pole2d.GetLength(1); j++)
                {
                    pole2d[i, j] = j;
                }
            }
            for (int i = 0; i < pole2d.GetLength(0); i++)
            {
                for (int j = 0; j < pole2d.GetLength(1); j++)
                {
                    Console.Write(pole2d[i, j]);
                }
                Console.WriteLine("");
            }
            */
            Console.ReadKey();

            //Zadani 3
            /*
            double[] pole = new double[5];
            int pomoc = 0;
            while (pomoc < pole.Length)
            {
                Console.WriteLine("Napis hodnotu");
                pole[pomoc] = Double.Parse(Console.ReadLine());
                pomoc++;
            }
            double soucet=0;
            for (int i = 0; i < pole.Length; i++)
            {
                soucet += pole[i];
            }
            Console.WriteLine("Soucet vsech prvku je roven:{0}", soucet);
            Console.WriteLine("Prumer prvku pole je roven:{0}", soucet / pole.Length);
            */
        }
    }
}
