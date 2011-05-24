using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem21 : Problem {
    public override long Solve() {
      var limit = 10000;
      var amicableNumbers = new List<long>();
      for (int i = 2; i < limit; i++) {
        var sumOfProperDivisors = Factors.CalculateProperDivisors(i).Sum();
        if (sumOfProperDivisors != i && Factors.CalculateProperDivisors(sumOfProperDivisors).Sum() == i) {
          amicableNumbers.AddRange(new List<long> { i, sumOfProperDivisors });
        }
      }
      return amicableNumbers.Distinct().Sum();
    }
  }
}
