using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavarankikasAdvansed1
{
    struct Studentas
    {
        public int PirmasTrimestras;
        public int AntrasTrimestras;
        public int TreciasTrimestras;

        public Studentas(int pirmasTr, int antrTr, int trecTr)
        {
            PirmasTrimestras = pirmasTr;
            AntrasTrimestras = antrTr;
            TreciasTrimestras = trecTr;
        }
        public void IsvestiPirmoTrimestroVidurki(List<int> PirmasTrimestras)
        {
            double rezult = 0;
            foreach (var item in PirmasTrimestras)
            {
               rezult += item;
            }
            Console.WriteLine("Pirmas trimestro vidurkis: {0:0.00}", (rezult / PirmasTrimestras.Count));

        }



    }
    class Class1
    {
    }
}
