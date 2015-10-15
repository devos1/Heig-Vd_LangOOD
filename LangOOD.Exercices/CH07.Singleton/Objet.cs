using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07.Singleton
{
    class Objet
    {
        // QUESTION : Faudrai-t'il mettre un lock comme dans MVA pour éviter que 2 puissent entre en même temps!

        // ----EXEMPLE AVEC SINGLETON----
        private static Objet instanceObjet;
        private static int InstancesCount;

        public string texteInstance { get; set; }

        // Utilisation d'une propriété, ça aurait aussi pu être fait avec une méthode
        public static Objet CreateInstance
        {
            get
            {
                if (instanceObjet == null)
                {
                    instanceObjet = new Objet();
                }
                return instanceObjet;
            }
        }
        // --------FIN SINGLETON--------

        private Objet()
        {
            InstancesCount++;
        }

        public static int GetInstancesCount()
        {
            return InstancesCount;
        }
    }
}
