using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            BibliotekosKnyga pasaka = new BibliotekosKnyga(1234, "Pasakecia", "Jonas", new DateTime(2019, 12, 4));

            int rezult = pasaka.GrazintiKiekDienuPasSkaitytoja();

            Console.WriteLine(pasaka.Pavadinimas);
            Console.WriteLine(pasaka.SkaitytojoVardas);
            Console.WriteLine(rezult);
            Console.ReadLine();
        }
    }
}
