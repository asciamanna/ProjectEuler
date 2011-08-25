using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;

namespace ProjectEulerTests {
  public static class PokerHandTestHelper {
    public static PokerHand CreateRoyalFlushHand(string playerName) {
      var cards = new List<Card> { 
        new Card(CardRank.Ten, CardSuit.Clubs),
        new Card(CardRank.Jack, CardSuit.Clubs),
        new Card(CardRank.Queen, CardSuit.Clubs),
        new Card(CardRank.Ace, CardSuit.Clubs),
        new Card(CardRank.King, CardSuit.Clubs) 
      };
      return new PokerHand(playerName, cards);
    }

    public static PokerHand CreateOnePairHand(string playerName) {
      var cards = new List<Card> { 
        new Card(CardRank.Five, CardSuit.Diamonds),
        new Card(CardRank.Jack, CardSuit.Hearts),
        new Card(CardRank.Six, CardSuit.Clubs),
        new Card(CardRank.Five, CardSuit.Spades),
        new Card(CardRank.King, CardSuit.Clubs) 
      };
      return new PokerHand(playerName, cards);
    }

    public static PokerHand CreateFourOfAKindHand(string playerName) {
      var cards = new List<Card> { 
        new Card(CardRank.Five, CardSuit.Diamonds),
        new Card(CardRank.Five, CardSuit.Hearts),
        new Card(CardRank.Seven, CardSuit.Clubs),
        new Card(CardRank.Five, CardSuit.Spades),
        new Card(CardRank.Five, CardSuit.Clubs) 
      };
      return new PokerHand(playerName, cards);
    }

    public static PokerHand CreateThreeOfAKindHand(string playerName) {
      var cards = new List<Card> { 
        new Card(CardRank.Three, CardSuit.Diamonds),
        new Card(CardRank.Five, CardSuit.Hearts),
        new Card(CardRank.Three, CardSuit.Clubs),
        new Card(CardRank.Six, CardSuit.Spades),
        new Card(CardRank.Three, CardSuit.Hearts) 
      };
      return new PokerHand(playerName, cards);
    }

    public static PokerHand CreateTwoPairsHand(string playerName) {
      var cards = new List<Card> { 
        new Card(CardRank.King, CardSuit.Diamonds),
        new Card(CardRank.King, CardSuit.Hearts),
        new Card(CardRank.Jack, CardSuit.Clubs),
        new Card(CardRank.Jack, CardSuit.Spades),
        new Card(CardRank.Four, CardSuit.Hearts) 
      };
      return new PokerHand(playerName, cards);
    }

    public static PokerHand CreateFullHouseHand(string playerName) {
      var cards = new List<Card> { 
        new Card(CardRank.King, CardSuit.Diamonds),
        new Card(CardRank.King, CardSuit.Hearts),
        new Card(CardRank.Jack, CardSuit.Clubs),
        new Card(CardRank.Jack, CardSuit.Spades),
        new Card(CardRank.Jack, CardSuit.Hearts) 
      };
      return new PokerHand(playerName, cards);
    }

    public static PokerHand CreateFlushHand(string playerName) {
      var cards = new List<Card> {
        new Card(CardRank.Five, CardSuit.Diamonds),
        new Card(CardRank.Eight, CardSuit.Diamonds),
        new Card(CardRank.Two, CardSuit.Diamonds),
        new Card(CardRank.King, CardSuit.Diamonds),
        new Card(CardRank.Seven, CardSuit.Diamonds)
      };
      return new PokerHand(playerName, cards);
    }

    public static PokerHand CreateStraightHand(string playerName) {
      var cards = new List<Card> {
        new Card(CardRank.Five, CardSuit.Clubs),
        new Card(CardRank.Six, CardSuit.Diamonds),
        new Card(CardRank.Eight, CardSuit.Hearts),
        new Card(CardRank.Nine, CardSuit.Spades),
        new Card(CardRank.Seven, CardSuit.Spades)
      };
      return new PokerHand(playerName, cards);
    }

    public static PokerHand CreateStraightFlushHand(string playerName) {
      var cards = new List<Card> {
        new Card(CardRank.Five, CardSuit.Clubs),
        new Card(CardRank.Six, CardSuit.Clubs),
        new Card(CardRank.Eight, CardSuit.Clubs),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Seven, CardSuit.Clubs)
      };
      return new PokerHand(playerName, cards);
    }

