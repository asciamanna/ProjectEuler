using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class PokerGame {
    readonly PokerHand hand1;
    readonly PokerHand hand2;

    public PokerGame(PokerHand hand1, PokerHand hand2) {
      this.hand1 = hand1;
      this.hand2 = hand2;
    }

    public HandResult PlayHand() {
      if (hand1.IsRoyalFlush()) return new HandResult(hand1.Player, HandRankResult.Royal_Flush);
      if (hand2.IsRoyalFlush()) return new HandResult(hand2.Player, HandRankResult.Royal_Flush);

      if (hand1.IsStraightFlush()) return new HandResult(hand1.Player, HandRankResult.Straight_Flush);
      if (hand2.IsStraightFlush()) return new HandResult(hand2.Player, HandRankResult.Straight_Flush);
      return new HandResult("UGH", HandRankResult.High_Card);
    }
  }
}
