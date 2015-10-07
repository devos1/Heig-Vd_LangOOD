using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    class EnDeplacement : Etat
    {
        public EnDeplacement()
        {
            Console.WriteLine("La voiture est en déplacement");
        }

        public override void Arrêter(Voiture v)
        {
            v.Etat = new Immobile();
        }

        public override void CourseEssai(Voiture v)
        {
            // Pas applicable
        }

        public override void Deplacer(Voiture v)
        {
            // Rien à faire, la voiture est déjà en déplacement
        }

        public override void RetourGarage(Voiture v)
        {
            Console.WriteLine("La voiture retourne au garage");
            v.Etat = new EnMaintenance();
        }
    }
}
