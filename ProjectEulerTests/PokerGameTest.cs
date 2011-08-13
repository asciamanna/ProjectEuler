using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class PokerGameTest {
    [Test]
    public void RoyalFlush_beats_StraightFlush() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateStraightFlushHand("Player1"),
                                          PokerHandTestHelper.CreateRoyalFlushHand("Player2"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual("Player2", result.WinningPlayer);
      Assert.AreEqual(HandRankResult.Royal_Flush, result.RankResult);
    }

    [Test]
    public void StraightFlush_beats_FourOfAKind() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateStraightFlushHand("Player1"),
                                          PokerHandTestHelper.CreateFourOfAKindHand("Player2"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual("Player1", result.WinningPlayer);
      Assert.AreEqual(HandRankResult.Straight_Flush, result.RankResult);
    }
    //TODO: Determine Highest Rank
    [Test]
    public void BothPlayers_Straight_Flush_HighRank_Wins() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateStraightFlushHandHighRank10("Player1"),
                                    PokerHandTestHelper.CreateStraightFlushHandHighRankJack("Player2"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual("Player2", result.WinningPlayer);
      Assert.AreEqual(HandRankResult.Straight_Flush, result.RankResult);
    }
    
  }
}
