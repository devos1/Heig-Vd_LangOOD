using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    class Voiture
    {

        // Variable privée pour avoir l'état en cours de la voiture
        private EtatVoiture etat;

        // Getter pour l'état 
        public String Etat
        {
            get{ return etat.GetType().Name;}
        }

        // Constructeur
        public Voiture(enEtatVoiture etatVoiture)
        {
            switch (etatVoiture) // permet de démarrer la machine dans n'importe quel état
            {
                case enEtatVoiture.Immobile:
                    etat = new Immobile(this);
                    break;
                case enEtatVoiture.EnDeplacement:
                    etat = new EnDeplacement(this);
                    break;
                case enEtatVoiture.EnMaintenance:
                    etat = new EnMaintenance(this);
                    break;
                case enEtatVoiture.EnVente:
                    etat = new EnVente(this);
                    break;
                case enEtatVoiture.Vendue:
                    etat = new Vendue(this);
                    break;
            }
        }

        // Méthodes de changement d'état (8 changements possibles comme dans le diagramme)
        #region Méthodes pour changer d'état
        public void Deplacer()
        {
            etat = etat.Deplacer();
        }
        public void Arreter()
        {
            etat = etat.Arreter();
        }
        public void EffectuerCourseEssai()
        {
            etat = etat.EffectuerCourseEssai();
        }
        public void RetournerauGarage()
        {
            etat = etat.RetournerauGarage();
        }
        public void FaireService()
        {
            etat = etat.FaireService();
        }
        public void RetourService()
        {
            etat = etat.RetourService();
        }
        public void MettreEnVente()
        {
            etat = etat.MettreEnVente();
        }
        public void Vendre()
        {
            etat = etat.Vendre();
        }
        #endregion
    }
}
