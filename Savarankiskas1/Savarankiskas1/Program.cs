using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Mokinys petras = new Mokinys();
            petras.vardas = "Petras";
            petras.pavarde = "Petraitis";
            petras.kursoPradzia = new DateTime(2019, 12, 4);
            petras.kursoPabaiga = new DateTime(2020, 02, 25);

            Console.WriteLine("{0} {1}, Kurso Pradzia: {2}, Kurso pabaiga: {3}", petras.vardas, petras.pavarde, petras.kursoPradzia.ToShortDateString(), petras.kursoPabaiga.ToLongDateString());
            Console.ReadLine();
        }
    }
}
