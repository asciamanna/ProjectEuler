using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(5,@"What is the smallest positive number that is evenly divisble by all 
numbers from 1 to 20")]
  public class Problem5 : Problem {
    //---------------------------------------------
    //2520 is the smallest number that can be divided 
    //by each of the numbers from 1 to 10 without any remainder.
    //What is the smallest positive number that is 
    // evenly divisible by all of the numbers from 1 to 20?
    //-----------------------------------------------
    //brute force (loop from 1 to max int until the answer is found): 69.172 seconds
    //NOTES: 
    //for number to be divisible by 2 and 5 must end in 0.
    //Try skipping by 10 each time through loop and start at upper limit
    //With those optimizations: 7.805 seconds

    //next optimization.  skip by the upper limit.
    //With these optimizations: 4.198 seconds

    //TODO: use prime factors to solve...

    readonly int lower;
    readonly int upper;
    public Problem5() : this(1, 20) { }

    public Problem5(int lower, int upper) {
      this.lower = lower;
      this.upper = upper;
    }
    public override long Solve() {
      var range = Enumerable.Range(lower, upper - lower + 1);
      for (int i = upper; i < int.MaxValue; i+=upper) {
        if (range.All(rangeNum => i % rangeNum == 0)) return i;
      }
      return 0;
    }
  }
}
