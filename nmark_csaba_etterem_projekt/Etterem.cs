using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmark_csaba_etterem_projekt
{
    public class Etterem
    {
        public List<Asztal> asztalok = new();
        
        public Etterem()
        {
            for(int i = 0; i < 8; i++)
            {
                Asztal a = new();
                asztalok.Add(a);
            }
        }
    }
}
