using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public static class PrimeGenerator {
    public static List<long> CalculatePrimesBelow(long primesBelow) {
      var primes = new List<long> { 2 };

      for (long i = 3; i <= primesBelow; i += 2) {
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

    public static long CalculateNthPrime(int n) {
       var primes = new List<long> { 2 };
       var count = 1;

      for (long i = 3; i <= long.MaxValue && count < n; i += 2) {
        if (IsPrime(i, primes)) {
          primes.Add(i);
          count++;
        }
      }
      return primes.Last();
    }

    public static bool IsPrime(long number) {
      if ((number & 1) == 0) {
        return (number == 2);
      }

      long limit = (long)Math.Sqrt(number);

      for (long i = 3; i <= limit; i += 2) {
        if ((number % i) == 0) {
          return false;
        }
      }
      return true;
    }
  }
}
