using System;
using System.Collections.Generic;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listik = new List<int>();
            int a;

            do
            {
                Console.WriteLine("Zadej hodnotu - cele cislo, proste integer");
                a = Int32.Parse(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                else
                {
                    listik.Add(a);
                }
            }
            while (a != 0);

            for (int i = 0; i < listik.Count; i++)
            {
                Console.WriteLine("V listíku máme hodnotz:{0}", listik[i]);
            }


        }
    }
}
