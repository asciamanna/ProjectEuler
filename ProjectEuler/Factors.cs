using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

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
      var factors = new List<long> { 1, number };
      for(int i = 2; i < number; i++) {
        if (number % i == 0) factors.Add(i);
      }
      return factors;
    }

    [Obsolete]
    public static List<long> CalculateProperDivisors(long i) {
      return GetFactors(i).Where(f => f != i).ToList();
    }

    [Obsolete]
    public static List<long> CalculateAbundantNumbersBelow(long number) {
      var abundantNumbers = new List<long>();

      for (int i = 1; i < number; i++) {
        if (CalculateProperDivisors(i).Sum() > i) {
          abundantNumbers.Add(i);
        }
      }
      return abundantNumbers;
    }

    public static long SumOfDivisors(long number) {
      long sum = 1;
      int p = 2;
      while (p * p <= number && number > 1) {
        if (number % p == 0) {
          var j = p * p;
          number = number / p;
          while (number % p == 0) {
            j *= p;
            number = number / p;
          }
          sum *= (j - 1);
          sum = sum / (p - 1);
        }
        if (p == 2) p = 3;
        else p += 2;
      }
      if (number>1) sum*=(number+1);
      return sum;
    }

    public static long SumOfProperDivisors(long number) {
      return SumOfDivisors(number) - number;
    }

    public static Dictionary<long, bool> AbundantNumbersBelow(long number) {
      var abundantNumbers = new Dictionary<long, bool>();

      for (int i = 1; i < number; i++) {
        if (SumOfProperDivisors(i) > i) abundantNumbers.Add(i, true);
        else abundantNumbers.Add(i, false);
      }
      return abundantNumbers;
    }
  }
}
