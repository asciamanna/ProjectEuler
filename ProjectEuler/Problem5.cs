using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem5 : Problem {
    //---------------------------------------------
    //2520 is the smallest number that can be divided 
    //by each of the numbers from 1 to 10 without any remainder.
    //What is the smallest positive number that is 
    // evenly divisible by all of the numbers from 1 to 20?
    //-----------------------------------------------

    readonly int lower;
    readonly int upper;

    public Problem5(int lower, int upper) {
      this.lower = lower;
      this.upper = upper;
    }
    public override long Solve() {
      var range = Enumerable.Range(lower, upper - lower + 1);
      for (int i = 1; i < int.MaxValue; i++) {
        if (range.All(rangeNum => i % rangeNum == 0)) return i;
      }
      return 0;
    }
  }
}
