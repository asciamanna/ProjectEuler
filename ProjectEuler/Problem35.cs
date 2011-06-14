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
      var primesLookup = Primes.CalculatePrimesBelow(max);
      foreach (var prime in primesLookup) {
        if (PossibleCircularPrime(prime)) {
          var rotations = Permutations.GenerateNumberRotations(prime);
          if (rotations.All(p => primesLookup.Contains(p))) circularPrimeCount++;
        }
      }
      return circularPrimeCount;
    }

    bool PossibleCircularPrime(long prime) {
      if (prime < 10) return prime.IsOdd() || prime == 2;

      var primeString = prime.ToString();
      return primeString.All(ps => int.Parse(ps.ToString()).IsOdd());
    }
  }
}
