using System;
using Xunit;
using src;

namespace src.Tests
{
    public class Deck_Shuffle
    {
        [Fact]
        public void Deck_IsFullyShuffled()
        {
            Deck shuffledDeck = new Deck();
            shuffledDeck.Randomize();
            Deck freshDeck = new Deck();
            bool cardRepeats = false;

            for(int i = 0; i < 52; i++) {
                if(shuffledDeck.cards[0].value == freshDeck.cards[0].value
                    && shuffledDeck.cards[0].suit == freshDeck.cards[0].suit) {
                        cardRepeats = true;
                    }
            }
            
            Assert.False(cardRepeats, "No card should repeat.");
        }
    }
}
