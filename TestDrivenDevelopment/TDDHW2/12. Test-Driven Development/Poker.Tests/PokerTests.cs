using NUnit.Framework;
using Poker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Tests
{

    [TestFixture]
    public class PokerTests
    {
        public static IEnumerable<TestCaseData> TestHandToStringWorkCorrectCases
        {
            get
            {
                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.King, CardSuit.Hearts),
                  new Card(CardFace.King, CardSuit.Spades),
                  new Card(CardFace.Seven, CardSuit.Diamonds),
                }), "Ace Clubs, Ace Diamonds, King Hearts, King Spades, Seven Diamonds");

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Jack, CardSuit.Spades),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                  new Card(CardFace.Three, CardSuit.Diamonds),
                }), "Eight Clubs, Ace Diamonds, Jack Spades, Queen Clubs, Three Diamonds");

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Hearts),
                  new Card(CardFace.Six, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                  new Card(CardFace.Two, CardSuit.Clubs),
                  new Card(CardFace.Ten, CardSuit.Diamonds),
                }), "Ace Hearts, Six Spades, King Hearts, Two Clubs, Ten Diamonds");

            }
        }
        public static IEnumerable<TestCaseData> TestIsFlushCheckerWithNoFlushHandCases
        {
            get
            {
                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.King, CardSuit.Hearts),
                  new Card(CardFace.King, CardSuit.Spades),
                  new Card(CardFace.Seven, CardSuit.Diamonds),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Jack, CardSuit.Spades),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                  new Card(CardFace.Three, CardSuit.Diamonds),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Hearts),
                  new Card(CardFace.Six, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                  new Card(CardFace.Two, CardSuit.Clubs),
                  new Card(CardFace.Ten, CardSuit.Diamonds),
                }));

            }
        }
        public static IEnumerable<TestCaseData> TestIsFlushCheckerWithCorrectHandCases{
            get
            {
                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.King, CardSuit.Clubs),
                  new Card(CardFace.Four, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Diamonds),
                  new Card(CardFace.King, CardSuit.Diamonds),
                  new Card(CardFace.Four, CardSuit.Diamonds),
                  new Card(CardFace.Queen, CardSuit.Diamonds),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Hearts),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                  new Card(CardFace.King, CardSuit.Hearts),
                  new Card(CardFace.Four, CardSuit.Hearts),
                  new Card(CardFace.Queen, CardSuit.Hearts),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Spades),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Spades),
                  new Card(CardFace.Four, CardSuit.Spades),
                  new Card(CardFace.Queen, CardSuit.Spades),
                }));

            }
        }

        public static IEnumerable<TestCaseData> TestIsValidHandCheckerWithCorrectHandCases
        {
            get
            {
                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.King, CardSuit.Clubs),
                  new Card(CardFace.Four, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Diamonds),
                  new Card(CardFace.King, CardSuit.Diamonds),
                  new Card(CardFace.Four, CardSuit.Diamonds),
                  new Card(CardFace.Queen, CardSuit.Diamonds),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Hearts),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                  new Card(CardFace.King, CardSuit.Hearts),
                  new Card(CardFace.Four, CardSuit.Hearts),
                  new Card(CardFace.Queen, CardSuit.Hearts),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Spades),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Spades),
                  new Card(CardFace.Four, CardSuit.Spades),
                  new Card(CardFace.Queen, CardSuit.Spades),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Jack, CardSuit.Diamonds),
                  new Card(CardFace.Queen, CardSuit.Hearts),
                  new Card(CardFace.King, CardSuit.Spades),
                  new Card(CardFace.Seven, CardSuit.Diamonds),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Jack, CardSuit.Spades),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                  new Card(CardFace.Three, CardSuit.Diamonds),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Hearts),
                  new Card(CardFace.Six, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                  new Card(CardFace.Two, CardSuit.Clubs),
                  new Card(CardFace.Ten, CardSuit.Diamonds),
                }));
            }
        }
        public static IEnumerable<TestCaseData> TestIsValidHandCheckerWithIncorrectHandCases
        {
            get
            {
                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.King, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Queen, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Diamonds),
                  new Card(CardFace.King, CardSuit.Diamonds),
                  new Card(CardFace.Four, CardSuit.Diamonds),
                  new Card(CardFace.Queen, CardSuit.Diamonds),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Hearts),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                  new Card(CardFace.King, CardSuit.Hearts),
                  new Card(CardFace.Four, CardSuit.Hearts),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Spades),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Spades),
                  new Card(CardFace.Four, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Spades),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.King, CardSuit.Hearts),
                  new Card(CardFace.King, CardSuit.Spades),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Three, CardSuit.Diamonds),
                  new Card(CardFace.Jack, CardSuit.Spades),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                  new Card(CardFace.Three, CardSuit.Diamonds),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>() {
                  new Card(CardFace.King, CardSuit.Hearts),
                  new Card(CardFace.Six, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                  new Card(CardFace.Two, CardSuit.Clubs),
                  new Card(CardFace.Ten, CardSuit.Diamonds),
                }));
            }
        }
        public static IEnumerable<TestCaseData> TestIsFourOfAKindCheckerWithCorrectHandCases{

            get{

                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                      new Card(CardFace.Ace, CardSuit.Clubs),
                      new Card(CardFace.Eight, CardSuit.Clubs),
                      new Card(CardFace.Ace, CardSuit.Diamonds),
                      new Card(CardFace.Ace, CardSuit.Spades),
                      new Card(CardFace.Ace, CardSuit.Hearts),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Jack, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Jack, CardSuit.Diamonds),
                  new Card(CardFace.Jack, CardSuit.Spades),
                  new Card(CardFace.Jack, CardSuit.Hearts),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                }));

            }
        }
        public static IEnumerable<TestCaseData> TestIsOnePairWithCorrectHandsCases
        {
            get
            {
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Five, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Diamonds),
                  new Card(CardFace.Five, CardSuit.Spades),
                  new Card(CardFace.Ace, CardSuit.Hearts),
                }));
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Four, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                }));
            }
        }
        public static IEnumerable<TestCaseData> TestTwoPairWithTwoPairsHandsCase
        {
            get
            {
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Diamonds),
                  new Card(CardFace.Queen, CardSuit.Spades),
                  new Card(CardFace.Ace, CardSuit.Hearts),
                }));
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Four, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Four, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                }));
            }
        }
        public static IEnumerable<TestCaseData> TestIsThreeOfAKindWithThreeOfAKindHandsCases
        {
            get
            {
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Queen, CardSuit.Spades),
                  new Card(CardFace.Ace, CardSuit.Hearts),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.King, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Diamonds),
                  new Card(CardFace.Queen, CardSuit.Spades),
                  new Card(CardFace.Ace, CardSuit.Hearts),
                }));
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Four, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.King, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                }));
            }
        }
        public static IEnumerable<TestCaseData> TestFullHouseWithFullHouseHandsCases
        {
            get
            {
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.Ace, CardSuit.Hearts),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.King, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Diamonds),
                  new Card(CardFace.Queen, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                }));
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Four, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Four, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                }));
            }
        }
        public static IEnumerable<TestCaseData> TestIsStraightWitStraightHandsCases
        {
            get
            {
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                  new Card(CardFace.King, CardSuit.Diamonds),
                  new Card(CardFace.Ten, CardSuit.Spades),
                  new Card(CardFace.Jack, CardSuit.Hearts),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Seven, CardSuit.Clubs),
                  new Card(CardFace.Six, CardSuit.Clubs),
                  new Card(CardFace.Four, CardSuit.Diamonds),
                  new Card(CardFace.Five, CardSuit.Spades),
                  new Card(CardFace.Three, CardSuit.Hearts),
                }));
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Six, CardSuit.Clubs),
                  new Card(CardFace.Five, CardSuit.Clubs),
                  new Card(CardFace.Four, CardSuit.Diamonds),
                  new Card(CardFace.Three, CardSuit.Spades),
                  new Card(CardFace.Two, CardSuit.Hearts),
                }));
            }
        }
        public static IEnumerable<TestCaseData> TestIsStraightFlushWithStraightFlushHandsCases
        {
            get
            {
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                  new Card(CardFace.King, CardSuit.Clubs),
                  new Card(CardFace.Ten, CardSuit.Clubs),
                  new Card(CardFace.Jack, CardSuit.Clubs),
                }));

                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Seven, CardSuit.Diamonds),
                  new Card(CardFace.Six, CardSuit.Diamonds),
                  new Card(CardFace.Four, CardSuit.Diamonds),
                  new Card(CardFace.Five, CardSuit.Diamonds),
                  new Card(CardFace.Three, CardSuit.Diamonds),
                }));
                yield return new TestCaseData(new Hand(new List<ICard>()
                {
                  new Card(CardFace.Six, CardSuit.Spades),
                  new Card(CardFace.Five, CardSuit.Spades),
                  new Card(CardFace.Four, CardSuit.Spades),
                  new Card(CardFace.Three, CardSuit.Spades),
                  new Card(CardFace.Two, CardSuit.Spades),
                }));
            }
        }
        [TestCase(CardFace.Ace, CardSuit.Clubs, "Ace Clubs")]
        [TestCase(CardFace.Eight, CardSuit.Diamonds, "Eight Diamonds")]
        [TestCase(CardFace.Five, CardSuit.Hearts, "Five Hearts")]
        [TestCase(CardFace.Four, CardSuit.Spades, "Four Spades")]
        [TestCase(CardFace.Jack, CardSuit.Clubs, "Jack Clubs")]
        public void TestCardToStringWorkCorrect(CardFace face, CardSuit suit, string result)
        {
            Card card = new Card(face, suit);

            Assert.AreEqual(result, card.ToString());
        }

        [TestCaseSource("TestHandToStringWorkCorrectCases")]
        public void TestHandToStringWorkCorrect(Hand hand, string expected)
        {
            IList<Card> cards = new List<Card>();

            string result = hand.ToString();

            Assert.AreEqual(result, expected);
        }

        [TestCaseSource("TestIsValidHandCheckerWithCorrectHandCases")]
        public void TestIsValidHandCheckerWithCorrectHand(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [TestCaseSource("TestIsValidHandCheckerWithIncorrectHandCases")]
        public void TestIsValidHandCheckerWithIncorrectHand(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [TestCaseSource("TestIsFlushCheckerWithCorrectHandCases")]
        public void TestIsFlushCheckerWithCorrectHand(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestCaseSource("TestIsValidHandCheckerWithIncorrectHandCases")]
        public void TestIsFlushCheckerWithIncorrectHand(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestCaseSource("TestIsFlushCheckerWithNoFlushHandCases")]
        public void TestIsFlushCheckerWithNoFlushHand(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestCaseSource("TestIsFourOfAKindCheckerWithCorrectHandCases")]
        public void TestIsFourOfAKindCheckerWithCorrectHand(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        //TestWithInvalidHandTests
        [TestCaseSource("TestIsValidHandCheckerWithIncorrectHandCases")]
        public void TestIsFourOfAKindCheckerWithNoCorrectHand(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        //TestWithFlushTests
        [TestCaseSource("TestIsFlushCheckerWithNoFlushHandCases")]
        public void TestIsFourOfAKindCheckerWithNoFourOfAKindHand(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        //TestWithIsValidHandCheckerTests
        [TestCaseSource("TestIsValidHandCheckerWithCorrectHandCases")]
        public void TestIsHightCardWithCorrectHightCardCases(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsHighCard(hand));
        }

        //TestIsHightCardWithIsValidCheckerTests
        [TestCaseSource("TestIsValidHandCheckerWithIncorrectHandCases")]
        public void TestIsHightCardWithIncorrectHightCardCases(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsHighCard(hand));
        }

        [TestCaseSource("TestIsOnePairWithCorrectHandsCases")]
        public void TestIsOnePairWithCorrectHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsOnePair(hand));
        }

        //TestIsPairWithCorrectHandsButNoPairs
        [TestCaseSource("TestIsValidHandCheckerWithCorrectHandCases")]
        public void TestIsOnePairWithNoPairHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsOnePair(hand));
        }

        //TestIsOnePairWithIsValidCheckerTests
        [TestCaseSource("TestIsValidHandCheckerWithIncorrectHandCases")]
        public void TestIsOnePairWithIncorrectHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsOnePair(hand));
        }

        [TestCaseSource("TestTwoPairWithTwoPairsHandsCase")]
        public void TestTwoPairWithTwoPairsHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsTwoPair(hand));
        }

        //TestIsTwoPairWithCorrectHandsButNoPairs
        [TestCaseSource("TestIsValidHandCheckerWithCorrectHandCases")]
        public void TestIsTwoPairWithNoPairHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        //TestIsTwoPairWithIsValidCheckerTests
        [TestCaseSource("TestIsValidHandCheckerWithIncorrectHandCases")]
        public void TestIsTwoPairWithIncorrectHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [TestCaseSource("TestIsThreeOfAKindWithThreeOfAKindHandsCases")]
        public void TestIsThreeOfAKindWithThreeOfAKindHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsThreeOfAKind(hand));
        }

        //TestIsThreeOfAKindWithCorrectHandsButNoThreeOfAKind
        [TestCaseSource("TestIsValidHandCheckerWithCorrectHandCases")]
        public void TestIsThreeOfAKindWithNoThreeOfAKindHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        //TestIsThreeOfAKindWithIsValidCheckerTests
        [TestCaseSource("TestIsValidHandCheckerWithIncorrectHandCases")]
        public void TestIsThreeOfAKindWithIncorrectHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        [TestCaseSource("TestFullHouseWithFullHouseHandsCases")]
        public void TestFullHouseWithFullHouseHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFullHouse(hand));
        }

        //TestIsFullHouseWithCorrectHandsButNoThreeOfAKind
        [TestCaseSource("TestIsValidHandCheckerWithCorrectHandCases")]
        public void TestIsFullHouseWithNoFullHouseHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        //TestIsFullHouseWithIsValidCheckerTests
        [TestCaseSource("TestIsValidHandCheckerWithIncorrectHandCases")]
        public void TestIsFullHouseWithIncorrectHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        [TestCaseSource("TestIsStraightWitStraightHandsCases")]
        public void TestIsStraightWithStraightHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsStraight(hand));
        }

        //TestIsStraightWithCorrectHandsButNoStraightHands
        [TestCaseSource("TestIsValidHandCheckerWithCorrectHandCases")]
        public void TestIsStraightWithNoStraightHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraight(hand));
        }

        //TestIsStraightWithIsValidCheckerTests
        [TestCaseSource("TestIsValidHandCheckerWithIncorrectHandCases")]
        public void TestIsStraightWithIncorrectHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraight(hand));
        }

        [TestCaseSource("TestIsStraightFlushWithStraightFlushHandsCases")]
        public void TestIsStraightFlushWithStraightFlushHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsStraightFlush(hand));
        }

        //TestIsStraightFlushWithCorrectHandsButNoStraightFlushHands
        [TestCaseSource("TestIsValidHandCheckerWithCorrectHandCases")]
        public void TestIsStraightFlushWithNoStraightFlushHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        //TestIsStraightFlushWithIsValidCheckerTests
        [TestCaseSource("TestIsValidHandCheckerWithIncorrectHandCases")]
        public void TestIsStraightFlushWithIncorrectHands(Hand hand)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        //-----------------------------------------------
        //Test comparing of cards

        public static IEnumerable<TestCaseData> TestCompareHandsCases
        {
            get
            {
                yield return new TestCaseData(
                    new Hand(
                       new List<ICard>()
                       {
                           new Card(CardFace.Ace, CardSuit.Clubs),
                           new Card(CardFace.Eight, CardSuit.Clubs),
                           new Card(CardFace.Four, CardSuit.Diamonds),
                           new Card(CardFace.Ace, CardSuit.Spades),
                           new Card(CardFace.Queen, CardSuit.Clubs),
                       }
                    ),
                    new Hand(
                       new List<ICard>()
                       {
                           new Card(CardFace.Ace, CardSuit.Clubs),
                           new Card(CardFace.Eight, CardSuit.Clubs),
                           new Card(CardFace.Four, CardSuit.Diamonds),
                           new Card(CardFace.King, CardSuit.Spades),
                           new Card(CardFace.Queen, CardSuit.Clubs),
                       }
                    ),
                    -1
                );
                yield return new TestCaseData(
                    new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                }),
                   new Hand(
                  new List<ICard>()
                  {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Clubs),
                  new Card(CardFace.King, CardSuit.Diamonds),
                  new Card(CardFace.Ten, CardSuit.Spades),
                  new Card(CardFace.Jack, CardSuit.Hearts),
                }),
                    1
                );
                yield return new TestCaseData(
                    new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                }),
                      new Hand(new List<ICard>()
                {
                  new Card(CardFace.Ace, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Clubs),
                  new Card(CardFace.Ace, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                  new Card(CardFace.King, CardSuit.Hearts),
                }),
                    0
                );
            }
        }

        [TestCaseSource("TestCompareHandsCases")]
        public void TestCompareHands(Hand firstHand, Hand secondHand, int result)
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(result, checker.CompareHands(firstHand, secondHand));
        }
    }
}
