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
            try
            {

                Voiture v = new Voiture(enEtatVoiture.Immobile);
                Console.WriteLine("La Voiture est dans l'état {0}", v.Etat);

                v.Deplacer();
                Console.WriteLine("La Voiture est dans l'état {0}", v.Etat);

                v.Arreter();
                Console.WriteLine("La Voiture est dans l'état {0}", v.Etat);

                v.FaireService();
                Console.WriteLine("La Voiture est dans l'état {0}", v.Etat);

                v.EffectuerCourseEssai();
                Console.WriteLine("La Voiture est dans l'état {0}", v.Etat);

                v.RetournerauGarage();
                Console.WriteLine("La Voiture est dans l'état {0}", v.Etat);

                v.RetourService();
                Console.WriteLine("La Voiture est dans l'état {0}", v.Etat);

                v.MettreEnVente();
                Console.WriteLine("La Voiture est dans l'état {0}", v.Etat);

                v.Vendre();
                Console.WriteLine("La Voiture est dans l'état {0}", v.Etat);
                v.Vendre();
                Console.WriteLine("La Voiture est dans l'état {0}", v.Etat);

            }
            catch (TransitionEtatImpossibleException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
