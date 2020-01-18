using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
   public class Program
    {
        
        public static decimal Tax(decimal pajamos)
        {
            decimal rezult = 0;
            if (pajamos <= 40000)
            {
                rezult = pajamos * 0.05m;

            }
            else if (pajamos > 40000 && pajamos <= 100000)
            {
                rezult = pajamos * 0.15m;
            }
            else
            {
                rezult = pajamos * 0.25m;
            }
            return rezult;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Tax(1000));
            Console.ReadLine();
        }
    }
}
