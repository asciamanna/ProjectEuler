using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  //Takes 9 minutes to run...must be refactored.
  [EulerProblem(50, "Which prime, below one-million, can be written as the sum of the most consecutive primes?")]
  public class Problem50 : Problem {
    int primeBelow;

    public Problem50(int primeBelow = 1000000) {
      this.primeBelow = primeBelow;
    }
    public override long Solve() {
      int longestNumberOfAddends = 0;
      long primeWithLongestSumOfConsecutivePrimes = 0;
      var primes = Primes.CalculatePrimesBelow(primeBelow).ToList();
      var maxPrime = primes.Max();
      
      for (int primeIndex = 0; primeIndex < primes.Count; primeIndex++) {
        int numberOfAddends = 0;
        long sum = 0;
        for (int i = primeIndex; i < primes.Count; i++) {
          sum += primes[i];
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

    //public override long Solve() {
    //  var longestSum = 0;
    //  long primeWithLongestSumOfConsecutivePrimes = 0;

    //  var primes = Primes.CalculatePrimesBelow(primeBelow);
    //  var primesList = primes.ToList();

    //  foreach (var prime in primes) {
    //    long difference = prime;
    //    var currentSum = 0;
    //    for (int i = 0; i < primesList.Count; i++) {
    //      difference -= primesList[i];
    //      if (difference > 0) {
    //        currentSum++;
    //      }
    //      else if (difference == 0) {
    //        if (currentSum > longestSum) {
    //          longestSum = currentSum;
    //          primeWithLongestSumOfConsecutivePrimes = prime;
    //        }
    //      }
    //      else {
    //        break;
    //      }
    //    }
    //  }
    //  return primeWithLongestSumOfConsecutivePrimes;
    //}
  }
}
