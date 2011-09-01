using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  [EulerProblem(56, "Considering natural numbers of the form, a^b, where a, b < 100, what is the maximum digital sum?")]
  public class Problem56 : Problem {
    public override long Solve() {
      long maximumDigitalSum = 0;
      for (int a = 1; a < 100; a++) {
        for (int b = 1; b < 100; b++) {
          BigInteger value = BigInteger.Pow(a, b);
          var digitalSum = CalculateDigitalSum(value);
          if (digitalSum > maximumDigitalSum) maximumDigitalSum = digitalSum;
        }
      }
      return maximumDigitalSum;
    }

    long CalculateDigitalSum(BigInteger number) {
      long sum = 0;
      foreach (var digit in number.ToString()) {
       sum += Int32.Parse(digit.ToString());
      }
      return sum;
    }
  }
}
