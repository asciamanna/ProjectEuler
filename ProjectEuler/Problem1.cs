using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem1 : Problem {
    //----------------------------------------------------------
    //find the sum of all of the multiples of 3 or 5 below 1000;
    //answer: 233168
    //----------------------------------------------------------

    readonly int belowNumber;

    public Problem1(int belowNumber) {
      this.belowNumber = belowNumber;
    }

    public override long Solve() {
      var sum = 0;

      for (int i = belowNumber - 1; i > 0; i--) {
        if (IsMultipleOf(i, 3) || IsMultipleOf(i, 5)) sum += i;
      }
      return sum;
    }

    static bool IsMultipleOf(int number, int multipleOf) {
      return number % multipleOf == 0;
    }
  }
}
