using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prosit_8._3._1
{
    public class CL_cards
    {

        public List<Card> cards = new List<Card>();

        public Random rnd = new Random();

        public void create()
        {
            char currSymbol = 'T';
            for (int w = 1; w < 5; w++)
            {
                for (int x = 1; x < 14; x++)
                {
                    cards.Add(new Card( currSymbol, x < 10 ?  x : 10));
                    /*Card tempCard = new Card('x', 5);
                    cards.Add(tempCard);*/
                }
                switch (currSymbol)
                {
                    case 'T':
                        currSymbol = 'C';
                        break;
                    case 'C':
                        currSymbol = 'D';
                        break;
                    case 'D':
                        currSymbol = 'S';
                        break;
                    default:
                        break;
                }
            }
        }

        public Card pickCard()
        {
            
            int idx = rnd.Next(1, cards.Count);
            Card selectedCard = cards[idx];
            //Console.WriteLine("ID : " + cards[idx].value);

            cards.RemoveAt(idx);

            return selectedCard;
        }

        public void showCards()
        {
            cards.ForEach(delegate (Card card)
            {
                Console.WriteLine(card.value);
                Console.WriteLine(card.symbol);
            });
        }
    }

    public class Card
    {

        public char symbol;
        public int value;

        public Card(char symbol, int value)
        {
            this.symbol = symbol;
            this.value = value;
        }
    }
}
