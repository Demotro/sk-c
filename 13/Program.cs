using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int hodnota = 100;
            int puvodnihodnota = hodnota;
            int podminka = 3;
            int podminka1 = 20;
            int podminka2 = 40;
            int odecet1 = 7;
            int odecet2 = 5;
            int value = 0;
            for (int i = 0; i < podminka; i++)
            {
                hodnota = puvodnihodnota;
                while (hodnota > podminka1)
                {
                    //Console.WriteLine("*");
                    value++;
                    if (hodnota >= podminka2)
                    {
                        hodnota = hodnota - odecet1;
                    }
                    else
                    {
                        hodnota = hodnota - odecet2;
                    }
                }
            }

            Console.WriteLine("Prvni:" + value);

            hodnota = 100;
            podminka = 5;
            podminka1 = 0;
            podminka2 = 3;
            odecet1 = 10;
            odecet2 = 8;
            value = 0;

            while (hodnota > podminka) //
            {
                if (hodnota > podminka1) //
                {
                    for (int i = 0; i < podminka2; i++)
                    {
                        // Console.WriteLine("*");
                        value++;
                    }

                    hodnota = hodnota - odecet1;
                }
                else
                {
                    //Console.WriteLine("*");
                    hodnota = hodnota - odecet2;
                    value++;
                }
            }
            Console.WriteLine("Druha: " + value);

            podminka = 6;
            podminka1 = 4;
            podminka2 = 2;
            value = 0;
            for (int i = 0; i < podminka; i++)
            {
                if (i >= podminka1)
                {
                    for (int j = 0; j < podminka2; j++)
                    {
                        // Console.WriteLine("*");
                        value++;
                    }
                }
                //Console.WriteLine("*");
                value++;
            }
            Console.WriteLine("Treti: " + value);
            Console.ReadLine();


            /*
            Console.WriteLine(value); 
            int value = 0;
            int for0 = 0;
            int for1 = 0;
            int for2 = 0;
            int for3 = 0;
            for (int i = 0; i <= 2; i++)//
            {
                 for0 = 0;
                 for1 = 0;
                 for2 = 0;
                 for3 = 0;
                Console.WriteLine("*");
                value++;
                for0++;
                for (int j = 0; j < 2; j++)//
                {
                    Console.WriteLine("*");
                    value++;
                    for1++;
                    for (int x = 0; x < 2; x++)//
                    {
                        Console.WriteLine("*");
                        value++;
                        for2++;
                        for (int y = 0; y < 2; y++)//
                        {
                            Console.WriteLine("*");
                            value++;
                            for3++;
                        }
                    }
                }                 
            }
            Console.WriteLine(value);
            Console.WriteLine("For0:"+for0);
            Console.WriteLine("For1:"+for1);
            Console.WriteLine("For2:"+for2);
            Console.WriteLine("For3:"+for3);
            Console.ReadLine();*/
            /* int hodnota = 5;
             int value = 0;
             do
             {
                 hodnota-=2;
                 Console.WriteLine("*");
             } while (hodnota >= 0);
             Console.WriteLine(value);
             Console.ReadLine();*/
        }
    }
}
}
