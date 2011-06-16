using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem43 : Problem {
    //12.5 seconds without filtering out invalid pandigitals.
    //filtering inputs:
    //Filter out pandigitals where d6 is not divisble by 5: 11.4 seconds
    public override long Solve() {
      var primes = Primes.CalculatePrimesBelow(18).ToArray();
      var pandigitals = Pandigitals.GenerateZeroToN(9);

      long sum = 0;
      foreach (var pandigital in pandigitals) {
        if (PossibleSubstringDivisibleByPrime(pandigital)) {
          var divisibleByPrime = true;
          for (int i = 0; i < primes.Length && divisibleByPrime; i++) {
            divisibleByPrime = SubstringDivisibleBy(pandigital, i + 1, primes[i]);
          }
          if (divisibleByPrime) {
            sum += pandigital;
          }
        }
      }
      return sum;
    }

    bool SubstringDivisibleBy(long pandigital, int index, long divisbleBy) {
      var pandigitalString = pandigital.ToString().Substring(index, 3);
      return int.Parse(pandigitalString) % divisbleBy == 0;
    }

    bool PossibleSubstringDivisibleByPrime(long pandigital) {
      var d6 = int.Parse(pandigital.ToString()[5].ToString());
      if (d6 != 0 && d6 != 5) return false;

      var d4 = int.Parse(pandigital.ToString()[3].ToString());
      if (d4.IsOdd()) return false;
      return true;
    }
  }
}
