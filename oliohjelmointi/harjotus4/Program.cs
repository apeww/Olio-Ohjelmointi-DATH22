using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjotus4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StaattinenLuokka.StaattinenMetodi();

            float kilometriArvo = 143.50f;
            float mailiArvo = StaattinenLuokka.KmToMiles(kilometriArvo + "km on mailesissa" + mailiArvo);
            //albumi albumi = new albumi("Evolve", "Imagine Dragons", "Poprock");

            //albumi.LisääKappale(new kappale("Next to me", "3:50"));
            //albumi.LisääKappale(new kappale("I Dont know why", "3:10"));
            //albumi.LisääKappale(new kappale("What ever it takes", "3:20"));
            //albumi.LisääKappale(new kappale("JOOOOOH", "3:10"));
            //albumi.LisääKappale(new kappale("Thunder", "3:50"));

            //albumi.TulostaTiedot();
        }
    }
}
