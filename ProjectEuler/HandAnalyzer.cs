using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class HandAnalyzer {
    readonly PokerHand hand1;
    readonly PokerHand hand2;
    readonly int numberOfSuitsInHand;
    List<CardRank> RanksOfPairs = new List<CardRank>();
    CardRank? RankForThreeOfAKind;
    CardRank? RankForFourOfAKind;

    public HandAnalyzer(PokerHand hand1, PokerHand hand2) {
      this.hand1 = hand1;
      this.hand2 = hand2;
    }
    public HandResult CalculateWinner() {
      return new HandResult(string.Empty, HandRankResult.Two_Pairs);
    }
  }
}
