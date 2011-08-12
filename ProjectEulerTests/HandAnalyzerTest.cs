using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class HandAnalyzerTest {
    [Test]
    public void Hand1_Wins_With_Royal_Flush() {
      var handAnalyzer = new HandAnalyzer(PokerHandTestHelper.CreateOnePairHand("Player1"), 
                                          PokerHandTestHelper.CreateRoyalFlushHand("Player2"));
      var result = handAnalyzer.CalculateWinner();
      Assert.AreEqual("Player2", result.WinningPlayer);
      Assert.AreEqual(HandRankResult.Royal_Flush, result.RankResult);
    }

    
  }
}
