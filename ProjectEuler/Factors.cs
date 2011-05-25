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

    public static List<long> CalculateProperDivisors(long i) {
      return GetFactors(i).Where(f => f != i).ToList();
    }

    public static List<long> CalculateAbundantNumbersBelow(long number) {
      var abundantNumbers = new List<long>();

      for (int i = 1; i < number; i++) {
        if (CalculateProperDivisors(i).Sum() > i) {
          abundantNumbers.Add(i);
        }
      }
      return abundantNumbers;
    }

    public static bool IsAbundant(long number) {
      return CalculateProperDivisors(number).Sum() > number;
    }

    //public static long SumOfProperDivisors(long number) {
    //  if (number == 1) return 0;
    //  long sum = 0;
    //  var limit = (long)Math.Sqrt(number);
    //  if (limit * limit == number) {
    //    sum = 1 + limit;
    //    limit--;
    //  }
    //  else sum = 1;

    //  if (number.IsOdd()) {

    //  }

    //}
    
//Function SumOfProperDivisors(n) 
//If n=1 then return 0 else 
//r=floor( n ) 
////first take into account the case that n is a perfect square. 
//if r*r=n then sum=1+r r=r-1 else sum=1 
//if odd(n) then f=3 step=2 else f=2 step=1 
//while f<=r    
//    if n mod f=0 then sum=sum+f+n div f 
//    f=f+step 
//return sum 
//EndFunctio
  }
}
