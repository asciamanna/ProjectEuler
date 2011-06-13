using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  [EulerProblem(40, "Finding the nth digit of the fractional part of the irrational number.")]
  public class Problem40 : Problem {
    StringBuilder sb = new StringBuilder();

    public override long Solve() {
      for (int i = 1; i <= 1000000; i++) {
        sb.Append(i);
      }

      return GetDigit(1) * GetDigit(10) * GetDigit(100) * GetDigit(1000) *
        GetDigit(10000) * GetDigit(100000) * GetDigit(1000000);
    }

    private int GetDigit(int p) {
      return int.Parse(sb[p - 1].ToString());
    }
  }
}
