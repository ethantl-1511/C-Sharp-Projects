using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        // Main function
        static void Main(string[] args)
        {

            Deck deck = new Deck(); // deck object
            deck.Shuffle(3);

            foreach (Card Card in deck.Cards)
            {
                Console.WriteLine(Card.Face + " of " + Card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
