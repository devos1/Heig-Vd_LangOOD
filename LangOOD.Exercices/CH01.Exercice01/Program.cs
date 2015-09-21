using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01.Exercice01
{
    class Program
    {
        static int nbIteration;
        static float valeurDepart;
        static float valeurFinale;

        static Boolean traitement(int nbIter, float vd, float vf)
        {
            try
            {
                vf = vd;
                for (int i = Convert.ToInt32(vd); i < nbIter; i++)
                {
                    vf += ((i-1) * 2);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Erreur : " + e.Message);
                return false;
            }

            if (vf.GetType() == typeof(System.Single))
            {
                valeurFinale = vf;
                return true;
            }
            else
            {
                Console.WriteLine("Erreur : La varaible n'est pas un float!");
                return false;
            }
        }

        static void Main(string[] args)
        {
            string line;

            try
            {
                Console.Write("Entre nombre d'itérations : ");
                line = Console.ReadLine();
                nbIteration = Int32.Parse(line);

                Console.Write("Entre numéro de départ : ");
                line = Console.ReadLine();
                valeurDepart = float.Parse(line);

                Console.Write("Entre numéro de fin : ");
                line = Console.ReadLine();
                valeurFinale = float.Parse(line);
            }
            catch (FormatException fEx)
            {
                Console.WriteLine("Erreur : {0} Fermeture de l'application ", fEx.Message);
                return;
            }
            catch (OverflowException oEx)
            {
                Console.WriteLine("Erreur : {0} Fermeture de l'application ", oEx.Message);
                return;
            }

            if (traitement(nbIteration, valeurDepart, valeurFinale))
            {
                Console.WriteLine("Le traitment s'est bien passé.");
                Console.WriteLine("Valeur finale = {0}", valeurFinale);
            }

            Console.ReadKey();

        }
    }
}
