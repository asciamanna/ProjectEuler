using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace ProjectEuler {
  [EulerProblem(31, "How many different ways can £2 be made using any number of coins?")]
  public enum BritishCoins {
    OnePence = 1,
    TwoPence = 2,
    FivePence = 5,
    TenPence = 10,
    TwentyPence = 20,
    FiftyPence = 50,
    OnePound = 100,
    TwoPound = 200,
  }

  public class Problem31 : Problem {
    int amountToFind;
    public Problem31() : this(200) { }

    public Problem31(int amountToFind) {
      this.amountToFind = amountToFind;
    }

    public override long Solve() {
      
      var allCoins = new List<BritishCoins> { BritishCoins.TwoPound, BritishCoins.OnePound, BritishCoins.FiftyPence,
        BritishCoins.TwentyPence, BritishCoins.TenPence, BritishCoins.FivePence, BritishCoins.TwoPence, BritishCoins.OnePence };

      foreach (var coin in allCoins) {
        
      }
      return 0;
    }
  }
}
