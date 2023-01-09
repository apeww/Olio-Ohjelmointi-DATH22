using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliohjelmointi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            koira koira1 = new koira("Rekku", "Mopsi", 2); // luodaan uusi koira instanssi/olio

            koira1.HaeTiedot();

            koira Koira2 = new koira("Ali", "Bulldog", 5);

            Koira2.HaeTiedot();

            Koira2.Hauku();
            koira1.Hauku();
        }
    }
}
