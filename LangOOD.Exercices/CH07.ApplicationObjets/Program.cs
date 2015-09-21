using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CH07.ApplicationObjets
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeurAvancement = 0;
            int milliseconds = 1000;

            Console.WriteLine("Création d'une nouvelle voiture...");
            Voiture voiture = new Voiture();
            Console.WriteLine("Démarrage de la voiture en cours...");
            voiture.MettreEnMarche();
            Console.WriteLine("Faire avance la voiture...");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("ATTENTION : Pour arrêter la voiture, presser ESC");
            Console.WriteLine("");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                Thread.Sleep(milliseconds);
                valeurAvancement++;
                voiture.Avancer(valeurAvancement);
            }
            Console.WriteLine("\n\nVous avez arrêté la voiture. A la prochaine...");
        }
    }
}
