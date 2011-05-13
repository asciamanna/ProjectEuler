using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem10 : Problem {
    //--------------------------------
    //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    //Find the sum of all the primes below two million.
    //--------------------------------
    readonly long primesBelow;

    public Problem10(long primesBelow) {
      this.primesBelow = primesBelow;
    }
    public override long Solve() {
      return PrimeGenerator.CalculatePrimesBelow(primesBelow).Sum();
    }
  }
}
