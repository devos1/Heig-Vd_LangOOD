using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH20.Delegates01
{
    class ChefOrchestre
    {
        delegate void DelegueJouerInstrument();
        private DelegueJouerInstrument JouerInstrument;

        private Violoniste v = new Violoniste();
        private Guitariste g = new Guitariste();
        private Pianiste p = new Pianiste();
        private Trompetiste t = new Trompetiste();
        private Silencieux s = new Silencieux();

        public void PréparerOrchestration()
        {
            this.JouerInstrument += v.JouerDuViolon;
            this.JouerInstrument += v.JouerDuViolon;
            this.JouerInstrument += g.JouerDeLaGuitare;
        }

        public void ajoutGuitariste()
        {
            this.JouerInstrument += g.JouerDeLaGuitare;
        }

        public void ajoutPianiste()
        {
            this.JouerInstrument += p.JouerDuPiano;

        }

        public void ajoutTrompetiste()
        {
            this.JouerInstrument += t.JouerDeLaTrompette;

        }

        public void ajoutVioloniste()
        {
            this.JouerInstrument += v.JouerDuViolon;

        }

        public void ajoutSilencieux()
        {
            this.JouerInstrument += s.NeRienJouer;

        }
        public void Orchestrer()
        {
            JouerInstrument();
        }
    }
}
