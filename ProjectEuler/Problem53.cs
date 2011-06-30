using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(53, "How many values of C(n,r), for 1 ≤ n ≤ 100, exceed one-million?")]
  public class Problem53 : Problem {
    public override long Solve() {
      long valuesThatExceedOneMillion = 0;

      var nRange = Enumerable.Range(1, 100);
      foreach (var n in nRange) {
        for (int r = 1; r <= n; r++) {
          var result = Combinations.NChooseR(n, r);
          if (result > 1000000) valuesThatExceedOneMillion++;
        }
      }
      return valuesThatExceedOneMillion;
    }
  }
}
