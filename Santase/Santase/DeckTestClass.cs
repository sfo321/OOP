namespace SantaseTest
{
    using Santase.Logic;
    using NUnit.Framework;
    using Santase.Logic.Cards;
    using System.Collections.Generic;

    public class DeckTestClass
    {
        [Test]
        public void TestIfDeckIsNOTnull()
        {
            var deck = new Deck();

            Assert.IsNotNull(deck);
        }

        [TestCase(10)]
        [TestCase(15)]
        [TestCase(20)]
        [TestCase(24)]
        public void CardsInDeckMustBeUnique(int cards)
        {
            var deck = new Deck();
            var cardsfromdeck = new List<Card>();
            var isUnique = true;

            for(int i = 0; i < cards; i++)
            {
                var nextcard = deck.GetNextCard();
                if(cardsfromdeck.Contains(nextcard))
                {
                    isUnique = false;
                }
                cardsfromdeck.Add(nextcard);
            }

            Assert.True(isUnique);
        }

        [Test]
        public void GetNextCardMustNotReturnNull()
        {
            var deck = new Deck();

            for(int i = 0; i < 24; i++)
            {
                var card = deck.GetNextCard();

                Assert.IsNotNull(card);
            }
        }

        [Test]
        public void GettingMoreThan_24_CardsMustThrow()
        {
            var deck = new Deck();

            for(int i = 0; i < 24; i++)
            {
                deck.GetNextCard();
            }
            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(20)]
        public void DrawingACardMustDecreaseDeckCount(int draw)
        {
            var deck = new Deck();

            for(int i = 0; i < draw; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(deck.CardsLeft, 24 - draw);
        }

        [Test]
        public void DeckMustHave_24_Cards()
        {
            var deck = new Deck();

            Assert.AreEqual(deck.CardsLeft, 24);
        }

        [Test]
        public void CheckIfDecksAreShuffled()
        {
            var deck1 = new Deck();
            var deck2 = new Deck();
            var areShuffled = false;

            for(int i = 0; i < 24; i++)
            {
                var card1 = deck1.GetNextCard();
                var card2 = deck2.GetNextCard();

                if(card1 != card2)
                {
                    areShuffled = true;
                }

                Assert.True(areShuffled);
            }
        }
    }
}
