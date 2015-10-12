using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH16.IndexersAtZoo
{
    class Animal
    {
        private string nom;

        public Animal()
        {
            this.nom = "Inconnu";
        }

        public Animal(string nom)
        {
            this.nom = nom;
        }

        public string getNom()
        {
            return this.nom;
        }
        public override bool Equals(object other)
        {
            return (other is Animal) && Equals((Animal)other);
        }

        public bool Equals(Animal other)
        {
            return this.nom == other.nom;
        }
    }
}
