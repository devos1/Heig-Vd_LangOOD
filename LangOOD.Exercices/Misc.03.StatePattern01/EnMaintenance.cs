using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    class EnMaintenance : EtatVoiture
    {
        public EnMaintenance(Voiture v)
            : base(v)
        {
            etatCourant = enEtatVoiture.EnMaintenance;
        }

        public override EtatVoiture Deplacer()
        {
            throw new TransitionEtatImpossibleException("Impossible de déplacer une voiture en maintenance");
        }

        public override EtatVoiture Arreter()
        {
            throw new TransitionEtatImpossibleException("Impossible d'arrêter une voiture en maintenance");
        }

        public override EtatVoiture EffectuerCourseEssai()
        {
            return new EnDeplacement(voiture);
        }

        public override EtatVoiture RetournerauGarage()
        {
            throw new TransitionEtatImpossibleException("Impossible de retourner au garage une voiture qui y est déjà");
        }

        public override EtatVoiture FaireService()
        {
            throw new TransitionEtatImpossibleException("La voiture est déjà au service");
        }

        public override EtatVoiture RetourService()
        {
            return new Immobile(voiture);
        }

        public override EtatVoiture MettreEnVente()
        {
            throw new TransitionEtatImpossibleException("Impossible de mettre en vente une voiture en maintenance");
        }

        public override EtatVoiture Vendre()
        {
            throw new TransitionEtatImpossibleException("Impossible de vendre une voiture en maintenance");
        }
    }
}
