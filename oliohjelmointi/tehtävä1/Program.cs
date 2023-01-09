using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ajoneuvot ajoneuvot1 = new ajoneuvot("Bugatti", 400, 4);

            ajoneuvot1.TulostaData();
        }
    }
}
