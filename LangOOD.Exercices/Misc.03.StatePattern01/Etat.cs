using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    abstract class Etat
    {
        public abstract void Deplacer(Voiture v);
        public abstract void Arrêter(Voiture v);
        public abstract void RetourGarage(Voiture v);
        public abstract void CourseEssai(Voiture v);
    }
}
