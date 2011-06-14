using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ProjectEuler {
  public static class Primes {
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

    public static HashSet<long> BuildPrimesLookup(int max) {
      var primeCandidates = new BitArray(max + 1, true);
      var primes = new HashSet<long> { 2 };

      for (int i = 3; i < max; i += 2) {
        if (primeCandidates[i]) {
          if (i < Math.Sqrt(max)) {
            for (int j = i * i; j <= max; j += i * 2)
              primeCandidates[j] = false;
          }
          primes.Add((long)i);
        }
      }
      return primes;
    }

    public static IEnumerable<long> CalculatePrimesBelow(int max) {
      var primeCandidates = new BitArray(max + 1, true);
      var primes = new List<long> { 2 };
      for (int i = 3; i < max; i += 2) {
        if (primeCandidates[i]) {
          if (i < Math.Sqrt(max)) {
            for (int j = i * i; j <= max; j += i*2)
              primeCandidates[j] = false;
          }
          primes.Add((long)i);
        }
      }
      return primes;
    }

    public static long CalculateNthPrime(int n) {
       var primes = new List<long> { 2 };
       var count = 1;

      for (long i = 3; count < n; i += 2) {
        if (IsPrime(i, primes)) {
          primes.Add(i);
          count++;
        }
      }
      return primes.Last();
    }

    public static bool IsPrime(long number) {
      if (number < 1) return false;

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

    public static List<long> CalculatePrimeFactors(long number) {
      var primeFactors = new List<long>();
      for (long i = number; i > 1; i--) {
        if(IsPrime(i) && number % i == 0) {
          primeFactors.Add(i);
          primeFactors.AddRange(CalculatePrimeFactors(number / i));
          break;
        }
      }
      return primeFactors;
    }
  }
}
