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
  }
}
