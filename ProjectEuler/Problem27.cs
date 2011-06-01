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
    //List<long> primesFound = new List<long>();
    public override long Solve() {
      var positivePrimes = Primes.CalculatePrimesBelow(MAX_COEFF);
      var primes = AddNegativePrimesToList(positivePrimes);
      
      int primesCount;
      var maxPrimesCount = 0;
      long maxACoeff = 0;
      long maxBCoeff = 0;
      foreach(var a in positivePrimes) {
       foreach(var b in primes) {
         primesCount = 0;
         int n = 0;
         while(true) {
            var result = (n * n) + (a * n) + b;
           if (Primes.IsPrime(result)) {
              primesCount++;
            }
            else {
              break;
            }
            n++;
          }
          if (primesCount > maxPrimesCount) {
            maxPrimesCount = primesCount;
            maxACoeff = a;
            maxBCoeff = b;
          }
        }
      }
      Console.WriteLine("Max A Coeff: " + maxACoeff + "Max b coeff: " + maxBCoeff + "primesCount: " + maxPrimesCount);
      return maxACoeff * maxBCoeff;
    }

    List<long> AddNegativePrimesToList(IEnumerable<long> positivePrimes) {
      var primes = new List<long>();
      foreach (var number in positivePrimes) {
        primes.Add(-number);
        primes.Add(number);
      }
      primes.Sort();
      return primes;
    }
  }
}
