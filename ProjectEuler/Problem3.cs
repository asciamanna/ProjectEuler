using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem3 : Problem {
    readonly long number;
    public Problem3(long number) {
      this.number = number;
    }
    //The prime factors of 13195 are 5, 7, 13 and 29.
    //What is the largest prime factor of the number 600851475143 ?
    public override long Solve() {
      var primeFactors = new List<long>();

      var primes = CalculatePrimes(number);
      return 0;
    }

    bool IsInteger(decimal value) {
      return value % 1 == 0;
    }

    public List<long> CalculatePrimes(long num) {
      var primes = new List<long> { 2 };

      for (long i = 3; i <= num; i += 2) {
        if (IsPrime(i, primes)) primes.Add(i);
      }
      return primes;
    }

    static bool IsPrime(long num, List<long> primesSoFar) {
      bool isPrime = true;

      foreach (long prime in primesSoFar) {
        if ((num % prime) == 0 && prime <= Math.Sqrt(num)) {
          isPrime = false;
          break;
        }
      }
      return isPrime;
    }



  }
}
