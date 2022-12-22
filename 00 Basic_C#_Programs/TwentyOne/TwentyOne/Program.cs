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
            //Card card = new Card() { Face = "King", Suit = "Spades"}; // initializes the object with some values

            //TwentyOneGame game = new TwentyOneGame(); // inheritence example
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();

            Deck deck = new Deck(); // deck object
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        // Random function


        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck)
        //    }
        //    return deck;
        //}
    }
}
