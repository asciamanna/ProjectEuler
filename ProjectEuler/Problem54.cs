using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem54 : Problem {
    List<PokerHand> player1Hands = new List<PokerHand>();
    List<PokerHand> player2Hands = new List<PokerHand>();

    public Problem54() {
      var pokerHands = File.ReadAllLines(@".\Data\Problem54\poker.txt");
      foreach (var playableHand in pokerHands.ToList()) {
        var cards = playableHand.Split(' ').ToList();
        var player1Cards = cards.Take(5).Select(c => new Card(Card.GetRank(c[0]), Card.GetSuit(c[1])));
        var player2Cards = cards.Skip(5).Take(5).Select(c => new Card(Card.GetRank(c[0]), Card.GetSuit(c[1])));
        player1Hands.Add(new PokerHand("Player One", player1Cards));
        player2Hands.Add(new PokerHand("Player Two", player2Cards));
      }
    }

    public override long Solve() {
      int player1Wins = 0;
      for (int i = 0; i < player1Hands.Count; i++) {
        var winner = new PokerGame(player1Hands[i], player2Hands[i]).PlayHand();
       // Console.WriteLine("Winner of Hand {0}: {1} with {2}", i, winner, "Pair Of Nuts");
        if (winner.WinningPlayer == "Player One") {
          player1Wins++;
        }
      }
      return player1Wins;

    }
  }
}
