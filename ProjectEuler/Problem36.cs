using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem36 : Problem {
    long max = 1000000;

    public override long Solve() {
      long sum = 0;
      for (int i = 1; i < max; i++) {
        if (i.IsPalindromic() && i.ToBinary().IsPalindromic()) sum += i;
      }
      return sum;
    }
  }
}
