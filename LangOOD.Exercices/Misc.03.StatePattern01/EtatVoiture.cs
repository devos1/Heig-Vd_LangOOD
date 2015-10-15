using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._03.StatePattern01
{
    // ENUM pour les différents états de la voiture (comme le diagramme)
    public enum enEtatVoiture { Immobile, EnDeplacement, EnMaintenance, EnVente, Vendue };

    // Classe d'exception pour la gestion d'une transition impossible
    public class TransitionEtatImpossibleException : Exception
    {
        public TransitionEtatImpossibleException(string message)
            : base(message)
        { }
    }

    // Classe abstraite pour la gestion de l'état
    abstract class EtatVoiture
    {
        // Variables
        protected Voiture voiture;
        protected enEtatVoiture etatCourant;

        // Constructeur
        public EtatVoiture(Voiture v)
        {
            voiture = v;
        }

        /// <summary>
        /// Fonction avec enum pour donner l'état de la voiture
        /// </summary>
        /// <returns>enum état voiture</returns>
        public enEtatVoiture GetEtatCourant()
        {
            return etatCourant;
        }

        //Méthodes abstraites appelées par la voiture
        public abstract EtatVoiture Deplacer();
        public abstract EtatVoiture Arreter();
        public abstract EtatVoiture EffectuerCourseEssai();
        public abstract EtatVoiture RetournerauGarage();
        public abstract EtatVoiture FaireService();
        public abstract EtatVoiture RetourService();
        public abstract EtatVoiture MettreEnVente();
        public abstract EtatVoiture Vendre();

    }
}
