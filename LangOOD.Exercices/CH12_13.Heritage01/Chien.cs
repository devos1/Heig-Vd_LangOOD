using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH12_13.Heritage01
{
    class Chien : Animal
    {
        public override string Manger()
        {
            return "Je mange des os puisque je suis un chien...";
        }
    }
}
