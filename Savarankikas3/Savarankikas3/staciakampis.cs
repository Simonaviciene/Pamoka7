using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankikas3
{
    struct Staciakampis
    {
        public int Staciakampiai;
        public double Ilgis;
        public double Plotis;
        

        public Staciakampis(int staciakampis, double ilgis, double plotis)
        {
            Staciakampiai = staciakampis;
            Ilgis = ilgis;
            Plotis = plotis;

        }
        public void ApskaiciuotiStaciakampioPlota()
        {
            Console.WriteLine("Staciakampio {0} plotas yra: {1} * {2}", Staciakampis, Ilgis, Plotis);
        }
    }
}
class Class1
    {
    }

