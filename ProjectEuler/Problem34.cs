using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  [EulerProblem(34, "Find the sum of all numbers which are equal to the sum of the factorial of their digits.")]
  public class Problem34 : Problem {
    public override long Solve() {
       var curiousNumbers = new List<int>();

      for (int i = 11; i < 100000; i++) {
        if (NumberEqualsFactorialOfDigits(i)) {
          curiousNumbers.Add(i);
        }
      }
      return (long)curiousNumbers.Sum();
    }

    public bool NumberEqualsFactorialOfDigits(int num) {
      return num == CalculateFactorialSumOfDigits(num);
    }

    long CalculateFactorialSumOfDigits(int i) {
      BigInteger sum = 0;
      foreach (var digit in i.ToString()) {
        sum += EulerMath.Factorial(long.Parse(digit.ToString()));
      }
      return long.Parse(sum.ToString());
    
    }
  }
}
