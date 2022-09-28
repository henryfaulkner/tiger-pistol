using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var deck = new Deck();
            deck.Randomize();
            for(int i = 0; i < 60; i++) {
                var card = deck.PullCard();
                Console.WriteLine($"{card.value} of {card.suit}");
            }
        }
    }
}
