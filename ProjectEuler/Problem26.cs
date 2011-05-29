using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Numerics;

namespace ProjectEuler {
  public class Problem26 : Problem {
    // http://en.wikipedia.org/wiki/Repeating_decimal#Cyclic_numbers
    // using Fermat's little theorem
    //1/d has a cycle of n digits if (10^n)−1 mod d = 0 for prime d
    //furthermore, d can only yield up to d-1 repeating decimal digits.
    readonly int maxDenominator;
    IEnumerable<long> primes;
    public Problem26() : this(1000) { }

    public Problem26(int maxDenominator) {
      this.maxDenominator = maxDenominator;
      primes = Primes.CalculatePrimesBelow(maxDenominator);
    }

    //1/d has a cycle of n digits if (10^n)−1 mod d = 0 for prime d
    public override long Solve() {
      long maxCycleLength = 0, denominatorWithMaxCycleLength = 0;
      foreach (var denominator in primes) {
        var cycleLength = FindRecurringCycleLength(denominator);
        if (cycleLength > maxCycleLength) {
          maxCycleLength = cycleLength;
          denominatorWithMaxCycleLength = denominator;
        }
      }
      return denominatorWithMaxCycleLength;
    }

    public long FindRecurringCycleLength(long denominator) {
      //denominators divisble by 2 or 5 (coprime to 10) 
      //won't create cyclical decimals.
      if (denominator % 2 == 0 || denominator % 5 == 0) return 0;
      int n = 1;
      if (primes.Contains(denominator)) {
        while((BigInteger.Pow(10, n) - 1) % denominator != BigInteger.Zero) {
          n += 1;
          if (denominator - n == 1) break;
        }
      }
      return n;
    }
    //NOTE: cycle detection using tortoise and hare won't work due to the
    //limited precision with decimals in C#.

    //public override long Solve() {
    //  var range = Enumerable.Range(2, maxDenominator -1);
    //  int longestRecurringCycle = 0;
    //  int denominatorWithLongestRecurringCycle = 0;

    //  foreach (var denominator in range) {
    //    decimal unitFraction = (decimal) 1 / denominator;
    //    int currentCycle = FindRecurringCycleLength(unitFraction);
    //    Console.WriteLine("Denominator" + denominator + " Decimal: " + unitFraction + " Cycle Length: " + currentCycle);

    //    if (currentCycle > longestRecurringCycle) {
    //      denominatorWithLongestRecurringCycle = denominator;
    //      longestRecurringCycle = currentCycle;
    //    }
    //  }
    //  return denominatorWithLongestRecurringCycle;
    //}

    //public static int FindRecurringCycleLength(decimal unitFraction) {
    //  var decimalPart = unitFraction.ToString().Split('.').ToList()[1];
    //  var values = decimalPart.ToList().Select(c => int.Parse(c.ToString())).ToList();
    //  Func<int, int> f = (int i) => { return ++i; };
    //  if (values.Count < 3) return 0;

    //  var tortoise = f(0);
    //  var hare = f(f(0));

    //  while (values[tortoise] != values[hare]) {
    //    if (values.Count - 1 < tortoise + 1 || values.Count - 1 < hare+2) return 0;
    //    tortoise = f(tortoise);
    //    hare = f(f(hare));
    //  }
    //  //mu is distance from start to beginning of first cycle
    //  int mu = 0;
    //  hare = tortoise;
    //  tortoise = 0;
    //  while (values[tortoise] != values[hare]) {
    //    tortoise = f(tortoise);
    //    hare = f(hare);
    //    mu += 1;
    //  }

    //  var firstValueOfCycle = values[mu];
    //  int lengthOfCycle = 1;
    //  int j = mu + 1;
    //  while (values[mu] != values[j]) {
    //    ++j;
    //    ++lengthOfCycle;
    //  }
    //  return lengthOfCycle;
    //}
  }
}
