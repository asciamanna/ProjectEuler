using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  public static class EulerMath {
    public static BigInteger Factorial(long n) {
      if (n == 1) return 1;
      return n * Factorial(n - 1);
    }

    //Implementation of the Euclidean Algorithm
    public static int GreatestCommonFactor(int num1, int num2) {
      if ( num2 != 0 ) return GreatestCommonFactor(num2, num1 % num2); 
      return Math.Abs(num1);

    }
  }
}
