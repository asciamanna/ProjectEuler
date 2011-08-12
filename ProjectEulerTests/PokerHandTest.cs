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
    public void FourOfAKind() {
      var hand = PokerHandTestHelper.CreateFourOfAKindHand("Kevin");
      Assert.IsTrue(hand.IsFourOfAKind());
    }

    //TODO: Left Off Here
    [Test]
    public void ThreeOfAKind() {
      var hand = PokerHandTestHelper.CreateThreeOfAKindHand("Lily");
    }
  }
}
