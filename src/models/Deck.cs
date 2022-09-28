using System;
using System.Collections.Generic;

namespace src {
    public class Deck : ICardPile {
        private List<string> values = new List<string>(){"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
        private List<string> suits = new List<string>(){"Spades", "Clubs", "Hearts", "Diamonds"};
        public List<Card> cards = new List<Card>();
        public DiscardPile discardPile = new DiscardPile();
        private Random rand = new Random();
        private int numshifts = 10000;

        public Deck() {
            PopulateDeck();
        }

        public void PopulateDeck() {
            foreach(var suit in suits){
                foreach(var value in values) {
                    cards.Add(new Card(value, suit));
                }
            }
        }

        public void Randomize() {
            for(int i = 0; i < numshifts; i++) {
                int randNumOne = rand.Next(52);
                int randNumTwo = rand.Next(52);
                Card tempCard = cards[randNumOne];
                cards[randNumOne] = cards[randNumTwo];
                cards[randNumTwo] = tempCard;
            }
        }

        public Card PullCard() {
            if(cards.Count == 0) {
                Console.WriteLine("The deck was empty.\n Reshuffling the deck and serving the first card now.");
                PopulateDeck();
                Randomize();
                discardPile.EmptyDiscardPile();
            }
            if(cards.Count == 1) {
                Console.WriteLine("Serving the deck's last card.");
            }    
            return Discard();
        }

        public Card Discard() {
            var result = cards[0];
            cards.RemoveAt(0);
            discardPile.cards.Add(result);
            return result;
        }
    }
}