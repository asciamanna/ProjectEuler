using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem43 : Problem {
    public override long Solve() {
      var primes = Primes.CalculatePrimesBelow(18).ToArray();
      var pandigitals = Pandigitals.GenerateZeroToN(9);
      long sum = 0;
      foreach (var pandigital in pandigitals) {
        var divisibleByPrime = true;
        for (int i = 0; i < primes.Length && divisibleByPrime; i++) {
          divisibleByPrime = SubstringDivisibleBy(pandigital, i + 1, primes[i]);
        }
        if (divisibleByPrime) {
          sum += pandigital;
        }
      }
      return sum;
    }

    bool SubstringDivisibleBy(long pandigital, int index, long divisbleBy) {
      var pandigitalString = pandigital.ToString().Substring(index, 3);
      return int.Parse(pandigitalString) % divisbleBy == 0;
    }
  }
}
