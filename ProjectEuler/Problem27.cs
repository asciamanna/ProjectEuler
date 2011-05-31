using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(27, "Find a quadratic formula that produces the maximum number of primes for consecutive values of n.")]
  public class Problem27 : Problem {
    //b must be prime
    //a must be odd to yield prime.
    const int MAX_COEFF = 1000;
    List<long> primesFound = new List<long>();
    public override long Solve() {
      var primes = Primes.CalculatePrimesBelow(MAX_COEFF);
      int primesCount;
      var maxPrimesCount = 0;
      long maxACoeff = 0;
      long maxBCoeff = 0;
      for(int a = -999; a < MAX_COEFF; a+=2) {
       foreach(var b in primes) {
         primesCount = 0;
         int n = 0;
         while(true) {
            var result = (n * n) + (a * n) + b;
            if (primesFound.Contains(result)) primesCount++;
            else if (Primes.IsPrime(result)) {
              primesFound.Add(result);
              primesCount++;
            }
            else break;
            n++;
          }
          if (primesCount > maxPrimesCount) {
            maxPrimesCount = primesCount;
            maxACoeff = a;
            maxBCoeff = b;
          }
        }
      }
      return maxACoeff * maxBCoeff;
    }
  }
}
