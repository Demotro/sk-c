using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {

            string cesta = @"C:\Users\krajc\source\repos\H22\ProCteni\soubor.txt";
            string radek;
            using (StreamReader sr = new StreamReader(cesta))
            {
                while ((radek = sr.ReadLine()) != null)
                {
                    if (radek.Contains("mys"))
                    {
                        Console.WriteLine(radek);
                    }
                }

            }
            /*
            string cesta = @"C:\Users\krajc\source\repos\H22\ProCteni\soubor.txt";
            string radek;
            List<string> obsahsouboru = new List<string>();
            string druhaMoznostObsahu = "";
            using (StreamReader sr = new StreamReader(cesta))
            {                
                while ((radek = sr.ReadLine()) != null)
                {
                    if (radek.Contains("ipsum"))
                    {
                        // int index = radek.IndexOf("ipsum");
                        // radek = radek.Substring(index, index+4) + "ipsum".ToUpper() + radek.Substring(index + 5);
                        
                        radek = Regex.Replace(radek, "ipsum", "IPSUM");
                        druhaMoznostObsahu += radek + "\n";
                        obsahsouboru.Add(radek);
                        Console.WriteLine(radek);
                    }
                }
            }*/
            /*
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < obsahsouboru.Count; i++)
            {
                Console.WriteLine(obsahsouboru[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(druhaMoznostObsahu);
            */
            /*
            string cesta = @"C:\Users\krajc\source\repos\H22\ProCteni\Konverzace.txt";
            string radek;
            using (StreamReader sr = new StreamReader(cesta))
            {
                while ((radek = sr.ReadLine()) != null)
                {
                    //Kdyz pise on
                    if (radek.Contains("Ja:"))
                    {
                        Console.WriteLine("Ja jsem ji laskyplne napsal:" + radek.Replace("Ja:", ""));
                    }
                    // nebo Kdyz pise ona
                    else if (radek.Contains("Ona:"))
                    {
                        Console.WriteLine("Ona z povysenosti odpovedela:" + radek.Replace("Ona:", ""));
                    }
                    // nebo kdyz pise facebook
                    else if (radek.Contains("Facebook:"))
                    {
                        Console.WriteLine("Byl jste zablokovan.");
                        Console.WriteLine(radek.Replace("Facebook:", "").Trim());
                    }
                }               
            }
            */
            /*
            string str = "....Ahoj. jak se mas!!!§§§";
            char[] charyOdstran = { '§', '.' };
            string cistystr = str.Trim(charyOdstran);
            string jinakcistystring = str.Replace(".", "");            
            Console.WriteLine(cistystr);
            Console.WriteLine(jinakcistystring);
            */
            string[] strDel = { "se", "jak" };
            string str = "Ahoj jak se mas!";
            for (int i = 0; i < strDel.Length; i++)
            {
                str = str.Replace(strDel[i], "");
            }
            Console.WriteLine(str);

        }
    }
}