using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH15.Properties
{
    class Voiture
    {
        public double VitesseCourante { get; private set; }

        public Voiture()
        {
            VitesseCourante = 0;
            Console.WriteLine("Une voiture vient d'être créée.");
        }

        public void Accelerer(double a)
        {
            VitesseCourante += a;
        }
    }
}
