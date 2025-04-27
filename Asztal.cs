using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmark_csaba_etterem_projekt
{
    public class Asztal
    {
        Random r = new();
        public bool foglalt { get; private set; }
        public int feroHely { get; private set; }
        public int foSzam { get; private set; }
        public string pincerNev { get; private set; }
        public string idopont { get; private set; }
        public Asztal()
        {
            this.feroHely = r.Next(2, 10);
        }

        public void Foglalas(int foSzam, string pincerNev, string idopont)
        {
            if(foSzam > this.feroHely)
            {
                throw new InvalidOperationException("nincs elég hely az asztalnál.");
            }
            this.foglalt = true;
            this.foSzam = foSzam;
            this.pincerNev = pincerNev;
            this.idopont = idopont;
        }
    }
}
