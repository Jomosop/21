using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    abstract class Spelare
    {
        protected KortLek leken;
        protected List<Kort> hand = new List<Kort>();

        public Spelare()
        {
            
        }

        public Spelare(KortLek lek)
        {
            leken = lek;     
        }

        public int beräknaPoäng()
        {           
            int poäng = 0;
            foreach (Kort ko in hand)
            {
                int kortVärde = (int)ko.KortValör;                
                if (kortVärde > 10 && kortVärde<14) kortVärde = 10;
                if (kortVärde == 14) kortVärde = 11;
                poäng += kortVärde;
            }
            if (poäng > 21)
            {
                poäng = 0;
                foreach (Kort ko in hand)
                {
                    int kortVärde = (int)ko.KortValör;
                    if (kortVärde > 10 && kortVärde < 14) kortVärde = 10;
                    if (kortVärde == 14) kortVärde = 1;
                    poäng += kortVärde;                   
                }
                if (poäng < 12) poäng += 10;
            }
            return poäng;
        }

        public List<Kort> GetHand()
        {
            return hand;
        }
    }
}
