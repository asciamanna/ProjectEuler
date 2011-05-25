using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public static class ExtensionMethods {
    public static bool IsEven(this long n) {
      return(n & 1) == 0;
    }

    public static bool IsOdd(this long n) {
      return (n & 1) != 0;
    }

    public static int RoundDownToTens(this int n) {
      if (n > 10 && n < 100)
      return ((int)n / 10) * 10;
      return 0;
    }
  }
}

