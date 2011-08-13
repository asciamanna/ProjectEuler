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
    }

    [Test]
    public void IsRoyalFlush_Fails() {
      var hand = PokerHandTestHelper.CreateOnePairHand("Fester");
      Assert.IsFalse(hand.IsRoyalFlush());
    }

    [Test]
    public void HighCard() {
      var hand = PokerHandTestHelper.CreateOnePairHand("Itt");
      Assert.AreEqual(CardRank.King, hand.HighCard);
    }

    [Test]
    public void SecondHighCard() {
      var hand = PokerHandTestHelper.CreateOnePairHand("Itt");
      Assert.AreEqual(CardRank.Jack, hand.SecondHighCard);
    }

    [Test]
    public void FourOfAKind() {
      var hand = PokerHandTestHelper.CreateFourOfAKindHand("Kevin");
      Assert.IsTrue(hand.IsFourOfAKind());
    }

    [Test]
    public void ThreeOfAKind() {
      var hand = PokerHandTestHelper.CreateThreeOfAKindHand("Lily");
      Assert.IsTrue(hand.IsThreeOfAKind());
      Assert.IsFalse(hand.IsTwoPairs());
      Assert.IsFalse(hand.IsFullHouse());
    }

    [Test]
    public void TwoPairs() {
      var hand = PokerHandTestHelper.CreateTwoPairsHand("Thing");
      Assert.IsTrue(hand.IsTwoPairs());
      Assert.IsFalse(hand.IsThreeOfAKind());
    }

    [Test]
    public void FullHouse() {
      var hand = PokerHandTestHelper.CreateFullHouseHand("Lurch");
      Assert.IsTrue(hand.IsFullHouse());
      Assert.IsFalse(hand.IsThreeOfAKind());
    }

    [Test]
    public void Flush() {
      var hand = PokerHandTestHelper.CreateFlushHand("Ren");
      Assert.IsTrue(hand.IsFlush());
      Assert.IsFalse(hand.IsRoyalFlush());
    }

    [Test]
    public void Straight() {
      var hand = PokerHandTestHelper.CreateStraightHand("Stimpy");
      Assert.IsTrue(hand.IsStraight());
      Assert.IsFalse(hand.IsStraightFlush());
    }

    [Test]
    public void StraightFlush() {
      var hand = PokerHandTestHelper.CreateStraightFlushHand("Sven Hoek");
      Assert.IsTrue(hand.IsStraight());
      Assert.IsTrue(hand.IsStraightFlush());
      Assert.IsFalse(hand.IsRoyalFlush());
    }
  }
}
