using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem58 : Problem {
    decimal numberOfPrimes = 0;
    decimal numberOfCornerNumbers = 1;
    int currentCornerNumber = 1;

    public override long Solve() {
      int sideLength = 1;

      while (RatioOfPrimes >= 0.1M || numberOfPrimes == 0) {
        for (int i = 1; i <= 4; i++) {
          var primetoCheck = currentCornerNumber += 2 * sideLength;
          if (Primes.IsPrime(primetoCheck)) {
            numberOfPrimes++;
          }
          numberOfCornerNumbers++;
        }
        sideLength++;
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
