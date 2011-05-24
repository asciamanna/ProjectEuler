using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public static class Factors {
    
    public static long LargestPrimeFactor(long number) {
      //start at sqrt of number.
      var limit = (long)Math.Sqrt(number);
      long largestPrimeFactor = 0;

      for (long i = limit; i > 0; i--) {
        if (number % i == 0 && Primes.IsPrime(i)) {
          largestPrimeFactor = i;
          break;
        }
      }
      return largestPrimeFactor;
    }

    public static List<long> GetFactors(long number) {
      var factors = new List<long>();
      for(int i = 1; i <= number; i++) {
        if (number % i == 0) factors.Add(i);
      }
      return factors;
    }

    public static List<long> CalculateProperDivisors(long i) {
      return GetFactors(i).Where(f => f != i).ToList();
    }
  }
}
