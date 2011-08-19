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
      var hand = PokerHandTestHelper.CreateRoyalFlushHand("Timmay");
      Assert.IsTrue(hand.IsRoyalFlush());
      Assert.AreEqual(CardRank.Ace, hand.RankHighCard);
    }

    [Test]
    public void IsRoyalFlush_Fails() {
      var hand = PokerHandTestHelper.CreateOnePairHand("Fester");
      Assert.IsFalse(hand.IsRoyalFlush());
    }

    [Test]
    public void HighCard() {
      var hand = PokerHandTestHelper.CreateOnePairHand("Itt");
      Assert.AreEqual(CardRank.King, hand.HandHighCard(1));
    }

    [Test]
    public void SecondHighCard() {
      var hand = PokerHandTestHelper.CreateOnePairHand("Itt");
      Assert.AreEqual(CardRank.Jack, hand.HandHighCard(2));
    }

    [Test]
    public void FourOfAKind() {
      var hand = PokerHandTestHelper.CreateFourOfAKindHand("Kevin");
      Assert.IsTrue(hand.IsFourOfAKind());
      Assert.AreEqual(CardRank.Five, hand.RankHighCard);
    }

    [Test]
    public void ThreeOfAKind() {
      var hand = PokerHandTestHelper.CreateThreeOfAKindHand("Lily");
      Assert.IsTrue(hand.IsThreeOfAKind());
      Assert.IsFalse(hand.IsTwoPairs());
      Assert.IsFalse(hand.IsFullHouse());
      Assert.AreEqual(CardRank.Three, hand.RankHighCard);
    }

    [Test]
    public void TwoPairs() {
      var hand = PokerHandTestHelper.CreateTwoPairsHand("Thing");
      Assert.IsTrue(hand.IsTwoPairs());
      Assert.IsFalse(hand.IsThreeOfAKind());
      Assert.IsFalse(hand.IsOnePair());
    }

    [Test]
    public void OnePair() {
      var hand = PokerHandTestHelper.CreateOnePairHand("WOOOOO");
      Assert.IsTrue(hand.IsOnePair());
      Assert.IsFalse(hand.IsTwoPairs());
    }

    [Test]
    public void FullHouse() {
      var hand = PokerHandTestHelper.CreateFullHouseHand("Lurch");
      Assert.IsTrue(hand.IsFullHouse());
      Assert.IsFalse(hand.IsThreeOfAKind());
      Assert.AreEqual(CardRank.Jack, hand.RankHighCard);
    }

    [Test]
    public void Flush() {
      var hand = PokerHandTestHelper.CreateFlushHand("Ren");
      Assert.IsTrue(hand.IsFlush());
      Assert.IsFalse(hand.IsRoyalFlush());
      Assert.AreEqual(CardRank.King, hand.RankHighCard);
    }

    [Test]
    public void Straight() {
      var hand = PokerHandTestHelper.CreateStraightHand("Stimpy");
      Assert.IsTrue(hand.IsStraight());
      Assert.IsFalse(hand.IsStraightFlush());
      Assert.AreEqual(CardRank.Nine, hand.RankHighCard);
    }

    [Test]
    public void StraightFlush() {
      var hand = PokerHandTestHelper.CreateStraightFlushHand("Sven Hoek");
      Assert.IsTrue(hand.IsStraight());
      Assert.IsTrue(hand.IsStraightFlush());
      Assert.IsFalse(hand.IsRoyalFlush());
      Assert.AreEqual(CardRank.Nine, hand.RankHighCard);
    }
  }
}
