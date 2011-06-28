using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(52, "Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits in some order.")]
  public class Problem52 : Problem {
    public override long Solve() {
      for(int number = 100000; number < int.MaxValue; number++) {
        //six is redundant so we can skip it for the check. if divisible by 3 will be divisible by 6.
          if (ContainsSameDigits(number, number*2) && ContainsSameDigits(number, number*3) &&
            ContainsSameDigits(number, number*4) && ContainsSameDigits(number, number*5)) {
            return number;
          }
      }
      throw new Exception("Cannot find integer below " + int.MaxValue);
    }

    public bool ContainsSameDigits(long num1, long num2) {
      var set1 = new SortedSet<char>(num1.ToString().ToList());
      var set2 = new SortedSet<char>(num2.ToString().ToList());
      return set1.SetEquals(set2);
    }
  }
}
