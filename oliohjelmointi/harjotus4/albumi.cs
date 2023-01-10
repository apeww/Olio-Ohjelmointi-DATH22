using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjotus4
{
    internal class albumi
    {
        public string artisti;
        public string genre;
        public string albuminNimi;

        private List<kappale> kappaleet = new List<kappale>();

        public albumi(string artisti, string genre, string albuminNimi)
        {
            this.artisti = artisti;
            this.genre = genre;
            this.albuminNimi = albuminNimi;
        }

        //Metodi jolla lisätään kappaleet listaan uusi kappale
        public void LisääKappale(kappale uusikappale)
        {
            kappaleet.Add(uusikappale);
        }

        public void TulostaTiedot()
        {
            Console.WriteLine();
            Console.WriteLine("Albumi");
            Console.WriteLine(" -Artisti");
            Console.WriteLine(" -Albumin Nimi: " + albuminNimi);
            Console.WriteLine(" -Genre: " + genre);
            Console.WriteLine("Songs:");

            foreach (kappale kappale in kappaleet)
            {
                kappale.TulostaTiedot();
            }
        }

	}
}

    

