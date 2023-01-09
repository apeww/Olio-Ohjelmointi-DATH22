using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace harjotus3
{
    internal class kiuas
    {
        public bool OnkoPäällä = false;
        public int lämpötila;
        public int kosteus;

        public kiuas (bool onkoPäällä, int lämpötila, int kosteus)
        {
            OnkoPäällä = onkoPäällä;
            this.lämpötila = lämpötila;
            this.kosteus = kosteus;
        }
        public void TulostData()
        {
            Console.WriteLine("Onko kiuas päällä: " + OnkoPäällä);
            Console.WriteLine("Kiukaan Lämpötila: " + lämpötila);
            Console.WriteLine("Kosteus: " + kosteus);
        }
        public void MuokkaaLämpötilaa(int määrä)
        {
            lämpötila += määrä;
        }
        public void MuokkaaKosteutta(int määrä)
        {
            kosteus += määrä;
        }

        public void OnkoKiuasPäällä()
        {
            if (OnkoPäällä)
            {
                Console.WriteLine("kiuas on päällä");
            }
            else
            {
                Console.WriteLine("Kiuas ei ole päällä");
            }
        }
    }
}
