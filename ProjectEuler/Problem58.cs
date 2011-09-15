using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem58 : Problem {
    decimal numberOfPrimes = 0;
    decimal numberOfCornerNumbers = 1;
    
    public override long Solve() {
      int currentCornerNumber = 1;
      int sideLength = 1;
      int spiral = 1;

      while (RatioOfPrimes >= 0.1M || numberOfPrimes == 0) {
        for (int i = 1; i <= 4; i++) {
          var primetoCheck = currentCornerNumber += 2 * spiral;
          if (Primes.IsPrime(primetoCheck)) {
            numberOfPrimes++;
          }
          numberOfCornerNumbers++;
        }
        sideLength+=2;
        spiral++;
      }
      return sideLength;
    }

    decimal RatioOfPrimes {
      get {
        return numberOfPrimes / numberOfCornerNumbers;
      }
    }
  }
}
