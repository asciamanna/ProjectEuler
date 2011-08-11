using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Card {
    public Card(CardRank cardRank, CardSuit cardSuit) {
      Rank = cardRank;
      Suit = cardSuit;
    }
    public CardSuit Suit { get; set; }
    public CardRank Rank { get; set; }

    public static CardSuit GetSuit(char c) {
      if (char.ToLower(c) == 'c') {
        return CardSuit.Clubs;
      }
      if (char.ToLower(c) == 'd') {
        return CardSuit.Diamonds;
      }
      if (char.ToLower(c) == 'h') {
        return CardSuit.Hearts;
      }
      if (char.ToLower(c) == 's') {
        return CardSuit.Spades;
      }
      throw new ArgumentException("Invalid card suit");
    }

    public static CardRank GetRank(char c) {
      if (c == '2') {
        return CardRank.Two;
      }
      if (c == '3') {
        return CardRank.Three;
      }
      if (c == '4') {
        return CardRank.Four;
      }
      if (c == '5') {
        return CardRank.Five;
      }
      if (c == '6') {
        return CardRank.Six;
      }
      if (c == '7') {
        return CardRank.Seven;
      }
      if (c == '8') {
        return CardRank.Eight;
      }
      if (c == '9') {
        return CardRank.Nine;
      }
      if (char.ToUpper(c) == 'T') {
        return CardRank.Ten;
      }
      if (char.ToUpper(c) == 'J') {
        return CardRank.Jack;
      }
      if (char.ToUpper(c) == 'Q') {
        return CardRank.Queen;
      }
      if (char.ToUpper(c) == 'K') {
        return CardRank.King;
      }
      if (char.ToUpper(c) == 'A') {
        return CardRank.Ace;
      }
      throw new ArgumentException("Invalid card rank");
    }
  }

  public enum CardSuit {
    Clubs,
    Spades,
    Hearts,
    Diamonds
  }

  public enum CardRank {
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13,
    Ace = 14
  }
}
