using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    class EnVente : EtatVoiture
    {
        public EnVente(Voiture v)
            : base(v)
        {
            etatCourant = enEtatVoiture.EnVente;
        }

        public override EtatVoiture Deplacer()
        {
            throw new TransitionEtatImpossibleException("Impossible de déplacer une voiture en vente");
        }

        public override EtatVoiture Arreter()
        {
            throw new TransitionEtatImpossibleException("Impossible d'arrêter une voiture en vente");
        }

        public override EtatVoiture EffectuerCourseEssai()
        {
            throw new TransitionEtatImpossibleException("La voiture n'est pas en maintenance");
        }

        public override EtatVoiture RetournerauGarage()
        {
            throw new TransitionEtatImpossibleException("La voiture n'est pas en course d'essai");
        }

        public override EtatVoiture FaireService()
        {
            throw new TransitionEtatImpossibleException("Impossible de faire le service sur une voiture en vente");
        }

        public override EtatVoiture RetourService()
        {
            throw new TransitionEtatImpossibleException("La voiture n'est pas en maintenance");
        }

        public override EtatVoiture MettreEnVente()
        {
            throw new TransitionEtatImpossibleException("La voiture est déjà en vente");
        }

        public override EtatVoiture Vendre()
        {
            return new Vendue(voiture);
        }
    }
}
