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

    internal static object CreateThreeOfAKindHand(string p) {
      throw new NotImplementedException();
    }
  }
   
}
