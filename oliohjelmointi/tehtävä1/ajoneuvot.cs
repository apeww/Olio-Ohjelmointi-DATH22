using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä1
{
    internal class ajoneuvot
    {
        public string Nimi;
        public int Nopeus;
        public int Renkaat;

        public ajoneuvot(string nimi, int nopeus, int renkaat)
        {
            Nimi = nimi;
            Nopeus = nopeus;
            Renkaat = renkaat;
        }

        public void TulostaData()
        {
            Console.WriteLine("Auton nimi on: " + Nimi);
            Console.WriteLine("Auton Nopeus on. "+ Nopeus);
            Console.WriteLine("Auton renkaiden määrä on: " + Renkaat);
        }


    }
}
