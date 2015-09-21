using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07.ApplicationObjets
{
    class Moteur
    {
        public Double Puissance { get; set; }
        public Double RegimeCourant { get; set; }

        public void Demarrer()
        {

        }

        public void ChangerRegime(Double valeur)
        {
            Console.Write("{0}m - ", valeur);
        }
    }
}
