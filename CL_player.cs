using System;
using System.Collections.Generic;
using System.Text;

namespace prosit_8._3._1
{

    class CL_player
    {

        public static Card c1;
        public static Card c2;

        public CL_player(Card c1_assigned, Card c2_assigned)
        {
            c1 = c1_assigned;
            c2 = c2_assigned;
        }

        public int checkPoints()
        {
            int pts = c1.value + c2.value;

            if (c1.symbol == c2.symbol) pts += 20;

            return pts;
        }
    }
}
