using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjotus3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kiuas kiuas1 = new kiuas(false, 100, 50);

            kiuas1.TulostData();
            kiuas1.MuokkaaLämpötilaa(10);
            kiuas1.MuokkaaKosteutta(10);
            kiuas1.OnkoKiuasPäällä();
        }
    }
}
