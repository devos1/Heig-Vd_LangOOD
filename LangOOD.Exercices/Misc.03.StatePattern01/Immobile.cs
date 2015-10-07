using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    class Immobile : Etat
    {
        public Immobile()
        {
            Console.WriteLine("La voiture est immobile");
        }

        public override void Arrêter(Voiture v)
        {
            // Rien à faire, la voiture est déjà arrêtée
        }

        public override void CourseEssai(Voiture v)
        {
            throw new NotImplementedException();
        }

        public override void Deplacer(Voiture v)
        {
            v.Etat = new EnDeplacement();
        }

        public override void RetourGarage(Voiture v)
        {
            throw new NotImplementedException();
        }
    }
}
