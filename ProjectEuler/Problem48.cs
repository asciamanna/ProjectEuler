using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  public class Problem48 : Problem {
    public override long Solve() {
      var sum = new BigInteger();
      for (int i = 1; i <= 1000; i++) {
        sum += BigInteger.Pow(i, i);
      }
      var bigString = sum.ToString();
      return long.Parse(bigString.Substring(bigString.Length - 10, 10));
    }
  }
}
