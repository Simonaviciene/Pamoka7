using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankikas4
{
    struct Studentas
    {
        public int StudentoID;
        public bool IskaitosRezultatas;

        public Studentas(int id, bool rezult)
        {
            StudentoID = id;
            IskaitosRezultatas = rezult;

        public override string ToString()
        {
            return("ID: " + StudentoID + "   Iskaitos Rezultatas: " + IskaitosRezultatas);
        }
        
        }
    }
}   
