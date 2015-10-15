using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    class Immobile : EtatVoiture
    {
        public Immobile(Voiture v)
            : base(v)
        {
            etatCourant = enEtatVoiture.Immobile;
        }

        public override EtatVoiture Arreter()
        {
            throw new TransitionEtatImpossibleException("Impossible d'arrêter une voiture déjà arrêtée");
        }

        public override EtatVoiture Deplacer()
        {
            return new EnDeplacement(voiture);
        }
        public override EtatVoiture EffectuerCourseEssai()
        {
            throw new TransitionEtatImpossibleException("Impossible de faire une course d'essai hors d'un service de maintenance");
        }
        public override EtatVoiture RetournerauGarage()
        {
            throw new TransitionEtatImpossibleException("Impossible de retourner au garage hors d'une course d'essai");
        }
        public override EtatVoiture FaireService()
        {
            return new EnMaintenance(voiture);
        }
        public override EtatVoiture RetourService()
        {
            throw new TransitionEtatImpossibleException("Impossible de retourner du service un véhicule qui n'y est pas");
        }
        public override EtatVoiture MettreEnVente()
        {
            return new EnVente(voiture);
        }
        public override EtatVoiture Vendre()
        {
            throw new TransitionEtatImpossibleException("Impossible de vendre une voiture qui n'est pas en vente");
        }

    }
}
