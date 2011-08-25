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


    [Test]
    public void Flush_Beats_Straight() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateStraightHand("John"),
                                    PokerHandTestHelper.CreateFlushHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Flush, result.RankResult);
      Assert.AreEqual("Bob", result.WinningPlayer);
    }

    [Test]
    public void BothPlayers_Flush_HighRank_Wins() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateFlushHighJackHand("John"),
                                    PokerHandTestHelper.CreateFlushHighQueenHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Flush, result.RankResult);
      Assert.AreEqual("Bob", result.WinningPlayer);
    }

    [Test]
    public void Straight_Beats_Three_Of_A_Kind() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateStraightHand("John"),
                                    PokerHandTestHelper.CreateThreeOfAKindHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Straight, result.RankResult);
      Assert.AreEqual("John", result.WinningPlayer);
    }

    [Test]
    public void BothPlayers_Straight_HighRank_Wins() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateStraightHighJackHand("John"),
                                    PokerHandTestHelper.CreateStraightHighQueenHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Straight, result.RankResult);
      Assert.AreEqual("Bob", result.WinningPlayer);
    }

    [Test]
    public void Three_Of_A_Kind_Beats_Two_Pairs() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateTwoPairsHand("John"),
                                    PokerHandTestHelper.CreateThreeOfAKindHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Three_Of_A_Kind, result.RankResult);
      Assert.AreEqual("Bob", result.WinningPlayer);
    }

    [Test]
    public void BothPlayers_Three_Of_A_Kind_HighRank_Wins() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateThreeOfAKindSevensHand("John"),
                                    PokerHandTestHelper.CreateThreeOfAKindFoursHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Three_Of_A_Kind, result.RankResult);
      Assert.AreEqual("John", result.WinningPlayer);
    }

    [Test]
    public void Two_Pairs_Beats_One_Pair() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateTwoPairsHand("John"),
                                    PokerHandTestHelper.CreateOnePairHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Two_Pairs, result.RankResult);
      Assert.AreEqual("John", result.WinningPlayer);
    }

    [Test]
    public void BothPlayers_Two_Pairs_HighRank_Wins() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateTwoPairsFivesSevensHand("John"),
                                    PokerHandTestHelper.CreateTwoPairsSixesJacksHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.Two_Pairs, result.RankResult);
      Assert.AreEqual("Bob", result.WinningPlayer);
    }

    [Test]
    public void OnePair_Beats_HighCard() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateHighCardNineHand("John"),
                                    PokerHandTestHelper.CreateOnePairHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.One_Pair, result.RankResult);
      Assert.AreEqual("Bob", result.WinningPlayer);
    }

    [Test]
    public void BothPlayers_One_Pair_HighRank_Wins() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateOnePairTensHand("John"),
                                    PokerHandTestHelper.CreateOnePairAcesHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.One_Pair, result.RankResult);
      Assert.AreEqual("Bob", result.WinningPlayer);
    }

    [Test]
    public void First_High_Card_Wins() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateHighCardNineHand("John"),
                                   PokerHandTestHelper.CreateHighCardAceHand("Bob"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.High_Card, result.RankResult);
      Assert.AreEqual("Bob", result.WinningPlayer);
    }

    [Test]
    public void Second_High_Card_Wins() {
      var pokerGame = new PokerGame(PokerHandTestHelper.CreateHighCardNineSixHand("Bob"),
                                   PokerHandTestHelper.CreateHighCardNineEightHand("John"));
      var result = pokerGame.PlayHand();
      Assert.AreEqual(HandRankResult.High_Card, result.RankResult);
      Assert.AreEqual("John", result.WinningPlayer);
    }

  }
}
