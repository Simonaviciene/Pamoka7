using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankikas3
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Staciakampis staciakampis1 = new Staciakampis(1, 5, 4);
            Staciakampis staciakampis2 = new Staciakampis(2, 6, 6);
            Staciakampis staciakampis3 = new Staciakampis(3, 3, 2);

            staciakampis1.ApskaiciuotiStaciakampioPlota();
            staciakampis2.ApskaiciuotiStaciakampioPlota();
            staciakampis3.ApskaiciuotiStaciakampioPlota();

            Console.ReadLine();
        }
    }
}
