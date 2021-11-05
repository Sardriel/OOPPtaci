using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPtaci
{
    class AngryPtak:Ptak
    {
        public int vztek;
        public AngryPtak(int hlad, int vaha, int vztek): base(hlad, vaha)
        {
            this.vztek = vztek;
        }
        public void VypisAngryPtaka()
        {
            Console.WriteLine("Jsem angry-pták s váhou {0} a hladem {1}, míra mého vzteku je {2}.", vaha,hlad,vztek);
            ///return ($"Jsem angry-pták s váhou {vaha} a hladem {hlad}, míra mého vzteku je {vztek}."); - Pokud by metoda byla string
        }

        public void Provokuj(int miraProvokace)
        { 
            if (hlad > 0)
            {
                vztek += (miraProvokace * 2);
            } 
            else 
            {
                vztek += miraProvokace;
            }

            
        }
    }
}
