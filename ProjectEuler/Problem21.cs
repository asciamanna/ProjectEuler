using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem21 : Problem {
    public override long Solve() {
      var limit = 10000;
      var amicablePairs = new List<long>();
      for (int i = 2; i < limit; i++) {
        var sumOfProperDivisors = Factors.CalculateProperDivisors(i).Sum();
        if (sumOfProperDivisors != i && Factors.CalculateProperDivisors(sumOfProperDivisors).Sum() == i) {
          amicablePairs.AddRange(new List<long> { i, sumOfProperDivisors });
        }
      }
      return amicablePairs.Distinct().Sum();
    }
  }
}
