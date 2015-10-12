using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH16.IndexersAtZoo
{
    class ZooYverdon
    {
        List<Animal> animaux;
        List<Nourriture> nourritures;

        public ZooYverdon()
        {
            animaux = new List<Animal>();
            nourritures = new List<Nourriture>();
        }

        public void addAnimalAuZoo(Animal animal, Nourriture nourriture)
        {
            this.animaux.Add(animal);
            this.nourritures.Add(nourriture);
        }

        public Animal this[Nourriture nourriture]
        {
            get
            {
                int i = nourritures.IndexOf(nourriture);
                if (i > -1)
                {
                    return animaux[i];
                }
                else
                {
                    return null;
                }
            }
        }

        public Nourriture this[Animal animal]
        {
            get
            {
                int i = this.animaux.IndexOf(animal);
                if (i > -1)
                {
                    return nourritures[i];
                }
                else
                {
                    return null;
                }
            }
        }

    }
}
