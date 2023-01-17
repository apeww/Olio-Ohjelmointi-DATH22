using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_13
{
    internal class Smliiga
    {
        public string Etunimi;
        public string Sukunimi;
        public int PelaajaNumero;

        private Dictionary Pelaajat(string Etunimi, string Sukunimi, int PelaajaNumero)
        {
            Etunimi = Etunimi;
            Sukunimi = Sukunimi;
            PelaajaNumero = PelaajaNumero;
               
        }

        public Pelaaja Haepelaaja(int)
        {
            Console.WriteLine("Pelaaja: " + Etunimi);
        }
    }
}
