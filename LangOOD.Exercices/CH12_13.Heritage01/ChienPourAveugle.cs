using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH12_13.Heritage01
{
    class ChienPourAveugle : Chien, IGuideAveugle
    {
        void IGuideAveugle.ApprendAGuider()
        {
            Console.WriteLine("J'apprends à guider...");
        }

        void IGuideAveugle.GuiderMaitre()
        {
            Console.WriteLine("Je guide mon maître...");
        }
    }
}
