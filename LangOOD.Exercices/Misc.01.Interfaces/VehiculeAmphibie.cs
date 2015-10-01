using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._01.Interfaces
{
    interface Iamphibie
    {
        void bouger();
    }

    interface Ivoiture
    {
        void bouger();
    }

    class VehiculeAmphibie : Iamphibie, Ivoiture
    {
        void Ivoiture.bouger()
        {
            Console.WriteLine("Je bouge en tant que voiture!!");
        }

        void Iamphibie.bouger()
        {
            Console.WriteLine("Je bouge en tant que amphibie!!");
        }
    }
}
