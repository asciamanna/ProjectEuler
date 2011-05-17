using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem3 : Problem {
    //-------------------------------------------------------------
    //The prime factors of 13195 are 5, 7, 13 and 29.
    //What is the largest prime factor of the number 600851475143 ?
    //-------------------------------------------------------------
    readonly long number;

    public Problem3(long number) {
      this.number = number;
    }

    public override long Solve() {
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
  }
}
