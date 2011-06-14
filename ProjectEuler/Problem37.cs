using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem37 : Problem {
    //http://en.wikipedia.org/wiki/Truncatable_prime

    public override long Solve() {
      long sum = 0;
      var primes = Primes.BuildPrimesLookup(1000000);

      foreach(var prime in primes) {
        bool truncatable = true;
        if (PossibleTruncatablePrime(prime)) {
          var leftToRightTruncate = new Truncate(prime, TruncateMethod.LeftToRight);
          while (leftToRightTruncate.CanTruncate()) {
            if (!primes.Contains(leftToRightTruncate.NextValue())) {
              truncatable = false;
              break;
            }
          }

          var rightToLeftTruncate = new Truncate(prime, TruncateMethod.RightToLeft);
          while (rightToLeftTruncate.CanTruncate()) {
            if (!primes.Contains(rightToLeftTruncate.NextValue())) {
              truncatable = false;
              break;
            }
          }
          if (truncatable) sum += prime;
        }
      }
      return sum;
    }


    bool PossibleTruncatablePrime(long prime) {
      var primeString = prime.ToString();
      //single digit primes aren't included.
      if (primeString.Length == 1) return false;
      //any prime containing a 0 is not truncatable
      if (primeString.Contains('0')) return false;
      return primeString.All(ps => int.Parse(ps.ToString()).IsOdd() || ps == '2');
    }
  }
}
