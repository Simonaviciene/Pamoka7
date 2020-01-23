using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSavarankiskas3
{
    class Program
    {
        public static bool ArSkaiciusLyginis(int parametras)
        {
            
            if (parametras % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        static void Main(string[] args)
        {
            int parametras = 11;
            bool isvada = ArSkaiciusLyginis(parametras);

            Console.WriteLine("{0}", isvada);
            Console.ReadLine();

        }
    }
}
