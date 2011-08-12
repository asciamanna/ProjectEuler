using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class PokerHand {
    HashSet<CardRank> rankSet;

    public PokerHand(string player, IEnumerable<Card> cards) {
      Player = player;
      Cards = cards;
      if (cards.Count() > 5) {
        throw new ArgumentException("Only 5 cards per poker hand");
      }
      rankSet = new HashSet<CardRank>();
      BuildRankSet();
    }
    public string Player { get; private set; }
    
    public IEnumerable<Card> Cards { get; private set; }

    void BuildRankSet() {
      var rankSet = new HashSet<CardRank>();
      foreach (var rank in Cards.Select(c => c.Rank)) {
        rankSet.Add(rank);
      }
    }

    public bool IsRoyalFlush() {
      return Cards.Any(c => c.Rank == CardRank.Ten) &&
          Cards.Any(c => c.Rank == CardRank.Jack) &&
          Cards.Any(c => c.Rank == CardRank.Queen) &&
          Cards.Any(c => c.Rank == CardRank.King) &&
          Cards.Any(c => c.Rank == CardRank.Ace) && AllCardsSameSuit; 
    }

    bool AllCardsSameSuit {
      get {
        var suitSet = new HashSet<CardSuit>();
        foreach (var suit in Cards.Select(c => c.Suit)) {
          suitSet.Add(suit);
        }
        return suitSet.Count == 1;
      }
    }

    public bool IsFourOfAKind() {
      return rankSet.Count == 2;
    }

    public CardRank HighCard {
      get {
        return Cards.Max(c => c.Rank);
      }
    }
  }
}
