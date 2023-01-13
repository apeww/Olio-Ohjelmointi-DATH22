using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_10
{
    internal class Opiskelijat
    {
        public string Etunimi;
        public string Sukunimi;
        public string Ryhmätunnus;
        public string Henkilötunnus;

        public Opiskelijat(string etunimi, string sukunimi, string ryhmätunnus, string henkilötunnus)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Ryhmätunnus = ryhmätunnus;
            Henkilötunnus = henkilötunnus;
        }
    }
}
