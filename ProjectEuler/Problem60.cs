using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem60 : Problem {
    public override long Solve() {
      long foundPrime = 0;
      var primes = Primes.CalculatePrimesBelow(100000);
      foreach (var first in primes) {
        foreach (var second in primes) {
          if (second <= first) continue;
          //if (Primes.IsPrime(Concat(first, second)) && Primes.IsPrime(Concat(second, first))) {
          //  foreach (var third in primes) {
          //    if (third <= second) continue;
          //    if (Primes.IsPrime(Concat(
          //  }
          //}
        }
      }
      return 0;
      //return setOfFour.Aggregate(foundPrime, (totalSum, s) => totalSum += s);
    }

    long Concat(long n1, long n2) {
      return long.Parse(string.Format("{0}{1}", n1, n2));
    }
  }
}
