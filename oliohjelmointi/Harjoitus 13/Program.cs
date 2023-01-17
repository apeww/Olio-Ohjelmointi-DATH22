using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Smliiga> PelaajaSanakirja = new Dictionary<string, Smliiga>();

            Smliiga Andrew = new Smliiga("Andrew", "Tate", 69);
            Smliiga Aapo = new Smliiga("Aapo", "Lehokas", 420);



            try
            {
                Smliiga.Add(Andrew.PelaajaNumero, Andrew);
                Smliiga.Add(Aapo.PelaajaNumero, Aapo);



                Console.WriteLine("Henkilöita Joukkueessa: " + Smliiga.Count);

                Smliiga.Remove("420");

                Console.WriteLine("Henkilöitä Joukkueessa: " + Smliiga.Count);

            }
            catch (Exception e)
            {
                Console.WriteLine("VIRHE ERROR KOODI: " + e.Message);
            }
        }
    }
}
