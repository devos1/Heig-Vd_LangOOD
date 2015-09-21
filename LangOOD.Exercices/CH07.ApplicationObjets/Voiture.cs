using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07.ApplicationObjets
{
    class Voiture
    {
        public string Couleur { get; set; }
        public double ContenanceReservoir { get; set; }

        private Moteur m;

        public Voiture()
        {
            m = new Moteur();
        }


        public void Avancer(int valeur)
        {
            m.ChangerRegime(valeur);
        }

        public void MettreEnMarche()
        {
            m.Demarrer();
        }
    }
}
