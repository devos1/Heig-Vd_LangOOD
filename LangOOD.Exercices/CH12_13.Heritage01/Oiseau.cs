using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH12_13.Heritage01
{
    class Oiseau : Animal
    {
        public override string Manger()
        {
            return "Je mange des graines puisque je suis un oiseau...";
        }
    }
}
