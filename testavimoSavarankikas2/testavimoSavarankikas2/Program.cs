using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testavimoSavarankikas2
{
     public class Program
    {
        public static string ApverstiEilute(string eilute)
        {
            string rezultatas = "";
            for (int i = 0; i <= eilute.Length-1; i++)
            {
                rezultatas = eilute[i] + rezultatas;
            }
           
            return rezultatas;
        }
        static void Main(string[] args)
        {
            string eilute = "abcde";
            Console.WriteLine("{0}", eilute);
            string apverstas = ApverstiEilute(eilute);
            Console.WriteLine("{0}", apverstas);
            
            Console.ReadLine();

        }
    }
}
