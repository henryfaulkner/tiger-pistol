using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            var deck = new Deck();
            deck.Randomize();
            while(input != "quit"){
                Console.WriteLine("Type 'pull' to pull a card.");
                input = Console.ReadLine();
                if(input == "pull") {
                    var card = deck.PullCard();
                    Console.WriteLine($"You pulled a {card.value} of {card.suit}.");
                }
            }
        }
    }
}
