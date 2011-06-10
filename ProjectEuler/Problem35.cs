using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem35 : Problem {
    int max;
    public Problem35() : this (1000000) { }

    public Problem35(int max) {
      this.max = max;
    }
    public override long Solve() {
      long circularPrimeCount = 0;
      var primesLookup = Primes.BuildPrimesLookup(max);
      foreach (var prime in primesLookup.Keys) {
        if (PossibleCircularPrime(prime)) {
          var permutations = Permutations.GenerateForNumbers(prime);
          if (permutations.All(p => primesLookup.ContainsKey(p))) circularPrimeCount++;
        }
      }
      return circularPrimeCount;
    }

    bool PossibleCircularPrime(long prime) {
      var primeString = prime.ToString();
      return primeString.All(ps => int.Parse(ps.ToString()).IsOdd() || ps == '2');
    }
  }
}
