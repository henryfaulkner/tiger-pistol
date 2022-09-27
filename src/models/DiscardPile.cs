using System.Collections.Generic;

namespace src {
    public class DiscardPile : ICardPile {
        public List<Card> cards = new List<Card>();

        public DiscardPile() {
        }

        public void EmptyDiscardPile() {
            cards.Clear();
        }
    }
}