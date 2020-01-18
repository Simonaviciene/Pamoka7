using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2
{
    struct BibliotekosKnyga
    {
        public int ID;
        public string Pavadinimas;
        public string SkaitytojoVardas;
        public DateTime PaemimoData;

        public BibliotekosKnyga(int id, string pavadinimas, string skaitytojoVardas, DateTime paemimoData)
        {
            ID = id;
            Pavadinimas = pavadinimas;
            SkaitytojoVardas = skaitytojoVardas;
            PaemimoData = paemimoData;
        }

        public int GrazintiKiekDienuPasSkaitytoja()
        {
            int rezult = DateTime.Now.Subtract(PaemimoData).Days;
            return rezult;
        }

    }
}
