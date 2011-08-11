using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class PokerHand {
    public PokerHand(string player, IEnumerable<Card> cards) {
      Player = player;
      Cards = cards;
      if (cards.Count() > 5) {
        throw new ArgumentException("Only 5 cards per poker hand");
      }
    }
    public string Player { get; private set; }
    
    public IEnumerable<Card> Cards { get; private set; }

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
  }
}
