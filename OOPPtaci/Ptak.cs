using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPtaci
{
    class Ptak
    {
        protected int hlad;
        protected int vaha;

        public Ptak(int hlad, int vaha)
        {
            this.hlad = hlad;
            this.vaha = vaha;
        }

        public void Snez(int jidlo)
        {
            vaha += jidlo;
            hlad -= jidlo;
        }
        public void VypisPtaka()
        {
            Console.WriteLine("Jsem pták s váhou {0} a hladem {1}.", vaha,hlad);
            ///return ($"Jsem pták s váhou {vaha} a hladem {hlad}."); - Pokud by metoda byla string
        }
        

    }
}
