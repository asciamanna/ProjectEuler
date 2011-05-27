using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
 public class Problem7 : Problem {
   //------------------------------
   //By listing the first six prime numbers: 
   //2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
   //What is the 10001st prime number?
   //------------------------------
   //First attempt: finding all prime numbers less than the one we are looking for: 0.89 seconds.

   readonly int whichPrime;
   public Problem7() : this(10001) { }

   public Problem7(int whichPrime) {
     this.whichPrime = whichPrime;
   }
   public override long Solve() {
     return Primes.CalculateNthPrime(whichPrime);
   }
 }
}
