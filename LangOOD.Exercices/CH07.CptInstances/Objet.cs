using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07.CptInstances
{
    class Objet
    {
        private static int nbInstances;

        public static int GetInstancesCount()
        {
            return nbInstances;
        }

        public Objet()
        {
            nbInstances++;
        }


    }
}
