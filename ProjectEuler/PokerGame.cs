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
      //if two players have a royal flush officially they should split the pot.  we're going to
      //skip that possibility for the game.  
      if (hand1.IsRoyalFlush()) return new HandResult(hand1.Player, HandRankResult.Royal_Flush);
      if (hand2.IsRoyalFlush()) return new HandResult(hand2.Player, HandRankResult.Royal_Flush);

      if (hand1.IsStraightFlush() && hand2.IsStraightFlush()) {
        return hand1.RankHighCard > hand2.RankHighCard ? new HandResult(hand1.Player, HandRankResult.Straight_Flush) :
          new HandResult(hand2.Player, HandRankResult.Straight_Flush);
      }
      if (hand1.IsStraightFlush()) return new HandResult(hand1.Player, HandRankResult.Straight_Flush);
      if (hand2.IsStraightFlush()) return new HandResult(hand2.Player, HandRankResult.Straight_Flush);

      if (hand1.IsFourOfAKind() && hand2.IsFourOfAKind()) {
        return hand1.RankHighCard > hand2.RankHighCard ? new HandResult(hand1.Player, HandRankResult.Four_Of_A_Kind) :
          new HandResult(hand2.Player, HandRankResult.Four_Of_A_Kind);
      }

      if (hand1.IsFourOfAKind()) return new HandResult(hand1.Player, HandRankResult.Four_Of_A_Kind);
      if (hand2.IsFourOfAKind()) return new HandResult(hand2.Player, HandRankResult.Four_Of_A_Kind);

      if (hand1.IsFullHouse() && hand2.IsFullHouse()) {
        return hand1.RankHighCard > hand2.RankHighCard ? new HandResult(hand1.Player, HandRankResult.Full_House) :
          new HandResult(hand2.Player, HandRankResult.Full_House);
      }

      if (hand1.IsFullHouse()) return new HandResult(hand1.Player, HandRankResult.Full_House);
      if (hand2.IsFullHouse()) return new HandResult(hand2.Player, HandRankResult.Full_House);

      if (hand1.IsFlush() && hand2.IsFlush()) {
        return hand1.RankHighCard > hand2.RankHighCard ? new HandResult(hand1.Player, HandRankResult.Flush) :
          new HandResult(hand2.Player, HandRankResult.Flush);
      }

      if (hand1.IsFlush()) return new HandResult(hand1.Player, HandRankResult.Flush);
      if (hand2.IsFlush()) return new HandResult(hand2.Player, HandRankResult.Flush);

      if (hand1.IsStraight() && hand2.IsStraight()) {
        return hand1.RankHighCard > hand2.RankHighCard ? new HandResult(hand1.Player, HandRankResult.Straight) :
          new HandResult(hand2.Player, HandRankResult.Straight);
      }

      if (hand1.IsStraight()) return new HandResult(hand1.Player, HandRankResult.Straight);
      if (hand2.IsStraight()) return new HandResult(hand2.Player, HandRankResult.Straight);

      if (hand1.IsThreeOfAKind() && hand2.IsThreeOfAKind()) {
        return hand1.RankHighCard > hand2.RankHighCard ? new HandResult(hand1.Player, HandRankResult.Three_Of_A_Kind) :
          new HandResult(hand2.Player, HandRankResult.Three_Of_A_Kind);
      }

      if (hand1.IsThreeOfAKind()) return new HandResult(hand1.Player, HandRankResult.Three_Of_A_Kind);
      if (hand2.IsThreeOfAKind()) return new HandResult(hand2.Player, HandRankResult.Three_Of_A_Kind);

      if (hand1.IsTwoPairs() && hand2.IsTwoPairs()) {
        return hand1.RankHighCard > hand2.RankHighCard ? new HandResult(hand1.Player, HandRankResult.Two_Pairs) :
          new HandResult(hand2.Player, HandRankResult.Two_Pairs);
      }

      if (hand1.IsTwoPairs()) return new HandResult(hand1.Player, HandRankResult.Two_Pairs);
      if (hand2.IsTwoPairs()) return new HandResult(hand2.Player, HandRankResult.Two_Pairs);

      if (hand1.IsOnePair() && hand2.IsOnePair()) {
        return hand1.RankHighCard > hand2.RankHighCard ? new HandResult(hand1.Player, HandRankResult.One_Pair) :
          new HandResult(hand2.Player, HandRankResult.One_Pair);
      }

      if (hand1.IsOnePair()) return new HandResult(hand1.Player, HandRankResult.One_Pair);
      if (hand2.IsOnePair()) return new HandResult(hand2.Player, HandRankResult.One_Pair);

      return DeterminHighCard();
    }

    HandResult DeterminHighCard() {
      int n = 1;
      while (n <= 5) {
        if (hand1.HandHighCard(n) != hand2.HandHighCard(n)) {
          return hand1.HandHighCard(1) > hand2.HandHighCard(1) ? new HandResult(hand1.Player, HandRankResult.High_Card) :
            new HandResult(hand2.Player, HandRankResult.High_Card);
        }
        n++;
      }
      throw new InvalidOperationException("Two Players Cannot have the same hand");
    }
    //HandResult HandWinningStrategy(Func<bool> hand1Func, Func<bool> hand2Func, HandRankResult result) {
    //  if (hand1Func() && hand2Func()) {
    //    return hand1.RankHighCard > hand2.RankHighCard ? new HandResult(hand1.Player, result) :
    //      new HandResult(hand2.Player, HandRankResult.Straight_Flush);
    //  }
    //  if (hand1Func()) return new HandResult(hand1.Player, result);
    //  if (hand2Func()) return new HandResult(hand2.Player, result);
    //}
    // HandResult DetermineWinningHand
  }
}
