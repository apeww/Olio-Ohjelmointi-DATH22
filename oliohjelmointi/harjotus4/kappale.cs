using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjotus4
{
    internal class kappale
    {
        public string nimi;
        public string kesto; //esim 3:50

        //konstruktori jolla pakoteetaan asettamaan oliolle arvot luontivaiheessa
        public kappale(string nimi, string kesto)
        {
            this.nimi = nimi;
            this.kesto = kesto;
        }

        //Tulostettaan kappaleen tiedot
        public void TulostaTiedot()
        {
            Console.WriteLine("--- Nimi: " + nimi + " - " + kesto);
        }



    }
}
