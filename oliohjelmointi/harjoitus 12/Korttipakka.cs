using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_12
{
    internal class Korttipakka
    {
        public List<string> Kortit = new List<string>();

        public Korttipakka()
        {

            LuoKortitListaan();
        }

        private void LuoKortitListaan()
        {
            for (int i = 0; i < 14; i++)
            {
                Kortit.Add("Pata - " + i);
                Kortit.Add("Hertta - " + i);
                Kortit.Add("Ruutu - " + i);
                Kortit.Add("Risti -" + i);
            }

        }

        private  Random rng = new Random();

        public void (List<string> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }
}
    


