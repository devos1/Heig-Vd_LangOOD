using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH16.IndexersAtZoo
{
    class Nourriture
    {
        private string nom;

        public Nourriture()
        {
            this.nom = "Nourriture inconnue";
        }

        public Nourriture(string nom)
        {
            this.nom = nom;
        }

        public string getNom()
        {
            return this.nom;
        }

        // Il faut redéfinir cette méthode car la méthode indexOf utilise Equals pour comparer
        // Et il faut un élément commun au niveau de l'objet pour comparer, ici c'est le nom
        // Je contrôle aussi que c'est le bon type d'objet avec l'opérateur is!!
        public override bool Equals(object other)
        {
            return (other is Nourriture) && Equals((Nourriture)other);
        }

        // Pas forcément utile, on pourrait faire cette comparaison dans la méthode précédente
        public bool Equals(Nourriture other)
        {
            return this.nom == other.nom;
        }
    }
}
