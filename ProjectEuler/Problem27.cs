using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(27, "Find a quadratic formula that produces the maximum number of primes for consecutive values of n.")]
  public class Problem27 : Problem {
    //b must be prime
    const int MAX_COEFF = 1000;
    public override long Solve() {
      var bRange = Primes.CalculatePrimesBelow(MAX_COEFF);
      var aRange = Enumerable.Range(-999, 1999);

      long maxPrimesCount = 0;
      long maxACoeff = 0;
      long maxBCoeff = 0;
      foreach (var b in bRange) {
       foreach(var a in aRange) {
         long n = 0;
         while (Primes.IsPrime((n*n) + (a*n) + b)) {
           n++;
          }
          if (n > maxPrimesCount) {
            maxPrimesCount = n;
            maxACoeff = a;
            maxBCoeff = b;
          }
        }
      }
      return maxACoeff * maxBCoeff;
    }
  }
}
