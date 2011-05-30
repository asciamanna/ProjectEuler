using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(10, "Find the sum of all the primes below two million.")]
  public class Problem10 : Problem {
    //--------------------------------
    //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    //Find the sum of all the primes below two million.
    //--------------------------------
    readonly int primesBelow;

    public Problem10() : this(2000000) { }
    public Problem10(int primesBelow) {
      this.primesBelow = primesBelow;
    }
    public override long Solve() {
      return Primes.CalculatePrimesBelow(primesBelow).Sum();
    }
  }
}
