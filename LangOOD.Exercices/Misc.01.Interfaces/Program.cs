using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._01.Interfaces
{


    class Program
    {
        static void Main(string[] args)
        {
            VehiculeAmphibie v = new VehiculeAmphibie();

            Ivoiture iv = v;
            Iamphibie ia = v;

            iv.bouger();
            ia.bouger();
        }
    }
}
