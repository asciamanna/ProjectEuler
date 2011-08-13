using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class PokerHand {
    Dictionary<CardRank, int> rankLookup;
    //key: rank, value: number of occurrences in hand
    Dictionary<CardSuit, int> suitLookup;
    //key: suit, value: number of occurerences in hand
    CardRank rankedHighCard = CardRank.Undefined;

    public PokerHand(string player, IEnumerable<Card> cards) {
      Player = player;
      Cards = cards;
      if (cards.Count() > 5) {
        throw new ArgumentException("Only 5 cards per poker hand");
      }
      rankLookup = new Dictionary<CardRank, int>();
      BuildRankLookup();
      suitLookup = new Dictionary<CardSuit, int>();
      BuildSuitLookup();
    }
    public string Player { get; private set; }
    
    public IEnumerable<Card> Cards { get; private set; }

    void BuildRankLookup() {
      foreach (var rank in Cards.Select(c => c.Rank)) {
        if (rankLookup.ContainsKey(rank)) {
          rankLookup[rank] = rankLookup[rank]++;
        }
        else {
          rankLookup.Add(rank, Cards.Count(c => c.Rank == rank));
        }
      }
    }

    void BuildSuitLookup() {
      foreach (var suit in Cards.Select(c => c.Suit)) {
        if (suitLookup.ContainsKey(suit)) {
          suitLookup[suit] = suitLookup[suit]++;
        }
        else {
          suitLookup.Add(suit, Cards.Count(c => c.Suit == suit));
        }
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
        return suitLookup.Count == 1;
      }
    }

    public bool IsFourOfAKind() {
      return rankLookup.Count == 2;
    }

    public CardRank HighCard(int cardNumber) {
      if (cardNumber < 1 || cardNumber > 5) throw new ArgumentException();
      return Cards.Select(c => c.Rank).OrderByDescending(cr => (int)cr).ToList()[cardNumber - 1];
    }

    public bool IsThreeOfAKind() {
      return rankLookup.Count == 3 && rankLookup.Values.Max(v => v == 3);
    }

    public bool IsTwoPairs() {
      return rankLookup.Count == 3 && rankLookup.Values.Max(v => v == 2);
    }

    public bool IsFullHouse() {
      return rankLookup.Count == 2 && rankLookup.Values.Max(v => v == 3);
    }

    public bool IsFlush() {
      return AllCardsSameSuit && !IsRoyalFlush();
    }

    public bool IsStraight() {
      var lowestRank = rankLookup.Keys.Min();
      var range = Enumerable.Range(1, 4);
      var currentRank = (int)lowestRank;
      foreach (var index in range) {
        if (!rankLookup.ContainsKey((CardRank)currentRank + index)) return false;
      }
      return true; 
    }

    public bool IsStraightFlush() {
      //can't use AllCardsSameSuit this would return true for Royal Flushes
      return IsStraight() && IsFlush();
    }

    //TODO: implement this.
    public CardRank RankHighCard {
      get {
        throw new NotImplementedException();
      }
    }
  }
}
