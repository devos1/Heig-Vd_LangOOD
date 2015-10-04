using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc._02.AssociationBi
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA ca = new ClassA();
            ClassB cb = new ClassB();

            Console.WriteLine("Appel de la méthode de la classe B depuis la classe A :");
            ca.quiEstLui();
            Console.WriteLine("Appel de la méthode de la classe A depuis la classe B :");
            cb.quiEstLui();
        }
    }
}
