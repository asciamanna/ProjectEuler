using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
 [EulerProblem(41, "What is the largest n-digit pandigital prime that exists?")]
 public class Problem41 : Problem {
   public override long Solve() {
     Primes.BuildPrimesLookup(987654322);
     return 0;
   }
 }
}
