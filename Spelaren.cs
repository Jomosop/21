using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Spelaren:Spelare
    {
        public Spelaren(KortLek lek):base(lek)
        {
        }

        public void NyttKort()
        {
            Kort k = leken.DraÖversta();
            hand.Add(k);                    
        }  
        
    }
   
}
