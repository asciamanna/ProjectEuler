﻿using System;
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
    HandRankResult handResult = HandRankResult.Undefined;

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
      DeterineHandRankings();
      DetermineRankHighCard();
    }

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

    Dictionary<int, CardRank> BuildRanksInHandLookup() {
      var numberOfRanksInHand = new Dictionary<int, CardRank>();
      foreach (var cardRank in Cards.Select(c => c.Rank).Distinct()) {
        numberOfRanksInHand.Add(Cards.Count(c => c.Rank == cardRank), cardRank);
      }
      return numberOfRanksInHand;
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

    void DeterineHandRankings() {
      if (IsRoyalFlush()) {
        handResult = HandRankResult.Royal_Flush;
      }
      else if (IsStraightFlush()) {
        handResult = HandRankResult.Straight_Flush;
      }
      else if (IsFourOfAKind()) {
        handResult = HandRankResult.Four_Of_A_Kind;
      }
      else if (IsFullHouse()) {
        handResult = HandRankResult.Full_House;
      }
      else if (IsFlush()) {
        handResult = HandRankResult.Flush;
      }
      else if (IsStraight()) {
        handResult = HandRankResult.Straight;
      }
      else if (IsThreeOfAKind()) {
        handResult = HandRankResult.Three_Of_A_Kind;
      }
      else if (IsTwoPairs()) {
        handResult = HandRankResult.Two_Pairs;
      }
      else if (IsOnePair()) {
        handResult = HandRankResult.One_Pair;
      }
      else {
        handResult = HandRankResult.High_Card;
      }
    }

    //TODO: Make all Is* methods private.
    //TODO: all places that call Is* methods to use HandResultProperty.
    //TODO: continue writing poker game tests to flesh out rest of game.
    void DetermineRankHighCard() {
      switch (handResult) {
        case HandRankResult.Royal_Flush:
          rankedHighCard = CardRank.Ace;
          break;
        case HandRankResult.Straight_Flush:
        case HandRankResult.Straight:
        case HandRankResult.Flush:
          rankedHighCard = Cards.Select(c => c.Rank).Max();
          break;
        case HandRankResult.Full_House:
        case HandRankResult.Three_Of_A_Kind:
          rankedHighCard = GetRankedHighCardForThreeOfAKind();
          break;
        case HandRankResult.Four_Of_A_Kind:
          rankedHighCard = GetRankedHighCardForFourOfAKind();
          break;
        case HandRankResult.Two_Pairs:
          rankedHighCard = GetRankedHighCardForTwoPairs();
          break;
        case HandRankResult.One_Pair:
          rankedHighCard = GetRankedHighCardForOnePair();
          break;
        case HandRankResult.High_Card:
          rankedHighCard = HandHighCard(1);
          break;
        default:
          throw new ArgumentException("Unknown Hand Rank");
      }
    }

    CardRank GetRankedHighCardForOnePair() {
      var grouping = from card in Cards
                     group card by card.Rank;
      return grouping.Where(g => g.Count() == 2).First().Key;
    }

    CardRank GetRankedHighCardForTwoPairs() {
      var grouping = from card in Cards
                     group card by card.Rank;
      return grouping.Where(g => g.Count() == 2).Max(g => g.First().Rank);
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
        return suitLookup.Count == 1;
      }
    }

    public bool IsFourOfAKind() {
      var grouping = from card in Cards
                     group card by card.Rank;
      return grouping.Where(g => g.Count() == 4).Count() == 1;
    }

    public CardRank HandHighCard(int cardNumber) {
      if (cardNumber < 1 || cardNumber > 5) throw new ArgumentException();
      return Cards.Select(c => c.Rank).OrderByDescending(cr => (int)cr).ToList()[cardNumber - 1];
    }

    public bool IsThreeOfAKind() {
      return rankLookup.Count == 3 && rankLookup.Values.Max(v => v == 3);
    }

    public bool IsTwoPairs() {
      return rankLookup.Count == 3 && rankLookup.Values.Max(v => v == 2);
    }

    public bool IsOnePair() {
      return rankLookup.Count == 4 && rankLookup.Values.Max(v => v == 2);
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
      rankedHighCard = rankLookup.Keys.Max();
      return true;
    }

    public bool IsStraightFlush() {
      //can't use AllCardsSameSuit this would return true for Royal Flushes
      if (IsStraight() && IsFlush()) {
        rankedHighCard = rankLookup.Keys.Max();
        return true;
      }
      return false;
    }

    public CardRank RankHighCard {
      get {
        return rankedHighCard;
      }
    }

    public HandRankResult HandResult {
      get {
        return handResult;
      }
    }

    CardRank GetRankedHighCardForThreeOfAKind() {
      var grouping = from card in Cards
                     group card by card.Rank;
      return grouping.Where(g => g.Count() == 3).Select(g => g.Key).First();
    }

    CardRank GetRankedHighCardForFourOfAKind() {
      var grouping = from card in Cards
                     group card by card.Rank;
      return grouping.Where(g => g.Count() == 4).Select(g => g.Key).First();
    }
  }
}
