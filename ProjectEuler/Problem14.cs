using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem14 : Problem {
    readonly long startingNumberLimit;
    long longestChain, numberThatCreatesLongestChain = 0;

    public Problem14(long startingNumberLimit) {
      this.startingNumberLimit = startingNumberLimit;
    }

    public override long Solve() {
      for (long i = 1; i < startingNumberLimit; i++) {
        var sequence = CalculateSequence(i);
        if (longestChain < sequence.Count) {

          longestChain = sequence.Count;
          numberThatCreatesLongestChain = i;
        }
      }
      return numberThatCreatesLongestChain;
    }

    public static List<long> CalculateSequence(long n) {
      var sequence = new List<long> { n };
      long result = n;
      while (result > 1) {
        result = result.IsEven() ? EvenSequenceIteration(result) : OddSequenceIteration(result);
        sequence.Add(result);
      }
      return sequence;
    }

    static long EvenSequenceIteration(long n) {
      return n / 2;
    }

    static long OddSequenceIteration(long n) {
      return 3 * n + 1;
    }

   // public long SolveWithRecursion() {
   //   Collatz = (long n) => {
   //     if (n == 1) return 1;
   //     long nextTerm = n.IsEven() ? n / 2 : 3 * n + 1;
   //     return Collatz(nextTerm) + 1;
   //   };

   //   for (long i = 0; i < startingNumberLimit; i++) {
   //     var length = Memoize(Collatz, i);
   //     if (length > longestChain) {
   //       longestChain = length;
   //       numberThatCreatesLongestChain = i;
   //     }
   //   }
   //   Console.WriteLine("Answer is (Number that creates the longest chain): " + numberThatCreatesLongestChain);
   //   return numberThatCreatesLongestChain;
   // }

   // Func<long, long> Collatz = null;

   //long Memoize(Func<long, long> func, long arg) {
   //   long result;
   //   if(cache.TryGetValue(arg, out result)) {
   //     return result;
   //   }
   //   result = func(arg);
   //   cache.Add(arg, result);
   //   return result;
   // }
  }
}
