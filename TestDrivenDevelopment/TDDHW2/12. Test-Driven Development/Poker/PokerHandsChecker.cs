using System;
using System.Collections.Generic;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (i != j && !(hand.Cards[i].Face != hand.Cards[j].Face || hand.Cards[i].Suit != hand.Cards[j].Suit))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            if (!IsValidHand(hand))
            {
                return false;
            }

            if (IsStraight(hand) && IsFlush(hand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            if (!IsValidHand(hand))
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                int count = 0;

                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (i != j && hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        count++;
                    }
                }

                if (count == 3)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            if (!IsValidHand(hand))
            {
                return false;
            }

            if (IsThreeOfAKind(hand) && IsOnePair(hand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFlush(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            if (!IsValidHand(hand))
            {
                return false;
            }

            CardSuit suit = hand.Cards[0].Suit;

            foreach (var item in hand.Cards)
            {
                if (item.Suit != suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            if (!IsValidHand(hand))
            {
                return false;
            }

            List<int> numbers = new List<int>();

            foreach (var item in hand.Cards)
            {
                switch (item.Face)
                {
                    case CardFace.Two : numbers.Add(0); break;
                    case CardFace.Three: numbers.Add(1); break;
                    case CardFace.Four: numbers.Add(2); break;
                    case CardFace.Five: numbers.Add(3); break;
                    case CardFace.Six: numbers.Add(4); break;
                    case CardFace.Seven: numbers.Add(5); break;
                    case CardFace.Eight: numbers.Add(6); break;
                    case CardFace.Nine: numbers.Add(7); break;
                    case CardFace.Ten: numbers.Add(8); break;
                    case CardFace.Jack: numbers.Add(9); break;
                    case CardFace.Queen: numbers.Add(10); break;
                    case CardFace.King: numbers.Add(11); break;
                    case CardFace.Ace: numbers.Add(12); break;
                }
            }

            numbers.Sort();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (!(numbers[i] == numbers[i - 1] + 1))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            if (!IsValidHand(hand))
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                int count = 0;

                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (i != j && hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsTwoPair(IHand hand)
        { 
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            if (!IsValidHand(hand))
            {
                return false;
            }

            HashSet<int> set = new HashSet<int>();
            
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                int count = 0;
               

                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (i != j && hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        count++;
                        set.Add(j);
                        set.Add(i);
                    }
                }

                if (count == 1 && set.Count == 4)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsOnePair(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            if (!IsValidHand(hand))
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                int count = 0;

                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (i != j && hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            if (!IsValidHand(hand))
            {
                return false;
            }

            return true;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {

            int PowerOfFirstHand = 0, PowerOfSecondHand = 0;

            PowerOfFirstHand = PowerOfHand(firstHand);
            PowerOfSecondHand = PowerOfHand(secondHand);

            if (PowerOfFirstHand > PowerOfSecondHand)
            {
                return -1;

            }else if (PowerOfFirstHand < PowerOfSecondHand)
            {
                return 1;

            }else{
                return 0;
            }
        }

        private int PowerOfHand(IHand hand)
        {
            if (IsStraightFlush(hand))
            {
                return 9;
            }

            if (IsFourOfAKind(hand))
            {
                return 8;
            }

            if (IsFullHouse(hand))
            {
                return 7;
            }

            if (IsFlush(hand))
            {
                return 6;
            }

            if (IsStraight(hand))
            {
                return 5;
            }

            if (IsThreeOfAKind(hand))
            {
                return 4;
            }

            if (IsTwoPair(hand))
            {
                return 3;
            }

            if (IsOnePair(hand))
            {
                return 2;
            }

            if (IsHighCard(hand))
            {
                return 1;
            }

            return -10;
        }
    }
}
