using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem12 : Problem {
    readonly int moreThanNumberOfDivisors;

    public Problem12() : this(500) { }

    public Problem12(int moreThanNumberOfDivisors) {
      this.moreThanNumberOfDivisors = moreThanNumberOfDivisors;
    }
    public override long Solve() {
      for (int i = 1; i < int.MaxValue; i++) {
        var triangleNumber = CalculateNthTriangleNumber(i);
        if (CalculateDivisors(triangleNumber).Count > moreThanNumberOfDivisors) {
          return triangleNumber;
        }
      }
      return 0;
    }

    public static long CalculateNthTriangleNumber(int n) {
      return Enumerable.Range(1, n).Sum();
    }

    List<long> CalculateDivisors(long triangleNumber) {
      var divisors = new List<long>();

      for (long i = 1; i < (long)Math.Sqrt(triangleNumber); i++) {
        if (triangleNumber % i == 0) {
          divisors.Add(i);
          divisors.Add(triangleNumber / i);
        }
      }
      return divisors;
    }

    //int CalculateNumberOfDivisors(long triangleNumber) {
    //  var divisors = new List<long>();

    //  var primeFactors = PrimeGenerator.CalculatePrimeFactors(triangleNumber);
    //  divisors = new List<long>(primeFactors);
    //  int i = 1; 
    //  while(i < primeFactors.Count) {
    //    divisors.Add(primeFactors[0] * primeFactors[i]);
    //    divisors.Add(primeFactors[0] * primeFactors[i] * primeFactors[i + 1]);
    //    i++;
    //  }
    //  return 0;
    //}
  }
}
