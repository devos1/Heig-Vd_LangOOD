using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01.Exercice01
{
    class Program
    {
        static Boolean traitement(int nbIteration, float valeurDepart, float valeurFinale)
        {
            try
            {
                for (int i = 0; i < nbIteration; i++)
                {
                    valeurFinale += (i * 2);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return false;
        }

        static void Main(string[] args)
        {
        }
    }
}
