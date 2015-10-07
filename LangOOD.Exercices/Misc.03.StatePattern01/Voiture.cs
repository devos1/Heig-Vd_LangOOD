using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    class Voiture
    {
        public Etat Etat { get; set; }

        public Voiture(Etat etat)
        {
            Etat = etat;        
        }


    }
}
