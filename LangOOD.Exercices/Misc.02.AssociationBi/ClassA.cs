using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._02.AssociationBi
{
    class ClassA
    {
        private ClassB cb;

        public ClassA()
        {
            cb = new ClassB();
        }

        public void quiSuisJe()
        {
            Console.WriteLine("Je suis la classe A");
        }

        internal void quiEstLui()
        {        
            cb.quiSuisJe();
        }

    }
}
