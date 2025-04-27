using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmark_csaba_etterem_projekt
{
    enum fizetesTipus
    {
        KARTYA,
        KEZPENZ,
        VEGYES
    }
    internal class Vendeg
    {
        private List<string> rendeltek = new();
        public IReadOnlyList<string> rendeltekR => rendeltek.AsReadOnly();

        public int fizetendoOsszeg { get; private set; }

        public fizetesTipus fizetesTipus { get; private set; }

        public void Rendeles(string rendeles)
        {
            rendeltek.Add(rendeles);
        }

        public void FizetesTipusValtoztatas(fizetesTipus f)
        {
            fizetesTipus = f;
        }

        
    }
}
