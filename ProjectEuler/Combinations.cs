using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  public static class Combinations {
    public static BigInteger NChooseR(int n, int r) {
      if (r > n) throw new ArgumentException("R cannot be greater than N");
      return (EulerMath.Factorial(n)) / (EulerMath.Factorial(r) * (EulerMath.Factorial(n - r)));
    }
  }
}
