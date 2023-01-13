using harjoitus_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Opiskelijat> HenkilöSanakirja = new Dictionary<string, Opiskelijat>();

            Opiskelijat Andrew = new Opiskelijat("Andrew", "Tate", "DATH22", "031106-1245");
            Opiskelijat Aapo = new Opiskelijat("Aapo", "Lehokas", "DATH22", "120346-1345");



            try
            {
                HenkilöSanakirja.Add(Andrew.Henkilötunnus, Andrew);
                HenkilöSanakirja.Add(Aapo.Henkilötunnus, Aapo);
                HenkilöSanakirja.Add(Aapo.Henkilötunnus, Aapo);


                Console.WriteLine("Henkilöita Sanakirjassa: " + HenkilöSanakirja.Count);

                HenkilöSanakirja.Remove("031106-1245");

                Console.WriteLine("Henkilöitä Sanakirjassa: " + HenkilöSanakirja.Count);

            }
            catch (Exception e)
            {
                Console.WriteLine("VIRHE ERROR KOODI: " + e.Message);
            }

        }
    }
}
