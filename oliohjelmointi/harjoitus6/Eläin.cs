using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus6
{
    internal class Eläin
    {
        protected string nimi;
        protected int ika;
        protected static int eläintenMäärä = 0;

        public Eläin(string nimi, int ika)
        {
            this.nimi = nimi;
            this.ika = ika;
            eläintenMäärä++;
        }

        public virtual string Ääni()
        {
            return "generic animal sound";
        }

        public virtual string Tiedot()
        {
            return "Eläin: " + nimi + ", ikä: " + ika + " vuotta.";
        }

        public static int EläintenMäärä()
        {
            return eläintenMäärä;
        }
    }

    class Koira : Eläin
    {
        public Koira(string nimi, int ika) : base(nimi, ika) { }

        public override string Ääni()
        {
            return "hau hau";
        }

        public override string Tiedot()
        {
            return "Koira: " + nimi + ", ikä: " + ika + " vuotta.";
        }
    }

    class Kissa : Eläin
    {
        public Kissa(string nimi, int ika) : base(nimi, ika) { }

        public override string Ääni()
        {
            return "miau miau";
        }

        public override string Tiedot()
        {
            return "Kissa: " + nimi + ", ikä: " + ika + " vuotta.";
        }
    }
}
