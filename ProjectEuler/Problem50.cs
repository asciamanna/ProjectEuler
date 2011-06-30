using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  //Takes 9 minutes to run...must be refactored.
  [EulerProblem(50, "Which prime, below one-million, can be written as the sum of the most consecutive primes?")]
  public class Problem50 : Problem {
    int primeBelow;
    public Problem50() : this(1000000) {}
    public Problem50(int primeBelow) {
      this.primeBelow = primeBelow;
    }

    public override long Solve() {
      int longestNumberOfAddends = 0;
      long primeWithLongestSumOfConsecutivePrimes = 0;
      var primes = Primes.CalculatePrimesBelow(primeBelow);
      var maxPrime = primes.Last();

      for (int primeIndex = 0; primeIndex < primes.Count; primeIndex++) {
        int numberOfAddends = 0;
        long sum = 0;
        for (int i = primeIndex; i < primes.Count; i++) {
          sum += primes.ElementAt(i);
          numberOfAddends++;
          if (primes.Contains(sum) && numberOfAddends > longestNumberOfAddends) {
            longestNumberOfAddends = numberOfAddends;
            primeWithLongestSumOfConsecutivePrimes = sum;
          }

          if (sum > maxPrime) break;
        }
      }
      return primeWithLongestSumOfConsecutivePrimes;
    }
  }
}
