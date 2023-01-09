using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjotus2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            opiskelija Opiskelija1 = new opiskelija("Aapo", "DATH22", 100);

            Opiskelija1.TulostaData();
            Opiskelija1.MuokkaaOpintoPisteitä(5);
            Opiskelija1.TulostaData();


        }
    }
}
