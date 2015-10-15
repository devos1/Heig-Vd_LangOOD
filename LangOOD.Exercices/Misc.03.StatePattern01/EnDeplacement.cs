using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    class EnDeplacement : EtatVoiture
    {
        // Constructeur
        public EnDeplacement(Voiture v) :base(v)
        {
            etatCourant = enEtatVoiture.EnDeplacement;
        }

        #region Méthodes redéfinies
        public override EtatVoiture Deplacer()
        {
            throw new TransitionEtatImpossibleException("Impossible de déplacer une voiture déjà en déplacement");
        }

        public override EtatVoiture Arreter()
        {
            //code métier

            return new Immobile(voiture);
        }

        public override EtatVoiture EffectuerCourseEssai()
        {
            throw new TransitionEtatImpossibleException("Impossible de faire une course d'essai sur une voiture en déplacement");
        }

        public override EtatVoiture RetournerauGarage()
        {
            return new EnMaintenance(voiture);
        }

        public override EtatVoiture FaireService()
        {
            throw new TransitionEtatImpossibleException("Impossible de faire un service sur une voiture en déplacement");
        }

        public override EtatVoiture RetourService()
        {
            throw new TransitionEtatImpossibleException("Impossible de revenir du service sur une voiture en déplacement");
        }

        public override EtatVoiture MettreEnVente()
        {
            throw new TransitionEtatImpossibleException("Impossible de mettre en vente une voiture en déplacement");
        }

        public override EtatVoiture Vendre()
        {
            throw new TransitionEtatImpossibleException("Impossible de vendre une voiture en déplacement");
        }
        #endregion
    }
}
