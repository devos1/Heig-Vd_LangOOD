using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Création de la voiture à l'état initial");
            Voiture v = new Voiture(new Immobile());
            v.Etat.Deplacer(v);
            v.Etat.RetourGarage(v);
            v.Etat.Deplacer(v);         // Pas possible -> ok
            v.Etat.Arrêter(v);          // Pas possible -> ok
            v.Etat.CourseEssai(v);      // Ok car la voiture est en maintenance
            v.Etat.CourseEssai(v);      // Pas possible la voiture est en déplacement -> ok
        }
    }
}
