using System;
using System.Collections.Generic;
using System.Text;

namespace prosit_8._3._1
{
    class CL_croupier
    {

        public static Card c1;
        public static Card c2;
        public static Card c3;


        public CL_croupier(Card c1_assigned, Card c2_assigned, Card c3_assigned)
        {
            c1 = c1_assigned;
            c2 = c2_assigned;
            c3 = c3_assigned;
        }

        public int checkPoints()
        {

            int pts = c1.value + c2.value + c3.value;

            if (c1.symbol == c2.symbol && c2.symbol == c3.symbol) pts += 35;

            return pts;
        }

        public bool checkWin()
        {
            return (c1.value == c2.value && c2.value == c3.value);
        }
    }
}
