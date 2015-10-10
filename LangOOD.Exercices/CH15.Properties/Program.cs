using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH15.Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture();
            Console.WriteLine("La vitesse actuelle est de {0} km/h", v1.VitesseCourante);
            v1.Accelerer(10.2);
            Console.WriteLine("La vitesse actuelle est de {0} km/h", v1.VitesseCourante);
            v1.Accelerer(30);
            Console.WriteLine("La vitesse actuelle est de {0} km/h", v1.VitesseCourante);
        }
    }
}
