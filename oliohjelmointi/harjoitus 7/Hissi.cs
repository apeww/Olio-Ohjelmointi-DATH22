using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_7
{
    internal class Hissi
    {
        private int kerros;
        public int Kerros
        {
            get { return kerros; }
            set
            {
                if (value >= 1 && value <= 6)
                {
                    kerros = value;
                    Console.WriteLine("Hissi on nyt kerroksessa " + kerros);
                }
                else
                {
                    Console.WriteLine("Virheellinen kerros, anna kerros 1-6 väliltä.");
                }
            }
        }
        public void MeneKerrokseen()
        {
            while (true)
            {
                Console.WriteLine("Mihin kerrokseen haluat mennä? (1-6)");
                int kerros = int.Parse(Console.ReadLine());
                Kerros = kerros;
            }
        }
    }
}
