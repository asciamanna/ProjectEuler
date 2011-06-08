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
    /*http://www.algorithmist.com/index.php/Coin_Change
     * Coin Change algorithm:
     * C(N,m) = C(N,m - 1) + C(N - Sm,m)
     * N = integer value trying to be found.
     * m = index of list of coins
     * base cases:
     * C(N,m) = 1,N = 0
     * C(N,m) = 0,N < 0
     * C(N,m) = 0, N >= 1, m <=0
     */
    List<BritishCoins> allCoins = new List<BritishCoins> { BritishCoins.OnePence, BritishCoins.TwoPence, BritishCoins.FivePence,
                                              BritishCoins.TenPence, BritishCoins.TwentyPence, BritishCoins.FiftyPence,
                                              BritishCoins.OnePound, BritishCoins.TwoPound };
    int amountToFind;

    public Problem31()
      : this(200) { }

    public Problem31(int amountToFind) {
      this.amountToFind = amountToFind;
    }

    public override long Solve() {
      return CountCombinations(amountToFind, allCoins.Count - 1);
    }

    long CountCombinations(int n, int m) {
      if (n == 0) return 1;
      if (n < 0) return 0;
      if (m < 0 && n >= 1) return 0;
        
      return CountCombinations(n - (int)allCoins[m], m) + CountCombinations(n, m - 1);
    }
  }
}
