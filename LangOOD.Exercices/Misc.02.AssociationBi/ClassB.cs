using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._02.AssociationBi
{
    class ClassB
    {
        private ClassA ca;

        public ClassB()
        {
            ca = new ClassA();
        }

        public void quiSuisJe()
        {
            Console.WriteLine("Je suis la classe B");
        }

        public void quiEstLui()
        {
            ca.quiSuisJe();
        }
    }
}
