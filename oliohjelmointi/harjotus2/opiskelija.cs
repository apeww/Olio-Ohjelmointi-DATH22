using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjotus2
{
    internal class opiskelija
    {
        public string Nimi;
        public string OpiskelijaID;
        public int Opintopisteet;

        public opiskelija(string nimi, string opiskelijaID, int opintopisteet)
        {
            Nimi = nimi;
            OpiskelijaID = opiskelijaID;
            Opintopisteet = opintopisteet;
        }
        public void TulostaData()
        {
            Console.WriteLine("opiskelijan nimi on: " + Nimi);
            Console.WriteLine("Opiskelijan ID on: " + OpiskelijaID);
            Console.WriteLine("Opiskleijan opinto pisteet on: " + Opintopisteet);
        }
        public void MuokkaaOpintoPisteitä(int määrä)
        {
            Opintopisteet += määrä;
        }
    }
}
