using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class KortLek 
    {
        public List<Kort> lek = new List<Kort>();
        static Random rand = new Random();

        public KortLek()
        {
            for (int i = 0; i < 52; i++)
            {
                lek.Add(new Kort((Färg)(i % 4 + 1), (Valör)((51-i) /4+2),i));                
            }
        }

        public void Blanda()
        {
            List<Kort> blandlek = new List<Kort>();
            int slump;
            for (int i = 0; i < 52; i++)
            {
                slump = rand.Next(51 - i);
                blandlek.Add(lek[slump]);
                lek.RemoveAt(slump);
            }
            lek = blandlek;
        }

        public Kort DraÖversta()
        {
            Kort k = lek[0];
            lek.RemoveAt(0);
            return k;
        }

       
    }
}