    public static PokerHand CreateStraightFlushHandHighRank10(string playerName) {
      var cards = new List<Card> {
        new Card(CardRank.Ten, CardSuit.Clubs),
        new Card(CardRank.Six, CardSuit.Clubs),
        new Card(CardRank.Eight, CardSuit.Clubs),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Seven, CardSuit.Clubs)
      };
      return new PokerHand(playerName, cards);
    }

    public static PokerHand CreateStraightFlushHandHighRankJack(string playerName) {
      var cards = new List<Card> {
        new Card(CardRank.Ten, CardSuit.Clubs),
        new Card(CardRank.Jack, CardSuit.Clubs),
        new Card(CardRank.Eight, CardSuit.Clubs),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Seven, CardSuit.Clubs)
      };
      return new PokerHand(playerName, cards);
    }

    internal static PokerHand CreateFourOfAKindFivesHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Five, CardSuit.Clubs),
        new Card(CardRank.Five, CardSuit.Diamonds),
        new Card(CardRank.Ten, CardSuit.Diamonds),
        new Card(CardRank.Five, CardSuit.Hearts),
        new Card(CardRank.Five, CardSuit.Spades)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand FourOfAKindJacksHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Jack, CardSuit.Clubs),
        new Card(CardRank.Jack, CardSuit.Diamonds),
        new Card(CardRank.Queen, CardSuit.Diamonds),
        new Card(CardRank.Jack, CardSuit.Hearts),
        new Card(CardRank.Jack, CardSuit.Spades)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateFullHouse3Fives2NinesHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Five, CardSuit.Clubs),
        new Card(CardRank.Five, CardSuit.Hearts),
        new Card(CardRank.Five, CardSuit.Diamonds),
        new Card(CardRank.Nine, CardSuit.Hearts),
        new Card(CardRank.Nine, CardSuit.Spades)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateFullHouse3Jacks2FoursHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Jack, CardSuit.Clubs),
        new Card(CardRank.Jack, CardSuit.Hearts),
        new Card(CardRank.Jack, CardSuit.Diamonds),
        new Card(CardRank.Four, CardSuit.Hearts),
        new Card(CardRank.Four, CardSuit.Spades)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateFlushHighJackHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Jack, CardSuit.Clubs),
        new Card(CardRank.Four, CardSuit.Clubs),
        new Card(CardRank.Six, CardSuit.Clubs),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Two, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateFlushHighQueenHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Jack, CardSuit.Spades),
        new Card(CardRank.Four, CardSuit.Spades),
        new Card(CardRank.Six, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Spades),
        new Card(CardRank.Queen, CardSuit.Spades)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateStraightHighJackHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Jack, CardSuit.Clubs),
        new Card(CardRank.Ten, CardSuit.Diamonds),
        new Card(CardRank.Eight, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Seven, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateStraightHighQueenHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Jack, CardSuit.Clubs),
        new Card(CardRank.Ten, CardSuit.Diamonds),
        new Card(CardRank.Eight, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Queen, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateThreeOfAKindSevensHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Seven, CardSuit.Clubs),
        new Card(CardRank.Seven, CardSuit.Diamonds),
        new Card(CardRank.Seven, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Queen, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateThreeOfAKindFoursHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Four, CardSuit.Clubs),
        new Card(CardRank.Four, CardSuit.Diamonds),
        new Card(CardRank.Four, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Queen, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateTwoPairsFivesSevensHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Five, CardSuit.Clubs),
        new Card(CardRank.Five, CardSuit.Diamonds),
        new Card(CardRank.Seven, CardSuit.Spades),
        new Card(CardRank.Seven, CardSuit.Clubs),
        new Card(CardRank.Queen, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateTwoPairsSixesJacksHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Jack, CardSuit.Clubs),
        new Card(CardRank.Jack, CardSuit.Diamonds),
        new Card(CardRank.Seven, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Seven, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateHighCardNineHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Two, CardSuit.Clubs),
        new Card(CardRank.Three, CardSuit.Diamonds),
        new Card(CardRank.Seven, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Six, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateOnePairTensHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Ten, CardSuit.Clubs),
        new Card(CardRank.Ten, CardSuit.Diamonds),
        new Card(CardRank.Seven, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Six, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateOnePairAcesHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Two, CardSuit.Clubs),
        new Card(CardRank.Three, CardSuit.Diamonds),
        new Card(CardRank.Ace, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Ace, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateHighCardAceHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Two, CardSuit.Clubs),
        new Card(CardRank.Three, CardSuit.Diamonds),
        new Card(CardRank.Ace, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Six, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }

    internal static PokerHand CreateHighCardNineSixHand(string p) {
       var cards = new List<Card> {
        new Card(CardRank.Two, CardSuit.Clubs),
        new Card(CardRank.Three, CardSuit.Diamonds),
        new Card(CardRank.Five, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Six, CardSuit.Clubs)
      };
       return new PokerHand(p, cards);
    }

    internal static PokerHand CreateHighCardNineEightHand(string p) {
      var cards = new List<Card> {
        new Card(CardRank.Two, CardSuit.Clubs),
        new Card(CardRank.Three, CardSuit.Diamonds),
        new Card(CardRank.Five, CardSuit.Spades),
        new Card(CardRank.Nine, CardSuit.Clubs),
        new Card(CardRank.Eight, CardSuit.Clubs)
      };
      return new PokerHand(p, cards);
    }
  }
   
}
