using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//brute force takes just over a minute.  need to come up with
//a better way that's not brute force.
namespace ProjectEuler {
  public class Problem60 : Problem {
    public override long Solve() {
      long smallestSum = 0;
      var primes = Primes.CalculatePrimesBelow(10000);
      foreach (var first in primes) {
        foreach (var second in primes) {

          if (second <= first) continue;
          if (Primes.IsPrime(Concat(first, second)) && Primes.IsPrime(Concat(second, first))) {
          
            foreach (var third in primes) {
              if (third <= second) continue;
            
              if (Primes.IsPrime(Concat(first, third)) && Primes.IsPrime(Concat(third, first))
                && Primes.IsPrime(Concat(second, third)) && Primes.IsPrime(Concat(third, second)))
              
                foreach (var fourth in primes) {
                  if (fourth <= third) continue;
                  if (Primes.IsPrime(Concat(first, fourth)) && Primes.IsPrime(Concat(fourth, first))
                    && Primes.IsPrime(Concat(second, fourth)) && Primes.IsPrime(Concat(fourth, second))
                    && Primes.IsPrime(Concat(third, fourth)) && Primes.IsPrime(Concat(fourth, third)))
                
                    foreach (var fifth in primes) {
                      if (fifth <= fourth) continue;
                      if (Primes.IsPrime(Concat(first, fifth)) && Primes.IsPrime(Concat(fifth, first))
                        && Primes.IsPrime(Concat(second, fifth)) && Primes.IsPrime(Concat(fifth, second))
                        && Primes.IsPrime(Concat(third, fifth)) && Primes.IsPrime(Concat(fifth, third))
                        && Primes.IsPrime(Concat(fourth, fifth)) && Primes.IsPrime(Concat(fifth, fourth))) {
                        Console.WriteLine("1: {0} 2: {1} 3: {2} 4: {3} 5: {4}", first, second, third, fourth, fifth);
                         var sum = new List<long> { first, second, third, fourth, fifth }.Sum();
                         if (sum < smallestSum || smallestSum == 0) {
                           smallestSum = sum;
                         }
                      }
                    }
                }
            }
          }
        }
      }

      return smallestSum;
    }

    long Concat(long n1, long n2) {
      return long.Parse(string.Format("{0}{1}", n1, n2));
    }
  }
}
