using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    class EnMaintenance : Etat
    {
        public EnMaintenance()
        {
            Console.WriteLine("La voiture est en maintenance!!");
        }

        public override void Arrêter(Voiture v)
        {
            // On ne peut arrêter la voiture vu qu'elle ne roule pas
        }

        public override void CourseEssai(Voiture v)
        {
            v.Etat = new EnDeplacement();
        }

        public override void Deplacer(Voiture v)
        {
            // On ne peut dépalcer la voiture vu qu'elle en maintenance
        }

        public override void RetourGarage(Voiture v)
        {
            throw new NotImplementedException();
        }
    }
}
