using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    class Vendue : EtatVoiture
    {
        public Vendue(Voiture v)
            : base(v)
        {
            etatCourant = enEtatVoiture.Vendue;
        }

        public override EtatVoiture Deplacer()
        {
            throw new TransitionEtatImpossibleException("La voiture est vendue");
        }

        public override EtatVoiture Arreter()
        {
            throw new TransitionEtatImpossibleException("La voiture est vendue");
        }

        public override EtatVoiture EffectuerCourseEssai()
        {
            throw new TransitionEtatImpossibleException("La voiture est vendue");
        }

        public override EtatVoiture RetournerauGarage()
        {
            throw new TransitionEtatImpossibleException("La voiture est vendue");
        }

        public override EtatVoiture FaireService()
        {
            throw new TransitionEtatImpossibleException("La voiture est vendue");
        }

        public override EtatVoiture RetourService()
        {
            throw new TransitionEtatImpossibleException("La voiture est vendue");
        }

        public override EtatVoiture MettreEnVente()
        {
            throw new TransitionEtatImpossibleException("La voiture est déjà vendue");
        }

        public override EtatVoiture Vendre()
        {
            throw new TransitionEtatImpossibleException("La voiture est déjà vendue !");
        }
    }
}
