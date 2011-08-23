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
    
    [Test]
    public void BothPlayers_Straight_Flush_HighRank_Wins() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateStraightFlushHandHighRank10("Player1"),
                                    PokerHandTestHelper.CreateStraightFlushHandHighRankJack("Player2"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual("Player2", result.WinningPlayer);
      Assert.AreEqual(HandRankResult.Straight_Flush, result.RankResult);
    }

    [Test]
    public void FourOfAKind_Beats_Full_House() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateFourOfAKindHand("John"),
                                    PokerHandTestHelper.CreateFullHouseHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Four_Of_A_Kind, result.RankResult);
      Assert.AreEqual("John", result.WinningPlayer);
    }

    [Test]
    public void BothPlayers_Four_Of_A_Kind_HighRank_Wins() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateFourOfAKindFivesHand("John"),
                                    PokerHandTestHelper.FourOfAKindJacksHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Four_Of_A_Kind, result.RankResult);
      Assert.AreEqual("Bob", result.WinningPlayer);
    }

    [Test]
    public void FullHouse_Beats_Flush() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateFlushHand("John"),
                                    PokerHandTestHelper.CreateFullHouseHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Full_House, result.RankResult);
      Assert.AreEqual("Bob", result.WinningPlayer);
    }

    [Test]
    public void BothPlayers_Full_House_HighRank_Wins() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateFullHouse3Fives2NinesHand("John"),
                                    PokerHandTestHelper.CreateFullHouse3Jacks2FoursHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Full_House, result.RankResult);
      Assert.AreEqual("Bob", result.WinningPlayer);
    }
    
  }
}
