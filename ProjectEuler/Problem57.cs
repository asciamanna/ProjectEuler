using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  public class Problem57 : Problem {
    //http://en.wikipedia.org/wiki/Square_root_of_2#Continued_fraction_representation

    public override long Solve() {
      int iterations = 1000;
      BigInteger p = BigInteger.One;
      BigInteger q = BigInteger.One;
      long valuesWithMoreDigitsInNumerator = 0;

      for (int i = 0; i < iterations; i++) {
        var nextPValue = p + new BigInteger(2) * q;
        q = p + q;
        p = nextPValue;
        if (p.NumberOfDigits() > q.NumberOfDigits()) {
          valuesWithMoreDigitsInNumerator++;
        }

        p = nextPValue;
      }
      return valuesWithMoreDigitsInNumerator; 
    }
  }
}
