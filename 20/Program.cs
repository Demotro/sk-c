using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> listlistu = new List<List<int>>();
            List<int> listintu;
            // Naplnte list desiti nahodnyma hodnotama. Do listu pridavate metodou   .Add()
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                listintu = new List<int>();
                for (int j = 0; j < 5; j++)
                {
                    listintu.Add(rnd.Next(0, 9));
                    Console.Write(listintu[j]);
                }
                Console.WriteLine();
                listlistu.Add(listintu);
            }

            Console.WriteLine();
            Console.WriteLine();


            //Console.WriteLine(listlistu[0].Count);  
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(listlistu[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var o in listlistu)
            {
                for (int j = 0; j < o.Count; j++)
                {
                    Console.Write(o[j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var o in listlistu)
            {
                foreach (var k in o)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }

            /*for (int i = 0; i < 10; i++)
            {
                listintu.Add(rnd.Next(0, 9));
                Console.WriteLine(listintu[i]);
            }*
            
            /*
            listlistu.Add(listintu);
            Console.WriteLine(listlistu.Count); // 
            Console.WriteLine(listlistu[0].Count); // 
            Console.WriteLine(listlistu[0][7]);
            */

            Console.ReadKey();
        }
    }
}