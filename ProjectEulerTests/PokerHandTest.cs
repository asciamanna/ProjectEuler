using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class PokerHandTest {
    [Test]
    public void IsRoyalFlush() {
      var hand = CreateRoyalFlushHand("Timmay");
      Assert.IsTrue(hand.IsRoyalFlush());
    }

    [Test]
    public void IsRoyalFlush_Fails() {
      var hand = CreateOnePairHand("Fester");
      Assert.IsFalse(hand.IsRoyalFlush());
    }

    [Test]
    public void HighCard() {
      var hand = CreateOnePairHand("Itt");
      Assert.AreEqual(CardRank.King, hand.HighCard);
    }

    //TODO: Four of A Kind test
    [Test]
    public void FourOfAKind() {

    }

    PokerHand CreateRoyalFlushHand(string playerName) {
      var cards = new List<Card> { 
        new Card(CardRank.Ten, CardSuit.Clubs),
        new Card(CardRank.Jack, CardSuit.Clubs),
        new Card(CardRank.Queen, CardSuit.Clubs),
        new Card(CardRank.Ace, CardSuit.Clubs),
        new Card(CardRank.King, CardSuit.Clubs) 
      };
      return new PokerHand(playerName, cards);
    }

    PokerHand CreateOnePairHand(string playerName) {
      var cards = new List<Card> { 
        new Card(CardRank.Five, CardSuit.Diamonds),
        new Card(CardRank.Jack, CardSuit.Hearts),
        new Card(CardRank.Six, CardSuit.Clubs),
        new Card(CardRank.Five, CardSuit.Spades),
        new Card(CardRank.King, CardSuit.Clubs) 
      };
      return new PokerHand(playerName, cards);
    }
  }
}
