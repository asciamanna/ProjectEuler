using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class HandResult {
    readonly string winningPlayer;
    readonly HandRankResult rankResult;
    public HandResult(string player, HandRankResult result) {
      this.winningPlayer = player;
      this.rankResult = result;
    }

    public string WinningPlayer { get { return winningPlayer; } }
    public HandRankResult RankResult { get { return rankResult; } }
  }

  public enum HandRankResult {
    Undefined,
    High_Card,
    One_Pair,
    Two_Pairs,
    Three_Of_A_Kind,
    Straight,
    Flush,
    Full_House,
    Four_Of_A_Kind,
    Straight_Flush,
    Royal_Flush
  }
}
