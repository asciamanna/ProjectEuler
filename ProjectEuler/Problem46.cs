using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(46, "What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?")]
  public class Problem46 : Problem {

    public override long Solve() {
      var primesBelow = 10000;
      var primes = Primes.CalculatePrimesBelow(primesBelow);
      var oddComposites = BuildOddComposites(primes);
      foreach (var oddComposite in oddComposites) {
        bool found = false;
        for (int i = 0; i < primes.Count && primes.ElementAt(i) < oddComposite && !found; i++) {
          long numberToBeSquared = 1;
          while (numberToBeSquared < (oddComposite * oddComposite * 2)) {
            if (oddComposite == primes.ElementAt(i) + (2 * numberToBeSquared * numberToBeSquared)) {
              found = true;
            }
            numberToBeSquared++;
          }
        }
        if (!found) return oddComposite; 
      }
      throw new Exception("Could not find an odd composite below " + primesBelow);
    }

    private HashSet<long> BuildOddComposites(HashSet<long> primes) {
      var oddComposites = new HashSet<long>();
      for (int i = 33; i < primes.Max(); i+=2) {
        if (!primes.Contains(i)) oddComposites.Add(i);
      }
      return oddComposites;
    }
  }
}
