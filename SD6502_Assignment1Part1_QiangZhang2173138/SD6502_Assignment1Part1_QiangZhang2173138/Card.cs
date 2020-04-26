using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD6502_Assignment1Part1_QiangZhang2173138
{
    public class Card
    {
        public Ranks Ranks { get; set; }
        public Suits Suits { get; set; }
        public bool IsfaceUp { get; set; }

        public Card(Ranks ranks, Suits suits, bool isfaceUp)
        {
            Ranks = ranks;
            Suits = suits;
            IsfaceUp = isfaceUp;
        }
    }
}
