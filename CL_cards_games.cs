using System;
using System.Collections.Generic;
using System.Text;



namespace prosit_8._3._1
{
    class CL_cards_games
    {

        public int p1_game_win = 0;
        public int p2_game_win = 0;
        public int c1_game_win = 0;

        private static int final_iteration = 10000;

        public void start()
        {
            
            for(int i = 0; i < final_iteration; i++)
            {
                round();
            }
            
            stats();

        }

        private void stats()
        {
            Console.WriteLine("Player 1 won " + p1_game_win + " games");
            Console.WriteLine("Player 2 won " + p2_game_win + " games");
            Console.WriteLine("Croupier won " + c1_game_win + " games");
        }

        private void round()
        {
            
            CL_cards cards = new CL_cards();
            cards.create();

            CL_player p1 = new CL_player(cards.pickCard(), cards.pickCard());
            int p1_pts = p1.checkPoints();
            CL_player p2 = new CL_player(cards.pickCard(), cards.pickCard());
            int p2_pts = p2.checkPoints();
            CL_croupier c1 = new CL_croupier(cards.pickCard(), cards.pickCard(), cards.pickCard());
            int c1_pts = c1.checkPoints();

            if (!c1.checkWin())
            {

                if (p1_pts > p2_pts && p1_pts > c1_pts)
                {
                    p1_game_win++;
                }
                if (p2_pts > p1_pts && p2_pts > c1_pts)
                {
                    p2_game_win++;
                }
                if (c1_pts > p1_pts && c1_pts > p2_pts)
                {
                    c1_game_win++;
                }
            } else
            {
                c1_game_win++;
            }
        }
    }
}
