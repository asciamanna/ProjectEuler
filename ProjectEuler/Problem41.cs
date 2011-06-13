using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
 [EulerProblem(41, "What is the largest n-digit pandigital prime that exists?")]
 public class Problem41 : Problem {
   public override long Solve() {
     for (int i = 9; i > 0; i--) {
       var pandigitals = Pandigitals.Generate(i).OrderByDescending(p => p);
       foreach (var pandigital in pandigitals) {
         if (Primes.IsPrime(pandigital)) return pandigital;
       }
     }
     return 0;
   }
 }
}
