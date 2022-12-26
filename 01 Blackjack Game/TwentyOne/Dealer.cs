using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); // hand is a list, we are adding a card to the hand ... we add first item
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); // the card about to be added to the deck ... we print to console
            Deck.Cards.RemoveAt(0); // pass in an index we want to remove ... we remove from deck
        }
    }
}
