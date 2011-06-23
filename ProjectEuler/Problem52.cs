using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(52, "Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits in some order.")]
  public class Problem52 : Problem {
    public override long Solve() {
     // var range = Enumerable.Range(1, int.MaxValue - 1);
      var sameDigitsAsNumber = true;
      //foreach (var number in range) {
      for(long number = 100000; number < long.MaxValue; number++) {
        for (int i = 2; i < 7; i++) {
          if (!ContainsSameDigitsAsNumber(number, number * i)) {
            sameDigitsAsNumber = false;
            break;
          }
        }
        if (sameDigitsAsNumber) return number;
      }
      throw new Exception("Cannot find integer below " + int.MaxValue);
    }

    public bool ContainsSameDigitsAsNumber(long num1, long num2) {
      var numString1 = num1.ToString();
      var numString2 = num2.ToString();
      return numString1.Length == numString2.Length && new String(numString1.Union(numString2).ToArray()).Length == numString2.Length;
    }
  }
}
