using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public static class ExtensionMethods {
    public static bool IsEven(this long n) {
      return(n & 1) == 0;
    }
  }
}

