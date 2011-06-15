using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem43 : Problem {
    public override long Solve() {
      var primes = Primes.CalculatePrimesBelow(18).ToArray();
      var pandigitals = Pandigitals.GenerateZeroToN(9);
      int primeIndex = 0;
      long sum = 0;
      foreach (var pandigital in pandigitals) {
        if ((ProductOfSubstringIsDivisibleByNumber(pandigital, 1, primes[0]) &&
          ProductOfSubstringIsDivisibleByNumber(pandigital, 2, primes[1]) &&  
          ProductOfSubstringIsDivisibleByNumber(pandigital, 3, primes[2]) && 
          ProductOfSubstringIsDivisibleByNumber(pandigital, 4, primes[3]) && 
        ProductOfSubstringIsDivisibleByNumber(pandigital, 5, primes[4]) && 
          ProductOfSubstringIsDivisibleByNumber(pandigital, 6, primes[5]) && 
          ProductOfSubstringIsDivisibleByNumber(pandigital, 7, primes[6])))
        {
          sum += pandigital;
        }
      }
      return sum;
    }

    bool ProductOfSubstringIsDivisibleByNumber(long pandigital, int index, long divisbleBy) {
      var pandigitalString = pandigital.ToString();
      return (long.Parse(pandigitalString[index].ToString()) * long.Parse(pandigitalString[index + 1].ToString()) *
        long.Parse(pandigitalString[index + 2].ToString()) % divisbleBy == 0);
    }
  }
}
