using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koira koira = new Koira("Musti", 5);
            Kissa kissa = new Kissa("Timo", 3);

            Console.WriteLine("Luotujen eläinten määrä: " + Eläin.EläintenMäärä());
            Console.WriteLine("Ensimmäinen eläin: " + koira.Tiedot() + " Ääni: " + koira.Ääni());
            Console.WriteLine("Toinen eläin: " + kissa.Tiedot() + " Ääni: " + kissa.Ääni());

            Console.ReadLine();
        }
    }
}
