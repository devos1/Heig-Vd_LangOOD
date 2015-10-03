using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Programme qui démontre l'héritage et ke polymorphisme avec une classe mêre Animal et 2 classes filles (Chien et Oiseau)
/// </summary>
namespace CH12_13.Heritage01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création de 2 variables de type animal mais instanciées une fois Chien et l'autre Oiseau
            Animal animal1 = new Chien();
            Animal animal2 = new Oiseau();

            // Affichage à la console pour démontrer que le polymorphisme fonctionne
            // Bien que ce soit 2 animaux, la méthode appelée est celle de la classe fille (chien ou oiseau)
            Console.WriteLine("Animal 1 (Chien)\t: {0} ", animal1.Manger());
            Console.WriteLine("Animal 2 (Oiseau)\t: {0} ", animal2.Manger());
            Console.WriteLine("\n--------------------------------------------------------------------------\n");

            // Création d'une collection d'animaux
            Animal animal3 = new Chien();
            Animal animal4 = new Chien();
            Animal animal5 = new Oiseau();
            Animal animal6 = new Oiseau();

            List<Animal> listeAnimaux = new List<Animal>();
            listeAnimaux.Add(animal1);
            listeAnimaux.Add(animal2);
            listeAnimaux.Add(animal3);
            listeAnimaux.Add(animal4);
            listeAnimaux.Add(animal5);
            listeAnimaux.Add(animal6);

            foreach (Animal animal in listeAnimaux)
            {
                Console.WriteLine(animal.Manger());               
            }

            Console.WriteLine("\n--------------------------------------------------------------------------\n");

            // Utilisation de la classe qui implémente une Interface
            ChienPourAveugle cpa = new ChienPourAveugle();
            IGuideAveugle iga = cpa;
            iga.ApprendAGuider();
            iga.GuiderMaitre();

            Console.WriteLine("\n--------------------------------------------------------------------------\n");

            // Test d'utilisation de "as" pour s'assurer que le type référencé est le bon
            Chien chien = new Chien();
            ChienPourAveugle cpa2 = new ChienPourAveugle();
            Animal a1 = chien;
            Animal a2 = cpa2;

            IGuideAveugle iga2 = a1 as IGuideAveugle;
            IGuideAveugle iga3 = a2 as IGuideAveugle;

            // Si on passe ig3 = ok si on passe ig2 = ko
            if (iga3 != null)
            {
                Console.Write("Ok - ");
                iga3.ApprendAGuider();
            }
            else
            {
                Console.WriteLine("Ce n'est pas un chien pour aveugle");
            }
        }
    }
}
